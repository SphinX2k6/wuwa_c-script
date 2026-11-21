using System;
using System.Runtime.CompilerServices;

// Token: 0x02000185 RID: 389
[NullableContext(1)]
[Nullable(0)]
internal class TurnModelBlackboardParams
{
	// Token: 0x0400108E RID: 4238
	public float TotalDuration;

	// Token: 0x0400108F RID: 4239
	public Rotator TurnModel = Rotator.Create();

	// Token: 0x04001090 RID: 4240
	public Quat TurnModelQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001091 RID: 4241
	public float RunTime;
}
