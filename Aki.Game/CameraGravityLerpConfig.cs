using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x02000207 RID: 519
[NullableContext(1)]
[Nullable(0)]
public class CameraGravityLerpConfig
{
	// Token: 0x06002069 RID: 8297 RVA: 0x000ACAC4 File Offset: 0x000AACC4
	public void SetConfig(SCamera_ChangeGravity config)
	{
		if (config == null)
		{
			return;
		}
		this.LerpMode = config.LerpMode;
		this.LerpTime = config.LerpTime;
		this.LerpAngleVelocity = config.LerpAngleVelocity;
		this.LerpAngleWhenFinish = config.LerpAngleWhenFinish;
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x000ACB10 File Offset: 0x000AAD10
	public void DeepCopy(CameraGravityLerpConfig config)
	{
		if (config == null)
		{
			return;
		}
		this.LerpMode = config.LerpMode;
		this.LerpTime = config.LerpTime;
		this.LerpTimeCurve = config.LerpTimeCurve;
		this.LerpAngleVelocity = config.LerpAngleVelocity;
		this.LerpAngleWhenFinish = config.LerpAngleWhenFinish;
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x000ACB5D File Offset: 0x000AAD5D
	public void Reset()
	{
		this.LerpMode = ECameraGravityLerpMode.None;
		this.LerpTime = 0f;
		this.LerpTimeCurve = null;
		this.LerpAngleVelocity = 0f;
		this.LerpAngleWhenFinish = false;
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x000ACB8C File Offset: 0x000AAD8C
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 4);
		defaultInterpolatedStringHandler.AppendLiteral("LerpMode:");
		defaultInterpolatedStringHandler.AppendFormatted<ECameraGravityLerpMode>(this.LerpMode);
		defaultInterpolatedStringHandler.AppendLiteral(", LerpTime:");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.LerpTime);
		defaultInterpolatedStringHandler.AppendLiteral(", LerpAngleVelocity:");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.LerpAngleVelocity);
		defaultInterpolatedStringHandler.AppendLiteral(", LerpAngleWhenFinish:");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(this.LerpAngleWhenFinish);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04001455 RID: 5205
	public ECameraGravityLerpMode LerpMode;

	// Token: 0x04001456 RID: 5206
	public float LerpTime;

	// Token: 0x04001457 RID: 5207
	[Nullable(2)]
	public UCurveFloat LerpTimeCurve;

	// Token: 0x04001458 RID: 5208
	public float LerpAngleVelocity;

	// Token: 0x04001459 RID: 5209
	public bool LerpAngleWhenFinish;
}
