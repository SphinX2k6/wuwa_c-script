using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x02005806 RID: 22534
	[NullableContext(1)]
	[Nullable(0)]
	public static class CyberPunkConst
	{
		// Token: 0x0401D53A RID: 120122
		public const string CHALLENGE_ITEM_SPRITE_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity34/Cyberpunk/Challenge";

		// Token: 0x0401D53B RID: 120123
		public const string HARD_COLOR = "FF1D28FF";

		// Token: 0x0401D53C RID: 120124
		public const string NORMAL_COLOR = "FFFFFFFF";

		// Token: 0x0401D53D RID: 120125
		public const int STORY_FUNCTION_ID = 1;

		// Token: 0x0401D53E RID: 120126
		public const int ADAMSMASHER_FUNCTION_ID = 5;

		// Token: 0x0401D53F RID: 120127
		public const int COLLAB_DIRECT_TRAIN_TASK_ID = 915700000;

		// Token: 0x0401D540 RID: 120128
		public const int COLLAB_DIRECT_TRAIN_ACTIVITY_ID = 103000004;

		// Token: 0x0401D541 RID: 120129
		public const int COLLAB_DIRECT_PRE_TRAIN_ACTIVITY_ID = 103000099;

		// Token: 0x0401D542 RID: 120130
		public const int TRIAL_ROLE_JUMPPOOL_ID = 100068;

		// Token: 0x0401D543 RID: 120131
		public const int ADAM_SMASHER_ENTRANCE_ID = 6090;

		// Token: 0x0401D544 RID: 120132
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyList<string> AdamSmasherSceneEffectPathList = new string[]
		{
			"/Game/Aki/Effect/EffectGroup/ML1AdamSmasherMd00001/DA_Fx_Group_Adam_ML_MengyanBuff_02.DA_Fx_Group_Adam_ML_MengyanBuff_02",
			"/Game/Aki/Effect/MaterialController/DA_Lord/ML1AdamSmasherMd00001/DA_Fx_AdamSmasher_Buff_04.DA_Fx_AdamSmasher_Buff_04"
		};
	}
}
