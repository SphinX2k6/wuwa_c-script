using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D3E RID: 19774
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectMaterialItemData : IRoleDevelopProjectMaterialItemData
	{
		// Token: 0x17007E51 RID: 32337
		// (get) Token: 0x06033170 RID: 209264 RVA: 0x00BE79A9 File Offset: 0x00BE5BA9
		// (set) Token: 0x06033171 RID: 209265 RVA: 0x00BE79B1 File Offset: 0x00BE5BB1
		public RoleDevelopItemGroup GroupItem { get; set; }

		// Token: 0x17007E52 RID: 32338
		// (get) Token: 0x06033172 RID: 209266 RVA: 0x00BE79BA File Offset: 0x00BE5BBA
		// (set) Token: 0x06033173 RID: 209267 RVA: 0x00BE79C2 File Offset: 0x00BE5BC2
		public Action<RoleDevelopItemGroup> JumpCallback { get; set; }

		// Token: 0x17007E53 RID: 32339
		// (get) Token: 0x06033174 RID: 209268 RVA: 0x00BE79CB File Offset: 0x00BE5BCB
		// (set) Token: 0x06033175 RID: 209269 RVA: 0x00BE79D3 File Offset: 0x00BE5BD3
		public int? LogRoleId { get; set; }

		// Token: 0x17007E54 RID: 32340
		// (get) Token: 0x06033176 RID: 209270 RVA: 0x00BE79DC File Offset: 0x00BE5BDC
		// (set) Token: 0x06033177 RID: 209271 RVA: 0x00BE79E4 File Offset: 0x00BE5BE4
		public ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x17007E55 RID: 32341
		// (get) Token: 0x06033178 RID: 209272 RVA: 0x00BE79ED File Offset: 0x00BE5BED
		// (set) Token: 0x06033179 RID: 209273 RVA: 0x00BE79F5 File Offset: 0x00BE5BF5
		public ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}
