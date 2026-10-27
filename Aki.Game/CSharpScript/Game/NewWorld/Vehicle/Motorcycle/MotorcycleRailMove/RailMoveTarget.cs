using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007047 RID: 28743
	[NullableContext(1)]
	[Nullable(0)]
	public class RailMoveTarget
	{
		// Token: 0x040249C9 RID: 149961
		public Vector TargetLoc = Vector.Create();

		// Token: 0x040249CA RID: 149962
		public Rotator TargetRot = Rotator.Create();

		// Token: 0x040249CB RID: 149963
		public Vector TargetVel = Vector.Create();

		// Token: 0x040249CC RID: 149964
		[Nullable(2)]
		public SplineCurve TargetSpline;

		// Token: 0x040249CD RID: 149965
		public float TargetSplineInputKey;

		// Token: 0x040249CE RID: 149966
		public float TargetSplineDist;

		// Token: 0x040249CF RID: 149967
		public Vector TargetSplineDir = Vector.Create();

		// Token: 0x040249D0 RID: 149968
		public Rotator TargetSplineRot = Rotator.Create();

		// Token: 0x040249D1 RID: 149969
		public bool IsForward;
	}
}
