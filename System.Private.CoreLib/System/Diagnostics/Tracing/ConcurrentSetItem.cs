using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200091C RID: 2332
	internal abstract class ConcurrentSetItem<KeyType, ItemType> where ItemType : ConcurrentSetItem<KeyType, ItemType>
	{
		// Token: 0x06008D6B RID: 36203
		public abstract int Compare(ItemType other);

		// Token: 0x06008D6C RID: 36204
		public abstract int Compare(KeyType key);
	}
}
