using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159C RID: 5532
	public enum ECharPositionState
	{
		// Token: 0x0400A7E4 RID: 42980
		[OriginalName("Ground")]
		Ground,
		// Token: 0x0400A7E5 RID: 42981
		[OriginalName("Climb")]
		Climb,
		// Token: 0x0400A7E6 RID: 42982
		[OriginalName("Air")]
		Air,
		// Token: 0x0400A7E7 RID: 42983
		[OriginalName("Water")]
		Water,
		// Token: 0x0400A7E8 RID: 42984
		[OriginalName("Ski")]
		Ski,
		// Token: 0x0400A7E9 RID: 42985
		[OriginalName("Ride")]
		Ride,
		// Token: 0x0400A7EA RID: 42986
		[OriginalName("RailSlide")]
		RailSlide,
		// Token: 0x0400A7EB RID: 42987
		[OriginalName("Floating")]
		Floating
	}
}
