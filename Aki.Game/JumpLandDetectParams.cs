using System;
using System.Runtime.CompilerServices;

// Token: 0x02000143 RID: 323
public class JumpLandDetectParams
{
	// Token: 0x04000E79 RID: 3705
	public float TotalTime;

	// Token: 0x04000E7A RID: 3706
	public float NowTime;

	// Token: 0x04000E7B RID: 3707
	[Nullable(2)]
	public Entity Entity;

	// Token: 0x04000E7C RID: 3708
	[Nullable(1)]
	public Vector HeightOffset = Vector.Create();

	// Token: 0x04000E7D RID: 3709
	public bool SetGoThrough;
}
