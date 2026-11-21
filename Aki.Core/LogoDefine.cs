using System;
using System.Runtime.CompilerServices;

// Token: 0x0200006C RID: 108
[NullableContext(1)]
[Nullable(0)]
public class LogoDefine : Singleton
{
	// Token: 0x17000075 RID: 117
	// (get) Token: 0x0600034A RID: 842 RVA: 0x00013C8C File Offset: 0x00011E8C
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

	// Token: 0x0600034B RID: 843 RVA: 0x00013CAF File Offset: 0x00011EAF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00013CB1 File Offset: 0x00011EB1
	public static void ResetStaticDefaultValue()
	{
		LogoDefine instance = LogoDefine._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		LogoDefine._instance = null;
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00013CCA File Offset: 0x00011ECA
	static LogoDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogoDefine.CreateStaticDefaultValue), new Action(LogoDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0400029F RID: 671
	public string LOGO = "\r\n██╗  ██╗██╗   ██╗██████╗  ██████╗  ██████╗  █████╗ ███╗   ███╗███████╗\r\n██║ ██╔╝██║   ██║██╔══██╗██╔═══██╗██╔════╝ ██╔══██╗████╗ ████║██╔════╝\r\n█████╔╝ ██║   ██║██████╔╝██║   ██║██║  ███╗███████║██╔████╔██║█████╗  \r\n██╔═██╗ ██║   ██║██╔══██╗██║   ██║██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  \r\n██║  ██╗╚██████╔╝██║  ██║╚██████╔╝╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗\r\n╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝\r\n";

	// Token: 0x040002A0 RID: 672
	[Nullable(2)]
	private static LogoDefine _instance;
}
