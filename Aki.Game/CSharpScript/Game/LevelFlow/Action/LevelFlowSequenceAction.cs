using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F9C RID: 28572
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowSequenceAction : LevelFlowActionBase
	{
		// Token: 0x06045769 RID: 284521 RVA: 0x0113AAAE File Offset: 0x01138CAE
		public LevelFlowSequenceAction Init(List<LevelFlowActionBase> actions)
		{
			this.Actions = actions;
			return this;
		}

		// Token: 0x0604576A RID: 284522 RVA: 0x0113AAB8 File Offset: 0x01138CB8
		protected override void OnExecute()
		{
			if (this.Actions.Count <= 0)
			{
				base.FinishExecute(true);
				return;
			}
			this.CurrentActionIndex = 0;
			LevelFlowActionBase levelFlowActionBase = this.Actions[this.CurrentActionIndex];
			levelFlowActionBase.BindCompleteCallBack(new Action<LevelFlowActionBase, bool>(this.OnActionComplete));
			levelFlowActionBase.Execute();
		}

		// Token: 0x0604576B RID: 284523 RVA: 0x0113AB0A File Offset: 0x01138D0A
		protected override void OnTick(float deltaTime)
		{
			this.Actions[this.CurrentActionIndex].Tick(deltaTime);
		}

		// Token: 0x0604576C RID: 284524 RVA: 0x0113AB24 File Offset: 0x01138D24
		private void OnActionComplete(LevelFlowActionBase action, bool isSuccess)
		{
			if (!isSuccess)
			{
				base.FinishExecute(false);
				return;
			}
			this.CurrentActionIndex++;
			if (this.CurrentActionIndex >= this.Actions.Count)
			{
				base.FinishExecute(true);
				return;
			}
			LevelFlowActionBase levelFlowActionBase = this.Actions[this.CurrentActionIndex];
			levelFlowActionBase.BindCompleteCallBack(new Action<LevelFlowActionBase, bool>(this.OnActionComplete));
			levelFlowActionBase.Execute();
		}

		// Token: 0x0604576D RID: 284525 RVA: 0x0113AB90 File Offset: 0x01138D90
		protected override void OnReset()
		{
			this.CurrentActionIndex = 0;
			foreach (LevelFlowActionBase levelFlowActionBase in this.Actions)
			{
				levelFlowActionBase.Reset();
			}
		}

		// Token: 0x040243EB RID: 148459
		private List<LevelFlowActionBase> Actions = new List<LevelFlowActionBase>();

		// Token: 0x040243EC RID: 148460
		private int CurrentActionIndex;
	}
}
