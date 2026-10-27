using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760B RID: 30219
	public class IWindProtagonistParkour2T
	{
		// Token: 0x1700E589 RID: 58761
		// (get) Token: 0x060370C2 RID: 225474 RVA: 0x00777AFE File Offset: 0x00775CFE
		// (set) Token: 0x060370C3 RID: 225475 RVA: 0x00777B06 File Offset: 0x00775D06
		public ELeisureInteract Type { get; set; }

		// Token: 0x060370C4 RID: 225476 RVA: 0x00777B0F File Offset: 0x00775D0F
		public IWindProtagonistParkour2T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
