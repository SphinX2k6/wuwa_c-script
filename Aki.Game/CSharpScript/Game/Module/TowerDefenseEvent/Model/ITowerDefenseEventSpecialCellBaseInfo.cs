using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B0F RID: 19215
	[NullableContext(1)]
	public interface ITowerDefenseEventSpecialCellBaseInfo : ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007B24 RID: 31524
		// (get) Token: 0x06031C2A RID: 203818
		// (set) Token: 0x06031C2B RID: 203819
		int CellType { get; set; }

		// Token: 0x17007B25 RID: 31525
		// (get) Token: 0x06031C2C RID: 203820
		// (set) Token: 0x06031C2D RID: 203821
		Vector2D GridSize { get; set; }
	}
}
