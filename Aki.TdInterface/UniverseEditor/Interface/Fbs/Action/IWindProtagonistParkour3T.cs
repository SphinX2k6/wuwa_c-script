using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E1C RID: 32284
	public class IWindProtagonistParkour3T
	{
		// Token: 0x1700F1CA RID: 61898
		// (get) Token: 0x0603A579 RID: 238969 RVA: 0x007DBD72 File Offset: 0x007D9F72
		// (set) Token: 0x0603A57A RID: 238970 RVA: 0x007DBD7A File Offset: 0x007D9F7A
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603A57B RID: 238971 RVA: 0x007DBD83 File Offset: 0x007D9F83
		public IWindProtagonistParkour3T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
