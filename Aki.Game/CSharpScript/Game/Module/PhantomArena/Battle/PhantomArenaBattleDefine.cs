using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200523F RID: 21055
	[NullableContext(1)]
	[Nullable(0)]
	public static class PhantomArenaBattleDefine
	{
		// Token: 0x0401C833 RID: 116787
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

		// Token: 0x0401C834 RID: 116788
		public const int CHECK_ATTACH_DISTANCE = 200;

		// Token: 0x0401C835 RID: 116789
		public const int DISTANCE_MAX = 99999;

		// Token: 0x0401C836 RID: 116790
		public const int HANDCARD_LIMIT = 6;

		// Token: 0x0401C837 RID: 116791
		public const int HAND_PHANTOMARENA_INDEX = -1;

		// Token: 0x0401C838 RID: 116792
		public const int INVALID_CARD_ID = -1;

		// Token: 0x0401C839 RID: 116793
		public const int UNVALID_FIGHT_ID = -1;

		// Token: 0x0401C83A RID: 116794
		public const int UNVALID_DURABILITY = -1;

		// Token: 0x0401C83B RID: 116795
		public const int LIMIT_BATTLE_CARD_NUM = 4;

		// Token: 0x0401C83C RID: 116796
		public const int COST_ONE = 1;

		// Token: 0x0401C83D RID: 116797
		public const int COST_THREE = 3;

		// Token: 0x0401C83E RID: 116798
		public const int AI_SENSE_ID = 80017;

		// Token: 0x0401C83F RID: 116799
		public const string AI_HATE_ID = "80017";

		// Token: 0x0401C840 RID: 116800
		public const int HIDETIPS_BY_FUNCTIONALDRAG_DISTANCE = 100;

		// Token: 0x0401C841 RID: 116801
		public const int PLAY_STARTTIME_CARD_TWEEN_DELAY = 30;

		// Token: 0x0401C842 RID: 116802
		public const float PLAY_TWEEN_DURATION = 0.5f;

		// Token: 0x0401C843 RID: 116803
		public const float PLAY_RESET_POS_TWEEN_DURATION = 0.2f;

		// Token: 0x0401C844 RID: 116804
		public const float PLAY_CHANGE_CARD_TWEEN_DURATION = 0.2f;

		// Token: 0x0401C845 RID: 116805
		public const float PLAY_MOVE_DURATION = 0.2f;

		// Token: 0x0401C846 RID: 116806
		public const float ACCUMULATE_TWEEN_TIME = 0.3f;

		// Token: 0x0401C847 RID: 116807
		public const float DAMAGE_TWEEN_TIME = 0.4f;

		// Token: 0x0401C848 RID: 116808
		public const float DAMAGE_COUNT_TWEEN_TIME = 0.2f;

		// Token: 0x0401C849 RID: 116809
		public const float NPC_DISSOLVE_VALUE = 0.55f;

		// Token: 0x0401C84A RID: 116810
		public const float NPC_DISSOLVE_TWEEN_TIME = 0.5f;

		// Token: 0x0401C84B RID: 116811
		public const string ENTITY_COMPONENT_DISABLE_KEY = "PhantomArenaBattle";

		// Token: 0x0401C84C RID: 116812
		public const string HIT_AUDIO = "play_ui_phantomarena_missile_shot_cardskill";

		// Token: 0x0401C84D RID: 116813
		public const string DAMAGE_AUDIO = "play_ui_phantomarena_missile_shot_settlement";
	}
}
