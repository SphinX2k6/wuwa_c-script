using System;
using System.Runtime.CompilerServices;

// Token: 0x02001778 RID: 6008
[NullableContext(2)]
public interface IMotorcycleDiyEditOverviewOpenParam
{
	// Token: 0x1700163E RID: 5694
	// (get) Token: 0x0600E8E5 RID: 59621
	// (set) Token: 0x0600E8E6 RID: 59622
	int PartId { get; set; }

	// Token: 0x1700163F RID: 5695
	// (get) Token: 0x0600E8E7 RID: 59623
	// (set) Token: 0x0600E8E8 RID: 59624
	MotorcycleDiyPresetData LocalPresetData { get; set; }

	// Token: 0x17001640 RID: 5696
	// (get) Token: 0x0600E8E9 RID: 59625
	// (set) Token: 0x0600E8EA RID: 59626
	Action<EOutlookType, bool> OnEditPresetChanged { get; set; }
}
