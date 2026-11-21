using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B8 RID: 696
	[NullableContext(1)]
	public interface ISubtractionOperators<[Nullable(0)] TSelf, [Nullable(2)] TOther, [Nullable(2)] TResult> where TSelf : ISubtractionOperators<TSelf, TOther, TResult>
	{
		// Token: 0x06003371 RID: 13169
		public abstract static TResult operator -(TSelf left, TOther right);

		// Token: 0x06003372 RID: 13170 RVA: 0x000A39C4 File Offset: 0x000A1BC4
		public virtual static TResult op_CheckedSubtraction(TSelf left, TOther right)
		{
			return left - right;
		}
	}
}
