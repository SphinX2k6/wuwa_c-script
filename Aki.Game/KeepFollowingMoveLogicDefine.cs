using System;
using System.Runtime.CompilerServices;

// Token: 0x02002651 RID: 9809
[NullableContext(1)]
[Nullable(0)]
public static class KeepFollowingMoveLogicDefine
{
	// Token: 0x0400D437 RID: 54327
	public const int DEBUG_RADIUS = 20;

	// Token: 0x0400D438 RID: 54328
	public const int DEBUG_SEGMENTS = 10;

	// Token: 0x0400D439 RID: 54329
	public const int DETECT_HEIGHT = 2;

	// Token: 0x0400D43A RID: 54330
	public const string PROFILE_KEY = "KeepFollowing";

	// Token: 0x0400D43B RID: 54331
	public const int CHECK_DIRECTION_ANGLE = 40;

	// Token: 0x0400D43C RID: 54332
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

	// Token: 0x0400D43D RID: 54333
	[StaticVariableRuleIgnore]
	public static readonly int[] checkDistanceList = new int[]
	{
		0,
		100,
		200,
		300,
		400
	};

	// Token: 0x0400D43E RID: 54334
	public const float FALLBACK_TELEPORT_RADIUS_MARGIN = 200f;

	// Token: 0x0400D43F RID: 54335
	public const int MIN_ANGLE = 5;

	// Token: 0x0400D440 RID: 54336
	public const float STAND_TOLERANCE_RATE = 0.4f;

	// Token: 0x0400D441 RID: 54337
	public const int COMPENSATE_TOLERANCE_DISTANCE = 5;

	// Token: 0x0400D442 RID: 54338
	public const int ANGLE_DIRECTION_TOLERANCE = 45;

	// Token: 0x0400D443 RID: 54339
	public const float DECELERATION_SPEED_RATE = -5f;

	// Token: 0x0400D444 RID: 54340
	public const int ROTATION_STOP_DELAY_STAND = 200;

	// Token: 0x0400D445 RID: 54341
	public const float MIN_MOVE_SPEED_RATE = 0.3f;

	// Token: 0x0400D446 RID: 54342
	public const int FREE_FOLLOWING_TARGET_RESOLVE_INTERVAL = 150;

	// Token: 0x0400D447 RID: 54343
	public const int FREE_FOLLOWING_TARGET_MIN_RESOLVE_INTERVAL = 100;

	// Token: 0x0400D448 RID: 54344
	public const int FREE_FOLLOWING_TARGET_WAIT_RETRY_INTERVAL = 500;

	// Token: 0x0400D449 RID: 54345
	public const int FREE_FOLLOWING_TARGET_REFRESH_DISTANCE = 100;

	// Token: 0x0400D44A RID: 54346
	public const int FREE_FOLLOWING_NAV_PATH_MIN_CHECK_DISTANCE = 100;

	// Token: 0x0400D44B RID: 54347
	public const int FREE_FOLLOWING_NAV_MOVE_POINT_REFRESH_DISTANCE = 50;

	// Token: 0x0400D44C RID: 54348
	public const int FREE_FOLLOWING_NAV_SAFE_LOCATION_REACHED_DISTANCE = 1;

	// Token: 0x0400D44D RID: 54349
	public const int MODEL_BUFFER_TIME = 100;

	// Token: 0x0400D44E RID: 54350
	public const int STAND_CHECK_TIME = 800;

	// Token: 0x0400D44F RID: 54351
	public const int STAND_ROTATION_INTERVAL = 2000;

	// Token: 0x0400D450 RID: 54352
	public const int SECOND_TO_MILLISECOND = 1000;

	// Token: 0x0400D451 RID: 54353
	public const float HEIGHT_LIMIT = 800f;

	// Token: 0x0400D452 RID: 54354
	public const int END_DISTANCE = 80;
}
