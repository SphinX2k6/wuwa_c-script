using System;

// Token: 0x020005AB RID: 1451
public static class ArtemisQteDefine
{
	// Token: 0x060044E7 RID: 17639 RVA: 0x0017AE7E File Offset: 0x0017907E
	public static int CalculateCellSize(int startIndex, int endIndex)
	{
		if (endIndex >= startIndex)
		{
			return endIndex - startIndex + 1;
		}
		return 36 - startIndex + endIndex + 1;
	}

	// Token: 0x060044E8 RID: 17640 RVA: 0x0017AE94 File Offset: 0x00179094
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

	// Token: 0x0400350C RID: 13580
	public const int QTE_RINGCELLCOUNT = 36;

	// Token: 0x0400350D RID: 13581
	public const int QTE_RING_ANGLE = 360;

	// Token: 0x0400350E RID: 13582
	public const int QTE_SINGLECELL_ANGLE = 10;
}
