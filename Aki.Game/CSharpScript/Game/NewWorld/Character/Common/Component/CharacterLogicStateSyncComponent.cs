using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CombatMessage;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070C6 RID: 28870
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterLogicStateSyncComponent : EntityComponent
	{
		// Token: 0x0604667D RID: 288381 RVA: 0x011A866C File Offset: 0x011A686C
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

		// Token: 0x0604667E RID: 288382 RVA: 0x011A86FC File Offset: 0x011A68FC
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

		// Token: 0x0604667F RID: 288383 RVA: 0x011A880C File Offset: 0x011A6A0C
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

		// Token: 0x06046680 RID: 288384 RVA: 0x011A888C File Offset: 0x011A6A8C
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

		// Token: 0x06046681 RID: 288385 RVA: 0x011A8954 File Offset: 0x011A6B54
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

		// Token: 0x06046682 RID: 288386 RVA: 0x011A89F0 File Offset: 0x011A6BF0
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

		// Token: 0x06046683 RID: 288387 RVA: 0x011A8A47 File Offset: 0x011A6C47
		public void OnSwitchControl(bool control)
		{
			if (control && !this.Inited)
			{
				this.LogicStateInitRequest();
				this.Inited = true;
			}
		}

		// Token: 0x06046684 RID: 288388 RVA: 0x011A8A61 File Offset: 0x011A6C61
		private void OnRoleGoUp()
		{
			this.ForcePush = true;
		}

		// Token: 0x06046685 RID: 288389 RVA: 0x011A8A6A File Offset: 0x011A6C6A
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

		// Token: 0x06046686 RID: 288390 RVA: 0x011A8A88 File Offset: 0x011A6C88
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

		// Token: 0x06046687 RID: 288391 RVA: 0x011A8C04 File Offset: 0x011A6E04
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

		// Token: 0x06046688 RID: 288392 RVA: 0x011A8CA4 File Offset: 0x011A6EA4
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

		// Token: 0x06046689 RID: 288393 RVA: 0x011A8D2C File Offset: 0x011A6F2C
		private static void TransferNotifyState(CharacterLogicStateSyncComponent logicStateSyncComp, int stateType, int state)
		{
			if (state == 0)
			{
				return;
			}
			logicStateSyncComp.SetLogicState((global::ELogicStateType)stateType, (state == 127) ? 0 : state);
		}

		// Token: 0x0604668A RID: 288394 RVA: 0x011A8D44 File Offset: 0x011A6F44
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterLogicStateSyncComponent characterLogicStateSyncComponent = (CharacterLogicStateSyncComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterLogicStateSyncComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("UnifiedStateComp"))
			{
				if (characterLogicStateSyncComponent.UnifiedStateComp == null)
				{
					this.UnifiedStateComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComp), "UnifiedStateComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LogicStateComponentPb"))
			{
				if (characterLogicStateSyncComponent.LogicStateComponentPb == null)
				{
					this.LogicStateComponentPb = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LogicStateComponentPb>(this.LogicStateComponentPb), "LogicStateComponentPb"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LogicStates"))
			{
				if (characterLogicStateSyncComponent.LogicStates == null)
				{
					this.LogicStates = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int[]>(this.LogicStates), "LogicStates"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastLogicStates"))
			{
				if (characterLogicStateSyncComponent.LastLogicStates == null)
				{
					this.LastLogicStates = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int[]>(this.LastLogicStates), "LastLogicStates"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsRole"))
			{
				this.IsRole = characterLogicStateSyncComponent.IsRole;
			}
			if (base.CanResetComponentProperty("Inited"))
			{
				this.Inited = characterLogicStateSyncComponent.Inited;
			}
			if (base.CanResetComponentProperty("ForcePush"))
			{
				this.ForcePush = characterLogicStateSyncComponent.ForcePush;
			}
			return true;
		}

		// Token: 0x04024E4D RID: 151117
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04024E4E RID: 151118
		[Nullable(2)]
		private CharacterUnifiedStateComponent UnifiedStateComp;

		// Token: 0x04024E4F RID: 151119
		[Nullable(2)]
		private LogicStateComponentPb LogicStateComponentPb;

		// Token: 0x04024E50 RID: 151120
		private int[] LogicStates = Array.Empty<int>();

		// Token: 0x04024E51 RID: 151121
		private int[] LastLogicStates = Array.Empty<int>();

		// Token: 0x04024E52 RID: 151122
		private bool IsRole;

		// Token: 0x04024E53 RID: 151123
		public bool Inited;

		// Token: 0x04024E54 RID: 151124
		private bool ForcePush;
	}
}
