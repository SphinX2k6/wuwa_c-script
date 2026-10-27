using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000657 RID: 1623
	public class IRandomPoolChoose_SetValue
	{
		// Token: 0x0400181E RID: 6174
		public EMonsterChooseType Type;

		// Token: 0x0400181F RID: 6175
		[Nullable(1)]
		public List<IRandomPoolConfig> RandomPoolConfigs;
	}
}
