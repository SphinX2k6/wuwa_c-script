using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E22 RID: 32290
	public class IWindProtagonistParkour5T
	{
		// Token: 0x1700F1D0 RID: 61904
		// (get) Token: 0x0603A59D RID: 239005 RVA: 0x007DC062 File Offset: 0x007DA262
		// (set) Token: 0x0603A59E RID: 239006 RVA: 0x007DC06A File Offset: 0x007DA26A
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603A59F RID: 239007 RVA: 0x007DC073 File Offset: 0x007DA273
		public IWindProtagonistParkour5T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
