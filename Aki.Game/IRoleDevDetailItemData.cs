using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x020027E3 RID: 10211
[NullableContext(1)]
public interface IRoleDevDetailItemData
{
	// Token: 0x17001B6A RID: 7018
	// (get) Token: 0x06014F73 RID: 85875
	// (set) Token: 0x06014F74 RID: 85876
	int RoleId { get; set; }

	// Token: 0x17001B6B RID: 7019
	// (get) Token: 0x06014F75 RID: 85877
	// (set) Token: 0x06014F76 RID: 85878
	ERoleDevMainPage MainPage { get; set; }

	// Token: 0x17001B6C RID: 7020
	// (get) Token: 0x06014F77 RID: 85879
	// (set) Token: 0x06014F78 RID: 85880
	ERoleDevSubPageButton ButtonType { get; set; }

	// Token: 0x17001B6D RID: 7021
	// (get) Token: 0x06014F79 RID: 85881
	// (set) Token: 0x06014F7A RID: 85882
	string Title { get; set; }

	// Token: 0x17001B6E RID: 7022
	// (get) Token: 0x06014F7B RID: 85883
	// (set) Token: 0x06014F7C RID: 85884
	int ItemGroupId { get; set; }

	// Token: 0x17001B6F RID: 7023
	// (get) Token: 0x06014F7D RID: 85885
	// (set) Token: 0x06014F7E RID: 85886
	List<global::IItemMaterial> ItemGroup { get; set; }
}
