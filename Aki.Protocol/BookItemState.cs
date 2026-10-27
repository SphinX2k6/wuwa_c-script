using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200165D RID: 5725
	public enum BookItemState
	{
		// Token: 0x0400C140 RID: 49472
		[OriginalName("BookItemLock")]
		BookItemLock,
		// Token: 0x0400C141 RID: 49473
		[OriginalName("BookItemUnlock")]
		BookItemUnlock,
		// Token: 0x0400C142 RID: 49474
		[OriginalName("BookItemRewarded")]
		BookItemRewarded
	}
}
