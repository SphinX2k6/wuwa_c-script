using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016A6 RID: 5798
	public enum GainDataUpdateType
	{
		// Token: 0x0400C55F RID: 50527
		[OriginalName("GainDataAdd")]
		GainDataAdd,
		// Token: 0x0400C560 RID: 50528
		[OriginalName("GainDataDelete")]
		GainDataDelete,
		// Token: 0x0400C561 RID: 50529
		[OriginalName("GainDataUpdate")]
		GainDataUpdate
	}
}
