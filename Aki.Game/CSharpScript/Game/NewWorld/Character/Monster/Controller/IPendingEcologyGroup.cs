using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Monster.Controller
{
	// Token: 0x0200709E RID: 28830
	[NullableContext(1)]
	public interface IPendingEcologyGroup
	{
		// Token: 0x17009C27 RID: 39975
		// (get) Token: 0x060463FD RID: 287741
		// (set) Token: 0x060463FE RID: 287742
		GroupAiComponent GroupComp { get; set; }

		// Token: 0x17009C28 RID: 39976
		// (get) Token: 0x060463FF RID: 287743
		// (set) Token: 0x06046400 RID: 287744
		HashSet<int> RegisteredPbDataIds { get; set; }
	}
}
