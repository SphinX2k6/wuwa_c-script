using System;

// Token: 0x020005B4 RID: 1460
public class RingArea
{
	// Token: 0x06004501 RID: 17665 RVA: 0x0017B254 File Offset: 0x00179454
	public RingArea(int startCellIndex, int endCellIndex, EArrowDirection arrowDirection)
	{
		this.StartCellIndex = startCellIndex;
		this.EndCellIndex = endCellIndex;
		this.ArrowDirection = arrowDirection;
	}

	// Token: 0x06004502 RID: 17666 RVA: 0x0017B274 File Offset: 0x00179474
	public void OnArrowDirectionReverse()
	{
		EArrowDirection arrowDirection = this.ArrowDirection;
		if (arrowDirection == EArrowDirection.Clockwise)
		{
			this.ArrowDirection = EArrowDirection.Anticlockwise;
			return;
		}
		if (arrowDirection != EArrowDirection.Anticlockwise)
		{
			return;
		}
		this.ArrowDirection = EArrowDirection.Clockwise;
	}

	// Token: 0x04003539 RID: 13625
	public int StartCellIndex;

	// Token: 0x0400353A RID: 13626
	public int EndCellIndex;

	// Token: 0x0400353B RID: 13627
	public EArrowDirection ArrowDirection;
}
