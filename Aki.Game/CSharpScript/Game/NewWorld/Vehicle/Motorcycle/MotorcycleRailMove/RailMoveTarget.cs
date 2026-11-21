using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061C8 RID: 25032
	[NullableContext(1)]
	[Nullable(0)]
	public class RailMoveTarget
	{
		// Token: 0x0401FC7F RID: 130175
		public Vector TargetLoc = Vector.Create();

		// Token: 0x0401FC80 RID: 130176
		public Rotator TargetRot = Rotator.Create();

		// Token: 0x0401FC81 RID: 130177
		public Vector TargetVel = Vector.Create();

		// Token: 0x0401FC82 RID: 130178
		[Nullable(2)]
		public SplineCurve TargetSpline;

		// Token: 0x0401FC83 RID: 130179
		public float TargetSplineInputKey;

		// Token: 0x0401FC84 RID: 130180
		public float TargetSplineDist;

		// Token: 0x0401FC85 RID: 130181
		public Vector TargetSplineDir = Vector.Create();

		// Token: 0x0401FC86 RID: 130182
		public Rotator TargetSplineRot = Rotator.Create();

		// Token: 0x0401FC87 RID: 130183
		public bool IsForward;
	}
}
