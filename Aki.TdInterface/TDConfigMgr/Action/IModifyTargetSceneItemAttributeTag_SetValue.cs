using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DDE RID: 7646
	public class IModifyTargetSceneItemAttributeTag_SetValue
	{
		// Token: 0x0400626D RID: 25197
		public EChangeEntityPrefabPerformanceType Type;

		// Token: 0x0400626E RID: 25198
		public bool IsAddTag;

		// Token: 0x0400626F RID: 25199
		public List<int> PerformanceTag;

		// Token: 0x04006270 RID: 25200
		public List<int> EntityIds;
	}
}
