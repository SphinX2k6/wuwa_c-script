using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000165 RID: 357
	public class PlatformReportGetEntitlementLabelListSuccess : PlatformSdkReportBaseData
	{
		// Token: 0x06000A69 RID: 2665 RVA: 0x00044E6E File Offset: 0x0004306E
		public PlatformReportGetEntitlementLabelListSuccess()
		{
			this.event_id = 60154;
			this.event_name = "get_entitlementlabellist_succ";
		}

		// Token: 0x04000644 RID: 1604
		[Nullable(1)]
		public string channel_goodsid = "";

		// Token: 0x04000645 RID: 1605
		public int channel_goodsid_count;
	}
}
