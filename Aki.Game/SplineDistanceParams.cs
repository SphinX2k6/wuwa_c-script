using System;

// Token: 0x020030FC RID: 12540
public class SplineDistanceParams
{
	// Token: 0x0601AE38 RID: 110136 RVA: 0x00747BF8 File Offset: 0x00745DF8
	public SplineDistanceParams(int spline, float r0, float r1, float wt, bool single)
	{
		this.SplineId = spline;
		this.MinSplineDistanceRange = r0;
		this.MaxSplineDistanceRange = r1;
		this.WaitingSplineDistanceRange = wt;
		this.SingleLane = single;
	}

	// Token: 0x0400D05F RID: 53343
	public int SplineId;

	// Token: 0x0400D060 RID: 53344
	public float MinSplineDistanceRange = 300f;

	// Token: 0x0400D061 RID: 53345
	public float MaxSplineDistanceRange = 500f;

	// Token: 0x0400D062 RID: 53346
	public bool SingleLane;

	// Token: 0x0400D063 RID: 53347
	public float WaitingSplineDistanceRange = 500f;
}
