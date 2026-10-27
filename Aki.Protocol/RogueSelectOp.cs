using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200162E RID: 5678
	public enum RogueSelectOp
	{
		// Token: 0x0400C04A RID: 49226
		[OriginalName("NormalSelect")]
		NormalSelect,
		// Token: 0x0400C04B RID: 49227
		[OriginalName("Refresh")]
		Refresh = -1,
		// Token: 0x0400C04C RID: 49228
		[OriginalName("GiveUp")]
		GiveUp = -2
	}
}
