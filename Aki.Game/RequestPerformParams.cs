using System;
using System.Runtime.CompilerServices;

// Token: 0x02003075 RID: 12405
[NullableContext(1)]
[Nullable(0)]
public class RequestPerformParams : IRequestPerformParams
{
	// Token: 0x1700246C RID: 9324
	// (get) Token: 0x0601A769 RID: 108393 RVA: 0x007116B5 File Offset: 0x0070F8B5
	// (set) Token: 0x0601A76A RID: 108394 RVA: 0x007116BD File Offset: 0x0070F8BD
	public int Signal { get; set; }

	// Token: 0x1700246D RID: 9325
	// (get) Token: 0x0601A76B RID: 108395 RVA: 0x007116C6 File Offset: 0x0070F8C6
	// (set) Token: 0x0601A76C RID: 108396 RVA: 0x007116CE File Offset: 0x0070F8CE
	public Entity Source { get; set; }
}
