using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.GenericPrompt;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B1B RID: 27419
	public class LevelEventEndPrompt : LevelEventBase
	{
		// Token: 0x060440B3 RID: 278707 RVA: 0x010B9EA3 File Offset: 0x010B80A3
		public LevelEventEndPrompt(int id) : base(id)
		{
		}

		// Token: 0x060440B4 RID: 278708 RVA: 0x010B9EAC File Offset: 0x010B80AC
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
