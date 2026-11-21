using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A3 RID: 675
	[NullableContext(1)]
	public interface IComparisonOperators<[Nullable(0)] TSelf, [Nullable(2)] TOther, [Nullable(2)] TResult> : IEqualityOperators<TSelf, TOther, TResult> where TSelf : IComparisonOperators<TSelf, TOther, TResult>
	{
		// Token: 0x060032E0 RID: 13024
		public abstract static TResult operator <(TSelf left, TOther right);

		// Token: 0x060032E1 RID: 13025
		public abstract static TResult operator <=(TSelf left, TOther right);

		// Token: 0x060032E2 RID: 13026
		public abstract static TResult operator >(TSelf left, TOther right);

		// Token: 0x060032E3 RID: 13027
		public abstract static TResult operator >=(TSelf left, TOther right);
	}
}
