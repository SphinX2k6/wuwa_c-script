using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200014B RID: 331
	public class PlatformReportFirstGetDid : PlatformSdkReportBaseData
	{
		// Token: 0x06000A4D RID: 2637 RVA: 0x00044AA5 File Offset: 0x00042CA5
		public PlatformReportFirstGetDid()
		{
			this.event_id = 60106;
			this.event_name = "first_did";
		}

		// Token: 0x04000634 RID: 1588
		[Nullable(1)]
		public string first_check_id = "";
	}
}
