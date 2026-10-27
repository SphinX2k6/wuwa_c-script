using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200015E RID: 350
	public class PlatformReportLoginRole : PlatformSdkReportBaseData
	{
		// Token: 0x06000A62 RID: 2658 RVA: 0x00044D5A File Offset: 0x00042F5A
		public PlatformReportLoginRole()
		{
			this.event_id = 60140;
			this.event_name = "login_role";
		}

		// Token: 0x0400063C RID: 1596
		[Nullable(1)]
		public string level = "";
	}
}
