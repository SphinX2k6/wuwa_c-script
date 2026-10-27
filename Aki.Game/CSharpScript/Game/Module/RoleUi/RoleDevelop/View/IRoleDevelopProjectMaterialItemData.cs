using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D3D RID: 19773
	[NullableContext(1)]
	public interface IRoleDevelopProjectMaterialItemData
	{
		// Token: 0x17007E4C RID: 32332
		// (get) Token: 0x06033166 RID: 209254
		// (set) Token: 0x06033167 RID: 209255
		RoleDevelopItemGroup GroupItem { get; set; }

		// Token: 0x17007E4D RID: 32333
		// (get) Token: 0x06033168 RID: 209256
		// (set) Token: 0x06033169 RID: 209257
		Action<RoleDevelopItemGroup> JumpCallback { get; set; }

		// Token: 0x17007E4E RID: 32334
		// (get) Token: 0x0603316A RID: 209258
		// (set) Token: 0x0603316B RID: 209259
		int? LogRoleId { get; set; }

		// Token: 0x17007E4F RID: 32335
		// (get) Token: 0x0603316C RID: 209260
		// (set) Token: 0x0603316D RID: 209261
		ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x17007E50 RID: 32336
		// (get) Token: 0x0603316E RID: 209262
		// (set) Token: 0x0603316F RID: 209263
		ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}
