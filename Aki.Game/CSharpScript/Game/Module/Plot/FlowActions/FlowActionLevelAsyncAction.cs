using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C0 RID: 20672
	public class FlowActionLevelAsyncAction : FlowActionBase
	{
		// Token: 0x06034EEB RID: 216811 RVA: 0x00C89998 File Offset: 0x00C87B98
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

		// Token: 0x06034EEC RID: 216812 RVA: 0x00C89A3D File Offset: 0x00C87C3D
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}

		// Token: 0x06034EED RID: 216813 RVA: 0x00C89A45 File Offset: 0x00C87C45
		protected override void OnInterruptExecute()
		{
			this.IncId++;
			base.FinishExecute(true, true);
		}

		// Token: 0x06034EEE RID: 216814 RVA: 0x00C89A5D File Offset: 0x00C87C5D
		protected virtual void OnActionFinish(bool result)
		{
			base.FinishExecute(result, true);
		}

		// Token: 0x0401C308 RID: 115464
		private int IncId;
	}
}
