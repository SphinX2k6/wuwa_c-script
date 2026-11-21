using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CB2 RID: 15538
	[NullableContext(1)]
	public interface IRoleDevProsProjectConfig
	{
		// Token: 0x1700515B RID: 20827
		// (get) Token: 0x06027D39 RID: 163129
		// (set) Token: 0x06027D3A RID: 163130
		int Id { get; set; }

		// Token: 0x1700515C RID: 20828
		// (get) Token: 0x06027D3B RID: 163131
		// (set) Token: 0x06027D3C RID: 163132
		int ElementId { get; set; }

		// Token: 0x1700515D RID: 20829
		// (get) Token: 0x06027D3D RID: 163133
		// (set) Token: 0x06027D3E RID: 163134
		string RoleName { get; set; }

		// Token: 0x1700515E RID: 20830
		// (get) Token: 0x06027D3F RID: 163135
		// (set) Token: 0x06027D40 RID: 163136
		int RoleExperience { get; set; }

		// Token: 0x1700515F RID: 20831
		// (get) Token: 0x06027D41 RID: 163137
		// (set) Token: 0x06027D42 RID: 163138
		int RoleGoalLevel { get; set; }

		// Token: 0x17005160 RID: 20832
		// (get) Token: 0x06027D43 RID: 163139
		// (set) Token: 0x06027D44 RID: 163140
		int WeaponGoalLevel { get; set; }

		// Token: 0x17005161 RID: 20833
		// (get) Token: 0x06027D45 RID: 163141
		// (set) Token: 0x06027D46 RID: 163142
		int WeaponExperience { get; set; }

		// Token: 0x17005162 RID: 20834
		// (get) Token: 0x06027D47 RID: 163143
		// (set) Token: 0x06027D48 RID: 163144
		List<int> RoleItemGroup { get; set; }

		// Token: 0x17005163 RID: 20835
		// (get) Token: 0x06027D49 RID: 163145
		// (set) Token: 0x06027D4A RID: 163146
		List<int> WeaponBreachItemGroup { get; set; }

		// Token: 0x17005164 RID: 20836
		// (get) Token: 0x06027D4B RID: 163147
		// (set) Token: 0x06027D4C RID: 163148
		int WeaponType { get; set; }

		// Token: 0x17005165 RID: 20837
		// (get) Token: 0x06027D4D RID: 163149
		// (set) Token: 0x06027D4E RID: 163150
		List<int> SkillItemGroup { get; set; }

		// Token: 0x17005166 RID: 20838
		// (get) Token: 0x06027D4F RID: 163151
		// (set) Token: 0x06027D50 RID: 163152
		List<int> PrefectSkillLevel { get; set; }

		// Token: 0x17005167 RID: 20839
		// (get) Token: 0x06027D51 RID: 163153
		// (set) Token: 0x06027D52 RID: 163154
		string RoleHeadIcon { get; set; }

		// Token: 0x17005168 RID: 20840
		// (get) Token: 0x06027D53 RID: 163155
		// (set) Token: 0x06027D54 RID: 163156
		string RoleHeadIconSmall { get; set; }

		// Token: 0x17005169 RID: 20841
		// (get) Token: 0x06027D55 RID: 163157
		// (set) Token: 0x06027D56 RID: 163158
		string FormationRoleCard { get; set; }
	}
}
