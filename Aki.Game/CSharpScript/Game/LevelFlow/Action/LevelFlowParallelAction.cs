using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006112 RID: 24850
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowParallelAction : LevelFlowActionBase
	{
		// Token: 0x0603B8E5 RID: 243941 RVA: 0x010E39D3 File Offset: 0x010E1BD3
		public LevelFlowParallelAction Init(List<LevelFlowActionBase> actions)
		{
			this.Actions = actions;
			return this;
		}

		// Token: 0x0603B8E6 RID: 243942 RVA: 0x010E39E0 File Offset: 0x010E1BE0
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

		// Token: 0x0603B8E7 RID: 243943 RVA: 0x010E3A64 File Offset: 0x010E1C64
		protected override void OnTick(float deltaTime)
		{
			foreach (LevelFlowActionBase levelFlowActionBase in this.Actions)
			{
				levelFlowActionBase.Tick(deltaTime);
			}
		}

		// Token: 0x0603B8E8 RID: 243944 RVA: 0x010E3AB8 File Offset: 0x010E1CB8
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

		// Token: 0x0603B8E9 RID: 243945 RVA: 0x010E3AF4 File Offset: 0x010E1CF4
		protected override void OnReset()
		{
			foreach (LevelFlowActionBase levelFlowActionBase in this.Actions)
			{
				levelFlowActionBase.Reset();
			}
			this.FinishActionSet.Clear();
		}

		// Token: 0x0401F682 RID: 128642
		private List<LevelFlowActionBase> Actions = new List<LevelFlowActionBase>();

		// Token: 0x0401F683 RID: 128643
		private readonly HashSet<LevelFlowActionBase> FinishActionSet = new HashSet<LevelFlowActionBase>();
	}
}
