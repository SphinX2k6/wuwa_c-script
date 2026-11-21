using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.Sequence;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004096 RID: 16534
	public class FlowActionOpenSystemBoard : FlowActionLevelAsyncAction
	{
		// Token: 0x06029DF9 RID: 171513 RVA: 0x00BD7205 File Offset: 0x00BD5405
		protected override void OnExecute()
		{
			if (SequenceModel.Instance.IsPlaying)
			{
				PlotController.Instance.PlotViewManager.EnableSkipPlotByReason(false, "OpenSystemBoard");
			}
			base.OnExecute();
		}

		// Token: 0x06029DFA RID: 171514 RVA: 0x00BD722E File Offset: 0x00BD542E
		protected override void OnBackgroundExecute()
		{
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DFB RID: 171515 RVA: 0x00BD7238 File Offset: 0x00BD5438
		protected override void OnActionFinish(bool result)
		{
			if (SequenceModel.Instance.IsPlaying)
			{
				PlotController.Instance.PlotViewManager.EnableSkipPlotByReason(true, "OpenSystemBoard");
			}
			base.FinishExecute(true, true);
		}

		// Token: 0x04016D3A RID: 93498
		[Nullable(1)]
		private const string EnableSkipReason = "OpenSystemBoard";
	}
}
