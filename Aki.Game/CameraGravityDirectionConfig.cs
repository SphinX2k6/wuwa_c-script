using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x02000205 RID: 517
[NullableContext(1)]
[Nullable(0)]
public class CameraGravityDirectionConfig
{
	// Token: 0x06002103 RID: 8451 RVA: 0x000B3B10 File Offset: 0x000B1D10
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
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x000B3B54 File Offset: 0x000B1D54
	public void DeepCopy(CameraGravityDirectionConfig config)
	{
		if (config == null)
		{
			return;
		}
		this.GravityMode = config.GravityMode;
		this.TargetGravity.DeepCopy(config.TargetGravity);
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000B3B78 File Offset: 0x000B1D78
	public void Reset()
	{
		this.GravityMode = ECameraGravityMode.CameraTargetGravityDirect;
		Vector targetGravity = this.TargetGravity;
		FVectorDouble fvectorDouble = Vector.DownVector;
		targetGravity.DeepCopy(fvectorDouble);
	}

	// Token: 0x04001487 RID: 5255
	public ECameraGravityMode GravityMode;

	// Token: 0x04001488 RID: 5256
	public Vector TargetGravity = Vector.Create();
}
