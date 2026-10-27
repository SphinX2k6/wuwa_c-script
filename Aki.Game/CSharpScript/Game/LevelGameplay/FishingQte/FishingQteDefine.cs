using System;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E25 RID: 28197
	public class FishingQteDefine
	{
		// Token: 0x06044BD8 RID: 281560 RVA: 0x010F75FC File Offset: 0x010F57FC
		public static int calculateCellSize(int startIndex, int endIndex)
		{
			if (endIndex >= startIndex)
			{
				return endIndex - startIndex + 1;
			}
			return 36 - startIndex + endIndex + 1;
		}

		// Token: 0x06044BD9 RID: 281561 RVA: 0x010F7610 File Offset: 0x010F5810
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

		// Token: 0x04023C1F RID: 146463
		public const int FISHINGQTE_RINGCELLCOUNT = 36;

		// Token: 0x04023C20 RID: 146464
		public const int FISHINGQTE_RING_ANGLE = 360;

		// Token: 0x04023C21 RID: 146465
		public const int FISHINGQTE_SINGLECELL_ANGLE = 10;
	}
}
