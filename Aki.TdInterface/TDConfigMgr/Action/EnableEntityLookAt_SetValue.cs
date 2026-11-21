using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A6 RID: 6054
	public class EnableEntityLookAt_SetValue
	{
		// Token: 0x04005048 RID: 20552
		public string Key;

		// Token: 0x04005049 RID: 20553
		public IDefaultLookAtType DefaultLookAtType;

		// Token: 0x0400504A RID: 20554
		[Nullable(2)]
		public ICheckFlowLookAt OverrideLookAtType;

		// Token: 0x0400504B RID: 20555
		public List<int> EntityIds;
	}
}
