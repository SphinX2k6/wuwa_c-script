using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014AA RID: 5290
	public class AwakeEntity_SetValue
	{
		// Token: 0x04004600 RID: 17920
		[Nullable(2)]
		public IAwakeWithTransformVar Position;

		// Token: 0x04004601 RID: 17921
		public bool? IsSnap;

		// Token: 0x04004602 RID: 17922
		[Nullable(1)]
		public List<int> EntityIds;
	}
}
