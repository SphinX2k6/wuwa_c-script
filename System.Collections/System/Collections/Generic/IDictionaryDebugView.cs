using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x0200000F RID: 15
	internal sealed class IDictionaryDebugView<TKey, TValue>
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00003F88 File Offset: 0x00002188
		public IDictionaryDebugView(IDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this._dict = dictionary;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003FA8 File Offset: 0x000021A8
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public DebugViewDictionaryItem<TKey, TValue>[] Items
		{
			get
			{
				KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[this._dict.Count];
				this._dict.CopyTo(array, 0);
				DebugViewDictionaryItem<TKey, TValue>[] array2 = new DebugViewDictionaryItem<TKey, TValue>[array.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = new DebugViewDictionaryItem<TKey, TValue>(array[i]);
				}
				return array2;
			}
		}

		// Token: 0x04000011 RID: 17
		private readonly IDictionary<TKey, TValue> _dict;
	}
}
