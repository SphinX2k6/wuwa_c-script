using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B6 RID: 694
	[NullableContext(1)]
	public interface IShiftOperators<[Nullable(0)] TSelf, [Nullable(2)] TOther, [Nullable(2)] TResult> where TSelf : IShiftOperators<TSelf, TOther, TResult>
	{
		// Token: 0x0600336D RID: 13165
		public abstract static TResult operator <<(TSelf value, TOther shiftAmount);

		// Token: 0x0600336E RID: 13166
		public abstract static TResult operator >>(TSelf value, TOther shiftAmount);

		// Token: 0x0600336F RID: 13167
		public abstract static TResult op_UnsignedRightShift(TSelf value, TOther shiftAmount);
	}
}
