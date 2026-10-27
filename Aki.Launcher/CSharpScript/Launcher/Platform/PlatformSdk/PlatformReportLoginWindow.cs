using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000156 RID: 342
	public class PlatformReportLoginWindow : PlatformSdkReportBaseData
	{
		// Token: 0x06000A58 RID: 2648 RVA: 0x00044C05 File Offset: 0x00042E05
		public PlatformReportLoginWindow()
		{
			this.event_id = 60125;
			this.event_name = "login_window";
		}

		// Token: 0x04000636 RID: 1590
		[Nullable(1)]
		public string login_way = "23";
	}
}
