using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C2 RID: 5570
	public enum CabinType
	{
		// Token: 0x0400BCB4 RID: 48308
		[OriginalName("ShipCabin")]
		ShipCabin,
		// Token: 0x0400BCB5 RID: 48309
		[OriginalName("TempCabin")]
		TempCabin,
		// Token: 0x0400BCB6 RID: 48310
		[OriginalName("NetCabin")]
		NetCabin,
		// Token: 0x0400BCB7 RID: 48311
		[OriginalName("Cage")]
		Cage,
		// Token: 0x0400BCB8 RID: 48312
		[OriginalName("HandIn")]
		HandIn
	}
}
