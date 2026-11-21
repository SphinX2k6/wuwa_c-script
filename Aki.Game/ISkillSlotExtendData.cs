using System;

// Token: 0x02001D6A RID: 7530
public interface ISkillSlotExtendData
{
	// Token: 0x17001BE9 RID: 7145
	// (get) Token: 0x060129C7 RID: 76231
	// (set) Token: 0x060129C8 RID: 76232
	int RoleId { get; set; }

	// Token: 0x17001BEA RID: 7146
	// (get) Token: 0x060129C9 RID: 76233
	// (set) Token: 0x060129CA RID: 76234
	int SkillNodeId { get; set; }

	// Token: 0x17001BEB RID: 7147
	// (get) Token: 0x060129CB RID: 76235
	// (set) Token: 0x060129CC RID: 76236
	int IconId { get; set; }

	// Token: 0x17001BEC RID: 7148
	// (get) Token: 0x060129CD RID: 76237
	// (set) Token: 0x060129CE RID: 76238
	int CurrentLevel { get; set; }

	// Token: 0x17001BED RID: 7149
	// (get) Token: 0x060129CF RID: 76239
	// (set) Token: 0x060129D0 RID: 76240
	int NormalTargetLevel { get; set; }

	// Token: 0x17001BEE RID: 7150
	// (get) Token: 0x060129D1 RID: 76241
	// (set) Token: 0x060129D2 RID: 76242
	int PerfectTargetLevel { get; set; }

	// Token: 0x17001BEF RID: 7151
	// (get) Token: 0x060129D3 RID: 76243
	// (set) Token: 0x060129D4 RID: 76244
	ESkillType SkillType { get; set; }

	// Token: 0x17001BF0 RID: 7152
	// (get) Token: 0x060129D5 RID: 76245
	// (set) Token: 0x060129D6 RID: 76246
	int NodeIndex { get; set; }
}
