using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200514B RID: 20811
	public class IEnterScreenWeightT
	{
		// Token: 0x170097CA RID: 38858
		// (get) Token: 0x06021972 RID: 137586 RVA: 0x004A9958 File Offset: 0x004A7B58
		// (set) Token: 0x06021973 RID: 137587 RVA: 0x004A9960 File Offset: 0x004A7B60
		public EExploreSkillSearchTargetCfg Type { get; set; }

		// Token: 0x170097CB RID: 38859
		// (get) Token: 0x06021974 RID: 137588 RVA: 0x004A9969 File Offset: 0x004A7B69
		// (set) Token: 0x06021975 RID: 137589 RVA: 0x004A9971 File Offset: 0x004A7B71
		public int Weight { get; set; }

		// Token: 0x06021976 RID: 137590 RVA: 0x004A997A File Offset: 0x004A7B7A
		public IEnterScreenWeightT()
		{
			this.Type = EExploreSkillSearchTargetCfg.AngleWeight;
			this.Weight = 0;
		}
	}
}
