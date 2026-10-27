using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D24 RID: 19748
	public interface IRoleDevelopSkillData
	{
		// Token: 0x17007E35 RID: 32309
		// (get) Token: 0x06033074 RID: 209012
		// (set) Token: 0x06033075 RID: 209013
		int RoleId { get; set; }

		// Token: 0x17007E36 RID: 32310
		// (get) Token: 0x06033076 RID: 209014
		// (set) Token: 0x06033077 RID: 209015
		int SkillNodeId { get; set; }

		// Token: 0x17007E37 RID: 32311
		// (get) Token: 0x06033078 RID: 209016
		// (set) Token: 0x06033079 RID: 209017
		int CurrentLevel { get; set; }

		// Token: 0x17007E38 RID: 32312
		// (get) Token: 0x0603307A RID: 209018
		// (set) Token: 0x0603307B RID: 209019
		int TargetLevel { get; set; }

		// Token: 0x17007E39 RID: 32313
		// (get) Token: 0x0603307C RID: 209020
		// (set) Token: 0x0603307D RID: 209021
		int Index { get; set; }
	}
}
