Module GraphicsHelper
    Public Sub waitopen()

        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
            ' Threading.Thread.Sleep(10)
        Catch

        End Try
    End Sub
    Public Sub waitclose()
        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
        Catch

        End Try
    End Sub
End Module
