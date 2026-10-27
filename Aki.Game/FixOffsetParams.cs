using System;
using System.Runtime.CompilerServices;

// Token: 0x02000132 RID: 306
[NullableContext(1)]
[Nullable(0)]
internal class FixOffsetParams
{
	// Token: 0x04000DE5 RID: 3557
	public readonly Vector DeltaPos = Vector.Create();

	// Token: 0x04000DE6 RID: 3558
	public float DeltaYaw;

	// Token: 0x04000DE7 RID: 3559
	public float TotalDuration;

	// Token: 0x04000DE8 RID: 3560
	public readonly CurveChannel ChX = new CurveChannel();

	// Token: 0x04000DE9 RID: 3561
	public readonly CurveChannel ChY = new CurveChannel();

	// Token: 0x04000DEA RID: 3562
	public readonly CurveChannel ChZ = new CurveChannel();

	// Token: 0x04000DEB RID: 3563
	public readonly CurveChannel ChLook = new CurveChannel();

	// Token: 0x04000DEC RID: 3564
	public float AppliedX;

	// Token: 0x04000DED RID: 3565
	public float AppliedY;

	// Token: 0x04000DEE RID: 3566
	public float AppliedZ;
}
