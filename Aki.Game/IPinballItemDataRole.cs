using System;
using System.Runtime.CompilerServices;

// Token: 0x02001405 RID: 5125
[NullableContext(2)]
public interface IPinballItemDataRole
{
	// Token: 0x17000C43 RID: 3139
	// (get) Token: 0x060090C6 RID: 37062
	// (set) Token: 0x060090C7 RID: 37063
	EPinballItemType Type { get; set; }

	// Token: 0x17000C44 RID: 3140
	// (get) Token: 0x060090C8 RID: 37064
	// (set) Token: 0x060090C9 RID: 37065
	int Id { get; set; }

	// Token: 0x17000C45 RID: 3141
	// (get) Token: 0x060090CA RID: 37066
	// (set) Token: 0x060090CB RID: 37067
	bool? IsRecommend { get; set; }

	// Token: 0x17000C46 RID: 3142
	// (get) Token: 0x060090CC RID: 37068
	// (set) Token: 0x060090CD RID: 37069
	int? BdId { get; set; }

	// Token: 0x17000C47 RID: 3143
	// (get) Token: 0x060090CE RID: 37070
	// (set) Token: 0x060090CF RID: 37071
	bool? IsLocked { get; set; }

	// Token: 0x17000C48 RID: 3144
	// (get) Token: 0x060090D0 RID: 37072
	// (set) Token: 0x060090D1 RID: 37073
	bool? IsUnavailable { get; set; }

	// Token: 0x17000C49 RID: 3145
	// (get) Token: 0x060090D2 RID: 37074
	// (set) Token: 0x060090D3 RID: 37075
	TableTextArgNew BottomText { get; set; }

	// Token: 0x17000C4A RID: 3146
	// (get) Token: 0x060090D4 RID: 37076
	// (set) Token: 0x060090D5 RID: 37077
	string BottomPlainText { get; set; }

	// Token: 0x17000C4B RID: 3147
	// (get) Token: 0x060090D6 RID: 37078
	// (set) Token: 0x060090D7 RID: 37079
	int? ClassId { get; set; }
}
