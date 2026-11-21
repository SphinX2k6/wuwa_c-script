using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004099 RID: 16537
	public class FlowActionPlaySequenceData : FlowActionBase
	{
		// Token: 0x06029E05 RID: 171525 RVA: 0x00BD7450 File Offset: 0x00BD5650
		protected override void OnExecute()
		{
			PlaySequenceData playSequenceData = this.ActionInfo.Params as PlaySequenceData;
			if (playSequenceData == null || StringUtils.IsEmpty(playSequenceData.Path))
			{
				FlowController.Instance.LogError("SequenceData路径为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, true);
				return;
			}
			EPlotLevel? plotLevel = PlotModel.Instance.PlotConfig.PlotLevel;
			EPlotLevel? eplotLevel = plotLevel;
			EPlotLevel eplotLevel2 = EPlotLevel.LevelA;
			if ((eplotLevel.GetValueOrDefault() == eplotLevel2 & eplotLevel != null) || plotLevel.GetValueOrDefault() == EPlotLevel.ControlEntity)
			{
				SequenceModel.Instance.Type = new EPlotSequenceType?(EPlotSequenceType.过场);
			}
			else if (plotLevel.GetValueOrDefault() == EPlotLevel.LevelB)
			{
				SequenceModel.Instance.Type = new EPlotSequenceType?(EPlotSequenceType.站桩);
			}
			if (!this.Context.IsBackground)
			{
				EventSystem.Instance.Once<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart));
				SequenceController.Instance.Play(playSequenceData, new List<string>(), new Action<bool>(this.OnSequenceFinish), false);
				return;
			}
			SequenceController.Instance.LoadData(playSequenceData, delegate
			{
				this.SkipPromise().ContinueWith(delegate()
				{
					base.FinishExecute(true, true);
				}).Forget();
			});
		}

		// Token: 0x06029E06 RID: 171526 RVA: 0x00BD755D File Offset: 0x00BD575D
		private void OnSequenceStart(float _)
		{
			FlowController.Instance.EnableSkip(true);
		}

		// Token: 0x06029E07 RID: 171527 RVA: 0x00BD756C File Offset: 0x00BD576C
		private void OnSequenceFinish(bool state)
		{
			FlowController.Instance.EnableSkip(false);
			if (EventSystem.Instance.Has<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart)))
			{
				EventSystem.Instance.Remove<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart));
			}
			base.FinishExecute(true, true);
		}

		// Token: 0x06029E08 RID: 171528 RVA: 0x00BD75C8 File Offset: 0x00BD57C8
		protected override void OnInterruptExecute()
		{
			FlowController.Instance.EnableSkip(false);
			if (EventSystem.Instance.Has<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart)))
			{
				EventSystem.Instance.Remove<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart));
			}
			this.SkipPromise().ContinueWith(delegate()
			{
				base.FinishExecute(true, true);
			}).Forget();
		}

		// Token: 0x06029E09 RID: 171529 RVA: 0x00BD7635 File Offset: 0x00BD5835
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06029E0A RID: 171530 RVA: 0x00BD7640 File Offset: 0x00BD5840
		private UniTask SkipPromise()
		{
			FlowActionPlaySequenceData.<SkipPromise>d__5 <SkipPromise>d__;
			<SkipPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SkipPromise>d__.<>4__this = this;
			<SkipPromise>d__.<>1__state = -1;
			<SkipPromise>d__.<>t__builder.Start<FlowActionPlaySequenceData.<SkipPromise>d__5>(ref <SkipPromise>d__);
			return <SkipPromise>d__.<>t__builder.Task;
		}
	}
}
