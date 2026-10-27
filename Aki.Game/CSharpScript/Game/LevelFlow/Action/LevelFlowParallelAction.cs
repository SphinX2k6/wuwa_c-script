using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F91 RID: 28561
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowParallelAction : LevelFlowActionBase
	{
		// Token: 0x06045737 RID: 284471 RVA: 0x01139BCF File Offset: 0x01137DCF
		public LevelFlowParallelAction Init(List<LevelFlowActionBase> actions)
		{
			this.Actions = actions;
			return this;
		}

		// Token: 0x06045738 RID: 284472 RVA: 0x01139BDC File Offset: 0x01137DDC
		protected override void OnExecute()
		{
			if (this.Actions.Count <= 0)
			{
				base.FinishExecute(true);
				return;
			}
			this.FinishActionSet.Clear();
			foreach (LevelFlowActionBase levelFlowActionBase in this.Actions)
			{
				levelFlowActionBase.BindCompleteCallBack(new Action<LevelFlowActionBase, bool>(this.OnActionComplete));
				levelFlowActionBase.Execute();
			}
		}

		// Token: 0x06045739 RID: 284473 RVA: 0x01139C60 File Offset: 0x01137E60
		protected override void OnTick(float deltaTime)
		{
			foreach (LevelFlowActionBase levelFlowActionBase in this.Actions)
			{
				levelFlowActionBase.Tick(deltaTime);
			}
		}

		// Token: 0x0604573A RID: 284474 RVA: 0x01139CB4 File Offset: 0x01137EB4
		private void OnActionComplete(LevelFlowActionBase action, bool isSuccess)
		{
			if (!isSuccess)
			{
				base.FinishExecute(false);
				return;
			}
			this.FinishActionSet.Add(action);
			if (this.FinishActionSet.Count >= this.Actions.Count)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0604573B RID: 284475 RVA: 0x01139CF0 File Offset: 0x01137EF0
		protected override void OnReset()
		{
			foreach (LevelFlowActionBase levelFlowActionBase in this.Actions)
			{
				levelFlowActionBase.Reset();
			}
			this.FinishActionSet.Clear();
		}

		// Token: 0x040243CD RID: 148429
		private List<LevelFlowActionBase> Actions = new List<LevelFlowActionBase>();

		// Token: 0x040243CE RID: 148430
		private readonly HashSet<LevelFlowActionBase> FinishActionSet = new HashSet<LevelFlowActionBase>();
	}
}
