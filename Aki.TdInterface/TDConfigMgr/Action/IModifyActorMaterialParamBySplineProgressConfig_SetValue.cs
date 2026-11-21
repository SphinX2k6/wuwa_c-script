using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DCE RID: 7630
	public class IModifyActorMaterialParamBySplineProgressConfig_SetValue
	{
		// Token: 0x04006247 RID: 25159
		public EModifyActorMaterialParamBySplineProgressType Type;

		// Token: 0x04006248 RID: 25160
		[Nullable(2)]
		public IModifyActorMaterialParamBySplineProgressTarget MoveTarget;

		// Token: 0x04006249 RID: 25161
		public int SplineEntityId;
	}
}
