using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006F16 RID: 28438
	[NullableContext(2)]
	public interface ILevelGamePlayPrepareCountDownViewParams
	{
		// Token: 0x17009B01 RID: 39681
		// (get) Token: 0x06045369 RID: 283497
		// (set) Token: 0x0604536A RID: 283498
		int CountDownNum { get; set; }

		// Token: 0x17009B02 RID: 39682
		// (get) Token: 0x0604536B RID: 283499
		// (set) Token: 0x0604536C RID: 283500
		string TidText { get; set; }

		// Token: 0x17009B03 RID: 39683
		// (get) Token: 0x0604536D RID: 283501
		// (set) Token: 0x0604536E RID: 283502
		ECountDownUiStyle? UiStyle { get; set; }
	}
}
