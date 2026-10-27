using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F93 RID: 28563
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowPlayPlot : LevelFlowActionBase
	{
		// Token: 0x06045741 RID: 284481 RVA: 0x01139EDC File Offset: 0x011380DC
		public LevelFlowPlayPlot Init(string flowListName, int flowId, int stateId, [Nullable(2)] GeneralContext context = null, int? flowIncId = null, bool? isAsync = null, bool? isSkip = null, [Nullable(2)] Vector pos = null)
		{
			this.FlowListName = flowListName;
			this.FlowId = flowId;
			this.StateId = stateId;
			this.Context = context;
			this.FlowIncId = flowIncId.GetValueOrDefault(-1);
			this.IsServerNotify = false;
			this.IsAsync = isAsync.GetValueOrDefault();
			this.IsSkip = isSkip.GetValueOrDefault();
			this.Pos = pos;
			return this;
		}

		// Token: 0x06045742 RID: 284482 RVA: 0x01139F40 File Offset: 0x01138140
		protected override void OnExecute()
		{
			FlowController.Instance.StartFlow(this.FlowListName, this.FlowId, this.StateId, this.Context, (long)this.FlowIncId, this.IsServerNotify, this.IsAsync, this.IsSkip, this.Pos);
			base.FinishExecute(true);
		}

		// Token: 0x040243D0 RID: 148432
		private string FlowListName = string.Empty;

		// Token: 0x040243D1 RID: 148433
		private int FlowId;

		// Token: 0x040243D2 RID: 148434
		private int StateId;

		// Token: 0x040243D3 RID: 148435
		[Nullable(2)]
		private GeneralContext Context;

		// Token: 0x040243D4 RID: 148436
		private int FlowIncId;

		// Token: 0x040243D5 RID: 148437
		private bool IsServerNotify;

		// Token: 0x040243D6 RID: 148438
		private bool IsAsync;

		// Token: 0x040243D7 RID: 148439
		private bool IsSkip;

		// Token: 0x040243D8 RID: 148440
		[Nullable(2)]
		private Vector Pos;
	}
}
