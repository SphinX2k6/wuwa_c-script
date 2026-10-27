using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E6 RID: 5606
	public enum InfrTaskStatusPb
	{
		// Token: 0x0400BDD8 RID: 48600
		[OriginalName("InfrTaskRunning")]
		InfrTaskRunning,
		// Token: 0x0400BDD9 RID: 48601
		[OriginalName("InfrTaskFinish")]
		InfrTaskFinish,
		// Token: 0x0400BDDA RID: 48602
		[OriginalName("InfrTaskTaken")]
		InfrTaskTaken
	}
}
