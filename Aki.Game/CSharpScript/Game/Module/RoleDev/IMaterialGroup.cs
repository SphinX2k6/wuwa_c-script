using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CBC RID: 19644
	[NullableContext(1)]
	public interface IMaterialGroup
	{
		// Token: 0x17007D21 RID: 32033
		// (get) Token: 0x06032B86 RID: 207750
		// (set) Token: 0x06032B87 RID: 207751
		int Type { get; set; }

		// Token: 0x17007D22 RID: 32034
		// (get) Token: 0x06032B88 RID: 207752
		// (set) Token: 0x06032B89 RID: 207753
		List<IItemMaterial> Materials { get; set; }
	}
}
