using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x02007214 RID: 29204
	[NullableContext(1)]
	[Nullable(0)]
	public class AiRacingPerceptionData
	{
		// Token: 0x040259CB RID: 154059
		public Vector PlayerLocation = Vector.Create();

		// Token: 0x040259CC RID: 154060
		public Vector SelfLocation = Vector.Create();

		// Token: 0x040259CD RID: 154061
		public float DistanceBetween;

		// Token: 0x040259CE RID: 154062
		public FSplineMoveDynamicSpeedData? SelfSplineMoveData;

		// Token: 0x040259CF RID: 154063
		public Vector PlayerVelocity = Vector.Create();

		// Token: 0x040259D0 RID: 154064
		public float PlayerAbsSpeed;

		// Token: 0x040259D1 RID: 154065
		public Vector SelfEstimationVelocity = Vector.Create();

		// Token: 0x040259D2 RID: 154066
		public float SelfAbsSpeed;

		// Token: 0x040259D3 RID: 154067
		public float DeltaAbsSpeed;

		// Token: 0x040259D4 RID: 154068
		public float SelfKeepMovingTime;
	}
}
