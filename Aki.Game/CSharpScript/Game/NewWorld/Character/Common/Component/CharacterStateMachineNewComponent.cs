using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.AI.StateMachine;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070D4 RID: 28884
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterStateMachineNewComponent : EntityComponent, IStaticVariableResetter
	{
		// Token: 0x060467B0 RID: 288688 RVA: 0x011B3580 File Offset: 0x011B1780
		static CharacterStateMachineNewComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterStateMachineNewComponent.CreateStaticDefaultValue), new Action(CharacterStateMachineNewComponent.ResetStaticDefaultValue));
		}

		// Token: 0x060467B1 RID: 288689 RVA: 0x011B359F File Offset: 0x011B179F
		protected override void OnTick(float delta)
		{
			this.StateMachineGroup.OnTick(delta);
		}

		// Token: 0x060467B2 RID: 288690 RVA: 0x011B35AD File Offset: 0x011B17AD
		protected override bool OnInit()
		{
			this.StateMachineGroup = new AiStateMachineGroup(this);
			return true;
		}

		// Token: 0x060467B3 RID: 288691 RVA: 0x011B35BC File Offset: 0x011B17BC
		protected override void OnActivate()
		{
			this.StateMachineGroup.OnActivate();
		}

		// Token: 0x060467B4 RID: 288692 RVA: 0x011B35C9 File Offset: 0x011B17C9
		protected override bool OnEnd()
		{
			AiStateMachineGroup stateMachineGroup = this.StateMachineGroup;
			if (stateMachineGroup != null)
			{
				stateMachineGroup.Clear();
			}
			this.StateMachineGroup = null;
			return true;
		}

		// Token: 0x060467B5 RID: 288693 RVA: 0x011B35E4 File Offset: 0x011B17E4
		public void OnControl()
		{
			this.StateMachineGroup.OnControl();
		}

		// Token: 0x060467B6 RID: 288694 RVA: 0x011B35F4 File Offset: 0x011B17F4
		[CombatListen(ENotifyMessageId.ChangeStateNotify, true, false)]
		public static void ChangeStateNotify(Entity entity, [Nullable(1)] ChangeStateNotify data, CombatCommon combatCommon = null)
		{
			long messageId = combatCommon.MessageId;
			CharacterStateMachineNewComponent characterStateMachineNewComponent = (entity != null) ? entity.GetComponent<CharacterStateMachineNewComponent>() : null;
			if (characterStateMachineNewComponent == null)
			{
				return;
			}
			characterStateMachineNewComponent.StateMachineGroup.HandleSwitch(data.FsmId, data.FromState, data.ToState, messageId);
		}

		// Token: 0x060467B7 RID: 288695 RVA: 0x011B3636 File Offset: 0x011B1836
		[CombatListen(ENotifyMessageId.ChangeStateConfirmNotify, true, false)]
		public static void ChangeStateConfirmNotify(Entity entity, [Nullable(1)] ChangeStateConfirmNotify data, CombatCommon combatCommon = null)
		{
			CharacterStateMachineNewComponent characterStateMachineNewComponent = (entity != null) ? entity.GetComponent<CharacterStateMachineNewComponent>() : null;
			if (characterStateMachineNewComponent == null)
			{
				return;
			}
			characterStateMachineNewComponent.StateMachineGroup.HandleChangeStateConfirm(data.FsmId, data.State);
		}

		// Token: 0x060467B8 RID: 288696 RVA: 0x011B3660 File Offset: 0x011B1860
		[CombatListen(ENotifyMessageId.FsmResetNotify, true, false)]
		public static void FsmResetNotify(Entity entity, [Nullable(1)] FsmResetNotify data, CombatCommon combatCommon = null)
		{
			long messageId = combatCommon.MessageId;
			CharacterStateMachineNewComponent characterStateMachineNewComponent = (entity != null) ? entity.GetComponent<CharacterStateMachineNewComponent>() : null;
			if (characterStateMachineNewComponent == null)
			{
				return;
			}
			characterStateMachineNewComponent.StateMachineGroup.ResetStateMachine(data.EntityFsmComponentPb, messageId);
		}

		// Token: 0x060467B9 RID: 288697 RVA: 0x011B3696 File Offset: 0x011B1896
		[CombatListen(ENotifyMessageId.FsmBlackboardNotify, true, false)]
		public static void FsmBlackboardNotify(Entity entity, [Nullable(1)] FsmBlackboardNotify data, CombatCommon combatCommon = null)
		{
			CharacterStateMachineNewComponent characterStateMachineNewComponent = (entity != null) ? entity.GetComponent<CharacterStateMachineNewComponent>() : null;
			if (characterStateMachineNewComponent == null)
			{
				return;
			}
			characterStateMachineNewComponent.StateMachineGroup.HandleBlackboard(data);
		}

		// Token: 0x060467BA RID: 288698 RVA: 0x011B36B4 File Offset: 0x011B18B4
		[CombatListen(ENotifyMessageId.FsmCustomBlackboardNotify, true, false)]
		public static void FsmCustomBlackboardNotify(Entity entity, [Nullable(1)] FsmCustomBlackboardNotify data, CombatCommon combatCommon = null)
		{
			CharacterStateMachineNewComponent characterStateMachineNewComponent = (entity != null) ? entity.GetComponent<CharacterStateMachineNewComponent>() : null;
			if (characterStateMachineNewComponent == null)
			{
				return;
			}
			characterStateMachineNewComponent.StateMachineGroup.HandleCustomBlackboard(data);
		}

		// Token: 0x060467BB RID: 288699 RVA: 0x011B36D2 File Offset: 0x011B18D2
		[CombatListen(ENotifyMessageId.FsmMontageDurationNotify, true, false)]
		public static void FsmMontageDurationNotify(Entity entity, [Nullable(1)] FsmMontageDurationNotify data, CombatCommon combatCommon = null)
		{
			CharacterStateMachineNewComponent characterStateMachineNewComponent = (entity != null) ? entity.GetComponent<CharacterStateMachineNewComponent>() : null;
			if (characterStateMachineNewComponent == null)
			{
				return;
			}
			characterStateMachineNewComponent.StateMachineGroup.SetMontagePredictEndParams(data.MontageHashCode, (float)data.DurationTime);
		}

		// Token: 0x060467BC RID: 288700 RVA: 0x011B36FC File Offset: 0x011B18FC
		public static void CreateStaticDefaultValue()
		{
			CharacterStateMachineNewComponent.EventDrivenOn = true;
		}

		// Token: 0x060467BD RID: 288701 RVA: 0x011B3704 File Offset: 0x011B1904
		public static void ResetStaticDefaultValue()
		{
			CharacterStateMachineNewComponent.EventDrivenOn = false;
		}

		// Token: 0x060467BE RID: 288702 RVA: 0x011B370C File Offset: 0x011B190C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterStateMachineNewComponent characterStateMachineNewComponent = (CharacterStateMachineNewComponent)componentTemplate;
			if (base.CanResetComponentProperty("StateMachineName"))
			{
				this.StateMachineName = characterStateMachineNewComponent.StateMachineName;
			}
			if (base.CanResetComponentProperty("StateMachineJsonObject"))
			{
				if (characterStateMachineNewComponent.StateMachineJsonObject == null)
				{
					this.StateMachineJsonObject = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CombatStateMachineDefine.Fsm.StateMachineGroup>(this.StateMachineJsonObject), "StateMachineJsonObject"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("StateMachineGroup"))
			{
				if (characterStateMachineNewComponent.StateMachineGroup == null)
				{
					this.StateMachineGroup = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AiStateMachineGroup>(this.StateMachineGroup), "StateMachineGroup"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024F1B RID: 151323
		[Nullable(1)]
		public string StateMachineName = "";

		// Token: 0x04024F1C RID: 151324
		public CombatStateMachineDefine.Fsm.StateMachineGroup StateMachineJsonObject;

		// Token: 0x04024F1D RID: 151325
		public AiStateMachineGroup StateMachineGroup;

		// Token: 0x04024F1E RID: 151326
		public static bool EventDrivenOn;
	}
}
