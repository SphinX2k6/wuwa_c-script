using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CB3 RID: 15539
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevProsProjectConfig : IRoleDevProsProjectConfig
	{
		// Token: 0x1700516A RID: 20842
		// (get) Token: 0x06027D58 RID: 163160 RVA: 0x00B271C3 File Offset: 0x00B253C3
		// (set) Token: 0x06027D59 RID: 163161 RVA: 0x00B271CB File Offset: 0x00B253CB
		public int Id { get; set; }

		// Token: 0x1700516B RID: 20843
		// (get) Token: 0x06027D5A RID: 163162 RVA: 0x00B271D4 File Offset: 0x00B253D4
		// (set) Token: 0x06027D5B RID: 163163 RVA: 0x00B271DC File Offset: 0x00B253DC
		public int ElementId { get; set; }

		// Token: 0x1700516C RID: 20844
		// (get) Token: 0x06027D5C RID: 163164 RVA: 0x00B271E5 File Offset: 0x00B253E5
		// (set) Token: 0x06027D5D RID: 163165 RVA: 0x00B271ED File Offset: 0x00B253ED
		public string RoleName { get; set; } = string.Empty;

		// Token: 0x1700516D RID: 20845
		// (get) Token: 0x06027D5E RID: 163166 RVA: 0x00B271F6 File Offset: 0x00B253F6
		// (set) Token: 0x06027D5F RID: 163167 RVA: 0x00B271FE File Offset: 0x00B253FE
		public int RoleExperience { get; set; }

		// Token: 0x1700516E RID: 20846
		// (get) Token: 0x06027D60 RID: 163168 RVA: 0x00B27207 File Offset: 0x00B25407
		// (set) Token: 0x06027D61 RID: 163169 RVA: 0x00B2720F File Offset: 0x00B2540F
		public int RoleGoalLevel { get; set; }

		// Token: 0x1700516F RID: 20847
		// (get) Token: 0x06027D62 RID: 163170 RVA: 0x00B27218 File Offset: 0x00B25418
		// (set) Token: 0x06027D63 RID: 163171 RVA: 0x00B27220 File Offset: 0x00B25420
		public int WeaponGoalLevel { get; set; }

		// Token: 0x17005170 RID: 20848
		// (get) Token: 0x06027D64 RID: 163172 RVA: 0x00B27229 File Offset: 0x00B25429
		// (set) Token: 0x06027D65 RID: 163173 RVA: 0x00B27231 File Offset: 0x00B25431
		public int WeaponExperience { get; set; }

		// Token: 0x17005171 RID: 20849
		// (get) Token: 0x06027D66 RID: 163174 RVA: 0x00B2723A File Offset: 0x00B2543A
		// (set) Token: 0x06027D67 RID: 163175 RVA: 0x00B27242 File Offset: 0x00B25442
		public List<int> RoleItemGroup { get; set; } = new List<int>();

		// Token: 0x17005172 RID: 20850
		// (get) Token: 0x06027D68 RID: 163176 RVA: 0x00B2724B File Offset: 0x00B2544B
		// (set) Token: 0x06027D69 RID: 163177 RVA: 0x00B27253 File Offset: 0x00B25453
		public List<int> WeaponBreachItemGroup { get; set; } = new List<int>();

		// Token: 0x17005173 RID: 20851
		// (get) Token: 0x06027D6A RID: 163178 RVA: 0x00B2725C File Offset: 0x00B2545C
		// (set) Token: 0x06027D6B RID: 163179 RVA: 0x00B27264 File Offset: 0x00B25464
		public int WeaponType { get; set; }

		// Token: 0x17005174 RID: 20852
		// (get) Token: 0x06027D6C RID: 163180 RVA: 0x00B2726D File Offset: 0x00B2546D
		// (set) Token: 0x06027D6D RID: 163181 RVA: 0x00B27275 File Offset: 0x00B25475
		public List<int> SkillItemGroup { get; set; } = new List<int>();

		// Token: 0x17005175 RID: 20853
		// (get) Token: 0x06027D6E RID: 163182 RVA: 0x00B2727E File Offset: 0x00B2547E
		// (set) Token: 0x06027D6F RID: 163183 RVA: 0x00B27286 File Offset: 0x00B25486
		public List<int> PrefectSkillLevel { get; set; } = new List<int>();

		// Token: 0x17005176 RID: 20854
		// (get) Token: 0x06027D70 RID: 163184 RVA: 0x00B2728F File Offset: 0x00B2548F
		// (set) Token: 0x06027D71 RID: 163185 RVA: 0x00B27297 File Offset: 0x00B25497
		public string RoleHeadIcon { get; set; } = string.Empty;

		// Token: 0x17005177 RID: 20855
		// (get) Token: 0x06027D72 RID: 163186 RVA: 0x00B272A0 File Offset: 0x00B254A0
		// (set) Token: 0x06027D73 RID: 163187 RVA: 0x00B272A8 File Offset: 0x00B254A8
		public string RoleHeadIconSmall { get; set; } = string.Empty;

		// Token: 0x17005178 RID: 20856
		// (get) Token: 0x06027D74 RID: 163188 RVA: 0x00B272B1 File Offset: 0x00B254B1
		// (set) Token: 0x06027D75 RID: 163189 RVA: 0x00B272B9 File Offset: 0x00B254B9
		public string FormationRoleCard { get; set; } = string.Empty;
	}
}
