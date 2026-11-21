using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CF7 RID: 15607
	[NullableContext(1)]
	public interface IRoleDevelopOverviewMaterialItemData
	{
		// Token: 0x170051F8 RID: 20984
		// (get) Token: 0x06027F30 RID: 163632
		// (set) Token: 0x06027F31 RID: 163633
		RoleDevelopItemGroup GroupItem { get; set; }

		// Token: 0x170051F9 RID: 20985
		// (get) Token: 0x06027F32 RID: 163634
		// (set) Token: 0x06027F33 RID: 163635
		Action<RoleDevelopItemGroup> JumpCallback { get; set; }
	}
}
