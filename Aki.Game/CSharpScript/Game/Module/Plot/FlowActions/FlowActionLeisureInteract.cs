using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050BF RID: 20671
	public class FlowActionLeisureInteract : FlowActionBase
	{
		// Token: 0x06034EE8 RID: 216808 RVA: 0x00C8990C File Offset: 0x00C87B0C
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

		// Token: 0x06034EE9 RID: 216809 RVA: 0x00C89986 File Offset: 0x00C87B86
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
