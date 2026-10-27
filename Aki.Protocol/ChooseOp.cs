using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200165F RID: 5727
	public enum ChooseOp
	{
		// Token: 0x0400C149 RID: 49481
		[OriginalName("NormalSelect")]
		NormalSelect,
		// Token: 0x0400C14A RID: 49482
		[OriginalName("Refresh")]
		Refresh = -1,
		// Token: 0x0400C14B RID: 49483
		[OriginalName("GiveUp")]
		GiveUp = -2
	}
}
