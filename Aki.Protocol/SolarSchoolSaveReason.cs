using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016D8 RID: 5848
	public enum SolarSchoolSaveReason
	{
		// Token: 0x0400C664 RID: 50788
		[OriginalName("SolarSchoolReasonManual")]
		SolarSchoolReasonManual,
		// Token: 0x0400C665 RID: 50789
		[OriginalName("SolarSchoolReasonNewWeek")]
		SolarSchoolReasonNewWeek,
		// Token: 0x0400C666 RID: 50790
		[OriginalName("SolarSchoolReasonNewCycle")]
		SolarSchoolReasonNewCycle,
		// Token: 0x0400C667 RID: 50791
		[OriginalName("SolarSchoolReasonLoad")]
		SolarSchoolReasonLoad
	}
}
