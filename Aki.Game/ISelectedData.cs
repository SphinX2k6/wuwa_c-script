using System;

// Token: 0x0200194F RID: 6479
public interface ISelectedData
{
	// Token: 0x17000FC3 RID: 4035
	// (get) Token: 0x0600BD29 RID: 48425
	// (set) Token: 0x0600BD2A RID: 48426
	int ItemId { get; set; }

	// Token: 0x17000FC4 RID: 4036
	// (get) Token: 0x0600BD2B RID: 48427
	// (set) Token: 0x0600BD2C RID: 48428
	int IncId { get; set; }

	// Token: 0x17000FC5 RID: 4037
	// (get) Token: 0x0600BD2D RID: 48429
	// (set) Token: 0x0600BD2E RID: 48430
	int Count { get; set; }

	// Token: 0x17000FC6 RID: 4038
	// (get) Token: 0x0600BD2F RID: 48431
	// (set) Token: 0x0600BD30 RID: 48432
	int SelectedCount { get; set; }

	// Token: 0x17000FC7 RID: 4039
	// (get) Token: 0x0600BD31 RID: 48433
	// (set) Token: 0x0600BD32 RID: 48434
	bool? OnlyTextFlag { get; set; }
}
