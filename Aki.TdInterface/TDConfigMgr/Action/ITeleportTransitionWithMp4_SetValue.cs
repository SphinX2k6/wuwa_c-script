using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB5 RID: 8117
	public class ITeleportTransitionWithMp4_SetValue
	{
		// Token: 0x04006BCB RID: 27595
		public ETeleportTransitionType Type;

		// Token: 0x04006BCC RID: 27596
		[Nullable(1)]
		public string Mp4Path;

		// Token: 0x04006BCD RID: 27597
		public bool? IsFadeInScreenAfterTeleport;

		// Token: 0x04006BCE RID: 27598
		public bool? ReplayWhenReLogin;

		// Token: 0x04006BCF RID: 27599
		[Nullable(2)]
		public IMp4BackgroundColor BackgroundColor;

		// Token: 0x04006BD0 RID: 27600
		public EAfterTeleportScreenColor? AfterTeleportScreenColor;
	}
}
