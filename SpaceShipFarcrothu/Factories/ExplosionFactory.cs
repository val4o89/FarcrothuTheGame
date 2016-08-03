﻿namespace SpaceShipFartrothu.Factories
{
    using System.Collections.Generic;
    using Effects;
    using Interfaces;

    public static class ExplosionFactory
    {
        public static void CreateExplosion(IRepository<IExplosion> explosions, List<IGameObject> entityList)
        {
            foreach (var entity in entityList)
            {
                if (!entity.IsVisible)
                {
                    var newExplosion = new Explosion(entity.Position);
                    explosions.AddEntity(newExplosion);
                }
            }

            //for (int i = 0; i < explosions.GetCount(); i++)
            //{
            //    if (!explosions.GetAll()[i].IsVisible)
            //    {
            //        explosions.RemoveAt(i);
            //        i--;
            //    }
            //}
        }
    }
}
