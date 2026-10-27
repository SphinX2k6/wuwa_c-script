using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019DB RID: 6619
	public class IEnableAlertArea_SetValue
	{
		// Token: 0x04005802 RID: 22530
		public EAlertSystemOption Type;

		// Token: 0x04005803 RID: 22531
		public int AreaId;

		// Token: 0x04005804 RID: 22532
		public bool IsEnable;

		// Token: 0x04005805 RID: 22533
		[Nullable(2)]
		public IDisableAlertAreaCondition AutoDisableCondition;
	}
}
