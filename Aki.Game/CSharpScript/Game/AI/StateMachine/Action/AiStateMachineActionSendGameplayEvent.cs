using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007358 RID: 29528
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionSendGameplayEvent : AiStateMachineAction
	{
		// Token: 0x060486C1 RID: 296641 RVA: 0x012A0F16 File Offset: 0x0129F116
		public AiStateMachineActionSendGameplayEvent(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486C2 RID: 296642 RVA: 0x012A0F20 File Offset: 0x0129F120
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			CombatStateMachineDefine.Fsm.ActionSendGameplayEvent actionSendGameplayEvent = action.ActionSendGameplayEvent;
			this.TagId = ((actionSendGameplayEvent != null) ? new int?(actionSendGameplayEvent.TagId) : null);
			return true;
		}

		// Token: 0x060486C3 RID: 296643 RVA: 0x012A0F54 File Offset: 0x0129F154
		public override void DoAction(long? contextId = null)
		{
			FGameplayTag? gameplayTagById = GameplayTagUtils.GetGameplayTagById(this.TagId.GetValueOrDefault());
			if (gameplayTagById == null)
			{
				return;
			}
			AiStateMachineBase node = this.Node;
			if (node == null)
			{
				return;
			}
			BaseAbilityComponent abilityComponent = node.AbilityComponent;
			if (abilityComponent == null)
			{
				return;
			}
			abilityComponent.SendGameplayEventToActor(gameplayTagById.Value, null);
		}

		// Token: 0x060486C4 RID: 296644 RVA: 0x012A0F9E File Offset: 0x0129F19E
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026484 RID: 156804
		private int? TagId;
	}
}
