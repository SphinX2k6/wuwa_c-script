using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02004C99 RID: 19609
	[NullableContext(2)]
	[Nullable(0)]
	public class ItemRefreshData
	{
		// Token: 0x17007D07 RID: 32007
		// (get) Token: 0x06032AD3 RID: 207571 RVA: 0x00BD279D File Offset: 0x00BD099D
		// (set) Token: 0x06032AD4 RID: 207572 RVA: 0x00BD27A5 File Offset: 0x00BD09A5
		public int ItemId { get; set; }

		// Token: 0x17007D08 RID: 32008
		// (get) Token: 0x06032AD5 RID: 207573 RVA: 0x00BD27AE File Offset: 0x00BD09AE
		// (set) Token: 0x06032AD6 RID: 207574 RVA: 0x00BD27B6 File Offset: 0x00BD09B6
		public bool NeedLock { get; set; }

		// Token: 0x17007D09 RID: 32009
		// (get) Token: 0x06032AD7 RID: 207575 RVA: 0x00BD27BF File Offset: 0x00BD09BF
		// (set) Token: 0x06032AD8 RID: 207576 RVA: 0x00BD27C7 File Offset: 0x00BD09C7
		public string Text { get; set; }
	}
}
