using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x0200733F RID: 29503
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionHate : AiStateMachineCondition
	{
		// Token: 0x06048644 RID: 296516 RVA: 0x0129F30B File Offset: 0x0129D50B
		public AiStateMachineConditionHate(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048645 RID: 296517 RVA: 0x0129F318 File Offset: 0x0129D518
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents())
			{
				AiController aiController = this.Node.AiController;
				Entity entity;
				if (aiController == null)
				{
					entity = null;
				}
				else
				{
					CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
					entity = ((charAiDesignComp != null) ? charAiDesignComp.Entity : null);
				}
				Entity entity2 = entity;
				AiController summonerAiController = this.Node.SummonerAiController;
				Entity entity3;
				if (summonerAiController == null)
				{
					entity3 = null;
				}
				else
				{
					CharacterAiComponent charAiDesignComp2 = summonerAiController.CharAiDesignComp;
					entity3 = ((charAiDesignComp2 != null) ? charAiDesignComp2.Entity : null);
				}
				Entity entity4 = entity3;
				if (entity2 != null && !EventSystem.Instance.HasWithTarget(entity2, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChanged)))
				{
					EventSystem.Instance.AddWithTarget(entity2, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChanged));
				}
				if (entity4 != null && !EventSystem.Instance.HasWithTarget(entity4, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChanged)))
				{
					EventSystem.Instance.AddWithTarget(entity4, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChanged));
				}
				return true;
			}
			return false;
		}

		// Token: 0x06048646 RID: 296518 RVA: 0x0129F3F8 File Offset: 0x0129D5F8
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents())
			{
				AiController aiController = this.Node.AiController;
				Entity entity;
				if (aiController == null)
				{
					entity = null;
				}
				else
				{
					CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
					entity = ((charAiDesignComp != null) ? charAiDesignComp.Entity : null);
				}
				Entity entity2 = entity;
				AiController summonerAiController = this.Node.SummonerAiController;
				Entity entity3;
				if (summonerAiController == null)
				{
					entity3 = null;
				}
				else
				{
					CharacterAiComponent charAiDesignComp2 = summonerAiController.CharAiDesignComp;
					entity3 = ((charAiDesignComp2 != null) ? charAiDesignComp2.Entity : null);
				}
				Entity entity4 = entity3;
				if (entity2 != null && EventSystem.Instance.HasWithTarget(entity2, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChanged)))
				{
					EventSystem.Instance.RemoveWithTarget(entity2, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChanged));
				}
				if (entity4 != null && EventSystem.Instance.HasWithTarget(entity4, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChanged)))
				{
					EventSystem.Instance.RemoveWithTarget(entity4, EEventName.AiHateTargetChanged, new Action<int?, int?>(this.OnAiHateTargetChanged));
				}
				return true;
			}
			return false;
		}

		// Token: 0x06048647 RID: 296519 RVA: 0x0129F4D8 File Offset: 0x0129D6D8
		private void CheckTargetImpl()
		{
			this.ResultSelf = (this.Node.AiController.AiHateList.GetCurrentTarget() != null);
			if (this.ResultSelf && this.Node.SummonerAiController != null)
			{
				this.ResultSelf = (this.Node.SummonerAiController.AiHateList.GetCurrentTarget() != null);
			}
		}

		// Token: 0x06048648 RID: 296520 RVA: 0x0129F536 File Offset: 0x0129D736
		protected override void OnTick()
		{
			this.CheckTargetImpl();
		}

		// Token: 0x06048649 RID: 296521 RVA: 0x0129F540 File Offset: 0x0129D740
		private void OnAiHateTargetChanged(int? newId, int? preId)
		{
			this.CheckTargetImpl();
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionHate", this.Node.Name);
			}
		}

		// Token: 0x0604864A RID: 296522 RVA: 0x0129F58D File Offset: 0x0129D78D
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("有仇恨\n");
		}
	}
}
