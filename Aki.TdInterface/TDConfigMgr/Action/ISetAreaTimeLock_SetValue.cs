using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002042 RID: 8258
	public class ISetAreaTimeLock_SetValue
	{
		// Token: 0x04006864 RID: 26724
		public ESetAreaTime Type;

		// Token: 0x04006865 RID: 26725
		public List<int> AreaIds;

		// Token: 0x04006866 RID: 26726
		public IFixedTime LockTime;
	}
}
