using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x0200029E RID: 670
	[NullableContext(1)]
	public interface IAdditiveIdentity<[Nullable(0)] TSelf, [Nullable(2)] TResult> where TSelf : IAdditiveIdentity<TSelf, TResult>
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060032C0 RID: 12992
		TResult AdditiveIdentity { get; }
	}
}
