using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006185 RID: 24965
	public class IWeaponExhibitConfigT
	{
		// Token: 0x1700BA29 RID: 47657
		// (get) Token: 0x0602A6BD RID: 173757 RVA: 0x005C98F5 File Offset: 0x005C7AF5
		// (set) Token: 0x0602A6BE RID: 173758 RVA: 0x005C98FD File Offset: 0x005C7AFD
		public EExhibitItemType Type { get; set; }

		// Token: 0x1700BA2A RID: 47658
		// (get) Token: 0x0602A6BF RID: 173759 RVA: 0x005C9906 File Offset: 0x005C7B06
		// (set) Token: 0x0602A6C0 RID: 173760 RVA: 0x005C990E File Offset: 0x005C7B0E
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700BA2B RID: 47659
		// (get) Token: 0x0602A6C1 RID: 173761 RVA: 0x005C9917 File Offset: 0x005C7B17
		// (set) Token: 0x0602A6C2 RID: 173762 RVA: 0x005C991F File Offset: 0x005C7B1F
		public IExhibitEffectT ActiveEffect { get; set; }

		// Token: 0x0602A6C3 RID: 173763 RVA: 0x005C9928 File Offset: 0x005C7B28
		public IWeaponExhibitConfigT()
		{
			this.Type = EExhibitItemType.Phantom;
			this.Offset = null;
			this.ActiveEffect = null;
		}
	}
}
