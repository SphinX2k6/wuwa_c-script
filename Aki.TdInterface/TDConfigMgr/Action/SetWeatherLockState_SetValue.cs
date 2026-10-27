using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F2 RID: 8690
	public class SetWeatherLockState_SetValue
	{
		// Token: 0x040071D5 RID: 29141
		public ELockState LockState;

		// Token: 0x040071D6 RID: 29142
		[Nullable(2)]
		public List<int> AreaIds;
	}
}
