using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02004217 RID: 16919
	[NullableContext(1)]
	public interface IServerAction
	{
		// Token: 0x17005617 RID: 22039
		// (get) Token: 0x0602AC1B RID: 175131
		// (set) Token: 0x0602AC1C RID: 175132
		List<TServerAction> ActionList { get; set; }

		// Token: 0x17005618 RID: 22040
		// (get) Token: 0x0602AC1D RID: 175133
		// (set) Token: 0x0602AC1E RID: 175134
		EServerActionType Type { get; set; }
	}
}
