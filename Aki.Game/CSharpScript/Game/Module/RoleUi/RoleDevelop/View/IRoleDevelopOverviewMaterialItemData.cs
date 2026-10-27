using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D38 RID: 19768
	[NullableContext(1)]
	public interface IRoleDevelopOverviewMaterialItemData
	{
		// Token: 0x17007E48 RID: 32328
		// (get) Token: 0x06033135 RID: 209205
		// (set) Token: 0x06033136 RID: 209206
		RoleDevelopItemGroup GroupItem { get; set; }

		// Token: 0x17007E49 RID: 32329
		// (get) Token: 0x06033137 RID: 209207
		// (set) Token: 0x06033138 RID: 209208
		Action<RoleDevelopItemGroup> JumpCallback { get; set; }
	}
}
