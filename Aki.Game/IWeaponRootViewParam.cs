using System;

// Token: 0x02002D12 RID: 11538
public interface IWeaponRootViewParam
{
	// Token: 0x170020B9 RID: 8377
	// (get) Token: 0x060183F6 RID: 99318
	// (set) Token: 0x060183F7 RID: 99319
	int WeaponIncId { get; set; }

	// Token: 0x170020BA RID: 8378
	// (get) Token: 0x060183F8 RID: 99320
	// (set) Token: 0x060183F9 RID: 99321
	int WeaponSkinId { get; set; }

	// Token: 0x170020BB RID: 8379
	// (get) Token: 0x060183FA RID: 99322
	// (set) Token: 0x060183FB RID: 99323
	bool IsFromRoleRootView { get; set; }
}
