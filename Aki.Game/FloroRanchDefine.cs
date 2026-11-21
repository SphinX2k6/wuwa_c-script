using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000FEC RID: 4076
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDefine : IStaticVariableResetter
{
	// Token: 0x0600A2B7 RID: 41655 RVA: 0x002FC3C5 File Offset: 0x002FA5C5
	static FloroRanchDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchDefine.CreateStaticDefaultValue), new Action(FloroRanchDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600A2B8 RID: 41656 RVA: 0x002FC3E4 File Offset: 0x002FA5E4
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

	// Token: 0x0600A2B9 RID: 41657 RVA: 0x002FC6CA File Offset: 0x002FA8CA
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

	// Token: 0x04005F62 RID: 24418
	public const float FLORO_RANCH_REWARD_POPUP_TIME = 500f;

	// Token: 0x04005F63 RID: 24419
	public const float FLORO_RANCH_REWARD_POPUP_STAY_TIME = 500f;

	// Token: 0x04005F64 RID: 24420
	public const float FLORO_RANCH_REWARD_POPUP_STAY_TIME_2 = 1000f;

	// Token: 0x04005F65 RID: 24421
	public const float FLORO_RANCH_REWARD_POPUP_STAY_TIME_3 = 2000f;

	// Token: 0x04005F66 RID: 24422
	public const float FLORO_RANCH_REWARD_POPUP_STAY_TIME_4 = 2000f;

	// Token: 0x04005F67 RID: 24423
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_TIME = 500f;

	// Token: 0x04005F68 RID: 24424
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_TIME_2 = 800f;

	// Token: 0x04005F69 RID: 24425
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_TIME_3 = 1200f;

	// Token: 0x04005F6A RID: 24426
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_TIME_4 = 12000f;

	// Token: 0x04005F6B RID: 24427
	public const float FLORO_RANCH_REWARD_COIN_BEZIER_WAIT_TIME = 20f;

	// Token: 0x04005F6C RID: 24428
	public const float FLORO_RANCH_CHAT_PANEL_HIDE_DELAY = 3000f;

	// Token: 0x04005F6D RID: 24429
	public const float FLORO_RANCH_GAME_PLAY_SPINE_SCALE = 0.53f;

	// Token: 0x04005F6E RID: 24430
	public const float FLORO_RANCH_OTHER_VIEW_SPINE_SCALE = 0.96f;

	// Token: 0x04005F6F RID: 24431
	public const float FLORO_RANCH_WEEKLY_SPINE_SCALE_FACTOR = 0.255f;

	// Token: 0x04005F70 RID: 24432
	public const float FLORO_RANCH_REWARD_POPUP_WAIT_TIME = 200f;

	// Token: 0x04005F71 RID: 24433
	public const float FLORO_RANCH_REWARD_POPUP_WAIT_TIME_2 = 500f;

	// Token: 0x04005F72 RID: 24434
	public const float FLORO_RANCH_REWARD_POPUP_WAIT_TIME_3 = 1000f;

	// Token: 0x04005F73 RID: 24435
	public const float FLORO_RANCH_REWARD_POPUP_WAIT_TIME_4 = 1000f;

	// Token: 0x04005F74 RID: 24436
	public static Vector FloroRanchPopupRewardOffset;

	// Token: 0x04005F75 RID: 24437
	public static Vector FloroRanchRewardPopUpSpeed;

	// Token: 0x04005F76 RID: 24438
	public const float FLORO_RANCH_BEZIER_FACTOR = 0.5f;

	// Token: 0x04005F77 RID: 24439
	public const float FLORO_RANCH_BEZIER_CENTER_FACTOR = 0.5f;

	// Token: 0x04005F78 RID: 24440
	public static Vector FloroRanchRewardRightDirection;

	// Token: 0x04005F79 RID: 24441
	public static Vector FloroRanchRewardLeftDirection;

	// Token: 0x04005F7A RID: 24442
	public const float FLORO_RANCH_CARD_SHOW_ANIM_WAIT_TIME = 200f;

	// Token: 0x04005F7B RID: 24443
	public const float FLORO_RANCH_CARD_HIDE_ANIM_WAIT_TIME = 200f;

	// Token: 0x04005F7C RID: 24444
	public const float FLORO_RANCH_CARD_NORAML_WAIT_ANIM_TIME = 200f;

	// Token: 0x04005F7D RID: 24445
	public const float FLORO_RANCH_CARD_MOVE_TIME = 500f;

	// Token: 0x04005F7E RID: 24446
	public const float FLORO_RANCH_CARD_EAT_TIME = 1000f;

	// Token: 0x04005F7F RID: 24447
	public const float FLORO_RANCH_CARD_BE_EAT_TIME = 1000f;

	// Token: 0x04005F80 RID: 24448
	public const float FLORO_RANCH_CARD_SACRIFICE_TIME = 1250f;

	// Token: 0x04005F81 RID: 24449
	public const float FLORO_RANCH_CARD_FUSION_HIDE_TIME = 1000f;

	// Token: 0x04005F82 RID: 24450
	public const float FLORO_RANCH_CARD_FUSION_SHOW_TIME = 1000f;

	// Token: 0x04005F83 RID: 24451
	public const float FLORO_RANCH_CARD_EVOLVE_UP_TIME = 1000f;

	// Token: 0x04005F84 RID: 24452
	public const int FLORO_RANCH_CARD_ITEM_MAX_HIERACHY = 99;

	// Token: 0x04005F85 RID: 24453
	public const float FLORO_RANCH_DAY_START_TASK_WAIT_TIME = 1000f;

	// Token: 0x04005F86 RID: 24454
	public const float FLORO_RANCH_DAY_ACTION_WAIT_TIME = 1000f;

	// Token: 0x04005F87 RID: 24455
	public const float FLORO_RANCH_DAY_WAGE_TASK_WAIT_TIME = 2500f;

	// Token: 0x04005F88 RID: 24456
	public const float FLORO_RANCH_DAY_WAGE_TASK_WAIT_TIME_2 = 3500f;

	// Token: 0x04005F89 RID: 24457
	public const float FLORO_RANCH_DAY_WAGE_TASK_WAIT_TIME_3 = 5000f;

	// Token: 0x04005F8A RID: 24458
	public const float FLORO_RANCH_DAY_WAGE_TASK_WAIT_TIME_4 = 15000f;

	// Token: 0x04005F8B RID: 24459
	public const int FLORO_RANCH_TERRAIN_ITEM_COUNT = 20;

	// Token: 0x04005F8C RID: 24460
	public const int FLORO_RANCH_TERRAIN_TIP_HEIGHT_HIGHER = 380;

	// Token: 0x04005F8D RID: 24461
	public const int FLORO_RANCH_TERRAIN_TIP_HEIGHT_SHORT = 240;

	// Token: 0x04005F8E RID: 24462
	public const float FLORO_RANCH_CARD_ITEM_ANIM_GAP_TIME = 50f;

	// Token: 0x04005F8F RID: 24463
	public const float FLORO_RANCH_TOY_SKILL_ANIM_WAIT_TIME = 200f;

	// Token: 0x04005F90 RID: 24464
	public const float FLORO_RANCH_TOY_LEVELUP_PLAY_RATE_DEFAULT = 1f;

	// Token: 0x04005F91 RID: 24465
	public const float FLORO_RANCH_TOY_LEVELUP_PLAY_RATE_MID = 1f;

	// Token: 0x04005F92 RID: 24466
	public const float FLORO_RANCH_TOY_LEVELUP_PLAY_RATE_HIGH = 1f;

	// Token: 0x04005F93 RID: 24467
	public const float FLORO_RANCH_TOY_LEVELUP_PLAY_RATE_MAX = 1f;

	// Token: 0x04005F94 RID: 24468
	public const int FLORO_RANCH_POPUP_REWARD_YELLOW_COIN_COUNT = 100;

	// Token: 0x04005F95 RID: 24469
	public const int FLORO_RANCH_POPUP_REWARD_RED_COIN_COUNT = 1000;

	// Token: 0x04005F96 RID: 24470
	public const int FLORO_RANCH_GAME_PLAY_HELP_ID = 354;

	// Token: 0x04005F97 RID: 24471
	public const int FLORO_RANCH_WEEKLY_GAME_PLAY_HELP_ID = 629;

	// Token: 0x04005F98 RID: 24472
	public const int FLORO_RANCH_HELP_ID = 347;

	// Token: 0x04005F99 RID: 24473
	public const float FLORO_RANCH_CARD_OFFSET_Z = 40f;

	// Token: 0x04005F9A RID: 24474
	public const int FLORO_RANCH_DEFAULT_SPEED = 1;

	// Token: 0x04005F9B RID: 24475
	public const int FLORO_RANCH_MID_SPEED = 3;

	// Token: 0x04005F9C RID: 24476
	public const int FLORO_RANCH_HIGH_SPEED = 5;

	// Token: 0x04005F9D RID: 24477
	public const int FLORO_RANCH_MAX_SPEED = 50;

	// Token: 0x04005F9E RID: 24478
	public const int FLORO_RANCH_SKIP_SPEED = 99;

	// Token: 0x04005F9F RID: 24479
	public static List<int> FloroRanchSpeedList;

	// Token: 0x04005FA0 RID: 24480
	public static List<int> FloroRanchEndlessSpeedList;

	// Token: 0x04005FA1 RID: 24481
	public static Dictionary<int, ISpeedTime> FloroRanchSpeedTimeMap;

	// Token: 0x04005FA2 RID: 24482
	public const string FLORO_RANCH_DEBUG_INFO_ITEM_PATH = "/Game/Aki/UI/UIResources/UiActivity/Prefabs/Activity25/Pasture/UiItem_FloroRanchEntityInfo.UiItem_FloroRanchEntityInfo";

	// Token: 0x04005FA3 RID: 24483
	public static Dictionary<EFloroRanchStageStateType, List<EFloroRanchStageStateType>> FloroRanchStageTransitionMap;

	// Token: 0x04005FA4 RID: 24484
	public static Dictionary<EFloroRanchDifficulty, string> FloroRanchDifficultyTextId;

	// Token: 0x04005FA5 RID: 24485
	public static Dictionary<int, int> EntityTypePriority;
}
