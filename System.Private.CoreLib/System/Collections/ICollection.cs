using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x02000975 RID: 2421
	[NullableContext(1)]
	public interface ICollection : IEnumerable
	{
		// Token: 0x06009079 RID: 36985
		void CopyTo(Array array, int index);

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x0600907A RID: 36986
		int Count { get; }

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x0600907B RID: 36987
		object SyncRoot { get; }

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600907C RID: 36988
		bool IsSynchronized { get; }
	}
}
