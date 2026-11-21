using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056FD RID: 22269
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineViewTitleData
	{
		// Token: 0x0401D0B6 RID: 118966
		public string Title = "";

		// Token: 0x0401D0B7 RID: 118967
		public List<DangoBrawlCombineViewListItemData> RowDataList = new List<DangoBrawlCombineViewListItemData>();

		// Token: 0x0401D0B8 RID: 118968
		public int LoopLimitNum;

		// Token: 0x0401D0B9 RID: 118969
		public int LoopMaxHeight;

		// Token: 0x0401D0BA RID: 118970
		public int LoopItemInterval;
	}
}
