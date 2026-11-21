using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B68 RID: 7016
	public class IEnableAlertArea_SetValue
	{
		// Token: 0x04005C57 RID: 23639
		public EAlertSystemOption Type;

		// Token: 0x04005C58 RID: 23640
		public int AreaId;

		// Token: 0x04005C59 RID: 23641
		public bool IsEnable;

		// Token: 0x04005C5A RID: 23642
		[Nullable(2)]
		public IDisableAlertAreaCondition AutoDisableCondition;
	}
}
