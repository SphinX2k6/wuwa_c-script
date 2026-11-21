using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C8 RID: 21448
	public class IAngleWeightT
	{
		// Token: 0x170097B6 RID: 38838
		// (get) Token: 0x060217D5 RID: 137173 RVA: 0x0049E6C7 File Offset: 0x0049C8C7
		// (set) Token: 0x060217D6 RID: 137174 RVA: 0x0049E6CF File Offset: 0x0049C8CF
		public EExploreSkillSearchTargetCfg Type { get; set; }

		// Token: 0x170097B7 RID: 38839
		// (get) Token: 0x060217D7 RID: 137175 RVA: 0x0049E6D8 File Offset: 0x0049C8D8
		// (set) Token: 0x060217D8 RID: 137176 RVA: 0x0049E6E0 File Offset: 0x0049C8E0
		public List<IEntityAngleWeightT> AngleWeight { get; set; }

		// Token: 0x060217D9 RID: 137177 RVA: 0x0049E6E9 File Offset: 0x0049C8E9
		public IAngleWeightT()
		{
			this.Type = EExploreSkillSearchTargetCfg.AngleWeight;
			this.AngleWeight = null;
		}
	}
}
