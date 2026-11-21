using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x020009B6 RID: 2486
	[DebuggerDisplay("{Value}", Name = "[{Key}]")]
	internal readonly struct DebugViewDictionaryItem<TKey, TValue>
	{
		// Token: 0x0600929B RID: 37531 RVA: 0x0016D4FB File Offset: 0x0016B6FB
		public DebugViewDictionaryItem(TKey key, TValue value)
		{
			this.Key = key;
			this.Value = value;
		}

		// Token: 0x0600929C RID: 37532 RVA: 0x0016D50B File Offset: 0x0016B70B
		public DebugViewDictionaryItem(KeyValuePair<TKey, TValue> keyValue)
		{
			this.Key = keyValue.Key;
			this.Value = keyValue.Value;
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x0600929D RID: 37533 RVA: 0x0016D527 File Offset: 0x0016B727
		[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
		public TKey Key { get; }

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x0600929E RID: 37534 RVA: 0x0016D52F File Offset: 0x0016B72F
		[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
		public TValue Value { get; }
	}
}
