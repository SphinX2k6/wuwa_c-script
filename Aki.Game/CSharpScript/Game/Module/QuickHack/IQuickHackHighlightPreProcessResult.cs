using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F2E RID: 16174
	[NullableContext(1)]
	public interface IQuickHackHighlightPreProcessResult
	{
		// Token: 0x17005301 RID: 21249
		// (get) Token: 0x06028F93 RID: 167827
		// (set) Token: 0x06028F94 RID: 167828
		HashSet<EntityHandle> NewOnScreenTargetSet { get; set; }

		// Token: 0x17005302 RID: 21250
		// (get) Token: 0x06028F95 RID: 167829
		// (set) Token: 0x06028F96 RID: 167830
		HashSet<EntityHandle> NewLockTargetSet { get; set; }
	}
}
