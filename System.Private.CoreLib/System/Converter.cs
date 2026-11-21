using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000C1 RID: 193
	// (Invoke) Token: 0x06000924 RID: 2340
	public delegate TOutput Converter<[Nullable(2)] in TInput, [Nullable(2)] out TOutput>(TInput input);
}
