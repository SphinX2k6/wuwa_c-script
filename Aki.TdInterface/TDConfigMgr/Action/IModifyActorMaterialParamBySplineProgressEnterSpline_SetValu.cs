using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE3 RID: 7139
	public class IModifyActorMaterialParamBySplineProgressEnterSpline_SetValue
	{
		// Token: 0x04005D2D RID: 23853
		public EModifyActorMaterialParamBySplineProgressType Type;

		// Token: 0x04005D2E RID: 23854
		public int SplineEntityId;

		// Token: 0x04005D2F RID: 23855
		[Nullable(1)]
		public List<IActorRefWithMaterialParam> ActorRefs;
	}
}
