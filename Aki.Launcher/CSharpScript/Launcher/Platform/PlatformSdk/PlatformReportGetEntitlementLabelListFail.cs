using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000166 RID: 358
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportGetEntitlementLabelListFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x00044E97 File Offset: 0x00043097
		public PlatformReportGetEntitlementLabelListFail()
		{
			this.event_id = 60155;
			this.event_name = "get_entitlementlabellist_fail";
		}

		// Token: 0x04000646 RID: 1606
		public string code = "";

		// Token: 0x04000647 RID: 1607
		public string msg = "";
	}
}
