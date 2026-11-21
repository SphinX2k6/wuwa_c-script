using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002BB RID: 699
	public interface IUnaryPlusOperators<TSelf, [Nullable(2)] TResult> where TSelf : IUnaryPlusOperators<TSelf, TResult>
	{
		// Token: 0x06003385 RID: 13189
		[NullableContext(1)]
		public abstract static TResult operator +(TSelf value);
	}
}
