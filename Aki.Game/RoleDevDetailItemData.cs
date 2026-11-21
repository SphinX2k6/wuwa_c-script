using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001D5F RID: 7519
[NullableContext(1)]
[Nullable(0)]
public class RoleDevDetailItemData : global::IRoleDevDetailItemData
{
	// Token: 0x17001BC8 RID: 7112
	// (get) Token: 0x0601297F RID: 76159 RVA: 0x0057BF02 File Offset: 0x0057A102
	// (set) Token: 0x06012980 RID: 76160 RVA: 0x0057BF0A File Offset: 0x0057A10A
	public int RoleId { get; set; }

	// Token: 0x17001BC9 RID: 7113
	// (get) Token: 0x06012981 RID: 76161 RVA: 0x0057BF13 File Offset: 0x0057A113
	// (set) Token: 0x06012982 RID: 76162 RVA: 0x0057BF1B File Offset: 0x0057A11B
	public ERoleDevMainPage MainPage { get; set; }

	// Token: 0x17001BCA RID: 7114
	// (get) Token: 0x06012983 RID: 76163 RVA: 0x0057BF24 File Offset: 0x0057A124
	// (set) Token: 0x06012984 RID: 76164 RVA: 0x0057BF2C File Offset: 0x0057A12C
	public ERoleDevSubPageButton ButtonType { get; set; }

	// Token: 0x17001BCB RID: 7115
	// (get) Token: 0x06012985 RID: 76165 RVA: 0x0057BF35 File Offset: 0x0057A135
	// (set) Token: 0x06012986 RID: 76166 RVA: 0x0057BF3D File Offset: 0x0057A13D
	public string Title { get; set; }

	// Token: 0x17001BCC RID: 7116
	// (get) Token: 0x06012987 RID: 76167 RVA: 0x0057BF46 File Offset: 0x0057A146
	// (set) Token: 0x06012988 RID: 76168 RVA: 0x0057BF4E File Offset: 0x0057A14E
	public int ItemGroupId { get; set; }

	// Token: 0x17001BCD RID: 7117
	// (get) Token: 0x06012989 RID: 76169 RVA: 0x0057BF57 File Offset: 0x0057A157
	// (set) Token: 0x0601298A RID: 76170 RVA: 0x0057BF5F File Offset: 0x0057A15F
	public List<global::IItemMaterial> ItemGroup { get; set; }
}
