using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BCD RID: 7117
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDefine
{
	// Token: 0x04009AC2 RID: 39618
	public const int RACING_BETS_MAP_POINT_COUNT = 24;

	// Token: 0x04009AC3 RID: 39619
	public const int RACING_BETS_DICE_ANIM_COUNT = 10;

	// Token: 0x04009AC4 RID: 39620
	public const float RACING_BETS_DANGO_BROADCAST_MOVE_SPEED = 0.2f;

	// Token: 0x04009AC5 RID: 39621
	public const int RACING_BETS_DANGO_BROADCAST_INTERVAL = 5000;

	// Token: 0x04009AC6 RID: 39622
	public const int RACING_BETS_DANGO_ORDER_INTERVAL = 1000;

	// Token: 0x04009AC7 RID: 39623
	public const float RACING_BETS_FREE_CAMERA_TO_DICE_CAMERA_TIME = 1f;

	// Token: 0x04009AC8 RID: 39624
	public const float RACING_BETS_DICE_CAMERA_TO_FREE_CAMERA_TIME = 1f;

	// Token: 0x04009AC9 RID: 39625
	public const int RACING_BETS_DANGO_RANK_ITEM_OFFSET_INTERVAL = 20;

	// Token: 0x04009ACA RID: 39626
	public const int RACING_BETS_DANGO_RANK_ITEM_LERP_INTERVAL = 1000;

	// Token: 0x04009ACB RID: 39627
	public const int RACING_BETS_BULLET_SCREEN_MIN_ALPHA = 10;

	// Token: 0x04009ACC RID: 39628
	public const int RACING_BETS_BULLET_SCREEN_MAX_ALPHA = 100;

	// Token: 0x04009ACD RID: 39629
	public const int RACING_BETS_FOUR_DANGO = 4;

	// Token: 0x04009ACE RID: 39630
	public const int RACING_BETS_SIX_DANGO = 6;

	// Token: 0x04009ACF RID: 39631
	public const string CAMERA_DANGO_PREVIEW_SIX_PLAYER = "Camera_DangoPreview_6Player";

	// Token: 0x04009AD0 RID: 39632
	public const string CAMERA_DANGO_PREVIEW_FOUR_PLAYER = "Camera_DangoPreview_4Player";

	// Token: 0x04009AD1 RID: 39633
	public const string CAMERA_DANGO_PREVIEW_ONE_PLAYER = "Camera_DangoFocus_RaceEnd";

	// Token: 0x04009AD2 RID: 39634
	public const string CAMERA_DANGO_PREVIEW_START = "Camera_DangoPreview_Start";

	// Token: 0x04009AD3 RID: 39635
	public const string DANGO_PREVIEW_POINT_CASE_ONE_PLAYER = "DangoChampionCase";

	// Token: 0x04009AD4 RID: 39636
	public const string DANGO_GLOBAL_CONFIG_PATH = "/Game/Aki/Character/NPC/Tuanzi/CommonConfig/DangoGlobalConfig.DangoGlobalConfig";

	// Token: 0x04009AD5 RID: 39637
	public const string MPC_DICE_DATE_PATH = "/Game/Aki/Render/Data/MPC_DiceDate.MPC_DiceDate";

	// Token: 0x04009AD6 RID: 39638
	public const string RACING_BETS_AUDIO_STATE_GROUP = "dungeon_2_3_race_music";

	// Token: 0x04009AD7 RID: 39639
	public const string AUDIO_EVENT_BLACK_HOLE_SINK = "play_ui_fx_spl_rsnt_blackhole_sink";

	// Token: 0x04009AD8 RID: 39640
	private const float RACING_BETS_OFFSET_ZERO = 108f;

	// Token: 0x04009AD9 RID: 39641
	private const float RACING_BETS_OFFSET_ONE = 111.5f;

	// Token: 0x04009ADA RID: 39642
	private const float RACING_BETS_OFFSET_TWO = 113.8f;

	// Token: 0x04009ADB RID: 39643
	private const float RACING_BETS_OFFSET_THREE = 119.8f;

	// Token: 0x04009ADC RID: 39644
	private const float RACING_BETS_OFFSET_FOUR = 120.1f;

	// Token: 0x04009ADD RID: 39645
	private const float RACING_BETS_OFFSET_FIVE = 117.9f;

	// Token: 0x04009ADE RID: 39646
	[StaticVariableRuleIgnore]
	public static readonly float[] RacingBetsDangoOddsOffsetList = new float[]
	{
		108f,
		111.5f,
		113.8f,
		119.8f,
		120.1f,
		117.9f
	};

	// Token: 0x04009ADF RID: 39647
	[StaticVariableRuleIgnore]
	public static readonly int[] RacingBetsDiceIndexList = new int[]
	{
		1,
		2,
		4,
		5,
		6,
		7
	};
}
