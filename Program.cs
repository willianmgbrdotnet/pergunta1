using System;

namespace Pegunta1;

class Program
{
    /*Observe o trecho de código abaixo:
    int INDICE = 13, SOMA = 0, K = 0;

    enquanto K < INDICE faça
    {
        K = K + 1;

        SOMA = SOMA + K;
    }

    imprimir(SOMA);

    Ao final do processamento, qual será o valor da variável SOMA?*/

    static void Main(string[] args)
    {
        int indice = 13;
        int soma = 0;
        int k = 0;

        for(k = 0; k < indice; k++)
        {
            soma = soma + k;
            Console.WriteLine("O valor da variavel soma é : {0}", soma);
        }
    }
    /*O valor da variavel soma é : 0
    O valor da variavel soma é : 1
    O valor da variavel soma é : 3
    O valor da variavel soma é : 6
    O valor da variavel soma é : 10
    O valor da variavel soma é : 15
    O valor da variavel soma é : 21
    O valor da variavel soma é : 28
    O valor da variavel soma é : 36
    O valor da variavel soma é : 45
    O valor da variavel soma é : 55
    O valor da variavel soma é : 66
    O valor da variavel soma é : 78*/

}
