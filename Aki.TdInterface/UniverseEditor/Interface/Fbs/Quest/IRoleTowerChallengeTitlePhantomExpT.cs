using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C5 RID: 16581
	public class IRoleTowerChallengeTitlePhantomExpT
	{
		// Token: 0x170074FC RID: 29948
		// (get) Token: 0x0601828E RID: 98958 RVA: 0x0037B44A File Offset: 0x0037964A
		// (set) Token: 0x0601828F RID: 98959 RVA: 0x0037B452 File Offset: 0x00379652
		public ERoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x06018290 RID: 98960 RVA: 0x0037B45B File Offset: 0x0037965B
		public IRoleTowerChallengeTitlePhantomExpT()
		{
			this.Type = ERoleTowerChallengeTitleType.KillProgress;
		}
	}
}
