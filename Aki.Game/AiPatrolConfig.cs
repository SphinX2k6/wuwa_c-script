using System;
using Aki.Config;

// Token: 0x020000EF RID: 239
public class AiPatrolConfig
{
	// Token: 0x06000DA1 RID: 3489 RVA: 0x0004C740 File Offset: 0x0004A940
	public void Init(AiPatrol config)
	{
		this.Id = config.Id;
		this.CirclePatrol = config.CirclePatrol;
		this.IsNavigation = config.IsNavigation;
		this.StartIndex = config.StartIndex;
		this.LimitNpcDistance = config.LimitNpcDistance;
		this.TurnSpeed = config.TurnSpeed;
		this.Loop = config.Loop;
		this.EndDistance = config.EndDistance;
		this.Sampling = config.Sampling;
		this.ContainZ = config.ContainZ;
	}

	// Token: 0x04000AF4 RID: 2804
	public int Id;

	// Token: 0x04000AF5 RID: 2805
	public bool CirclePatrol;

	// Token: 0x04000AF6 RID: 2806
	public int SplineEntityId;

	// Token: 0x04000AF7 RID: 2807
	public bool IsNavigation;

	// Token: 0x04000AF8 RID: 2808
	public int StartIndex;

	// Token: 0x04000AF9 RID: 2809
	public float LimitNpcDistance;

	// Token: 0x04000AFA RID: 2810
	public float TurnSpeed;

	// Token: 0x04000AFB RID: 2811
	public bool Loop;

	// Token: 0x04000AFC RID: 2812
	public float EndDistance;

	// Token: 0x04000AFD RID: 2813
	public float Sampling;

	// Token: 0x04000AFE RID: 2814
	public bool ContainZ;

	// Token: 0x04000AFF RID: 2815
	public bool IsInverse;

	// Token: 0x04000B00 RID: 2816
	public int Times;
}
