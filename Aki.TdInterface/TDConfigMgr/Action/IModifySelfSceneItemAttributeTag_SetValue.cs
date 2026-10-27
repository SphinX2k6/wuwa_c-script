using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BED RID: 7149
	public class IModifySelfSceneItemAttributeTag_SetValue
	{
		// Token: 0x04005D42 RID: 23874
		public EChangeEntityPrefabPerformanceType Type;

		// Token: 0x04005D43 RID: 23875
		public bool IsAddTag;

		// Token: 0x04005D44 RID: 23876
		[Nullable(1)]
		public List<int> PerformanceTag;
	}
}
