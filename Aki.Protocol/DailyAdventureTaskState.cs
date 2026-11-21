using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F9 RID: 5625
	public enum DailyAdventureTaskState
	{
		// Token: 0x0400ABFF RID: 44031
		[OriginalName("DailyAdventureTaskRunning")]
		DailyAdventureTaskRunning,
		// Token: 0x0400AC00 RID: 44032
		[OriginalName("DailyAdventureTaskFinish")]
		DailyAdventureTaskFinish,
		// Token: 0x0400AC01 RID: 44033
		[OriginalName("DailyAdventureTaskTaken")]
		DailyAdventureTaskTaken
	}
}
