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
	// Token: 0x020050C9 RID: 20681
	public class FlowActionPlaySequenceData : FlowActionBase
	{
		// Token: 0x06034F0C RID: 216844 RVA: 0x00C8A168 File Offset: 0x00C88368
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

		// Token: 0x06034F0D RID: 216845 RVA: 0x00C8A275 File Offset: 0x00C88475
		private void OnSequenceStart(float _)
		{
			FlowController.Instance.EnableSkip(true);
		}

		// Token: 0x06034F0E RID: 216846 RVA: 0x00C8A284 File Offset: 0x00C88484
		private void OnSequenceFinish(bool state)
		{
			FlowController.Instance.EnableSkip(false);
			if (EventSystem.Instance.Has<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart)))
			{
				EventSystem.Instance.Remove<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart));
			}
			base.FinishExecute(true, true);
		}

		// Token: 0x06034F0F RID: 216847 RVA: 0x00C8A2E0 File Offset: 0x00C884E0
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

		// Token: 0x06034F10 RID: 216848 RVA: 0x00C8A34D File Offset: 0x00C8854D
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06034F11 RID: 216849 RVA: 0x00C8A358 File Offset: 0x00C88558
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
