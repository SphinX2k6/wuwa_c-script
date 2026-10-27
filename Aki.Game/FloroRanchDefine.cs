using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B2D RID: 6957
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDefine : IStaticVariableResetter
{
	// Token: 0x0600CEA6 RID: 52902 RVA: 0x002F12E5 File Offset: 0x002EF4E5
	static FloroRanchDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchDefine.CreateStaticDefaultValue), new Action(FloroRanchDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600CEA7 RID: 52903 RVA: 0x002F1304 File Offset: 0x002EF504
	public static void CreateStaticDefaultValue()
	{
		FloroRanchDefine.FloroRanchPopupRewardOffset = Vector.Create(0.0, 0.0, 100.0);
		FloroRanchDefine.FloroRanchRewardPopUpSpeed = Vector.Create(100.0, 100.0, 0.0);
		FloroRanchDefine.FloroRanchRewardRightDirection = Vector.Create(0.0, 1.0, 0.0);
		FloroRanchDefine.FloroRanchRewardLeftDirection = Vector.Create(0.0, -1.0, 0.0);
		FloroRanchDefine.FloroRanchSpeedList = new List<int>
		{
			1,
			3,
			5
		};
		FloroRanchDefine.FloroRanchEndlessSpeedList = new List<int>
		{
			1,
			3,
			5,
			50
		};
		FloroRanchDefine.FloroRanchSpeedTimeMap = new Dictionary<int, ISpeedTime>
		{
			{
				1,
				new SpeedTime
				{
					PopupRewardStayTime = 500f,
					PopupRewardWaitTime = 200f,
					BezierCurveTime = 500f,
					WageSettleWaitTime = 2500f,
					ToyLevelUpPlayRate = 1f
				}
			},
			{
				3,
				new SpeedTime
				{
					PopupRewardStayTime = 1000f,
					PopupRewardWaitTime = 500f,
					BezierCurveTime = 800f,
					WageSettleWaitTime = 3500f,
					ToyLevelUpPlayRate = 1f
				}
			},
			{
				5,
				new SpeedTime
				{
					PopupRewardStayTime = 2000f,
					PopupRewardWaitTime = 1000f,
					BezierCurveTime = 1200f,
					WageSettleWaitTime = 5000f,
					ToyLevelUpPlayRate = 1f
				}
			},
			{
				50,
				new SpeedTime
				{
					PopupRewardStayTime = 2000f,
					PopupRewardWaitTime = 1000f,
					BezierCurveTime = 12000f,
					WageSettleWaitTime = 15000f,
					ToyLevelUpPlayRate = 1f
				}
			}
		};
		FloroRanchDefine.FloroRanchStageTransitionMap = new Dictionary<EFloroRanchStageStateType, List<EFloroRanchStageStateType>>
		{
			{
				EFloroRanchStageStateType.None,
				new List<EFloroRanchStageStateType>
				{
					EFloroRanchStageStateType.GameStart
				}
			},
			{
				EFloroRanchStageStateType.GameStart,
				new List<EFloroRanchStageStateType>
				{
					EFloroRanchStageStateType.DailyInStage,
					EFloroRanchStageStateType.StageSuccess,
					EFloroRanchStageStateType.GameExit
				}
			},
			{
				EFloroRanchStageStateType.DailyInStage,
				new List<EFloroRanchStageStateType>
				{
					EFloroRanchStageStateType.StageFail,
					EFloroRanchStageStateType.StageSuccess,
					EFloroRanchStageStateType.GameExit
				}
			},
			{
				EFloroRanchStageStateType.StageFail,
				new List<EFloroRanchStageStateType>
				{
					EFloroRanchStageStateType.GameExit
				}
			},
			{
				EFloroRanchStageStateType.StageSuccess,
				new List<EFloroRanchStageStateType>
				{
					EFloroRanchStageStateType.DailyInStage,
					EFloroRanchStageStateType.GameExit
				}
			},
			{
				EFloroRanchStageStateType.GameExit,
				new List<EFloroRanchStageStateType>()
			}
		};
		FloroRanchDefine.FloroRanchDifficultyTextId = new Dictionary<EFloroRanchDifficulty, string>
		{
			{
				EFloroRanchDifficulty.Easy,
				"Farm_Difficulty1"
			},
			{
				EFloroRanchDifficulty.Middle,
				"Farm_Difficulty2"
			},
			{
				EFloroRanchDifficulty.Difficult,
				"Farm_Difficulty3"
			}
		};
		FloroRanchDefine.EntityTypePriority = new Dictionary<int, int>
		{
			{
				1,
				1
			},
			{
				2,
				2
			},
			{
				0,
				3
			}
		};
	}

	// Token: 0x0600CEA8 RID: 52904 RVA: 0x002F15EA File Offset: 0x002EF7EA
	public static void ResetStaticDefaultValue()
	{
		FloroRanchDefine.FloroRanchPopupRewardOffset = null;
		FloroRanchDefine.FloroRanchRewardPopUpSpeed = null;
		FloroRanchDefine.FloroRanchRewardRightDirection = null;
		FloroRanchDefine.FloroRanchRewardLeftDirection = null;
		FloroRanchDefine.FloroRanchSpeedList = null;
		FloroRanchDefine.FloroRanchEndlessSpeedList = null;
		FloroRanchDefine.FloroRanchSpeedTimeMap = null;
		FloroRanchDefine.FloroRanchStageTransitionMap = null;
		FloroRanchDefine.FloroRanchDifficultyTextId = null;
		FloroRanchDefine.EntityTypePriority = null;
	}

	// Token: 0x04005E93 RID: 24211
	public const float FLORO_RANCH_REWARD_POPUP_TIME = 500f;

	// Token: 0x04005E94 RID: 24212
	public const float FLORO_RANCH_REWARD_POPUP_STAY_TIME = 500f;

	// Token: 0x04005E95 RID: 24213
	public const float FLORO_RANCH_REWARD_POPUP_STAY_TIME_2 = 1000f;

	// Token: 0x04005E96 RID: 24214
	public const float FLORO_RANCH_REWARD_POPUP_STAY_TIME_3 = 2000f;

	// Token: 0x04005E97 RID: 24215
	public const float FLORO_RANCH_REWARD_POPUP_STAY_TIME_4 = 2000f;

	// Token: 0x04005E98 RID: 24216
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_TIME = 500f;

	// Token: 0x04005E99 RID: 24217
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_TIME_2 = 800f;

	// Token: 0x04005E9A RID: 24218
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_TIME_3 = 1200f;

	// Token: 0x04005E9B RID: 24219
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_TIME_4 = 12000f;

	// Token: 0x04005E9C RID: 24220
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_WAIT_TIME = 20f;

	// Token: 0x04005E9D RID: 24221
	public const float FLORO_RANCH_CHAT_PANEL_HIDE_DELAY = 3000f;

	// Token: 0x04005E9E RID: 24222
	public const float FLORO_RANCH_GAME_PLAY_SPINE_SCALE = 0.53f;

	// Token: 0x04005E9F RID: 24223
	public const float FLORO_RANCH_OTHER_VIEW_SPINE_SCALE = 0.96f;

	// Token: 0x04005EA0 RID: 24224
	public const float FLORO_RANCH_WEEKLY_SPINE_SCALE_FACTOR = 0.255f;

	// Token: 0x04005EA1 RID: 24225
	public const float FLORO_RANCH_REWARD_POPUP_WAIT_TIME = 200f;

	// Token: 0x04005EA2 RID: 24226
	public const float FLORO_RANCH_REWARD_POPUP_WAIT_TIME_2 = 500f;

	// Token: 0x04005EA3 RID: 24227
	public const float FLORO_RANCH_REWARD_POPUP_WAIT_TIME_3 = 1000f;

	// Token: 0x04005EA4 RID: 24228
	public const float FLORO_RANCH_REWARD_POPUP_WAIT_TIME_4 = 1000f;

	// Token: 0x04005EA5 RID: 24229
	public static Vector FloroRanchPopupRewardOffset;

	// Token: 0x04005EA6 RID: 24230
	public static Vector FloroRanchRewardPopUpSpeed;

	// Token: 0x04005EA7 RID: 24231
	public const float FLORO_RANCH_BEZIER_FACTOR = 0.5f;

	// Token: 0x04005EA8 RID: 24232
	public const float FLORO_RANCH_BEZIER_CENTER_FACTOR = 0.5f;

	// Token: 0x04005EA9 RID: 24233
	public static Vector FloroRanchRewardRightDirection;

	// Token: 0x04005EAA RID: 24234
	public static Vector FloroRanchRewardLeftDirection;

	// Token: 0x04005EAB RID: 24235
	public const float FLORO_RANCH_CARD_SHOW_ANIM_WAIT_TIME = 200f;

	// Token: 0x04005EAC RID: 24236
	public const float FLORO_RANCH_CARD_HIDE_ANIM_WAIT_TIME = 200f;

	// Token: 0x04005EAD RID: 24237
	public const float FLORO_RANCH_CARD_NORAML_WAIT_ANIM_TIME = 200f;

	// Token: 0x04005EAE RID: 24238
	public const float FLORO_RANCH_CARD_MOVE_TIME = 500f;

	// Token: 0x04005EAF RID: 24239
	public const float FLORO_RANCH_CARD_EAT_TIME = 1000f;

	// Token: 0x04005EB0 RID: 24240
	public const float FLORO_RANCH_CARD_BE_EAT_TIME = 1000f;

	// Token: 0x04005EB1 RID: 24241
	public const float FLORO_RANCH_CARD_SACRIFICE_TIME = 1250f;

	// Token: 0x04005EB2 RID: 24242
	public const float FLORO_RANCH_CARD_FUSION_HIDE_TIME = 1000f;

	// Token: 0x04005EB3 RID: 24243
	public const float FLORO_RANCH_CARD_FUSION_SHOW_TIME = 1000f;

	// Token: 0x04005EB4 RID: 24244
	public const float FLORO_RANCH_CARD_EVOLVE_UP_TIME = 1000f;

	// Token: 0x04005EB5 RID: 24245
	public const int FLORO_RANCH_CARD_ITEM_MAX_HIERACHY = 99;

	// Token: 0x04005EB6 RID: 24246
	public const float FLORO_RANCH_DAY_START_TASK_WAIT_TIME = 1000f;

	// Token: 0x04005EB7 RID: 24247
	public const float FLORO_RANCH_DAY_ACTION_WAIT_TIME = 1000f;

	// Token: 0x04005EB8 RID: 24248
	public const float FLORO_RANCH_DAY_WAGE_TASK_WAIT_TIME = 2500f;

	// Token: 0x04005EB9 RID: 24249
	public const float FLORO_RANCH_DAY_WAGE_TASK_WAIT_TIME_2 = 3500f;

	// Token: 0x04005EBA RID: 24250
	public const float FLORO_RANCH_DAY_WAGE_TASK_WAIT_TIME_3 = 5000f;

	// Token: 0x04005EBB RID: 24251
	public const float FLORO_RANCH_DAY_WAGE_TASK_WAIT_TIME_4 = 15000f;

	// Token: 0x04005EBC RID: 24252
	public const int FLORO_RANCH_TERRAIN_ITEM_COUNT = 20;

	// Token: 0x04005EBD RID: 24253
	public const int FLORO_RANCH_TERRAIN_TIP_HEIGHT_HIGHER = 380;

	// Token: 0x04005EBE RID: 24254
	public const int FLORO_RANCH_TERRAIN_TIP_HEIGHT_SHORT = 240;

	// Token: 0x04005EBF RID: 24255
	public const float FLORO_RANCH_CARD_ITEM_ANIM_GAP_TIME = 50f;

	// Token: 0x04005EC0 RID: 24256
	public const float FLORO_RANCH_TOY_SKILL_ANIM_WAIT_TIME = 200f;

	// Token: 0x04005EC1 RID: 24257
	public const float FLORO_RANCH_TOY_LEVELUP_PLAY_RATE_DEFAULT = 1f;

	// Token: 0x04005EC2 RID: 24258
	public const float FLORO_RANCH_TOY_LEVELUP_PLAY_RATE_MID = 1f;

	// Token: 0x04005EC3 RID: 24259
	public const float FLORO_RANCH_TOY_LEVELUP_PLAY_RATE_HIGH = 1f;

	// Token: 0x04005EC4 RID: 24260
	public const float FLORO_RANCH_TOY_LEVELUP_PLAY_RATE_MAX = 1f;

	// Token: 0x04005EC5 RID: 24261
	public const int FLORO_RANCH_POPUP_REWARD_YELLOW_COIN_COUNT = 100;

	// Token: 0x04005EC6 RID: 24262
	public const int FLORO_RANCH_POPUP_REWARD_RED_COIN_COUNT = 1000;

	// Token: 0x04005EC7 RID: 24263
	public const int FLORO_RANCH_GAME_PLAY_HELP_ID = 354;

	// Token: 0x04005EC8 RID: 24264
	public const int FLORO_RANCH_WEEKLY_GAME_PLAY_HELP_ID = 629;

	// Token: 0x04005EC9 RID: 24265
	public const int FLORO_RANCH_HELP_ID = 347;

	// Token: 0x04005ECA RID: 24266
	public const float FLORO_RANCH_CARD_OFFSET_Z = 40f;

	// Token: 0x04005ECB RID: 24267
	public const int FLORO_RANCH_DEFAULT_SPEED = 1;

	// Token: 0x04005ECC RID: 24268
	public const int FLORO_RANCH_MID_SPEED = 3;

	// Token: 0x04005ECD RID: 24269
	public const int FLORO_RANCH_HIGH_SPEED = 5;

	// Token: 0x04005ECE RID: 24270
	public const int FLORO_RANCH_MAX_SPEED = 50;

	// Token: 0x04005ECF RID: 24271
	public const int FLORO_RANCH_SKIP_SPEED = 99;

	// Token: 0x04005ED0 RID: 24272
	public static List<int> FloroRanchSpeedList;

	// Token: 0x04005ED1 RID: 24273
	public static List<int> FloroRanchEndlessSpeedList;

	// Token: 0x04005ED2 RID: 24274
	public static Dictionary<int, ISpeedTime> FloroRanchSpeedTimeMap;

	// Token: 0x04005ED3 RID: 24275
	public const string FLORO_RANCH_DEBUG_INFO_ITEM_PATH = "/Game/Aki/UI/UIResources/UiActivity/Prefabs/Activity25/Pasture/UiItem_FloroRanchEntityInfo.UiItem_FloroRanchEntityInfo";

	// Token: 0x04005ED4 RID: 24276
	public static Dictionary<EFloroRanchStageStateType, List<EFloroRanchStageStateType>> FloroRanchStageTransitionMap;

	// Token: 0x04005ED5 RID: 24277
	public static Dictionary<EFloroRanchDifficulty, string> FloroRanchDifficultyTextId;

	// Token: 0x04005ED6 RID: 24278
	public static Dictionary<int, int> EntityTypePriority;
}
