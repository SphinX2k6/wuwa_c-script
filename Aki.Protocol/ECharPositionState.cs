using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200160E RID: 5646
	public enum ECharPositionState
	{
		// Token: 0x0400AC63 RID: 44131
		[OriginalName("Ground")]
		Ground,
		// Token: 0x0400AC64 RID: 44132
		[OriginalName("Climb")]
		Climb,
		// Token: 0x0400AC65 RID: 44133
		[OriginalName("Air")]
		Air,
		// Token: 0x0400AC66 RID: 44134
		[OriginalName("Water")]
		Water,
		// Token: 0x0400AC67 RID: 44135
		[OriginalName("Ski")]
		Ski,
		// Token: 0x0400AC68 RID: 44136
		[OriginalName("Ride")]
		Ride,
		// Token: 0x0400AC69 RID: 44137
		[OriginalName("RailSlide")]
		RailSlide,
		// Token: 0x0400AC6A RID: 44138
		[OriginalName("Floating")]
		Floating
	}
}
