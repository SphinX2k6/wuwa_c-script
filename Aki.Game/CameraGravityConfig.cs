using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x020001FF RID: 511
[NullableContext(1)]
[Nullable(0)]
public class CameraGravityConfig
{
	// Token: 0x06002031 RID: 8241 RVA: 0x000ABC40 File Offset: 0x000A9E40
	public void SetConfig(SCamera_ChangeGravity config)
	{
		if (config == null)
		{
			return;
		}
		this.GravityMode = config.GravityMode;
		Vector targetGravity = this.TargetGravity;
		FVector targetGravity2 = config.TargetGravity;
		FVectorDouble fvectorDouble = targetGravity2;
		targetGravity.DeepCopy(fvectorDouble);
		this.LerpMode = config.LerpMode;
		this.LerpTime = config.LerpTime;
		this.LerpTimeCurve = config.LerpTimeCurve;
		this.LerpAngleVelocity = config.LerpAngleVelocity;
		this.LerpAngleWhenFinish = config.LerpAngleWhenFinish;
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x000ABCC8 File Offset: 0x000A9EC8
	public void DeepCopy(CameraGravityConfig config)
	{
		if (config == null)
		{
			return;
		}
		this.GravityMode = config.GravityMode;
		this.TargetGravity.DeepCopy(config.TargetGravity);
		this.LerpMode = config.LerpMode;
		this.LerpTime = config.LerpTime;
		this.LerpTimeCurve = config.LerpTimeCurve;
		this.LerpAngleVelocity = config.LerpAngleVelocity;
		this.LerpAngleWhenFinish = config.LerpAngleWhenFinish;
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x000ABD34 File Offset: 0x000A9F34
	public void Reset()
	{
		this.GravityMode = ECameraGravityMode.CameraTargetGravityDirect;
		Vector targetGravity = this.TargetGravity;
		FVectorDouble fvectorDouble = Vector.DownVector;
		targetGravity.DeepCopy(fvectorDouble);
		this.LerpMode = ECameraGravityLerpMode.None;
		this.LerpTime = 0f;
		this.LerpTimeCurve = null;
		this.LerpAngleVelocity = 0f;
		this.LerpAngleWhenFinish = false;
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x000ABD8C File Offset: 0x000A9F8C
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(75, 5);
		defaultInterpolatedStringHandler.AppendLiteral("GravityMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<ECameraGravityMode>(this.GravityMode);
		defaultInterpolatedStringHandler.AppendLiteral(", TargetGravity: ");
		defaultInterpolatedStringHandler.AppendFormatted(this.TargetGravity.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(", LerpMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<ECameraGravityLerpMode>(this.LerpMode);
		defaultInterpolatedStringHandler.AppendLiteral(", LerpTime: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.LerpTime);
		defaultInterpolatedStringHandler.AppendLiteral(", LerpAngleVelocity: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.LerpAngleVelocity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400142F RID: 5167
	public ECameraGravityMode GravityMode;

	// Token: 0x04001430 RID: 5168
	public Vector TargetGravity = Vector.Create();

	// Token: 0x04001431 RID: 5169
	public ECameraGravityLerpMode LerpMode;

	// Token: 0x04001432 RID: 5170
	public float LerpTime;

	// Token: 0x04001433 RID: 5171
	[Nullable(2)]
	public UCurveFloat LerpTimeCurve;

	// Token: 0x04001434 RID: 5172
	public float LerpAngleVelocity;

	// Token: 0x04001435 RID: 5173
	public bool LerpAngleWhenFinish;
}
