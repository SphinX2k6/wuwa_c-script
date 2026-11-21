using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001687 RID: 5767
	public enum PinballInGameStatePb
	{
		// Token: 0x0400C4B1 RID: 50353
		[OriginalName("NotInitiated")]
		NotInitiated,
		// Token: 0x0400C4B2 RID: 50354
		[OriginalName("InProgress")]
		InProgress,
		// Token: 0x0400C4B3 RID: 50355
		[OriginalName("SettlePreSubmit")]
		SettlePreSubmit,
		// Token: 0x0400C4B4 RID: 50356
		[OriginalName("SettleFinish")]
		SettleFinish
	}
}
