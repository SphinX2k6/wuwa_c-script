using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C65 RID: 7269
	public class INotifyMonsterPlayStandbyTags_SetValue
	{
		// Token: 0x04005E9E RID: 24222
		public ESetBattleStateType Type;

		// Token: 0x04005E9F RID: 24223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMonsterStandByConfig> StandbyConfigs;
	}
}
