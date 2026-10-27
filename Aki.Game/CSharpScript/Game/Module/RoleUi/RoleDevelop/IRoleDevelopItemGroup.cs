using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D10 RID: 19728
	[NullableContext(1)]
	public interface IRoleDevelopItemGroup
	{
		// Token: 0x17007DEB RID: 32235
		// (get) Token: 0x06032FD7 RID: 208855
		// (set) Token: 0x06032FD8 RID: 208856
		EItemMaterialType Type { get; set; }

		// Token: 0x17007DEC RID: 32236
		// (get) Token: 0x06032FD9 RID: 208857
		// (set) Token: 0x06032FDA RID: 208858
		List<RoleDevelopNeedItem> Items { get; set; }
	}
}
