using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA3 RID: 16035
	public interface IRogueBattleMapSummeryOpenInfo
	{
		// Token: 0x170052DD RID: 21213
		// (get) Token: 0x06028B5F RID: 166751
		// (set) Token: 0x06028B60 RID: 166752
		EUiTabViewName TabName { get; set; }

		// Token: 0x170052DE RID: 21214
		// (get) Token: 0x06028B61 RID: 166753
		// (set) Token: 0x06028B62 RID: 166754
		int? FetterId { get; set; }
	}
}
