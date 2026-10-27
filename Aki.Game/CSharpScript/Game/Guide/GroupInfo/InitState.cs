using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Guide.StepInfo;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x0200460F RID: 17935
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InitState : StateBase<GuideGroupInfo, EGuideGroupState>
	{
		// Token: 0x0602E3AA RID: 189354 RVA: 0x00AB0B17 File Offset: 0x00AAED17
		public InitState(GuideGroupInfo owner, EGuideGroupState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<GuideGroupInfo, EGuideGroupState> stateMachine = null) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x0602E3AB RID: 189355 RVA: 0x00AB0B24 File Offset: 0x00AAED24
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

		// Token: 0x0602E3AC RID: 189356 RVA: 0x00AB0BF0 File Offset: 0x00AAEDF0
		protected override void OnEnter(EGuideGroupState? lastState)
		{
			this.Owner.CurrentStepIndex = -1;
			this.Owner.IsFake = false;
		}
	}
}
