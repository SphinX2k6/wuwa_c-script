using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F05 RID: 24325
	public class ISearchTargetCfgT
	{
		// Token: 0x1700B3E7 RID: 46055
		// (get) Token: 0x06028D24 RID: 167204 RVA: 0x00594426 File Offset: 0x00592626
		// (set) Token: 0x06028D25 RID: 167205 RVA: 0x0059442E File Offset: 0x0059262E
		public List<IEntityAngleWeightT> AngleWeight { get; set; }

		// Token: 0x1700B3E8 RID: 46056
		// (get) Token: 0x06028D26 RID: 167206 RVA: 0x00594437 File Offset: 0x00592637
		// (set) Token: 0x06028D27 RID: 167207 RVA: 0x0059443F File Offset: 0x0059263F
		public List<IEntityCategoryWeightT> LockConditions { get; set; }

		// Token: 0x1700B3E9 RID: 46057
		// (get) Token: 0x06028D28 RID: 167208 RVA: 0x00594448 File Offset: 0x00592648
		// (set) Token: 0x06028D29 RID: 167209 RVA: 0x00594450 File Offset: 0x00592650
		public bool IgnoreDistanceWeight { get; set; }

		// Token: 0x1700B3EA RID: 46058
		// (get) Token: 0x06028D2A RID: 167210 RVA: 0x00594459 File Offset: 0x00592659
		// (set) Token: 0x06028D2B RID: 167211 RVA: 0x00594461 File Offset: 0x00592661
		public byte NullMask { get; set; }

		// Token: 0x06028D2C RID: 167212 RVA: 0x0059446A File Offset: 0x0059266A
		public ISearchTargetCfgT()
		{
			this.AngleWeight = null;
			this.LockConditions = null;
			this.IgnoreDistanceWeight = false;
			this.NullMask = 0;
		}
	}
}
