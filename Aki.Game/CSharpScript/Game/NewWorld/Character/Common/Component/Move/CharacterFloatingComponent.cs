using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x02006394 RID: 25492
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterFloatingComponent : EntityComponent, IStaticVariableResetter
	{
		// Token: 0x0603DC64 RID: 253028 RVA: 0x011E8D42 File Offset: 0x011E6F42
		static CharacterFloatingComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterFloatingComponent.CreateStaticDefaultValue), new Action(CharacterFloatingComponent.ResetStaticDefaultValue));
		}

		// Token: 0x17007530 RID: 30000
		// (get) Token: 0x0603DC65 RID: 253029 RVA: 0x011E8D81 File Offset: 0x011E6F81
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x17007531 RID: 30001
		// (get) Token: 0x0603DC66 RID: 253030 RVA: 0x011E8D96 File Offset: 0x011E6F96
		public bool IsFloating
		{
			get
			{
				return this.InFloatingState;
			}
		}

		// Token: 0x17007532 RID: 30002
		// (get) Token: 0x0603DC67 RID: 253031 RVA: 0x011E8D9E File Offset: 0x011E6F9E
		public bool IsFloatingMove
		{
			get
			{
				return this.Speed > 1f;
			}
		}

		// Token: 0x17007533 RID: 30003
		// (get) Token: 0x0603DC68 RID: 253032 RVA: 0x011E8DB0 File Offset: 0x011E6FB0
		public Vector FloatingLocalDirection
		{
			get
			{
				Vector tempVector = this.TempVector;
				FTransformDouble actorTransform = this.ActorComp.ActorTransform;
				FVectorDouble fvectorDouble = this.TempInputDirection.ToUeVector(false);
				FVectorDouble fvectorDouble2 = actorTransform.InverseTransformVector(fvectorDouble);
				tempVector.FromUeVector(fvectorDouble2);
				return this.TempVector;
			}
		}

		// Token: 0x17007534 RID: 30004
		// (get) Token: 0x0603DC69 RID: 253033 RVA: 0x011E8DF3 File Offset: 0x011E6FF3
		public float FloatingMoveMix
		{
			get
			{
				return this.FloatingMoveMixInternal;
			}
		}

		// Token: 0x17007535 RID: 30005
		// (get) Token: 0x0603DC6A RID: 253034 RVA: 0x011E8DFB File Offset: 0x011E6FFB
		public float FloatingSpeedMix
		{
			get
			{
				return this.FloatingSpeedMixInternal;
			}
		}

		// Token: 0x17007536 RID: 30006
		// (get) Token: 0x0603DC6B RID: 253035 RVA: 0x011E8E03 File Offset: 0x011E7003
		public float Speed
		{
			get
			{
				return this.SpeedInternal;
			}
		}

		// Token: 0x0603DC6C RID: 253036 RVA: 0x011E8E0B File Offset: 0x011E700B
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603DC6D RID: 253037 RVA: 0x011E8E10 File Offset: 0x011E7010
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			this.StateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
			this.TimeScaleComp = base.Entity.GetComponent<CharacterTimeScaleComponent>();
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			this.InputComp = base.Entity.GetComponent<CharacterInputComponent>();
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			if (creatureDataComp != null && creatureDataComp.Valid && CreatureModel.Instance.GetPlayerId() == this.CreatureDataComp.GetPlayerId())
			{
				this.AddFloatingStateListener();
				this.InitFloatingStateMachine();
				EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnBeforeChangeRole, new Action<EntityHandle, EntityHandle>(this.OnBeforeChangeRole));
				EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
				EventSystem.Instance.AddWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
				EventSystem.Instance.AddWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.OnUnifiedMoveStateChanged));
				EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnRoleGoUpEnable, new Action(this.OnRoleInheritTransform));
			}
			this.ComponentDisableHandle = base.Disable("悬浮组件默认禁用");
			return true;
		}

		// Token: 0x0603DC6E RID: 253038 RVA: 0x011E8FB4 File Offset: 0x011E71B4
		protected override void OnEnable()
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterFloatingState(true);
			this.ClearCacheInputDirect();
			EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnBeginSkill));
			EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
		}

		// Token: 0x0603DC6F RID: 253039 RVA: 0x011E9014 File Offset: 0x011E7214
		protected override void OnDisable(string reason)
		{
			this.ClearCacheInputDirect();
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnBeginSkill)))
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnBeginSkill));
			}
			if (EventSystem.Instance.HasWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd)))
			{
				EventSystem.Instance.RemoveWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
			}
		}

		// Token: 0x0603DC70 RID: 253040 RVA: 0x011E90A8 File Offset: 0x011E72A8
		protected override bool OnEnd()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.IsAutonomousProxy)
			{
				return true;
			}
			this.StateMachine = null;
			ITagTask floatingEnableListener = this.FloatingEnableListener;
			if (floatingEnableListener != null)
			{
				floatingEnableListener.EndTask();
			}
			ITagTask floatingMoveModeListener = this.FloatingMoveModeListener;
			if (floatingMoveModeListener != null)
			{
				floatingMoveModeListener.EndTask();
			}
			ITagTask floatingSprintListener = this.FloatingSprintListener;
			if (floatingSprintListener != null)
			{
				floatingSprintListener.EndTask();
			}
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnBeforeChangeRole, new Action<EntityHandle, EntityHandle>(this.OnBeforeChangeRole));
			EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem.Instance.RemoveWithTarget<ECharPositionState, ECharPositionState>(base.Entity, EEventName.CharOnPositionStateChanged, new Action<ECharPositionState, ECharPositionState>(this.OnPositionStateChanged));
			EventSystem.Instance.RemoveWithTarget<ECharMoveState, ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<ECharMoveState, ECharMoveState>(this.OnUnifiedMoveStateChanged));
			EventSystem.Instance.RemoveWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnRoleGoUpEnable, new Action(this.OnRoleInheritTransform));
			return true;
		}

		// Token: 0x0603DC71 RID: 253041 RVA: 0x011E91CC File Offset: 0x011E73CC
		public void EnableFloating(string daPath)
		{
			if (this.InFloatingState)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[悬浮模式]重复进入";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("daPath", daPath);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.InFloatingState = true;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[悬浮模式][总开关]进入悬浮模式";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("daPath", daPath);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.InitConfig(daPath, new Action(this.EnterFloatingInternal));
		}

		// Token: 0x0603DC72 RID: 253042 RVA: 0x011E924C File Offset: 0x011E744C
		public void DisableFloating()
		{
			if (!this.InFloatingState)
			{
				return;
			}
			this.InFloatingState = false;
			Log.Instance.Info(ELogModule.Movement, ELogAuthor.LJM, "[悬浮模式][总开关]离开悬浮模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.LeaveFloatingInternal();
		}

		// Token: 0x0603DC73 RID: 253043 RVA: 0x011E928B File Offset: 0x011E748B
		public void JumpPressInAir()
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterRiseState();
		}

		// Token: 0x0603DC74 RID: 253044 RVA: 0x011E9299 File Offset: 0x011E7499
		public void JumpRelease()
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterFloatingState(false);
		}

		// Token: 0x0603DC75 RID: 253045 RVA: 0x011E92A8 File Offset: 0x011E74A8
		public void CtrlPress()
		{
			if (Info.Instance.IsInTouch())
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.EnterDropState();
			}
		}

		// Token: 0x0603DC76 RID: 253046 RVA: 0x011E92C2 File Offset: 0x011E74C2
		public void CtrlRelease()
		{
			if (this.FloatingMoveType == EFloatingMovementType.Drop)
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.EnterFloatingState(false);
				return;
			}
			bool debug2 = CharacterFloatingComponent.Debug;
			this.EnterDropState();
		}

		// Token: 0x0603DC77 RID: 253047 RVA: 0x011E92E7 File Offset: 0x011E74E7
		private void EnterDefaultState()
		{
			if (this.FloatingMoveType == EFloatingMovementType.None)
			{
				return;
			}
			this.UpdateState(EFloatingMovementType.None);
		}

		// Token: 0x0603DC78 RID: 253048 RVA: 0x011E92FA File Offset: 0x011E74FA
		private void EnterRiseState()
		{
			this.EnterFloatingInternal();
			if (this.FloatingMoveType == EFloatingMovementType.Rise)
			{
				return;
			}
			if (this.UpdateState(EFloatingMovementType.Rise))
			{
				return;
			}
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterFloatingState(false);
		}

		// Token: 0x0603DC79 RID: 253049 RVA: 0x011E9323 File Offset: 0x011E7523
		private void EnterFloatingState(bool forceEnter = false)
		{
			this.EnterFloatingInternal();
			if (this.FloatingMoveType == EFloatingMovementType.Floating && !forceEnter)
			{
				return;
			}
			if (this.UpdateState(EFloatingMovementType.Floating))
			{
				return;
			}
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterDropState();
		}

		// Token: 0x0603DC7A RID: 253050 RVA: 0x011E934E File Offset: 0x011E754E
		private void EnterDropState()
		{
			this.EnterFloatingInternal();
			if (this.FloatingMoveType == EFloatingMovementType.Drop)
			{
				return;
			}
			if (this.UpdateState(EFloatingMovementType.Drop))
			{
				return;
			}
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterWalkState();
		}

		// Token: 0x0603DC7B RID: 253051 RVA: 0x011E9376 File Offset: 0x011E7576
		private void EnterWalkState()
		{
			if (this.FloatingMoveType == EFloatingMovementType.Walk)
			{
				return;
			}
			if (this.UpdateState(EFloatingMovementType.Walk))
			{
				return;
			}
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterDropState();
		}

		// Token: 0x0603DC7C RID: 253052 RVA: 0x011E9398 File Offset: 0x011E7598
		private bool UpdateState(EFloatingMovementType state)
		{
			return this.StateMachine.Switch(state);
		}

		// Token: 0x0603DC7D RID: 253053 RVA: 0x011E93A8 File Offset: 0x011E75A8
		private void EnterFloatingInternal()
		{
			CharacterUnifiedStateComponent stateComp = this.StateComp;
			if (stateComp == null || stateComp.PositionState != ECharPositionState.Floating)
			{
				CharacterMoveComponent moveComp = this.MoveComp;
				if (moveComp != null)
				{
					CharacterActorComponent actorComp = moveComp.ActorComp;
					if (actorComp != null)
					{
						actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
						{
							Mode = EMovementMode.MOVE_Custom,
							CustomMode = 15,
							Context = "[CharacterFloatingComponent.Enter]"
						});
					}
				}
			}
			if (this.ComponentDisableHandle != -1)
			{
				int componentDisableHandle = this.ComponentDisableHandle;
				this.ComponentDisableHandle = -1;
				base.Enable(new int?(componentDisableHandle), "[悬浮模式][总开关]开启悬浮组件Tick功能");
			}
		}

		// Token: 0x0603DC7E RID: 253054 RVA: 0x011E9438 File Offset: 0x011E7638
		private void LeaveFloatingInternal()
		{
			bool flag = this.IsOnGround || this.IsNearGround;
			this.ReleaseGroundTag();
			this.IsOnWater = false;
			this.IsOnGround = false;
			this.IsNearGround = false;
			this.CurrentBase = null;
			CharacterUnifiedStateComponent stateComp = this.StateComp;
			if (stateComp != null && stateComp.PositionState == ECharPositionState.Floating)
			{
				if (flag)
				{
					CharacterActorComponent actorComp = this.ActorComp;
					if (actorComp != null)
					{
						actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
						{
							Mode = EMovementMode.MOVE_Walking,
							Context = "[CharacterFloatingComponent.Leave] Walking"
						});
					}
				}
				else
				{
					CharacterMoveComponent moveComp = this.MoveComp;
					if (moveComp != null)
					{
						CharacterActorComponent actorComp2 = moveComp.ActorComp;
						if (actorComp2 != null)
						{
							actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
							{
								Mode = EMovementMode.MOVE_Falling,
								Context = "[CharacterFloatingComponent.Leave] Falling"
							});
						}
					}
				}
			}
			CharacterMoveComponent moveComp2 = this.MoveComp;
			if (moveComp2 != null)
			{
				moveComp2.SetForceSpeed(Vector.ZeroVectorProxy);
			}
			if (this.ComponentDisableHandle == -1)
			{
				this.ComponentDisableHandle = base.Disable("[悬浮模式][总开关]关闭悬浮组件Tick功能");
			}
		}

		// Token: 0x0603DC7F RID: 253055 RVA: 0x011E952A File Offset: 0x011E772A
		private bool QueryInputAction(AkiClient.Game.Aki.Character.Input.Enum.EInputAction inputAction)
		{
			return this.InputComp != null && InputController.Instance.IsKeyDown(inputAction);
		}

		// Token: 0x0603DC80 RID: 253056 RVA: 0x011E9546 File Offset: 0x011E7746
		private void OnPositionStateChanged(ECharPositionState oldPositionState, ECharPositionState newPositionState)
		{
			if (!this.InFloatingState)
			{
				return;
			}
			if (newPositionState == ECharPositionState.Floating)
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.EnterFloatingState(false);
			}
			else if (oldPositionState == ECharPositionState.Floating)
			{
				bool debug2 = CharacterFloatingComponent.Debug;
				this.EnterDefaultState();
			}
			this.ClearCacheInputDirect();
		}

		// Token: 0x0603DC81 RID: 253057 RVA: 0x011E957A File Offset: 0x011E777A
		private void OnUnifiedMoveStateChanged(ECharMoveState oldMoveState, ECharMoveState newMoveState)
		{
			if (!this.InFloatingState)
			{
				return;
			}
			if (newMoveState == ECharMoveState.Floating || newMoveState == ECharMoveState.Rise || newMoveState == ECharMoveState.Drop || newMoveState == ECharMoveState.FloatingGround)
			{
				return;
			}
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterDefaultState();
		}

		// Token: 0x0603DC82 RID: 253058 RVA: 0x011E95A8 File Offset: 0x011E77A8
		[NullableContext(2)]
		private void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
		{
			if (other == null || !other.Valid)
			{
				return;
			}
			CharacterUnifiedStateComponent component = other.GetComponent<CharacterUnifiedStateComponent>();
			if (component == null || !component.Valid)
			{
				return;
			}
			CharacterFloatingComponent component2 = other.GetComponent<CharacterFloatingComponent>();
			if (component2 == null || !component2.Valid || !component2.InFloatingState)
			{
				return;
			}
			if (!this.InFloatingState)
			{
				if (!component2.IsNearGround)
				{
					CharacterMoveComponent moveComp = this.MoveComp;
					if (moveComp == null)
					{
						return;
					}
					CharacterActorComponent actorComp = moveComp.ActorComp;
					if (actorComp == null)
					{
						return;
					}
					actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Falling,
						Context = "[CharacterFloatingComponent.OnStateInherit] Falling"
					});
					return;
				}
			}
			else
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.StateComp.SetPositionState(component.PositionState);
			}
		}

		// Token: 0x0603DC83 RID: 253059 RVA: 0x011E965F File Offset: 0x011E785F
		private void OnRoleInheritTransform()
		{
			if (!this.InFloatingState)
			{
				return;
			}
			this.DetectFloor();
			this.CheckGround();
		}

		// Token: 0x0603DC84 RID: 253060 RVA: 0x011E9677 File Offset: 0x011E7877
		private void OnBeginSkill(int skillId, bool isAutonomousProxy)
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterDefaultState();
			this.ClearCacheInputDirect();
		}

		// Token: 0x0603DC85 RID: 253061 RVA: 0x011E968B File Offset: 0x011E788B
		private void OnCharSkillEnd(int entityId, int skillId)
		{
			if (this.StateComp.PositionState != ECharPositionState.Floating)
			{
				return;
			}
			if (this.FloatingMoveType == EFloatingMovementType.None || this.FloatingMoveType == EFloatingMovementType.Drop)
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.EnterFloatingState(false);
			}
			this.ClearCacheInputDirect();
		}

		// Token: 0x0603DC86 RID: 253062 RVA: 0x011E96C0 File Offset: 0x011E78C0
		private void OnBeforeChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			if (!this.InFloatingState)
			{
				return;
			}
			if (newEntity == oldEntity || base.Entity != ((oldEntity != null) ? oldEntity.Entity : null))
			{
				return;
			}
			this.WasNearGround = this.IsNearGround;
			this.WasNearGroundDist = this.NearGroundDist;
			this.WasOnGround = this.IsOnGround;
			CharacterMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.SetForceSpeed(Vector.ZeroVectorProxy);
			}
			this.SpeedInternal = 0f;
		}

		// Token: 0x0603DC87 RID: 253063 RVA: 0x011E9734 File Offset: 0x011E7934
		private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			if (this.Config == null || !this.InFloatingState)
			{
				return;
			}
			if (newEntity.Id == base.Entity.Id)
			{
				if (this.StateComp.PositionState != ECharPositionState.Floating)
				{
					return;
				}
				if (this.FloatingMoveType == EFloatingMovementType.None || this.FloatingMoveType == EFloatingMovementType.Drop)
				{
					bool debug = CharacterFloatingComponent.Debug;
					this.EnterFloatingState(false);
				}
				this.ClearCacheInputDirect();
			}
			int? num = (oldEntity != null) ? new int?(oldEntity.Id) : null;
			int id = base.Entity.Id;
			if (num.GetValueOrDefault() == id & num != null)
			{
				bool debug2 = CharacterFloatingComponent.Debug;
				this.EnterDefaultState();
				this.ClearCacheInputDirect();
			}
		}

		// Token: 0x0603DC88 RID: 253064 RVA: 0x011E97E4 File Offset: 0x011E79E4
		protected override void OnTick(float delta)
		{
			this.HasFloatingMoveInput = false;
			if (this.InFloatingState && this.Config != null && this.ActorComp != null)
			{
				CharacterMoveComponent moveComp = this.MoveComp;
				if (moveComp != null && moveComp.Active && this.TagComp != null && this.AnimComp != null && this.StateComp != null && this.TimeScaleComp != null && this.CreatureDataComp != null && this.StateMachine != null)
				{
					if ((this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom && this.MoveComp.CharacterMovement.CustomMovementMode == 5) || this.StateComp.PositionSubState == ECharPositionSubState.WaterSurface)
					{
						this.RefreshMoveState();
						this.TriggerFloatingMoveEvent();
						return;
					}
					if (this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Falling)
					{
						this.EnterDefaultState();
						this.TriggerFloatingMoveEvent();
						return;
					}
					if (this.StateComp.PositionState == ECharPositionState.Ground)
					{
						this.EnterFloatingInternal();
						this.TriggerFloatingMoveEvent();
						return;
					}
					if (this.StateComp.PositionState != ECharPositionState.Floating)
					{
						return;
					}
					this.RefreshMoveState();
					this.TriggerFloatingMoveEvent();
					this.StateMachine.Update(delta * this.TimeScaleComp.CurrentTimeScale * this.ActorComp.TimeDilation * 0.001f);
					return;
				}
			}
			this.TriggerFloatingMoveEvent();
		}

		// Token: 0x0603DC89 RID: 253065 RVA: 0x011E9932 File Offset: 0x011E7B32
		public void UpdateMove(float deltaSeconds, Vector output)
		{
			output.DeepCopy(this.ActorComp.InputDirectProxy);
			this.TempInputDirection.DeepCopy(output);
			output.MultiplyEqual((double)(this.SpeedInternal * deltaSeconds));
		}

		// Token: 0x0603DC8A RID: 253066 RVA: 0x011E9964 File Offset: 0x011E7B64
		public void UpdateSpeed(float second)
		{
			if (this.ActorComp.InputDirectProxy.IsNearlyZero(0.0001))
			{
				if (this.Speed > 0f)
				{
					this.SpeedInternal = Math.Max(this.Speed - this.Config.SpeedAcceleration * second, 0f);
				}
				else
				{
					this.SpeedInternal = 0f;
				}
				this.FloatingMoveMixInternal = MathUtils.Instance.Lerp(this.FloatingMoveMix, 0f, this.Config.AnimLerpAlpha);
				return;
			}
			if (this.IsSprintMove)
			{
				if (this.Speed < this.Config.SprintSpeed)
				{
					this.SpeedInternal = Math.Min(this.Speed + this.Config.SpeedAcceleration * second, this.Config.SprintSpeed);
				}
				else
				{
					this.SpeedInternal = Math.Max(this.Speed - this.Config.SpeedAcceleration * second, this.Config.SprintSpeed);
				}
				this.FloatingMoveMixInternal = MathUtils.Instance.Lerp(this.FloatingMoveMix, 1f, this.Config.AnimLerpAlpha);
				return;
			}
			if (this.Speed < this.Config.MoveSpeed)
			{
				this.SpeedInternal = Math.Min(this.Speed + this.Config.SpeedAcceleration * second, this.Config.MoveSpeed);
			}
			else
			{
				this.SpeedInternal = Math.Max(this.Speed - this.Config.SpeedAcceleration * second, this.Config.MoveSpeed);
			}
			this.FloatingMoveMixInternal = MathUtils.Instance.Lerp(this.FloatingMoveMix, 0.5f, this.Config.AnimLerpAlpha);
		}

		// Token: 0x0603DC8B RID: 253067 RVA: 0x011E9B1C File Offset: 0x011E7D1C
		public void CloseToGround(float deltaSeconds)
		{
			if (this.TagComp.HasAnyTag(this.Config.ForbidCloseToGroundTagList))
			{
				return;
			}
			float floorDistance = this.GetFloorDistance();
			float num = Math.Min(this.WaterDist, floorDistance);
			if (num > 3f && num < this.Config.CloseToGroundHeight)
			{
				this.TempVector2.DeepCopy(this.MoveComp.GravityDirect);
				this.TempVector2.MultiplyEqual((double)num);
				this.TempVector2.AdditionEqual(this.ActorComp.ActorLocationProxy);
				this.TempVector.DeepCopy(this.ActorComp.ActorLocationProxy);
				MathUtils.Instance.VectorInterpTo(this.TempVector, this.TempVector2, (double)deltaSeconds, 3.0, this.TempVector3);
				this.TempVector3.Subtraction(this.TempVector, this.TempVector2);
				this.MoveDelta.AdditionEqual(this.TempVector2);
			}
		}

		// Token: 0x0603DC8C RID: 253068 RVA: 0x011E9C14 File Offset: 0x011E7E14
		public void CheckGround()
		{
			float floorDistance = this.GetFloorDistance();
			this.IsNearGround = (floorDistance < this.Config.AirCriticalHeight);
			this.NearGroundDist = (this.IsNearGround ? floorDistance : -1f);
			if (this.IsNearGround)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.近地"]))
				{
					BaseTagComponent tagComp2 = this.TagComp;
					if (tagComp2 == null)
					{
						goto IL_D7;
					}
					tagComp2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.近地"]));
					goto IL_D7;
				}
			}
			if (!this.IsNearGround)
			{
				BaseTagComponent tagComp3 = this.TagComp;
				if (tagComp3 != null && tagComp3.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.近地"]))
				{
					BaseTagComponent tagComp4 = this.TagComp;
					if (tagComp4 != null)
					{
						tagComp4.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.近地"]));
					}
				}
			}
			IL_D7:
			this.IsOnWater = (this.WaterDist < 3f);
			this.IsOnGround = (floorDistance < 3f);
			if (this.IsOnGround)
			{
				if (this.HasGroundTag)
				{
					BaseTagComponent tagComp5 = this.TagComp;
					if (tagComp5 != null && tagComp5.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]))
					{
						goto IL_18A;
					}
				}
				BaseTagComponent tagComp6 = this.TagComp;
				if (tagComp6 != null)
				{
					tagComp6.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]));
				}
				this.HasGroundTag = true;
				CharacterUnifiedStateComponent stateComp = this.StateComp;
				if (stateComp == null || stateComp.PositionSubState != ECharPositionSubState.FloatingOnGround)
				{
					CharacterUnifiedStateComponent stateComp2 = this.StateComp;
					if (stateComp2 != null)
					{
						stateComp2.SetPositionSubState(ECharPositionSubState.FloatingOnGround, false);
					}
				}
				IL_18A:
				if (this.HasAirTag)
				{
					BaseTagComponent tagComp7 = this.TagComp;
					if (tagComp7 != null && tagComp7.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
					{
						BaseTagComponent tagComp8 = this.TagComp;
						if (tagComp8 != null)
						{
							tagComp8.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]));
						}
						this.HasAirTag = false;
						CharacterUnifiedStateComponent stateComp3 = this.StateComp;
						if (stateComp3 != null && stateComp3.PositionSubState == ECharPositionSubState.FloatingOnAir)
						{
							CharacterUnifiedStateComponent stateComp4 = this.StateComp;
							if (stateComp4 != null)
							{
								stateComp4.SetPositionSubState(ECharPositionSubState.None, false);
							}
						}
					}
				}
			}
			else
			{
				if (!this.IsOnWater)
				{
					if (this.HasAirTag)
					{
						BaseTagComponent tagComp9 = this.TagComp;
						if (tagComp9 != null && tagComp9.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
						{
							goto IL_2AF;
						}
					}
					BaseTagComponent tagComp10 = this.TagComp;
					if (tagComp10 != null)
					{
						tagComp10.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]));
					}
					this.HasAirTag = true;
					CharacterUnifiedStateComponent stateComp5 = this.StateComp;
					if (stateComp5 == null || stateComp5.PositionSubState != ECharPositionSubState.FloatingOnAir)
					{
						CharacterUnifiedStateComponent stateComp6 = this.StateComp;
						if (stateComp6 != null)
						{
							stateComp6.SetPositionSubState(ECharPositionSubState.FloatingOnAir, false);
						}
					}
				}
				IL_2AF:
				if (this.HasGroundTag)
				{
					BaseTagComponent tagComp11 = this.TagComp;
					if (tagComp11 != null && tagComp11.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]))
					{
						BaseTagComponent tagComp12 = this.TagComp;
						if (tagComp12 != null)
						{
							tagComp12.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]));
						}
						this.HasGroundTag = false;
						CharacterUnifiedStateComponent stateComp7 = this.StateComp;
						if (stateComp7 != null && stateComp7.PositionSubState == ECharPositionSubState.FloatingOnGround)
						{
							CharacterUnifiedStateComponent stateComp8 = this.StateComp;
							if (stateComp8 != null)
							{
								stateComp8.SetPositionSubState(ECharPositionSubState.None, false);
							}
						}
					}
				}
			}
			if (floorDistance >= this.Config.CloseToGroundHeight)
			{
				if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.悬浮贴地中"]))
				{
					this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.悬浮贴地中"]));
					return;
				}
			}
			else if (!this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.悬浮贴地中"]))
			{
				this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.悬浮贴地中"]));
			}
		}

		// Token: 0x0603DC8D RID: 253069 RVA: 0x011E9FD8 File Offset: 0x011E81D8
		public void ReleaseGroundTag()
		{
			if (this.IsNearGround)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.近地"]))
				{
					BaseTagComponent tagComp2 = this.TagComp;
					if (tagComp2 != null)
					{
						tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.悬浮.近地"]));
					}
				}
			}
			this.IsNearGround = false;
			if (this.HasAirTag)
			{
				BaseTagComponent tagComp3 = this.TagComp;
				if (tagComp3 != null && tagComp3.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
				{
					BaseTagComponent tagComp4 = this.TagComp;
					if (tagComp4 != null)
					{
						tagComp4.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]));
					}
				}
			}
			this.HasAirTag = false;
			if (this.HasGroundTag)
			{
				BaseTagComponent tagComp5 = this.TagComp;
				if (tagComp5 != null && tagComp5.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]))
				{
					BaseTagComponent tagComp6 = this.TagComp;
					if (tagComp6 != null)
					{
						tagComp6.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.地面"]));
					}
				}
			}
			this.HasGroundTag = false;
		}

		// Token: 0x0603DC8E RID: 253070 RVA: 0x011EA0F0 File Offset: 0x011E82F0
		public bool GetTargetDirectionProjection(Vector outVector)
		{
			if (CameraModel.Instance.MainModel.HasLockTarget())
			{
				CameraModel.Instance.MainModel.GetLockTargetLocation(this.TempVector);
				this.TempVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
				this.TempVector.Normalize(9.99999993922529E-09);
			}
			else
			{
				FVectorDouble fvectorDouble = Global.CharacterCameraManager.GetCameraRotation().VectorDouble();
				this.TempVector.DeepCopy(fvectorDouble);
			}
			Vector gravityDirect = this.MoveComp.GravityDirect;
			Vector.VectorPlaneProject(this.TempVector, gravityDirect, outVector);
			return outVector.Normalize(9.99999993922529E-09);
		}

		// Token: 0x0603DC8F RID: 253071 RVA: 0x011EA19C File Offset: 0x011E839C
		public void RotatorFloatingDirection(float deltaSeconds, Vector cameraDirection)
		{
			if (cameraDirection.IsNearlyZero(9.999999747378752E-05))
			{
				return;
			}
			Vector actorUpProxy = this.ActorComp.ActorUpProxy;
			float turnSpeedDeg = this.Config.TurnSpeedDeg;
			Vector.VectorPlaneProject(this.ActorComp.ActorForwardProxy, this.MoveComp.GravityDirect, this.TempVector);
			if (!this.TempVector.IsNearlyZero(9.999999747378752E-05))
			{
				this.TempVector.Normalize(9.99999993922529E-09);
				double value = MathUtils.Instance.SignedAngleOnPlaneDeg(this.TempVector, cameraDirection, actorUpProxy);
				float num = turnSpeedDeg * deltaSeconds * 2f;
				double alpha = MathUtils.Instance.Clamp(Math.Abs(value) / 180.0, 0.0, 1.0);
				double value2 = MathUtils.Instance.LerpCubic(0.0, 1.2000000476837158, 1.0, 0.800000011920929, alpha);
				double num2 = MathUtils.Instance.RangeClamp(value2, 0.0, 1.0, 0.10000000149011612, 1.0);
				double num3 = Math.Min(Math.Abs(value), (double)num * num2);
				double angleDeg = (double)Math.Sign(value) * num3;
				this.TempVector.RotateAngleAxis(angleDeg, actorUpProxy, this.TempVector);
				MathUtils.Instance.LookRotationForwardFirst(this.TempVector, actorUpProxy, this.TempRotator);
			}
			else
			{
				MathUtils.Instance.LookRotationForwardFirst(cameraDirection, actorUpProxy, this.TempRotator);
			}
			this.ActorComp.SetActorRotation(this.TempRotator.ToUeRotator(), "RailSlide.TangentRotator", false);
			this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, false);
		}

		// Token: 0x0603DC90 RID: 253072 RVA: 0x011EA368 File Offset: 0x011E8568
		public bool DetectFloor()
		{
			this.DetectWaterDist();
			this.ActorComp.RefreshCurrentFloor();
			this.CurrentFloor = this.MoveComp.CharacterMovement.CurrentFloor;
			this.RefreshMovementBase();
			if (this.CurrentFloor == null)
			{
				return this.DetectHeightNonFloor();
			}
			AActor aactor = this.CurrentFloor.HitResult.Actor.Get();
			if (aactor == null || !aactor.IsValid())
			{
				return this.DetectHeightNonFloor();
			}
			return (this.CurrentFloor.bWalkableFloor && this.CurrentFloor.FloorDist < 3f) || this.DetectHeightNonFloor();
		}

		// Token: 0x0603DC91 RID: 253073 RVA: 0x011EA410 File Offset: 0x011E8610
		private void DetectWaterDist()
		{
			float heightDetect = Math.Max(550f, this.Config.CloseToGroundHeight);
			float heightAboveWater = this.MoveComp.GetHeightAboveWater(heightDetect);
			this.WaterDist = heightAboveWater;
		}

		// Token: 0x0603DC92 RID: 253074 RVA: 0x011EA448 File Offset: 0x011E8648
		private bool DetectHeightNonFloor()
		{
			float heightDetect = Math.Max(this.Config.AirCriticalHeight, this.Config.CloseToGroundHeight);
			float heightAboveGround = this.MoveComp.GetHeightAboveGround(heightDetect);
			this.HitFloorNonFloor = (heightAboveGround < this.Config.AirCriticalHeight);
			this.HitFloorDist = heightAboveGround;
			return this.HitFloorNonFloor;
		}

		// Token: 0x0603DC93 RID: 253075 RVA: 0x011EA49F File Offset: 0x011E869F
		public float GetFloorDistance()
		{
			FFindFloorResult currentFloor = this.CurrentFloor;
			if (currentFloor != null && currentFloor.bWalkableFloor)
			{
				return this.CurrentFloor.FloorDist;
			}
			if (!this.HitFloorNonFloor)
			{
				return 1E+09f;
			}
			return this.HitFloorDist;
		}

		// Token: 0x0603DC94 RID: 253076 RVA: 0x011EA4D8 File Offset: 0x011E86D8
		[NullableContext(2)]
		public UKuroHitResult DetectCeiling()
		{
			UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
			actorTrace.WorldContextObject = this.ActorComp.Actor;
			actorTrace.Radius = 1f;
			this.TempVector.DeepCopy(this.ActorComp.ActorLocationProxy);
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempVector, (double)this.ActorComp.ScaledHalfHeight);
			TraceElementCommon.Instance.SetStartLocation(actorTrace, this.TempVector);
			this.TempVector2.DeepCopy(this.TempVector);
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TempVector2, 1.0);
			TraceElementCommon.Instance.SetEndLocation(actorTrace, this.TempVector2);
			actorTrace.ActorsToIgnore.Empty(true);
			foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
			{
				actorTrace.ActorsToIgnore.Add(value);
			}
			if (!TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "Floating", "Floating"))
			{
				return null;
			}
			return actorTrace.HitResult;
		}

		// Token: 0x0603DC95 RID: 253077 RVA: 0x011EA620 File Offset: 0x011E8820
		private void RefreshMovementBase()
		{
			FFindFloorResult currentFloor = this.CurrentFloor;
			UPrimitiveComponent uprimitiveComponent = (currentFloor != null) ? currentFloor.HitResult.Component.Get() : null;
			if (this.CurrentBase == uprimitiveComponent)
			{
				return;
			}
			this.CurrentBase = uprimitiveComponent;
			UKuroStaticLibrary.SetBaseAndSaveBaseLocation(this.ActorComp.Actor.CharacterMovement, this.CurrentBase);
		}

		// Token: 0x0603DC96 RID: 253078 RVA: 0x011EA67C File Offset: 0x011E887C
		private void RefreshMoveState()
		{
			if (!this.MoveComp.CanResponseInput())
			{
				return;
			}
			if (this.QueryInputAction(AkiClient.Game.Aki.Character.Input.Enum.EInputAction.跳跃))
			{
				this.EnterRiseState();
				this.HasFloatingMoveInput = true;
				return;
			}
			if (this.FloatingMoveType == EFloatingMovementType.None && this.MoveComp.HasMoveInput)
			{
				this.EnterFloatingState(false);
			}
		}

		// Token: 0x0603DC97 RID: 253079 RVA: 0x011EA6CA File Offset: 0x011E88CA
		private void TriggerFloatingMoveEvent()
		{
			if (this.HadFloatingMoveInput == this.HasFloatingMoveInput)
			{
				return;
			}
			EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnFloatingMoveInputChanged, this.HadFloatingMoveInput, this.HasFloatingMoveInput);
			this.HadFloatingMoveInput = this.HasFloatingMoveInput;
		}

		// Token: 0x0603DC98 RID: 253080 RVA: 0x011EA70C File Offset: 0x011E890C
		public void ExitHitState()
		{
			if (this.QueryInputAction(AkiClient.Game.Aki.Character.Input.Enum.EInputAction.跳跃))
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.EnterRiseState();
				return;
			}
			if (Info.Instance.IsInTouch() && this.QueryInputAction(AkiClient.Game.Aki.Character.Input.Enum.EInputAction.下降))
			{
				bool debug2 = CharacterFloatingComponent.Debug;
				this.EnterDropState();
				return;
			}
			if (Array.IndexOf<ECharMoveState>(CharacterFloatingComponent.BeHitMoveStateList, this.StateComp.MoveState) >= 0)
			{
				bool debug3 = CharacterFloatingComponent.Debug;
				this.EnterFloatingState(false);
			}
		}

		// Token: 0x0603DC99 RID: 253081 RVA: 0x011EA777 File Offset: 0x011E8977
		public void ExternalEnterFloatingState()
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterFloatingState(true);
		}

		// Token: 0x0603DC9A RID: 253082 RVA: 0x011EA786 File Offset: 0x011E8986
		public void ClearCacheInputDirect()
		{
			this.TempInputDirection.Reset();
		}

		// Token: 0x0603DC9B RID: 253083 RVA: 0x011EA794 File Offset: 0x011E8994
		private void AddFloatingStateListener()
		{
			BaseTagComponent tagComp = this.TagComp;
			this.FloatingEnableListener = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮"]), delegate(int _, bool tagExists)
			{
				if (tagExists)
				{
					this.EnableFloating("/Game/Aki/Character/Role/FemaleZ2/AimisiGD/Data/DA_FloatingMovementConfig.DA_FloatingMovementConfig");
					return;
				}
				this.DisableFloating();
			}, null) : null);
			BaseTagComponent tagComp2 = this.TagComp;
			this.FloatingMoveModeListener = ((tagComp2 != null) ? tagComp2.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.锁敌移动"]), delegate(int _, bool tagExists)
			{
				this.InLockTargetState = tagExists;
			}, null) : null);
			BaseTagComponent tagComp3 = this.TagComp;
			this.FloatingSprintListener = ((tagComp3 != null) ? tagComp3.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.悬浮.快速移动"]), delegate(int _, bool tagExists)
			{
				this.IsSprintMove = tagExists;
			}, null) : null);
		}

		// Token: 0x0603DC9C RID: 253084 RVA: 0x011EA84C File Offset: 0x011E8A4C
		private void InitConfig(string daPath, Action callback)
		{
			if (this.Config == null)
			{
				this.Config = new FloatingMovementConfig();
			}
			BP_FloatingMovementConfig_C bp_FloatingMovementConfig_C = ResourceSystem.Instance.Load<BP_FloatingMovementConfig_C>(daPath, "js_undefined");
			if (bp_FloatingMovementConfig_C != null && bp_FloatingMovementConfig_C.IsValid())
			{
				this.Config.Init(bp_FloatingMovementConfig_C);
			}
			callback();
		}

		// Token: 0x0603DC9D RID: 253085 RVA: 0x011EA89C File Offset: 0x011E8A9C
		private void InitFloatingStateMachine()
		{
			this.StateMachine = new StateMachine<CharacterFloatingComponent, EFloatingMovementType>(this, null);
			this.StateMachine.AddState<DefaultState>(EFloatingMovementType.None, null);
			this.StateMachine.AddState<FloatingState>(EFloatingMovementType.Floating, null);
			this.StateMachine.AddState<RiseState>(EFloatingMovementType.Rise, null);
			this.StateMachine.AddState<DropState>(EFloatingMovementType.Drop, null);
			this.StateMachine.AddState<WalkState>(EFloatingMovementType.Walk, null);
			this.StateMachine.Start(EFloatingMovementType.None);
		}

		// Token: 0x0603DC9E RID: 253086 RVA: 0x011EA904 File Offset: 0x011E8B04
		public string GetStateName(EFloatingMovementType state)
		{
			switch (state)
			{
			case EFloatingMovementType.None:
				return "None";
			case EFloatingMovementType.Floating:
				return "Floating";
			case EFloatingMovementType.Rise:
				return "Rise";
			case EFloatingMovementType.Drop:
				return "Drop";
			case EFloatingMovementType.Walk:
				return "Walk";
			default:
				return "请补充悬浮状态名称";
			}
		}

		// Token: 0x0603DC9F RID: 253087 RVA: 0x011EA950 File Offset: 0x011E8B50
		public static void CreateStaticDefaultValue()
		{
			CharacterFloatingComponent.Debug = false;
		}

		// Token: 0x0603DCA0 RID: 253088 RVA: 0x011EA958 File Offset: 0x011E8B58
		public static void ResetStaticDefaultValue()
		{
			CharacterFloatingComponent.Debug = false;
		}

		// Token: 0x0603DCA1 RID: 253089 RVA: 0x011EA960 File Offset: 0x011E8B60
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterFloatingComponent characterFloatingComponent = (CharacterFloatingComponent)componentTemplate;
			this.InFloatingState = characterFloatingComponent.InFloatingState;
			this.InLockTargetState = characterFloatingComponent.InLockTargetState;
			this.SpeedInternal = characterFloatingComponent.SpeedInternal;
			this.IsSprintMove = characterFloatingComponent.IsSprintMove;
			this.FloatingMoveMixInternal = characterFloatingComponent.FloatingMoveMixInternal;
			this.FloatingMoveType = characterFloatingComponent.FloatingMoveType;
			this.HadFloatingMoveInput = characterFloatingComponent.HadFloatingMoveInput;
			this.HasFloatingMoveInput = characterFloatingComponent.HasFloatingMoveInput;
			this.IsOnWater = characterFloatingComponent.IsOnWater;
			this.WaterDist = characterFloatingComponent.WaterDist;
			if (characterFloatingComponent.CurrentFloor == null)
			{
				this.CurrentFloor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentFloor), "CurrentFloor"))
			{
				return false;
			}
			if (characterFloatingComponent.CurrentBase == null)
			{
				this.CurrentBase = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentBase), "CurrentBase"))
			{
				return false;
			}
			this.HitFloorNonFloor = characterFloatingComponent.HitFloorNonFloor;
			this.HitFloorDist = characterFloatingComponent.HitFloorDist;
			this.IsNearGround = characterFloatingComponent.IsNearGround;
			this.NearGroundDist = characterFloatingComponent.NearGroundDist;
			this.IsOnGround = characterFloatingComponent.IsOnGround;
			this.HasGroundTag = characterFloatingComponent.HasGroundTag;
			this.HasAirTag = characterFloatingComponent.HasAirTag;
			this.WasNearGround = characterFloatingComponent.WasNearGround;
			this.WasNearGroundDist = characterFloatingComponent.WasNearGroundDist;
			this.WasOnGround = characterFloatingComponent.WasOnGround;
			if (characterFloatingComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (characterFloatingComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (characterFloatingComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (characterFloatingComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterFloatingComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
			{
				return false;
			}
			if (characterFloatingComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (characterFloatingComponent.TimeScaleComp == null)
			{
				this.TimeScaleComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleComp), "TimeScaleComp"))
			{
				return false;
			}
			if (characterFloatingComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (characterFloatingComponent.InputComp == null)
			{
				this.InputComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComp), "InputComp"))
			{
				return false;
			}
			if (characterFloatingComponent.StateMachine == null)
			{
				this.StateMachine = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateMachine), "StateMachine"))
			{
				return false;
			}
			this.ComponentDisableHandle = characterFloatingComponent.ComponentDisableHandle;
			if (characterFloatingComponent.MoveDelta != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveDelta), "MoveDelta"))
			{
				return false;
			}
			if (characterFloatingComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
			{
				return false;
			}
			if (characterFloatingComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2"))
			{
				return false;
			}
			if (characterFloatingComponent.TempVector3 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector3), "TempVector3"))
			{
				return false;
			}
			if (characterFloatingComponent.TempInputDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempInputDirection), "TempInputDirection"))
			{
				return false;
			}
			if (characterFloatingComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRotator), "TempRotator"))
			{
				return false;
			}
			if (characterFloatingComponent.FloatingEnableListener == null)
			{
				this.FloatingEnableListener = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FloatingEnableListener), "FloatingEnableListener"))
			{
				return false;
			}
			if (characterFloatingComponent.FloatingMoveModeListener == null)
			{
				this.FloatingMoveModeListener = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FloatingMoveModeListener), "FloatingMoveModeListener"))
			{
				return false;
			}
			if (characterFloatingComponent.FloatingSprintListener == null)
			{
				this.FloatingSprintListener = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FloatingSprintListener), "FloatingSprintListener"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007537 RID: 30007
		// (get) Token: 0x0603DCA2 RID: 253090 RVA: 0x011EADD3 File Offset: 0x011E8FD3
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007538 RID: 30008
		// (get) Token: 0x0603DCA3 RID: 253091 RVA: 0x011EADD6 File Offset: 0x011E8FD6
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007539 RID: 30009
		// (get) Token: 0x0603DCA4 RID: 253092 RVA: 0x011EADD9 File Offset: 0x011E8FD9
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700753A RID: 30010
		// (get) Token: 0x0603DCA5 RID: 253093 RVA: 0x011EADDC File Offset: 0x011E8FDC
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700753B RID: 30011
		// (get) Token: 0x0603DCA6 RID: 253094 RVA: 0x011EADDF File Offset: 0x011E8FDF
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700753C RID: 30012
		// (get) Token: 0x0603DCA7 RID: 253095 RVA: 0x011EADE2 File Offset: 0x011E8FE2
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020C55 RID: 134229
		private const string PROFILE_KEY = "Floating";

		// Token: 0x04020C56 RID: 134230
		private const int TRACE_ERROR_VALUE = 1;

		// Token: 0x04020C57 RID: 134231
		private const int COMPONENT_DISABLE_KEY = -1;

		// Token: 0x04020C58 RID: 134232
		private const int FAST_MOVE_MIX = 1;

		// Token: 0x04020C59 RID: 134233
		private const float NORMAL_MOVE_MIX = 0.5f;

		// Token: 0x04020C5A RID: 134234
		private const int MAX_FLOOR_DIST = 999999999;

		// Token: 0x04020C5B RID: 134235
		private const int WATER_TRACE_DEPTH = 550;

		// Token: 0x04020C5C RID: 134236
		private const int TRACE_ERROR_THRESHOLD = 3;

		// Token: 0x04020C5D RID: 134237
		private const string DEFAULT_DA_PATH = "/Game/Aki/Character/Role/FemaleZ2/AimisiGD/Data/DA_FloatingMovementConfig.DA_FloatingMovementConfig";

		// Token: 0x04020C5E RID: 134238
		[StaticVariableRuleIgnore]
		public static readonly List<int> EmptyArray = new List<int>();

		// Token: 0x04020C5F RID: 134239
		[StaticVariableRuleIgnore]
		public static readonly ECharMoveState[] BeHitMoveStateList = new ECharMoveState[]
		{
			ECharMoveState.KnockDown,
			ECharMoveState.Parry,
			ECharMoveState.SoftKnock,
			ECharMoveState.HeavyKnock,
			ECharMoveState.KnockUp,
			ECharMoveState.Captured
		};

		// Token: 0x04020C60 RID: 134240
		public bool InFloatingState;

		// Token: 0x04020C61 RID: 134241
		public bool InLockTargetState;

		// Token: 0x04020C62 RID: 134242
		public float SpeedInternal;

		// Token: 0x04020C63 RID: 134243
		public bool IsSprintMove;

		// Token: 0x04020C64 RID: 134244
		public float FloatingMoveMixInternal = 1f;

		// Token: 0x04020C65 RID: 134245
		public readonly float FloatingSpeedMixInternal = 1f;

		// Token: 0x04020C66 RID: 134246
		public EFloatingMovementType FloatingMoveType;

		// Token: 0x04020C67 RID: 134247
		public bool HadFloatingMoveInput;

		// Token: 0x04020C68 RID: 134248
		public bool HasFloatingMoveInput;

		// Token: 0x04020C69 RID: 134249
		public bool IsOnWater;

		// Token: 0x04020C6A RID: 134250
		public float WaterDist;

		// Token: 0x04020C6B RID: 134251
		[Nullable(2)]
		public FFindFloorResult CurrentFloor;

		// Token: 0x04020C6C RID: 134252
		[Nullable(2)]
		public UPrimitiveComponent CurrentBase;

		// Token: 0x04020C6D RID: 134253
		public bool HitFloorNonFloor;

		// Token: 0x04020C6E RID: 134254
		public float HitFloorDist;

		// Token: 0x04020C6F RID: 134255
		public bool IsNearGround;

		// Token: 0x04020C70 RID: 134256
		public float NearGroundDist;

		// Token: 0x04020C71 RID: 134257
		public bool IsOnGround;

		// Token: 0x04020C72 RID: 134258
		public bool HasGroundTag;

		// Token: 0x04020C73 RID: 134259
		public bool HasAirTag;

		// Token: 0x04020C74 RID: 134260
		public bool WasNearGround;

		// Token: 0x04020C75 RID: 134261
		public float WasNearGroundDist;

		// Token: 0x04020C76 RID: 134262
		public bool WasOnGround;

		// Token: 0x04020C77 RID: 134263
		[Nullable(2)]
		public FloatingMovementConfig Config;

		// Token: 0x04020C78 RID: 134264
		[Nullable(2)]
		public BaseTagComponent TagComp;

		// Token: 0x04020C79 RID: 134265
		[Nullable(2)]
		public CharacterMoveComponent MoveComp;

		// Token: 0x04020C7A RID: 134266
		[Nullable(2)]
		public CharacterActorComponent ActorComp;

		// Token: 0x04020C7B RID: 134267
		[Nullable(2)]
		public CharacterAnimationComponent AnimComp;

		// Token: 0x04020C7C RID: 134268
		[Nullable(2)]
		public CharacterUnifiedStateComponent StateComp;

		// Token: 0x04020C7D RID: 134269
		[Nullable(2)]
		public CharacterTimeScaleComponent TimeScaleComp;

		// Token: 0x04020C7E RID: 134270
		[Nullable(2)]
		public CreatureDataComponent CreatureDataComp;

		// Token: 0x04020C7F RID: 134271
		[Nullable(2)]
		public CharacterInputComponent InputComp;

		// Token: 0x04020C80 RID: 134272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private StateMachine<CharacterFloatingComponent, EFloatingMovementType> StateMachine;

		// Token: 0x04020C81 RID: 134273
		private int ComponentDisableHandle = -1;

		// Token: 0x04020C82 RID: 134274
		public readonly Vector MoveDelta = Vector.Create();

		// Token: 0x04020C83 RID: 134275
		public readonly Vector TempVector = Vector.Create();

		// Token: 0x04020C84 RID: 134276
		public readonly Vector TempVector2 = Vector.Create();

		// Token: 0x04020C85 RID: 134277
		public readonly Vector TempVector3 = Vector.Create();

		// Token: 0x04020C86 RID: 134278
		public readonly Vector TempInputDirection = Vector.Create();

		// Token: 0x04020C87 RID: 134279
		public readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x04020C88 RID: 134280
		public static bool Debug;

		// Token: 0x04020C89 RID: 134281
		[Nullable(2)]
		private ITagTask FloatingEnableListener;

		// Token: 0x04020C8A RID: 134282
		[Nullable(2)]
		private ITagTask FloatingMoveModeListener;

		// Token: 0x04020C8B RID: 134283
		[Nullable(2)]
		private ITagTask FloatingSprintListener;
	}
}
