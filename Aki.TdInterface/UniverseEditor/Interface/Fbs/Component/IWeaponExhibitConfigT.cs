using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6F RID: 23407
	public class IWeaponExhibitConfigT
	{
		// Token: 0x1700B0E1 RID: 45281
		// (get) Token: 0x060280F9 RID: 164089 RVA: 0x00581E65 File Offset: 0x00580065
		// (set) Token: 0x060280FA RID: 164090 RVA: 0x00581E6D File Offset: 0x0058006D
		public EExhibitItemType Type { get; set; }

		// Token: 0x1700B0E2 RID: 45282
		// (get) Token: 0x060280FB RID: 164091 RVA: 0x00581E76 File Offset: 0x00580076
		// (set) Token: 0x060280FC RID: 164092 RVA: 0x00581E7E File Offset: 0x0058007E
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B0E3 RID: 45283
		// (get) Token: 0x060280FD RID: 164093 RVA: 0x00581E87 File Offset: 0x00580087
		// (set) Token: 0x060280FE RID: 164094 RVA: 0x00581E8F File Offset: 0x0058008F
		public IExhibitEffectT ActiveEffect { get; set; }

		// Token: 0x060280FF RID: 164095 RVA: 0x00581E98 File Offset: 0x00580098
		public IWeaponExhibitConfigT()
		{
			this.Type = EExhibitItemType.Phantom;
			this.Offset = null;
			this.ActiveEffect = null;
		}
	}
}
