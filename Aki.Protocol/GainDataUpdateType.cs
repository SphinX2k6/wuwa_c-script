using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001633 RID: 5683
	public enum GainDataUpdateType
	{
		// Token: 0x0400C065 RID: 49253
		[OriginalName("GainDataAdd")]
		GainDataAdd,
		// Token: 0x0400C066 RID: 49254
		[OriginalName("GainDataDelete")]
		GainDataDelete,
		// Token: 0x0400C067 RID: 49255
		[OriginalName("GainDataUpdate")]
		GainDataUpdate
	}
}
