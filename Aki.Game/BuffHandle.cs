using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021DC RID: 8668
[NullableContext(1)]
[Nullable(0)]
public class BuffHandle
{
	// Token: 0x0400B4CE RID: 46286
	public readonly HashSet<int> EffectHandleSet = new HashSet<int>();

	// Token: 0x0400B4CF RID: 46287
	public readonly HashSet<int> MaterialHandleSet = new HashSet<int>();
}
