using System;

// Token: 0x02001A3E RID: 6718
public class PhotoCameraHandler
{
	// Token: 0x060108F4 RID: 67828 RVA: 0x004D8BCA File Offset: 0x004D6DCA
	public virtual void Clear()
	{
	}

	// Token: 0x060108F5 RID: 67829 RVA: 0x004D8BCC File Offset: 0x004D6DCC
	public virtual void AddPitchInput(float pitch)
	{
	}

	// Token: 0x060108F6 RID: 67830 RVA: 0x004D8BCE File Offset: 0x004D6DCE
	public virtual void AddYawInput(float yaw)
	{
	}

	// Token: 0x060108F7 RID: 67831 RVA: 0x004D8BD0 File Offset: 0x004D6DD0
	public virtual void ApplyCameraDelta()
	{
	}

	// Token: 0x060108F8 RID: 67832 RVA: 0x004D8BD2 File Offset: 0x004D6DD2
	public virtual void SetFov(float fov)
	{
	}

	// Token: 0x060108F9 RID: 67833 RVA: 0x004D8BD4 File Offset: 0x004D6DD4
	public virtual float GetCameraInitializeFov()
	{
		return 0f;
	}

	// Token: 0x060108FA RID: 67834 RVA: 0x004D8BDB File Offset: 0x004D6DDB
	public virtual void ClearInput()
	{
	}
}
