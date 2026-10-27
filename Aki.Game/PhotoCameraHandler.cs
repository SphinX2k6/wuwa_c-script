using System;

// Token: 0x02002553 RID: 9555
public class PhotoCameraHandler
{
	// Token: 0x06013414 RID: 78868 RVA: 0x004CA04A File Offset: 0x004C824A
	public virtual void Clear()
	{
	}

	// Token: 0x06013415 RID: 78869 RVA: 0x004CA04C File Offset: 0x004C824C
	public virtual void AddPitchInput(float pitch)
	{
	}

	// Token: 0x06013416 RID: 78870 RVA: 0x004CA04E File Offset: 0x004C824E
	public virtual void AddYawInput(float yaw)
	{
	}

	// Token: 0x06013417 RID: 78871 RVA: 0x004CA050 File Offset: 0x004C8250
	public virtual void ApplyCameraDelta()
	{
	}

	// Token: 0x06013418 RID: 78872 RVA: 0x004CA052 File Offset: 0x004C8252
	public virtual void SetFov(float fov)
	{
	}

	// Token: 0x06013419 RID: 78873 RVA: 0x004CA054 File Offset: 0x004C8254
	public virtual float GetCameraInitializeFov()
	{
		return 0f;
	}

	// Token: 0x0601341A RID: 78874 RVA: 0x004CA05B File Offset: 0x004C825B
	public virtual void ClearInput()
	{
	}
}
