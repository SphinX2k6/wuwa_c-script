using System;
using System.Runtime.CompilerServices;

// Token: 0x02000556 RID: 1366
public class ActivityCommonDefine
{
	// Token: 0x0400341A RID: 13338
	public const int ACTIVITYFIRSTUNLOCKFLAG = -100;

	// Token: 0x0400341B RID: 13339
	public const float REDDOT_TOLERANCE = 0.1f;

	// Token: 0x0400341C RID: 13340
	public const int ACTIVITY_PERMANENT_TAB_ID = 999;

	// Token: 0x0400341D RID: 13341
	public const int ACTIVITY_FILTER_ALL_ID = 999;

	// Token: 0x0400341E RID: 13342
	public const int ACTIVITY_RECOMMEND_FILTER_TAB_TYPE = 1;

	// Token: 0x0400341F RID: 13343
	public const int ACTIVITY_NEWBIE_FILTER_TAB_TYPE = 2;

	// Token: 0x04003420 RID: 13344
	public const int ACTIVITYFORCECLOSETIME = -1;

	// Token: 0x04003421 RID: 13345
	[Nullable(1)]
	public const string ACTIVITY_TIME_REASON = "活动开启关闭时间倒计时 [ActivityId:{0}, IsOpen:{1}]";

	// Token: 0x04003422 RID: 13346
	public const int CHECKGAP = 600000;
}
