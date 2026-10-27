using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D39 RID: 19769
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopOverviewMaterialItemData : IRoleDevelopOverviewMaterialItemData
	{
		// Token: 0x17007E4A RID: 32330
		// (get) Token: 0x06033139 RID: 209209 RVA: 0x00BE6869 File Offset: 0x00BE4A69
		// (set) Token: 0x0603313A RID: 209210 RVA: 0x00BE6871 File Offset: 0x00BE4A71
		public RoleDevelopItemGroup GroupItem { get; set; }

		// Token: 0x17007E4B RID: 32331
		// (get) Token: 0x0603313B RID: 209211 RVA: 0x00BE687A File Offset: 0x00BE4A7A
		// (set) Token: 0x0603313C RID: 209212 RVA: 0x00BE6882 File Offset: 0x00BE4A82
		public Action<RoleDevelopItemGroup> JumpCallback { get; set; }
	}
}
