using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050D9 RID: 20697
	public class FlowActionShowTalk : FlowActionBase
	{
		// Token: 0x06034F5C RID: 216924 RVA: 0x00C8B9CC File Offset: 0x00C89BCC
		protected override void OnExecute()
		{
			this.Context.CurShowTalk = (this.ActionInfo.Params as ShowTalk);
			this.Context.CurShowTalkActionId = this.ActionInfo.ActionId.GetValueOrDefault();
			this.Context.OptionsHistory[this.Context.CurShowTalkActionId] = new Dictionary<int, int>();
			this.Context.OptionsCollection.Add(new ValueTuple<int, List<ValueTuple<int, int>>>(this.Context.CurShowTalkActionId, new List<ValueTuple<int, int>>
			{
				Capacity = 0
			}));
			switch (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault())
			{
			case EPlotLevel.LevelA:
			case EPlotLevel.LevelB:
			case EPlotLevel.ControlEntity:
				this.OnExecuteSequenceTalk();
				return;
			case EPlotLevel.LevelC:
				this.OnExecuteNormalTalk();
				return;
			case EPlotLevel.LevelD:
			case EPlotLevel.LevelE:
				if (FormationDataController.Instance.GlobalIsInFight && PlotModel.Instance.PlotConfig.SkipTalkWhenFighting)
				{
					base.FinishExecute(true, true);
					return;
				}
				this.OnExecuteNormalTalk();
				break;
			case EPlotLevel.Prompt:
				break;
			default:
				return;
			}
		}

		// Token: 0x06034F5D RID: 216925 RVA: 0x00C8BAD0 File Offset: 0x00C89CD0
		private void OnExecuteNormalTalk()
		{
			ShowTalk inShowTalk = this.ActionInfo.Params as ShowTalk;
			FlowContext context = this.Context;
			FlowActionRunner runner = this.Runner;
			base.FinishExecute(true, false);
			runner.FlowShowTalk.Start(inShowTalk, context);
		}

		// Token: 0x06034F5E RID: 216926 RVA: 0x00C8BB10 File Offset: 0x00C89D10
		private void OnExecuteSequenceTalk()
		{
			ShowTalk showTalk = this.ActionInfo.Params as ShowTalk;
			if (showTalk == null || showTalk.SequenceDataAsset == null)
			{
				base.FinishExecute(true, true);
				return;
			}
			FlowActionRunner runner = this.Runner;
			FlowContext context = this.Context;
			bool seamlessPlot = this.Context.SeamlessPlot;
			base.FinishExecute(true, false);
			runner.FlowSequence.Init(showTalk, context);
			runner.FlowSequence.Start(seamlessPlot);
		}

		// Token: 0x06034F5F RID: 216927 RVA: 0x00C8BB7B File Offset: 0x00C89D7B
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
