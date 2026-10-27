using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007341 RID: 29505
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionListenBeHit : AiStateMachineCondition
	{
		// Token: 0x0604864D RID: 296525 RVA: 0x0129F5C4 File Offset: 0x0129D7C4
		public AiStateMachineConditionListenBeHit(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0604864E RID: 296526 RVA: 0x0129F5DC File Offset: 0x0129D7DC
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

		// Token: 0x0604864F RID: 296527 RVA: 0x0129F70A File Offset: 0x0129D90A
		protected override void OnClear()
		{
			this.Node.Owner.UnregisterBeHitEvent(new Action<bool, EHitAnim, int>(this.OnBeHit));
		}

		// Token: 0x06048650 RID: 296528 RVA: 0x0129F728 File Offset: 0x0129D928
		protected override void OnEnter()
		{
			this.ResultSelf = false;
			this.Node.Owner.RegisterBeHitEvent(new Action<bool, EHitAnim, int>(this.OnBeHit));
		}

		// Token: 0x06048651 RID: 296529 RVA: 0x0129F74D File Offset: 0x0129D94D
		protected override void OnExit()
		{
			this.ResultSelf = false;
			this.Node.Owner.UnregisterBeHitEvent(new Action<bool, EHitAnim, int>(this.OnBeHit));
		}

		// Token: 0x06048652 RID: 296530 RVA: 0x0129F774 File Offset: 0x0129D974
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

		// Token: 0x06048653 RID: 296531 RVA: 0x0129F7C0 File Offset: 0x0129D9C0
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("监听受击\n");
		}

		// Token: 0x04026465 RID: 156773
		private bool NoHitAnimation;

		// Token: 0x04026466 RID: 156774
		private readonly HashSet<EHitAnim> BeHitAnimSet = new HashSet<EHitAnim>();

		// Token: 0x04026467 RID: 156775
		private int VisionCounterAttackId;
	}
}
