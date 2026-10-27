using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000162 RID: 354
	public class PlatformReportGetGoodsListSuccess : PlatformSdkReportBaseData
	{
		// Token: 0x06000A66 RID: 2662 RVA: 0x00044DF3 File Offset: 0x00042FF3
		public PlatformReportGetGoodsListSuccess()
		{
			this.event_id = 60151;
			this.event_name = "get_goodsidlist_succ";
		}

		// Token: 0x04000640 RID: 1600
		[Nullable(1)]
		public string channel_goodsid = "";

		// Token: 0x04000641 RID: 1601
		public int channel_goodsid_count;
	}
}
