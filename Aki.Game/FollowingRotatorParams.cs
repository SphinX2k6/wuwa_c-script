using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;

// Token: 0x02002653 RID: 9811
public class FollowingRotatorParams
{
	// Token: 0x0601885F RID: 100447 RVA: 0x0076D284 File Offset: 0x0076B484
	[NullableContext(2)]
	public FollowingRotatorParams(BP_KeepFollowingConfig_C data = null)
	{
		if (data != null)
		{
			this.ToleranceRotatorAngle = (float)data.转向角度容差;
			this.MaxRotatorDuration = (float)data.最大转向持续时间;
			this.RotatorSpeed = (float)data.转向速度;
		}
	}

	// Token: 0x0400D458 RID: 54360
	public float RotatorSpeed = 360f;

	// Token: 0x0400D459 RID: 54361
	public float ToleranceRotatorAngle = 10f;

	// Token: 0x0400D45A RID: 54362
	public float MaxRotatorDuration = 400f;
}
