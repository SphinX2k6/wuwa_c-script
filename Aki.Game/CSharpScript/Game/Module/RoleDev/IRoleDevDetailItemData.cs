using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CBE RID: 19646
	[NullableContext(1)]
	public interface IRoleDevDetailItemData
	{
		// Token: 0x17007D25 RID: 32037
		// (get) Token: 0x06032B8F RID: 207759
		// (set) Token: 0x06032B90 RID: 207760
		int RoleId { get; set; }

		// Token: 0x17007D26 RID: 32038
		// (get) Token: 0x06032B91 RID: 207761
		// (set) Token: 0x06032B92 RID: 207762
		ERoleDevMainPage MainPage { get; set; }

		// Token: 0x17007D27 RID: 32039
		// (get) Token: 0x06032B93 RID: 207763
		// (set) Token: 0x06032B94 RID: 207764
		ERoleDevSubPageButton ButtonType { get; set; }

		// Token: 0x17007D28 RID: 32040
		// (get) Token: 0x06032B95 RID: 207765
		// (set) Token: 0x06032B96 RID: 207766
		string Title { get; set; }

		// Token: 0x17007D29 RID: 32041
		// (get) Token: 0x06032B97 RID: 207767
		// (set) Token: 0x06032B98 RID: 207768
		int ItemGroupId { get; set; }

		// Token: 0x17007D2A RID: 32042
		// (get) Token: 0x06032B99 RID: 207769
		// (set) Token: 0x06032B9A RID: 207770
		List<IItemMaterial> ItemGroup { get; set; }
	}
}
