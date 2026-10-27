using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200075B RID: 1883
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemFoundation_SetValue
	{
		// Token: 0x04001B50 RID: 6992
		public bool? Disabled;

		// Token: 0x04001B51 RID: 6993
		public bool? EdIsLocked;

		// Token: 0x04001B52 RID: 6994
		public IAdsortTransform AdsorptionPoint;

		// Token: 0x04001B53 RID: 6995
		public IEntityMatch AdsorptionMatch;

		// Token: 0x04001B54 RID: 6996
		public IEntityMatch ActiveMatch;

		// Token: 0x04001B55 RID: 6997
		public bool IsSilent;

		// Token: 0x04001B56 RID: 6998
		public bool IsDestroy;

		// Token: 0x04001B57 RID: 6999
		[Nullable(2)]
		public IItemChangeAdsorbateState ChangeAdsorbateState;
	}
}
