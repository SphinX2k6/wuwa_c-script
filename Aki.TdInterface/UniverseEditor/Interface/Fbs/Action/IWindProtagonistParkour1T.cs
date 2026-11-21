using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E16 RID: 32278
	public class IWindProtagonistParkour1T
	{
		// Token: 0x1700F1C4 RID: 61892
		// (get) Token: 0x0603A555 RID: 238933 RVA: 0x007DBA82 File Offset: 0x007D9C82
		// (set) Token: 0x0603A556 RID: 238934 RVA: 0x007DBA8A File Offset: 0x007D9C8A
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603A557 RID: 238935 RVA: 0x007DBA93 File Offset: 0x007D9C93
		public IWindProtagonistParkour1T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
