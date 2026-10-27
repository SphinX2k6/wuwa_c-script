using System;
using System.Runtime.CompilerServices;

// Token: 0x02002295 RID: 8853
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyEditOverviewOpenParam : IMotorcycleDiyEditOverviewOpenParam
{
	// Token: 0x1700160A RID: 5642
	// (get) Token: 0x06011455 RID: 70741 RVA: 0x00436E1A File Offset: 0x0043501A
	// (set) Token: 0x06011456 RID: 70742 RVA: 0x00436E22 File Offset: 0x00435022
	public int PartId { get; set; }

	// Token: 0x1700160B RID: 5643
	// (get) Token: 0x06011457 RID: 70743 RVA: 0x00436E2B File Offset: 0x0043502B
	// (set) Token: 0x06011458 RID: 70744 RVA: 0x00436E33 File Offset: 0x00435033
	public MotorcycleDiyPresetData LocalPresetData { get; set; }

	// Token: 0x1700160C RID: 5644
	// (get) Token: 0x06011459 RID: 70745 RVA: 0x00436E3C File Offset: 0x0043503C
	// (set) Token: 0x0601145A RID: 70746 RVA: 0x00436E44 File Offset: 0x00435044
	public Action<EOutlookType, bool> OnEditPresetChanged { get; set; }
}
