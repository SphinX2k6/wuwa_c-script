using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000168 RID: 360
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportClosePsnCheckOut : PlatformSdkReportBaseData
	{
		// Token: 0x06000A6C RID: 2668 RVA: 0x00044F0A File Offset: 0x0004310A
		public PlatformReportClosePsnCheckOut()
		{
			this.event_id = 60157;
			this.event_name = "close_psncheckout";
		}

		// Token: 0x0400064B RID: 1611
		public string product_id = "";

		// Token: 0x0400064C RID: 1612
		public string goodsId = "";

		// Token: 0x0400064D RID: 1613
		public string psnenvlssuer = "";
	}
}
