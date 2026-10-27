using System;
using System.Runtime.CompilerServices;

// Token: 0x0200006A RID: 106
[NullableContext(1)]
[Nullable(0)]
public class LogoDefine : Singleton
{
	// Token: 0x1700006E RID: 110
	// (get) Token: 0x0600030F RID: 783 RVA: 0x00012EA4 File Offset: 0x000110A4
	public static LogoDefine Instance
	{
		get
		{
			if (LogoDefine._instance == null)
			{
				LogoDefine._instance = new LogoDefine();
				LogoDefine._instance.OnInit();
			}
			return LogoDefine._instance;
		}
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00012EC7 File Offset: 0x000110C7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00012EC9 File Offset: 0x000110C9
	public static void ResetStaticDefaultValue()
	{
		LogoDefine instance = LogoDefine._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		LogoDefine._instance = null;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00012EE2 File Offset: 0x000110E2
	static LogoDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogoDefine.CreateStaticDefaultValue), new Action(LogoDefine.ResetStaticDefaultValue));
	}

	// Token: 0x04000287 RID: 647
	public string LOGO = "\r\n██╗  ██╗██╗   ██╗██████╗  ██████╗  ██████╗  █████╗ ███╗   ███╗███████╗\r\n██║ ██╔╝██║   ██║██╔══██╗██╔═══██╗██╔════╝ ██╔══██╗████╗ ████║██╔════╝\r\n█████╔╝ ██║   ██║██████╔╝██║   ██║██║  ███╗███████║██╔████╔██║█████╗  \r\n██╔═██╗ ██║   ██║██╔══██╗██║   ██║██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  \r\n██║  ██╗╚██████╔╝██║  ██║╚██████╔╝╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗\r\n╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝\r\n";

	// Token: 0x04000288 RID: 648
	[Nullable(2)]
	private static LogoDefine _instance;
}
