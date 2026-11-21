using System;
using System.Runtime.CompilerServices;

// Token: 0x02002663 RID: 9827
[NullableContext(1)]
[Nullable(0)]
public static class FreeFollowingUtilsDefine
{
	// Token: 0x0400D55C RID: 54620
	public const double FORWARD_OFFSET_SMOOTHING_TIME_SECONDS = 0.25;

	// Token: 0x0400D55D RID: 54621
	public const double LEADER_SPEED_SMOOTHING_TIME_SECONDS = 0.2;

	// Token: 0x0400D55E RID: 54622
	public const double LEADER_ACCELERATION_SMOOTHING_TIME_SECONDS = 0.12;

	// Token: 0x0400D55F RID: 54623
	public const double ACCELERATION_PREDICTION_TIME_SECONDS = 0.18;

	// Token: 0x0400D560 RID: 54624
	public const double MAX_LEADER_ACCELERATION_CMPS2 = 1200.0;

	// Token: 0x0400D561 RID: 54625
	public const double REFERENCE_DIRECTION_SPEED_DEG_PER_SECOND = 180.0;

	// Token: 0x0400D562 RID: 54626
	public const double REFERENCE_DIRECTION_DEAD_ZONE_DEGREES = 3.0;

	// Token: 0x0400D563 RID: 54627
	public const double REFERENCE_DIRECTION_SNAP_ANGLE_DEGREES = 135.0;

	// Token: 0x0400D564 RID: 54628
	public const double MOVEMENT_DIRECTION_MIN_SPEED_CMPS = 30.0;

	// Token: 0x0400D565 RID: 54629
	public const double REVERSAL_TEASING_WINDOW_SECONDS = 1.5;

	// Token: 0x0400D566 RID: 54630
	public const double REVERSAL_DETECT_DOT = -0.7071067811865476;

	// Token: 0x0400D567 RID: 54631
	public const double REVERSAL_DETECT_MIN_SPEED_CMPS = 60.0;

	// Token: 0x0400D568 RID: 54632
	public const double LOCAL_MOVEMENT_EXIT_RATE = 0.7;

	// Token: 0x0400D569 RID: 54633
	public const double LOCAL_MOVEMENT_EXIT_CONFIRM_SECONDS = 0.2;

	// Token: 0x0400D56A RID: 54634
	public const double HOLD_RADIUS_TOLERANCE = 1.0;

	// Token: 0x0400D56B RID: 54635
	public const double WALK_ARRIVAL_HOLD_SECONDS = 0.3;

	// Token: 0x0400D56C RID: 54636
	public const double WALK_BEHIND_TARGET_ENTER_ANGLE = 100.0;

	// Token: 0x0400D56D RID: 54637
	public const double WALK_BEHIND_TARGET_RESET_ANGLE = 80.0;

	// Token: 0x0400D56E RID: 54638
	public const double REJOIN_MIN_DURATION_SECONDS = 0.3;

	// Token: 0x0400D56F RID: 54639
	public const double RECOVER_DURATION_SECONDS = 0.4;

	// Token: 0x0400D570 RID: 54640
	public const double WALK_SIDE_SWITCH_MIN_ANGLE_DEGREES = 3.0;

	// Token: 0x0400D571 RID: 54641
	public const double HIGH_SPEED_SIDE_SWITCH_MIN_ANGLE_DEGREES = 15.0;

	// Token: 0x0400D572 RID: 54642
	public const double WALK_SIDE_SWITCH_MIN_RATE = 0.052335956242943835;

	// Token: 0x0400D573 RID: 54643
	public const double HIGH_SPEED_SIDE_SWITCH_MIN_RATE = 0.25881904510252074;

	// Token: 0x0400D574 RID: 54644
	[StaticVariableRuleIgnore]
	public static readonly string[] FreeFollowingStateNames = new string[]
	{
		"Stable",
		"FormationFollow",
		"Rejoin",
		"Recover"
	};

	// Token: 0x0400D575 RID: 54645
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
