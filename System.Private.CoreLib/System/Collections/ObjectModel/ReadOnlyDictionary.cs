using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.ObjectModel
{
	// Token: 0x02000989 RID: 2441
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ReadOnlyDictionary<TKey, [Nullable(2)] TValue> : IDictionary<!0, !1>, ICollection<KeyValuePair<!0, !1>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<!0, !1>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x0600910C RID: 37132 RVA: 0x001669D6 File Offset: 0x00164BD6
		public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
		{
			ArgumentNullException.ThrowIfNull(dictionary, "dictionary");
			this.m_dictionary = dictionary;
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600910D RID: 37133 RVA: 0x001669F0 File Offset: 0x00164BF0
		public static ReadOnlyDictionary<TKey, TValue> Empty { get; } = new ReadOnlyDictionary<TKey, TValue>(new Dictionary<TKey, TValue>());

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x0600910E RID: 37134 RVA: 0x001669F7 File Offset: 0x00164BF7
		protected IDictionary<TKey, TValue> Dictionary
		{
			get
			{
				return this.m_dictionary;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x0600910F RID: 37135 RVA: 0x00166A00 File Offset: 0x00164C00
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public ReadOnlyDictionary<TKey, TValue>.KeyCollection Keys
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				ReadOnlyDictionary<TKey, TValue>.KeyCollection result;
				if ((result = this._keys) == null)
				{
					result = (this._keys = new ReadOnlyDictionary<TKey, TValue>.KeyCollection(this.m_dictionary.Keys));
				}
				return result;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06009110 RID: 37136 RVA: 0x00166A30 File Offset: 0x00164C30
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public ReadOnlyDictionary<TKey, TValue>.ValueCollection Values
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				ReadOnlyDictionary<TKey, TValue>.ValueCollection result;
				if ((result = this._values) == null)
				{
					result = (this._values = new ReadOnlyDictionary<TKey, TValue>.ValueCollection(this.m_dictionary.Values));
				}
				return result;
			}
		}

		// Token: 0x06009111 RID: 37137 RVA: 0x00166A60 File Offset: 0x00164C60
		public bool ContainsKey(TKey key)
		{
			return this.m_dictionary.ContainsKey(key);
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06009112 RID: 37138 RVA: 0x00166A6E File Offset: 0x00164C6E
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x06009113 RID: 37139 RVA: 0x00166A76 File Offset: 0x00164C76
		public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			return this.m_dictionary.TryGetValue(key, out value);
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06009114 RID: 37140 RVA: 0x00166A85 File Offset: 0x00164C85
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x170013A6 RID: 5030
		public TValue this[TKey key]
		{
			get
			{
				return this.m_dictionary[key];
			}
		}

		// Token: 0x06009116 RID: 37142 RVA: 0x00162F26 File Offset: 0x00161126
		void IDictionary<!0, !1>.Add(TKey key, TValue value)
		{
			throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x06009117 RID: 37143 RVA: 0x00162F26 File Offset: 0x00161126
		bool IDictionary<!0, !1>.Remove(TKey key)
		{
			throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x170013A7 RID: 5031
		TValue IDictionary<!0, !1>.this[TKey key]
		{
			get
			{
				return this.m_dictionary[key];
			}
			set
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x0600911A RID: 37146 RVA: 0x00166A9B File Offset: 0x00164C9B
		public int Count
		{
			get
			{
				return this.m_dictionary.Count;
			}
		}

		// Token: 0x0600911B RID: 37147 RVA: 0x00166AA8 File Offset: 0x00164CA8
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return this.m_dictionary.Contains(item);
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x00166AB6 File Offset: 0x00164CB6
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			this.m_dictionary.CopyTo(array, arrayIndex);
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x0600911D RID: 37149 RVA: 0x000070DD File Offset: 0x000052DD
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600911E RID: 37150 RVA: 0x00162F26 File Offset: 0x00161126
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x00162F26 File Offset: 0x00161126
		void ICollection<KeyValuePair<!0, !1>>.Clear()
		{
			throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x06009120 RID: 37152 RVA: 0x00162F26 File Offset: 0x00161126
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x06009121 RID: 37153 RVA: 0x00166AC5 File Offset: 0x00164CC5
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return this.m_dictionary.GetEnumerator();
		}

		// Token: 0x06009122 RID: 37154 RVA: 0x00166AD2 File Offset: 0x00164CD2
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.m_dictionary.GetEnumerator();
		}

		// Token: 0x06009123 RID: 37155 RVA: 0x00166ADF File Offset: 0x00164CDF
		private static bool IsCompatibleKey(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			return key is TKey;
		}

		// Token: 0x06009124 RID: 37156 RVA: 0x00162F26 File Offset: 0x00161126
		void IDictionary.Add(object key, object value)
		{
			throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x00162F26 File Offset: 0x00161126
		void IDictionary.Clear()
		{
			throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x06009126 RID: 37158 RVA: 0x00166AF5 File Offset: 0x00164CF5
		bool IDictionary.Contains(object key)
		{
			return ReadOnlyDictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		// Token: 0x06009127 RID: 37159 RVA: 0x00166B10 File Offset: 0x00164D10
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			IDictionary dictionary = this.m_dictionary as IDictionary;
			if (dictionary != null)
			{
				return dictionary.GetEnumerator();
			}
			return new ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator(this.m_dictionary);
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06009128 RID: 37160 RVA: 0x000070DD File Offset: 0x000052DD
		bool IDictionary.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06009129 RID: 37161 RVA: 0x000070DD File Offset: 0x000052DD
		bool IDictionary.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x0600912A RID: 37162 RVA: 0x00166A6E File Offset: 0x00164C6E
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x0600912B RID: 37163 RVA: 0x00162F26 File Offset: 0x00161126
		void IDictionary.Remove(object key)
		{
			throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x0600912C RID: 37164 RVA: 0x00166A85 File Offset: 0x00164C85
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x170013AE RID: 5038
		[Nullable(2)]
		object IDictionary.this[object key]
		{
			get
			{
				if (!ReadOnlyDictionary<TKey, TValue>.IsCompatibleKey(key))
				{
					return null;
				}
				TValue tvalue;
				if (this.m_dictionary.TryGetValue((TKey)((object)key), out tvalue))
				{
					return tvalue;
				}
				return null;
			}
			set
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}
		}

		// Token: 0x0600912F RID: 37167 RVA: 0x00166B78 File Offset: 0x00164D78
		void ICollection.CopyTo(Array array, int index)
		{
			CollectionHelpers.ValidateCopyToArguments(this.Count, array, index);
			KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
			if (array2 != null)
			{
				this.m_dictionary.CopyTo(array2, index);
				return;
			}
			DictionaryEntry[] array3 = array as DictionaryEntry[];
			if (array3 != null)
			{
				using (IEnumerator<KeyValuePair<TKey, TValue>> enumerator = this.m_dictionary.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<TKey, TValue> keyValuePair = enumerator.Current;
						array3[index++] = new DictionaryEntry(keyValuePair.Key, keyValuePair.Value);
					}
					return;
				}
			}
			object[] array4 = array as object[];
			if (array4 == null)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
			object[] array5 = array4;
			try
			{
				foreach (KeyValuePair<TKey, TValue> keyValuePair2 in this.m_dictionary)
				{
					array5[index++] = new KeyValuePair<TKey, TValue>(keyValuePair2.Key, keyValuePair2.Value);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06009130 RID: 37168 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06009131 RID: 37169 RVA: 0x00166CAC File Offset: 0x00164EAC
		object ICollection.SyncRoot
		{
			get
			{
				ICollection collection = this.m_dictionary as ICollection;
				if (collection == null)
				{
					return this;
				}
				return collection.SyncRoot;
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06009132 RID: 37170 RVA: 0x00166A6E File Offset: 0x00164C6E
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06009133 RID: 37171 RVA: 0x00166A85 File Offset: 0x00164C85
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x04002225 RID: 8741
		private readonly IDictionary<TKey, TValue> m_dictionary;

		// Token: 0x04002226 RID: 8742
		[NonSerialized]
		private ReadOnlyDictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x04002227 RID: 8743
		[NonSerialized]
		private ReadOnlyDictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x0200098A RID: 2442
		private readonly struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06009135 RID: 37173 RVA: 0x00166CE1 File Offset: 0x00164EE1
			public DictionaryEnumerator(IDictionary<TKey, TValue> dictionary)
			{
				this._dictionary = dictionary;
				this._enumerator = this._dictionary.GetEnumerator();
			}

			// Token: 0x170013B3 RID: 5043
			// (get) Token: 0x06009136 RID: 37174 RVA: 0x00166CFC File Offset: 0x00164EFC
			public DictionaryEntry Entry
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					object key = keyValuePair.Key;
					keyValuePair = this._enumerator.Current;
					return new DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x170013B4 RID: 5044
			// (get) Token: 0x06009137 RID: 37175 RVA: 0x00166D40 File Offset: 0x00164F40
			public object Key
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x170013B5 RID: 5045
			// (get) Token: 0x06009138 RID: 37176 RVA: 0x00166D68 File Offset: 0x00164F68
			public object Value
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x170013B6 RID: 5046
			// (get) Token: 0x06009139 RID: 37177 RVA: 0x00166D8D File Offset: 0x00164F8D
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x0600913A RID: 37178 RVA: 0x00166D9A File Offset: 0x00164F9A
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x0600913B RID: 37179 RVA: 0x00166DA7 File Offset: 0x00164FA7
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x04002229 RID: 8745
			private readonly IDictionary<TKey, TValue> _dictionary;

			// Token: 0x0400222A RID: 8746
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;
		}

		// Token: 0x0200098B RID: 2443
		[Nullable(0)]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			// Token: 0x0600913C RID: 37180 RVA: 0x00166DB4 File Offset: 0x00164FB4
			internal KeyCollection(ICollection<TKey> collection)
			{
				ArgumentNullException.ThrowIfNull(collection, "collection");
				this._collection = collection;
			}

			// Token: 0x0600913D RID: 37181 RVA: 0x00162F26 File Offset: 0x00161126
			void ICollection<!0>.Add(TKey item)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x0600913E RID: 37182 RVA: 0x00162F26 File Offset: 0x00161126
			void ICollection<!0>.Clear()
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x0600913F RID: 37183 RVA: 0x00166DCE File Offset: 0x00164FCE
			public bool Contains(TKey item)
			{
				return this._collection.Contains(item);
			}

			// Token: 0x06009140 RID: 37184 RVA: 0x00166DDC File Offset: 0x00164FDC
			public void CopyTo(TKey[] array, int arrayIndex)
			{
				this._collection.CopyTo(array, arrayIndex);
			}

			// Token: 0x170013B7 RID: 5047
			// (get) Token: 0x06009141 RID: 37185 RVA: 0x00166DEB File Offset: 0x00164FEB
			public int Count
			{
				get
				{
					return this._collection.Count;
				}
			}

			// Token: 0x170013B8 RID: 5048
			// (get) Token: 0x06009142 RID: 37186 RVA: 0x000070DD File Offset: 0x000052DD
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06009143 RID: 37187 RVA: 0x00162F26 File Offset: 0x00161126
			bool ICollection<!0>.Remove(TKey item)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06009144 RID: 37188 RVA: 0x00166DF8 File Offset: 0x00164FF8
			public IEnumerator<TKey> GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			// Token: 0x06009145 RID: 37189 RVA: 0x00166E05 File Offset: 0x00165005
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			// Token: 0x06009146 RID: 37190 RVA: 0x00166E12 File Offset: 0x00165012
			void ICollection.CopyTo(Array array, int index)
			{
				CollectionHelpers.CopyTo<TKey>(this._collection, array, index);
			}

			// Token: 0x170013B9 RID: 5049
			// (get) Token: 0x06009147 RID: 37191 RVA: 0x00007B65 File Offset: 0x00005D65
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170013BA RID: 5050
			// (get) Token: 0x06009148 RID: 37192 RVA: 0x00166E24 File Offset: 0x00165024
			object ICollection.SyncRoot
			{
				get
				{
					ICollection collection = this._collection as ICollection;
					if (collection == null)
					{
						return this;
					}
					return collection.SyncRoot;
				}
			}

			// Token: 0x0400222B RID: 8747
			private readonly ICollection<TKey> _collection;
		}

		// Token: 0x0200098C RID: 2444
		[NullableContext(0)]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class ValueCollection : ICollection<!1>, IEnumerable<!1>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			// Token: 0x06009149 RID: 37193 RVA: 0x00166E48 File Offset: 0x00165048
			internal ValueCollection(ICollection<TValue> collection)
			{
				ArgumentNullException.ThrowIfNull(collection, "collection");
				this._collection = collection;
			}

			// Token: 0x0600914A RID: 37194 RVA: 0x00162F26 File Offset: 0x00161126
			void ICollection<!1>.Add(TValue item)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x0600914B RID: 37195 RVA: 0x00162F26 File Offset: 0x00161126
			void ICollection<!1>.Clear()
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x0600914C RID: 37196 RVA: 0x00166E62 File Offset: 0x00165062
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._collection.Contains(item);
			}

			// Token: 0x0600914D RID: 37197 RVA: 0x00166E70 File Offset: 0x00165070
			[NullableContext(1)]
			public void CopyTo(TValue[] array, int arrayIndex)
			{
				this._collection.CopyTo(array, arrayIndex);
			}

			// Token: 0x170013BB RID: 5051
			// (get) Token: 0x0600914E RID: 37198 RVA: 0x00166E7F File Offset: 0x0016507F
			public int Count
			{
				get
				{
					return this._collection.Count;
				}
			}

			// Token: 0x170013BC RID: 5052
			// (get) Token: 0x0600914F RID: 37199 RVA: 0x000070DD File Offset: 0x000052DD
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06009150 RID: 37200 RVA: 0x00162F26 File Offset: 0x00161126
			bool ICollection<!1>.Remove(TValue item)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06009151 RID: 37201 RVA: 0x00166E8C File Offset: 0x0016508C
			[NullableContext(1)]
			public IEnumerator<TValue> GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			// Token: 0x06009152 RID: 37202 RVA: 0x00166E99 File Offset: 0x00165099
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			// Token: 0x06009153 RID: 37203 RVA: 0x00166EA6 File Offset: 0x001650A6
			void ICollection.CopyTo(Array array, int index)
			{
				CollectionHelpers.CopyTo<TValue>(this._collection, array, index);
			}

			// Token: 0x170013BD RID: 5053
			// (get) Token: 0x06009154 RID: 37204 RVA: 0x00007B65 File Offset: 0x00005D65
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170013BE RID: 5054
			// (get) Token: 0x06009155 RID: 37205 RVA: 0x00166EB8 File Offset: 0x001650B8
			[Nullable(1)]
			object ICollection.SyncRoot
			{
				get
				{
					ICollection collection = this._collection as ICollection;
					if (collection == null)
					{
						return this;
					}
					return collection.SyncRoot;
				}
			}

			// Token: 0x0400222C RID: 8748
			private readonly ICollection<TValue> _collection;
		}
	}
}
