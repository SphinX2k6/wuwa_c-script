using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016D9 RID: 5849
	public enum BookItemState
	{
		// Token: 0x0400C669 RID: 50793
		[OriginalName("BookItemLock")]
		BookItemLock,
		// Token: 0x0400C66A RID: 50794
		[OriginalName("BookItemUnlock")]
		BookItemUnlock,
		// Token: 0x0400C66B RID: 50795
		[OriginalName("BookItemRewarded")]
		BookItemRewarded
	}
}
