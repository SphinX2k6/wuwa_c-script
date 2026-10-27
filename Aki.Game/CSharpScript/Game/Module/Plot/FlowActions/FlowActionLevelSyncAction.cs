using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C1 RID: 20673
	public class FlowActionLevelSyncAction : FlowActionBase
	{
		// Token: 0x06034EF0 RID: 216816 RVA: 0x00C89A70 File Offset: 0x00C87C70
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

		// Token: 0x06034EF1 RID: 216817 RVA: 0x00C89AE2 File Offset: 0x00C87CE2
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
