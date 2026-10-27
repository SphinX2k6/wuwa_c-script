using System;
using System.Runtime.CompilerServices;

// Token: 0x0200013F RID: 319
public class JumpLandDetectParams
{
	// Token: 0x04000E36 RID: 3638
	public float TotalTime;

	// Token: 0x04000E37 RID: 3639
	public float NowTime;

	// Token: 0x04000E38 RID: 3640
	[Nullable(2)]
	public Entity Entity;

	// Token: 0x04000E39 RID: 3641
	[Nullable(1)]
	public Vector HeightOffset = Vector.Create();

	// Token: 0x04000E3A RID: 3642
	public bool SetGoThrough;
}
