using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x020027E4 RID: 10212
[NullableContext(1)]
[Nullable(0)]
public class RoleDevDetailItemData : global::IRoleDevDetailItemData
{
	// Token: 0x17001B70 RID: 7024
	// (get) Token: 0x06014F7F RID: 85887 RVA: 0x00551192 File Offset: 0x0054F392
	// (set) Token: 0x06014F80 RID: 85888 RVA: 0x0055119A File Offset: 0x0054F39A
	public int RoleId { get; set; }

	// Token: 0x17001B71 RID: 7025
	// (get) Token: 0x06014F81 RID: 85889 RVA: 0x005511A3 File Offset: 0x0054F3A3
	// (set) Token: 0x06014F82 RID: 85890 RVA: 0x005511AB File Offset: 0x0054F3AB
	public ERoleDevMainPage MainPage { get; set; }

	// Token: 0x17001B72 RID: 7026
	// (get) Token: 0x06014F83 RID: 85891 RVA: 0x005511B4 File Offset: 0x0054F3B4
	// (set) Token: 0x06014F84 RID: 85892 RVA: 0x005511BC File Offset: 0x0054F3BC
	public ERoleDevSubPageButton ButtonType { get; set; }

	// Token: 0x17001B73 RID: 7027
	// (get) Token: 0x06014F85 RID: 85893 RVA: 0x005511C5 File Offset: 0x0054F3C5
	// (set) Token: 0x06014F86 RID: 85894 RVA: 0x005511CD File Offset: 0x0054F3CD
	public string Title { get; set; }

	// Token: 0x17001B74 RID: 7028
	// (get) Token: 0x06014F87 RID: 85895 RVA: 0x005511D6 File Offset: 0x0054F3D6
	// (set) Token: 0x06014F88 RID: 85896 RVA: 0x005511DE File Offset: 0x0054F3DE
	public int ItemGroupId { get; set; }

	// Token: 0x17001B75 RID: 7029
	// (get) Token: 0x06014F89 RID: 85897 RVA: 0x005511E7 File Offset: 0x0054F3E7
	// (set) Token: 0x06014F8A RID: 85898 RVA: 0x005511EF File Offset: 0x0054F3EF
	public List<global::IItemMaterial> ItemGroup { get; set; }
}
