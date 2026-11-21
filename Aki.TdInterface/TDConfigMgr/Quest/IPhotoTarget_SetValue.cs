using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200117C RID: 4476
	public class IPhotoTarget_SetValue
	{
		// Token: 0x04003B94 RID: 15252
		public int EntityId;

		// Token: 0x04003B95 RID: 15253
		public string TidDescription;

		// Token: 0x04003B96 RID: 15254
		public bool? IsOptionalTarget;

		// Token: 0x04003B97 RID: 15255
		[Nullable(2)]
		public SetVar SetVar;

		// Token: 0x04003B98 RID: 15256
		[Nullable(2)]
		public string EdTidDescription;
	}
}
