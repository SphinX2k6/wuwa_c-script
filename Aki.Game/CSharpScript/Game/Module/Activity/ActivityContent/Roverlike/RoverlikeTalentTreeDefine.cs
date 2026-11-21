using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200511F RID: 20767
	[NullableContext(1)]
	[Nullable(0)]
	public static class RoverlikeTalentTreeDefine
	{
		// Token: 0x06033EC2 RID: 212674 RVA: 0x00E8628D File Offset: 0x00E8448D
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

		// Token: 0x0401B7B9 RID: 112569
		public const int ROVERLIKE_MAX_TALENT_NODES_IN_ROW = 6;

		// Token: 0x0401B7BA RID: 112570
		public const int ROVERLIKE_TALENT_TREE_TOP_LINE_OFFSET = 0;

		// Token: 0x0401B7BB RID: 112571
		public const int ROVERLIKE_TALENT_TREE_MID_LINE_OFFSET = 6;

		// Token: 0x0401B7BC RID: 112572
		public const int ROVERLIKE_TALENT_TREE_BOTTOM_LINE_OFFSET = 12;

		// Token: 0x0401B7BD RID: 112573
		public const int ROVERLIKE_TALENT_TREE_LEFT_LINE_OFFSET = 18;

		// Token: 0x0401B7BE RID: 112574
		public const string ROVERLIKE_TALENT_NODE_PREFAB_NOR = "UiItem_RoverRougeTalentTreeNorNode";

		// Token: 0x0401B7BF RID: 112575
		public const string ROVERLIKE_TALENT_NODE_PREFAB_SP = "UiItem_RoverRougeTalentTreeSPNode";

		// Token: 0x0401B7C0 RID: 112576
		public const string ROVERLIKE_TALENT_TREE_TYPE_TEXT_LEFT = "RoverRogue_TalentTree_TypeLeft";

		// Token: 0x0401B7C1 RID: 112577
		public const string ROVERLIKE_TALENT_TREE_TYPE_TEXT_MIDDLE = "RoverRogue_TalentTree_TypeMiddle";

		// Token: 0x0401B7C2 RID: 112578
		public const string ROVERLIKE_TALENT_TREE_TYPE_TEXT_RIGHT = "RoverRogue_TalentTree_TypeRight";

		// Token: 0x0401B7C3 RID: 112579
		public const string ROVERLIKE_TALENT_TREE_ACTIVATE_TEXT = "RoverRogue_TalentTree_Activate";

		// Token: 0x0401B7C4 RID: 112580
		public const string ROVERLIKE_TALENT_TREE_NEXT_TITLE_UNLOCK = "RoverRogue_TalentTreeUnlockShow";

		// Token: 0x0401B7C5 RID: 112581
		public const string ROVERLIKE_TALENT_TREE_NEXT_TITLE_UPGRADE = "PrefabTextItem_124464148_Text";
	}
}
