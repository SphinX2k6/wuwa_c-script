using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CD2 RID: 19666
	public interface IRoleDevSkillSlotItemData
	{
		// Token: 0x17007D7D RID: 32125
		// (get) Token: 0x06032C47 RID: 207943
		// (set) Token: 0x06032C48 RID: 207944
		int RoleId { get; set; }

		// Token: 0x17007D7E RID: 32126
		// (get) Token: 0x06032C49 RID: 207945
		// (set) Token: 0x06032C4A RID: 207946
		int SkillNodeId { get; set; }

		// Token: 0x17007D7F RID: 32127
		// (get) Token: 0x06032C4B RID: 207947
		// (set) Token: 0x06032C4C RID: 207948
		int CurrentLevel { get; set; }

		// Token: 0x17007D80 RID: 32128
		// (get) Token: 0x06032C4D RID: 207949
		// (set) Token: 0x06032C4E RID: 207950
		int NormalTargetLevel { get; set; }

		// Token: 0x17007D81 RID: 32129
		// (get) Token: 0x06032C4F RID: 207951
		// (set) Token: 0x06032C50 RID: 207952
		int PerfectTargetLevel { get; set; }
	}
}
