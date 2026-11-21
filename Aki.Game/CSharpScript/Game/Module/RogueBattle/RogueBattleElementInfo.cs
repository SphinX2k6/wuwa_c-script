using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E89 RID: 16009
	public class RogueBattleElementInfo : IRogueBattleElementInfo
	{
		// Token: 0x17005294 RID: 21140
		// (get) Token: 0x06028AC1 RID: 166593 RVA: 0x00B6A350 File Offset: 0x00B68550
		// (set) Token: 0x06028AC2 RID: 166594 RVA: 0x00B6A358 File Offset: 0x00B68558
		public int ElementId { get; set; }

		// Token: 0x17005295 RID: 21141
		// (get) Token: 0x06028AC3 RID: 166595 RVA: 0x00B6A361 File Offset: 0x00B68561
		// (set) Token: 0x06028AC4 RID: 166596 RVA: 0x00B6A369 File Offset: 0x00B68569
		public int Count { get; set; }

		// Token: 0x17005296 RID: 21142
		// (get) Token: 0x06028AC5 RID: 166597 RVA: 0x00B6A372 File Offset: 0x00B68572
		// (set) Token: 0x06028AC6 RID: 166598 RVA: 0x00B6A37A File Offset: 0x00B6857A
		public bool IsPreview { get; set; }
	}
}
