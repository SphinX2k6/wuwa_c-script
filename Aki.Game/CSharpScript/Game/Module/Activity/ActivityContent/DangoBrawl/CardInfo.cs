using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C5 RID: 26565
	public struct CardInfo
	{
		// Token: 0x170096BB RID: 38587
		// (get) Token: 0x0604228D RID: 270989 RVA: 0x0100B0BD File Offset: 0x010092BD
		public readonly int RemainRefreshCount
		{
			get
			{
				return this.TotalRefreshCount - this.RefreshCount;
			}
		}

		// Token: 0x040228A5 RID: 141477
		public int CardId;

		// Token: 0x040228A6 RID: 141478
		public int TotalRefreshCount;

		// Token: 0x040228A7 RID: 141479
		public int RefreshCount;
	}
}
