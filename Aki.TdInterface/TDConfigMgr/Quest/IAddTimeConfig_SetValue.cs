using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EBB RID: 3771
	public class IAddTimeConfig_SetValue
	{
		// Token: 0x0400326B RID: 12907
		[Nullable(2)]
		public IKillMonster MonsterConfig;

		// Token: 0x0400326C RID: 12908
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAddTimeStateCondition> StateConfig;
	}
}
