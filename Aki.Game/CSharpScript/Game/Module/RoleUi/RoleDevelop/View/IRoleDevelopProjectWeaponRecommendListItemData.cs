using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D4C RID: 19788
	public interface IRoleDevelopProjectWeaponRecommendListItemData
	{
		// Token: 0x17007E56 RID: 32342
		// (get) Token: 0x06033204 RID: 209412
		// (set) Token: 0x06033205 RID: 209413
		int DevelopRoleId { get; set; }

		// Token: 0x17007E57 RID: 32343
		// (get) Token: 0x06033206 RID: 209414
		// (set) Token: 0x06033207 RID: 209415
		int RecommendWeaponId { get; set; }

		// Token: 0x17007E58 RID: 32344
		// (get) Token: 0x06033208 RID: 209416
		// (set) Token: 0x06033209 RID: 209417
		int? LogRoleId { get; set; }

		// Token: 0x17007E59 RID: 32345
		// (get) Token: 0x0603320A RID: 209418
		// (set) Token: 0x0603320B RID: 209419
		ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x17007E5A RID: 32346
		// (get) Token: 0x0603320C RID: 209420
		// (set) Token: 0x0603320D RID: 209421
		ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}
