using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD0 RID: 7632
	public class IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue
	{
		// Token: 0x0400624E RID: 25166
		public EModifyActorMaterialParamBySplineProgressType Type;

		// Token: 0x0400624F RID: 25167
		[Nullable(2)]
		public IModifyActorMaterialParamBySplineProgressTarget MoveTarget;

		// Token: 0x04006250 RID: 25168
		public int SplineEntityId;

		// Token: 0x04006251 RID: 25169
		public List<IActorRefWithMaterialParam> ActorRefs;
	}
}
