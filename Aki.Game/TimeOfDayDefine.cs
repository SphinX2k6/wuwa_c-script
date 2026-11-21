using System;
using System.Runtime.CompilerServices;

// Token: 0x02002129 RID: 8489
public static class TimeOfDayDefine
{
	// Token: 0x0400B167 RID: 45415
	public const int TOD_MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x0400B168 RID: 45416
	public const int TOD_SECOND_PER_MINUTE = 60;

	// Token: 0x0400B169 RID: 45417
	public const int TOD_MINUTE_PER_HOUR = 60;

	// Token: 0x0400B16A RID: 45418
	public const int TOD_HOUR_PER_DAY = 24;

	// Token: 0x0400B16B RID: 45419
	public const int TOD_MINUTE_PER_DAY = 1440;

	// Token: 0x0400B16C RID: 45420
	public const int TOD_SECOND_PER_HOUR = 3600;

	// Token: 0x0400B16D RID: 45421
	public const int TOD_SECOND_PER_DAY = 86400;

	// Token: 0x0400B16E RID: 45422
	public const int TOD_MILLIONSECOND_PER_DAY = 86400000;

	// Token: 0x0400B16F RID: 45423
	public const int TOD_SAVE_CD_MINUTE = 2;

	// Token: 0x0400B170 RID: 45424
	public const int TOD_SAVE_CD_SECONDS = 120;

	// Token: 0x0400B171 RID: 45425
	public const int TOD_TICK_INTERVAL_SECOND = 0;

	// Token: 0x0400B172 RID: 45426
	public const int TOD_TICK_INTERVAL_MILLIONSECOND = 0;

	// Token: 0x0400B173 RID: 45427
	public const int TOD_RATE_RATIO = 10000;

	// Token: 0x0400B174 RID: 45428
	public const int TOD_CIRCLE_ANGLE = 360;

	// Token: 0x0400B175 RID: 45429
	public const int TOD_MIN_ADJUST_MINUTE = 30;

	// Token: 0x0400B176 RID: 45430
	public const int TOD_MAX_ADJUST_DAY = 2;

	// Token: 0x0400B177 RID: 45431
	[Nullable(1)]
	public const string TOD_CAMERA_SETTING_NAME = "1032";

	// Token: 0x0400B178 RID: 45432
	public const int TOD_ANIMATION_LAST_SECOND = 2;

	// Token: 0x0400B179 RID: 45433
	public const int DEFAULT_JUMP_HOUR = 12;
}
