using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D11 RID: 19729
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopItemGroup : IRoleDevelopItemGroup
	{
		// Token: 0x17007DED RID: 32237
		// (get) Token: 0x06032FDB RID: 208859 RVA: 0x00BE1AE1 File Offset: 0x00BDFCE1
		// (set) Token: 0x06032FDC RID: 208860 RVA: 0x00BE1AE9 File Offset: 0x00BDFCE9
		public EItemMaterialType Type { get; set; }

		// Token: 0x17007DEE RID: 32238
		// (get) Token: 0x06032FDD RID: 208861 RVA: 0x00BE1AF2 File Offset: 0x00BDFCF2
		// (set) Token: 0x06032FDE RID: 208862 RVA: 0x00BE1AFA File Offset: 0x00BDFCFA
		public List<RoleDevelopNeedItem> Items { get; set; }
	}
}
