using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CCC RID: 19660
	public interface ISkillSlotExtendData
	{
		// Token: 0x17007D63 RID: 32099
		// (get) Token: 0x06032C10 RID: 207888
		// (set) Token: 0x06032C11 RID: 207889
		int RoleId { get; set; }

		// Token: 0x17007D64 RID: 32100
		// (get) Token: 0x06032C12 RID: 207890
		// (set) Token: 0x06032C13 RID: 207891
		int SkillNodeId { get; set; }

		// Token: 0x17007D65 RID: 32101
		// (get) Token: 0x06032C14 RID: 207892
		// (set) Token: 0x06032C15 RID: 207893
		int IconId { get; set; }

		// Token: 0x17007D66 RID: 32102
		// (get) Token: 0x06032C16 RID: 207894
		// (set) Token: 0x06032C17 RID: 207895
		int CurrentLevel { get; set; }

		// Token: 0x17007D67 RID: 32103
		// (get) Token: 0x06032C18 RID: 207896
		// (set) Token: 0x06032C19 RID: 207897
		int NormalTargetLevel { get; set; }

		// Token: 0x17007D68 RID: 32104
		// (get) Token: 0x06032C1A RID: 207898
		// (set) Token: 0x06032C1B RID: 207899
		int PerfectTargetLevel { get; set; }

		// Token: 0x17007D69 RID: 32105
		// (get) Token: 0x06032C1C RID: 207900
		// (set) Token: 0x06032C1D RID: 207901
		ESkillType SkillType { get; set; }

		// Token: 0x17007D6A RID: 32106
		// (get) Token: 0x06032C1E RID: 207902
		// (set) Token: 0x06032C1F RID: 207903
		int NodeIndex { get; set; }
	}
}
