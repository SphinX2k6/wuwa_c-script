using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x02004219 RID: 16921
	[NullableContext(1)]
	[Nullable(0)]
	public class ServerAction : IServerAction
	{
		// Token: 0x1700561A RID: 22042
		// (get) Token: 0x0602AC21 RID: 175137 RVA: 0x00C0933F File Offset: 0x00C0753F
		// (set) Token: 0x0602AC22 RID: 175138 RVA: 0x00C09347 File Offset: 0x00C07547
		public List<TServerAction> ActionList { get; set; }

		// Token: 0x1700561B RID: 22043
		// (get) Token: 0x0602AC23 RID: 175139 RVA: 0x00C09350 File Offset: 0x00C07550
		// (set) Token: 0x0602AC24 RID: 175140 RVA: 0x00C09358 File Offset: 0x00C07558
		public EServerActionType Type { get; set; }
	}
}
