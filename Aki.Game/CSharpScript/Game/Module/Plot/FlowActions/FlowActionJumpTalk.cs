using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050BE RID: 20670
	public class FlowActionJumpTalk : FlowActionBase
	{
		// Token: 0x06034EE5 RID: 216805 RVA: 0x00C898C4 File Offset: 0x00C87AC4
		protected override void OnExecute()
		{
			JumpTalk jumpTalk = this.ActionInfo.Params as JumpTalk;
			FlowActionRunner runner = this.Runner;
			base.FinishExecute(true, false);
			runner.JumpTalk(jumpTalk.TalkId);
		}

		// Token: 0x06034EE6 RID: 216806 RVA: 0x00C898FB File Offset: 0x00C87AFB
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
