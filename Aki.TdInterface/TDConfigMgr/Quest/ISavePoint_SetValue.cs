using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001255 RID: 4693
	public class ISavePoint_SetValue
	{
		// Token: 0x04003EB8 RID: 16056
		public ESaveConfig Type;

		// Token: 0x04003EB9 RID: 16057
		public bool? RelinkRollback;

		// Token: 0x04003EBA RID: 16058
		[Nullable(2)]
		public IPositionRollbackConfig PosRollbackCfg;
	}
}
