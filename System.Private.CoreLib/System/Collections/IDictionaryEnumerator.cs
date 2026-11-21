using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x02000978 RID: 2424
	[NullableContext(1)]
	public interface IDictionaryEnumerator : IEnumerator
	{
		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06009089 RID: 37001
		object Key { get; }

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x0600908A RID: 37002
		[Nullable(2)]
		object Value { [NullableContext(2)] get; }

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x0600908B RID: 37003
		DictionaryEntry Entry { get; }
	}
}
