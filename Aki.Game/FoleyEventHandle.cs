using System;
using System.Runtime.CompilerServices;

// Token: 0x02000135 RID: 309
[NullableContext(1)]
[Nullable(0)]
internal class FoleyEventHandle
{
	// Token: 0x060012FF RID: 4863 RVA: 0x0006C9D3 File Offset: 0x0006ABD3
	public FoleyEventHandle(int id, string eventName)
	{
		this.Id = id;
		this.EventName = eventName;
	}

	// Token: 0x04000E07 RID: 3591
	public int Id;

	// Token: 0x04000E08 RID: 3592
	public string EventName = "";
}
