using System;
using System.Runtime.CompilerServices;

// Token: 0x020030F9 RID: 12537
[NullableContext(1)]
[Nullable(0)]
public static class KeepFollowingMoveLogicDefine
{
	// Token: 0x0400D042 RID: 53314
	public const int DEBUG_RADIUS = 20;

	// Token: 0x0400D043 RID: 53315
	public const int DEBUG_SEGMENTS = 10;

	// Token: 0x0400D044 RID: 53316
	public const int DETECT_HEIGHT = 2;

	// Token: 0x0400D045 RID: 53317
	public const string PROFILE_KEY = "KeepFollowing";

	// Token: 0x0400D046 RID: 53318
	public const int CHECK_DIRECTION_ANGLE = 40;

	// Token: 0x0400D047 RID: 53319
	[StaticVariableRuleIgnore]
	public static readonly int[] checkDirectionList = new int[]
	{
		0,
		1,
		2,
		3,
		4,
		-1
	};

	// Token: 0x0400D048 RID: 53320
	[StaticVariableRuleIgnore]
	public static readonly int[] checkDistanceList = new int[]
	{
		0,
		100,
		200,
		300,
		400
	};

	// Token: 0x0400D049 RID: 53321
	public const float FALLBACK_TELEPORT_RADIUS_MARGIN = 200f;

	// Token: 0x0400D04A RID: 53322
	public const int MIN_ANGLE = 5;

	// Token: 0x0400D04B RID: 53323
	public const float STAND_TOLERANCE_RATE = 0.4f;

	// Token: 0x0400D04C RID: 53324
	public const int COMPENSATE_TOLERANCE_DISTANCE = 5;

	// Token: 0x0400D04D RID: 53325
	public const int ANGLE_DIRECTION_TOLERANCE = 45;

	// Token: 0x0400D04E RID: 53326
	public const float DECELERATION_SPEED_RATE = -5f;

	// Token: 0x0400D04F RID: 53327
	public const int ROTATION_STOP_DELAY_STAND = 200;

	// Token: 0x0400D050 RID: 53328
	public const float MIN_MOVE_SPEED_RATE = 0.3f;

	// Token: 0x0400D051 RID: 53329
	public const int MODEL_BUFFER_TIME = 100;

	// Token: 0x0400D052 RID: 53330
	public const int STAND_CHECK_TIME = 800;

	// Token: 0x0400D053 RID: 53331
	public const int STAND_ROTATION_INTERVAL = 2000;

	// Token: 0x0400D054 RID: 53332
	public const int SECOND_TO_MILLISECOND = 1000;

	// Token: 0x0400D055 RID: 53333
	public const float HEIGHT_LIMIT = 800f;

	// Token: 0x0400D056 RID: 53334
	public const int END_DISTANCE = 80;
}
