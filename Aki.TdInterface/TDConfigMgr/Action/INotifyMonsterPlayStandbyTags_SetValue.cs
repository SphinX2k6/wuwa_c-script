using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E5E RID: 7774
	public class INotifyMonsterPlayStandbyTags_SetValue
	{
		// Token: 0x040063D8 RID: 25560
		public ESetBattleStateType Type;

		// Token: 0x040063D9 RID: 25561
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMonsterStandByConfig> StandbyConfigs;
	}
}
