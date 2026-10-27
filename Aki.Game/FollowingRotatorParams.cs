using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;

// Token: 0x020030FB RID: 12539
public class FollowingRotatorParams
{
	// Token: 0x0601AE37 RID: 110135 RVA: 0x00747B98 File Offset: 0x00745D98
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

	// Token: 0x0400D05C RID: 53340
	public float RotatorSpeed = 360f;

	// Token: 0x0400D05D RID: 53341
	public float ToleranceRotatorAngle = 10f;

	// Token: 0x0400D05E RID: 53342
	public float MaxRotatorDuration = 400f;
}
