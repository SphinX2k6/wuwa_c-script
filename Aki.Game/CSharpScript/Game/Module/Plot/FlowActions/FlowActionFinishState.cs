using System;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004089 RID: 16521
	public class FlowActionFinishState : FlowActionBase
	{
		// Token: 0x06029DCF RID: 171471 RVA: 0x00BD69D0 File Offset: 0x00BD4BD0
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

		// Token: 0x06029DD0 RID: 171472 RVA: 0x00BD6A07 File Offset: 0x00BD4C07
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
