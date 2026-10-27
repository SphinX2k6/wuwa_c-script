using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E0A RID: 28170
	public class GuaranteeFadeInParams : ActionParams, IGuaranteeFadeInParams
	{
		// Token: 0x170099F5 RID: 39413
		// (get) Token: 0x06044B4F RID: 281423 RVA: 0x010F540E File Offset: 0x010F360E
		// (set) Token: 0x06044B50 RID: 281424 RVA: 0x010F5416 File Offset: 0x010F3616
		public bool? KeepFadeAfterTreeRollBack { get; set; }
	}
}
