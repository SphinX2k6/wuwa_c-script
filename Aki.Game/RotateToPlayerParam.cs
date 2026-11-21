using System;

// Token: 0x02000162 RID: 354
internal class RotateToPlayerParam
{
	// Token: 0x0600169B RID: 5787 RVA: 0x0007DFCF File Offset: 0x0007C1CF
	public RotateToPlayerParam(float total)
	{
		this.NowTime = 0f;
		this.TotalDurationReciprocal = 1f / total;
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x0007DFEF File Offset: 0x0007C1EF
	public void Update(float now, float total)
	{
		this.NowTime = now;
		this.TotalDurationReciprocal = 1f / total;
	}

	// Token: 0x04000FA9 RID: 4009
	public float NowTime;

	// Token: 0x04000FAA RID: 4010
	public float TotalDurationReciprocal;
}
