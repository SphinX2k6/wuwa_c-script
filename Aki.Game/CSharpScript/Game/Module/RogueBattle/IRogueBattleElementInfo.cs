using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E88 RID: 16008
	public interface IRogueBattleElementInfo
	{
		// Token: 0x17005291 RID: 21137
		// (get) Token: 0x06028ABB RID: 166587
		// (set) Token: 0x06028ABC RID: 166588
		int ElementId { get; set; }

		// Token: 0x17005292 RID: 21138
		// (get) Token: 0x06028ABD RID: 166589
		// (set) Token: 0x06028ABE RID: 166590
		int Count { get; set; }

		// Token: 0x17005293 RID: 21139
		// (get) Token: 0x06028ABF RID: 166591
		// (set) Token: 0x06028AC0 RID: 166592
		bool IsPreview { get; set; }
	}
}
