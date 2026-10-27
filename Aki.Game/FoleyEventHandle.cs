using System;
using System.Runtime.CompilerServices;

// Token: 0x02000135 RID: 309
[NullableContext(1)]
[Nullable(0)]
internal class FoleyEventHandle
{
	// Token: 0x060012F9 RID: 4857 RVA: 0x0006AFC7 File Offset: 0x000691C7
	public FoleyEventHandle(int id, string eventName)
	{
		this.Id = id;
		this.EventName = eventName;
	}

	// Token: 0x04000DFF RID: 3583
	public int Id;

	// Token: 0x04000E00 RID: 3584
	public string EventName = "";
}
