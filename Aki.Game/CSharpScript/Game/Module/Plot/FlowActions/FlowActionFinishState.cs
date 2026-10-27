using System;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050B9 RID: 20665
	public class FlowActionFinishState : FlowActionBase
	{
		// Token: 0x06034ED6 RID: 216790 RVA: 0x00C896E8 File Offset: 0x00C878E8
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

		// Token: 0x06034ED7 RID: 216791 RVA: 0x00C8971F File Offset: 0x00C8791F
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
