using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x02000203 RID: 515
[NullableContext(1)]
[Nullable(0)]
public class CameraGravityConfig
{
	// Token: 0x060020DF RID: 8415 RVA: 0x000B2F94 File Offset: 0x000B1194
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

	// Token: 0x060020E0 RID: 8416 RVA: 0x000B301C File Offset: 0x000B121C
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

	// Token: 0x060020E1 RID: 8417 RVA: 0x000B3088 File Offset: 0x000B1288
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

	// Token: 0x060020E2 RID: 8418 RVA: 0x000B30E0 File Offset: 0x000B12E0
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

	// Token: 0x04001471 RID: 5233
	public ECameraGravityMode GravityMode;

	// Token: 0x04001472 RID: 5234
	public Vector TargetGravity = Vector.Create();

	// Token: 0x04001473 RID: 5235
	public ECameraGravityLerpMode LerpMode;

	// Token: 0x04001474 RID: 5236
	public float LerpTime;

	// Token: 0x04001475 RID: 5237
	[Nullable(2)]
	public UCurveFloat LerpTimeCurve;

	// Token: 0x04001476 RID: 5238
	public float LerpAngleVelocity;

	// Token: 0x04001477 RID: 5239
	public bool LerpAngleWhenFinish;
}
