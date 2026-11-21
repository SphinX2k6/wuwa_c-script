using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061C9 RID: 25033
	[NullableContext(1)]
	[Nullable(0)]
	public class RailMoveContext
	{
		// Token: 0x0401FC88 RID: 130184
		public Vector SourceLoc = Vector.Create();

		// Token: 0x0401FC89 RID: 130185
		public Rotator SourceRot = Rotator.Create();

		// Token: 0x0401FC8A RID: 130186
		public Vector SourceVel = Vector.Create();

		// Token: 0x0401FC8B RID: 130187
		[Nullable(2)]
		public SplineCurve RailSpline;

		// Token: 0x0401FC8C RID: 130188
		public bool IsForward;

		// Token: 0x0401FC8D RID: 130189
		public RailMoveTarget RailMoveTarget = new RailMoveTarget();
	}
}
