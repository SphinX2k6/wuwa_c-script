using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x0200735A RID: 29530
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionStopMontage : AiStateMachineAction
	{
		// Token: 0x060486C9 RID: 296649 RVA: 0x012A0FBF File Offset: 0x0129F1BF
		public AiStateMachineActionStopMontage(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486CA RID: 296650 RVA: 0x012A0FC9 File Offset: 0x0129F1C9
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.BlendOutTime = action.ActionStopMontage.BlendOutTime / 1000f;
			return true;
		}

		// Token: 0x060486CB RID: 296651 RVA: 0x012A0FE4 File Offset: 0x0129F1E4
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

		// Token: 0x060486CC RID: 296652 RVA: 0x012A10C3 File Offset: 0x0129F2C3
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026485 RID: 156805
		private float BlendOutTime;
	}
}
