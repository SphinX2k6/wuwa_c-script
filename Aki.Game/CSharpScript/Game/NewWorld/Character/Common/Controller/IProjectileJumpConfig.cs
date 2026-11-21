using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006314 RID: 25364
	public interface IProjectileJumpConfig
	{
		// Token: 0x17007458 RID: 29784
		// (get) Token: 0x0603D62A RID: 251434
		// (set) Token: 0x0603D62B RID: 251435
		float BaseJumpHeight { get; set; }

		// Token: 0x17007459 RID: 29785
		// (get) Token: 0x0603D62C RID: 251436
		// (set) Token: 0x0603D62D RID: 251437
		float BaseJumpDistanceRate { get; set; }

		// Token: 0x1700745A RID: 29786
		// (get) Token: 0x0603D62E RID: 251438
		// (set) Token: 0x0603D62F RID: 251439
		float MaxJumpDistance { get; set; }

		// Token: 0x1700745B RID: 29787
		// (get) Token: 0x0603D630 RID: 251440
		// (set) Token: 0x0603D631 RID: 251441
		float MaxJumpHeight { get; set; }

		// Token: 0x1700745C RID: 29788
		// (get) Token: 0x0603D632 RID: 251442
		// (set) Token: 0x0603D633 RID: 251443
		float JumpAcceleration { get; set; }

		// Token: 0x1700745D RID: 29789
		// (get) Token: 0x0603D634 RID: 251444
		// (set) Token: 0x0603D635 RID: 251445
		float TargetSpeedForJump { get; set; }

		// Token: 0x1700745E RID: 29790
		// (get) Token: 0x0603D636 RID: 251446
		// (set) Token: 0x0603D637 RID: 251447
		float AllTimeForJump { get; set; }

		// Token: 0x1700745F RID: 29791
		// (get) Token: 0x0603D638 RID: 251448
		// (set) Token: 0x0603D639 RID: 251449
		float JumpBlendTime { get; set; }
	}
}
