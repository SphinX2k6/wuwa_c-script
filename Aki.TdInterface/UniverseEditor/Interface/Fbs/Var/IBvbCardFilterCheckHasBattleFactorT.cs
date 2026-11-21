using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E09 RID: 15881
	public class IBvbCardFilterCheckHasBattleFactorT
	{
		// Token: 0x17006B41 RID: 27457
		// (get) Token: 0x06015581 RID: 87425 RVA: 0x0031577F File Offset: 0x0031397F
		// (set) Token: 0x06015582 RID: 87426 RVA: 0x00315787 File Offset: 0x00313987
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006B42 RID: 27458
		// (get) Token: 0x06015583 RID: 87427 RVA: 0x00315790 File Offset: 0x00313990
		// (set) Token: 0x06015584 RID: 87428 RVA: 0x00315798 File Offset: 0x00313998
		public List<int> BattleFactorList { get; set; }

		// Token: 0x06015585 RID: 87429 RVA: 0x003157A1 File Offset: 0x003139A1
		public IBvbCardFilterCheckHasBattleFactorT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.BattleFactorList = null;
		}
	}
}
