using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007FC RID: 2044
	public class ItemFoundation_SetValue
	{
		// Token: 0x04001D55 RID: 7509
		public bool? Disabled;

		// Token: 0x04001D56 RID: 7510
		public bool? EdIsLocked;

		// Token: 0x04001D57 RID: 7511
		public IAdsortTransform AdsorptionPoint;

		// Token: 0x04001D58 RID: 7512
		public IEntityMatch AdsorptionMatch;

		// Token: 0x04001D59 RID: 7513
		public IEntityMatch ActiveMatch;

		// Token: 0x04001D5A RID: 7514
		public bool IsSilent;

		// Token: 0x04001D5B RID: 7515
		public bool IsDestroy;

		// Token: 0x04001D5C RID: 7516
		[Nullable(2)]
		public IItemChangeAdsorbateState ChangeAdsorbateState;
	}
}
