using System;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x0200033B RID: 827
	// (Invoke) Token: 0x06003A85 RID: 14981
	public delegate void SpanAction<[Nullable(2)] T, [Nullable(2)] in TArg>([Nullable(new byte[]
	{
		0,
		1
	})] Span<T> span, TArg arg);
}
