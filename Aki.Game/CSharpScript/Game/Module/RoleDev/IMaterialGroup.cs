using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C6D RID: 15469
	[NullableContext(1)]
	public interface IMaterialGroup
	{
		// Token: 0x170050CB RID: 20683
		// (get) Token: 0x0602793A RID: 162106
		// (set) Token: 0x0602793B RID: 162107
		int Type { get; set; }

		// Token: 0x170050CC RID: 20684
		// (get) Token: 0x0602793C RID: 162108
		// (set) Token: 0x0602793D RID: 162109
		List<IItemMaterial> Materials { get; set; }
	}
}
