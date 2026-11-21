using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A5 RID: 677
	[NullableContext(1)]
	public interface IDivisionOperators<[Nullable(0)] TSelf, [Nullable(2)] TOther, [Nullable(2)] TResult> where TSelf : IDivisionOperators<TSelf, TOther, TResult>
	{
		// Token: 0x060032E6 RID: 13030
		public abstract static TResult operator /(TSelf left, TOther right);

		// Token: 0x060032E7 RID: 13031 RVA: 0x000A2FC3 File Offset: 0x000A11C3
		public virtual static TResult op_CheckedDivision(TSelf left, TOther right)
		{
			return left / right;
		}
	}
}
