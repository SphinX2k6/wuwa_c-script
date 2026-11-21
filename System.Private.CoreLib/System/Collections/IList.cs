using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x0200097D RID: 2429
	[NullableContext(2)]
	public interface IList : ICollection, IEnumerable
	{
		// Token: 0x17001378 RID: 4984
		object this[int index]
		{
			get;
			set;
		}

		// Token: 0x06009095 RID: 37013
		int Add(object value);

		// Token: 0x06009096 RID: 37014
		bool Contains(object value);

		// Token: 0x06009097 RID: 37015
		void Clear();

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06009098 RID: 37016
		bool IsReadOnly { get; }

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06009099 RID: 37017
		bool IsFixedSize { get; }

		// Token: 0x0600909A RID: 37018
		int IndexOf(object value);

		// Token: 0x0600909B RID: 37019
		void Insert(int index, object value);

		// Token: 0x0600909C RID: 37020
		void Remove(object value);

		// Token: 0x0600909D RID: 37021
		void RemoveAt(int index);
	}
}
