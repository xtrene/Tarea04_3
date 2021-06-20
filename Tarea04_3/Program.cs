using System;

namespace Tarea04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu edad: ");
            string edad = Console.ReadLine();

            Console.WriteLine("Te llamas {0} y tienes {1} años.", nombre, edad);

            Console.ReadKey();
        }
    }
}
