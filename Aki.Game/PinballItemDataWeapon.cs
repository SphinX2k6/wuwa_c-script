using System;

// Token: 0x020008DA RID: 2266
public class PinballItemDataWeapon : IPinballItemDataWeapon
{
	// Token: 0x17000CBB RID: 3259
	// (get) Token: 0x06006514 RID: 25876 RVA: 0x001FB9DD File Offset: 0x001F9BDD
	// (set) Token: 0x06006515 RID: 25877 RVA: 0x001FB9E5 File Offset: 0x001F9BE5
	public EPinballItemType Type { get; set; }

	// Token: 0x17000CBC RID: 3260
	// (get) Token: 0x06006516 RID: 25878 RVA: 0x001FB9EE File Offset: 0x001F9BEE
	// (set) Token: 0x06006517 RID: 25879 RVA: 0x001FB9F6 File Offset: 0x001F9BF6
	public int Id { get; set; }

	// Token: 0x17000CBD RID: 3261
	// (get) Token: 0x06006518 RID: 25880 RVA: 0x001FB9FF File Offset: 0x001F9BFF
	// (set) Token: 0x06006519 RID: 25881 RVA: 0x001FBA07 File Offset: 0x001F9C07
	public int IncId { get; set; }

	// Token: 0x17000CBE RID: 3262
	// (get) Token: 0x0600651A RID: 25882 RVA: 0x001FBA10 File Offset: 0x001F9C10
	// (set) Token: 0x0600651B RID: 25883 RVA: 0x001FBA18 File Offset: 0x001F9C18
	public bool? IsUnavailable { get; set; }

	// Token: 0x17000CBF RID: 3263
	// (get) Token: 0x0600651C RID: 25884 RVA: 0x001FBA21 File Offset: 0x001F9C21
	// (set) Token: 0x0600651D RID: 25885 RVA: 0x001FBA29 File Offset: 0x001F9C29
	public int? RoleId { get; set; }

	// Token: 0x17000CC0 RID: 3264
	// (get) Token: 0x0600651E RID: 25886 RVA: 0x001FBA32 File Offset: 0x001F9C32
	// (set) Token: 0x0600651F RID: 25887 RVA: 0x001FBA3A File Offset: 0x001F9C3A
	public bool? IsLocked { get; set; }

	// Token: 0x17000CC1 RID: 3265
	// (get) Token: 0x06006520 RID: 25888 RVA: 0x001FBA43 File Offset: 0x001F9C43
	// (set) Token: 0x06006521 RID: 25889 RVA: 0x001FBA4B File Offset: 0x001F9C4B
	public bool? NeedReduceBtn { get; set; }

	// Token: 0x17000CC2 RID: 3266
	// (get) Token: 0x06006522 RID: 25890 RVA: 0x001FBA54 File Offset: 0x001F9C54
	// (set) Token: 0x06006523 RID: 25891 RVA: 0x001FBA5C File Offset: 0x001F9C5C
	public bool? IsRecommendedWeapon { get; set; }
}
