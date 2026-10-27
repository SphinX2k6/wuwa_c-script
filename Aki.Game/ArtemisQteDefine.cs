using System;

// Token: 0x020010F7 RID: 4343
public static class ArtemisQteDefine
{
	// Token: 0x06007151 RID: 29009 RVA: 0x001724C2 File Offset: 0x001706C2
	public static int CalculateCellSize(int startIndex, int endIndex)
	{
		if (endIndex >= startIndex)
		{
			return endIndex - startIndex + 1;
		}
		return 36 - startIndex + endIndex + 1;
	}

	// Token: 0x06007152 RID: 29010 RVA: 0x001724D8 File Offset: 0x001706D8
	public static int FixedCellIndex(int index)
	{
		if (index > 36)
		{
			int num = index % 36;
			if (num != 0)
			{
				return num;
			}
			return 36;
		}
		else
		{
			if (index <= 0)
			{
				return index + 36;
			}
			return index;
		}
	}

	// Token: 0x04003473 RID: 13427
	public const int QTE_RINGCELLCOUNT = 36;

	// Token: 0x04003474 RID: 13428
	public const int QTE_RING_ANGLE = 360;

	// Token: 0x04003475 RID: 13429
	public const int QTE_SINGLECELL_ANGLE = 10;
}
