using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B44 RID: 6980
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableSectionalSkillOperation_SetValue
	{
		// Token: 0x04005C04 RID: 23556
		public ESkillOperationType Type;

		// Token: 0x04005C05 RID: 23557
		public EDisplayModeInSkillOp? DisplayMode;

		// Token: 0x04005C06 RID: 23558
		public IDisableExploreSkill DisableExploreSkill;

		// Token: 0x04005C07 RID: 23559
		public bool? DisableSkillWheel;

		// Token: 0x04005C08 RID: 23560
		public IDisableBattleSkillOptions DisableBattleSkill;

		// Token: 0x04005C09 RID: 23561
		public bool? DisableSwitchRole;

		// Token: 0x04005C0A RID: 23562
		public ETeamDisplayModeInSkillOp? TeamDisplayMode;
	}
}
