using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree
{
	// Token: 0x0200648C RID: 25740
	[NullableContext(1)]
	[Nullable(0)]
	public static class MatchThreeDefine
	{
		// Token: 0x06040A72 RID: 264818 RVA: 0x00FA5AE0 File Offset: 0x00FA3CE0
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

		// Token: 0x040219DF RID: 137695
		public const int ENDLESS_CHAPTER = 8;

		// Token: 0x040219E0 RID: 137696
		public const int MATCH_THREE_LEVEL_CLICKED_KEY = 1;

		// Token: 0x040219E1 RID: 137697
		public const int MATCH_THREE_SELECTED_ROLE_KEY = 2;

		// Token: 0x040219E2 RID: 137698
		public const int MATCH_THREE_ROLE_UNLOCK_TIP_KEY = 3;

		// Token: 0x040219E3 RID: 137699
		public const int MATCH_THREE_ROLE_NEW_RED_DOT_KEY = 4;

		// Token: 0x040219E4 RID: 137700
		public const int MATCH_THREE_ROLE_SWITCH_BTN_RED_DOT_KEY = 5;

		// Token: 0x040219E5 RID: 137701
		public const int MATCH_THREE_GAMEPLAY_HELP_ID = 683;

		// Token: 0x040219E6 RID: 137702
		public const int BASIC_GUIDE_LEVEL_ID = 100011;

		// Token: 0x040219E7 RID: 137703
		public const int BOTTLE_GUIDE_LEVEL_ID = 100021;

		// Token: 0x040219E8 RID: 137704
		public const int ICE_GUIDE_LEVEL_ID = 100031;

		// Token: 0x040219E9 RID: 137705
		public const int HOURGLASS_GUIDE_LEVEL_ID = 100051;

		// Token: 0x040219EA RID: 137706
		public const int BASIC_GUIDE_GROUP_ID = 20602;

		// Token: 0x040219EB RID: 137707
		public const int BOTTLE_GUIDE_GROUP_ID = 20605;

		// Token: 0x040219EC RID: 137708
		public const int ICE_GUIDE_GROUP_ID = 20607;

		// Token: 0x040219ED RID: 137709
		public const int HOURGLASS_GUIDE_GROUP_ID = 20608;

		// Token: 0x040219EE RID: 137710
		public const int SETTLE_REASON_NORMAL = 1;

		// Token: 0x040219EF RID: 137711
		public const int SETTLE_REASON_QUIT = 2;

		// Token: 0x040219F0 RID: 137712
		public const string LOCK_TIME_TEXT_ID = "MatchThree_TimeCountdown";

		// Token: 0x040219F1 RID: 137713
		public const string LOCK_PRE_TEXT_ID = "MatchThree_FinishPrestage";

		// Token: 0x040219F2 RID: 137714
		public const string CHAPTER_DONE_TEXT_ID = "MatchThree_Completed";

		// Token: 0x040219F3 RID: 137715
		public const string CHAPTER_PROGRESS_TEXT_ID = "MatchThree_Ongoing";

		// Token: 0x040219F4 RID: 137716
		public const string ENDLESS_SCORE_TEXT_ID = "MatchThree_BestRecord";

		// Token: 0x040219F5 RID: 137717
		public const string ENDLESS_NO_SCORE_TEXT_ID = "MatchThree_NoRecord";

		// Token: 0x040219F6 RID: 137718
		public const string STAGE_GOAL_POINTS_TEXT_ID = "MatchThree_StageGoal_Points";

		// Token: 0x040219F7 RID: 137719
		public const string STAGE_GOAL_GEM_NUM_TEXT_ID = "MatchThree_StageGoal_GemNum";

		// Token: 0x040219F8 RID: 137720
		public const string STAGE_GOAL_ENDLESS_TEXT_ID = "MatchThree_StageGoal_Endless";

		// Token: 0x040219F9 RID: 137721
		public const string STAGE_GOAL_PIECE_HOURGLASS_TEXT_ID = "PieceName_2004";

		// Token: 0x040219FA RID: 137722
		public const string STAGE_GOAL_PIECE_BOTTLE_TEXT_ID = "PieceName_2003";

		// Token: 0x040219FB RID: 137723
		public const string DIFFICULTY_NORMAL_TEXT_ID = "Tetristext_06";

		// Token: 0x040219FC RID: 137724
		public const string DIFFICULTY_HARD_TEXT_ID = "Tetristext_07";

		// Token: 0x040219FD RID: 137725
		public const string LEVEL_DETAIL_TITLE_TEXT_ID = "MatchThree_LevelDetailTitle";

		// Token: 0x040219FE RID: 137726
		public const string HARD_LOCK_TIPS_TEXT_ID = "Tetristext_14";

		// Token: 0x040219FF RID: 137727
		public const string ENV_NO_EFFECT_TEXT_ID = "Weather_NoEffect";

		// Token: 0x04021A00 RID: 137728
		public const string ROLE_SELECT_CONFIRM_TEXT_ID = "RolePanel_Confirm";

		// Token: 0x04021A01 RID: 137729
		public const string ROLE_LOCK_BUTTON_TEXT_ID = "RolePanel_Locked";

		// Token: 0x04021A02 RID: 137730
		public const string ROLE_SKILL_ENERGY_TEXT_ID = "MatchThreeRoleRecharge";

		// Token: 0x04021A03 RID: 137731
		public const string ROLE_SPINE_IDLE_ANIM = "idle";

		// Token: 0x04021A04 RID: 137732
		public const string ROLE_SPINE_POSE_ANIM = "pose";

		// Token: 0x04021A05 RID: 137733
		public const string LEVEL_DETAIL_BG_NORMAL = "/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity37/Match3Game/T_LevelDetailBg1.T_LevelDetailBg1";

		// Token: 0x04021A06 RID: 137734
		public const string LEVEL_DETAIL_BG_ENDLESS = "/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity37/Match3Game/T_LevelDetailBg2.T_LevelDetailBg2";

		// Token: 0x04021A07 RID: 137735
		public const string LEVEL_DETAIL_INFO_TITLE_BG_NORMAL = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity37/Match3Game/LevelDetail/SP_InfoTitleBg1.SP_InfoTitleBg1";

		// Token: 0x04021A08 RID: 137736
		public const string LEVEL_DETAIL_INFO_TITLE_BG_ENDLESS = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity37/Match3Game/LevelDetail/SP_InfoTitleBg2.SP_InfoTitleBg2";

		// Token: 0x04021A09 RID: 137737
		public const string ROLE_SELECT_SWITCH_SEQUENCE = "Swtich";
	}
}
