using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067CD RID: 26573
	public class DangoBrawlCardItemData
	{
		// Token: 0x060422D5 RID: 271061 RVA: 0x0100C730 File Offset: 0x0100A930
		public DangoBrawlCardItemData(int cardId, int remainRefreshCount)
		{
			this.CardId = cardId;
			this.RemainRefreshCount = remainRefreshCount;
		}

		// Token: 0x040228C0 RID: 141504
		public int CardId;

		// Token: 0x040228C1 RID: 141505
		public int RemainRefreshCount;
	}
}
