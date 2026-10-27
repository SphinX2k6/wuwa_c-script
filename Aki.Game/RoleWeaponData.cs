using System;

// Token: 0x020027C5 RID: 10181
public class RoleWeaponData : IRoleWeaponData
{
	// Token: 0x17001B3D RID: 6973
	// (get) Token: 0x06014F0A RID: 85770 RVA: 0x00550B4A File Offset: 0x0054ED4A
	// (set) Token: 0x06014F0B RID: 85771 RVA: 0x00550B52 File Offset: 0x0054ED52
	public int WeaponId { get; set; }

	// Token: 0x17001B3E RID: 6974
	// (get) Token: 0x06014F0C RID: 85772 RVA: 0x00550B5B File Offset: 0x0054ED5B
	// (set) Token: 0x06014F0D RID: 85773 RVA: 0x00550B63 File Offset: 0x0054ED63
	public int WeaponLevel { get; set; }

	// Token: 0x17001B3F RID: 6975
	// (get) Token: 0x06014F0E RID: 85774 RVA: 0x00550B6C File Offset: 0x0054ED6C
	// (set) Token: 0x06014F0F RID: 85775 RVA: 0x00550B74 File Offset: 0x0054ED74
	public int WeaponBreachLevel { get; set; }

	// Token: 0x17001B40 RID: 6976
	// (get) Token: 0x06014F10 RID: 85776 RVA: 0x00550B7D File Offset: 0x0054ED7D
	// (set) Token: 0x06014F11 RID: 85777 RVA: 0x00550B85 File Offset: 0x0054ED85
	public int WeaponResonanceLevel { get; set; }
}
