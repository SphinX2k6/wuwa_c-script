using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007611 RID: 30225
	public class IWindProtagonistParkour4T
	{
		// Token: 0x1700E58F RID: 58767
		// (get) Token: 0x060370E6 RID: 225510 RVA: 0x00777DEE File Offset: 0x00775FEE
		// (set) Token: 0x060370E7 RID: 225511 RVA: 0x00777DF6 File Offset: 0x00775FF6
		public ELeisureInteract Type { get; set; }

		// Token: 0x060370E8 RID: 225512 RVA: 0x00777DFF File Offset: 0x00775FFF
		public IWindProtagonistParkour4T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
