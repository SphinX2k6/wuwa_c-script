using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B0 RID: 688
	[NullableContext(1)]
	public interface IMultiplicativeIdentity<[Nullable(0)] TSelf, [Nullable(2)] TResult> where TSelf : IMultiplicativeIdentity<TSelf, TResult>
	{
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06003332 RID: 13106
		TResult MultiplicativeIdentity { get; }
	}
}
