using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A96 RID: 6806
	public class ICommonTip2PrepareCountdown_SetValue
	{
		// Token: 0x04005A6A RID: 23146
		public ECommonTip2Type Type;

		// Token: 0x04005A6B RID: 23147
		public int CountDownNum;

		// Token: 0x04005A6C RID: 23148
		public string TidCountDownTxt;

		// Token: 0x04005A6D RID: 23149
		public ECountDownUiStyle? UiStyle;

		// Token: 0x04005A6E RID: 23150
		public bool? IsBlockPlayer;

		// Token: 0x04005A6F RID: 23151
		[Nullable(2)]
		public string EdTidCountDownTxt;
	}
}
