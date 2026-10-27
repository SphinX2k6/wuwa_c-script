using System;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C7 RID: 20679
	public class FlowActionPhoneSystemInteract : FlowActionLevelAsyncAction
	{
		// Token: 0x06034F04 RID: 216836 RVA: 0x00C89F84 File Offset: 0x00C88184
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

		// Token: 0x06034F05 RID: 216837 RVA: 0x00C8A01F File Offset: 0x00C8821F
		protected override void OnBackgroundExecute()
		{
			base.FinishExecute(true, true);
		}

		// Token: 0x06034F06 RID: 216838 RVA: 0x00C8A029 File Offset: 0x00C88229
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
