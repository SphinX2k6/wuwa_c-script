using System;

// Token: 0x02001426 RID: 5158
public class PinballItemDataWeapon : IPinballItemDataWeapon
{
	// Token: 0x17000C9B RID: 3227
	// (get) Token: 0x0600917F RID: 37247 RVA: 0x001F2EA1 File Offset: 0x001F10A1
	// (set) Token: 0x06009180 RID: 37248 RVA: 0x001F2EA9 File Offset: 0x001F10A9
	public EPinballItemType Type { get; set; }

	// Token: 0x17000C9C RID: 3228
	// (get) Token: 0x06009181 RID: 37249 RVA: 0x001F2EB2 File Offset: 0x001F10B2
	// (set) Token: 0x06009182 RID: 37250 RVA: 0x001F2EBA File Offset: 0x001F10BA
	public int Id { get; set; }

	// Token: 0x17000C9D RID: 3229
	// (get) Token: 0x06009183 RID: 37251 RVA: 0x001F2EC3 File Offset: 0x001F10C3
	// (set) Token: 0x06009184 RID: 37252 RVA: 0x001F2ECB File Offset: 0x001F10CB
	public int IncId { get; set; }

	// Token: 0x17000C9E RID: 3230
	// (get) Token: 0x06009185 RID: 37253 RVA: 0x001F2ED4 File Offset: 0x001F10D4
	// (set) Token: 0x06009186 RID: 37254 RVA: 0x001F2EDC File Offset: 0x001F10DC
	public bool? IsUnavailable { get; set; }

	// Token: 0x17000C9F RID: 3231
	// (get) Token: 0x06009187 RID: 37255 RVA: 0x001F2EE5 File Offset: 0x001F10E5
	// (set) Token: 0x06009188 RID: 37256 RVA: 0x001F2EED File Offset: 0x001F10ED
	public int? RoleId { get; set; }

	// Token: 0x17000CA0 RID: 3232
	// (get) Token: 0x06009189 RID: 37257 RVA: 0x001F2EF6 File Offset: 0x001F10F6
	// (set) Token: 0x0600918A RID: 37258 RVA: 0x001F2EFE File Offset: 0x001F10FE
	public bool? IsLocked { get; set; }

	// Token: 0x17000CA1 RID: 3233
	// (get) Token: 0x0600918B RID: 37259 RVA: 0x001F2F07 File Offset: 0x001F1107
	// (set) Token: 0x0600918C RID: 37260 RVA: 0x001F2F0F File Offset: 0x001F110F
	public bool? NeedReduceBtn { get; set; }

	// Token: 0x17000CA2 RID: 3234
	// (get) Token: 0x0600918D RID: 37261 RVA: 0x001F2F18 File Offset: 0x001F1118
	// (set) Token: 0x0600918E RID: 37262 RVA: 0x001F2F20 File Offset: 0x001F1120
	public bool? IsRecommendedWeapon { get; set; }
}
