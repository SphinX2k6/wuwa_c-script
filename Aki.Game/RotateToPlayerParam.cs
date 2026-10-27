using System;

// Token: 0x0200015E RID: 350
internal class RotateToPlayerParam
{
	// Token: 0x060015FE RID: 5630 RVA: 0x000787EF File Offset: 0x000769EF
	public RotateToPlayerParam(float total)
	{
		this.NowTime = 0f;
		this.TotalDurationReciprocal = 1f / total;
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x0007880F File Offset: 0x00076A0F
	public void Update(float now, float total)
	{
		this.NowTime = now;
		this.TotalDurationReciprocal = 1f / total;
	}

	// Token: 0x04000F66 RID: 3942
	public float NowTime;

	// Token: 0x04000F67 RID: 3943
	public float TotalDurationReciprocal;
}
