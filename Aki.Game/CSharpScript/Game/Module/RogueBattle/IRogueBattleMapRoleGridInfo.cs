using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ECB RID: 20171
	public interface IRogueBattleMapRoleGridInfo
	{
		// Token: 0x17007F01 RID: 32513
		// (get) Token: 0x06033C95 RID: 212117
		// (set) Token: 0x06033C96 RID: 212118
		int ConfigId { get; set; }

		// Token: 0x17007F02 RID: 32514
		// (get) Token: 0x06033C97 RID: 212119
		// (set) Token: 0x06033C98 RID: 212120
		bool IsGain { get; set; }

		// Token: 0x17007F03 RID: 32515
		// (get) Token: 0x06033C99 RID: 212121
		// (set) Token: 0x06033C9A RID: 212122
		bool NeedLevel { get; set; }
	}
}
