using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DA4 RID: 19876
	public class RogueTalentTreeDefine
	{
		// Token: 0x06033522 RID: 210210 RVA: 0x00BFA90C File Offset: 0x00BF8B0C
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

		// Token: 0x0401B451 RID: 111697
		public const int ROGUE_MAX_TALENT_NODES_IN_ROW = 6;

		// Token: 0x0401B452 RID: 111698
		public const int ROGUE_TALENT_TREE_TOP_LINE_OFFSET = 0;

		// Token: 0x0401B453 RID: 111699
		public const int ROGUE_TALENT_TREE_MID_LINE_OFFSET = 6;

		// Token: 0x0401B454 RID: 111700
		public const int ROGUE_TALENT_TREE_BOTTOM_LINE_OFFSET = 12;

		// Token: 0x0401B455 RID: 111701
		public const int ROGUE_TALENT_TREE_LEFT_LINE_OFFSET = 18;
	}
}
