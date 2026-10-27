using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E9F RID: 20127
	public class IAngleWeightT
	{
		// Token: 0x17009057 RID: 36951
		// (get) Token: 0x0601FAE0 RID: 129760 RVA: 0x00469463 File Offset: 0x00467663
		// (set) Token: 0x0601FAE1 RID: 129761 RVA: 0x0046946B File Offset: 0x0046766B
		public EExploreSkillSearchTargetCfg Type { get; set; }

		// Token: 0x17009058 RID: 36952
		// (get) Token: 0x0601FAE2 RID: 129762 RVA: 0x00469474 File Offset: 0x00467674
		// (set) Token: 0x0601FAE3 RID: 129763 RVA: 0x0046947C File Offset: 0x0046767C
		public List<IEntityAngleWeightT> AngleWeight { get; set; }

		// Token: 0x0601FAE4 RID: 129764 RVA: 0x00469485 File Offset: 0x00467685
		public IAngleWeightT()
		{
			this.Type = EExploreSkillSearchTargetCfg.AngleWeight;
			this.AngleWeight = null;
		}
	}
}
