using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064A7 RID: 25767
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateAiHateConfig : AiStateMachineState
	{
		// Token: 0x0603E9F1 RID: 256497 RVA: 0x0123F0AB File Offset: 0x0123D2AB
		public AiStateMachineStateAiHateConfig(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603E9F2 RID: 256498 RVA: 0x0123F0B5 File Offset: 0x0123D2B5
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.ConfigId = state.BindAiHateConfig.ConfigId;
			return true;
		}

		// Token: 0x0603E9F3 RID: 256499 RVA: 0x0123F0CC File Offset: 0x0123D2CC
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			AiHateList aiHateList = this.Node.AiController.AiHateList;
			AiHate? aiHate;
			this.LastConfigId = ((aiHateList != null) ? ((aiHateList.AiHate != null) ? new int?(aiHate.GetValueOrDefault().Id) : null) : null);
			if (this.ConfigId != 0)
			{
				this.Node.AiController.AiHateList.AiHate = AiConfig.Instance.LoadAiHate(this.ConfigId);
				return;
			}
			this.Node.AiController.AiHateList.AiHate = AiConfig.Instance.LoadAiHateByController(this.Node.AiController, null, null);
		}

		// Token: 0x0603E9F4 RID: 256500 RVA: 0x0123F198 File Offset: 0x0123D398
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			if (this.LastConfigId != null)
			{
				this.Node.AiController.AiHateList.AiHate = AiConfig.Instance.LoadAiHate(this.LastConfigId.Value);
			}
			else
			{
				this.Node.AiController.AiHateList.AiHate = AiConfig.Instance.LoadAiHateByController(this.Node.AiController, null, null);
			}
			this.LastConfigId = null;
		}

		// Token: 0x0603E9F5 RID: 256501 RVA: 0x0123F226 File Offset: 0x0123D426
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021701 RID: 136961
		private int ConfigId;

		// Token: 0x04021702 RID: 136962
		private int? LastConfigId;
	}
}
