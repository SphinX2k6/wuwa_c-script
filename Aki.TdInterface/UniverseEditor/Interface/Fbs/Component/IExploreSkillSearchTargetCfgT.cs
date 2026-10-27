using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005208 RID: 21000
	public class IExploreSkillSearchTargetCfgT
	{
		// Token: 0x170099D3 RID: 39379
		// (get) Token: 0x060221F4 RID: 139764 RVA: 0x004BC24A File Offset: 0x004BA44A
		// (set) Token: 0x060221F5 RID: 139765 RVA: 0x004BC252 File Offset: 0x004BA452
		public EExploreSkillSearchTargetCfg Type { get; set; }

		// Token: 0x060221F6 RID: 139766 RVA: 0x004BC25B File Offset: 0x004BA45B
		public IExploreSkillSearchTargetCfgT()
		{
			this.Type = EExploreSkillSearchTargetCfg.AngleWeight;
		}
	}
}
