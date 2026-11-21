using System;

// Token: 0x020005B5 RID: 1461
public class ContinuousRingArea : RingArea
{
	// Token: 0x06004503 RID: 17667 RVA: 0x0017B29F File Offset: 0x0017949F
	public ContinuousRingArea(int continuousIndex, int startCellIndex, int endCellIndex, EArrowDirection arrowDirection) : base(startCellIndex, endCellIndex, arrowDirection)
	{
		this.ContinuousIndex = continuousIndex;
	}

	// Token: 0x0400353C RID: 13628
	public int ContinuousIndex;
}
