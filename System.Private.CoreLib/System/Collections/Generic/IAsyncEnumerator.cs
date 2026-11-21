using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
	// Token: 0x020009C4 RID: 2500
	public interface IAsyncEnumerator<[Nullable(2)] out T> : IAsyncDisposable
	{
		// Token: 0x06009315 RID: 37653
		ValueTask<bool> MoveNextAsync();

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06009316 RID: 37654
		[Nullable(1)]
		T Current { [NullableContext(1)] get; }
	}
}
