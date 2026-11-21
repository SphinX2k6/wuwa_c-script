using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003AB7 RID: 15031
	[NullableContext(1)]
	public interface ITowerDefenseEventSpecialCellBaseInfo : ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004ED1 RID: 20177
		// (get) Token: 0x060269BA RID: 158138
		// (set) Token: 0x060269BB RID: 158139
		int CellType { get; set; }

		// Token: 0x17004ED2 RID: 20178
		// (get) Token: 0x060269BC RID: 158140
		// (set) Token: 0x060269BD RID: 158141
		Vector2D GridSize { get; set; }
	}
}
