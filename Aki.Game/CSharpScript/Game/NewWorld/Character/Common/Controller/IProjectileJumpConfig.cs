using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B5 RID: 28853
	public interface IProjectileJumpConfig
	{
		// Token: 0x17009C64 RID: 40036
		// (get) Token: 0x06046580 RID: 288128
		// (set) Token: 0x06046581 RID: 288129
		float BaseJumpHeight { get; set; }

		// Token: 0x17009C65 RID: 40037
		// (get) Token: 0x06046582 RID: 288130
		// (set) Token: 0x06046583 RID: 288131
		float BaseJumpDistanceRate { get; set; }

		// Token: 0x17009C66 RID: 40038
		// (get) Token: 0x06046584 RID: 288132
		// (set) Token: 0x06046585 RID: 288133
		float MaxJumpDistance { get; set; }

		// Token: 0x17009C67 RID: 40039
		// (get) Token: 0x06046586 RID: 288134
		// (set) Token: 0x06046587 RID: 288135
		float MaxJumpHeight { get; set; }

		// Token: 0x17009C68 RID: 40040
		// (get) Token: 0x06046588 RID: 288136
		// (set) Token: 0x06046589 RID: 288137
		float JumpAcceleration { get; set; }

		// Token: 0x17009C69 RID: 40041
		// (get) Token: 0x0604658A RID: 288138
		// (set) Token: 0x0604658B RID: 288139
		float TargetSpeedForJump { get; set; }

		// Token: 0x17009C6A RID: 40042
		// (get) Token: 0x0604658C RID: 288140
		// (set) Token: 0x0604658D RID: 288141
		float AllTimeForJump { get; set; }

		// Token: 0x17009C6B RID: 40043
		// (get) Token: 0x0604658E RID: 288142
		// (set) Token: 0x0604658F RID: 288143
		float JumpBlendTime { get; set; }
	}
}
