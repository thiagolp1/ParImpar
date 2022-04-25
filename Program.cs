int numero;
String paridade;

Console.Write("Digite um numero: ");
numero = Convert.ToInt32(Console.ReadLine());

paridade = (numero % 2) == 0 ? "par" : "impar";

Console.WriteLine($"{numero} e {paridade}");