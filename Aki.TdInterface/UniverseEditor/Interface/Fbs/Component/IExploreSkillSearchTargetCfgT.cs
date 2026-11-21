using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005770 RID: 22384
	public class IExploreSkillSearchTargetCfgT
	{
		// Token: 0x1700A1CF RID: 41423
		// (get) Token: 0x0602418A RID: 147850 RVA: 0x004F6D0E File Offset: 0x004F4F0E
		// (set) Token: 0x0602418B RID: 147851 RVA: 0x004F6D16 File Offset: 0x004F4F16
		public EExploreSkillSearchTargetCfg Type { get; set; }

		// Token: 0x0602418C RID: 147852 RVA: 0x004F6D1F File Offset: 0x004F4F1F
		public IExploreSkillSearchTargetCfgT()
		{
			this.Type = EExploreSkillSearchTargetCfg.AngleWeight;
		}
	}
}
