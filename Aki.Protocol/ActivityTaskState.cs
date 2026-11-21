using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015BE RID: 5566
	public enum ActivityTaskState
	{
		// Token: 0x0400A9CE RID: 43470
		[OriginalName("ActivityTaskRunning")]
		ActivityTaskRunning,
		// Token: 0x0400A9CF RID: 43471
		[OriginalName("ActivityTaskFinish")]
		ActivityTaskFinish,
		// Token: 0x0400A9D0 RID: 43472
		[OriginalName("ActivityTaskTaken")]
		ActivityTaskTaken
	}
}
