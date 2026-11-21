using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CFD RID: 15613
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectMaterialItemData : IRoleDevelopProjectMaterialItemData
	{
		// Token: 0x17005201 RID: 20993
		// (get) Token: 0x06027F79 RID: 163705 RVA: 0x00B2E44D File Offset: 0x00B2C64D
		// (set) Token: 0x06027F7A RID: 163706 RVA: 0x00B2E455 File Offset: 0x00B2C655
		public RoleDevelopItemGroup GroupItem { get; set; }

		// Token: 0x17005202 RID: 20994
		// (get) Token: 0x06027F7B RID: 163707 RVA: 0x00B2E45E File Offset: 0x00B2C65E
		// (set) Token: 0x06027F7C RID: 163708 RVA: 0x00B2E466 File Offset: 0x00B2C666
		public Action<RoleDevelopItemGroup> JumpCallback { get; set; }

		// Token: 0x17005203 RID: 20995
		// (get) Token: 0x06027F7D RID: 163709 RVA: 0x00B2E46F File Offset: 0x00B2C66F
		// (set) Token: 0x06027F7E RID: 163710 RVA: 0x00B2E477 File Offset: 0x00B2C677
		public int? LogRoleId { get; set; }

		// Token: 0x17005204 RID: 20996
		// (get) Token: 0x06027F7F RID: 163711 RVA: 0x00B2E480 File Offset: 0x00B2C680
		// (set) Token: 0x06027F80 RID: 163712 RVA: 0x00B2E488 File Offset: 0x00B2C688
		public ERoleDevelopCategoryType? LogMainPage { get; set; }

		// Token: 0x17005205 RID: 20997
		// (get) Token: 0x06027F81 RID: 163713 RVA: 0x00B2E491 File Offset: 0x00B2C691
		// (set) Token: 0x06027F82 RID: 163714 RVA: 0x00B2E499 File Offset: 0x00B2C699
		public ERoleDevelopLogSubPage? LogSubPage { get; set; }
	}
}
