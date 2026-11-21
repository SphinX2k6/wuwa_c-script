using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A4 RID: 676
	[NullableContext(1)]
	public interface IDecrementOperators<[Nullable(0)] TSelf> where TSelf : IDecrementOperators<TSelf>
	{
		// Token: 0x060032E4 RID: 13028
		public abstract static TSelf operator --(TSelf value);

		// Token: 0x060032E5 RID: 13029 RVA: 0x000A2FB2 File Offset: 0x000A11B2
		public virtual static TSelf op_CheckedDecrement(TSelf value)
		{
			return value = --value;
		}
	}
}
