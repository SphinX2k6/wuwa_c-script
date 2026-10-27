using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760E RID: 30222
	public class IWindProtagonistParkour3T
	{
		// Token: 0x1700E58C RID: 58764
		// (get) Token: 0x060370D4 RID: 225492 RVA: 0x00777C76 File Offset: 0x00775E76
		// (set) Token: 0x060370D5 RID: 225493 RVA: 0x00777C7E File Offset: 0x00775E7E
		public ELeisureInteract Type { get; set; }

		// Token: 0x060370D6 RID: 225494 RVA: 0x00777C87 File Offset: 0x00775E87
		public IWindProtagonistParkour3T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
