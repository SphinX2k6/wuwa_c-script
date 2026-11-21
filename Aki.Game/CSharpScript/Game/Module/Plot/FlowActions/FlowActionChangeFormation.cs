using System;
using CSharpScript.Game.Module.Plot.Sequence;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004080 RID: 16512
	public class FlowActionChangeFormation : FlowActionServerAction
	{
		// Token: 0x06029DB1 RID: 171441 RVA: 0x00BD5FF4 File Offset: 0x00BD41F4
		protected override void OnExecute()
		{
			if (!PlotModel.Instance.IsInSequencePlot() || !SequenceModel.Instance.IsPlaying)
			{
				Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "禁止在非Seq剧情中使用切编队", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, true);
				return;
			}
			PlotController.Instance.ChangeFormation();
			base.RequestServerAction(false, null);
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DB2 RID: 171442 RVA: 0x00BD6058 File Offset: 0x00BD4258
		protected override void OnBackgroundExecute()
		{
			base.FinishExecute(true, true);
		}
	}
}
