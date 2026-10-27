using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B5 RID: 1717
	public class ISceneTextSubtitleWithVoice_SetValue
	{
		// Token: 0x0400193E RID: 6462
		public ESceneTextType Type;

		// Token: 0x0400193F RID: 6463
		[Nullable(1)]
		public PlayFlow Content;

		// Token: 0x04001940 RID: 6464
		public int FontSize;

		// Token: 0x04001941 RID: 6465
		public float BoxWidth;

		// Token: 0x04001942 RID: 6466
		public float BoxHeight;

		// Token: 0x04001943 RID: 6467
		public float? Duration;

		// Token: 0x04001944 RID: 6468
		public bool? AutoHide;
	}
}
