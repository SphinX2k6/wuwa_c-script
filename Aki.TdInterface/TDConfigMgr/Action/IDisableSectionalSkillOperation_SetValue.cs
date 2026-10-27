using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B7 RID: 6583
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableSectionalSkillOperation_SetValue
	{
		// Token: 0x040057AF RID: 22447
		public ESkillOperationType Type;

		// Token: 0x040057B0 RID: 22448
		public EDisplayModeInSkillOp? DisplayMode;

		// Token: 0x040057B1 RID: 22449
		public IDisableExploreSkill DisableExploreSkill;

		// Token: 0x040057B2 RID: 22450
		public bool? DisableSkillWheel;

		// Token: 0x040057B3 RID: 22451
		public IDisableBattleSkillOptions DisableBattleSkill;

		// Token: 0x040057B4 RID: 22452
		public bool? DisableSwitchRole;

		// Token: 0x040057B5 RID: 22453
		public ETeamDisplayModeInSkillOp? TeamDisplayMode;
	}
}
