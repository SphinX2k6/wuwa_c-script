using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005ABC RID: 23228
	public class ActionCaptureRequest : ActionParams
	{
		// Token: 0x0401E1CD RID: 123341
		[Nullable(2)]
		public ActionSendGameplayEvent SuccessEvent;
	}
}
