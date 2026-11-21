using System;

// Token: 0x0200258B RID: 9611
public class GravityScale
{
	// Token: 0x06017BBB RID: 97211 RVA: 0x00706874 File Offset: 0x00704A74
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

	// Token: 0x0400CA6D RID: 51821
	public float ScaleUp;

	// Token: 0x0400CA6E RID: 51822
	public float ScaleDown;

	// Token: 0x0400CA6F RID: 51823
	public float ScaleTop;

	// Token: 0x0400CA70 RID: 51824
	public float VelocityTop;

	// Token: 0x0400CA71 RID: 51825
	public float Duration;

	// Token: 0x0400CA72 RID: 51826
	public float ElapsedTime;

	// Token: 0x0400CA73 RID: 51827
	public bool ForceVelocityZero;

	// Token: 0x0400CA74 RID: 51828
	public bool Enable;
}
