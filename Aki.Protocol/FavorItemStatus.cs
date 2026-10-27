using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015AF RID: 5551
	public enum FavorItemStatus
	{
		// Token: 0x0400BC61 RID: 48225
		[OriginalName("ItemLocked")]
		ItemLocked,
		// Token: 0x0400BC62 RID: 48226
		[OriginalName("ItemCanUnLock")]
		ItemCanUnLock,
		// Token: 0x0400BC63 RID: 48227
		[OriginalName("ItemUnLocked")]
		ItemUnLocked
	}
}
