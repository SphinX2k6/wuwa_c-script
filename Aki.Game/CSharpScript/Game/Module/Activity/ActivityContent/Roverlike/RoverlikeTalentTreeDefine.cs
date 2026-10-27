using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061A1 RID: 24993
	[NullableContext(1)]
	[Nullable(0)]
	public static class RoverlikeTalentTreeDefine
	{
		// Token: 0x0603F202 RID: 258562 RVA: 0x00F3F3C5 File Offset: 0x00F3D5C5
		public static int RoverlikeLineIndex2NodeIndex(int lineIndex)
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

		// Token: 0x04020E8C RID: 134796
		public const int ROVERLIKE_MAX_TALENT_NODES_IN_ROW = 6;

		// Token: 0x04020E8D RID: 134797
		public const int ROVERLIKE_TALENT_TREE_TOP_LINE_OFFSET = 0;

		// Token: 0x04020E8E RID: 134798
		public const int ROVERLIKE_TALENT_TREE_MID_LINE_OFFSET = 6;

		// Token: 0x04020E8F RID: 134799
		public const int ROVERLIKE_TALENT_TREE_BOTTOM_LINE_OFFSET = 12;

		// Token: 0x04020E90 RID: 134800
		public const int ROVERLIKE_TALENT_TREE_LEFT_LINE_OFFSET = 18;

		// Token: 0x04020E91 RID: 134801
		public const string ROVERLIKE_TALENT_NODE_PREFAB_NOR = "UiItem_RoverRougeTalentTreeNorNode";

		// Token: 0x04020E92 RID: 134802
		public const string ROVERLIKE_TALENT_NODE_PREFAB_SP = "UiItem_RoverRougeTalentTreeSPNode";

		// Token: 0x04020E93 RID: 134803
		public const string ROVERLIKE_TALENT_TREE_TYPE_TEXT_LEFT = "RoverRogue_TalentTree_TypeLeft";

		// Token: 0x04020E94 RID: 134804
		public const string ROVERLIKE_TALENT_TREE_TYPE_TEXT_MIDDLE = "RoverRogue_TalentTree_TypeMiddle";

		// Token: 0x04020E95 RID: 134805
		public const string ROVERLIKE_TALENT_TREE_TYPE_TEXT_RIGHT = "RoverRogue_TalentTree_TypeRight";

		// Token: 0x04020E96 RID: 134806
		public const string ROVERLIKE_TALENT_TREE_ACTIVATE_TEXT = "RoverRogue_TalentTree_Activate";

		// Token: 0x04020E97 RID: 134807
		public const string ROVERLIKE_TALENT_TREE_NEXT_TITLE_UNLOCK = "RoverRogue_TalentTreeUnlockShow";

		// Token: 0x04020E98 RID: 134808
		public const string ROVERLIKE_TALENT_TREE_NEXT_TITLE_UPGRADE = "PrefabTextItem_124464148_Text";
	}
}
