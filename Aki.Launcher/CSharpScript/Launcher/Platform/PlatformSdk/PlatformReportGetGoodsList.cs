using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000165 RID: 357
	public class PlatformReportGetGoodsList : PlatformSdkReportBaseData
	{
		// Token: 0x06000A99 RID: 2713 RVA: 0x000471DE File Offset: 0x000453DE
		public PlatformReportGetGoodsList()
		{
			this.event_id = 60150;
			this.event_name = "get_goodsidlist";
		}

		// Token: 0x04000679 RID: 1657
		[Nullable(1)]
		public string goodsid = "";

		// Token: 0x0400067A RID: 1658
		public int goodsid_count;
	}
}
