using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x0200167C RID: 5756
	public enum ESummonType
	{
		// Token: 0x0400C1F2 RID: 49650
		[OriginalName("ESummonTypeDefault")]
		Default,
		// Token: 0x0400C1F3 RID: 49651
		[OriginalName("ESummonTypeConcomitantVision")]
		ConcomitantVision,
		// Token: 0x0400C1F4 RID: 49652
		[OriginalName("ESummonTypeConcomitantCustom")]
		ConcomitantCustom,
		// Token: 0x0400C1F5 RID: 49653
		[OriginalName("ESummonTypeConcomitantPhantomRole")]
		ConcomitantPhantomRole,
		// Token: 0x0400C1F6 RID: 49654
		[OriginalName("ESummonTypeConcomitantWeakVision")]
		ConcomitantWeakVision,
		// Token: 0x0400C1F7 RID: 49655
		[OriginalName("ESummonTypeConcomitantMotorcycle")]
		ConcomitantMotorcycle
	}
}
