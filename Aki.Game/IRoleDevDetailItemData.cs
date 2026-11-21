using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001D5E RID: 7518
[NullableContext(1)]
public interface IRoleDevDetailItemData
{
	// Token: 0x17001BC2 RID: 7106
	// (get) Token: 0x06012973 RID: 76147
	// (set) Token: 0x06012974 RID: 76148
	int RoleId { get; set; }

	// Token: 0x17001BC3 RID: 7107
	// (get) Token: 0x06012975 RID: 76149
	// (set) Token: 0x06012976 RID: 76150
	ERoleDevMainPage MainPage { get; set; }

	// Token: 0x17001BC4 RID: 7108
	// (get) Token: 0x06012977 RID: 76151
	// (set) Token: 0x06012978 RID: 76152
	ERoleDevSubPageButton ButtonType { get; set; }

	// Token: 0x17001BC5 RID: 7109
	// (get) Token: 0x06012979 RID: 76153
	// (set) Token: 0x0601297A RID: 76154
	string Title { get; set; }

	// Token: 0x17001BC6 RID: 7110
	// (get) Token: 0x0601297B RID: 76155
	// (set) Token: 0x0601297C RID: 76156
	int ItemGroupId { get; set; }

	// Token: 0x17001BC7 RID: 7111
	// (get) Token: 0x0601297D RID: 76157
	// (set) Token: 0x0601297E RID: 76158
	List<global::IItemMaterial> ItemGroup { get; set; }
}
