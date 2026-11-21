using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200015A RID: 346
	public class PlatformReportLoginWindow : PlatformSdkReportBaseData
	{
		// Token: 0x06000A8C RID: 2700 RVA: 0x00047019 File Offset: 0x00045219
		public PlatformReportLoginWindow()
		{
			this.event_id = 60125;
			this.event_name = "login_window";
		}

		// Token: 0x04000671 RID: 1649
		[Nullable(1)]
		public string login_way = "23";
	}
}
