using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C8 RID: 16584
	public class IRoleTowerChallengeTitleTypeBaseT
	{
		// Token: 0x170074FF RID: 29951
		// (get) Token: 0x060182A0 RID: 98976 RVA: 0x0037B5C2 File Offset: 0x003797C2
		// (set) Token: 0x060182A1 RID: 98977 RVA: 0x0037B5CA File Offset: 0x003797CA
		public ERoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x060182A2 RID: 98978 RVA: 0x0037B5D3 File Offset: 0x003797D3
		public IRoleTowerChallengeTitleTypeBaseT()
		{
			this.Type = ERoleTowerChallengeTitleType.KillProgress;
		}
	}
}
