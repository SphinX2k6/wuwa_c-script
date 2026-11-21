using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D6D RID: 15725
	public class RogueTalentTreeDefine
	{
		// Token: 0x0602838F RID: 164751 RVA: 0x00B43F08 File Offset: 0x00B42108
		public static int rogueLineIndex2NodeIndex(int lineIndex)
		{
			if (lineIndex >= 18)
			{
				return lineIndex - 18;
			}
			if (lineIndex >= 12)
			{
				return lineIndex - 12;
			}
			if (lineIndex >= 6)
			{
				return lineIndex - 6;
			}
			return lineIndex;
		}

		// Token: 0x04015E24 RID: 89636
		public const int ROGUE_MAX_TALENT_NODES_IN_ROW = 6;

		// Token: 0x04015E25 RID: 89637
		public const int ROGUE_TALENT_TREE_TOP_LINE_OFFSET = 0;

		// Token: 0x04015E26 RID: 89638
		public const int ROGUE_TALENT_TREE_MID_LINE_OFFSET = 6;

		// Token: 0x04015E27 RID: 89639
		public const int ROGUE_TALENT_TREE_BOTTOM_LINE_OFFSET = 12;

		// Token: 0x04015E28 RID: 89640
		public const int ROGUE_TALENT_TREE_LEFT_LINE_OFFSET = 18;
	}
}
