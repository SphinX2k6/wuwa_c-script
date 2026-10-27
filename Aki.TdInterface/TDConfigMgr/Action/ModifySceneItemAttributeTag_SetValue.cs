using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020DA RID: 8410
	public class ModifySceneItemAttributeTag_SetValue
	{
		// Token: 0x04006EB0 RID: 28336
		public EChangeEntityPrefabPerformanceType Type;

		// Token: 0x04006EB1 RID: 28337
		public bool IsAddTag;

		// Token: 0x04006EB2 RID: 28338
		[Nullable(1)]
		public List<int> PerformanceTag;
	}
}
