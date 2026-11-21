using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001646 RID: 5702
	public enum HookInteractActionType
	{
		// Token: 0x0400C279 RID: 49785
		[OriginalName("Hooked")]
		Hooked,
		// Token: 0x0400C27A RID: 49786
		[OriginalName("ExitMidway")]
		ExitMidway,
		// Token: 0x0400C27B RID: 49787
		[OriginalName("ExitEndpoint")]
		ExitEndpoint
	}
}
