using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02004218 RID: 16920
	[NullableContext(1)]
	public interface ICountEffectServerActionList : IServerAction
	{
		// Token: 0x17005619 RID: 22041
		// (get) Token: 0x0602AC1F RID: 175135
		// (set) Token: 0x0602AC20 RID: 175136
		List<int> CardIdList { get; set; }
	}
}
