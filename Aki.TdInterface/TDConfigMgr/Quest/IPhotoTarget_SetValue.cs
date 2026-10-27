using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200104E RID: 4174
	[NullableContext(2)]
	[Nullable(0)]
	public class IPhotoTarget_SetValue
	{
		// Token: 0x0400384C RID: 14412
		public int EntityId;

		// Token: 0x0400384D RID: 14413
		[Nullable(1)]
		public string TidDescription;

		// Token: 0x0400384E RID: 14414
		public bool? IsOptionalTarget;

		// Token: 0x0400384F RID: 14415
		public SetVar SetVar;

		// Token: 0x04003850 RID: 14416
		public string EdTidDescription;
	}
}
