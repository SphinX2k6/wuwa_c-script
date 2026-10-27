using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02005247 RID: 21063
	[NullableContext(1)]
	public interface IServerAction
	{
		// Token: 0x17008257 RID: 33367
		// (get) Token: 0x06035D20 RID: 220448
		// (set) Token: 0x06035D21 RID: 220449
		List<TServerAction> ActionList { get; set; }

		// Token: 0x17008258 RID: 33368
		// (get) Token: 0x06035D22 RID: 220450
		// (set) Token: 0x06035D23 RID: 220451
		EServerActionType Type { get; set; }
	}
}
