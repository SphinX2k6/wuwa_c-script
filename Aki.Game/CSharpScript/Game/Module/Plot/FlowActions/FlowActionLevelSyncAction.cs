using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004091 RID: 16529
	public class FlowActionLevelSyncAction : FlowActionBase
	{
		// Token: 0x06029DE9 RID: 171497 RVA: 0x00BD6D58 File Offset: 0x00BD4F58
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
		}

		// Token: 0x06029DEA RID: 171498 RVA: 0x00BD6DCA File Offset: 0x00BD4FCA
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
