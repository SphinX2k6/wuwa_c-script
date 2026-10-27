using System;
using Aki.Config;

// Token: 0x020000EF RID: 239
public class AiPatrolConfig
{
	// Token: 0x06000D9B RID: 3483 RVA: 0x0004BBA4 File Offset: 0x00049DA4
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

	// Token: 0x04000AEC RID: 2796
	public int Id;

	// Token: 0x04000AED RID: 2797
	public bool CirclePatrol;

	// Token: 0x04000AEE RID: 2798
	public int SplineEntityId;

	// Token: 0x04000AEF RID: 2799
	public bool IsNavigation;

	// Token: 0x04000AF0 RID: 2800
	public int StartIndex;

	// Token: 0x04000AF1 RID: 2801
	public float LimitNpcDistance;

	// Token: 0x04000AF2 RID: 2802
	public float TurnSpeed;

	// Token: 0x04000AF3 RID: 2803
	public bool Loop;

	// Token: 0x04000AF4 RID: 2804
	public float EndDistance;

	// Token: 0x04000AF5 RID: 2805
	public float Sampling;

	// Token: 0x04000AF6 RID: 2806
	public bool ContainZ;

	// Token: 0x04000AF7 RID: 2807
	public bool IsInverse;

	// Token: 0x04000AF8 RID: 2808
	public int Times;
}
