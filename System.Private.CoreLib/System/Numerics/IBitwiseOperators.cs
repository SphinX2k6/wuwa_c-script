using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A2 RID: 674
	[NullableContext(1)]
	public interface IBitwiseOperators<[Nullable(0)] TSelf, [Nullable(2)] TOther, [Nullable(2)] TResult> where TSelf : IBitwiseOperators<TSelf, TOther, TResult>
	{
		// Token: 0x060032DC RID: 13020
		public abstract static TResult operator &(TSelf left, TOther right);

		// Token: 0x060032DD RID: 13021
		public abstract static TResult operator |(TSelf left, TOther right);

		// Token: 0x060032DE RID: 13022
		public abstract static TResult operator ^(TSelf left, TOther right);

		// Token: 0x060032DF RID: 13023
		public abstract static TResult operator ~(TSelf value);
	}
}
