using System;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004097 RID: 16535
	public class FlowActionPhoneSystemInteract : FlowActionLevelAsyncAction
	{
		// Token: 0x06029DFD RID: 171517 RVA: 0x00BD726C File Offset: 0x00BD546C
		protected override void OnExecute()
		{
			EPlotLevel? plotLevel = PlotModel.Instance.PlotConfig.PlotLevel;
			EPlotLevel? eplotLevel = plotLevel;
			EPlotLevel eplotLevel2 = EPlotLevel.LevelA;
			if (!(eplotLevel.GetValueOrDefault() == eplotLevel2 & eplotLevel != null) && plotLevel.GetValueOrDefault() != EPlotLevel.LevelB && plotLevel.GetValueOrDefault() != EPlotLevel.LevelC)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "PhoneSystemInteract只允许在剧情A/B/C级别中执行";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlotLevel", plotLevel);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false, true);
				return;
			}
			if (SequenceModel.Instance.IsPlaying)
			{
				FlowController.Instance.EnableSkip(false);
			}
			base.OnExecute();
		}

		// Token: 0x06029DFE RID: 171518 RVA: 0x00BD7307 File Offset: 0x00BD5507
		protected override void OnBackgroundExecute()
		{
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DFF RID: 171519 RVA: 0x00BD7311 File Offset: 0x00BD5511
		protected override void OnActionFinish(bool result)
		{
			if (SequenceModel.Instance.IsPlaying)
			{
				FlowController.Instance.EnableSkip(true);
			}
			base.FinishExecute(true, true);
		}
	}
}
