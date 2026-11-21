using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040A9 RID: 16553
	public class FlowActionShowTalk : FlowActionBase
	{
		// Token: 0x06029E55 RID: 171605 RVA: 0x00BD8CB4 File Offset: 0x00BD6EB4
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

		// Token: 0x06029E56 RID: 171606 RVA: 0x00BD8DB8 File Offset: 0x00BD6FB8
		private void OnExecuteNormalTalk()
		{
			ShowTalk inShowTalk = this.ActionInfo.Params as ShowTalk;
			FlowContext context = this.Context;
			FlowActionRunner runner = this.Runner;
			base.FinishExecute(true, false);
			runner.FlowShowTalk.Start(inShowTalk, context);
		}

		// Token: 0x06029E57 RID: 171607 RVA: 0x00BD8DF8 File Offset: 0x00BD6FF8
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

		// Token: 0x06029E58 RID: 171608 RVA: 0x00BD8E63 File Offset: 0x00BD7063
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
