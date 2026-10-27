using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221D RID: 8733
	[NullableContext(1)]
	[Nullable(0)]
	public class StartRoadNetworkNavigation_SetValue
	{
		// Token: 0x04007259 RID: 29273
		public ISceneItemRoadNetworkNavigation Target;

		// Token: 0x0400725A RID: 29274
		public ISplineWayPoint Start;

		// Token: 0x0400725B RID: 29275
		public ISplineWayPoint End;
	}
}
