using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x02000201 RID: 513
[NullableContext(1)]
[Nullable(0)]
public class CameraGravityDirectionConfig
{
	// Token: 0x06002055 RID: 8277 RVA: 0x000AC7F0 File Offset: 0x000AA9F0
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

	// Token: 0x06002056 RID: 8278 RVA: 0x000AC834 File Offset: 0x000AAA34
	public void DeepCopy(CameraGravityDirectionConfig config)
	{
		if (config == null)
		{
			return;
		}
		this.GravityMode = config.GravityMode;
		this.TargetGravity.DeepCopy(config.TargetGravity);
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x000AC858 File Offset: 0x000AAA58
	public void Reset()
	{
		this.GravityMode = ECameraGravityMode.CameraTargetGravityDirect;
		Vector targetGravity = this.TargetGravity;
		FVectorDouble fvectorDouble = Vector.DownVector;
		targetGravity.DeepCopy(fvectorDouble);
	}

	// Token: 0x04001445 RID: 5189
	public ECameraGravityMode GravityMode;

	// Token: 0x04001446 RID: 5190
	public Vector TargetGravity = Vector.Create();
}
