using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A6 RID: 678
	[NullableContext(2)]
	public interface IEqualityOperators<[Nullable(0)] TSelf, TOther, TResult> where TSelf : IEqualityOperators<TSelf, TOther, TResult>
	{
		// Token: 0x060032E8 RID: 13032
		[return: Nullable(1)]
		public abstract static TResult operator ==(TSelf left, TOther right);

		// Token: 0x060032E9 RID: 13033
		[return: Nullable(1)]
		public abstract static TResult operator !=(TSelf left, TOther right);
	}
}
