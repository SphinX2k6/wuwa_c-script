using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200409B RID: 16539
	public class FlowActionPreEnableSubLevel : FlowActionBase
	{
		// Token: 0x06029E12 RID: 171538 RVA: 0x00BD7720 File Offset: 0x00BD5920
		protected unsafe override void OnExecute()
		{
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
			instance.ExecuteActionsNew(list, context2, null);
			base.FinishExecute(true, true);
		}

		// Token: 0x06029E13 RID: 171539 RVA: 0x00BD779A File Offset: 0x00BD599A
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
