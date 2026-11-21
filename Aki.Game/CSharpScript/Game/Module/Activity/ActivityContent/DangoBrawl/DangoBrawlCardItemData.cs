using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200571D RID: 22301
	public class DangoBrawlCardItemData
	{
		// Token: 0x06036E2B RID: 224811 RVA: 0x00F4DAFC File Offset: 0x00F4BCFC
		public DangoBrawlCardItemData(int cardId, int remainRefreshCount)
		{
			this.CardId = cardId;
			this.RemainRefreshCount = remainRefreshCount;
		}

		// Token: 0x0401D11D RID: 119069
		public int CardId;

		// Token: 0x0401D11E RID: 119070
		public int RemainRefreshCount;
	}
}
