using System;

// Token: 0x0200226C RID: 8812
public interface IWeaponRootViewParam
{
	// Token: 0x17002114 RID: 8468
	// (get) Token: 0x06015C97 RID: 89239
	// (set) Token: 0x06015C98 RID: 89240
	int WeaponIncId { get; set; }

	// Token: 0x17002115 RID: 8469
	// (get) Token: 0x06015C99 RID: 89241
	// (set) Token: 0x06015C9A RID: 89242
	int WeaponSkinId { get; set; }

	// Token: 0x17002116 RID: 8470
	// (get) Token: 0x06015C9B RID: 89243
	// (set) Token: 0x06015C9C RID: 89244
	bool IsFromRoleRootView { get; set; }
}
