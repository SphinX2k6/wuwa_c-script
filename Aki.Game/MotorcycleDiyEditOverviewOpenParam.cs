using System;
using System.Runtime.CompilerServices;

// Token: 0x02001779 RID: 6009
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleDiyEditOverviewOpenParam : IMotorcycleDiyEditOverviewOpenParam
{
	// Token: 0x17001641 RID: 5697
	// (get) Token: 0x0600E8EB RID: 59627 RVA: 0x00443A26 File Offset: 0x00441C26
	// (set) Token: 0x0600E8EC RID: 59628 RVA: 0x00443A2E File Offset: 0x00441C2E
	public int PartId { get; set; }

	// Token: 0x17001642 RID: 5698
	// (get) Token: 0x0600E8ED RID: 59629 RVA: 0x00443A37 File Offset: 0x00441C37
	// (set) Token: 0x0600E8EE RID: 59630 RVA: 0x00443A3F File Offset: 0x00441C3F
	public MotorcycleDiyPresetData LocalPresetData { get; set; }

	// Token: 0x17001643 RID: 5699
	// (get) Token: 0x0600E8EF RID: 59631 RVA: 0x00443A48 File Offset: 0x00441C48
	// (set) Token: 0x0600E8F0 RID: 59632 RVA: 0x00443A50 File Offset: 0x00441C50
	public Action<EOutlookType, bool> OnEditPresetChanged { get; set; }
}
