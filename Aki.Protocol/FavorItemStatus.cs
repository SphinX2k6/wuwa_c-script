using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001621 RID: 5665
	public enum FavorItemStatus
	{
		// Token: 0x0400C154 RID: 49492
		[OriginalName("ItemLocked")]
		ItemLocked,
		// Token: 0x0400C155 RID: 49493
		[OriginalName("ItemCanUnLock")]
		ItemCanUnLock,
		// Token: 0x0400C156 RID: 49494
		[OriginalName("ItemUnLocked")]
		ItemUnLocked
	}
}
