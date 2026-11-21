using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D15 RID: 15637
	public interface IRoleDevelopProjectWeaponRecommendListItemData
	{
		// Token: 0x17005206 RID: 20998
		// (get) Token: 0x06028067 RID: 163943
		// (set) Token: 0x06028068 RID: 163944
		int DevelopRoleId { get; set; }

		// Token: 0x17005207 RID: 20999
		// (get) Token: 0x06028069 RID: 163945
		// (set) Token: 0x0602806A RID: 163946
		int RecommendWeaponId { get; set; }

		// Token: 0x17005208 RID: 21000
		// (get) Token: 0x0602806B RID: 163947
		// (set) Token: 0x0602806C RID: 163948
		int? LogRoleId { get; set; }

		// Token: 0x17005209 RID: 21001
		// (get) Token: 0x0602806D RID: 163949
		// (set) Token: 0x0602806E RID: 163950
		ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x1700520A RID: 21002
		// (get) Token: 0x0602806F RID: 163951
		// (set) Token: 0x06028070 RID: 163952
		ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}
