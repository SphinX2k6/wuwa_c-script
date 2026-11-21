using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000169 RID: 361
	public class PlatformReportGetEntitlementLabelListSuccess : PlatformSdkReportBaseData
	{
		// Token: 0x06000A9D RID: 2717 RVA: 0x00047282 File Offset: 0x00045482
		public PlatformReportGetEntitlementLabelListSuccess()
		{
			this.event_id = 60154;
			this.event_name = "get_entitlementlabellist_succ";
		}

		// Token: 0x0400067F RID: 1663
		[Nullable(1)]
		public string channel_goodsid = "";

		// Token: 0x04000680 RID: 1664
		public int channel_goodsid_count;
	}
}
