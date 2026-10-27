using System;

// Token: 0x02003035 RID: 12341
public class GravityScale
{
	// Token: 0x0601A25D RID: 107101 RVA: 0x006DEB80 File Offset: 0x006DCD80
	public GravityScale(float scaleUp = 0f, float scaleDown = 0f, float scaleTop = 0f, float velocityTop = 0f, float duration = 0f, float elapsedTime = 0f, bool forceVelocityZero = false, bool enable = false)
	{
		this.ScaleUp = scaleUp;
		this.ScaleDown = scaleDown;
		this.ScaleTop = scaleTop;
		this.VelocityTop = velocityTop;
		this.Duration = duration;
		this.ElapsedTime = elapsedTime;
		this.ForceVelocityZero = forceVelocityZero;
		this.Enable = enable;
	}

	// Token: 0x0400C69E RID: 50846
	public float ScaleUp;

	// Token: 0x0400C69F RID: 50847
	public float ScaleDown;

	// Token: 0x0400C6A0 RID: 50848
	public float ScaleTop;

	// Token: 0x0400C6A1 RID: 50849
	public float VelocityTop;

	// Token: 0x0400C6A2 RID: 50850
	public float Duration;

	// Token: 0x0400C6A3 RID: 50851
	public float ElapsedTime;

	// Token: 0x0400C6A4 RID: 50852
	public bool ForceVelocityZero;

	// Token: 0x0400C6A5 RID: 50853
	public bool Enable;
}
