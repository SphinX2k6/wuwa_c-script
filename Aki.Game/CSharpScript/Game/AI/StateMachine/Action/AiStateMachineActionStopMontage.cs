using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064DD RID: 25821
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionStopMontage : AiStateMachineAction
	{
		// Token: 0x0603EB17 RID: 256791 RVA: 0x01243ABB File Offset: 0x01241CBB
		public AiStateMachineActionStopMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EB18 RID: 256792 RVA: 0x01243AC5 File Offset: 0x01241CC5
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.BlendOutTime = action.ActionStopMontage.BlendOutTime / 1000f;
			return true;
		}

		// Token: 0x0603EB19 RID: 256793 RVA: 0x01243AE0 File Offset: 0x01241CE0
		public override void DoAction(long? contextId = null)
		{
			CharacterSkillComponent skillComponent = this.Node.SkillComponent;
			if (((skillComponent != null) ? skillComponent.CurrentSkill : null) != null)
			{
				return;
			}
			if (this.Node.Owner.CheckAnyMontageTaskRunning(this.Node.RootNode))
			{
				return;
			}
			BaseTagComponent tagComponent = this.Node.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]))
			{
				BaseTagComponent tagComponent2 = this.Node.TagComponent;
				if (tagComponent2 == null || !tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"]))
				{
					BaseTagComponent tagComponent3 = this.Node.TagComponent;
					if (tagComponent3 == null || !tagComponent3.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"]))
					{
						UAnimInstance mainAnimInstance = this.Node.AnimationComponent.MainAnimInstance;
						if (mainAnimInstance == null)
						{
							return;
						}
						mainAnimInstance.Montage_Stop(this.BlendOutTime, null);
						return;
					}
				}
			}
		}

		// Token: 0x0603EB1A RID: 256794 RVA: 0x01243BBF File Offset: 0x01241DBF
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021773 RID: 137075
		private float BlendOutTime;
	}
}
