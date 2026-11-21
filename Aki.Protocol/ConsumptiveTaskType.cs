using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F7 RID: 5623
	public enum ConsumptiveTaskType
	{
		// Token: 0x0400ABF8 RID: 44024
		[OriginalName("Unknown")]
		Unknown,
		// Token: 0x0400ABF9 RID: 44025
		[OriginalName("Single")]
		Single,
		// Token: 0x0400ABFA RID: 44026
		[OriginalName("Cycle")]
		Cycle
	}
}
