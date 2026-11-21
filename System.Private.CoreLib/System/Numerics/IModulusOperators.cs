using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002AF RID: 687
	[NullableContext(2)]
	public interface IModulusOperators<[Nullable(0)] TSelf, TOther, TResult> where TSelf : IModulusOperators<TSelf, TOther, TResult>
	{
		// Token: 0x06003331 RID: 13105
		[NullableContext(1)]
		public abstract static TResult operator %(TSelf left, TOther right);
	}
}
