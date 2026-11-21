using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x020016F8 RID: 5880
	public enum ESummonType
	{
		// Token: 0x0400C71D RID: 50973
		[OriginalName("ESummonTypeDefault")]
		Default,
		// Token: 0x0400C71E RID: 50974
		[OriginalName("ESummonTypeConcomitantVision")]
		ConcomitantVision,
		// Token: 0x0400C71F RID: 50975
		[OriginalName("ESummonTypeConcomitantCustom")]
		ConcomitantCustom,
		// Token: 0x0400C720 RID: 50976
		[OriginalName("ESummonTypeConcomitantPhantomRole")]
		ConcomitantPhantomRole,
		// Token: 0x0400C721 RID: 50977
		[OriginalName("ESummonTypeConcomitantWeakVision")]
		ConcomitantWeakVision,
		// Token: 0x0400C722 RID: 50978
		[OriginalName("ESummonTypeConcomitantMotorcycle")]
		ConcomitantMotorcycle,
		// Token: 0x0400C723 RID: 50979
		[OriginalName("ESummonTypeConcomitantSkillAvatar")]
		ConcomitantSkillAvatar
	}
}
