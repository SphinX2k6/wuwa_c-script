using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001545 RID: 5445
	public enum RogueWeeklyEntryType
	{
		// Token: 0x0400A564 RID: 42340
		[OriginalName("Unknow")]
		Unknow,
		// Token: 0x0400A565 RID: 42341
		[OriginalName("Goods")]
		Goods = 2,
		// Token: 0x0400A566 RID: 42342
		[OriginalName("CommonBuff")]
		CommonBuff = 9
	}
}
