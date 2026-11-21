using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Generic
{
	// Token: 0x020009C3 RID: 2499
	[NullableContext(1)]
	public interface IAsyncEnumerable<[Nullable(2)] out T>
	{
		// Token: 0x06009314 RID: 37652
		IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken));
	}
}
