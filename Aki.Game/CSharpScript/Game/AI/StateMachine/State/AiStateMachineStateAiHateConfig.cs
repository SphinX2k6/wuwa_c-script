using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007324 RID: 29476
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateAiHateConfig : AiStateMachineState
	{
		// Token: 0x060485A4 RID: 296356 RVA: 0x0129C62B File Offset: 0x0129A82B
		public AiStateMachineStateAiHateConfig(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485A5 RID: 296357 RVA: 0x0129C635 File Offset: 0x0129A835
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.ConfigId = state.BindAiHateConfig.ConfigId;
			return true;
		}

		// Token: 0x060485A6 RID: 296358 RVA: 0x0129C64C File Offset: 0x0129A84C
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

		// Token: 0x060485A7 RID: 296359 RVA: 0x0129C718 File Offset: 0x0129A918
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

		// Token: 0x060485A8 RID: 296360 RVA: 0x0129C7A6 File Offset: 0x0129A9A6
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026414 RID: 156692
		private int ConfigId;

		// Token: 0x04026415 RID: 156693
		private int? LastConfigId;
	}
}
