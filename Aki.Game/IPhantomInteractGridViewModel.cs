using System;

// Token: 0x02002465 RID: 9317
public interface IPhantomInteractGridViewModel : IPhantomInteractGridData
{
	// Token: 0x1700185C RID: 6236
	// (get) Token: 0x06012B1B RID: 76571
	// (set) Token: 0x06012B1C RID: 76572
	bool IsSelected { get; set; }

	// Token: 0x1700185D RID: 6237
	// (get) Token: 0x06012B1D RID: 76573
	// (set) Token: 0x06012B1E RID: 76574
	bool IsInArea { get; set; }
}
