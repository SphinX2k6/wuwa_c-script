using System;

// Token: 0x02001100 RID: 4352
public class RingArea
{
	// Token: 0x0600716B RID: 29035 RVA: 0x00172898 File Offset: 0x00170A98
	public RingArea(int startCellIndex, int endCellIndex, EArrowDirection arrowDirection)
	{
		this.StartCellIndex = startCellIndex;
		this.EndCellIndex = endCellIndex;
		this.ArrowDirection = arrowDirection;
	}

	// Token: 0x0600716C RID: 29036 RVA: 0x001728B8 File Offset: 0x00170AB8
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

	// Token: 0x040034A0 RID: 13472
	public int StartCellIndex;

	// Token: 0x040034A1 RID: 13473
	public int EndCellIndex;

	// Token: 0x040034A2 RID: 13474
	public EArrowDirection ArrowDirection;
}
