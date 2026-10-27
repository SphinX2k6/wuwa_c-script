using System;

// Token: 0x02001101 RID: 4353
public class ContinuousRingArea : RingArea
{
	// Token: 0x0600716D RID: 29037 RVA: 0x001728E3 File Offset: 0x00170AE3
	public ContinuousRingArea(int continuousIndex, int startCellIndex, int endCellIndex, EArrowDirection arrowDirection) : base(startCellIndex, endCellIndex, arrowDirection)
	{
		this.ContinuousIndex = continuousIndex;
	}

	// Token: 0x040034A3 RID: 13475
	public int ContinuousIndex;
}
