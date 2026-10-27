using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001576 RID: 5494
	public enum PrivateChatOperateType
	{
		// Token: 0x0400A6A2 RID: 42658
		[OriginalName("CloseChat")]
		CloseChat,
		// Token: 0x0400A6A3 RID: 42659
		[OriginalName("OpenChat")]
		OpenChat,
		// Token: 0x0400A6A4 RID: 42660
		[OriginalName("ReadMsg")]
		ReadMsg
	}
}
