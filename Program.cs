// See https://aka.ms/new-console-template for more information


using System.Linq.Expressions;

//double vlrgas = 0.00;jjj
//double vlreta = 0.00;
double perc = 0.70;
double conseta = 0.00;
double congas = 0.00;

void menu() {
    Console.WriteLine("Bem vindo! Selecione uma das seguintes opções: \n Calcular(1) \n Editar(2) \n Sair(3)");

    try {

        int r = int.Parse(Console.ReadLine());
        if (r==1) {

            Calcular();

        } else if (r==2) {
            
            Editar();

        } else if (r==3){

            Sair();

        }else {
            Console.WriteLine("Resposta Inválida, digite apenas os valores indicados!");
            menu();
        }
    } catch(Exception e ) {
        Console.WriteLine ("Resposta Inválida, digite apenas os valores indicados!");
        menu();
        throw;
    }
}


void Calcular(){

    Console.WriteLine("Selecione o modelo do seu veículo de acordo com as opções:\n Gasolina(1) \n Etanol(2) \n Flex(3)" );

    try {
        int r = int.Parse(Console.ReadLine());
        if (r==1) {

            Console.WriteLine("A melhor opção para o seu veículo é gasolina!");
            menu();   

        } else if (r==2) {

            Console.WriteLine("A melhor opção para o seu veículo é etanol!");
            menu();

        } else if (r==3) {
            gasv:

            try{        
                Console.WriteLine("Informe o valor do Litro da gasolina:");
                double vlrgas = double.Parse(Console.ReadLine());

                etav:
                try {
                    Console.WriteLine("Informe o valor do Litro do etanol:");
                    double vlreta = double.Parse(Console.ReadLine());
                    double x = vlrgas * perc;
                    Console.WriteLine(perc);
                    if (x>vlreta) {
                        Console.WriteLine("A melhor opção para o seu veículo é etanol!");
                        menu();
                    } else if (vlreta == x) {
                        Console.WriteLine("As duas opções são válidas!");
                        menu();
                    } else {
                        Console.WriteLine("A melhor opção para o seu veículo é gasolina!");
                        menu();
                    }
                } catch (Exception e){
                    Console.WriteLine("Resposta Inválida, digite apenas números!");
                    goto etav;
                }

            } catch (Exception e){
            Console.WriteLine("Resposta Inválida, digite apenas números!");
            goto gasv;
            }

        
        } else {
            Console.WriteLine("Resposta Inválida, digite apenas os valores indicados!");
            Calcular();
        }

    }  catch (Exception e ) {
        Console.WriteLine ("Resposta Inválida, digite apenas os valores indicados!");
        Calcular();
        throw;
    }
}


void Editar(){
    
    try{
        Console.WriteLine("Insira o valor do consumo de gasolina do seu veículo(Km/L):");
        congas = double.Parse(Console.ReadLine());
        Editar:
        try {
            Console.WriteLine("Insira o valor do consumo de etanol do seu veículo(Km/L):");
            conseta = double.Parse(Console.ReadLine());
            Console.WriteLine("Valores editados com sucesso!");
            perc = conseta/congas;
        } catch (Exception e ) {
            Console.WriteLine ("Resposta Inválida, digite apenas números!");
            goto Editar;
            throw;
        }


    } catch (Exception e ) {
        Console.WriteLine ("Resposta Inválida, digite apenas números!");
        Editar();
        throw;
    }
    menu();
}


void Sair(){

    Console.WriteLine("Você deseja sair da aplicação?");
    Console.WriteLine("Sim(1)   Não(2)");

    try {
        int r = int.Parse ( Console.ReadLine());
        if (r==1) {
            Environment.Exit(0);
        } else if (r==2) {
            menu();
        } else {
            Console.WriteLine("Resposta Inválida, digite apenas os valores indicados!");
            Sair();
        }

    }catch (Exception e ) {
        Console.WriteLine ("Resposta Inválida, digite apenas os valores indicados!");
        Sair();
        throw;
    }
}

menu();