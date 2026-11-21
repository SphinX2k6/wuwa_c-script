using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016AA RID: 5802
	public enum SelectOp
	{
		// Token: 0x0400C570 RID: 50544
		[OriginalName("NormalSelect")]
		NormalSelect,
		// Token: 0x0400C571 RID: 50545
		[OriginalName("Refresh")]
		Refresh = -1,
		// Token: 0x0400C572 RID: 50546
		[OriginalName("GiveUp")]
		GiveUp = -2
	}
}
