using System;
using System.Runtime.CompilerServices;

// Token: 0x02000132 RID: 306
[NullableContext(1)]
[Nullable(0)]
internal class FixOffsetParams
{
	// Token: 0x04000DED RID: 3565
	public readonly Vector DeltaPos = Vector.Create();

	// Token: 0x04000DEE RID: 3566
	public float DeltaYaw;

	// Token: 0x04000DEF RID: 3567
	public float TotalDuration;

	// Token: 0x04000DF0 RID: 3568
	public readonly CurveChannel ChX = new CurveChannel();

	// Token: 0x04000DF1 RID: 3569
	public readonly CurveChannel ChY = new CurveChannel();

	// Token: 0x04000DF2 RID: 3570
	public readonly CurveChannel ChZ = new CurveChannel();

	// Token: 0x04000DF3 RID: 3571
	public readonly CurveChannel ChLook = new CurveChannel();

	// Token: 0x04000DF4 RID: 3572
	public float AppliedX;

	// Token: 0x04000DF5 RID: 3573
	public float AppliedY;

	// Token: 0x04000DF6 RID: 3574
	public float AppliedZ;
}
