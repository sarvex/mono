Option Explicit
Option Strict Off
Option Compare Text

Imports System

Module WriteOK

    Sub Main()
        REM Testing old-fashioned comments
        Console.WriteLine("OK!") ' Simple comments
    End Sub

End Module

Module WriteOK2

    Sub [Sub]() ' Escaped identifier
		Dim Text as string ' here 'Text' isn't a keyword
		
        Console.WriteLine("Sub:OK!")
    End Sub

End Module

