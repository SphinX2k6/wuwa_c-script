using System;
using System.Runtime.CompilerServices;

// Token: 0x0200021D RID: 541
[NullableContext(1)]
[Nullable(0)]
public class CameraBlendOutData
{
	// Token: 0x06002193 RID: 8595 RVA: 0x000BD7B5 File Offset: 0x000BB9B5
	public void Reset()
	{
		this.IsInitializedArmRotationPitch = false;
		this.IsInitializedArmRotationYaw = false;
		this.IsInitializedArmRotationRoll = false;
		this.IsInitializedCameraOffset = false;
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x000BD7D3 File Offset: 0x000BB9D3
	public void SetBlendOutArmRotationPitch(float pitch)
	{
		if (!this.IsInitializedArmRotationPitch)
		{
			this.ArmRotationPitch = pitch;
			this.IsInitializedArmRotationPitch = true;
		}
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x000BD7EB File Offset: 0x000BB9EB
	public void SetBlendOutArmRotationYaw(float yaw)
	{
		if (!this.IsInitializedArmRotationYaw)
		{
			this.ArmRotationYaw = yaw;
			this.IsInitializedArmRotationYaw = true;
		}
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x000BD803 File Offset: 0x000BBA03
	public void SetBlendOutArmRotationRoll(float roll)
	{
		if (!this.IsInitializedArmRotationRoll)
		{
			this.ArmRotationRoll = roll;
			this.IsInitializedArmRotationRoll = true;
		}
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x000BD81B File Offset: 0x000BBA1B
	public void SetBlendOutCameraOffset(Vector offset)
	{
		if (!this.IsInitializedCameraOffset)
		{
			this.CameraOffset.DeepCopy(offset);
			this.IsInitializedCameraOffset = true;
		}
	}

	// Token: 0x04001575 RID: 5493
	public bool IsInitializedArmRotationPitch;

	// Token: 0x04001576 RID: 5494
	public float ArmRotationPitch;

	// Token: 0x04001577 RID: 5495
	public bool IsInitializedArmRotationYaw;

	// Token: 0x04001578 RID: 5496
	public float ArmRotationYaw;

	// Token: 0x04001579 RID: 5497
	public bool IsInitializedArmRotationRoll;

	// Token: 0x0400157A RID: 5498
	public float ArmRotationRoll;

	// Token: 0x0400157B RID: 5499
	public bool IsInitializedCameraOffset;

	// Token: 0x0400157C RID: 5500
	public Vector CameraOffset = Vector.Create();
}
