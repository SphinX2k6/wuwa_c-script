using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.AI.StateMachine;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006338 RID: 25400
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterStateMachineNewComponent : EntityComponent, IStaticVariableResetter
	{
		// Token: 0x0603D8B3 RID: 252083 RVA: 0x011D263B File Offset: 0x011D083B
		static CharacterStateMachineNewComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterStateMachineNewComponent.CreateStaticDefaultValue), new Action(CharacterStateMachineNewComponent.ResetStaticDefaultValue));
		}

		// Token: 0x0603D8B4 RID: 252084 RVA: 0x011D265A File Offset: 0x011D085A
		protected override void OnTick(float delta)
		{
			this.StateMachineGroup.OnTick(delta);
		}

		// Token: 0x0603D8B5 RID: 252085 RVA: 0x011D2668 File Offset: 0x011D0868
		protected override bool OnInit()
		{
			this.StateMachineGroup = new AiStateMachineGroup(this);
			return true;
		}

		// Token: 0x0603D8B6 RID: 252086 RVA: 0x011D2677 File Offset: 0x011D0877
		protected override void OnActivate()
		{
			this.StateMachineGroup.OnActivate();
		}

		// Token: 0x0603D8B7 RID: 252087 RVA: 0x011D2684 File Offset: 0x011D0884
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

		// Token: 0x0603D8B8 RID: 252088 RVA: 0x011D269F File Offset: 0x011D089F
		public void OnControl()
		{
			this.StateMachineGroup.OnControl();
		}

		// Token: 0x0603D8B9 RID: 252089 RVA: 0x011D26AC File Offset: 0x011D08AC
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

		// Token: 0x0603D8BA RID: 252090 RVA: 0x011D26EE File Offset: 0x011D08EE
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

		// Token: 0x0603D8BB RID: 252091 RVA: 0x011D2718 File Offset: 0x011D0918
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

		// Token: 0x0603D8BC RID: 252092 RVA: 0x011D274E File Offset: 0x011D094E
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

		// Token: 0x0603D8BD RID: 252093 RVA: 0x011D276C File Offset: 0x011D096C
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

		// Token: 0x0603D8BE RID: 252094 RVA: 0x011D278A File Offset: 0x011D098A
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

		// Token: 0x0603D8BF RID: 252095 RVA: 0x011D27B4 File Offset: 0x011D09B4
		public static void CreateStaticDefaultValue()
		{
			CharacterStateMachineNewComponent.EventDrivenOn = true;
		}

		// Token: 0x0603D8C0 RID: 252096 RVA: 0x011D27BC File Offset: 0x011D09BC
		public static void ResetStaticDefaultValue()
		{
			CharacterStateMachineNewComponent.EventDrivenOn = false;
		}

		// Token: 0x0603D8C1 RID: 252097 RVA: 0x011D27C4 File Offset: 0x011D09C4
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterStateMachineNewComponent characterStateMachineNewComponent = (CharacterStateMachineNewComponent)componentTemplate;
			this.StateMachineName = characterStateMachineNewComponent.StateMachineName;
			if (characterStateMachineNewComponent.StateMachineJsonObject == null)
			{
				this.StateMachineJsonObject = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateMachineJsonObject), "StateMachineJsonObject"))
			{
				return false;
			}
			if (characterStateMachineNewComponent.StateMachineGroup == null)
			{
				this.StateMachineGroup = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateMachineGroup), "StateMachineGroup"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170074D1 RID: 29905
		// (get) Token: 0x0603D8C2 RID: 252098 RVA: 0x011D2846 File Offset: 0x011D0A46
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074D2 RID: 29906
		// (get) Token: 0x0603D8C3 RID: 252099 RVA: 0x011D2849 File Offset: 0x011D0A49
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074D3 RID: 29907
		// (get) Token: 0x0603D8C4 RID: 252100 RVA: 0x011D284C File Offset: 0x011D0A4C
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074D4 RID: 29908
		// (get) Token: 0x0603D8C5 RID: 252101 RVA: 0x011D284F File Offset: 0x011D0A4F
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020A5A RID: 133722
		[Nullable(1)]
		public string StateMachineName = "";

		// Token: 0x04020A5B RID: 133723
		public CombatStateMachineDefine.Fsm.StateMachineGroup StateMachineJsonObject;

		// Token: 0x04020A5C RID: 133724
		public AiStateMachineGroup StateMachineGroup;

		// Token: 0x04020A5D RID: 133725
		public static bool EventDrivenOn;
	}
}
