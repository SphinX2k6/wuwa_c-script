using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200014F RID: 335
	public class PlatformReportFirstGetDid : PlatformSdkReportBaseData
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x00046EB9 File Offset: 0x000450B9
		public PlatformReportFirstGetDid()
		{
			this.event_id = 60106;
			this.event_name = "first_did";
		}

		// Token: 0x0400066F RID: 1647
		[Nullable(1)]
		public string first_check_id = "";
	}
}
