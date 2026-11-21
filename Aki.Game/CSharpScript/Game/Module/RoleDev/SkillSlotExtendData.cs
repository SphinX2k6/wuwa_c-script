using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C7E RID: 15486
	public class SkillSlotExtendData : ISkillSlotExtendData
	{
		// Token: 0x17005115 RID: 20757
		// (get) Token: 0x060279D4 RID: 162260 RVA: 0x00B1A114 File Offset: 0x00B18314
		// (set) Token: 0x060279D5 RID: 162261 RVA: 0x00B1A11C File Offset: 0x00B1831C
		public int RoleId { get; set; }

		// Token: 0x17005116 RID: 20758
		// (get) Token: 0x060279D6 RID: 162262 RVA: 0x00B1A125 File Offset: 0x00B18325
		// (set) Token: 0x060279D7 RID: 162263 RVA: 0x00B1A12D File Offset: 0x00B1832D
		public int SkillNodeId { get; set; }

		// Token: 0x17005117 RID: 20759
		// (get) Token: 0x060279D8 RID: 162264 RVA: 0x00B1A136 File Offset: 0x00B18336
		// (set) Token: 0x060279D9 RID: 162265 RVA: 0x00B1A13E File Offset: 0x00B1833E
		public int IconId { get; set; }

		// Token: 0x17005118 RID: 20760
		// (get) Token: 0x060279DA RID: 162266 RVA: 0x00B1A147 File Offset: 0x00B18347
		// (set) Token: 0x060279DB RID: 162267 RVA: 0x00B1A14F File Offset: 0x00B1834F
		public int CurrentLevel { get; set; }

		// Token: 0x17005119 RID: 20761
		// (get) Token: 0x060279DC RID: 162268 RVA: 0x00B1A158 File Offset: 0x00B18358
		// (set) Token: 0x060279DD RID: 162269 RVA: 0x00B1A160 File Offset: 0x00B18360
		public int NormalTargetLevel { get; set; }

		// Token: 0x1700511A RID: 20762
		// (get) Token: 0x060279DE RID: 162270 RVA: 0x00B1A169 File Offset: 0x00B18369
		// (set) Token: 0x060279DF RID: 162271 RVA: 0x00B1A171 File Offset: 0x00B18371
		public int PerfectTargetLevel { get; set; }

		// Token: 0x1700511B RID: 20763
		// (get) Token: 0x060279E0 RID: 162272 RVA: 0x00B1A17A File Offset: 0x00B1837A
		// (set) Token: 0x060279E1 RID: 162273 RVA: 0x00B1A182 File Offset: 0x00B18382
		public ESkillType SkillType { get; set; }

		// Token: 0x1700511C RID: 20764
		// (get) Token: 0x060279E2 RID: 162274 RVA: 0x00B1A18B File Offset: 0x00B1838B
		// (set) Token: 0x060279E3 RID: 162275 RVA: 0x00B1A193 File Offset: 0x00B18393
		public int NodeIndex { get; set; }
	}
}
