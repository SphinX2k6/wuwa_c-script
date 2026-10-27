using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FA9 RID: 28585
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowWaitPlotEnd : LevelFlowActionBase
	{
		// Token: 0x060457A0 RID: 284576 RVA: 0x0113C3F2 File Offset: 0x0113A5F2
		public LevelFlowWaitPlotEnd Init(string flowListName, int flowId, int stateId)
		{
			this.FlowListName = flowListName;
			this.FlowId = flowId;
			this.StateId = stateId;
			return this;
		}

		// Token: 0x060457A1 RID: 284577 RVA: 0x0113C40A File Offset: 0x0113A60A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		}

		// Token: 0x060457A2 RID: 284578 RVA: 0x0113C428 File Offset: 0x0113A628
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		}

		// Token: 0x060457A3 RID: 284579 RVA: 0x0113C448 File Offset: 0x0113A648
		private void OnPlotNetworkEnd(PlotResultInfo plotResult)
		{
			if (plotResult.FlowListName == this.FlowListName)
			{
				int? num = plotResult.FlowId;
				int num2 = this.FlowId;
				if (num.GetValueOrDefault() == num2 & num != null)
				{
					num = plotResult.StateId;
					num2 = this.StateId;
					if (num.GetValueOrDefault() == num2 & num != null)
					{
						base.FinishExecute(true);
					}
				}
			}
		}

		// Token: 0x04024404 RID: 148484
		private string FlowListName = string.Empty;

		// Token: 0x04024405 RID: 148485
		private int FlowId;

		// Token: 0x04024406 RID: 148486
		private int StateId;
	}
}
