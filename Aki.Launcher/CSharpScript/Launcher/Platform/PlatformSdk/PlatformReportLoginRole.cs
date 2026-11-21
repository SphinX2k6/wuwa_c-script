using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000162 RID: 354
	public class PlatformReportLoginRole : PlatformSdkReportBaseData
	{
		// Token: 0x06000A96 RID: 2710 RVA: 0x0004716E File Offset: 0x0004536E
		public PlatformReportLoginRole()
		{
			this.event_id = 60140;
			this.event_name = "login_role";
		}

		// Token: 0x04000677 RID: 1655
		[Nullable(1)]
		public string level = "";
	}
}
