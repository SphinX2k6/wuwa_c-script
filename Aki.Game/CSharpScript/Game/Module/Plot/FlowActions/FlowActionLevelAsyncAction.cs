using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004090 RID: 16528
	public class FlowActionLevelAsyncAction : FlowActionBase
	{
		// Token: 0x06029DE4 RID: 171492 RVA: 0x00BD6C80 File Offset: 0x00BD4E80
		protected unsafe override void OnExecute()
		{
			this.IncId++;
			int id = this.IncId;
			long flowIncId = this.Context.FlowIncId;
			GeneralContext context = this.Context.Context;
			PlotContext context2 = PlotContext.Create(flowIncId, (context != null) ? context.SubType : null);
			LevelGeneralController instance = LevelGeneralController.Instance;
			int num = 1;
			List<ActionInfo> list = new List<ActionInfo>(num);
			CollectionsMarshal.SetCount<ActionInfo>(list, num);
			Span<ActionInfo> span = CollectionsMarshal.AsSpan<ActionInfo>(list);
			int index = 0;
			*span[index] = this.ActionInfo;
			instance.ExecuteActionsNew(list, context2, delegate(ELevelEventState result)
			{
				if (this.ActionInfo == null || this.Runner == null || id != this.IncId)
				{
					return;
				}
				this.OnActionFinish(result == ELevelEventState.Success);
			});
		}

		// Token: 0x06029DE5 RID: 171493 RVA: 0x00BD6D25 File Offset: 0x00BD4F25
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06029DE6 RID: 171494 RVA: 0x00BD6D2D File Offset: 0x00BD4F2D
		protected override void OnInterruptExecute()
		{
			this.IncId++;
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DE7 RID: 171495 RVA: 0x00BD6D45 File Offset: 0x00BD4F45
		protected virtual void OnActionFinish(bool result)
		{
			base.FinishExecute(result, true);
		}

		// Token: 0x04016D39 RID: 93497
		private int IncId;
	}
}
