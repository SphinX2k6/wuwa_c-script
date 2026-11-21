using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001634 RID: 5684
	public enum CabinType
	{
		// Token: 0x0400C1A7 RID: 49575
		[OriginalName("ShipCabin")]
		ShipCabin,
		// Token: 0x0400C1A8 RID: 49576
		[OriginalName("TempCabin")]
		TempCabin,
		// Token: 0x0400C1A9 RID: 49577
		[OriginalName("NetCabin")]
		NetCabin,
		// Token: 0x0400C1AA RID: 49578
		[OriginalName("Cage")]
		Cage,
		// Token: 0x0400C1AB RID: 49579
		[OriginalName("HandIn")]
		HandIn
	}
}
