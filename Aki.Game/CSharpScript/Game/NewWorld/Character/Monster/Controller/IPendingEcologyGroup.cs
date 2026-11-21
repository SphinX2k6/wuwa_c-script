using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Monster.Controller
{
	// Token: 0x02006303 RID: 25347
	[NullableContext(1)]
	public interface IPendingEcologyGroup
	{
		// Token: 0x1700740C RID: 29708
		// (get) Token: 0x0603D4EB RID: 251115
		// (set) Token: 0x0603D4EC RID: 251116
		GroupAiComponent GroupComp { get; set; }

		// Token: 0x1700740D RID: 29709
		// (get) Token: 0x0603D4ED RID: 251117
		// (set) Token: 0x0603D4EE RID: 251118
		HashSet<int> RegisteredPbDataIds { get; set; }
	}
}
