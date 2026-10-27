using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040BF RID: 16575
	public class IRoleTowerChallengeTitleCurrentFloorT
	{
		// Token: 0x170074F6 RID: 29942
		// (get) Token: 0x0601826A RID: 98922 RVA: 0x0037B15A File Offset: 0x0037935A
		// (set) Token: 0x0601826B RID: 98923 RVA: 0x0037B162 File Offset: 0x00379362
		public ERoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x0601826C RID: 98924 RVA: 0x0037B16B File Offset: 0x0037936B
		public IRoleTowerChallengeTitleCurrentFloorT()
		{
			this.Type = ERoleTowerChallengeTitleType.KillProgress;
		}
	}
}
