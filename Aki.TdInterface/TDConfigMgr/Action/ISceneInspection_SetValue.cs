using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF6 RID: 8182
	public class ISceneInspection_SetValue
	{
		// Token: 0x040067A7 RID: 26535
		public ESimpleGameplayType Type;

		// Token: 0x040067A8 RID: 26536
		public string SaveVarName;

		// Token: 0x040067A9 RID: 26537
		public List<ISceneInspectionPoint> InteractPoints;
	}
}
