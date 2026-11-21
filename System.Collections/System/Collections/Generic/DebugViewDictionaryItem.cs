using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x0200000D RID: 13
	[DebuggerDisplay("{Value}", Name = "[{Key}]")]
	internal readonly struct DebugViewDictionaryItem<TKey, TValue>
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00003F14 File Offset: 0x00002114
		public DebugViewDictionaryItem(KeyValuePair<TKey, TValue> keyValue)
		{
			this.Key = keyValue.Key;
			this.Value = keyValue.Value;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003F30 File Offset: 0x00002130
		[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
		public TKey Key { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003F38 File Offset: 0x00002138
		[DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
		public TValue Value { get; }
	}
}
