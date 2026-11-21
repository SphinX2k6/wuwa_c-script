using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x020060AE RID: 24750
	[NullableContext(1)]
	public interface IJumpConfig : IMoveConfig
	{
		// Token: 0x17007051 RID: 28753
		// (get) Token: 0x0603B591 RID: 243089
		// (set) Token: 0x0603B592 RID: 243090
		float JumpTime { get; set; }

		// Token: 0x17007052 RID: 28754
		// (get) Token: 0x0603B593 RID: 243091
		// (set) Token: 0x0603B594 RID: 243092
		float MoveBaseHeightOffset { get; set; }

		// Token: 0x17007053 RID: 28755
		// (get) Token: 0x0603B595 RID: 243093
		// (set) Token: 0x0603B596 RID: 243094
		float MaxRiseHeightEdge { get; set; }

		// Token: 0x17007054 RID: 28756
		// (get) Token: 0x0603B597 RID: 243095
		// (set) Token: 0x0603B598 RID: 243096
		float MaxFallHeightEdge { get; set; }

		// Token: 0x17007055 RID: 28757
		// (get) Token: 0x0603B599 RID: 243097
		// (set) Token: 0x0603B59A RID: 243098
		UCurveFloat MoveRiseCurve { get; set; }

		// Token: 0x17007056 RID: 28758
		// (get) Token: 0x0603B59B RID: 243099
		// (set) Token: 0x0603B59C RID: 243100
		UCurveFloat MoveFallCurve { get; set; }
	}
}
