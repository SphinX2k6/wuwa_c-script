using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245D RID: 9309
	public class SetWeatherLockState_SetValue
	{
		// Token: 0x0400781E RID: 30750
		public ELockState LockState;

		// Token: 0x0400781F RID: 30751
		[Nullable(2)]
		public List<int> AreaIds;
	}
}
