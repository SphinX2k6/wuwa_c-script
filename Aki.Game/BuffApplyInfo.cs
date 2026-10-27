using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002E71 RID: 11889
[NullableContext(1)]
[Nullable(0)]
public class BuffApplyInfo
{
	// Token: 0x170022F0 RID: 8944
	// (get) Token: 0x06019683 RID: 104067 RVA: 0x0068CDD3 File Offset: 0x0068AFD3
	// (set) Token: 0x06019684 RID: 104068 RVA: 0x0068CDDB File Offset: 0x0068AFDB
	public long InstigatorId { get; set; }

	// Token: 0x170022F1 RID: 8945
	// (get) Token: 0x06019685 RID: 104069 RVA: 0x0068CDE4 File Offset: 0x0068AFE4
	// (set) Token: 0x06019686 RID: 104070 RVA: 0x0068CDEC File Offset: 0x0068AFEC
	public ApplyGEType ApplyType { get; set; }

	// Token: 0x170022F2 RID: 8946
	// (get) Token: 0x06019687 RID: 104071 RVA: 0x0068CDF5 File Offset: 0x0068AFF5
	// (set) Token: 0x06019688 RID: 104072 RVA: 0x0068CDFD File Offset: 0x0068AFFD
	public string Reason { get; set; } = string.Empty;
}
