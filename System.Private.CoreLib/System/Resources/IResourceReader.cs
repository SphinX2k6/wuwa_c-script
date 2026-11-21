using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Resources
{
	// Token: 0x0200027A RID: 634
	public interface IResourceReader : IEnumerable, IDisposable
	{
		// Token: 0x06002E2A RID: 11818
		void Close();

		// Token: 0x06002E2B RID: 11819
		[NullableContext(1)]
		IDictionaryEnumerator GetEnumerator();
	}
}
