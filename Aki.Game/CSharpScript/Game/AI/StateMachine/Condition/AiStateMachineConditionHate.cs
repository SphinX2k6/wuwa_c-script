using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C2 RID: 25794
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionHate : AiStateMachineCondition
	{
		// Token: 0x0603EA91 RID: 256657 RVA: 0x01241D93 File Offset: 0x0123FF93
		public AiStateMachineConditionHate(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA92 RID: 256658 RVA: 0x01241DA0 File Offset: 0x0123FFA0
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

		// Token: 0x0603EA93 RID: 256659 RVA: 0x01241E80 File Offset: 0x01240080
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

		// Token: 0x0603EA94 RID: 256660 RVA: 0x01241F60 File Offset: 0x01240160
		private void CheckTargetImpl()
		{
			this.ResultSelf = (this.Node.AiController.AiHateList.GetCurrentTarget() != null);
			if (this.ResultSelf && this.Node.SummonerAiController != null)
			{
				this.ResultSelf = (this.Node.SummonerAiController.AiHateList.GetCurrentTarget() != null);
			}
		}

		// Token: 0x0603EA95 RID: 256661 RVA: 0x01241FBE File Offset: 0x012401BE
		protected override void OnTick()
		{
			this.CheckTargetImpl();
		}

		// Token: 0x0603EA96 RID: 256662 RVA: 0x01241FC8 File Offset: 0x012401C8
		private void OnAiHateTargetChanged(int? newId, int? preId)
		{
			this.CheckTargetImpl();
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionHate", this.Node.Name);
			}
		}

		// Token: 0x0603EA97 RID: 256663 RVA: 0x01242015 File Offset: 0x01240215
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("有仇恨\n");
		}
	}
}
