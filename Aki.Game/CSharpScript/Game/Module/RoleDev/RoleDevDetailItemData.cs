using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CBF RID: 19647
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevDetailItemData : IRoleDevDetailItemData
	{
		// Token: 0x17007D2B RID: 32043
		// (get) Token: 0x06032B9B RID: 207771 RVA: 0x00BD5145 File Offset: 0x00BD3345
		// (set) Token: 0x06032B9C RID: 207772 RVA: 0x00BD514D File Offset: 0x00BD334D
		public int RoleId { get; set; }

		// Token: 0x17007D2C RID: 32044
		// (get) Token: 0x06032B9D RID: 207773 RVA: 0x00BD5156 File Offset: 0x00BD3356
		// (set) Token: 0x06032B9E RID: 207774 RVA: 0x00BD515E File Offset: 0x00BD335E
		public ERoleDevMainPage MainPage { get; set; }

		// Token: 0x17007D2D RID: 32045
		// (get) Token: 0x06032B9F RID: 207775 RVA: 0x00BD5167 File Offset: 0x00BD3367
		// (set) Token: 0x06032BA0 RID: 207776 RVA: 0x00BD516F File Offset: 0x00BD336F
		public ERoleDevSubPageButton ButtonType { get; set; }

		// Token: 0x17007D2E RID: 32046
		// (get) Token: 0x06032BA1 RID: 207777 RVA: 0x00BD5178 File Offset: 0x00BD3378
		// (set) Token: 0x06032BA2 RID: 207778 RVA: 0x00BD5180 File Offset: 0x00BD3380
		public string Title { get; set; }

		// Token: 0x17007D2F RID: 32047
		// (get) Token: 0x06032BA3 RID: 207779 RVA: 0x00BD5189 File Offset: 0x00BD3389
		// (set) Token: 0x06032BA4 RID: 207780 RVA: 0x00BD5191 File Offset: 0x00BD3391
		public int ItemGroupId { get; set; }

		// Token: 0x17007D30 RID: 32048
		// (get) Token: 0x06032BA5 RID: 207781 RVA: 0x00BD519A File Offset: 0x00BD339A
		// (set) Token: 0x06032BA6 RID: 207782 RVA: 0x00BD51A2 File Offset: 0x00BD33A2
		public List<IItemMaterial> ItemGroup { get; set; }
	}
}
