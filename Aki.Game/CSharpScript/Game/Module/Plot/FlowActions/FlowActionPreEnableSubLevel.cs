using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050CB RID: 20683
	public class FlowActionPreEnableSubLevel : FlowActionBase
	{
		// Token: 0x06034F19 RID: 216857 RVA: 0x00C8A438 File Offset: 0x00C88638
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

		// Token: 0x06034F1A RID: 216858 RVA: 0x00C8A4B2 File Offset: 0x00C886B2
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
