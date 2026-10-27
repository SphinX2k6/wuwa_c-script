using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D00 RID: 19712
	[NullableContext(1)]
	public interface IRoleDevProsProjectConfig
	{
		// Token: 0x17007DB1 RID: 32177
		// (get) Token: 0x06032F5E RID: 208734
		// (set) Token: 0x06032F5F RID: 208735
		int Id { get; set; }

		// Token: 0x17007DB2 RID: 32178
		// (get) Token: 0x06032F60 RID: 208736
		// (set) Token: 0x06032F61 RID: 208737
		int ElementId { get; set; }

		// Token: 0x17007DB3 RID: 32179
		// (get) Token: 0x06032F62 RID: 208738
		// (set) Token: 0x06032F63 RID: 208739
		string RoleName { get; set; }

		// Token: 0x17007DB4 RID: 32180
		// (get) Token: 0x06032F64 RID: 208740
		// (set) Token: 0x06032F65 RID: 208741
		int RoleExperience { get; set; }

		// Token: 0x17007DB5 RID: 32181
		// (get) Token: 0x06032F66 RID: 208742
		// (set) Token: 0x06032F67 RID: 208743
		int RoleGoalLevel { get; set; }

		// Token: 0x17007DB6 RID: 32182
		// (get) Token: 0x06032F68 RID: 208744
		// (set) Token: 0x06032F69 RID: 208745
		int WeaponGoalLevel { get; set; }

		// Token: 0x17007DB7 RID: 32183
		// (get) Token: 0x06032F6A RID: 208746
		// (set) Token: 0x06032F6B RID: 208747
		int WeaponExperience { get; set; }

		// Token: 0x17007DB8 RID: 32184
		// (get) Token: 0x06032F6C RID: 208748
		// (set) Token: 0x06032F6D RID: 208749
		List<int> RoleItemGroup { get; set; }

		// Token: 0x17007DB9 RID: 32185
		// (get) Token: 0x06032F6E RID: 208750
		// (set) Token: 0x06032F6F RID: 208751
		List<int> WeaponBreachItemGroup { get; set; }

		// Token: 0x17007DBA RID: 32186
		// (get) Token: 0x06032F70 RID: 208752
		// (set) Token: 0x06032F71 RID: 208753
		int WeaponType { get; set; }

		// Token: 0x17007DBB RID: 32187
		// (get) Token: 0x06032F72 RID: 208754
		// (set) Token: 0x06032F73 RID: 208755
		List<int> SkillItemGroup { get; set; }

		// Token: 0x17007DBC RID: 32188
		// (get) Token: 0x06032F74 RID: 208756
		// (set) Token: 0x06032F75 RID: 208757
		List<int> PrefectSkillLevel { get; set; }

		// Token: 0x17007DBD RID: 32189
		// (get) Token: 0x06032F76 RID: 208758
		// (set) Token: 0x06032F77 RID: 208759
		string RoleHeadIcon { get; set; }

		// Token: 0x17007DBE RID: 32190
		// (get) Token: 0x06032F78 RID: 208760
		// (set) Token: 0x06032F79 RID: 208761
		string RoleHeadIconSmall { get; set; }

		// Token: 0x17007DBF RID: 32191
		// (get) Token: 0x06032F7A RID: 208762
		// (set) Token: 0x06032F7B RID: 208763
		string FormationRoleCard { get; set; }
	}
}
