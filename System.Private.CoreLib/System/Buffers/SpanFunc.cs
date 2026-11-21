using System;

namespace System.Buffers
{
	// Token: 0x0200033D RID: 829
	// (Invoke) Token: 0x06003A8D RID: 14989
	internal delegate TResult SpanFunc<TSpan, in T1, in T2, in T3, out TResult>(Span<TSpan> span, T1 arg1, T2 arg2, T3 arg3);
}
