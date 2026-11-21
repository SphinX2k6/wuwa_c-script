using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015BB RID: 5563
	public enum RogueWeeklyEntryType
	{
		// Token: 0x0400A9C2 RID: 43458
		[OriginalName("Unknow")]
		Unknow,
		// Token: 0x0400A9C3 RID: 43459
		[OriginalName("Goods")]
		Goods = 2,
		// Token: 0x0400A9C4 RID: 43460
		[OriginalName("CommonBuff")]
		CommonBuff = 9
	}
}
