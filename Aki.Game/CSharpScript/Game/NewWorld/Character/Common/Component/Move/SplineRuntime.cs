using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070FE RID: 28926
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineRuntime
	{
		// Token: 0x040250EB RID: 151787
		[Nullable(2)]
		public USplineComponent SourceSplineUe;

		// Token: 0x040250EC RID: 151788
		public SplineCurve SourceSpline = new SplineCurve(10);

		// Token: 0x040250ED RID: 151789
		public SplineCurve WallSpline = new SplineCurve(10);

		// Token: 0x040250EE RID: 151790
		public float DistanceInSource;

		// Token: 0x040250EF RID: 151791
		public float DistanceInWallSpline;
	}
}
