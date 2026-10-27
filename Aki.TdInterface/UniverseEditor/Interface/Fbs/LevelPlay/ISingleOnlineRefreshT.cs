using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045AF RID: 17839
	public class ISingleOnlineRefreshT
	{
		// Token: 0x17007ECB RID: 32459
		// (get) Token: 0x0601AF8D RID: 110477 RVA: 0x003D8B8E File Offset: 0x003D6D8E
		// (set) Token: 0x0601AF8E RID: 110478 RVA: 0x003D8B96 File Offset: 0x003D6D96
		public int CompletedRefreshTime { get; set; }

		// Token: 0x17007ECC RID: 32460
		// (get) Token: 0x0601AF8F RID: 110479 RVA: 0x003D8B9F File Offset: 0x003D6D9F
		// (set) Token: 0x0601AF90 RID: 110480 RVA: 0x003D8BA7 File Offset: 0x003D6DA7
		public int AwardedRefreshTime { get; set; }

		// Token: 0x17007ECD RID: 32461
		// (get) Token: 0x0601AF91 RID: 110481 RVA: 0x003D8BB0 File Offset: 0x003D6DB0
		// (set) Token: 0x0601AF92 RID: 110482 RVA: 0x003D8BB8 File Offset: 0x003D6DB8
		public byte NullMask { get; set; }

		// Token: 0x0601AF93 RID: 110483 RVA: 0x003D8BC1 File Offset: 0x003D6DC1
		public ISingleOnlineRefreshT()
		{
			this.CompletedRefreshTime = 0;
			this.AwardedRefreshTime = 0;
			this.NullMask = 0;
		}
	}
}
