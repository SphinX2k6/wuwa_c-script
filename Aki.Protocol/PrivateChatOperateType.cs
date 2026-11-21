using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015EC RID: 5612
	public enum PrivateChatOperateType
	{
		// Token: 0x0400AB2F RID: 43823
		[OriginalName("CloseChat")]
		CloseChat,
		// Token: 0x0400AB30 RID: 43824
		[OriginalName("OpenChat")]
		OpenChat,
		// Token: 0x0400AB31 RID: 43825
		[OriginalName("ReadMsg")]
		ReadMsg
	}
}
