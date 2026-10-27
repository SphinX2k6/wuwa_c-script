using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DDD RID: 7645
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneInspection_SetValue
	{
		// Token: 0x0400621A RID: 25114
		public ESimpleGameplayType Type;

		// Token: 0x0400621B RID: 25115
		public string SaveVarName;

		// Token: 0x0400621C RID: 25116
		public List<ISceneInspectionPoint> InteractPoints;
	}
}
