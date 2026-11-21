using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000925 RID: 2341
	internal sealed class EventPayload : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		// Token: 0x06008D91 RID: 36241 RVA: 0x0015D3B5 File Offset: 0x0015B5B5
		internal EventPayload(string[] payloadNames, object[] payloadValues)
		{
			this.m_names = payloadNames;
			this.m_values = payloadValues;
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06008D92 RID: 36242 RVA: 0x0015D3CB File Offset: 0x0015B5CB
		public ICollection<string> Keys
		{
			get
			{
				return this.m_names;
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06008D93 RID: 36243 RVA: 0x0015D3D3 File Offset: 0x0015B5D3
		public ICollection<object> Values
		{
			get
			{
				return this.m_values;
			}
		}

		// Token: 0x170012EA RID: 4842
		public object this[string key]
		{
			get
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				int num = 0;
				string[] names = this.m_names;
				for (int i = 0; i < names.Length; i++)
				{
					if (names[i] == key)
					{
						return this.m_values[num];
					}
					num++;
				}
				throw new KeyNotFoundException(SR.Format(SR.Arg_KeyNotFoundWithKey, key));
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x0001A563 File Offset: 0x00018763
		public void Add(string key, object value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x0001A563 File Offset: 0x00018763
		public void Add(KeyValuePair<string, object> payloadEntry)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x0001A563 File Offset: 0x00018763
		public void Clear()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x0015D433 File Offset: 0x0015B633
		public bool Contains(KeyValuePair<string, object> entry)
		{
			return this.ContainsKey(entry.Key);
		}

		// Token: 0x06008D9A RID: 36250 RVA: 0x0015D444 File Offset: 0x0015B644
		public bool ContainsKey(string key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			string[] names = this.m_names;
			for (int i = 0; i < names.Length; i++)
			{
				if (names[i] == key)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06008D9B RID: 36251 RVA: 0x0015D47F File Offset: 0x0015B67F
		public int Count
		{
			get
			{
				return this.m_names.Length;
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06008D9C RID: 36252 RVA: 0x000070DD File Offset: 0x000052DD
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x0015D489 File Offset: 0x0015B689
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			int num;
			for (int i = 0; i < this.Keys.Count; i = num + 1)
			{
				yield return new KeyValuePair<string, object>(this.m_names[i], this.m_values[i]);
				num = i;
			}
			yield break;
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x0015D498 File Offset: 0x0015B698
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06008D9F RID: 36255 RVA: 0x0001A563 File Offset: 0x00018763
		public void CopyTo(KeyValuePair<string, object>[] payloadEntries, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06008DA0 RID: 36256 RVA: 0x0001A563 File Offset: 0x00018763
		public bool Remove(string key)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x0001A563 File Offset: 0x00018763
		public bool Remove(KeyValuePair<string, object> entry)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x0015D4A0 File Offset: 0x0015B6A0
		public bool TryGetValue(string key, [MaybeNullWhen(false)] out object value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			int num = 0;
			string[] names = this.m_names;
			for (int i = 0; i < names.Length; i++)
			{
				if (names[i] == key)
				{
					value = this.m_values[num];
					return true;
				}
				num++;
			}
			value = null;
			return false;
		}

		// Token: 0x040020F0 RID: 8432
		private readonly string[] m_names;

		// Token: 0x040020F1 RID: 8433
		private readonly object[] m_values;
	}
}
