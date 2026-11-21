using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005715 RID: 22293
	public struct CardInfo
	{
		// Token: 0x170069FC RID: 27132
		// (get) Token: 0x06036DE3 RID: 224739 RVA: 0x00F4C4A1 File Offset: 0x00F4A6A1
		public readonly int RemainRefreshCount
		{
			get
			{
				return this.TotalRefreshCount - this.RefreshCount;
			}
		}

		// Token: 0x0401D102 RID: 119042
		public int CardId;

		// Token: 0x0401D103 RID: 119043
		public int TotalRefreshCount;

		// Token: 0x0401D104 RID: 119044
		public int RefreshCount;
	}
}
