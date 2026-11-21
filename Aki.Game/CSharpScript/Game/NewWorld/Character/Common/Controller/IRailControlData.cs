using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006316 RID: 25366
	[NullableContext(1)]
	public interface IRailControlData
	{
		// Token: 0x17007468 RID: 29800
		// (get) Token: 0x0603D64B RID: 251467
		// (set) Token: 0x0603D64C RID: 251468
		float Rad { get; set; }

		// Token: 0x17007469 RID: 29801
		// (get) Token: 0x0603D64D RID: 251469
		// (set) Token: 0x0603D64E RID: 251470
		float AngularVelocity { get; set; }

		// Token: 0x1700746A RID: 29802
		// (get) Token: 0x0603D64F RID: 251471
		// (set) Token: 0x0603D650 RID: 251472
		float Damping { get; set; }

		// Token: 0x1700746B RID: 29803
		// (get) Token: 0x0603D651 RID: 251473
		// (set) Token: 0x0603D652 RID: 251474
		float MaxAngularVelocity { get; set; }

		// Token: 0x1700746C RID: 29804
		// (get) Token: 0x0603D653 RID: 251475
		// (set) Token: 0x0603D654 RID: 251476
		float MaxLinearVelocity { get; set; }

		// Token: 0x1700746D RID: 29805
		// (get) Token: 0x0603D655 RID: 251477
		// (set) Token: 0x0603D656 RID: 251478
		bool IgnoreMaxAngle { get; set; }

		// Token: 0x1700746E RID: 29806
		// (get) Token: 0x0603D657 RID: 251479
		// (set) Token: 0x0603D658 RID: 251480
		float RegressionSpeed { get; set; }

		// Token: 0x1700746F RID: 29807
		// (get) Token: 0x0603D659 RID: 251481
		// (set) Token: 0x0603D65A RID: 251482
		float InputCoefficient { get; set; }

		// Token: 0x17007470 RID: 29808
		// (get) Token: 0x0603D65B RID: 251483
		// (set) Token: 0x0603D65C RID: 251484
		float MaxAngle { get; set; }

		// Token: 0x17007471 RID: 29809
		// (get) Token: 0x0603D65D RID: 251485
		// (set) Token: 0x0603D65E RID: 251486
		float Radius { get; set; }

		// Token: 0x17007472 RID: 29810
		// (get) Token: 0x0603D65F RID: 251487
		// (set) Token: 0x0603D660 RID: 251488
		bool InnerArc { get; set; }

		// Token: 0x17007473 RID: 29811
		// (get) Token: 0x0603D661 RID: 251489
		// (set) Token: 0x0603D662 RID: 251490
		float HalfHeight { get; set; }

		// Token: 0x17007474 RID: 29812
		// (get) Token: 0x0603D663 RID: 251491
		Vector ToCenterVector { get; }

		// Token: 0x17007475 RID: 29813
		// (get) Token: 0x0603D664 RID: 251492
		Vector SplineForwardVector { get; }

		// Token: 0x17007476 RID: 29814
		// (get) Token: 0x0603D665 RID: 251493
		Vector CenterLocation { get; }

		// Token: 0x17007477 RID: 29815
		// (get) Token: 0x0603D666 RID: 251494
		Vector DefaultLocation { get; }

		// Token: 0x0603D667 RID: 251495
		float GetLimitLinearVelocity();
	}
}
