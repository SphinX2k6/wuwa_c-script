using System;
using System.Runtime.CompilerServices;

// Token: 0x02002294 RID: 8852
[NullableContext(2)]
public interface IMotorcycleDiyEditOverviewOpenParam
{
	// Token: 0x17001607 RID: 5639
	// (get) Token: 0x0601144F RID: 70735
	// (set) Token: 0x06011450 RID: 70736
	int PartId { get; set; }

	// Token: 0x17001608 RID: 5640
	// (get) Token: 0x06011451 RID: 70737
	// (set) Token: 0x06011452 RID: 70738
	MotorcycleDiyPresetData LocalPresetData { get; set; }

	// Token: 0x17001609 RID: 5641
	// (get) Token: 0x06011453 RID: 70739
	// (set) Token: 0x06011454 RID: 70740
	Action<EOutlookType, bool> OnEditPresetChanged { get; set; }
}
