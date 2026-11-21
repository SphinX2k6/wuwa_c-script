using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.GenericPrompt;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C93 RID: 23699
	public class LevelEventEndPrompt : LevelEventBase
	{
		// Token: 0x0603A205 RID: 238085 RVA: 0x0106372F File Offset: 0x0106192F
		public LevelEventEndPrompt(int id) : base(id)
		{
		}

		// Token: 0x0603A206 RID: 238086 RVA: 0x01063738 File Offset: 0x01061938
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			EndCommonTip endCommonTip = inParams as EndCommonTip;
			if (endCommonTip == null)
			{
				return;
			}
			GenericPromptController.CancelPromptByPromptKey(endCommonTip.Token);
		}
	}
}
