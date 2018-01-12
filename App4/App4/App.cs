using System;
using App4.Helpers;
using App4.Models;
using App4.Services;

namespace App4
{
    public class App
    {

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}
