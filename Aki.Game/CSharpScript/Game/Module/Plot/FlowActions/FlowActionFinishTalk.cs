using System;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050BA RID: 20666
	public class FlowActionFinishTalk : FlowActionBase
	{
		// Token: 0x06034ED9 RID: 216793 RVA: 0x00C8972F File Offset: 0x00C8792F
		protected override void OnExecute()
		{
			FlowActionRunner runner = this.Runner;
			base.FinishExecute(true, false);
			runner.FinishTalk();
		}

		// Token: 0x06034EDA RID: 216794 RVA: 0x00C89744 File Offset: 0x00C87944
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
