using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001620 RID: 5664
	public enum AccessRangeType
	{
		// Token: 0x0400C00B RID: 49163
		[OriginalName("RangeEnter")]
		RangeEnter,
		// Token: 0x0400C00C RID: 49164
		[OriginalName("RangeLeave")]
		RangeLeave,
		// Token: 0x0400C00D RID: 49165
		[OriginalName("RangeInit")]
		RangeInit,
		// Token: 0x0400C00E RID: 49166
		[OriginalName("RangeInitOut")]
		RangeInitOut
	}
}
