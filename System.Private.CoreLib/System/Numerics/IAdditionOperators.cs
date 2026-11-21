using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x0200029D RID: 669
	[NullableContext(1)]
	public interface IAdditionOperators<[Nullable(0)] TSelf, [Nullable(2)] TOther, [Nullable(2)] TResult> where TSelf : IAdditionOperators<TSelf, TOther, TResult>
	{
		// Token: 0x060032BE RID: 12990
		public abstract static TResult operator +(TSelf left, TOther right);

		// Token: 0x060032BF RID: 12991 RVA: 0x000A2BF4 File Offset: 0x000A0DF4
		public virtual static TResult op_CheckedAddition(TSelf left, TOther right)
		{
			return left + right;
		}
	}
}
