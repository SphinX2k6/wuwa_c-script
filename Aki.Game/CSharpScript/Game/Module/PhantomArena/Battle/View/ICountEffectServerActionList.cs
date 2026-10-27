using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02005248 RID: 21064
	[NullableContext(1)]
	public interface ICountEffectServerActionList : IServerAction
	{
		// Token: 0x17008259 RID: 33369
		// (get) Token: 0x06035D24 RID: 220452
		// (set) Token: 0x06035D25 RID: 220453
		List<int> CardIdList { get; set; }
	}
}
