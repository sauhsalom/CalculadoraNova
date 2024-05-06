namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, res = 0;
            string op;

            Inicio:
            Console.WriteLine("Número 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Número 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Operação: [+, -, x, /]");
            op = Console.ReadLine();

            switch (op)
            {
                case "+":
                 res =   num1 + num2;
                    break;
                case "-":
                 res =   num1 - num2;
                    break;
                case "x":
                 res =   num1* num2;
                    break;
                case "/":
                 res =   num1 / num2;
                    break;
                default:
                    Console.WriteLine("Ocorreu um erro!");
                    break;
            }

            Console.WriteLine(num1 + " " + op + " " + num2 + " = " + res);
            Console.ReadKey();
            Console.Clear();
            goto Inicio;

        }
    }
}
