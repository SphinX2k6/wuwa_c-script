using System;

// Token: 0x02002654 RID: 9812
public class SplineDistanceParams
{
	// Token: 0x06018860 RID: 100448 RVA: 0x0076D2E4 File Offset: 0x0076B4E4
	public SplineDistanceParams(int spline, float r0, float r1, float wt, bool single)
	{
		this.SplineId = spline;
		this.MinSplineDistanceRange = r0;
		this.MaxSplineDistanceRange = r1;
		this.WaitingSplineDistanceRange = wt;
		this.SingleLane = single;
	}

	// Token: 0x0400D45B RID: 54363
	public int SplineId;

	// Token: 0x0400D45C RID: 54364
	public float MinSplineDistanceRange = 300f;

	// Token: 0x0400D45D RID: 54365
	public float MaxSplineDistanceRange = 500f;

	// Token: 0x0400D45E RID: 54366
	public bool SingleLane;

	// Token: 0x0400D45F RID: 54367
	public float WaitingSplineDistanceRange = 500f;
}
