using System;

namespace arancia
{	
	/// <summary>
	/// Main class.
	/// </summary>
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("Hola ");
			Console.WriteLine("Mundo!");

			Console.WriteLine("What is your name: ");

			String name = Console.ReadLine();

			Console.Write("Buenos Dias, ");
			Console.Write(name);
		}
	}
}
