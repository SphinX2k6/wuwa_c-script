using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200611D RID: 24861
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowSequenceAction : LevelFlowActionBase
	{
		// Token: 0x0603B917 RID: 243991 RVA: 0x010E48B2 File Offset: 0x010E2AB2
		public LevelFlowSequenceAction Init(List<LevelFlowActionBase> actions)
		{
			this.Actions = actions;
			return this;
		}

		// Token: 0x0603B918 RID: 243992 RVA: 0x010E48BC File Offset: 0x010E2ABC
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

		// Token: 0x0603B919 RID: 243993 RVA: 0x010E490E File Offset: 0x010E2B0E
		protected override void OnTick(float deltaTime)
		{
			this.Actions[this.CurrentActionIndex].Tick(deltaTime);
		}

		// Token: 0x0603B91A RID: 243994 RVA: 0x010E4928 File Offset: 0x010E2B28
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

		// Token: 0x0603B91B RID: 243995 RVA: 0x010E4994 File Offset: 0x010E2B94
		protected override void OnReset()
		{
			this.CurrentActionIndex = 0;
			foreach (LevelFlowActionBase levelFlowActionBase in this.Actions)
			{
				levelFlowActionBase.Reset();
			}
		}

		// Token: 0x0401F6A0 RID: 128672
		private List<LevelFlowActionBase> Actions = new List<LevelFlowActionBase>();

		// Token: 0x0401F6A1 RID: 128673
		private int CurrentActionIndex;
	}
}
