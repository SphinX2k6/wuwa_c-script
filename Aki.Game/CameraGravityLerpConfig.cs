using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x0200020B RID: 523
[NullableContext(1)]
[Nullable(0)]
public class CameraGravityLerpConfig
{
	// Token: 0x06002117 RID: 8471 RVA: 0x000B3DE4 File Offset: 0x000B1FE4
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

	// Token: 0x06002118 RID: 8472 RVA: 0x000B3E30 File Offset: 0x000B2030
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

	// Token: 0x06002119 RID: 8473 RVA: 0x000B3E7D File Offset: 0x000B207D
	public void Reset()
	{
		this.LerpMode = ECameraGravityLerpMode.None;
		this.LerpTime = 0f;
		this.LerpTimeCurve = null;
		this.LerpAngleVelocity = 0f;
		this.LerpAngleWhenFinish = false;
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x000B3EAC File Offset: 0x000B20AC
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

	// Token: 0x04001497 RID: 5271
	public ECameraGravityLerpMode LerpMode;

	// Token: 0x04001498 RID: 5272
	public float LerpTime;

	// Token: 0x04001499 RID: 5273
	[Nullable(2)]
	public UCurveFloat LerpTimeCurve;

	// Token: 0x0400149A RID: 5274
	public float LerpAngleVelocity;

	// Token: 0x0400149B RID: 5275
	public bool LerpAngleWhenFinish;
}
