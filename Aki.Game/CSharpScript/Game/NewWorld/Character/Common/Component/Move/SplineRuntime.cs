using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063AE RID: 25518
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineRuntime
	{
		// Token: 0x04020D80 RID: 134528
		[Nullable(2)]
		public USplineComponent SourceSplineUe;

		// Token: 0x04020D81 RID: 134529
		public SplineCurve SourceSpline = new SplineCurve(10);

		// Token: 0x04020D82 RID: 134530
		public SplineCurve WallSpline = new SplineCurve(10);

		// Token: 0x04020D83 RID: 134531
		public float DistanceInSource;

		// Token: 0x04020D84 RID: 134532
		public float DistanceInWallSpline;
	}
}
