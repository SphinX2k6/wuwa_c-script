using System;
using System.Runtime.CompilerServices;

// Token: 0x02003108 RID: 12552
[NullableContext(1)]
[Nullable(0)]
public static class FreeFollowingUtilsDefine
{
	// Token: 0x0400D13C RID: 53564
	public const double FORWARD_OFFSET_SMOOTHING_TIME_SECONDS = 0.25;

	// Token: 0x0400D13D RID: 53565
	public const double LEADER_SPEED_SMOOTHING_TIME_SECONDS = 0.2;

	// Token: 0x0400D13E RID: 53566
	public const double LEADER_ACCELERATION_SMOOTHING_TIME_SECONDS = 0.12;

	// Token: 0x0400D13F RID: 53567
	public const double ACCELERATION_PREDICTION_TIME_SECONDS = 0.18;

	// Token: 0x0400D140 RID: 53568
	public const double MAX_LEADER_ACCELERATION_CMPS2 = 1200.0;

	// Token: 0x0400D141 RID: 53569
	public const double REFERENCE_DIRECTION_SPEED_DEG_PER_SECOND = 180.0;

	// Token: 0x0400D142 RID: 53570
	public const double REFERENCE_DIRECTION_DEAD_ZONE_DEGREES = 3.0;

	// Token: 0x0400D143 RID: 53571
	public const double REFERENCE_DIRECTION_SNAP_ANGLE_DEGREES = 135.0;

	// Token: 0x0400D144 RID: 53572
	public const double MOVEMENT_DIRECTION_MIN_SPEED_CMPS = 30.0;

	// Token: 0x0400D145 RID: 53573
	public const double REVERSAL_TEASING_WINDOW_SECONDS = 1.5;

	// Token: 0x0400D146 RID: 53574
	public const double REVERSAL_DETECT_DOT = -0.7071067811865476;

	// Token: 0x0400D147 RID: 53575
	public const double REVERSAL_DETECT_MIN_SPEED_CMPS = 60.0;

	// Token: 0x0400D148 RID: 53576
	public const double LOCAL_MOVEMENT_EXIT_RATE = 0.7;

	// Token: 0x0400D149 RID: 53577
	public const double LOCAL_MOVEMENT_EXIT_CONFIRM_SECONDS = 0.2;

	// Token: 0x0400D14A RID: 53578
	public const double HOLD_RADIUS_TOLERANCE = 1.0;

	// Token: 0x0400D14B RID: 53579
	public const double WALK_ARRIVAL_HOLD_SECONDS = 0.3;

	// Token: 0x0400D14C RID: 53580
	public const double WALK_BEHIND_TARGET_ENTER_ANGLE = 100.0;

	// Token: 0x0400D14D RID: 53581
	public const double WALK_BEHIND_TARGET_RESET_ANGLE = 80.0;

	// Token: 0x0400D14E RID: 53582
	public const double REJOIN_MIN_DURATION_SECONDS = 0.3;

	// Token: 0x0400D14F RID: 53583
	public const double RECOVER_DURATION_SECONDS = 0.4;

	// Token: 0x0400D150 RID: 53584
	public const double WALK_SIDE_SWITCH_MIN_ANGLE_DEGREES = 3.0;

	// Token: 0x0400D151 RID: 53585
	public const double HIGH_SPEED_SIDE_SWITCH_MIN_ANGLE_DEGREES = 15.0;

	// Token: 0x0400D152 RID: 53586
	public const double WALK_SIDE_SWITCH_MIN_RATE = 0.052335956242943835;

	// Token: 0x0400D153 RID: 53587
	public const double HIGH_SPEED_SIDE_SWITCH_MIN_RATE = 0.25881904510252074;

	// Token: 0x0400D154 RID: 53588
	[StaticVariableRuleIgnore]
	public static readonly string[] FreeFollowingStateNames = new string[]
	{
		"Stable",
		"FormationFollow",
		"Rejoin",
		"Recover"
	};

	// Token: 0x0400D155 RID: 53589
	[StaticVariableRuleIgnore]
	public static readonly double[] FreeFollowingCandidateAngles = new double[]
	{
		0.0,
		-30.0,
		30.0,
		-60.0,
		60.0
	};
}
