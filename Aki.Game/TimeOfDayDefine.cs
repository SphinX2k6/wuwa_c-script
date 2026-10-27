using System;
using System.Runtime.CompilerServices;

// Token: 0x02002BAD RID: 11181
public static class TimeOfDayDefine
{
	// Token: 0x0400AD60 RID: 44384
	public const int TOD_MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x0400AD61 RID: 44385
	public const int TOD_SECOND_PER_MINUTE = 60;

	// Token: 0x0400AD62 RID: 44386
	public const int TOD_MINUTE_PER_HOUR = 60;

	// Token: 0x0400AD63 RID: 44387
	public const int TOD_HOUR_PER_DAY = 24;

	// Token: 0x0400AD64 RID: 44388
	public const int TOD_MINUTE_PER_DAY = 1440;

	// Token: 0x0400AD65 RID: 44389
	public const int TOD_SECOND_PER_HOUR = 3600;

	// Token: 0x0400AD66 RID: 44390
	public const int TOD_SECOND_PER_DAY = 86400;

	// Token: 0x0400AD67 RID: 44391
	public const int TOD_MILLIONSECOND_PER_DAY = 86400000;

	// Token: 0x0400AD68 RID: 44392
	public const int TOD_SAVE_CD_MINUTE = 2;

	// Token: 0x0400AD69 RID: 44393
	public const int TOD_SAVE_CD_SECONDS = 120;

	// Token: 0x0400AD6A RID: 44394
	public const int TOD_TICK_INTERVAL_SECOND = 0;

	// Token: 0x0400AD6B RID: 44395
	public const int TOD_TICK_INTERVAL_MILLIONSECOND = 0;

	// Token: 0x0400AD6C RID: 44396
	public const int TOD_RATE_RATIO = 10000;

	// Token: 0x0400AD6D RID: 44397
	public const int TOD_CIRCLE_ANGLE = 360;

	// Token: 0x0400AD6E RID: 44398
	public const int TOD_MIN_ADJUST_MINUTE = 30;

	// Token: 0x0400AD6F RID: 44399
	public const int TOD_MAX_ADJUST_DAY = 2;

	// Token: 0x0400AD70 RID: 44400
	[Nullable(1)]
	public const string TOD_CAMERA_SETTING_NAME = "1032";

	// Token: 0x0400AD71 RID: 44401
	public const int TOD_ANIMATION_LAST_SECOND = 2;

	// Token: 0x0400AD72 RID: 44402
	public const int DEFAULT_JUMP_HOUR = 12;
}
