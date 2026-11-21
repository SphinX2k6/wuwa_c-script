using System;
using System.Runtime.CompilerServices;

// Token: 0x020016D2 RID: 5842
[NullableContext(1)]
[Nullable(0)]
public struct PropertyEntry<[Nullable(2)] TV>
{
	// Token: 0x0600E303 RID: 58115 RVA: 0x0042973B File Offset: 0x0042793B
	public PropertyEntry(TV Value, bool IsDirty)
	{
		this.Value = Value;
		this.IsDirty = IsDirty;
	}

	// Token: 0x040081B6 RID: 33206
	public TV Value;

	// Token: 0x040081B7 RID: 33207
	public bool IsDirty;
}
