using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C70 RID: 15472
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevDetailItemData : IRoleDevDetailItemData
	{
		// Token: 0x170050D5 RID: 20693
		// (get) Token: 0x0602794F RID: 162127 RVA: 0x00B19EDD File Offset: 0x00B180DD
		// (set) Token: 0x06027950 RID: 162128 RVA: 0x00B19EE5 File Offset: 0x00B180E5
		public int RoleId { get; set; }

		// Token: 0x170050D6 RID: 20694
		// (get) Token: 0x06027951 RID: 162129 RVA: 0x00B19EEE File Offset: 0x00B180EE
		// (set) Token: 0x06027952 RID: 162130 RVA: 0x00B19EF6 File Offset: 0x00B180F6
		public ERoleDevMainPage MainPage { get; set; }

		// Token: 0x170050D7 RID: 20695
		// (get) Token: 0x06027953 RID: 162131 RVA: 0x00B19EFF File Offset: 0x00B180FF
		// (set) Token: 0x06027954 RID: 162132 RVA: 0x00B19F07 File Offset: 0x00B18107
		public ERoleDevSubPageButton ButtonType { get; set; }

		// Token: 0x170050D8 RID: 20696
		// (get) Token: 0x06027955 RID: 162133 RVA: 0x00B19F10 File Offset: 0x00B18110
		// (set) Token: 0x06027956 RID: 162134 RVA: 0x00B19F18 File Offset: 0x00B18118
		public string Title { get; set; }

		// Token: 0x170050D9 RID: 20697
		// (get) Token: 0x06027957 RID: 162135 RVA: 0x00B19F21 File Offset: 0x00B18121
		// (set) Token: 0x06027958 RID: 162136 RVA: 0x00B19F29 File Offset: 0x00B18129
		public int ItemGroupId { get; set; }

		// Token: 0x170050DA RID: 20698
		// (get) Token: 0x06027959 RID: 162137 RVA: 0x00B19F32 File Offset: 0x00B18132
		// (set) Token: 0x0602795A RID: 162138 RVA: 0x00B19F3A File Offset: 0x00B1813A
		public List<IItemMaterial> ItemGroup { get; set; }
	}
}
