using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AFE RID: 23294
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowActionContext : GeneralContext
	{
		// Token: 0x0603948A RID: 234634 RVA: 0x0100A26D File Offset: 0x0100846D
		public FlowActionContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.FlowAction);
		}

		// Token: 0x0603948B RID: 234635 RVA: 0x0100A28D File Offset: 0x0100848D
		public override void Reset()
		{
			this.FlowActionId = 0;
			this.FlowListName = "";
			this.FlowId = 0;
			this.StateId = 0;
		}

		// Token: 0x0603948C RID: 234636 RVA: 0x0100A2B0 File Offset: 0x010084B0
		public static FlowActionContext Create(FlowActionCtxPb gameCtx, GameCtxType? subType = null)
		{
			FlowActionContext flowActionContext = GeneralContext.GetObj(EGeneralContextType.FlowAction, subType, () => new FlowActionContext()) as FlowActionContext;
			flowActionContext.FlowActionId = gameCtx.ActionId;
			flowActionContext.FlowListName = gameCtx.FlowListName;
			flowActionContext.FlowId = gameCtx.FlowId;
			flowActionContext.StateId = gameCtx.StateId;
			return flowActionContext;
		}

		// Token: 0x0401E29A RID: 123546
		public int FlowActionId;

		// Token: 0x0401E29B RID: 123547
		public string FlowListName = "";

		// Token: 0x0401E29C RID: 123548
		public int FlowId;

		// Token: 0x0401E29D RID: 123549
		public int StateId;
	}
}
