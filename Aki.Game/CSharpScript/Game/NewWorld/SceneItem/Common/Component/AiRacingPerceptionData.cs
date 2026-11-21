using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062C9 RID: 25289
	[NullableContext(1)]
	[Nullable(0)]
	public class AiRacingPerceptionData
	{
		// Token: 0x0402063A RID: 132666
		public Vector PlayerLocation = Vector.Create();

		// Token: 0x0402063B RID: 132667
		public Vector SelfLocation = Vector.Create();

		// Token: 0x0402063C RID: 132668
		public float DistanceBetween;

		// Token: 0x0402063D RID: 132669
		public FSplineMoveDynamicSpeedData? SelfSplineMoveData;

		// Token: 0x0402063E RID: 132670
		public Vector PlayerVelocity = Vector.Create();

		// Token: 0x0402063F RID: 132671
		public float PlayerAbsSpeed;

		// Token: 0x04020640 RID: 132672
		public Vector SelfEstimationVelocity = Vector.Create();

		// Token: 0x04020641 RID: 132673
		public float SelfAbsSpeed;

		// Token: 0x04020642 RID: 132674
		public float DeltaAbsSpeed;

		// Token: 0x04020643 RID: 132675
		public float SelfKeepMovingTime;
	}
}
