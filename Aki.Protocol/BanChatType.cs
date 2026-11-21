using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C9 RID: 5577
	public enum BanChatType
	{
		// Token: 0x0400A9FC RID: 43516
		[OriginalName("None")]
		None,
		// Token: 0x0400A9FD RID: 43517
		[OriginalName("All")]
		All,
		// Token: 0x0400A9FE RID: 43518
		[OriginalName("Friend")]
		Friend,
		// Token: 0x0400A9FF RID: 43519
		[OriginalName("Foreign")]
		Foreign,
		// Token: 0x0400AA00 RID: 43520
		[OriginalName("Team")]
		Team
	}
}
