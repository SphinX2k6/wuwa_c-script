using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067AD RID: 26541
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineViewTitleData
	{
		// Token: 0x04022859 RID: 141401
		public string Title = "";

		// Token: 0x0402285A RID: 141402
		public List<DangoBrawlCombineViewListItemData> RowDataList = new List<DangoBrawlCombineViewListItemData>();

		// Token: 0x0402285B RID: 141403
		public int LoopLimitNum;

		// Token: 0x0402285C RID: 141404
		public int LoopMaxHeight;

		// Token: 0x0402285D RID: 141405
		public int LoopItemInterval;
	}
}
