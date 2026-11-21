using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016A RID: 362
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportGetEntitlementLabelListFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A9E RID: 2718 RVA: 0x000472AB File Offset: 0x000454AB
		public PlatformReportGetEntitlementLabelListFail()
		{
			this.event_id = 60155;
			this.event_name = "get_entitlementlabellist_fail";
		}

		// Token: 0x04000681 RID: 1665
		public string code = "";

		// Token: 0x04000682 RID: 1666
		public string msg = "";
	}
}
