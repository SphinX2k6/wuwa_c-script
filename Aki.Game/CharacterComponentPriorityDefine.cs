using System;

// Token: 0x020023A5 RID: 9125
public class CharacterComponentPriorityDefine
{
	// Token: 0x0400BF59 RID: 48985
	public const int UE_MOVE_TICK_PRIORITY = 1000;

	// Token: 0x0400BF5A RID: 48986
	public const int UE_ACTOR_TICK_PRIOTITY = 900;

	// Token: 0x0400BF5B RID: 48987
	public const int ACTOR_TICK_PRIORITY = 100;

	// Token: 0x0400BF5C RID: 48988
	public const int INPUT_TICK_PRIORITY = 99;

	// Token: 0x0400BF5D RID: 48989
	public const int SPLINE_MOVE_TICK_PRIORITY = 98;

	// Token: 0x0400BF5E RID: 48990
	public const int SLIDE_TICK_PRIORITY = 91;

	// Token: 0x0400BF5F RID: 48991
	public const int CLIMB_TICK_PRIORITY = 90;

	// Token: 0x0400BF60 RID: 48992
	public const int MOVE_TICK_PRIORITY = 80;

	// Token: 0x0400BF61 RID: 48993
	public const int GAIT_TICK_PRIORITY = 70;

	// Token: 0x0400BF62 RID: 48994
	public const int MOVEMENT_SYNC_TICK_PRIORITY = 60;

	// Token: 0x0400BF63 RID: 48995
	public const int UE_SKELETAL_TICK_PRIORITY = 50;

	// Token: 0x0400BF64 RID: 48996
	public const int UE_OTHER_COMPONENT_TICK_PRIORITY = 1;
}
