using System;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004082 RID: 16514
	public class FlowActionChangeState : FlowActionBase
	{
		// Token: 0x06029DB6 RID: 171446 RVA: 0x00BD60F6 File Offset: 0x00BD42F6
		protected override void OnExecute()
		{
			this.Context.IsBreakdown = true;
			if (this.Context.CurShowTalk != null)
			{
				FlowActionRunner runner = this.Runner;
				base.FinishExecute(true, false);
				runner.FinishTalk();
				return;
			}
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DB7 RID: 171447 RVA: 0x00BD612D File Offset: 0x00BD432D
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
