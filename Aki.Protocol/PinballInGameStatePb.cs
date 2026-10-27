using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001614 RID: 5652
	public enum PinballInGameStatePb
	{
		// Token: 0x0400BFB7 RID: 49079
		[OriginalName("NotInitiated")]
		NotInitiated,
		// Token: 0x0400BFB8 RID: 49080
		[OriginalName("InProgress")]
		InProgress,
		// Token: 0x0400BFB9 RID: 49081
		[OriginalName("SettlePreSubmit")]
		SettlePreSubmit,
		// Token: 0x0400BFBA RID: 49082
		[OriginalName("SettleFinish")]
		SettleFinish
	}
}
