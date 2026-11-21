using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002AC RID: 684
	[NullableContext(1)]
	public interface IIncrementOperators<[Nullable(0)] TSelf> where TSelf : IIncrementOperators<TSelf>
	{
		// Token: 0x06003326 RID: 13094
		public abstract static TSelf operator ++(TSelf value);

		// Token: 0x06003327 RID: 13095 RVA: 0x000A32C9 File Offset: 0x000A14C9
		public virtual static TSelf op_CheckedIncrement(TSelf value)
		{
			return value = ++value;
		}
	}
}
