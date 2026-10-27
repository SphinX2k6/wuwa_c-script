using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Monster.Controller
{
	// Token: 0x0200709F RID: 28831
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingEcologyGroup : IPendingEcologyGroup
	{
		// Token: 0x17009C29 RID: 39977
		// (get) Token: 0x06046401 RID: 287745 RVA: 0x011944AB File Offset: 0x011926AB
		// (set) Token: 0x06046402 RID: 287746 RVA: 0x011944B3 File Offset: 0x011926B3
		public GroupAiComponent GroupComp { get; set; }

		// Token: 0x17009C2A RID: 39978
		// (get) Token: 0x06046403 RID: 287747 RVA: 0x011944BC File Offset: 0x011926BC
		// (set) Token: 0x06046404 RID: 287748 RVA: 0x011944C4 File Offset: 0x011926C4
		public HashSet<int> RegisteredPbDataIds { get; set; } = new HashSet<int>();
	}
}
