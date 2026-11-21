using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CC7 RID: 15559
	[NullableContext(1)]
	public interface IRoleDevelopItemGroup
	{
		// Token: 0x17005195 RID: 20885
		// (get) Token: 0x06027DB5 RID: 163253
		// (set) Token: 0x06027DB6 RID: 163254
		EItemMaterialType Type { get; set; }

		// Token: 0x17005196 RID: 20886
		// (get) Token: 0x06027DB7 RID: 163255
		// (set) Token: 0x06027DB8 RID: 163256
		List<RoleDevelopNeedItem> Items { get; set; }
	}
}
