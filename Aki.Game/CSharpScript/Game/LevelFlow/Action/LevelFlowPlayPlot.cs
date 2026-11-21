using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006114 RID: 24852
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowPlayPlot : LevelFlowActionBase
	{
		// Token: 0x0603B8EF RID: 243951 RVA: 0x010E3CE0 File Offset: 0x010E1EE0
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

		// Token: 0x0603B8F0 RID: 243952 RVA: 0x010E3D44 File Offset: 0x010E1F44
		protected override void OnExecute()
		{
			FlowController.Instance.StartFlow(this.FlowListName, this.FlowId, this.StateId, this.Context, (long)this.FlowIncId, this.IsServerNotify, this.IsAsync, this.IsSkip, this.Pos);
			base.FinishExecute(true);
		}

		// Token: 0x0401F685 RID: 128645
		private string FlowListName = string.Empty;

		// Token: 0x0401F686 RID: 128646
		private int FlowId;

		// Token: 0x0401F687 RID: 128647
		private int StateId;

		// Token: 0x0401F688 RID: 128648
		[Nullable(2)]
		private GeneralContext Context;

		// Token: 0x0401F689 RID: 128649
		private int FlowIncId;

		// Token: 0x0401F68A RID: 128650
		private bool IsServerNotify;

		// Token: 0x0401F68B RID: 128651
		private bool IsAsync;

		// Token: 0x0401F68C RID: 128652
		private bool IsSkip;

		// Token: 0x0401F68D RID: 128653
		[Nullable(2)]
		private Vector Pos;
	}
}
