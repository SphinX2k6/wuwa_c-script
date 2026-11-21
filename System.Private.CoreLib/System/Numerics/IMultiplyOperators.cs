using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B1 RID: 689
	[NullableContext(1)]
	public interface IMultiplyOperators<[Nullable(0)] TSelf, [Nullable(2)] TOther, [Nullable(2)] TResult> where TSelf : IMultiplyOperators<TSelf, TOther, TResult>
	{
		// Token: 0x06003333 RID: 13107
		public abstract static TResult operator *(TSelf left, TOther right);

		// Token: 0x06003334 RID: 13108 RVA: 0x000A3346 File Offset: 0x000A1546
		public virtual static TResult op_CheckedMultiply(TSelf left, TOther right)
		{
			return left * right;
		}
	}
}
