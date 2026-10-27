using System;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050B2 RID: 20658
	public class FlowActionChangeState : FlowActionBase
	{
		// Token: 0x06034EBD RID: 216765 RVA: 0x00C88E3A File Offset: 0x00C8703A
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

		// Token: 0x06034EBE RID: 216766 RVA: 0x00C88E71 File Offset: 0x00C87071
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
