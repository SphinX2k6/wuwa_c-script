using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001643 RID: 5699
	public class EnableLevelPlay_SetValue
	{
		// Token: 0x04004C6E RID: 19566
		[Nullable(1)]
		public List<IEnableLevelPlayConfig> Configs;

		// Token: 0x04004C6F RID: 19567
		public EPlayerType? TargetPlayer;
	}
}
