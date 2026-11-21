using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006097 RID: 24727
	[NullableContext(2)]
	public interface ILevelGamePlayPrepareCountDownViewParams
	{
		// Token: 0x17007040 RID: 28736
		// (get) Token: 0x0603B517 RID: 242967
		// (set) Token: 0x0603B518 RID: 242968
		int CountDownNum { get; set; }

		// Token: 0x17007041 RID: 28737
		// (get) Token: 0x0603B519 RID: 242969
		// (set) Token: 0x0603B51A RID: 242970
		string TidText { get; set; }

		// Token: 0x17007042 RID: 28738
		// (get) Token: 0x0603B51B RID: 242971
		// (set) Token: 0x0603B51C RID: 242972
		ECountDownUiStyle? UiStyle { get; set; }
	}
}
