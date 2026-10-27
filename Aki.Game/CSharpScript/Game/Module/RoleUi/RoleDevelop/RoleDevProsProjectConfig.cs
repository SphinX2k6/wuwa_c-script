using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D01 RID: 19713
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevProsProjectConfig : IRoleDevProsProjectConfig
	{
		// Token: 0x17007DC0 RID: 32192
		// (get) Token: 0x06032F7D RID: 208765 RVA: 0x00BE18BB File Offset: 0x00BDFABB
		// (set) Token: 0x06032F7E RID: 208766 RVA: 0x00BE18C3 File Offset: 0x00BDFAC3
		public int Id { get; set; }

		// Token: 0x17007DC1 RID: 32193
		// (get) Token: 0x06032F7F RID: 208767 RVA: 0x00BE18CC File Offset: 0x00BDFACC
		// (set) Token: 0x06032F80 RID: 208768 RVA: 0x00BE18D4 File Offset: 0x00BDFAD4
		public int ElementId { get; set; }

		// Token: 0x17007DC2 RID: 32194
		// (get) Token: 0x06032F81 RID: 208769 RVA: 0x00BE18DD File Offset: 0x00BDFADD
		// (set) Token: 0x06032F82 RID: 208770 RVA: 0x00BE18E5 File Offset: 0x00BDFAE5
		public string RoleName { get; set; } = string.Empty;

		// Token: 0x17007DC3 RID: 32195
		// (get) Token: 0x06032F83 RID: 208771 RVA: 0x00BE18EE File Offset: 0x00BDFAEE
		// (set) Token: 0x06032F84 RID: 208772 RVA: 0x00BE18F6 File Offset: 0x00BDFAF6
		public int RoleExperience { get; set; }

		// Token: 0x17007DC4 RID: 32196
		// (get) Token: 0x06032F85 RID: 208773 RVA: 0x00BE18FF File Offset: 0x00BDFAFF
		// (set) Token: 0x06032F86 RID: 208774 RVA: 0x00BE1907 File Offset: 0x00BDFB07
		public int RoleGoalLevel { get; set; }

		// Token: 0x17007DC5 RID: 32197
		// (get) Token: 0x06032F87 RID: 208775 RVA: 0x00BE1910 File Offset: 0x00BDFB10
		// (set) Token: 0x06032F88 RID: 208776 RVA: 0x00BE1918 File Offset: 0x00BDFB18
		public int WeaponGoalLevel { get; set; }

		// Token: 0x17007DC6 RID: 32198
		// (get) Token: 0x06032F89 RID: 208777 RVA: 0x00BE1921 File Offset: 0x00BDFB21
		// (set) Token: 0x06032F8A RID: 208778 RVA: 0x00BE1929 File Offset: 0x00BDFB29
		public int WeaponExperience { get; set; }

		// Token: 0x17007DC7 RID: 32199
		// (get) Token: 0x06032F8B RID: 208779 RVA: 0x00BE1932 File Offset: 0x00BDFB32
		// (set) Token: 0x06032F8C RID: 208780 RVA: 0x00BE193A File Offset: 0x00BDFB3A
		public List<int> RoleItemGroup { get; set; } = new List<int>();

		// Token: 0x17007DC8 RID: 32200
		// (get) Token: 0x06032F8D RID: 208781 RVA: 0x00BE1943 File Offset: 0x00BDFB43
		// (set) Token: 0x06032F8E RID: 208782 RVA: 0x00BE194B File Offset: 0x00BDFB4B
		public List<int> WeaponBreachItemGroup { get; set; } = new List<int>();

		// Token: 0x17007DC9 RID: 32201
		// (get) Token: 0x06032F8F RID: 208783 RVA: 0x00BE1954 File Offset: 0x00BDFB54
		// (set) Token: 0x06032F90 RID: 208784 RVA: 0x00BE195C File Offset: 0x00BDFB5C
		public int WeaponType { get; set; }

		// Token: 0x17007DCA RID: 32202
		// (get) Token: 0x06032F91 RID: 208785 RVA: 0x00BE1965 File Offset: 0x00BDFB65
		// (set) Token: 0x06032F92 RID: 208786 RVA: 0x00BE196D File Offset: 0x00BDFB6D
		public List<int> SkillItemGroup { get; set; } = new List<int>();

		// Token: 0x17007DCB RID: 32203
		// (get) Token: 0x06032F93 RID: 208787 RVA: 0x00BE1976 File Offset: 0x00BDFB76
		// (set) Token: 0x06032F94 RID: 208788 RVA: 0x00BE197E File Offset: 0x00BDFB7E
		public List<int> PrefectSkillLevel { get; set; } = new List<int>();

		// Token: 0x17007DCC RID: 32204
		// (get) Token: 0x06032F95 RID: 208789 RVA: 0x00BE1987 File Offset: 0x00BDFB87
		// (set) Token: 0x06032F96 RID: 208790 RVA: 0x00BE198F File Offset: 0x00BDFB8F
		public string RoleHeadIcon { get; set; } = string.Empty;

		// Token: 0x17007DCD RID: 32205
		// (get) Token: 0x06032F97 RID: 208791 RVA: 0x00BE1998 File Offset: 0x00BDFB98
		// (set) Token: 0x06032F98 RID: 208792 RVA: 0x00BE19A0 File Offset: 0x00BDFBA0
		public string RoleHeadIconSmall { get; set; } = string.Empty;

		// Token: 0x17007DCE RID: 32206
		// (get) Token: 0x06032F99 RID: 208793 RVA: 0x00BE19A9 File Offset: 0x00BDFBA9
		// (set) Token: 0x06032F9A RID: 208794 RVA: 0x00BE19B1 File Offset: 0x00BDFBB1
		public string FormationRoleCard { get; set; } = string.Empty;
	}
}
