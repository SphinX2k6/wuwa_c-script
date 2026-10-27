using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001553 RID: 5459
	public enum BanChatType
	{
		// Token: 0x0400A59E RID: 42398
		[OriginalName("None")]
		None,
		// Token: 0x0400A59F RID: 42399
		[OriginalName("All")]
		All,
		// Token: 0x0400A5A0 RID: 42400
		[OriginalName("Friend")]
		Friend,
		// Token: 0x0400A5A1 RID: 42401
		[OriginalName("Foreign")]
		Foreign,
		// Token: 0x0400A5A2 RID: 42402
		[OriginalName("Team")]
		Team
	}
}
