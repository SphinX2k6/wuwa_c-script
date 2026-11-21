using System;

// Token: 0x02001D3F RID: 7487
public interface IRoleWeaponData
{
	// Token: 0x17001B91 RID: 7057
	// (get) Token: 0x06012902 RID: 76034
	// (set) Token: 0x06012903 RID: 76035
	int WeaponId { get; set; }

	// Token: 0x17001B92 RID: 7058
	// (get) Token: 0x06012904 RID: 76036
	// (set) Token: 0x06012905 RID: 76037
	int WeaponLevel { get; set; }

	// Token: 0x17001B93 RID: 7059
	// (get) Token: 0x06012906 RID: 76038
	// (set) Token: 0x06012907 RID: 76039
	int WeaponBreachLevel { get; set; }

	// Token: 0x17001B94 RID: 7060
	// (get) Token: 0x06012908 RID: 76040
	// (set) Token: 0x06012909 RID: 76041
	int WeaponResonanceLevel { get; set; }
}
