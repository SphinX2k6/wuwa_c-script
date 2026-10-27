using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B2C RID: 19244
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenceDefine : IStaticVariableResetter
	{
		// Token: 0x06031D70 RID: 204144 RVA: 0x00B92582 File Offset: 0x00B90782
		static TowerDefenceDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenceDefine.CreateStaticDefaultValue), new Action(TowerDefenceDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06031D71 RID: 204145 RVA: 0x00B925A4 File Offset: 0x00B907A4
		public static void CreateStaticDefaultValue()
		{
			TowerDefenceDefine.entranceSet = new HashSet<int>
			{
				8170,
				8180,
				8610
			};
			TowerDefenceDefine.tabText = new Dictionary<TowerDefenceDefine.ETabType, string>
			{
				{
					TowerDefenceDefine.ETabType.Single,
					"OnlineGymnasium_SingleListName"
				},
				{
					TowerDefenceDefine.ETabType.Online,
					"OnlineGymnasium_OnlineListName"
				}
			};
			TowerDefenceDefine.inBattleQualitySpriteKey = new Dictionary<InventoryDefine.EQuality, string>
			{
				{
					InventoryDefine.EQuality.White,
					"SP_VisionlQualityA"
				},
				{
					InventoryDefine.EQuality.Green,
					"SP_VisionlQualityB"
				},
				{
					InventoryDefine.EQuality.Blue,
					"SP_VisionlQualityC"
				},
				{
					InventoryDefine.EQuality.Purple,
					"SP_VisionlQualityD"
				},
				{
					InventoryDefine.EQuality.Orange,
					"SP_VisionlQualityE"
				}
			};
		}

		// Token: 0x06031D72 RID: 204146 RVA: 0x00B92647 File Offset: 0x00B90847
		public static void ResetStaticDefaultValue()
		{
			TowerDefenceDefine.entranceSet = null;
			TowerDefenceDefine.tabText = null;
			TowerDefenceDefine.inBattleQualitySpriteKey = null;
		}

		// Token: 0x0401A983 RID: 108931
		public const int DEFAULT_ID = 0;

		// Token: 0x0401A984 RID: 108932
		public const int NIL_PHANTOM_ID = -1;

		// Token: 0x0401A985 RID: 108933
		public const int INSTANCE_SUCCESS = 3018;

		// Token: 0x0401A986 RID: 108934
		public const int INSTANCE_FAIL = 3017;

		// Token: 0x0401A987 RID: 108935
		public const string EXIT_POPUP_TITLE = "TowerDefence_ExitTitle";

		// Token: 0x0401A988 RID: 108936
		public const string EXIT_POPUP_CONTENT = "TowerDefence_ExitContent";

		// Token: 0x0401A989 RID: 108937
		public const string EXIT_POPUP_TIPS_SINGLE = "TowerDefence_ExitTipsSingle";

		// Token: 0x0401A98A RID: 108938
		public const string EXIT_POPUP_TIPS_MULTI = "TowerDefence_ExitTipsMulti";

		// Token: 0x0401A98B RID: 108939
		public const string SETTLE_TEXT_EXIT_BTN = "Text_ButtonTextExit_Text";

		// Token: 0x0401A98C RID: 108940
		public const string SETTLE_TEXT_RESTART_BTN = "Text_ChallengeAgain_Text";

		// Token: 0x0401A98D RID: 108941
		public const string SETTLE_TEXT_TITLE_WIN = "Text_ChallengeSuccess_Text";

		// Token: 0x0401A98E RID: 108942
		public const string SETTLE_TEXT_TITLE_LOSE = "TowerDefenceSettlement01";

		// Token: 0x0401A98F RID: 108943
		public const string SETTLE_TEXT_HIGHEST_TIME = "TowerDefenceBestTime";

		// Token: 0x0401A990 RID: 108944
		public const string SETTLE_TEXT_HIGHEST_SCORE = "TowerDefence_GPint";

		// Token: 0x0401A991 RID: 108945
		public const string SETTLE_TEXT_RECORD_TITLE_CHALLENGE = "PrefabTextItem_3771425333_Text";

		// Token: 0x0401A992 RID: 108946
		public const string SETTLE_TEXT_RECORD_TITLE_CHALLENGE_LOSE = "TowerDefencelose";

		// Token: 0x0401A993 RID: 108947
		public const string SETTLE_TEXT_RECORD_TITLE_NORMAL = "PrefabTextItem_1350027209_Text";

		// Token: 0x0401A994 RID: 108948
		public const string LEVEL_TEXT_DIFFICULTY_NORMAL = "TowerDefence_DifficultyNormal";

		// Token: 0x0401A995 RID: 108949
		public const string LEVEL_TEXT_DIFFICULTY_HARD = "TowerDefence_DifficultyHard";

		// Token: 0x0401A996 RID: 108950
		public const string LEVEL_TEXT_SUB_LEVEL_LOCKED = "TowerDefence_SubLevelLocked";

		// Token: 0x0401A997 RID: 108951
		public const string LEVEL_TEXT_SUB_LEVEL_UNPASSED = "TowerDefence_SubLevelUnpassed";

		// Token: 0x0401A998 RID: 108952
		public const string LEVEL_TEXT_SUB_LEVEL_PASSED = "TowerDefence_SubLevelPassed";

		// Token: 0x0401A999 RID: 108953
		public const string LEVEL_TEXT_LEVEL_LOCKED_TIP = "TowerDefence_LevelLocked";

		// Token: 0x0401A99A RID: 108954
		public const string LEVEL_TEXT_PRE_NORMAL_UNPASSED = "OnlineGymnasium_LevelRst";

		// Token: 0x0401A99B RID: 108955
		public const string LEVEL_TEXT_BOSS_RUSH_LOCKED = "TowerDefence_Lcok_TipsText";

		// Token: 0x0401A99C RID: 108956
		public const string LEVEL_TEXT_COUNT_DOWN_WRAP = "ActivityMowing_UnlockCondition";

		// Token: 0x0401A99D RID: 108957
		public const string IN_BATTLE_SKILL_TITLE_BG_CURRENT = "T_LordGymTitleBgB";

		// Token: 0x0401A99E RID: 108958
		public const string IN_BATTLE_SKILL_TITLE_BG_NORMAL = "T_LordGymTitleBgA";

		// Token: 0x0401A99F RID: 108959
		public static HashSet<int> entranceSet;

		// Token: 0x0401A9A0 RID: 108960
		public static Dictionary<TowerDefenceDefine.ETabType, string> tabText;

		// Token: 0x0401A9A1 RID: 108961
		public static Dictionary<InventoryDefine.EQuality, string> inBattleQualitySpriteKey;

		// Token: 0x0200ACBE RID: 44222
		[NullableContext(0)]
		public enum EActivityType
		{
			// Token: 0x040347BA RID: 214970
			Defense = 1,
			// Token: 0x040347BB RID: 214971
			Attack
		}

		// Token: 0x0200ACBF RID: 44223
		[NullableContext(0)]
		public enum ETabType
		{
			// Token: 0x040347BD RID: 214973
			Single,
			// Token: 0x040347BE RID: 214974
			Online
		}
	}
}
