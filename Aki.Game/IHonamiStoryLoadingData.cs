using System;

// Token: 0x0200154B RID: 5451
public interface IHonamiStoryLoadingData : ISpecialCustomLoadingData
{
	// Token: 0x1700145D RID: 5213
	// (get) Token: 0x0600DA32 RID: 55858
	// (set) Token: 0x0600DA33 RID: 55859
	int? LoadingId { get; set; }

	// Token: 0x1700145E RID: 5214
	// (get) Token: 0x0600DA34 RID: 55860
	// (set) Token: 0x0600DA35 RID: 55861
	int? BtId { get; set; }

	// Token: 0x1700145F RID: 5215
	// (get) Token: 0x0600DA36 RID: 55862
	// (set) Token: 0x0600DA37 RID: 55863
	int? Timing { get; set; }
}
