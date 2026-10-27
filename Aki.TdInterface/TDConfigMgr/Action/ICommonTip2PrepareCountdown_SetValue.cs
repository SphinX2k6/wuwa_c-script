using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200190D RID: 6413
	public class ICommonTip2PrepareCountdown_SetValue
	{
		// Token: 0x0400561A RID: 22042
		public ECommonTip2Type Type;

		// Token: 0x0400561B RID: 22043
		public int CountDownNum;

		// Token: 0x0400561C RID: 22044
		[Nullable(1)]
		public string TidCountDownTxt;

		// Token: 0x0400561D RID: 22045
		public ECountDownUiStyle? UiStyle;

		// Token: 0x0400561E RID: 22046
		public bool? IsBlockPlayer;

		// Token: 0x0400561F RID: 22047
		[Nullable(2)]
		public string EdTidCountDownTxt;
	}
}
