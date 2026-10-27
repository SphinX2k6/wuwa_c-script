using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001127 RID: 4391
	public class ISavePoint_SetValue
	{
		// Token: 0x04003B6A RID: 15210
		public ESaveConfig Type;

		// Token: 0x04003B6B RID: 15211
		public bool? RelinkRollback;

		// Token: 0x04003B6C RID: 15212
		[Nullable(2)]
		public IPositionRollbackConfig PosRollbackCfg;
	}
}
