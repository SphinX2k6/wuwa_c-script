using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F8 RID: 8696
	public class ITeleportTransitionWithMp4_SetValue
	{
		// Token: 0x040071C6 RID: 29126
		public ETeleportTransitionType Type;

		// Token: 0x040071C7 RID: 29127
		public string Mp4Path;

		// Token: 0x040071C8 RID: 29128
		public bool? IsFadeInScreenAfterTeleport;

		// Token: 0x040071C9 RID: 29129
		public bool? ReplayWhenReLogin;

		// Token: 0x040071CA RID: 29130
		[Nullable(2)]
		public IMp4BackgroundColor BackgroundColor;

		// Token: 0x040071CB RID: 29131
		public EAfterTeleportScreenColor? AfterTeleportScreenColor;
	}
}
