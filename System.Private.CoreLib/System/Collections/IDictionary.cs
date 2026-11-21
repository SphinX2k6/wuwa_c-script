using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x02000977 RID: 2423
	[NullableContext(1)]
	public interface IDictionary : ICollection, IEnumerable
	{
		// Token: 0x1700136F RID: 4975
		[Nullable(2)]
		object this[object key]
		{
			[return: Nullable(2)]
			get;
			[param: Nullable(2)]
			set;
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06009080 RID: 36992
		ICollection Keys { get; }

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06009081 RID: 36993
		ICollection Values { get; }

		// Token: 0x06009082 RID: 36994
		bool Contains(object key);

		// Token: 0x06009083 RID: 36995
		void Add(object key, [Nullable(2)] object value);

		// Token: 0x06009084 RID: 36996
		void Clear();

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06009085 RID: 36997
		bool IsReadOnly { get; }

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06009086 RID: 36998
		bool IsFixedSize { get; }

		// Token: 0x06009087 RID: 36999
		IDictionaryEnumerator GetEnumerator();

		// Token: 0x06009088 RID: 37000
		void Remove(object key);
	}
}
