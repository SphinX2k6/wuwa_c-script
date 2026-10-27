using System;
using System.Runtime.CompilerServices;

// Token: 0x020021EE RID: 8686
[NullableContext(1)]
[Nullable(0)]
public struct PropertyEntry<[Nullable(2)] TV>
{
	// Token: 0x06010E70 RID: 69232 RVA: 0x0041CDAB File Offset: 0x0041AFAB
	public PropertyEntry(TV Value, bool IsDirty)
	{
		this.Value = Value;
		this.IsDirty = IsDirty;
	}

	// Token: 0x04008078 RID: 32888
	public TV Value;

	// Token: 0x04008079 RID: 32889
	public bool IsDirty;
}
