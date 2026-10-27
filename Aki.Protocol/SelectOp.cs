using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001637 RID: 5687
	public enum SelectOp
	{
		// Token: 0x0400C076 RID: 49270
		[OriginalName("NormalSelect")]
		NormalSelect,
		// Token: 0x0400C077 RID: 49271
		[OriginalName("Refresh")]
		Refresh = -1,
		// Token: 0x0400C078 RID: 49272
		[OriginalName("GiveUp")]
		GiveUp = -2
	}
}
