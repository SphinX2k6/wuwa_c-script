using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B0 RID: 22192
	public class IEnterScreenWeightT
	{
		// Token: 0x17009FB7 RID: 40887
		// (get) Token: 0x060238C6 RID: 145606 RVA: 0x004E38E4 File Offset: 0x004E1AE4
		// (set) Token: 0x060238C7 RID: 145607 RVA: 0x004E38EC File Offset: 0x004E1AEC
		public EExploreSkillSearchTargetCfg Type { get; set; }

		// Token: 0x17009FB8 RID: 40888
		// (get) Token: 0x060238C8 RID: 145608 RVA: 0x004E38F5 File Offset: 0x004E1AF5
		// (set) Token: 0x060238C9 RID: 145609 RVA: 0x004E38FD File Offset: 0x004E1AFD
		public int Weight { get; set; }

		// Token: 0x060238CA RID: 145610 RVA: 0x004E3906 File Offset: 0x004E1B06
		public IEnterScreenWeightT()
		{
			this.Type = EExploreSkillSearchTargetCfg.AngleWeight;
			this.Weight = 0;
		}
	}
}
