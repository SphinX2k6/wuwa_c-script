using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F65 RID: 20325
	[NullableContext(1)]
	public interface IQuickHackHighlightPreProcessResult
	{
		// Token: 0x17007F51 RID: 32593
		// (get) Token: 0x06034125 RID: 213285
		// (set) Token: 0x06034126 RID: 213286
		HashSet<EntityHandle> NewOnScreenTargetSet { get; set; }

		// Token: 0x17007F52 RID: 32594
		// (get) Token: 0x06034127 RID: 213287
		// (set) Token: 0x06034128 RID: 213288
		HashSet<EntityHandle> NewLockTargetSet { get; set; }
	}
}
