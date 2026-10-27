using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BEF RID: 7151
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyTargetSceneItemAttributeTag_SetValue
	{
		// Token: 0x04005D47 RID: 23879
		public EChangeEntityPrefabPerformanceType Type;

		// Token: 0x04005D48 RID: 23880
		public bool IsAddTag;

		// Token: 0x04005D49 RID: 23881
		public List<int> PerformanceTag;

		// Token: 0x04005D4A RID: 23882
		public List<int> EntityIds;
	}
}
