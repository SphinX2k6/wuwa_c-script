using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F3D RID: 16189
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackDefine
	{
		// Token: 0x040164AE RID: 91310
		public const string QUICK_HACK_SKILL_ENABLE_BG = "QuickHackSkillEnableBg";

		// Token: 0x040164AF RID: 91311
		public const string QUICK_HACK_SKILL_ENABLE_HOLD_BG = "QuickHackSkillEnableHoldBg";

		// Token: 0x040164B0 RID: 91312
		public const string QUICK_HACK_SKILL_DISABLE_BG = "QuickHackSkillDisableBg";

		// Token: 0x040164B1 RID: 91313
		public const string QUICK_HACK_SKILL_DISABLE_HOLD_BG = "QuickHackSkillDisableHoldBg";

		// Token: 0x040164B2 RID: 91314
		public const string QUICK_HACK_SKILL_ENABLE_ICON_BG = "QuickHackSkillEnableIconBg";

		// Token: 0x040164B3 RID: 91315
		public const string QUICK_HACK_SKILL_DISABLE_ICON_BG = "QuickHackSkillDisableIconBg";

		// Token: 0x040164B4 RID: 91316
		public const string QUICK_HACK_SKILL_ENABLE_RAM_ICON = "QuickHackSkillEnableRamIcon";

		// Token: 0x040164B5 RID: 91317
		public const string QUICK_HACK_SKILL_DISABLE_RAM_ICON = "QuickHackSkillDisableRamIcon";

		// Token: 0x040164B6 RID: 91318
		public const string QUICK_HACK_SKILL_ENABLE_TAG_BG = "QuickHackSkillEnableTagBg";

		// Token: 0x040164B7 RID: 91319
		public const string QUICK_HACK_SKILL_DISABLE_TAG_BG = "QuickHackSkillDisableTagBg";

		// Token: 0x040164B8 RID: 91320
		public const string QUICK_HACK_MARKS_ITEM = "QuickHackMarksItem";

		// Token: 0x040164B9 RID: 91321
		public const string QUICK_HACK_RAM_TITLE_TEXT = "QuickHack_Desc_1";

		// Token: 0x040164BA RID: 91322
		public const string QUICK_HACK_DURATION_LIMIT_TEXT = "QuickHack_Desc_2";

		// Token: 0x040164BB RID: 91323
		public const string QUICK_HACK_CONDITION_FAIL_TEXT = "QuickHack_Prohibit_1";

		// Token: 0x040164BC RID: 91324
		public const string QUICK_HACK_TARGET_NOT_MATCH_TEXT = "QuickHack_Prohibit_2";

		// Token: 0x040164BD RID: 91325
		public const string QUICK_HACK_RAM_NOT_ENOUGH_TEXT = "QuickHack_Prohibit_3";

		// Token: 0x040164BE RID: 91326
		public const string QUICK_HACK_USAGE_COUNT_NOT_ENOUGH_TEXT = "QuickHack_Prohibit_4";

		// Token: 0x040164BF RID: 91327
		public const string QUICK_HACK_MONSTER_NOT_MATCH_TEXT = "QuickHack_Prohibit_5";

		// Token: 0x040164C0 RID: 91328
		public const string QUICK_HACK_TARGET_HAS_BEEN_HACK_TEXT = "QuickHack_Prohibit_6";

		// Token: 0x040164C1 RID: 91329
		public const string QUICK_HACK_SKILL_ENABLE_STATE_TEXT = "Skill_10001511_HackSkill101";

		// Token: 0x040164C2 RID: 91330
		public const string QUICK_HACK_SKILL_DISABLE_STATE_TEXT = "Skill_10001511_HackSkill102";

		// Token: 0x040164C3 RID: 91331
		public const string QUICK_HACK_SKILL_DURATION_TEXT = "QuickHack_SkillMessage_1";

		// Token: 0x040164C4 RID: 91332
		public const string QUICK_HACK_SKILL_UPLOAD_TEXT = "QuickHack_SkillMessage_2";

		// Token: 0x040164C5 RID: 91333
		public const string QUICK_HACK_NO_TARGET_TEXT = "QuickHack_Desc_12";

		// Token: 0x040164C6 RID: 91334
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

		// Token: 0x040164C7 RID: 91335
		public const string QUICK_HACK_AUTO_USE_SKILL_LONG_PRESS = "QuickHackAutoUseSkillLongPressTime";

		// Token: 0x040164C8 RID: 91336
		public const string QUICK_HACK_TRY_EXIT_LONG_PRESS = "QuickHackTryExitLongPressTime";

		// Token: 0x040164C9 RID: 91337
		public const string QUICK_HACK_FORCE_EXIT_LONG_PRESS = "QuickHackForceExitLongPressTime";

		// Token: 0x040164CA RID: 91338
		public const int QUICK_HACK_PER_RAM_WIDTH = 28;

		// Token: 0x040164CB RID: 91339
		public const string QUICK_HACK_RAM_SELECTED_CURVE = "/Game/Aki/UI/UIResources/UiLevel/Curve/CyberSynergy/Curve_BarPawY.Curve_BarPawY";

		// Token: 0x040164CC RID: 91340
		public const int QUICK_HACK_RAM_SELECTED_MAX_FRAME = 34;

		// Token: 0x040164CD RID: 91341
		public const int QUICK_HACK_RAM_SELECTED_FRAME_PER_SECOND = 60;

		// Token: 0x040164CE RID: 91342
		public const int QUICK_HACK_RAM_SELECTED_Y_MIN = 0;

		// Token: 0x040164CF RID: 91343
		public const int QUICK_HACK_RAM_SELECTED_Y_MAX = 6;

		// Token: 0x040164D0 RID: 91344
		[StaticVariableRuleIgnore]
		public static readonly List<EBattleUiChild> battleViewExcludeChildren = new List<EBattleUiChild>
		{
			EBattleUiChild.HeadState,
			EBattleUiChild.BossState,
			EBattleUiChild.DamageView
		};

		// Token: 0x040164D1 RID: 91345
		[StaticVariableRuleIgnore]
		public static readonly List<EBattleUiChild> commonBattleViewExcludeChildren = new List<EBattleUiChild>
		{
			EBattleUiChild.HeadState,
			EBattleUiChild.BossState,
			EBattleUiChild.DamageView
		};

		// Token: 0x040164D2 RID: 91346
		public const string QUICK_HACK_SKILL_ENABLE_CLICK_COLOR = "#55DAFFFF";

		// Token: 0x040164D3 RID: 91347
		public const string QUICK_HACK_SKILL_DISABLE_CLICK_COLOR = "#FF5753FF";

		// Token: 0x040164D4 RID: 91348
		public const string QUICK_HACK_POST_PROCESS_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/FilterDA/DA_PostProcess_Filter_Green.DA_PostProcess_Filter_Green";

		// Token: 0x040164D5 RID: 91349
		public const float QUICK_HACK_SCREEN_TARGET_EXTEND = 0.1f;

		// Token: 0x040164D6 RID: 91350
		public const string QUICK_HACK_AUDIO_COMMON_MARKS_LOOP = "play_ui_focus_mode_scanning_loop";

		// Token: 0x040164D7 RID: 91351
		public const string QUICK_HACK_AUDIO_COMMON_MARKS_FINISH = "play_ui_focus_mode_scanning_qh_done";

		// Token: 0x040164D8 RID: 91352
		public const string QUICK_HACK_AUDIO_COMMON_SELECT_SKILL = "play_ui_focus_mode_scanning_choice";

		// Token: 0x040164D9 RID: 91353
		public const string QUICK_HACK_AUDIO_BATTLE_MARKS_LOOP = "play_role_lucy_bat_burst01_qh_loop";

		// Token: 0x040164DA RID: 91354
		public const string QUICK_HACK_AUDIO_BATTLE_MARKS_FINISH = "play_role_lucy_bat_burst01_qh_done";

		// Token: 0x040164DB RID: 91355
		public const string QUICK_HACK_AUDIO_BATTLE_SELECT_SKILL = "play_role_lucy_bat_burst01_qh_select";

		// Token: 0x040164DC RID: 91356
		public const string QUICK_HACK_AUDIO_BATTLE_USE_SKILL = "play_role_lucy_bat_burst01_qh_scanning";

		// Token: 0x040164DD RID: 91357
		public const string QUICK_HACK_MARK_RED_COLOR = "#FF4F4BFF";

		// Token: 0x040164DE RID: 91358
		public const string QUICK_HACK_MARK_BLUE_COLOR = "#6CF4F8FF";

		// Token: 0x040164DF RID: 91359
		public const int QUICK_HACK_MONSTER_MARK_UPLOAD_TIME = 200;

		// Token: 0x040164E0 RID: 91360
		public const string QUICK_HACK_MARK_BACKGROUND_BLUE = "QuickHackMarkBackgroundBlue";

		// Token: 0x040164E1 RID: 91361
		public const string QUICK_HACK_MARK_PROGRESS_BLUE = "QuickHackMarkProgressBlue";

		// Token: 0x040164E2 RID: 91362
		public const string QUICK_HACK_MARK_BACKGROUND_RED = "QuickHackMarkBackgroundRed";

		// Token: 0x040164E3 RID: 91363
		public const string QUICK_HACK_MARK_PROGRESS_RED = "QuickHackMarkProgressRed";
	}
}
