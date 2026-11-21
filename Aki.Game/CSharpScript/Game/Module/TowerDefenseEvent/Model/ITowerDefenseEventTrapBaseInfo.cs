using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003AB5 RID: 15029
	[NullableContext(1)]
	public interface ITowerDefenseEventTrapBaseInfo : ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004EC6 RID: 20166
		// (get) Token: 0x060269A3 RID: 158115
		// (set) Token: 0x060269A4 RID: 158116
		int TrapId { get; set; }

		// Token: 0x17004EC7 RID: 20167
		// (get) Token: 0x060269A5 RID: 158117
		// (set) Token: 0x060269A6 RID: 158118
		int Level { get; set; }

		// Token: 0x17004EC8 RID: 20168
		// (get) Token: 0x060269A7 RID: 158119
		// (set) Token: 0x060269A8 RID: 158120
		int BranchId { get; set; }

		// Token: 0x17004EC9 RID: 20169
		// (get) Token: 0x060269A9 RID: 158121
		// (set) Token: 0x060269AA RID: 158122
		int DefaultCost { get; set; }

		// Token: 0x17004ECA RID: 20170
		// (get) Token: 0x060269AB RID: 158123
		// (set) Token: 0x060269AC RID: 158124
		int DeconstructReturn { get; set; }

		// Token: 0x17004ECB RID: 20171
		// (get) Token: 0x060269AD RID: 158125
		// (set) Token: 0x060269AE RID: 158126
		Vector2D GridSize { get; set; }

		// Token: 0x17004ECC RID: 20172
		// (get) Token: 0x060269AF RID: 158127
		// (set) Token: 0x060269B0 RID: 158128
		ETowerDefenseEventTrapPlacementType PlacementType { get; set; }

		// Token: 0x17004ECD RID: 20173
		// (get) Token: 0x060269B1 RID: 158129
		// (set) Token: 0x060269B2 RID: 158130
		bool CanRotate { get; set; }

		// Token: 0x17004ECE RID: 20174
		// (get) Token: 0x060269B3 RID: 158131
		// (set) Token: 0x060269B4 RID: 158132
		int Degree { get; set; }
	}
}
