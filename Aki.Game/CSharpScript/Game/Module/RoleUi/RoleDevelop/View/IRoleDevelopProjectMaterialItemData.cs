using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CFC RID: 15612
	[NullableContext(1)]
	public interface IRoleDevelopProjectMaterialItemData
	{
		// Token: 0x170051FC RID: 20988
		// (get) Token: 0x06027F6F RID: 163695
		// (set) Token: 0x06027F70 RID: 163696
		RoleDevelopItemGroup GroupItem { get; set; }

		// Token: 0x170051FD RID: 20989
		// (get) Token: 0x06027F71 RID: 163697
		// (set) Token: 0x06027F72 RID: 163698
		Action<RoleDevelopItemGroup> JumpCallback { get; set; }

		// Token: 0x170051FE RID: 20990
		// (get) Token: 0x06027F73 RID: 163699
		// (set) Token: 0x06027F74 RID: 163700
		int? LogRoleId { get; set; }

		// Token: 0x170051FF RID: 20991
		// (get) Token: 0x06027F75 RID: 163701
		// (set) Token: 0x06027F76 RID: 163702
		ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x17005200 RID: 20992
		// (get) Token: 0x06027F77 RID: 163703
		// (set) Token: 0x06027F78 RID: 163704
		ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}
