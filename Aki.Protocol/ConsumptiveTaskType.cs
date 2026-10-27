using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001581 RID: 5505
	public enum ConsumptiveTaskType
	{
		// Token: 0x0400A76B RID: 42859
		[OriginalName("Unknown")]
		Unknown,
		// Token: 0x0400A76C RID: 42860
		[OriginalName("Single")]
		Single,
		// Token: 0x0400A76D RID: 42861
		[OriginalName("Cycle")]
		Cycle
	}
}
