using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007614 RID: 30228
	public class IWindProtagonistParkour5T
	{
		// Token: 0x1700E592 RID: 58770
		// (get) Token: 0x060370F8 RID: 225528 RVA: 0x00777F66 File Offset: 0x00776166
		// (set) Token: 0x060370F9 RID: 225529 RVA: 0x00777F6E File Offset: 0x0077616E
		public ELeisureInteract Type { get; set; }

		// Token: 0x060370FA RID: 225530 RVA: 0x00777F77 File Offset: 0x00776177
		public IWindProtagonistParkour5T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
