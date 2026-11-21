using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002BA RID: 698
	[NullableContext(1)]
	public interface IUnaryNegationOperators<[Nullable(0)] TSelf, [Nullable(2)] TResult> where TSelf : IUnaryNegationOperators<TSelf, TResult>
	{
		// Token: 0x06003383 RID: 13187
		public abstract static TResult operator -(TSelf value);

		// Token: 0x06003384 RID: 13188 RVA: 0x000A3A3B File Offset: 0x000A1C3B
		public virtual static TResult op_CheckedUnaryNegation(TSelf value)
		{
			return -value;
		}
	}
}
