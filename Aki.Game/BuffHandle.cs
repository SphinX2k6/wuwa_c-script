using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C83 RID: 11395
[NullableContext(1)]
[Nullable(0)]
public class BuffHandle
{
	// Token: 0x0400B163 RID: 45411
	public readonly HashSet<int> EffectHandleSet = new HashSet<int>();

	// Token: 0x0400B164 RID: 45412
	public readonly HashSet<int> MaterialHandleSet = new HashSet<int>();
}
