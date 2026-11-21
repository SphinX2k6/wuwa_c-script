using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200612A RID: 24874
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowWaitPlotEnd : LevelFlowActionBase
	{
		// Token: 0x0603B94E RID: 244046 RVA: 0x010E61F6 File Offset: 0x010E43F6
		public LevelFlowWaitPlotEnd Init(string flowListName, int flowId, int stateId)
		{
			this.FlowListName = flowListName;
			this.FlowId = flowId;
			this.StateId = stateId;
			return this;
		}

		// Token: 0x0603B94F RID: 244047 RVA: 0x010E620E File Offset: 0x010E440E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		}

		// Token: 0x0603B950 RID: 244048 RVA: 0x010E622C File Offset: 0x010E442C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		}

		// Token: 0x0603B951 RID: 244049 RVA: 0x010E624C File Offset: 0x010E444C
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

		// Token: 0x0401F6B9 RID: 128697
		private string FlowListName = string.Empty;

		// Token: 0x0401F6BA RID: 128698
		private int FlowId;

		// Token: 0x0401F6BB RID: 128699
		private int StateId;
	}
}
