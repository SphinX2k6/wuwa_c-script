using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F2D RID: 28461
	[NullableContext(1)]
	public interface IJumpConfig : IMoveConfig
	{
		// Token: 0x17009B12 RID: 39698
		// (get) Token: 0x060453E3 RID: 283619
		// (set) Token: 0x060453E4 RID: 283620
		float JumpTime { get; set; }

		// Token: 0x17009B13 RID: 39699
		// (get) Token: 0x060453E5 RID: 283621
		// (set) Token: 0x060453E6 RID: 283622
		float MoveBaseHeightOffset { get; set; }

		// Token: 0x17009B14 RID: 39700
		// (get) Token: 0x060453E7 RID: 283623
		// (set) Token: 0x060453E8 RID: 283624
		float MaxRiseHeightEdge { get; set; }

		// Token: 0x17009B15 RID: 39701
		// (get) Token: 0x060453E9 RID: 283625
		// (set) Token: 0x060453EA RID: 283626
		float MaxFallHeightEdge { get; set; }

		// Token: 0x17009B16 RID: 39702
		// (get) Token: 0x060453EB RID: 283627
		// (set) Token: 0x060453EC RID: 283628
		UCurveFloat MoveRiseCurve { get; set; }

		// Token: 0x17009B17 RID: 39703
		// (get) Token: 0x060453ED RID: 283629
		// (set) Token: 0x060453EE RID: 283630
		UCurveFloat MoveFallCurve { get; set; }
	}
}
