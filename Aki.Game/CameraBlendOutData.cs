using System;
using System.Runtime.CompilerServices;

// Token: 0x02000219 RID: 537
[NullableContext(1)]
[Nullable(0)]
public class CameraBlendOutData
{
	// Token: 0x060020E5 RID: 8421 RVA: 0x000B6495 File Offset: 0x000B4695
	public void Reset()
	{
		this.IsInitializedArmRotationPitch = false;
		this.IsInitializedArmRotationYaw = false;
		this.IsInitializedArmRotationRoll = false;
		this.IsInitializedCameraOffset = false;
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000B64B3 File Offset: 0x000B46B3
	public void SetBlendOutArmRotationPitch(float pitch)
	{
		if (!this.IsInitializedArmRotationPitch)
		{
			this.ArmRotationPitch = pitch;
			this.IsInitializedArmRotationPitch = true;
		}
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x000B64CB File Offset: 0x000B46CB
	public void SetBlendOutArmRotationYaw(float yaw)
	{
		if (!this.IsInitializedArmRotationYaw)
		{
			this.ArmRotationYaw = yaw;
			this.IsInitializedArmRotationYaw = true;
		}
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x000B64E3 File Offset: 0x000B46E3
	public void SetBlendOutArmRotationRoll(float roll)
	{
		if (!this.IsInitializedArmRotationRoll)
		{
			this.ArmRotationRoll = roll;
			this.IsInitializedArmRotationRoll = true;
		}
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000B64FB File Offset: 0x000B46FB
	public void SetBlendOutCameraOffset(Vector offset)
	{
		if (!this.IsInitializedCameraOffset)
		{
			this.CameraOffset.DeepCopy(offset);
			this.IsInitializedCameraOffset = true;
		}
	}

	// Token: 0x04001533 RID: 5427
	public bool IsInitializedArmRotationPitch;

	// Token: 0x04001534 RID: 5428
	public float ArmRotationPitch;

	// Token: 0x04001535 RID: 5429
	public bool IsInitializedArmRotationYaw;

	// Token: 0x04001536 RID: 5430
	public float ArmRotationYaw;

	// Token: 0x04001537 RID: 5431
	public bool IsInitializedArmRotationRoll;

	// Token: 0x04001538 RID: 5432
	public float ArmRotationRoll;

	// Token: 0x04001539 RID: 5433
	public bool IsInitializedCameraOffset;

	// Token: 0x0400153A RID: 5434
	public Vector CameraOffset = Vector.Create();
}
