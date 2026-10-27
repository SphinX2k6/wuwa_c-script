using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001548 RID: 5448
	public enum ActivityTaskState
	{
		// Token: 0x0400A570 RID: 42352
		[OriginalName("ActivityTaskRunning")]
		ActivityTaskRunning,
		// Token: 0x0400A571 RID: 42353
		[OriginalName("ActivityTaskFinish")]
		ActivityTaskFinish,
		// Token: 0x0400A572 RID: 42354
		[OriginalName("ActivityTaskTaken")]
		ActivityTaskTaken
	}
}
