using System;
using CSharpScript.Game.Module.Plot.Sequence;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050B0 RID: 20656
	public class FlowActionChangeFormation : FlowActionServerAction
	{
		// Token: 0x06034EB8 RID: 216760 RVA: 0x00C88D38 File Offset: 0x00C86F38
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

		// Token: 0x06034EB9 RID: 216761 RVA: 0x00C88D9C File Offset: 0x00C86F9C
		protected override void OnBackgroundExecute()
		{
			base.FinishExecute(true, true);
		}
	}
}
