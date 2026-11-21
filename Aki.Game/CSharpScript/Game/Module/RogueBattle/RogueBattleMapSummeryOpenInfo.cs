using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA4 RID: 16036
	public class RogueBattleMapSummeryOpenInfo : IRogueBattleMapSummeryOpenInfo
	{
		// Token: 0x170052DF RID: 21215
		// (get) Token: 0x06028B63 RID: 166755 RVA: 0x00B6A68E File Offset: 0x00B6888E
		// (set) Token: 0x06028B64 RID: 166756 RVA: 0x00B6A696 File Offset: 0x00B68896
		public EUiTabViewName TabName { get; set; }

		// Token: 0x170052E0 RID: 21216
		// (get) Token: 0x06028B65 RID: 166757 RVA: 0x00B6A69F File Offset: 0x00B6889F
		// (set) Token: 0x06028B66 RID: 166758 RVA: 0x00B6A6A7 File Offset: 0x00B688A7
		public int? FetterId { get; set; }
	}
}
