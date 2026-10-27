using System;
using System.Runtime.CompilerServices;

// Token: 0x02000181 RID: 385
[NullableContext(1)]
[Nullable(0)]
internal class TurnModelBlackboardParams
{
	// Token: 0x0400104B RID: 4171
	public float TotalDuration;

	// Token: 0x0400104C RID: 4172
	public Rotator TurnModel = Rotator.Create();

	// Token: 0x0400104D RID: 4173
	public Quat TurnModelQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400104E RID: 4174
	public float RunTime;
}
