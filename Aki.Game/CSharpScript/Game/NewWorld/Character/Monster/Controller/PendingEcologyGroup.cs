using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Monster.Controller
{
	// Token: 0x02006304 RID: 25348
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingEcologyGroup : IPendingEcologyGroup
	{
		// Token: 0x1700740E RID: 29710
		// (get) Token: 0x0603D4EF RID: 251119 RVA: 0x011B7517 File Offset: 0x011B5717
		// (set) Token: 0x0603D4F0 RID: 251120 RVA: 0x011B751F File Offset: 0x011B571F
		public GroupAiComponent GroupComp { get; set; }

		// Token: 0x1700740F RID: 29711
		// (get) Token: 0x0603D4F1 RID: 251121 RVA: 0x011B7528 File Offset: 0x011B5728
		// (set) Token: 0x0603D4F2 RID: 251122 RVA: 0x011B7530 File Offset: 0x011B5730
		public HashSet<int> RegisteredPbDataIds { get; set; } = new HashSet<int>();
	}
}
