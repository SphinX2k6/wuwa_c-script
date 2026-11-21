using System;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FA5 RID: 24485
	public class FishingQteDefine
	{
		// Token: 0x0603AD41 RID: 240961 RVA: 0x010A1B38 File Offset: 0x0109FD38
		public static int calculateCellSize(int startIndex, int endIndex)
		{
			if (endIndex >= startIndex)
			{
				return endIndex - startIndex + 1;
			}
			return 36 - startIndex + endIndex + 1;
		}

		// Token: 0x0603AD42 RID: 240962 RVA: 0x010A1B4C File Offset: 0x0109FD4C
		public static int fixedCellIndex(int index)
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

		// Token: 0x0401EEC2 RID: 126658
		public const int FISHINGQTE_RINGCELLCOUNT = 36;

		// Token: 0x0401EEC3 RID: 126659
		public const int FISHINGQTE_RING_ANGLE = 360;

		// Token: 0x0401EEC4 RID: 126660
		public const int FISHINGQTE_SINGLECELL_ANGLE = 10;
	}
}
