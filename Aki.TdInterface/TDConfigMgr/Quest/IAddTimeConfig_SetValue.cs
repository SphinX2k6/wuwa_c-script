using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD1 RID: 4049
	public class IAddTimeConfig_SetValue
	{
		// Token: 0x04003578 RID: 13688
		[Nullable(2)]
		public IKillMonster MonsterConfig;

		// Token: 0x04003579 RID: 13689
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IAddTimeStateCondition> StateConfig;
	}
}
