using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F74 RID: 20340
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackDefine
	{
		// Token: 0x0401BAD9 RID: 113369
		public const string QUICK_HACK_SKILL_ENABLE_BG = "QuickHackSkillEnableBg";

		// Token: 0x0401BADA RID: 113370
		public const string QUICK_HACK_SKILL_ENABLE_HOLD_BG = "QuickHackSkillEnableHoldBg";

		// Token: 0x0401BADB RID: 113371
		public const string QUICK_HACK_SKILL_DISABLE_BG = "QuickHackSkillDisableBg";

		// Token: 0x0401BADC RID: 113372
		public const string QUICK_HACK_SKILL_DISABLE_HOLD_BG = "QuickHackSkillDisableHoldBg";

		// Token: 0x0401BADD RID: 113373
		public const string QUICK_HACK_SKILL_ENABLE_ICON_BG = "QuickHackSkillEnableIconBg";

		// Token: 0x0401BADE RID: 113374
		public const string QUICK_HACK_SKILL_DISABLE_ICON_BG = "QuickHackSkillDisableIconBg";

		// Token: 0x0401BADF RID: 113375
		public const string QUICK_HACK_SKILL_ENABLE_RAM_ICON = "QuickHackSkillEnableRamIcon";

		// Token: 0x0401BAE0 RID: 113376
		public const string QUICK_HACK_SKILL_DISABLE_RAM_ICON = "QuickHackSkillDisableRamIcon";

		// Token: 0x0401BAE1 RID: 113377
		public const string QUICK_HACK_SKILL_ENABLE_TAG_BG = "QuickHackSkillEnableTagBg";

		// Token: 0x0401BAE2 RID: 113378
		public const string QUICK_HACK_SKILL_DISABLE_TAG_BG = "QuickHackSkillDisableTagBg";

		// Token: 0x0401BAE3 RID: 113379
		public const string QUICK_HACK_MARKS_ITEM = "QuickHackMarksItem";

		// Token: 0x0401BAE4 RID: 113380
		public const string QUICK_HACK_RAM_TITLE_TEXT = "QuickHack_Desc_1";

		// Token: 0x0401BAE5 RID: 113381
		public const string QUICK_HACK_DURATION_LIMIT_TEXT = "QuickHack_Desc_2";

		// Token: 0x0401BAE6 RID: 113382
		public const string QUICK_HACK_CONDITION_FAIL_TEXT = "QuickHack_Prohibit_1";

		// Token: 0x0401BAE7 RID: 113383
		public const string QUICK_HACK_TARGET_NOT_MATCH_TEXT = "QuickHack_Prohibit_2";

		// Token: 0x0401BAE8 RID: 113384
		public const string QUICK_HACK_RAM_NOT_ENOUGH_TEXT = "QuickHack_Prohibit_3";

		// Token: 0x0401BAE9 RID: 113385
		public const string QUICK_HACK_USAGE_COUNT_NOT_ENOUGH_TEXT = "QuickHack_Prohibit_4";

		// Token: 0x0401BAEA RID: 113386
		public const string QUICK_HACK_MONSTER_NOT_MATCH_TEXT = "QuickHack_Prohibit_5";

		// Token: 0x0401BAEB RID: 113387
		public const string QUICK_HACK_TARGET_HAS_BEEN_HACK_TEXT = "QuickHack_Prohibit_6";

		// Token: 0x0401BAEC RID: 113388
		public const string QUICK_HACK_SKILL_ENABLE_STATE_TEXT = "Skill_10001511_HackSkill101";

		// Token: 0x0401BAED RID: 113389
		public const string QUICK_HACK_SKILL_DISABLE_STATE_TEXT = "Skill_10001511_HackSkill102";

		// Token: 0x0401BAEE RID: 113390
		public const string QUICK_HACK_SKILL_DURATION_TEXT = "QuickHack_SkillMessage_1";

		// Token: 0x0401BAEF RID: 113391
		public const string QUICK_HACK_SKILL_UPLOAD_TEXT = "QuickHack_SkillMessage_2";

		// Token: 0x0401BAF0 RID: 113392
		public const string QUICK_HACK_NO_TARGET_TEXT = "QuickHack_Desc_12";

		// Token: 0x0401BAF1 RID: 113393
		[StaticVariableRuleIgnore]
		public static readonly List<int> quickHackSkillItemOffsets = new List<int>
		{
			0,
			-10,
			-30,
			-40,
			-20,
			20,
			50
		};

		// Token: 0x0401BAF2 RID: 113394
		public const string QUICK_HACK_AUTO_USE_SKILL_LONG_PRESS = "QuickHackAutoUseSkillLongPressTime";

		// Token: 0x0401BAF3 RID: 113395
		public const string QUICK_HACK_TRY_EXIT_LONG_PRESS = "QuickHackTryExitLongPressTime";

		// Token: 0x0401BAF4 RID: 113396
		public const string QUICK_HACK_FORCE_EXIT_LONG_PRESS = "QuickHackForceExitLongPressTime";

		// Token: 0x0401BAF5 RID: 113397
		public const int QUICK_HACK_PER_RAM_WIDTH = 28;

		// Token: 0x0401BAF6 RID: 113398
		public const string QUICK_HACK_RAM_SELECTED_CURVE = "/Game/Aki/UI/UIResources/UiLevel/Curve/CyberSynergy/Curve_BarPawY.Curve_BarPawY";

		// Token: 0x0401BAF7 RID: 113399
		public const int QUICK_HACK_RAM_SELECTED_MAX_FRAME = 34;

		// Token: 0x0401BAF8 RID: 113400
		public const int QUICK_HACK_RAM_SELECTED_FRAME_PER_SECOND = 60;

		// Token: 0x0401BAF9 RID: 113401
		public const int QUICK_HACK_RAM_SELECTED_Y_MIN = 0;

		// Token: 0x0401BAFA RID: 113402
		public const int QUICK_HACK_RAM_SELECTED_Y_MAX = 6;

		// Token: 0x0401BAFB RID: 113403
		[StaticVariableRuleIgnore]
		public static readonly List<EBattleUiChild> battleViewExcludeChildren = new List<EBattleUiChild>
		{
			EBattleUiChild.HeadState,
			EBattleUiChild.BossState,
			EBattleUiChild.DamageView
		};

		// Token: 0x0401BAFC RID: 113404
		[StaticVariableRuleIgnore]
		public static readonly List<EBattleUiChild> commonBattleViewExcludeChildren = new List<EBattleUiChild>
		{
			EBattleUiChild.HeadState,
			EBattleUiChild.BossState,
			EBattleUiChild.DamageView
		};

		// Token: 0x0401BAFD RID: 113405
		public const string QUICK_HACK_SKILL_ENABLE_CLICK_COLOR = "#55DAFFFF";

		// Token: 0x0401BAFE RID: 113406
		public const string QUICK_HACK_SKILL_DISABLE_CLICK_COLOR = "#FF5753FF";

		// Token: 0x0401BAFF RID: 113407
		public const string QUICK_HACK_POST_PROCESS_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/FilterDA/DA_PostProcess_Filter_Green.DA_PostProcess_Filter_Green";

		// Token: 0x0401BB00 RID: 113408
		public const float QUICK_HACK_SCREEN_TARGET_EXTEND = 0.1f;

		// Token: 0x0401BB01 RID: 113409
		public const string QUICK_HACK_AUDIO_COMMON_MARKS_LOOP = "play_ui_focus_mode_scanning_loop";

		// Token: 0x0401BB02 RID: 113410
		public const string QUICK_HACK_AUDIO_COMMON_MARKS_FINISH = "play_ui_focus_mode_scanning_qh_done";

		// Token: 0x0401BB03 RID: 113411
		public const string QUICK_HACK_AUDIO_COMMON_SELECT_SKILL = "play_ui_focus_mode_scanning_choice";

		// Token: 0x0401BB04 RID: 113412
		public const string QUICK_HACK_AUDIO_BATTLE_MARKS_LOOP = "play_role_lucy_bat_burst01_qh_loop";

		// Token: 0x0401BB05 RID: 113413
		public const string QUICK_HACK_AUDIO_BATTLE_MARKS_FINISH = "play_role_lucy_bat_burst01_qh_done";

		// Token: 0x0401BB06 RID: 113414
		public const string QUICK_HACK_AUDIO_BATTLE_SELECT_SKILL = "play_role_lucy_bat_burst01_qh_select";

		// Token: 0x0401BB07 RID: 113415
		public const string QUICK_HACK_AUDIO_BATTLE_USE_SKILL = "play_role_lucy_bat_burst01_qh_scanning";

		// Token: 0x0401BB08 RID: 113416
		public const string QUICK_HACK_MARK_RED_COLOR = "#FF4F4BFF";

		// Token: 0x0401BB09 RID: 113417
		public const string QUICK_HACK_MARK_BLUE_COLOR = "#6CF4F8FF";

		// Token: 0x0401BB0A RID: 113418
		public const int QUICK_HACK_MONSTER_MARK_UPLOAD_TIME = 200;

		// Token: 0x0401BB0B RID: 113419
		public const string QUICK_HACK_MARK_BACKGROUND_BLUE = "QuickHackMarkBackgroundBlue";

		// Token: 0x0401BB0C RID: 113420
		public const string QUICK_HACK_MARK_PROGRESS_BLUE = "QuickHackMarkProgressBlue";

		// Token: 0x0401BB0D RID: 113421
		public const string QUICK_HACK_MARK_BACKGROUND_RED = "QuickHackMarkBackgroundRed";

		// Token: 0x0401BB0E RID: 113422
		public const string QUICK_HACK_MARK_PROGRESS_RED = "QuickHackMarkProgressRed";
	}
}
