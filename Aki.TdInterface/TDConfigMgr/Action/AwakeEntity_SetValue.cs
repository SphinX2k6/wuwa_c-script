using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001603 RID: 5635
	public class AwakeEntity_SetValue
	{
		// Token: 0x0400499B RID: 18843
		[Nullable(2)]
		public IAwakeWithTransformVar Position;

		// Token: 0x0400499C RID: 18844
		public bool? IsSnap;

		// Token: 0x0400499D RID: 18845
		public List<int> EntityIds;
	}
}
