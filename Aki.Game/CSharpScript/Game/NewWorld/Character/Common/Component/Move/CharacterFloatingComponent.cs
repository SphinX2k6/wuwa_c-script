using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020070E4 RID: 28900
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterFloatingComponent : EntityComponent, IComponentDependency, IStaticVariableResetter
	{
		// Token: 0x06046877 RID: 288887 RVA: 0x011B966E File Offset: 0x011B786E
		static CharacterFloatingComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterFloatingComponent.CreateStaticDefaultValue), new Action(CharacterFloatingComponent.ResetStaticDefaultValue));
		}

		// Token: 0x17009CB3 RID: 40115
		// (get) Token: 0x06046878 RID: 288888 RVA: 0x011B96AD File Offset: 0x011B78AD
		public static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x17009CB4 RID: 40116
		// (get) Token: 0x06046879 RID: 288889 RVA: 0x011B96C2 File Offset: 0x011B78C2
		public bool IsFloating
		{
			get
			{
				return this.InFloatingState;
			}
		}

		// Token: 0x17009CB5 RID: 40117
		// (get) Token: 0x0604687A RID: 288890 RVA: 0x011B96CA File Offset: 0x011B78CA
		public bool IsFloatingMove
		{
			get
			{
				return this.Speed > 1f;
			}
		}

		// Token: 0x17009CB6 RID: 40118
		// (get) Token: 0x0604687B RID: 288891 RVA: 0x011B96DC File Offset: 0x011B78DC
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

		// Token: 0x17009CB7 RID: 40119
		// (get) Token: 0x0604687C RID: 288892 RVA: 0x011B971F File Offset: 0x011B791F
		public float FloatingMoveMix
		{
			get
			{
				return this.FloatingMoveMixInternal;
			}
		}

		// Token: 0x17009CB8 RID: 40120
		// (get) Token: 0x0604687D RID: 288893 RVA: 0x011B9727 File Offset: 0x011B7927
		public float FloatingSpeedMix
		{
			get
			{
				return this.FloatingSpeedMixInternal;
			}
		}

		// Token: 0x17009CB9 RID: 40121
		// (get) Token: 0x0604687E RID: 288894 RVA: 0x011B972F File Offset: 0x011B792F
		public float Speed
		{
			get
			{
				return this.SpeedInternal;
			}
		}

		// Token: 0x0604687F RID: 288895 RVA: 0x011B9737 File Offset: 0x011B7937
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06046880 RID: 288896 RVA: 0x011B973C File Offset: 0x011B793C
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

		// Token: 0x06046881 RID: 288897 RVA: 0x011B98E0 File Offset: 0x011B7AE0
		protected override void OnEnable()
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterFloatingState(true);
			this.ClearCacheInputDirect();
			EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnBeginSkill));
			EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
		}

		// Token: 0x06046882 RID: 288898 RVA: 0x011B9940 File Offset: 0x011B7B40
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

		// Token: 0x06046883 RID: 288899 RVA: 0x011B99D4 File Offset: 0x011B7BD4
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

		// Token: 0x06046884 RID: 288900 RVA: 0x011B9AF8 File Offset: 0x011B7CF8
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

		// Token: 0x06046885 RID: 288901 RVA: 0x011B9B78 File Offset: 0x011B7D78
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

		// Token: 0x06046886 RID: 288902 RVA: 0x011B9BB7 File Offset: 0x011B7DB7
		public void JumpPressInAir()
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterRiseState();
		}

		// Token: 0x06046887 RID: 288903 RVA: 0x011B9BC5 File Offset: 0x011B7DC5
		public void JumpRelease()
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterFloatingState(false);
		}

		// Token: 0x06046888 RID: 288904 RVA: 0x011B9BD4 File Offset: 0x011B7DD4
		public void CtrlPress()
		{
			if (Info.Instance.IsInTouch())
			{
				bool debug = CharacterFloatingComponent.Debug;
				this.EnterDropState();
			}
		}

		// Token: 0x06046889 RID: 288905 RVA: 0x011B9BEE File Offset: 0x011B7DEE
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

		// Token: 0x0604688A RID: 288906 RVA: 0x011B9C13 File Offset: 0x011B7E13
		private void EnterDefaultState()
		{
			if (this.FloatingMoveType == EFloatingMovementType.None)
			{
				return;
			}
			this.UpdateState(EFloatingMovementType.None);
		}

		// Token: 0x0604688B RID: 288907 RVA: 0x011B9C26 File Offset: 0x011B7E26
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

		// Token: 0x0604688C RID: 288908 RVA: 0x011B9C4F File Offset: 0x011B7E4F
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

		// Token: 0x0604688D RID: 288909 RVA: 0x011B9C7A File Offset: 0x011B7E7A
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

		// Token: 0x0604688E RID: 288910 RVA: 0x011B9CA2 File Offset: 0x011B7EA2
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

		// Token: 0x0604688F RID: 288911 RVA: 0x011B9CC4 File Offset: 0x011B7EC4
		private bool UpdateState(EFloatingMovementType state)
		{
			return this.StateMachine.Switch(state);
		}

		// Token: 0x06046890 RID: 288912 RVA: 0x011B9CD4 File Offset: 0x011B7ED4
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

		// Token: 0x06046891 RID: 288913 RVA: 0x011B9D64 File Offset: 0x011B7F64
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

		// Token: 0x06046892 RID: 288914 RVA: 0x011B9E56 File Offset: 0x011B8056
		private bool QueryInputAction(AkiClient.Game.Aki.Character.Input.Enum.EInputAction inputAction)
		{
			return this.InputComp != null && InputController.Instance.IsKeyDown(inputAction);
		}

		// Token: 0x06046893 RID: 288915 RVA: 0x011B9E72 File Offset: 0x011B8072
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

		// Token: 0x06046894 RID: 288916 RVA: 0x011B9EA6 File Offset: 0x011B80A6
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

		// Token: 0x06046895 RID: 288917 RVA: 0x011B9ED4 File Offset: 0x011B80D4
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

		// Token: 0x06046896 RID: 288918 RVA: 0x011B9F8B File Offset: 0x011B818B
		private void OnRoleInheritTransform()
		{
			if (!this.InFloatingState)
			{
				return;
			}
			this.DetectFloor();
			this.CheckGround();
		}

		// Token: 0x06046897 RID: 288919 RVA: 0x011B9FA3 File Offset: 0x011B81A3
		private void OnBeginSkill(int skillId, bool isAutonomousProxy)
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterDefaultState();
			this.ClearCacheInputDirect();
		}

		// Token: 0x06046898 RID: 288920 RVA: 0x011B9FB7 File Offset: 0x011B81B7
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

		// Token: 0x06046899 RID: 288921 RVA: 0x011B9FEC File Offset: 0x011B81EC
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

		// Token: 0x0604689A RID: 288922 RVA: 0x011BA060 File Offset: 0x011B8260
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

		// Token: 0x0604689B RID: 288923 RVA: 0x011BA110 File Offset: 0x011B8310
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

		// Token: 0x0604689C RID: 288924 RVA: 0x011BA25E File Offset: 0x011B845E
		public void UpdateMove(float deltaSeconds, Vector output)
		{
			output.DeepCopy(this.ActorComp.InputDirectProxy);
			this.TempInputDirection.DeepCopy(output);
			output.MultiplyEqual((double)(this.SpeedInternal * deltaSeconds));
		}

		// Token: 0x0604689D RID: 288925 RVA: 0x011BA290 File Offset: 0x011B8490
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

		// Token: 0x0604689E RID: 288926 RVA: 0x011BA448 File Offset: 0x011B8648
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

		// Token: 0x0604689F RID: 288927 RVA: 0x011BA540 File Offset: 0x011B8740
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

		// Token: 0x060468A0 RID: 288928 RVA: 0x011BA904 File Offset: 0x011B8B04
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

		// Token: 0x060468A1 RID: 288929 RVA: 0x011BAA1C File Offset: 0x011B8C1C
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

		// Token: 0x060468A2 RID: 288930 RVA: 0x011BAAC8 File Offset: 0x011B8CC8
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

		// Token: 0x060468A3 RID: 288931 RVA: 0x011BAC94 File Offset: 0x011B8E94
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

		// Token: 0x060468A4 RID: 288932 RVA: 0x011BAD3C File Offset: 0x011B8F3C
		private void DetectWaterDist()
		{
			float heightDetect = Math.Max(550f, this.Config.CloseToGroundHeight);
			float heightAboveWater = this.MoveComp.GetHeightAboveWater(heightDetect);
			this.WaterDist = heightAboveWater;
		}

		// Token: 0x060468A5 RID: 288933 RVA: 0x011BAD74 File Offset: 0x011B8F74
		private bool DetectHeightNonFloor()
		{
			float heightDetect = Math.Max(this.Config.AirCriticalHeight, this.Config.CloseToGroundHeight);
			float heightAboveGround = this.MoveComp.GetHeightAboveGround(heightDetect);
			this.HitFloorNonFloor = (heightAboveGround < this.Config.AirCriticalHeight);
			this.HitFloorDist = heightAboveGround;
			return this.HitFloorNonFloor;
		}

		// Token: 0x060468A6 RID: 288934 RVA: 0x011BADCB File Offset: 0x011B8FCB
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

		// Token: 0x060468A7 RID: 288935 RVA: 0x011BAE04 File Offset: 0x011B9004
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

		// Token: 0x060468A8 RID: 288936 RVA: 0x011BAF4C File Offset: 0x011B914C
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

		// Token: 0x060468A9 RID: 288937 RVA: 0x011BAFA8 File Offset: 0x011B91A8
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

		// Token: 0x060468AA RID: 288938 RVA: 0x011BAFF6 File Offset: 0x011B91F6
		private void TriggerFloatingMoveEvent()
		{
			if (this.HadFloatingMoveInput == this.HasFloatingMoveInput)
			{
				return;
			}
			EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnFloatingMoveInputChanged, this.HadFloatingMoveInput, this.HasFloatingMoveInput);
			this.HadFloatingMoveInput = this.HasFloatingMoveInput;
		}

		// Token: 0x060468AB RID: 288939 RVA: 0x011BB038 File Offset: 0x011B9238
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
			if (CharacterFloatingComponent.BeHitMoveStateList.Contains(this.StateComp.MoveState))
			{
				bool debug3 = CharacterFloatingComponent.Debug;
				this.EnterFloatingState(false);
			}
		}

		// Token: 0x060468AC RID: 288940 RVA: 0x011BB0A2 File Offset: 0x011B92A2
		public void ExternalEnterFloatingState()
		{
			bool debug = CharacterFloatingComponent.Debug;
			this.EnterFloatingState(true);
		}

		// Token: 0x060468AD RID: 288941 RVA: 0x011BB0B1 File Offset: 0x011B92B1
		public void ClearCacheInputDirect()
		{
			this.TempInputDirection.Reset();
		}

		// Token: 0x060468AE RID: 288942 RVA: 0x011BB0C0 File Offset: 0x011B92C0
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

		// Token: 0x060468AF RID: 288943 RVA: 0x011BB178 File Offset: 0x011B9378
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

		// Token: 0x060468B0 RID: 288944 RVA: 0x011BB1C8 File Offset: 0x011B93C8
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

		// Token: 0x060468B1 RID: 288945 RVA: 0x011BB230 File Offset: 0x011B9430
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

		// Token: 0x060468B2 RID: 288946 RVA: 0x011BB27C File Offset: 0x011B947C
		public static void CreateStaticDefaultValue()
		{
			CharacterFloatingComponent.Debug = false;
		}

		// Token: 0x060468B3 RID: 288947 RVA: 0x011BB284 File Offset: 0x011B9484
		public static void ResetStaticDefaultValue()
		{
			CharacterFloatingComponent.Debug = false;
		}

		// Token: 0x060468B4 RID: 288948 RVA: 0x011BB28C File Offset: 0x011B948C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterFloatingComponent characterFloatingComponent = (CharacterFloatingComponent)componentTemplate;
			if (base.CanResetComponentProperty("InFloatingState"))
			{
				this.InFloatingState = characterFloatingComponent.InFloatingState;
			}
			if (base.CanResetComponentProperty("InLockTargetState"))
			{
				this.InLockTargetState = characterFloatingComponent.InLockTargetState;
			}
			if (base.CanResetComponentProperty("SpeedInternal"))
			{
				this.SpeedInternal = characterFloatingComponent.SpeedInternal;
			}
			if (base.CanResetComponentProperty("IsSprintMove"))
			{
				this.IsSprintMove = characterFloatingComponent.IsSprintMove;
			}
			if (base.CanResetComponentProperty("FloatingMoveMixInternal"))
			{
				this.FloatingMoveMixInternal = characterFloatingComponent.FloatingMoveMixInternal;
			}
			if (base.CanResetComponentProperty("FloatingMoveType"))
			{
				this.FloatingMoveType = characterFloatingComponent.FloatingMoveType;
			}
			if (base.CanResetComponentProperty("HadFloatingMoveInput"))
			{
				this.HadFloatingMoveInput = characterFloatingComponent.HadFloatingMoveInput;
			}
			if (base.CanResetComponentProperty("HasFloatingMoveInput"))
			{
				this.HasFloatingMoveInput = characterFloatingComponent.HasFloatingMoveInput;
			}
			if (base.CanResetComponentProperty("IsOnWater"))
			{
				this.IsOnWater = characterFloatingComponent.IsOnWater;
			}
			if (base.CanResetComponentProperty("WaterDist"))
			{
				this.WaterDist = characterFloatingComponent.WaterDist;
			}
			if (base.CanResetComponentProperty("CurrentFloor"))
			{
				if (characterFloatingComponent.CurrentFloor == null)
				{
					this.CurrentFloor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FFindFloorResult>(this.CurrentFloor), "CurrentFloor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentBase"))
			{
				if (characterFloatingComponent.CurrentBase == null)
				{
					this.CurrentBase = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.CurrentBase), "CurrentBase"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("HitFloorNonFloor"))
			{
				this.HitFloorNonFloor = characterFloatingComponent.HitFloorNonFloor;
			}
			if (base.CanResetComponentProperty("HitFloorDist"))
			{
				this.HitFloorDist = characterFloatingComponent.HitFloorDist;
			}
			if (base.CanResetComponentProperty("IsNearGround"))
			{
				this.IsNearGround = characterFloatingComponent.IsNearGround;
			}
			if (base.CanResetComponentProperty("NearGroundDist"))
			{
				this.NearGroundDist = characterFloatingComponent.NearGroundDist;
			}
			if (base.CanResetComponentProperty("IsOnGround"))
			{
				this.IsOnGround = characterFloatingComponent.IsOnGround;
			}
			if (base.CanResetComponentProperty("HasGroundTag"))
			{
				this.HasGroundTag = characterFloatingComponent.HasGroundTag;
			}
			if (base.CanResetComponentProperty("HasAirTag"))
			{
				this.HasAirTag = characterFloatingComponent.HasAirTag;
			}
			if (base.CanResetComponentProperty("WasNearGround"))
			{
				this.WasNearGround = characterFloatingComponent.WasNearGround;
			}
			if (base.CanResetComponentProperty("WasNearGroundDist"))
			{
				this.WasNearGroundDist = characterFloatingComponent.WasNearGroundDist;
			}
			if (base.CanResetComponentProperty("WasOnGround"))
			{
				this.WasOnGround = characterFloatingComponent.WasOnGround;
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (characterFloatingComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FloatingMovementConfig>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (characterFloatingComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (characterFloatingComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterFloatingComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AnimComp"))
			{
				if (characterFloatingComponent.AnimComp == null)
				{
					this.AnimComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("StateComp"))
			{
				if (characterFloatingComponent.StateComp == null)
				{
					this.StateComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TimeScaleComp"))
			{
				if (characterFloatingComponent.TimeScaleComp == null)
				{
					this.TimeScaleComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterTimeScaleComponent>(this.TimeScaleComp), "TimeScaleComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (characterFloatingComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InputComp"))
			{
				if (characterFloatingComponent.InputComp == null)
				{
					this.InputComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterInputComponent>(this.InputComp), "InputComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("StateMachine"))
			{
				if (characterFloatingComponent.StateMachine == null)
				{
					this.StateMachine = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<StateMachine<CharacterFloatingComponent, EFloatingMovementType>>(this.StateMachine), "StateMachine"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ComponentDisableHandle"))
			{
				this.ComponentDisableHandle = characterFloatingComponent.ComponentDisableHandle;
			}
			if (base.CanResetComponentProperty("MoveDelta") && characterFloatingComponent.MoveDelta != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.MoveDelta), "MoveDelta"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempVector") && characterFloatingComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector), "TempVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempVector2") && characterFloatingComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector2), "TempVector2"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempVector3") && characterFloatingComponent.TempVector3 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector3), "TempVector3"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempInputDirection") && characterFloatingComponent.TempInputDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempInputDirection), "TempInputDirection"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TempRotator") && characterFloatingComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TempRotator), "TempRotator"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("FloatingEnableListener"))
			{
				if (characterFloatingComponent.FloatingEnableListener == null)
				{
					this.FloatingEnableListener = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.FloatingEnableListener), "FloatingEnableListener"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FloatingMoveModeListener"))
			{
				if (characterFloatingComponent.FloatingMoveModeListener == null)
				{
					this.FloatingMoveModeListener = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.FloatingMoveModeListener), "FloatingMoveModeListener"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FloatingSprintListener"))
			{
				if (characterFloatingComponent.FloatingSprintListener == null)
				{
					this.FloatingSprintListener = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.FloatingSprintListener), "FloatingSprintListener"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024FC0 RID: 151488
		private const string PROFILE_KEY = "Floating";

		// Token: 0x04024FC1 RID: 151489
		private const int TRACE_ERROR_VALUE = 1;

		// Token: 0x04024FC2 RID: 151490
		private const int COMPONENT_DISABLE_KEY = -1;

		// Token: 0x04024FC3 RID: 151491
		private const int FAST_MOVE_MIX = 1;

		// Token: 0x04024FC4 RID: 151492
		private const float NORMAL_MOVE_MIX = 0.5f;

		// Token: 0x04024FC5 RID: 151493
		private const int MAX_FLOOR_DIST = 999999999;

		// Token: 0x04024FC6 RID: 151494
		private const int WATER_TRACE_DEPTH = 550;

		// Token: 0x04024FC7 RID: 151495
		private const int TRACE_ERROR_THRESHOLD = 3;

		// Token: 0x04024FC8 RID: 151496
		private const string DEFAULT_DA_PATH = "/Game/Aki/Character/Role/FemaleZ2/AimisiGD/Data/DA_FloatingMovementConfig.DA_FloatingMovementConfig";

		// Token: 0x04024FC9 RID: 151497
		[StaticVariableRuleIgnore]
		public static readonly List<int> EmptyArray = new List<int>();

		// Token: 0x04024FCA RID: 151498
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

		// Token: 0x04024FCB RID: 151499
		public bool InFloatingState;

		// Token: 0x04024FCC RID: 151500
		public bool InLockTargetState;

		// Token: 0x04024FCD RID: 151501
		public float SpeedInternal;

		// Token: 0x04024FCE RID: 151502
		public bool IsSprintMove;

		// Token: 0x04024FCF RID: 151503
		public float FloatingMoveMixInternal = 1f;

		// Token: 0x04024FD0 RID: 151504
		public readonly float FloatingSpeedMixInternal = 1f;

		// Token: 0x04024FD1 RID: 151505
		public EFloatingMovementType FloatingMoveType;

		// Token: 0x04024FD2 RID: 151506
		public bool HadFloatingMoveInput;

		// Token: 0x04024FD3 RID: 151507
		public bool HasFloatingMoveInput;

		// Token: 0x04024FD4 RID: 151508
		public bool IsOnWater;

		// Token: 0x04024FD5 RID: 151509
		public float WaterDist;

		// Token: 0x04024FD6 RID: 151510
		[Nullable(2)]
		public FFindFloorResult CurrentFloor;

		// Token: 0x04024FD7 RID: 151511
		[Nullable(2)]
		public UPrimitiveComponent CurrentBase;

		// Token: 0x04024FD8 RID: 151512
		public bool HitFloorNonFloor;

		// Token: 0x04024FD9 RID: 151513
		public float HitFloorDist;

		// Token: 0x04024FDA RID: 151514
		public bool IsNearGround;

		// Token: 0x04024FDB RID: 151515
		public float NearGroundDist;

		// Token: 0x04024FDC RID: 151516
		public bool IsOnGround;

		// Token: 0x04024FDD RID: 151517
		public bool HasGroundTag;

		// Token: 0x04024FDE RID: 151518
		public bool HasAirTag;

		// Token: 0x04024FDF RID: 151519
		public bool WasNearGround;

		// Token: 0x04024FE0 RID: 151520
		public float WasNearGroundDist;

		// Token: 0x04024FE1 RID: 151521
		public bool WasOnGround;

		// Token: 0x04024FE2 RID: 151522
		[Nullable(2)]
		public FloatingMovementConfig Config;

		// Token: 0x04024FE3 RID: 151523
		[Nullable(2)]
		public BaseTagComponent TagComp;

		// Token: 0x04024FE4 RID: 151524
		[Nullable(2)]
		public CharacterMoveComponent MoveComp;

		// Token: 0x04024FE5 RID: 151525
		[Nullable(2)]
		public CharacterActorComponent ActorComp;

		// Token: 0x04024FE6 RID: 151526
		[Nullable(2)]
		public CharacterAnimationComponent AnimComp;

		// Token: 0x04024FE7 RID: 151527
		[Nullable(2)]
		public CharacterUnifiedStateComponent StateComp;

		// Token: 0x04024FE8 RID: 151528
		[Nullable(2)]
		public CharacterTimeScaleComponent TimeScaleComp;

		// Token: 0x04024FE9 RID: 151529
		[Nullable(2)]
		public CreatureDataComponent CreatureDataComp;

		// Token: 0x04024FEA RID: 151530
		[Nullable(2)]
		public CharacterInputComponent InputComp;

		// Token: 0x04024FEB RID: 151531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private StateMachine<CharacterFloatingComponent, EFloatingMovementType> StateMachine;

		// Token: 0x04024FEC RID: 151532
		private int ComponentDisableHandle = -1;

		// Token: 0x04024FED RID: 151533
		public readonly Vector MoveDelta = Vector.Create();

		// Token: 0x04024FEE RID: 151534
		public readonly Vector TempVector = Vector.Create();

		// Token: 0x04024FEF RID: 151535
		public readonly Vector TempVector2 = Vector.Create();

		// Token: 0x04024FF0 RID: 151536
		public readonly Vector TempVector3 = Vector.Create();

		// Token: 0x04024FF1 RID: 151537
		public readonly Vector TempInputDirection = Vector.Create();

		// Token: 0x04024FF2 RID: 151538
		public readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x04024FF3 RID: 151539
		public static bool Debug;

		// Token: 0x04024FF4 RID: 151540
		[Nullable(2)]
		private ITagTask FloatingEnableListener;

		// Token: 0x04024FF5 RID: 151541
		[Nullable(2)]
		private ITagTask FloatingMoveModeListener;

		// Token: 0x04024FF6 RID: 151542
		[Nullable(2)]
		private ITagTask FloatingSprintListener;
	}
}
