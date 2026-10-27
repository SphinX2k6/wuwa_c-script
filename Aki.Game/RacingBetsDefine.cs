using System;
using System.Runtime.CompilerServices;

// Token: 0x020026E2 RID: 9954
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDefine
{
	// Token: 0x0400996A RID: 39274
	public const int RACING_BETS_MAP_POINT_COUNT = 24;

	// Token: 0x0400996B RID: 39275
	public const int RACING_BETS_DICE_ANIM_COUNT = 10;

	// Token: 0x0400996C RID: 39276
	public const float RACING_BETS_DANGO_BROADCAST_MOVE_SPEED = 0.2f;

	// Token: 0x0400996D RID: 39277
	public const int RACING_BETS_DANGO_BROADCAST_INTERVAL = 5000;

	// Token: 0x0400996E RID: 39278
	public const int RACING_BETS_DANGO_ORDER_INTERVAL = 1000;

	// Token: 0x0400996F RID: 39279
	public const float RACING_BETS_FREE_CAMERA_TO_DICE_CAMERA_TIME = 1f;

	// Token: 0x04009970 RID: 39280
	public const float RACING_BETS_DICE_CAMERA_TO_FREE_CAMERA_TIME = 1f;

	// Token: 0x04009971 RID: 39281
	public const int RACING_BETS_DANGO_RANK_ITEM_OFFSET_INTERVAL = 20;

	// Token: 0x04009972 RID: 39282
	public const int RACING_BETS_DANGO_RANK_ITEM_LERP_INTERVAL = 1000;

	// Token: 0x04009973 RID: 39283
	public const int RACING_BETS_BULLET_SCREEN_MIN_ALPHA = 10;

	// Token: 0x04009974 RID: 39284
	public const int RACING_BETS_BULLET_SCREEN_MAX_ALPHA = 100;

	// Token: 0x04009975 RID: 39285
	public const int RACING_BETS_FOUR_DANGO = 4;

	// Token: 0x04009976 RID: 39286
	public const int RACING_BETS_SIX_DANGO = 6;

	// Token: 0x04009977 RID: 39287
	public const string CAMERA_DANGO_PREVIEW_SIX_PLAYER = "Camera_DangoPreview_6Player";

	// Token: 0x04009978 RID: 39288
	public const string CAMERA_DANGO_PREVIEW_FOUR_PLAYER = "Camera_DangoPreview_4Player";

	// Token: 0x04009979 RID: 39289
	public const string CAMERA_DANGO_PREVIEW_ONE_PLAYER = "Camera_DangoFocus_RaceEnd";

	// Token: 0x0400997A RID: 39290
	public const string CAMERA_DANGO_PREVIEW_START = "Camera_DangoPreview_Start";

	// Token: 0x0400997B RID: 39291
	public const string DANGO_PREVIEW_POINT_CASE_ONE_PLAYER = "DangoChampionCase";

	// Token: 0x0400997C RID: 39292
	public const string DANGO_GLOBAL_CONFIG_PATH = "/Game/Aki/Character/NPC/Tuanzi/CommonConfig/DangoGlobalConfig.DangoGlobalConfig";

	// Token: 0x0400997D RID: 39293
	public const string MPC_DICE_DATE_PATH = "/Game/Aki/Render/Data/MPC_DiceDate.MPC_DiceDate";

	// Token: 0x0400997E RID: 39294
	public const string RACING_BETS_AUDIO_STATE_GROUP = "dungeon_2_3_race_music";

	// Token: 0x0400997F RID: 39295
	public const string AUDIO_EVENT_BLACK_HOLE_SINK = "play_ui_fx_spl_rsnt_blackhole_sink";

	// Token: 0x04009980 RID: 39296
	private const float RACING_BETS_OFFSET_ZERO = 108f;

	// Token: 0x04009981 RID: 39297
	private const float RACING_BETS_OFFSET_ONE = 111.5f;

	// Token: 0x04009982 RID: 39298
	private const float RACING_BETS_OFFSET_TWO = 113.8f;

	// Token: 0x04009983 RID: 39299
	private const float RACING_BETS_OFFSET_THREE = 119.8f;

	// Token: 0x04009984 RID: 39300
	private const float RACING_BETS_OFFSET_FOUR = 120.1f;

	// Token: 0x04009985 RID: 39301
	private const float RACING_BETS_OFFSET_FIVE = 117.9f;

	// Token: 0x04009986 RID: 39302
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

	// Token: 0x04009987 RID: 39303
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
