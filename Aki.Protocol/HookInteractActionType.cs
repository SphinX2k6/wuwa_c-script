using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D4 RID: 5588
	public enum HookInteractActionType
	{
		// Token: 0x0400BD85 RID: 48517
		[OriginalName("Hooked")]
		Hooked,
		// Token: 0x0400BD86 RID: 48518
		[OriginalName("ExitMidway")]
		ExitMidway,
		// Token: 0x0400BD87 RID: 48519
		[OriginalName("ExitEndpoint")]
		ExitEndpoint
	}
}
