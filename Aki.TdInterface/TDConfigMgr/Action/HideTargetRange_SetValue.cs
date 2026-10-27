using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001747 RID: 5959
	public class HideTargetRange_SetValue
	{
		// Token: 0x0400505D RID: 20573
		public int RangeEntity;

		// Token: 0x0400505E RID: 20574
		[Nullable(1)]
		public IHideRangeType HideConfig;

		// Token: 0x0400505F RID: 20575
		public bool? IsHideSimpleNpc;

		// Token: 0x04005060 RID: 20576
		public bool? IsHidePasserByNpc;
	}
}
