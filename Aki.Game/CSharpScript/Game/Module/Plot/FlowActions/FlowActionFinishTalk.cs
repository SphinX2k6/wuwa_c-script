using System;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200408A RID: 16522
	public class FlowActionFinishTalk : FlowActionBase
	{
		// Token: 0x06029DD2 RID: 171474 RVA: 0x00BD6A17 File Offset: 0x00BD4C17
		protected override void OnExecute()
		{
			FlowActionRunner runner = this.Runner;
			base.FinishExecute(true, false);
			runner.FinishTalk();
		}

		// Token: 0x06029DD3 RID: 171475 RVA: 0x00BD6A2C File Offset: 0x00BD4C2C
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
