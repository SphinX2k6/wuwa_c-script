using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CombatMessage;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200632A RID: 25386
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterLogicStateSyncComponent : EntityComponent
	{
		// Token: 0x0603D764 RID: 251748 RVA: 0x011C7CAC File Offset: 0x011C5EAC
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
			this.UnifiedStateComp = base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>();
			this.IsRole = base.Entity.GetComponent<CreatureDataComponent>().IsRole();
			EventSystem.Instance.AddWithTarget<bool>(base.Entity, EEventName.CharSwitchControl, new Action<bool>(this.OnSwitchControl));
			if (this.IsRole)
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnRoleGoUp, new Action(this.OnRoleGoUp));
			}
			return true;
		}

		// Token: 0x0603D765 RID: 251749 RVA: 0x011C7D3C File Offset: 0x011C5F3C
		protected override void OnActivate()
		{
			CombatMessageController.Instance.RegisterAfterTick(this, new Action<float>(this.ForceAfterTickInternal));
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			EntityComponentPb entityComponentPb;
			this.LogicStateComponentPb = (component.ComponentDataMap.TryGetValue("LogicStateComponentPb", out entityComponentPb) ? ((entityComponentPb != null) ? entityComponentPb.LogicStateComponentPb : null) : null);
			if (this.ActorComp.IsAutonomousProxy)
			{
				this.LogicStateInitRequest();
				this.Inited = true;
			}
			else if (this.LogicStateComponentPb != null)
			{
				this.InitWithPb(this.LogicStateComponentPb);
			}
			this.LogicStates = new int[4];
			this.LastLogicStates = new int[4];
			this.LogicStates[0] = (int)this.UnifiedStateComp.PositionState;
			this.LogicStates[1] = (int)this.UnifiedStateComp.MoveState;
			this.LogicStates[2] = (int)this.UnifiedStateComp.DirectionState;
			this.LogicStates[3] = (int)this.UnifiedStateComp.PositionSubState;
			for (int i = 0; i < this.LogicStates.Length; i++)
			{
				this.LastLogicStates[i] = this.LogicStates[i];
			}
		}

		// Token: 0x0603D766 RID: 251750 RVA: 0x011C7E4C File Offset: 0x011C604C
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget<bool>(base.Entity, EEventName.CharSwitchControl, new Action<bool>(this.OnSwitchControl));
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnRoleGoUp, new Action(this.OnRoleGoUp)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnRoleGoUp, new Action(this.OnRoleGoUp));
			}
			CombatMessageController.Instance.UnregisterAfterTick(this);
			return true;
		}

		// Token: 0x0603D767 RID: 251751 RVA: 0x011C7ECC File Offset: 0x011C60CC
		private void LogicStateInitRequest()
		{
			LogicStateInitPush logicStateInitPush = LogicStateInitPush.Create();
			if (this.IsRole)
			{
				logicStateInitPush.ClientEntityId = MathUtils.Instance.NumberToLong(this.GetClientEntityId());
			}
			logicStateInitPush.InitData = LogicStateComponentPb.Create();
			logicStateInitPush.InitData.PositionState = (int)this.UnifiedStateComp.PositionState;
			logicStateInitPush.InitData.MoveState = (int)this.UnifiedStateComp.MoveState;
			logicStateInitPush.InitData.DirectionState = (int)this.UnifiedStateComp.DirectionState;
			logicStateInitPush.InitData.PositionSubState = (int)this.UnifiedStateComp.PositionSubState;
			CombatNet.Instance.Send(EPushMessageId.LogicStateInitPush, base.Entity, logicStateInitPush, null, null, null);
		}

		// Token: 0x0603D768 RID: 251752 RVA: 0x011C7F94 File Offset: 0x011C6194
		private void InitWithPb(LogicStateComponentPb data)
		{
			this.SetLogicState(global::ELogicStateType.CharPositionState, data.PositionState);
			this.SetLogicState(global::ELogicStateType.CharMoveState, data.MoveState);
			this.SetLogicState(global::ELogicStateType.CharDirectionState, data.DirectionState);
			this.SetLogicState(global::ELogicStateType.CharPositionSubState, data.PositionSubState);
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.LogicState;
			Entity entity = base.Entity;
			string message = "初始化逻辑状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("states", new int[]
			{
				data.PositionState,
				data.MoveState,
				data.DirectionState,
				data.PositionSubState
			});
			instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.Inited = true;
		}

		// Token: 0x0603D769 RID: 251753 RVA: 0x011C8030 File Offset: 0x011C6230
		private void SetLogicState(global::ELogicStateType stateType, int value)
		{
			switch (stateType)
			{
			case global::ELogicStateType.CharPositionState:
				this.UnifiedStateComp.SetPositionStateHandle((global::ECharPositionState)value);
				return;
			case global::ELogicStateType.CharMoveState:
				this.UnifiedStateComp.SetMoveStateHandle((global::ECharMoveState)value);
				return;
			case global::ELogicStateType.CharDirectionState:
				this.UnifiedStateComp.SetDirectionStateHandle((ECharDirectionState)value);
				return;
			case global::ELogicStateType.CharPositionSubState:
				this.UnifiedStateComp.SetPositionSubStateHandle((global::ECharPositionSubState)value);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603D76A RID: 251754 RVA: 0x011C8087 File Offset: 0x011C6287
		public void OnSwitchControl(bool control)
		{
			if (control && !this.Inited)
			{
				this.LogicStateInitRequest();
				this.Inited = true;
			}
		}

		// Token: 0x0603D76B RID: 251755 RVA: 0x011C80A1 File Offset: 0x011C62A1
		private void OnRoleGoUp()
		{
			this.ForcePush = true;
		}

		// Token: 0x0603D76C RID: 251756 RVA: 0x011C80AA File Offset: 0x011C62AA
		[NullableContext(2)]
		[CombatListen(ENotifyMessageId.LogicStateInitNotify, true, false)]
		public static void LogicStateInitNotify(Entity entity, [Nullable(1)] LogicStateInitNotify data, CombatCommon combatCommon = null)
		{
			CharacterLogicStateSyncComponent characterLogicStateSyncComponent = (entity != null) ? entity.GetComponent<CharacterLogicStateSyncComponent>() : null;
			if (characterLogicStateSyncComponent == null)
			{
				return;
			}
			characterLogicStateSyncComponent.InitWithPb(data.InitData);
		}

		// Token: 0x0603D76D RID: 251757 RVA: 0x011C80C8 File Offset: 0x011C62C8
		private void ForceAfterTickInternal(float deltaTime)
		{
			if (!this.ActorComp.IsMoveAutonomousProxy)
			{
				return;
			}
			CharacterUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
			if (unifiedStateComp == null)
			{
				return;
			}
			bool flag = false;
			this.LogicStates[0] = (int)unifiedStateComp.PositionState;
			this.LogicStates[1] = (int)unifiedStateComp.MoveState;
			this.LogicStates[2] = (int)unifiedStateComp.DirectionState;
			this.LogicStates[3] = (int)unifiedStateComp.PositionSubState;
			for (int i = 0; i < this.LogicStates.Length; i++)
			{
				if (this.LogicStates[i] != this.LastLogicStates[i])
				{
					flag = true;
					break;
				}
			}
			if (flag || this.ForcePush)
			{
				this.ForcePush = false;
				SwitchLogicStatePush switchLogicStatePush = SwitchLogicStatePush.Create();
				switchLogicStatePush.States = LogicStateComponentPb.Create();
				if (this.IsRole)
				{
					switchLogicStatePush.ClientEntityId = MathUtils.Instance.NumberToLong(this.GetClientEntityId());
				}
				this.LastLogicStates[0] = (switchLogicStatePush.States.PositionState = (int)unifiedStateComp.PositionState);
				this.LastLogicStates[1] = (switchLogicStatePush.States.MoveState = (int)unifiedStateComp.MoveState);
				this.LastLogicStates[2] = (switchLogicStatePush.States.DirectionState = (int)unifiedStateComp.DirectionState);
				this.LastLogicStates[3] = (switchLogicStatePush.States.PositionSubState = (int)unifiedStateComp.PositionSubState);
				CombatNet.Instance.Send(EPushMessageId.SwitchLogicStatePush, base.Entity, switchLogicStatePush, null, null, null);
			}
		}

		// Token: 0x0603D76E RID: 251758 RVA: 0x011C8244 File Offset: 0x011C6444
		private long GetClientEntityId()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			int? num;
			if (actorComp == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent creatureData = actorComp.CreatureData;
				num = ((creatureData != null) ? new int?(creatureData.GetPlayerId()) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(valueOrDefault);
			long? num3;
			if (teamPlayerData == null)
			{
				num3 = null;
			}
			else
			{
				SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
				if (currentGroup == null)
				{
					num3 = null;
				}
				else
				{
					SceneTeamRole currentRole = currentGroup.GetCurrentRole();
					num3 = ((currentRole != null) ? new long?(currentRole.CreatureDataId) : null);
				}
			}
			long? num4 = num3;
			return num4.GetValueOrDefault();
		}

		// Token: 0x0603D76F RID: 251759 RVA: 0x011C82E4 File Offset: 0x011C64E4
		[NullableContext(2)]
		[CombatListen(ENotifyMessageId.SwitchLogicStateNotify, true, false)]
		public static void SwitchLogicStateNotify(Entity entity, [Nullable(1)] SwitchLogicStateNotify data, CombatCommon combatCommon = null)
		{
			CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
			if (characterActorComponent != null && characterActorComponent.IsMoveAutonomousProxy)
			{
				return;
			}
			CharacterLogicStateSyncComponent characterLogicStateSyncComponent = (entity != null) ? entity.GetComponent<CharacterLogicStateSyncComponent>() : null;
			if (characterLogicStateSyncComponent != null && data.States != null)
			{
				CharacterLogicStateSyncComponent.TransferNotifyState(characterLogicStateSyncComponent, 0, data.States.PositionState);
				CharacterLogicStateSyncComponent.TransferNotifyState(characterLogicStateSyncComponent, 1, data.States.MoveState);
				CharacterLogicStateSyncComponent.TransferNotifyState(characterLogicStateSyncComponent, 2, data.States.DirectionState);
				CharacterLogicStateSyncComponent.TransferNotifyState(characterLogicStateSyncComponent, 3, data.States.PositionSubState);
			}
		}

		// Token: 0x0603D770 RID: 251760 RVA: 0x011C836C File Offset: 0x011C656C
		private static void TransferNotifyState(CharacterLogicStateSyncComponent logicStateSyncComp, int stateType, int state)
		{
			if (state == 0)
			{
				return;
			}
			logicStateSyncComp.SetLogicState((global::ELogicStateType)stateType, (state == 127) ? 0 : state);
		}

		// Token: 0x0603D771 RID: 251761 RVA: 0x011C8384 File Offset: 0x011C6584
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterLogicStateSyncComponent characterLogicStateSyncComponent = (CharacterLogicStateSyncComponent)componentTemplate;
			if (characterLogicStateSyncComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterLogicStateSyncComponent.UnifiedStateComp == null)
			{
				this.UnifiedStateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComp), "UnifiedStateComp"))
			{
				return false;
			}
			if (characterLogicStateSyncComponent.LogicStateComponentPb == null)
			{
				this.LogicStateComponentPb = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LogicStateComponentPb), "LogicStateComponentPb"))
			{
				return false;
			}
			if (characterLogicStateSyncComponent.LogicStates == null)
			{
				this.LogicStates = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LogicStates), "LogicStates"))
			{
				return false;
			}
			if (characterLogicStateSyncComponent.LastLogicStates == null)
			{
				this.LastLogicStates = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastLogicStates), "LastLogicStates"))
			{
				return false;
			}
			this.IsRole = characterLogicStateSyncComponent.IsRole;
			this.Inited = characterLogicStateSyncComponent.Inited;
			this.ForcePush = characterLogicStateSyncComponent.ForcePush;
			return true;
		}

		// Token: 0x17007495 RID: 29845
		// (get) Token: 0x0603D772 RID: 251762 RVA: 0x011C849F File Offset: 0x011C669F
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007496 RID: 29846
		// (get) Token: 0x0603D773 RID: 251763 RVA: 0x011C84A2 File Offset: 0x011C66A2
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007497 RID: 29847
		// (get) Token: 0x0603D774 RID: 251764 RVA: 0x011C84A5 File Offset: 0x011C66A5
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402098B RID: 133515
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x0402098C RID: 133516
		[Nullable(2)]
		private CharacterUnifiedStateComponent UnifiedStateComp;

		// Token: 0x0402098D RID: 133517
		[Nullable(2)]
		private LogicStateComponentPb LogicStateComponentPb;

		// Token: 0x0402098E RID: 133518
		private int[] LogicStates = Array.Empty<int>();

		// Token: 0x0402098F RID: 133519
		private int[] LastLogicStates = Array.Empty<int>();

		// Token: 0x04020990 RID: 133520
		private bool IsRole;

		// Token: 0x04020991 RID: 133521
		public bool Inited;

		// Token: 0x04020992 RID: 133522
		private bool ForcePush;
	}
}
