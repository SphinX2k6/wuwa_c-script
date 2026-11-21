using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200420F RID: 16911
	[NullableContext(1)]
	[Nullable(0)]
	public static class PhantomArenaBattleDefine
	{
		// Token: 0x04017268 RID: 94824
		[StaticVariableRuleIgnore]
		public static readonly int[] functionAreaTypeList = new int[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			1
		};

		// Token: 0x04017269 RID: 94825
		public const int CHECK_ATTACH_DISTANCE = 200;

		// Token: 0x0401726A RID: 94826
		public const int DISTANCE_MAX = 99999;

		// Token: 0x0401726B RID: 94827
		public const int HANDCARD_LIMIT = 6;

		// Token: 0x0401726C RID: 94828
		public const int HAND_PHANTOMARENA_INDEX = -1;

		// Token: 0x0401726D RID: 94829
		public const int INVALID_CARD_ID = -1;

		// Token: 0x0401726E RID: 94830
		public const int UNVALID_FIGHT_ID = -1;

		// Token: 0x0401726F RID: 94831
		public const int UNVALID_DURABILITY = -1;

		// Token: 0x04017270 RID: 94832
		public const int LIMIT_BATTLE_CARD_NUM = 4;

		// Token: 0x04017271 RID: 94833
		public const int COST_ONE = 1;

		// Token: 0x04017272 RID: 94834
		public const int COST_THREE = 3;

		// Token: 0x04017273 RID: 94835
		public const int AI_SENSE_ID = 80017;

		// Token: 0x04017274 RID: 94836
		public const string AI_HATE_ID = "80017";

		// Token: 0x04017275 RID: 94837
		public const int HIDETIPS_BY_FUNCTIONALDRAG_DISTANCE = 100;

		// Token: 0x04017276 RID: 94838
		public const int PLAY_STARTTIME_CARD_TWEEN_DELAY = 30;

		// Token: 0x04017277 RID: 94839
		public const float PLAY_TWEEN_DURATION = 0.5f;

		// Token: 0x04017278 RID: 94840
		public const float PLAY_RESET_POS_TWEEN_DURATION = 0.2f;

		// Token: 0x04017279 RID: 94841
		public const float PLAY_CHANGE_CARD_TWEEN_DURATION = 0.2f;

		// Token: 0x0401727A RID: 94842
		public const float PLAY_MOVE_DURATION = 0.2f;

		// Token: 0x0401727B RID: 94843
		public const float ACCUMULATE_TWEEN_TIME = 0.3f;

		// Token: 0x0401727C RID: 94844
		public const float DAMAGE_TWEEN_TIME = 0.4f;

		// Token: 0x0401727D RID: 94845
		public const float DAMAGE_COUNT_TWEEN_TIME = 0.2f;

		// Token: 0x0401727E RID: 94846
		public const float NPC_DISSOLVE_VALUE = 0.55f;

		// Token: 0x0401727F RID: 94847
		public const float NPC_DISSOLVE_TWEEN_TIME = 0.5f;

		// Token: 0x04017280 RID: 94848
		public const string ENTITY_COMPONENT_DISABLE_KEY = "PhantomArenaBattle";

		// Token: 0x04017281 RID: 94849
		public const string HIT_AUDIO = "play_ui_phantomarena_missile_shot_cardskill";

		// Token: 0x04017282 RID: 94850
		public const string DAMAGE_AUDIO = "play_ui_phantomarena_missile_shot_settlement";
	}
}
