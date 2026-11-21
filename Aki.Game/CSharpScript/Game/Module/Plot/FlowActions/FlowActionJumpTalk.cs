using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200408E RID: 16526
	public class FlowActionJumpTalk : FlowActionBase
	{
		// Token: 0x06029DDE RID: 171486 RVA: 0x00BD6BAC File Offset: 0x00BD4DAC
		protected override void OnExecute()
		{
			JumpTalk jumpTalk = this.ActionInfo.Params as JumpTalk;
			FlowActionRunner runner = this.Runner;
			base.FinishExecute(true, false);
			runner.JumpTalk(jumpTalk.TalkId);
		}

		// Token: 0x06029DDF RID: 171487 RVA: 0x00BD6BE3 File Offset: 0x00BD4DE3
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
