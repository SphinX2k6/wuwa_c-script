using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree
{
	// Token: 0x0200540A RID: 21514
	[NullableContext(1)]
	[Nullable(0)]
	public static class MatchThreeDefine
	{
		// Token: 0x06035736 RID: 218934 RVA: 0x00EECB28 File Offset: 0x00EEAD28
		public static bool TryGetInitialGuideGroupId(int levelId, out int guideGroupId)
		{
			if (levelId <= 100021)
			{
				if (levelId == 100011)
				{
					guideGroupId = 20602;
					return true;
				}
				if (levelId == 100021)
				{
					guideGroupId = 20605;
					return true;
				}
			}
			else
			{
				if (levelId == 100031)
				{
					guideGroupId = 20607;
					return true;
				}
				if (levelId == 100051)
				{
					guideGroupId = 20608;
					return true;
				}
			}
			guideGroupId = 0;
			return false;
		}

		// Token: 0x0401C310 RID: 115472
		public const int ENDLESS_CHAPTER = 8;

		// Token: 0x0401C311 RID: 115473
		public const int MATCH_THREE_LEVEL_CLICKED_KEY = 1;

		// Token: 0x0401C312 RID: 115474
		public const int MATCH_THREE_SELECTED_ROLE_KEY = 2;

		// Token: 0x0401C313 RID: 115475
		public const int MATCH_THREE_ROLE_UNLOCK_TIP_KEY = 3;

		// Token: 0x0401C314 RID: 115476
		public const int MATCH_THREE_ROLE_NEW_RED_DOT_KEY = 4;

		// Token: 0x0401C315 RID: 115477
		public const int MATCH_THREE_ROLE_SWITCH_BTN_RED_DOT_KEY = 5;

		// Token: 0x0401C316 RID: 115478
		public const int MATCH_THREE_GAMEPLAY_HELP_ID = 683;

		// Token: 0x0401C317 RID: 115479
		public const int BASIC_GUIDE_LEVEL_ID = 100011;

		// Token: 0x0401C318 RID: 115480
		public const int BOTTLE_GUIDE_LEVEL_ID = 100021;

		// Token: 0x0401C319 RID: 115481
		public const int ICE_GUIDE_LEVEL_ID = 100031;

		// Token: 0x0401C31A RID: 115482
		public const int HOURGLASS_GUIDE_LEVEL_ID = 100051;

		// Token: 0x0401C31B RID: 115483
		public const int BASIC_GUIDE_GROUP_ID = 20602;

		// Token: 0x0401C31C RID: 115484
		public const int BOTTLE_GUIDE_GROUP_ID = 20605;

		// Token: 0x0401C31D RID: 115485
		public const int ICE_GUIDE_GROUP_ID = 20607;

		// Token: 0x0401C31E RID: 115486
		public const int HOURGLASS_GUIDE_GROUP_ID = 20608;

		// Token: 0x0401C31F RID: 115487
		public const int SETTLE_REASON_NORMAL = 1;

		// Token: 0x0401C320 RID: 115488
		public const int SETTLE_REASON_QUIT = 2;

		// Token: 0x0401C321 RID: 115489
		public const string LOCK_TIME_TEXT_ID = "MatchThree_TimeCountdown";

		// Token: 0x0401C322 RID: 115490
		public const string LOCK_PRE_TEXT_ID = "MatchThree_FinishPrestage";

		// Token: 0x0401C323 RID: 115491
		public const string CHAPTER_DONE_TEXT_ID = "MatchThree_Completed";

		// Token: 0x0401C324 RID: 115492
		public const string CHAPTER_PROGRESS_TEXT_ID = "MatchThree_Ongoing";

		// Token: 0x0401C325 RID: 115493
		public const string ENDLESS_SCORE_TEXT_ID = "MatchThree_BestRecord";

		// Token: 0x0401C326 RID: 115494
		public const string ENDLESS_NO_SCORE_TEXT_ID = "MatchThree_NoRecord";

		// Token: 0x0401C327 RID: 115495
		public const string STAGE_GOAL_POINTS_TEXT_ID = "MatchThree_StageGoal_Points";

		// Token: 0x0401C328 RID: 115496
		public const string STAGE_GOAL_GEM_NUM_TEXT_ID = "MatchThree_StageGoal_GemNum";

		// Token: 0x0401C329 RID: 115497
		public const string STAGE_GOAL_ENDLESS_TEXT_ID = "MatchThree_StageGoal_Endless";

		// Token: 0x0401C32A RID: 115498
		public const string STAGE_GOAL_PIECE_HOURGLASS_TEXT_ID = "PieceName_2004";

		// Token: 0x0401C32B RID: 115499
		public const string STAGE_GOAL_PIECE_BOTTLE_TEXT_ID = "PieceName_2003";

		// Token: 0x0401C32C RID: 115500
		public const string DIFFICULTY_NORMAL_TEXT_ID = "Tetristext_06";

		// Token: 0x0401C32D RID: 115501
		public const string DIFFICULTY_HARD_TEXT_ID = "Tetristext_07";

		// Token: 0x0401C32E RID: 115502
		public const string LEVEL_DETAIL_TITLE_TEXT_ID = "MatchThree_LevelDetailTitle";

		// Token: 0x0401C32F RID: 115503
		public const string HARD_LOCK_TIPS_TEXT_ID = "Tetristext_14";

		// Token: 0x0401C330 RID: 115504
		public const string ENV_NO_EFFECT_TEXT_ID = "Weather_NoEffect";

		// Token: 0x0401C331 RID: 115505
		public const string ROLE_SELECT_CONFIRM_TEXT_ID = "RolePanel_Confirm";

		// Token: 0x0401C332 RID: 115506
		public const string ROLE_LOCK_BUTTON_TEXT_ID = "RolePanel_Locked";

		// Token: 0x0401C333 RID: 115507
		public const string ROLE_SKILL_ENERGY_TEXT_ID = "MatchThreeRoleRecharge";

		// Token: 0x0401C334 RID: 115508
		public const string ROLE_SPINE_IDLE_ANIM = "idle";

		// Token: 0x0401C335 RID: 115509
		public const string ROLE_SPINE_POSE_ANIM = "pose";

		// Token: 0x0401C336 RID: 115510
		public const string LEVEL_DETAIL_BG_NORMAL = "/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity37/Match3Game/T_LevelDetailBg1.T_LevelDetailBg1";

		// Token: 0x0401C337 RID: 115511
		public const string LEVEL_DETAIL_BG_ENDLESS = "/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity37/Match3Game/T_LevelDetailBg2.T_LevelDetailBg2";

		// Token: 0x0401C338 RID: 115512
		public const string LEVEL_DETAIL_INFO_TITLE_BG_NORMAL = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity37/Match3Game/LevelDetail/SP_InfoTitleBg1.SP_InfoTitleBg1";

		// Token: 0x0401C339 RID: 115513
		public const string LEVEL_DETAIL_INFO_TITLE_BG_ENDLESS = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity37/Match3Game/LevelDetail/SP_InfoTitleBg2.SP_InfoTitleBg2";

		// Token: 0x0401C33A RID: 115514
		public const string ROLE_SELECT_SWITCH_SEQUENCE = "Swtich";
	}
}
