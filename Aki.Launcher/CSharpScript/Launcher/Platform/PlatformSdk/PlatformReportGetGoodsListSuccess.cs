using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000166 RID: 358
	public class PlatformReportGetGoodsListSuccess : PlatformSdkReportBaseData
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x00047207 File Offset: 0x00045407
		public PlatformReportGetGoodsListSuccess()
		{
			this.event_id = 60151;
			this.event_name = "get_goodsidlist_succ";
		}

		// Token: 0x0400067B RID: 1659
		[Nullable(1)]
		public string channel_goodsid = "";

		// Token: 0x0400067C RID: 1660
		public int channel_goodsid_count;
	}
}
