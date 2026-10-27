using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F92 RID: 20370
	public class ICheckGearHitT
	{
		// Token: 0x17009360 RID: 37728
		// (get) Token: 0x06020605 RID: 132613 RVA: 0x004811F9 File Offset: 0x0047F3F9
		// (set) Token: 0x06020606 RID: 132614 RVA: 0x00481201 File Offset: 0x0047F401
		public int HitIndex { get; set; }

		// Token: 0x17009361 RID: 37729
		// (get) Token: 0x06020607 RID: 132615 RVA: 0x0048120A File Offset: 0x0047F40A
		// (set) Token: 0x06020608 RID: 132616 RVA: 0x00481212 File Offset: 0x0047F412
		public List<int> AffectIndex { get; set; }

		// Token: 0x17009362 RID: 37730
		// (get) Token: 0x06020609 RID: 132617 RVA: 0x0048121B File Offset: 0x0047F41B
		// (set) Token: 0x0602060A RID: 132618 RVA: 0x00481223 File Offset: 0x0047F423
		public EGearHitAffectType AffectType { get; set; }

		// Token: 0x0602060B RID: 132619 RVA: 0x0048122C File Offset: 0x0047F42C
		public ICheckGearHitT()
		{
			this.HitIndex = 0;
			this.AffectIndex = null;
			this.AffectType = EGearHitAffectType.ChangeNextState;
		}
	}
}
