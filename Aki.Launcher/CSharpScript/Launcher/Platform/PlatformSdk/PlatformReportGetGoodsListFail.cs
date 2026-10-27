using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000163 RID: 355
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportGetGoodsListFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x00044E1C File Offset: 0x0004301C
		public PlatformReportGetGoodsListFail()
		{
			this.event_id = 60152;
			this.event_name = "get_goodsidlist_fail";
		}

		// Token: 0x04000642 RID: 1602
		public string code = "";

		// Token: 0x04000643 RID: 1603
		public string msg = "";
	}
}
