using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C4 RID: 25796
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionListenBeHit : AiStateMachineCondition
	{
		// Token: 0x0603EA9A RID: 256666 RVA: 0x0124204C File Offset: 0x0124024C
		public AiStateMachineConditionListenBeHit(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA9B RID: 256667 RVA: 0x01242064 File Offset: 0x01240264
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			if (condition.CondListenBeHit.NoHitAnimation)
			{
				this.NoHitAnimation = true;
			}
			if (condition.CondListenBeHit.SoftKnock)
			{
				this.BeHitAnimSet.Add(EHitAnim.轻左);
				this.BeHitAnimSet.Add(EHitAnim.轻右);
				this.BeHitAnimSet.Add(EHitAnim.轻前);
				this.BeHitAnimSet.Add(EHitAnim.轻后);
			}
			if (condition.CondListenBeHit.HeavyKnock)
			{
				this.BeHitAnimSet.Add(EHitAnim.重左);
				this.BeHitAnimSet.Add(EHitAnim.重右);
				this.BeHitAnimSet.Add(EHitAnim.重前);
				this.BeHitAnimSet.Add(EHitAnim.重后);
				this.BeHitAnimSet.Add(EHitAnim.压制);
			}
			if (condition.CondListenBeHit.KnockUp)
			{
				this.BeHitAnimSet.Add(EHitAnim.击飞);
			}
			if (condition.CondListenBeHit.KnockDown)
			{
				this.BeHitAnimSet.Add(EHitAnim.击倒);
			}
			if (condition.CondListenBeHit.Parry)
			{
				this.BeHitAnimSet.Add(EHitAnim.被弹反);
			}
			if (condition.CondListenBeHit.BreakWeakness)
			{
				this.BeHitAnimSet.Add(EHitAnim.被破弱);
			}
			this.VisionCounterAttackId = condition.CondListenBeHit.VisionCounterAttackId;
			return true;
		}

		// Token: 0x0603EA9C RID: 256668 RVA: 0x01242192 File Offset: 0x01240392
		protected override void OnClear()
		{
			this.Node.Owner.UnregisterBeHitEvent(new Action<bool, EHitAnim, int>(this.OnBeHit));
		}

		// Token: 0x0603EA9D RID: 256669 RVA: 0x012421B0 File Offset: 0x012403B0
		protected override void OnEnter()
		{
			this.ResultSelf = false;
			this.Node.Owner.RegisterBeHitEvent(new Action<bool, EHitAnim, int>(this.OnBeHit));
		}

		// Token: 0x0603EA9E RID: 256670 RVA: 0x012421D5 File Offset: 0x012403D5
		protected override void OnExit()
		{
			this.ResultSelf = false;
			this.Node.Owner.UnregisterBeHitEvent(new Action<bool, EHitAnim, int>(this.OnBeHit));
		}

		// Token: 0x0603EA9F RID: 256671 RVA: 0x012421FC File Offset: 0x012403FC
		private void OnBeHit(bool hasBeHitAnim, EHitAnim beHitAnim, int visionCounterAttackId)
		{
			if (visionCounterAttackId > 0)
			{
				if (this.VisionCounterAttackId != visionCounterAttackId)
				{
					return;
				}
				this.ResultSelf = true;
			}
			if (hasBeHitAnim)
			{
				if (this.BeHitAnimSet.Contains(beHitAnim))
				{
					this.ResultSelf = true;
					return;
				}
			}
			else if (this.NoHitAnimation)
			{
				this.ResultSelf = true;
			}
		}

		// Token: 0x0603EAA0 RID: 256672 RVA: 0x01242248 File Offset: 0x01240448
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("监听受击\n");
		}

		// Token: 0x04021752 RID: 137042
		private bool NoHitAnimation;

		// Token: 0x04021753 RID: 137043
		private readonly HashSet<EHitAnim> BeHitAnimSet = new HashSet<EHitAnim>();

		// Token: 0x04021754 RID: 137044
		private int VisionCounterAttackId;
	}
}
