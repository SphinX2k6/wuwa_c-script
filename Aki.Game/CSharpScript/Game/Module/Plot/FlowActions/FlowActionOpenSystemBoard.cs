using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.Sequence;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C6 RID: 20678
	public class FlowActionOpenSystemBoard : FlowActionLevelAsyncAction
	{
		// Token: 0x06034F00 RID: 216832 RVA: 0x00C89F1D File Offset: 0x00C8811D
		protected override void OnExecute()
		{
			if (SequenceModel.Instance.IsPlaying)
			{
				PlotController.Instance.PlotViewManager.EnableSkipPlotByReason(false, "OpenSystemBoard");
			}
			base.OnExecute();
		}

		// Token: 0x06034F01 RID: 216833 RVA: 0x00C89F46 File Offset: 0x00C88146
		protected override void OnBackgroundExecute()
		{
			base.FinishExecute(true, true);
		}

		// Token: 0x06034F02 RID: 216834 RVA: 0x00C89F50 File Offset: 0x00C88150
		protected override void OnActionFinish(bool result)
		{
			if (SequenceModel.Instance.IsPlaying)
			{
				PlotController.Instance.PlotViewManager.EnableSkipPlotByReason(true, "OpenSystemBoard");
			}
			base.FinishExecute(true, true);
		}

		// Token: 0x0401C309 RID: 115465
		[Nullable(1)]
		private const string EnableSkipReason = "OpenSystemBoard";
	}
}
