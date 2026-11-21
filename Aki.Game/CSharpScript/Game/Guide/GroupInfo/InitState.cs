using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Guide.StepInfo;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x02003538 RID: 13624
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InitState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x06022A9F RID: 141983 RVA: 0x009DD20B File Offset: 0x009DB40B
		public InitState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x06022AA0 RID: 141984 RVA: 0x009DD218 File Offset: 0x009DB418
		protected override void OnStart()
		{
			this.Owner.BreakExcludeStepIdSet = GuideConfig.Instance.GetBreakExcludeStepIdSetOfGroup(this.Owner.Id);
			this.Owner.StepInfoList.Clear();
			foreach (int stepId in GuideConfig.Instance.GetOrderedStepIdsOfGroup(this.Owner.Id, Info.Instance.InputControllerMainType))
			{
				this.Owner.StepInfoList.Add(new GuideStepInfo(stepId, this.Owner));
			}
			this.Owner.CurrentStepIndex = -1;
			this.Owner.IsFake = false;
			if (this.Owner.FinishPromise != null)
			{
				this.Owner.FinishPromise.SetResult();
				this.Owner.FinishPromise = null;
			}
		}

		// Token: 0x06022AA1 RID: 141985 RVA: 0x009DD2E4 File Offset: 0x009DB4E4
		protected override void OnEnter(EGuideGroupState? lastState)
		{
			this.Owner.CurrentStepIndex = -1;
			this.Owner.IsFake = false;
		}
	}
}
