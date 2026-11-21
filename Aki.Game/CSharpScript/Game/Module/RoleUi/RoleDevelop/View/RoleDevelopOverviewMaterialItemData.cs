using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CF8 RID: 15608
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopOverviewMaterialItemData : IRoleDevelopOverviewMaterialItemData
	{
		// Token: 0x170051FA RID: 20986
		// (get) Token: 0x06027F34 RID: 163636 RVA: 0x00B2CAA5 File Offset: 0x00B2ACA5
		// (set) Token: 0x06027F35 RID: 163637 RVA: 0x00B2CAAD File Offset: 0x00B2ACAD
		public RoleDevelopItemGroup GroupItem { get; set; }

		// Token: 0x170051FB RID: 20987
		// (get) Token: 0x06027F36 RID: 163638 RVA: 0x00B2CAB6 File Offset: 0x00B2ACB6
		// (set) Token: 0x06027F37 RID: 163639 RVA: 0x00B2CABE File Offset: 0x00B2ACBE
		public Action<RoleDevelopItemGroup> JumpCallback { get; set; }
	}
}
