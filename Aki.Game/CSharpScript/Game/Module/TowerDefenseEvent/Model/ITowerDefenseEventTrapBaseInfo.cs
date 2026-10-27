using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B0D RID: 19213
	[NullableContext(1)]
	public interface ITowerDefenseEventTrapBaseInfo : ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007B19 RID: 31513
		// (get) Token: 0x06031C13 RID: 203795
		// (set) Token: 0x06031C14 RID: 203796
		int TrapId { get; set; }

		// Token: 0x17007B1A RID: 31514
		// (get) Token: 0x06031C15 RID: 203797
		// (set) Token: 0x06031C16 RID: 203798
		int Level { get; set; }

		// Token: 0x17007B1B RID: 31515
		// (get) Token: 0x06031C17 RID: 203799
		// (set) Token: 0x06031C18 RID: 203800
		int BranchId { get; set; }

		// Token: 0x17007B1C RID: 31516
		// (get) Token: 0x06031C19 RID: 203801
		// (set) Token: 0x06031C1A RID: 203802
		int DefaultCost { get; set; }

		// Token: 0x17007B1D RID: 31517
		// (get) Token: 0x06031C1B RID: 203803
		// (set) Token: 0x06031C1C RID: 203804
		int DeconstructReturn { get; set; }

		// Token: 0x17007B1E RID: 31518
		// (get) Token: 0x06031C1D RID: 203805
		// (set) Token: 0x06031C1E RID: 203806
		Vector2D GridSize { get; set; }

		// Token: 0x17007B1F RID: 31519
		// (get) Token: 0x06031C1F RID: 203807
		// (set) Token: 0x06031C20 RID: 203808
		ETowerDefenseEventTrapPlacementType PlacementType { get; set; }

		// Token: 0x17007B20 RID: 31520
		// (get) Token: 0x06031C21 RID: 203809
		// (set) Token: 0x06031C22 RID: 203810
		bool CanRotate { get; set; }

		// Token: 0x17007B21 RID: 31521
		// (get) Token: 0x06031C23 RID: 203811
		// (set) Token: 0x06031C24 RID: 203812
		int Degree { get; set; }
	}
}
