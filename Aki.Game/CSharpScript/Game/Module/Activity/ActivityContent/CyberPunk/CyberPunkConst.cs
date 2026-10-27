using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068B6 RID: 26806
	[NullableContext(1)]
	[Nullable(0)]
	public static class CyberPunkConst
	{
		// Token: 0x04022CDE RID: 142558
		public const string CHALLENGE_ITEM_SPRITE_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity34/Cyberpunk/Challenge";

		// Token: 0x04022CDF RID: 142559
		public const string HARD_COLOR = "FF1D28FF";

		// Token: 0x04022CE0 RID: 142560
		public const string NORMAL_COLOR = "FFFFFFFF";

		// Token: 0x04022CE1 RID: 142561
		public const int STORY_FUNCTION_ID = 1;

		// Token: 0x04022CE2 RID: 142562
		public const int ADAMSMASHER_FUNCTION_ID = 5;

		// Token: 0x04022CE3 RID: 142563
		public const int COLLAB_DIRECT_TRAIN_TASK_ID = 915700000;

		// Token: 0x04022CE4 RID: 142564
		public const int COLLAB_DIRECT_TRAIN_ACTIVITY_ID = 103000004;

		// Token: 0x04022CE5 RID: 142565
		public const int COLLAB_DIRECT_PRE_TRAIN_ACTIVITY_ID = 103000099;

		// Token: 0x04022CE6 RID: 142566
		public const int TRIAL_ROLE_JUMPPOOL_ID = 100068;

		// Token: 0x04022CE7 RID: 142567
		public const int ADAM_SMASHER_ENTRANCE_ID = 6090;

		// Token: 0x04022CE8 RID: 142568
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyList<string> AdamSmasherSceneEffectPathList = new string[]
		{
			"/Game/Aki/Effect/EffectGroup/ML1AdamSmasherMd00001/DA_Fx_Group_Adam_ML_MengyanBuff_02.DA_Fx_Group_Adam_ML_MengyanBuff_02",
			"/Game/Aki/Effect/MaterialController/DA_Lord/ML1AdamSmasherMd00001/DA_Fx_AdamSmasher_Buff_04.DA_Fx_AdamSmasher_Buff_04"
		};
	}
}
