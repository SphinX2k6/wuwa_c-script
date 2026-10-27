using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007048 RID: 28744
	[NullableContext(1)]
	[Nullable(0)]
	public class RailMoveContext
	{
		// Token: 0x040249D2 RID: 149970
		public Vector SourceLoc = Vector.Create();

		// Token: 0x040249D3 RID: 149971
		public Rotator SourceRot = Rotator.Create();

		// Token: 0x040249D4 RID: 149972
		public Vector SourceVel = Vector.Create();

		// Token: 0x040249D5 RID: 149973
		[Nullable(2)]
		public SplineCurve RailSpline;

		// Token: 0x040249D6 RID: 149974
		public bool IsForward;

		// Token: 0x040249D7 RID: 149975
		public RailMoveTarget RailMoveTarget = new RailMoveTarget();
	}
}
