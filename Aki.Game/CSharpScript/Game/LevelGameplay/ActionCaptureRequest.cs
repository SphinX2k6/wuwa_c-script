using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006961 RID: 26977
	public class ActionCaptureRequest : ActionParams
	{
		// Token: 0x04022FE3 RID: 143331
		[Nullable(2)]
		public ActionSendGameplayEvent SuccessEvent;
	}
}
