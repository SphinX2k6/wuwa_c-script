using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001693 RID: 5779
	public enum AccessRangeType
	{
		// Token: 0x0400C505 RID: 50437
		[OriginalName("RangeEnter")]
		RangeEnter,
		// Token: 0x0400C506 RID: 50438
		[OriginalName("RangeLeave")]
		RangeLeave,
		// Token: 0x0400C507 RID: 50439
		[OriginalName("RangeInit")]
		RangeInit,
		// Token: 0x0400C508 RID: 50440
		[OriginalName("RangeInitOut")]
		RangeInitOut
	}
}
