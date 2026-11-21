using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x020009C9 RID: 2505
	internal sealed class IDictionaryDebugView<TKey, TValue>
	{
		// Token: 0x06009329 RID: 37673 RVA: 0x0016F3F0 File Offset: 0x0016D5F0
		public IDictionaryDebugView(IDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this._dict = dictionary;
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x0600932A RID: 37674 RVA: 0x0016F410 File Offset: 0x0016D610
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

		// Token: 0x04002293 RID: 8851
		private readonly IDictionary<TKey, TValue> _dict;
	}
}
