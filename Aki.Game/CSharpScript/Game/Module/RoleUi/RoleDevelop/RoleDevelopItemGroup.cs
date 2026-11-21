using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CC8 RID: 15560
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopItemGroup : IRoleDevelopItemGroup
	{
		// Token: 0x17005197 RID: 20887
		// (get) Token: 0x06027DB9 RID: 163257 RVA: 0x00B27417 File Offset: 0x00B25617
		// (set) Token: 0x06027DBA RID: 163258 RVA: 0x00B2741F File Offset: 0x00B2561F
		public EItemMaterialType Type { get; set; }

		// Token: 0x17005198 RID: 20888
		// (get) Token: 0x06027DBB RID: 163259 RVA: 0x00B27428 File Offset: 0x00B25628
		// (set) Token: 0x06027DBC RID: 163260 RVA: 0x00B27430 File Offset: 0x00B25630
		public List<RoleDevelopNeedItem> Items { get; set; }
	}
}
