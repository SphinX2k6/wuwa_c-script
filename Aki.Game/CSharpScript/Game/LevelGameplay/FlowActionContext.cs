using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A2 RID: 27042
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowActionContext : GeneralContext
	{
		// Token: 0x06043452 RID: 275538 RVA: 0x01066005 File Offset: 0x01064205
		public FlowActionContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.FlowAction);
		}

		// Token: 0x06043453 RID: 275539 RVA: 0x01066025 File Offset: 0x01064225
		public override void Reset()
		{
			this.FlowActionId = 0;
			this.FlowListName = "";
			this.FlowId = 0;
			this.StateId = 0;
		}

		// Token: 0x06043454 RID: 275540 RVA: 0x01066048 File Offset: 0x01064248
		public static FlowActionContext Create(FlowActionCtxPb gameCtx, GameCtxType? subType = null)
		{
			FlowActionContext flowActionContext = GeneralContext.GetObj(EGeneralContextType.FlowAction, subType, () => new FlowActionContext()) as FlowActionContext;
			flowActionContext.FlowActionId = gameCtx.ActionId;
			flowActionContext.FlowListName = gameCtx.FlowListName;
			flowActionContext.FlowId = gameCtx.FlowId;
			flowActionContext.StateId = gameCtx.StateId;
			return flowActionContext;
		}

		// Token: 0x040230B0 RID: 143536
		public int FlowActionId;

		// Token: 0x040230B1 RID: 143537
		public string FlowListName = "";

		// Token: 0x040230B2 RID: 143538
		public int FlowId;

		// Token: 0x040230B3 RID: 143539
		public int StateId;
	}
}
