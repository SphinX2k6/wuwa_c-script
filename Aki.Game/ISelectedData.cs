using System;

// Token: 0x02000E0C RID: 3596
public interface ISelectedData
{
	// Token: 0x17000FE7 RID: 4071
	// (get) Token: 0x0600912C RID: 37164
	// (set) Token: 0x0600912D RID: 37165
	int ItemId { get; set; }

	// Token: 0x17000FE8 RID: 4072
	// (get) Token: 0x0600912E RID: 37166
	// (set) Token: 0x0600912F RID: 37167
	int IncId { get; set; }

	// Token: 0x17000FE9 RID: 4073
	// (get) Token: 0x06009130 RID: 37168
	// (set) Token: 0x06009131 RID: 37169
	int Count { get; set; }

	// Token: 0x17000FEA RID: 4074
	// (get) Token: 0x06009132 RID: 37170
	// (set) Token: 0x06009133 RID: 37171
	int SelectedCount { get; set; }

	// Token: 0x17000FEB RID: 4075
	// (get) Token: 0x06009134 RID: 37172
	// (set) Token: 0x06009135 RID: 37173
	bool? OnlyTextFlag { get; set; }
}
