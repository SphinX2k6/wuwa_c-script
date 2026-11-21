using System;

// Token: 0x02001D40 RID: 7488
public class RoleWeaponData : IRoleWeaponData
{
	// Token: 0x17001B95 RID: 7061
	// (get) Token: 0x0601290A RID: 76042 RVA: 0x0057B8BC File Offset: 0x00579ABC
	// (set) Token: 0x0601290B RID: 76043 RVA: 0x0057B8C4 File Offset: 0x00579AC4
	public int WeaponId { get; set; }

	// Token: 0x17001B96 RID: 7062
	// (get) Token: 0x0601290C RID: 76044 RVA: 0x0057B8CD File Offset: 0x00579ACD
	// (set) Token: 0x0601290D RID: 76045 RVA: 0x0057B8D5 File Offset: 0x00579AD5
	public int WeaponLevel { get; set; }

	// Token: 0x17001B97 RID: 7063
	// (get) Token: 0x0601290E RID: 76046 RVA: 0x0057B8DE File Offset: 0x00579ADE
	// (set) Token: 0x0601290F RID: 76047 RVA: 0x0057B8E6 File Offset: 0x00579AE6
	public int WeaponBreachLevel { get; set; }

	// Token: 0x17001B98 RID: 7064
	// (get) Token: 0x06012910 RID: 76048 RVA: 0x0057B8EF File Offset: 0x00579AEF
	// (set) Token: 0x06012911 RID: 76049 RVA: 0x0057B8F7 File Offset: 0x00579AF7
	public int WeaponResonanceLevel { get; set; }
}
