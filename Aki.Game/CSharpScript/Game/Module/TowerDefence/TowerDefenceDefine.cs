using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD4 RID: 15060
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenceDefine : IStaticVariableResetter
	{
		// Token: 0x06026B00 RID: 158464 RVA: 0x00AD65E6 File Offset: 0x00AD47E6
		static TowerDefenceDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenceDefine.CreateStaticDefaultValue), new Action(TowerDefenceDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06026B01 RID: 158465 RVA: 0x00AD6608 File Offset: 0x00AD4808
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

		// Token: 0x06026B02 RID: 158466 RVA: 0x00AD66AB File Offset: 0x00AD48AB
		public static void ResetStaticDefaultValue()
		{
			TowerDefenceDefine.entranceSet = null;
			TowerDefenceDefine.tabText = null;
			TowerDefenceDefine.inBattleQualitySpriteKey = null;
		}

		// Token: 0x040152D5 RID: 86741
		public const int DEFAULT_ID = 0;

		// Token: 0x040152D6 RID: 86742
		public const int NIL_PHANTOM_ID = -1;

		// Token: 0x040152D7 RID: 86743
		public const int INSTANCE_SUCCESS = 3018;

		// Token: 0x040152D8 RID: 86744
		public const int INSTANCE_FAIL = 3017;

		// Token: 0x040152D9 RID: 86745
		public const string EXIT_POPUP_TITLE = "TowerDefence_ExitTitle";

		// Token: 0x040152DA RID: 86746
		public const string EXIT_POPUP_CONTENT = "TowerDefence_ExitContent";

		// Token: 0x040152DB RID: 86747
		public const string EXIT_POPUP_TIPS_SINGLE = "TowerDefence_ExitTipsSingle";

		// Token: 0x040152DC RID: 86748
		public const string EXIT_POPUP_TIPS_MULTI = "TowerDefence_ExitTipsMulti";

		// Token: 0x040152DD RID: 86749
		public const string SETTLE_TEXT_EXIT_BTN = "Text_ButtonTextExit_Text";

		// Token: 0x040152DE RID: 86750
		public const string SETTLE_TEXT_RESTART_BTN = "Text_ChallengeAgain_Text";

		// Token: 0x040152DF RID: 86751
		public const string SETTLE_TEXT_TITLE_WIN = "Text_ChallengeSuccess_Text";

		// Token: 0x040152E0 RID: 86752
		public const string SETTLE_TEXT_TITLE_LOSE = "TowerDefenceSettlement01";

		// Token: 0x040152E1 RID: 86753
		public const string SETTLE_TEXT_HIGHEST_TIME = "TowerDefenceBestTime";

		// Token: 0x040152E2 RID: 86754
		public const string SETTLE_TEXT_HIGHEST_SCORE = "TowerDefence_GPint";

		// Token: 0x040152E3 RID: 86755
		public const string SETTLE_TEXT_RECORD_TITLE_CHALLENGE = "PrefabTextItem_3771425333_Text";

		// Token: 0x040152E4 RID: 86756
		public const string SETTLE_TEXT_RECORD_TITLE_CHALLENGE_LOSE = "TowerDefencelose";

		// Token: 0x040152E5 RID: 86757
		public const string SETTLE_TEXT_RECORD_TITLE_NORMAL = "PrefabTextItem_1350027209_Text";

		// Token: 0x040152E6 RID: 86758
		public const string LEVEL_TEXT_DIFFICULTY_NORMAL = "TowerDefence_DifficultyNormal";

		// Token: 0x040152E7 RID: 86759
		public const string LEVEL_TEXT_DIFFICULTY_HARD = "TowerDefence_DifficultyHard";

		// Token: 0x040152E8 RID: 86760
		public const string LEVEL_TEXT_SUB_LEVEL_LOCKED = "TowerDefence_SubLevelLocked";

		// Token: 0x040152E9 RID: 86761
		public const string LEVEL_TEXT_SUB_LEVEL_UNPASSED = "TowerDefence_SubLevelUnpassed";

		// Token: 0x040152EA RID: 86762
		public const string LEVEL_TEXT_SUB_LEVEL_PASSED = "TowerDefence_SubLevelPassed";

		// Token: 0x040152EB RID: 86763
		public const string LEVEL_TEXT_LEVEL_LOCKED_TIP = "TowerDefence_LevelLocked";

		// Token: 0x040152EC RID: 86764
		public const string LEVEL_TEXT_PRE_NORMAL_UNPASSED = "OnlineGymnasium_LevelRst";

		// Token: 0x040152ED RID: 86765
		public const string LEVEL_TEXT_BOSS_RUSH_LOCKED = "TowerDefence_Lcok_TipsText";

		// Token: 0x040152EE RID: 86766
		public const string LEVEL_TEXT_COUNT_DOWN_WRAP = "ActivityMowing_UnlockCondition";

		// Token: 0x040152EF RID: 86767
		public const string IN_BATTLE_SKILL_TITLE_BG_CURRENT = "T_LordGymTitleBgB";

		// Token: 0x040152F0 RID: 86768
		public const string IN_BATTLE_SKILL_TITLE_BG_NORMAL = "T_LordGymTitleBgA";

		// Token: 0x040152F1 RID: 86769
		public static HashSet<int> entranceSet;

		// Token: 0x040152F2 RID: 86770
		public static Dictionary<TowerDefenceDefine.ETabType, string> tabText;

		// Token: 0x040152F3 RID: 86771
		public static Dictionary<InventoryDefine.EQuality, string> inBattleQualitySpriteKey;

		// Token: 0x020096DE RID: 38622
		[NullableContext(0)]
		public enum EActivityType
		{
			// Token: 0x0402F16B RID: 192875
			Defense = 1,
			// Token: 0x0402F16C RID: 192876
			Attack
		}

		// Token: 0x020096DF RID: 38623
		[NullableContext(0)]
		public enum ETabType
		{
			// Token: 0x0402F16E RID: 192878
			Single,
			// Token: 0x0402F16F RID: 192879
			Online
		}
	}
}
