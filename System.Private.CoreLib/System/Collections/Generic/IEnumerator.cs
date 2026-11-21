using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009CD RID: 2509
	public interface IEnumerator<[Nullable(2)] out T> : IDisposable, IEnumerator
	{
		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06009330 RID: 37680
		[Nullable(1)]
		T Current { [NullableContext(1)] get; }
	}
}
