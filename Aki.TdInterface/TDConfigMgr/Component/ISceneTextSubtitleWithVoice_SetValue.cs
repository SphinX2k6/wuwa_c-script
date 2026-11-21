using System;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000756 RID: 1878
	public class ISceneTextSubtitleWithVoice_SetValue
	{
		// Token: 0x04001B3B RID: 6971
		public ESceneTextType Type;

		// Token: 0x04001B3C RID: 6972
		public PlayFlow Content;

		// Token: 0x04001B3D RID: 6973
		public int FontSize;

		// Token: 0x04001B3E RID: 6974
		public float BoxWidth;

		// Token: 0x04001B3F RID: 6975
		public float BoxHeight;

		// Token: 0x04001B40 RID: 6976
		public float? Duration;

		// Token: 0x04001B41 RID: 6977
		public bool? AutoHide;

		// Token: 0x04001B42 RID: 6978
		public ESceneTextFadeInEffect? FadeInEffect;

		// Token: 0x04001B43 RID: 6979
		public ESceneTextFadeOutEffect? FadeOutEffect;
	}
}
