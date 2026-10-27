using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Role.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070DB RID: 28891
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterClimbComponent : EntityComponent
	{
		// Token: 0x17009CB1 RID: 40113
		// (get) Token: 0x060467E3 RID: 288739 RVA: 0x011B4073 File Offset: 0x011B2273
		[StaticVariableRuleIgnore]
		public new static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterActorComponent),
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x060467E4 RID: 288740 RVA: 0x011B4095 File Offset: 0x011B2295
		private void ReceiveClimbEvent(float deltaTime)
		{
			this.ClimbEvent(deltaTime);
		}

		// Token: 0x060467E5 RID: 288741 RVA: 0x011B40A0 File Offset: 0x011B22A0
		[NullableContext(2)]
		private void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
		{
			if (notInheritMoveAndAnim)
			{
				return;
			}
			if (other == null || !other.Valid)
			{
				return;
			}
			CharacterClimbComponent component = other.GetComponent<CharacterClimbComponent>();
			if (component == null || !component.Valid)
			{
				return;
			}
			if (component.ClimbInputDirect.ContainsNaN())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "OnStateInherit ClimbInput is Nan.";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ClimbInput", component.ClimbInputDirect);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				component.ClimbInputDirect.Reset();
			}
			this.ClimbInputDirect.DeepCopy(component.ClimbInputDirect);
			this.PrevClimbInputDirect.DeepCopy(component.PrevClimbInputDirect);
			this.PreCharacterStateInClimb = component.PreCharacterStateInClimb;
			this.AwakeInput = component.AwakeInput;
			this.ClimbUpNewTransform = component.ClimbUpNewTransform;
			this.ClimbUpNewLocation = component.ClimbUpNewLocation;
			this.LastExitClimbTime = component.LastExitClimbTime;
			this.LastSafeLocation.DeepCopy(component.LastSafeLocation);
			this.SetClimbState(component.ClimbState);
			this.SetEnterClimbType(component.EnterClimbType);
			this.SetExitClimbType(component.ExitClimbType);
			this.ExitClimbCountDown = component.ExitClimbCountDown;
			if (this.ClimbState != EClimbState.无)
			{
				UKuroClimbObject kuroClimbObject = this.KuroClimbObject;
				if (kuroClimbObject != null)
				{
					kuroClimbObject.SyncFromOther(component.KuroClimbObject);
				}
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp == null)
				{
					return;
				}
				actorComp.ResetCachedVelocityTime();
			}
		}

		// Token: 0x060467E6 RID: 288742 RVA: 0x011B41F0 File Offset: 0x011B23F0
		private void OnUseSkill(int entityId, int skillId, bool IsAutonomousProxy)
		{
			CharacterMoveComponent moveComp = this.MoveComp;
			if (((moveComp != null) ? moveComp.CharacterMovement : null) == null)
			{
				return;
			}
			if (this.MoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Custom || this.MoveComp.CharacterMovement.CustomMovementMode != 0)
			{
				return;
			}
			SSkillInfo skillInfo = base.Entity.GetComponent<CharacterSkillComponent>().GetSkillInfo(skillId);
			if (1 != skillInfo.GroupId)
			{
				return;
			}
			if (this.UnifiedStateComponent.MoveState == global::ECharMoveState.NormalClimb || this.UnifiedStateComponent.MoveState == global::ECharMoveState.FastClimb)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp == null)
				{
					return;
				}
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Walking,
					Context = "[CharacterClimbComponent.OnUseSkill]"
				});
			}
		}

		// Token: 0x17009CB2 RID: 40114
		// (get) Token: 0x060467E7 RID: 288743 RVA: 0x011B42A3 File Offset: 0x011B24A3
		// (set) Token: 0x060467E8 RID: 288744 RVA: 0x011B42AC File Offset: 0x011B24AC
		protected bool ClimbBlocking
		{
			get
			{
				return this.ClimbBlockingInternal;
			}
			set
			{
				if (this.ClimbBlockingInternal == value)
				{
					return;
				}
				this.ClimbBlockingInternal = value;
				if (this.ClimbBlockingInternal)
				{
					this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.攀爬受阻"]));
					return;
				}
				this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.攀爬受阻"]));
			}
		}

		// Token: 0x060467E9 RID: 288745 RVA: 0x011B4312 File Offset: 0x011B2512
		public void SetIsAllowEarlyExitClimb(bool adaptive)
		{
			this.IsAllowEarlyExitClimb = adaptive;
		}

		// Token: 0x060467EA RID: 288746 RVA: 0x011B431C File Offset: 0x011B251C
		private unsafe void OnPositionStateChanged(global::ECharPositionState oldPositionState, global::ECharPositionState newPositionState)
		{
			if (oldPositionState == newPositionState)
			{
				return;
			}
			if (oldPositionState == global::ECharPositionState.Climb && newPositionState == global::ECharPositionState.Air && this.ExitClimbType != EExitClimb.蹬墙退出 && this.ExitClimbType != EExitClimb.反斜登顶)
			{
				double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy);
				if (znInGravityForActor > 1.0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Movement;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "错误的退出攀爬";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("退出模式", this.ExitClimbType);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("速度", this.ActorComp.ActorVelocityProxy);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("动作", this.AnimComp.MainAnimInstance.GetMainAnimsDebugText());
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					this.TmpVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
					GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, -znInGravityForActor);
					this.MoveComp.SetForceSpeed(this.TmpVector);
				}
			}
			if (oldPositionState == global::ECharPositionState.Climb)
			{
				FTransformDouble? ftransformDouble = null;
				bool flag = false;
				if (Math.Abs(this.ActorComp.ActorForwardProxy.DotProduct(this.MoveComp.GravityUp)) > 9.99999993922529E-09)
				{
					MathUtils.Instance.LookRotationUpFirst(this.ActorComp.ActorForwardProxy, this.MoveComp.GravityUp, this.TmpQuat);
					this.TmpQuat.Rotator(this.TmpRotator);
					CharacterActorComponent actorComp = this.ActorComp;
					if (actorComp != null)
					{
						actorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "ExitClimb", false);
					}
					flag = true;
					if (this.AnimComp != null && ftransformDouble == null)
					{
						ftransformDouble = new FTransformDouble?(this.AnimComp.GetMeshTransform());
					}
				}
				if (!this.ActorComp.IsDefaultCapsule)
				{
					EResultForExitClimb eresultForExitClimb = LocomotionUtils.FindSpaceForExitClimb(this.ActorComp, this.ActorComp.DefaultHalfHeight, this.ActorComp.DefaultRadius, 5f, this.TmpVector);
					if (eresultForExitClimb == EResultForExitClimb.Safety)
					{
						this.ActorComp.SetActorLocation(this.TmpVector.ToUeVector(false), "ExitClimb Capsule Safety", false);
						flag = true;
						if (this.AnimComp != null && ftransformDouble == null)
						{
							ftransformDouble = new FTransformDouble?(this.AnimComp.GetMeshTransform());
						}
					}
					else if (eresultForExitClimb == EResultForExitClimb.NoSafety)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Movement;
						ELogAuthor author2 = ELogAuthor.LCZ;
						string message2 = "ExitClimb Capsule NotSafety";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
						string item = "CurrentLocation";
						CharacterActorComponent actorComp2 = this.ActorComp;
						ptr = new ValueTuple<string, object>(item, (actorComp2 != null) ? actorComp2.ActorLocationProxy : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Last", this.LastSafeLocation);
						instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						this.ActorComp.SetActorLocation(this.LastSafeLocation.ToUeVector(false), "ExitClimb Capsule NotSafety", false);
						flag = true;
						if (this.AnimComp != null && ftransformDouble == null)
						{
							ftransformDouble = new FTransformDouble?(this.AnimComp.GetMeshTransform());
						}
					}
				}
				if (flag && ftransformDouble != null)
				{
					this.AnimComp.SetModelBuffer(ftransformDouble.Value, 100f);
				}
				this.ActorComp.ResetCapsuleRadiusAndHeight(false);
				this.CleanClimbState();
				return;
			}
			if (newPositionState == global::ECharPositionState.Climb)
			{
				this.ActorComp.SetRadiusAndHalfHeight(5f, 5f, false, false);
			}
		}

		// Token: 0x060467EB RID: 288747 RVA: 0x011B46A8 File Offset: 0x011B28A8
		private void OnForbiddenClimbChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			if (count > 0)
			{
				if (this.ForbiddenClimbKey == null)
				{
					this.ForbiddenClimbKey = new int?(base.Disable("[CharacterClimbComponent.OnForbiddenClimbChanged] 禁用攀爬"));
					if (this.UnifiedStateComponent.PositionState == global::ECharPositionState.Climb)
					{
						this.NormalExitClimb();
						return;
					}
				}
			}
			else if (this.ForbiddenClimbKey != null)
			{
				base.Enable(new int?(this.ForbiddenClimbKey.Value), "[CharacterClimbComponent.OnForbiddenClimbChanged] 启用攀爬");
				this.ForbiddenClimbKey = null;
			}
		}

		// Token: 0x060467EC RID: 288748 RVA: 0x011B4726 File Offset: 0x011B2926
		private void OnForbiddenClimbOnWall(int count, int tagId, int exactTagId, int oldCount)
		{
			if (count > 0 && this.UnifiedStateComponent.PositionState == global::ECharPositionState.Climb)
			{
				this.NormalExitClimb();
			}
		}

		// Token: 0x060467ED RID: 288749 RVA: 0x011B4740 File Offset: 0x011B2940
		private void OnForceFastClimb(int tagId, bool bTagExists)
		{
			this.ForceFastClimb = bTagExists;
		}

		// Token: 0x060467EE RID: 288750 RVA: 0x011B474C File Offset: 0x011B294C
		public void UpdateClimbDebug()
		{
			if (GlobalData.IsPlayInEditor)
			{
				TsCharacterDebugComponent tsCharacterDebugComponent = this.ActorComp.Actor.TsCharacterDebugComponent;
				this.DebugNoTop = tsCharacterDebugComponent.NoTop;
				this.DebugEnterClimbTrace = tsCharacterDebugComponent.EnterClimbTrace;
				this.DebugVaultClimbTrace = tsCharacterDebugComponent.VaultClimbTrace;
				this.DebugUpArriveClimbTrace = tsCharacterDebugComponent.UpArriveClimbTrace;
				this.DebugClimbingTrace = tsCharacterDebugComponent.ClimbingTrace;
			}
		}

		// Token: 0x060467EF RID: 288751 RVA: 0x011B47C1 File Offset: 0x011B29C1
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.ClimbUpNewTransform = new FTransform?(FTransform.Identity);
			this.CacheTransformBeforeMove = new FTransform?(FTransform.Identity);
			this.RefTransform = FTransformDouble.Identity;
			this.RefFloat = 0f;
			return true;
		}

		// Token: 0x060467F0 RID: 288752 RVA: 0x011B47FA File Offset: 0x011B29FA
		protected override bool OnInit()
		{
			this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
			return true;
		}

		// Token: 0x060467F1 RID: 288753 RVA: 0x011B4810 File Offset: 0x011B2A10
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
			this.MoveComp = base.Entity.CheckGetComponent<CharacterMoveComponent>();
			this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
			this.UnifiedStateComponent = base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>();
			this.AwakeInput = true;
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChanged));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CustomMoveClimb, new Action<float>(this.ReceiveClimbEvent));
			EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
			EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			string roleBody = this.ActorComp.CreatureData.GetRoleConfig().Value.RoleBody;
			if (!this.InitClimbConfig(roleBody))
			{
				return false;
			}
			this.ClimbDownCompleted = true;
			this.InitTraceElement();
			if (this.TagComponent != null && this.TagComponent.Valid)
			{
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止攀爬"]))
				{
					this.ForbiddenClimbKey = new int?(base.Disable("[CharacterClimbComponent.OnStart] 包含了禁止攀爬Tag"));
				}
				this.TagComponent.ListenForTagAnyCountChanged(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止攀爬"], new BaseTagComponent.TTagChangedCallback(this.OnForbiddenClimbChanged));
				this.TagComponent.ListenForTagAnyCountChanged(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止上墙"], new BaseTagComponent.TTagChangedCallback(this.OnForbiddenClimbOnWall));
				this.TagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制快速攀爬"]), new BaseTagComponent.TTagSwitchedCallback(this.OnForceFastClimb), null);
			}
			this.LastSafeLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			return true;
		}

		// Token: 0x060467F2 RID: 288754 RVA: 0x011B4A20 File Offset: 0x011B2C20
		private void InitTraceElement()
		{
			this.TraceElement = new UTraceSphereElement();
			this.TraceElement.WorldContextObject = this.ActorComp.Owner;
			this.TraceElement.bIgnoreSelf = true;
			this.TraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
			this.TraceElement.SetDrawDebugTrace(this.DebugEnterClimbTrace);
			this.TraceElement.DrawTime = 5f;
			this.TraceElement.Radius = this.ClimbConfig.Value.ClimbRadius * 0.85f;
			TraceElementCommon.Instance.SetTraceColor(this.TraceElement, CharacterClimbComponent.TraceColor);
			TraceElementCommon.Instance.SetTraceHitColor(this.TraceElement, CharacterClimbComponent.TraceSuccessColor);
		}

		// Token: 0x060467F3 RID: 288755 RVA: 0x011B4AD9 File Offset: 0x011B2CD9
		protected override void OnActivate()
		{
			this.CapsuleHalfHeight = this.ActorComp.ScaledHalfHeight;
			this.UpdateClimbDebug();
		}

		// Token: 0x060467F4 RID: 288756 RVA: 0x011B4AF4 File Offset: 0x011B2CF4
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChanged));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CustomMoveClimb, new Action<float>(this.ReceiveClimbEvent));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
			EventSystem.Instance.Remove(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制快速攀爬"], new BaseTagComponent.TTagSwitchedCallback(this.OnForceFastClimb));
			}
			return true;
		}

		// Token: 0x060467F5 RID: 288757 RVA: 0x011B4BCC File Offset: 0x011B2DCC
		protected unsafe override void OnTick(float delta)
		{
			CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Ride)
			{
				return;
			}
			if (SundryModel.Instance.SceneCheckOn)
			{
				double num = global::Vector.Dist(this.ActorComp.ActorLocationProxy, this.CachedActorLocation);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "TickMove";
				<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PrevLocation", this.CachedActorLocation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CurrentLocation", this.ActorComp.ActorLocationProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("MovementMode", this.MoveComp.CharacterMovement.MovementMode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("CustomMode", this.MoveComp.CharacterMovement.CustomMovementMode);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Delta", delta);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("Dist", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("MainAnim", (this.AnimComp.MainAnimInstance as UKuroAnimInstance).GetDebugAnimNodeString());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
				if (num > (double)(2f * delta))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Test;
					ELogAuthor author2 = ELogAuthor.LCZ;
					string message2 = "OverSpeed";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Velocity", this.ActorComp.ActorVelocityProxy);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				if (num > 500.0)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Test;
					ELogAuthor author3 = ELogAuthor.LCZ;
					string message3 = "OverSpeed2";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Velocity", this.ActorComp.ActorVelocityProxy);
					instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
				actorTrace.WorldContextObject = this.ActorComp.Actor;
				actorTrace.Radius = 5f;
				TraceElementCommon.Instance.SetStartLocation(actorTrace, this.CachedActorLocation);
				TraceElementCommon.Instance.SetEndLocation(actorTrace, this.ActorComp.ActorLocationProxy);
				if (TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "CharacterClimbComponent_DetectClimbFromTop", "CharacterClimbComponent_DetectClimbFromTop"))
				{
					UKuroHitResult hitResult = actorTrace.HitResult;
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Test;
					ELogAuthor author4 = ELogAuthor.LCZ;
					string message4 = "MoveHit Something";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", hitResult.Actors.Get(0).Get());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Comp", hitResult.Components.Get(0).Get());
					instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				this.CachedActorLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			}
			global::Vector inputDirectProxy = this.ActorComp.InputDirectProxy;
			if (this.ClimbState != EClimbState.无)
			{
				if (inputDirectProxy.ContainsNaN())
				{
					this.ClimbInputDirect.Reset();
					Log instance5 = Log.Instance;
					ELogModule module5 = ELogModule.Movement;
					ELogAuthor author5 = ELogAuthor.LCZ;
					string message5 = "Set Climb Input Nan.";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Input", inputDirectProxy);
					instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}
				else
				{
					this.ClimbInputDirect.X = inputDirectProxy.X;
					this.ClimbInputDirect.Y = inputDirectProxy.Y;
				}
				if (this.OnWallAngle != 0f)
				{
					if (this.PrevClimbInputDirect.IsNearlyZero(9.999999747378752E-05))
					{
						this.PrevClimbInputDirect.DeepCopy(this.ClimbInputDirect);
					}
					else if (!this.PrevClimbInputDirect.Equals(this.ClimbInputDirect, 9.999999747378752E-05))
					{
						this.OnWallAngle = 0f;
					}
				}
			}
			else
			{
				this.ClimbInputDirect.Reset();
				this.PrevClimbInputDirect.Reset();
			}
			bool flag = this.UnifiedStateComponent.PositionState == global::ECharPositionState.Climb;
			if (!flag)
			{
				this.LastSafeLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			}
			else if (this.ClimbState != EClimbState.退出攀爬)
			{
				global::Vector lastSafeLocation = this.LastSafeLocation;
				FVectorDouble fvectorDouble = this.KuroClimbObject.D_GetSafetyLocation();
				lastSafeLocation.FromUeVector(fvectorDouble);
			}
			if (flag)
			{
				if (this.ExitClimbCountDown > 0f)
				{
					this.ExitClimbCountDown -= delta;
					if (this.ExitClimbCountDown <= 0f)
					{
						this.OnExitClimb();
						flag = false;
					}
				}
			}
			else
			{
				this.ExitClimbCountDown = 0f;
			}
			if (!flag && !this.PreCharacterStateInClimb)
			{
				if (!this.MoveComp.HasMoveInput)
				{
					CharacterUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
					if (unifiedStateComponent2 == null || unifiedStateComponent2.MoveState != global::ECharMoveState.Soar)
					{
						goto IL_509;
					}
				}
				if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.方向状态.面朝方向"]) || MathUtils.Instance.DotProduct(inputDirectProxy, this.ActorComp.ActorForwardProxy) > 0.7070000171661377)
				{
					this.SetClimbState(EClimbState.无);
					this.DetectClimb(delta);
				}
			}
			IL_509:
			if (flag && FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength) <= 0f && this.ClimbState != EClimbState.退出攀爬 && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFFID.体力消耗.攀爬跳跃"]))
			{
				this.NormalExitClimb();
			}
			this.PreCharacterStateInClimb = flag;
			if (CharacterClimbComponent.DebugLogController && flag)
			{
				this.PrintClimbDebugLog();
			}
			if (flag && this.ForceFastClimb)
			{
				CharacterUnifiedStateComponent unifiedStateComponent3 = this.UnifiedStateComponent;
				if (unifiedStateComponent3 != null && unifiedStateComponent3.MoveState == global::ECharMoveState.NormalClimb)
				{
					CharacterUnifiedStateComponent unifiedStateComponent4 = this.UnifiedStateComponent;
					if (unifiedStateComponent4 == null)
					{
						return;
					}
					unifiedStateComponent4.SwitchFastClimb(true, false);
				}
			}
		}

		// Token: 0x060467F6 RID: 288758 RVA: 0x011B516D File Offset: 0x011B336D
		public EExitClimb GetExitClimbType()
		{
			return this.ExitClimbType;
		}

		// Token: 0x060467F7 RID: 288759 RVA: 0x011B5178 File Offset: 0x011B3378
		private void DetectClimb(float deltaTime)
		{
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.冲刺"]))
			{
				return;
			}
			bool flag = this.IsSprintClimb();
			if (flag && this.UnifiedStateComponent.MoveState != global::ECharMoveState.Glide && this.UnifiedStateComponent.MoveState != global::ECharMoveState.Soar)
			{
				this.DetectSprintVault();
				if (this.ClimbState != EClimbState.无)
				{
					return;
				}
			}
			if (flag || this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.钩锁"]))
			{
				this.DetectClimbByMovementMode(true);
				CharacterActorComponent actorComp = this.ActorComp;
				CharacterSkillComponent characterSkillComponent;
				if (actorComp == null)
				{
					characterSkillComponent = null;
				}
				else
				{
					Entity entity = actorComp.Entity;
					characterSkillComponent = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
				}
				CharacterSkillComponent characterSkillComponent2 = characterSkillComponent;
				if (this.ClimbState != EClimbState.无)
				{
					characterSkillComponent2.StopGroup1Skill("攀爬打断技能");
					return;
				}
			}
			else
			{
				this.DetectClimbByMovementMode(false);
			}
		}

		// Token: 0x060467F8 RID: 288760 RVA: 0x011B5258 File Offset: 0x011B3458
		private void DetectClimbByMovementMode(bool bSprintEnter)
		{
			switch (this.UnifiedStateComponent.PositionState)
			{
			case global::ECharPositionState.Ground:
				this.DetectClimbWalking(bSprintEnter);
				return;
			case global::ECharPositionState.Climb:
				break;
			case global::ECharPositionState.Air:
				if (!CharacterClimbComponent.CanEnterClimbAirStates.Contains(this.UnifiedStateComponent.MoveState))
				{
					if (this.UnifiedStateComponent.MoveState == global::ECharMoveState.Soar)
					{
						this.DetectUpArriveBothVaultAndOnTop();
						if (this.ClimbState != EClimbState.无)
						{
							return;
						}
						this.SpeedDirect.FromUeVector(this.ActorComp.ActorVelocityProxy);
						GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.SpeedDirect);
						this.DetectEnterClimbWithDirectInternal(bSprintEnter ? EEnterClimb.技能进入 : EEnterClimb.空中进入, this.SpeedDirect, false);
						return;
					}
				}
				else if (this.IsForwardBlock())
				{
					this.DetectUpArriveBothVaultAndOnTop();
					if (this.ClimbState != EClimbState.无)
					{
						return;
					}
					this.DetectEnterClimb(bSprintEnter ? EEnterClimb.技能进入 : (this.MoveComp.IsJump ? EEnterClimb.地面上爬进入 : EEnterClimb.空中进入));
					return;
				}
				break;
			case global::ECharPositionState.Water:
				if (this.IsForwardBlock() && base.Entity.GetComponent<CharacterSwimComponent>().CheckCanEnterClimbFromSwim())
				{
					this.DetectUpArriveBothVaultAndOnTop();
					if (this.ClimbState == EClimbState.无)
					{
						this.DetectEnterClimb(EEnterClimb.水中进入);
					}
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x060467F9 RID: 288761 RVA: 0x011B5370 File Offset: 0x011B3570
		private void DetectUpArriveBothVaultAndOnTop()
		{
			EClimbingArriveType eclimbingArriveType = this.KuroClimbObject.D_TryUpArrives(this.ActorComp.ActorForward, this.GetTimeFromTraceType(this.DebugVaultClimbTrace), ref this.RefTransform);
			if (eclimbingArriveType == EClimbingArriveType.ClimbOnTop)
			{
				this.UpArrive(EExitClimb.到顶退出, this.RefTransform, true);
				return;
			}
			if (eclimbingArriveType != EClimbingArriveType.ClimbVault)
			{
				return;
			}
			this.UpArrive(EExitClimb.地面登上, this.RefTransform, true);
		}

		// Token: 0x060467FA RID: 288762 RVA: 0x011B53D4 File Offset: 0x011B35D4
		private void DetectClimbWalking(bool bSprintEnter)
		{
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走"]))
			{
				this.DetectClimbFromTop();
				if (this.ClimbState != EClimbState.无)
				{
					return;
				}
			}
			if (!this.IsForwardBlock())
			{
				return;
			}
			this.DetectUpArriveBothVaultAndOnTop();
			if (this.ClimbState != EClimbState.无)
			{
				return;
			}
			this.DetectEnterClimb(bSprintEnter ? EEnterClimb.技能进入 : EEnterClimb.地面上爬进入);
		}

		// Token: 0x060467FB RID: 288763 RVA: 0x011B5434 File Offset: 0x011B3634
		private void CleanClimbState()
		{
			this.KuroClimbObject.ExitClimb();
			this.SetClimbState(EClimbState.无);
			this.SetExitClimbType(EExitClimb.未知方式);
			this.CacheLastMoveDirect.Set(0.0, 0.0, 0.0);
			this.ActorComp.SetInputFacing(this.ActorComp.ActorForwardProxy, false);
			this.ClimbBlocking = false;
		}

		// Token: 0x060467FC RID: 288764 RVA: 0x011B54A3 File Offset: 0x011B36A3
		public bool CanClimbPress()
		{
			return true;
		}

		// Token: 0x060467FD RID: 288765 RVA: 0x011B54A8 File Offset: 0x011B36A8
		private void NormalExitClimb()
		{
			if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy) > 0.0)
			{
				this.TmpVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
				GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TmpVector);
				this.MoveComp.SetForceSpeed(this.TmpVector);
			}
			if (this.ClimbState == EClimbState.攀爬中)
			{
				this.ClimbingExitPositionFix();
			}
			if (this.UnifiedStateComponent.MoveState == global::ECharMoveState.FastClimb)
			{
				this.TmpVector.DeepCopy(this.ActorComp.InputDirectProxy);
				if (!this.TmpVector.IsNearlyZero(9.999999747378752E-05) && Math.Abs(this.TmpVector.Y) > 1E-08)
				{
					global::Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
					global::Vector actorRightProxy = this.ActorComp.ActorRightProxy;
					actorForwardProxy.Multiply(Math.Abs(this.TmpVector.X), this.TmpVector2);
					actorRightProxy.Multiply(this.TmpVector.Y, this.TmpVector3);
					this.TmpVector2.AdditionEqual(this.TmpVector3);
					MathUtils.Instance.LookRotationUpFirst(this.TmpVector2, this.MoveComp.GravityUp, this.TmpQuat);
					FTransformDouble actorTransform = this.ActorComp.ActorTransform;
					FQuat fquat = this.TmpQuat.ToUeQuat();
					actorTransform.SetRotation(fquat);
					this.SetCharacterTransformAndBuffer(actorTransform, 300f, null, true);
				}
			}
			this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[CharacterClimbComponent.NormalExitClimb]"
			});
		}

		// Token: 0x060467FE RID: 288766 RVA: 0x011B565C File Offset: 0x011B385C
		public void ClimbPress(bool pressed)
		{
			CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Climb && (this.ClimbState == EClimbState.攀爬中 || (this.ClimbState == EClimbState.进入攀爬 && this.IsAllowEarlyExitClimb)))
			{
				this.NormalExitClimb();
				this.NextCanEnterClimbTime = (float)Time.Instance.Now + 500f;
			}
		}

		// Token: 0x060467FF RID: 288767 RVA: 0x011B56B8 File Offset: 0x011B38B8
		private float CalculateClimbAngle(global::Vector inputDirect, global::Vector wallNormal)
		{
			this.TmpVector.DeepCopy(wallNormal);
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TmpVector);
			this.TmpVector.Normalize(9.99999993922529E-09);
			return GravityUtils.Instance.GetAngleOffsetInGravityForActor(this.ActorComp, wallNormal, inputDirect);
		}

		// Token: 0x06046800 RID: 288768 RVA: 0x011B570F File Offset: 0x011B390F
		protected bool NeedProcessTransform()
		{
			return (this.ClimbState != EClimbState.进入攀爬 || this.ClimbDownCompleted) && (this.ClimbState == EClimbState.攀爬中 || this.ClimbState == EClimbState.进入攀爬);
		}

		// Token: 0x06046801 RID: 288769 RVA: 0x011B573C File Offset: 0x011B393C
		private void ConfirmMove(FTransformDouble newTransform, float CachedTime = 200f)
		{
			global::Vector tmpVector = this.TmpVector;
			FVectorDouble location = newTransform.GetLocation();
			tmpVector.FromUeVector(location);
			if (this.AnimComp != null && this.AnimComp.Valid && MathUtils.Instance.DotProduct(newTransform.GetRotation().GetForwardVector(), this.CacheTransformBeforeMove.Value.GetRotation().GetForwardVector()) < 0.8999999761581421)
			{
				this.SetCharacterTransformAndBuffer(newTransform, CachedTime, null, true);
			}
			else
			{
				this.ActorComp.SetActorTransform(newTransform, "攀爬.ConfirmMove", true, null);
			}
			this.KuroClimbObject.ConfirmMove();
		}

		// Token: 0x06046802 RID: 288770 RVA: 0x011B57F0 File Offset: 0x011B39F0
		private bool IsForwardBlock()
		{
			global::Vector tmpVector = this.TmpVector;
			FVector fvector = this.MoveComp.CharacterMovement.Kuro_GetBlockDirectWhenMove();
			tmpVector.FromUeVector(fvector);
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TmpVector);
			return this.TmpVector.Normalize(9.99999993922529E-09) && this.ActorComp.InputDirectProxy.DotProduct(this.TmpVector) <= -0.7070000171661377;
		}

		// Token: 0x06046803 RID: 288771 RVA: 0x011B5870 File Offset: 0x011B3A70
		private unsafe void UpArrive(EExitClimb exitType, FTransformDouble transform, bool changeMovementMode = true)
		{
			if (this.UnifiedStateComponent.PositionState == global::ECharPositionState.Ground)
			{
				this.MoveComp.PlayerMotionRequest(MotionType.StepAcross);
			}
			else
			{
				this.MoveComp.PlayerMotionRequest(MotionType.ClimbTop);
			}
			if (changeMovementMode)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Custom,
						Context = "[CharacterClimbComponent.UpArrive]"
					});
				}
			}
			this.SetClimbState(EClimbState.退出攀爬);
			this.ExitClimbCountDown = 800f;
			this.SetExitClimbType(exitType);
			EventSystem.Instance.Emit<int, EExitClimb>(EEventName.CharClimbStartExit, base.Entity.Id, exitType);
			FVectorDouble fvectorDouble;
			if (this.IsSprintClimb())
			{
				if (exitType == EExitClimb.到顶退出)
				{
					this.SetExitClimbType(EExitClimb.跑墙退出);
				}
				else if (exitType == EExitClimb.地面登上)
				{
					this.SetExitClimbType(EExitClimb.冲刺跨越近);
					this.TmpVector.Set(0.0, 0.0, (double)(this.ClimbVault.Value.Z - this.ClimbSprintVault.Value.Z));
					fvectorDouble = this.TmpVector.ToUeVector(false);
					FVectorDouble fvectorDouble2 = transform.TransformPosition(fvectorDouble);
					transform.SetLocation(fvectorDouble2);
				}
			}
			global::Vector climbUpNewLocation = this.ClimbUpNewLocation;
			fvectorDouble = transform.GetLocation();
			climbUpNewLocation.FromUeVector(fvectorDouble);
			if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorForwardProxy) <= 0.0)
			{
				fvectorDouble = this.ActorComp.ActorLocation;
				transform.SetLocation(fvectorDouble);
				this.ClimbUpNewLocation.Subtraction(this.ActorComp.ActorLocationProxy, this.TmpVector);
				GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, 2.0);
			}
			else
			{
				this.TmpVector.DeepCopy(this.ClimbUpNewLocation);
				GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, this.TmpVector, GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorLocationProxy));
				fvectorDouble = this.TmpVector.ToUeVector(false);
				transform.SetLocation(fvectorDouble);
				this.TmpVector.Reset();
				this.ClimbUpNewLocation.Subtraction(this.ActorComp.ActorLocationProxy, this.TmpVector2);
				GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TmpVector2) + 2.0);
			}
			BlackboardController.Instance.SetVectorValueByEntity(base.Entity.Id, "ClimbOnTopMove", this.TmpVector.X, this.TmpVector.Y, this.TmpVector.Z);
			if (exitType == EExitClimb.反斜登顶)
			{
				FVector secondMoveOffset = this.KuroClimbObject.GetSecondMoveOffset();
				BlackboardController.Instance.SetVectorValueByEntity(base.Entity.Id, "ClimbBlockUpSecondMove", (double)secondMoveOffset.X, (double)secondMoveOffset.Y, (double)secondMoveOffset.Z);
			}
			if (SundryModel.Instance.SceneCheckOn)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "UpArrive";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NewLocation", transform.GetLocation());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("From", this.ActorComp.ActorLocationProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Forward", this.ActorComp.ActorForwardProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ExitClimbType", this.ExitClimbType);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			if (this.ExitClimbType == EExitClimb.冲刺跨越近 || this.ExitClimbType == EExitClimb.冲刺跨越远 || this.ExitClimbType == EExitClimb.跑墙退出)
			{
				this.SetCharacterTransformAndBuffer(transform, 100f, null, true);
			}
			else
			{
				this.SetCharacterTransformAndBuffer(transform, 300f, null, true);
			}
			if (SundryModel.Instance.SceneCheckOn)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Test;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "UpArrive2";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Location", this.ActorComp.ActorLocationProxy);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06046804 RID: 288772 RVA: 0x011B5C7F File Offset: 0x011B3E7F
		private float GetTimeFromTraceType(EDrawDebugTrace TraceType)
		{
			if (TraceType == EDrawDebugTrace.ForOneFrame)
			{
				return 0.1f;
			}
			if (TraceType != EDrawDebugTrace.ForDuration)
			{
				return 0f;
			}
			return 5f;
		}

		// Token: 0x06046805 RID: 288773 RVA: 0x011B5C9C File Offset: 0x011B3E9C
		private void DetectClimbFromTop()
		{
		}

		// Token: 0x06046806 RID: 288774 RVA: 0x011B5CAC File Offset: 0x011B3EAC
		private void DetectEnterClimb(EEnterClimb enterType)
		{
			if ((double)this.NextCanEnterClimbTime > Time.Instance.Now || FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength) <= 10f)
			{
				return;
			}
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止上墙"]))
			{
				return;
			}
			if (this.UnifiedStateComponent.PositionState == global::ECharPositionState.Air && this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
			{
				this.SpeedDirect.DeepCopy(this.ActorComp.InputDirectProxy);
			}
			else
			{
				global::Vector actorVelocityProxy = this.ActorComp.ActorVelocityProxy;
				if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, actorVelocityProxy) < -500.0)
				{
					return;
				}
				this.ActorComp.InputDirectProxy.Multiply(500.0, this.SpeedDirect);
				this.SpeedDirect.AdditionEqual(actorVelocityProxy);
			}
			this.DetectEnterClimbWithDirectInternal(enterType, this.SpeedDirect, false);
		}

		// Token: 0x06046807 RID: 288775 RVA: 0x011B5DA4 File Offset: 0x011B3FA4
		private unsafe void DetectEnterClimbWithDirectInternal(EEnterClimb enterType, global::Vector speedDirect, bool log = false)
		{
			if (!speedDirect.Normalize(9.99999993922529E-09))
			{
				return;
			}
			if (this.ClimbTrans == null)
			{
				this.ClimbTrans = global::Transform.Create();
			}
			this.ClimbTrans.SetLocation(this.ActorComp.ActorLocationProxy);
			this.ClimbTrans.SetScale3D(this.ActorComp.ActorScaleProxy);
			MathUtils.Instance.LookRotationForwardFirst(speedDirect, this.MoveComp.GravityUp, this.ClimbTrans.GetRotation());
			if (!this.KuroClimbObject.D_TryStartClimb(this.ClimbTrans.ToUeTransform(), this.GetTimeFromTraceType(this.DebugEnterClimbTrace), ref this.RefTransform))
			{
				if (log)
				{
					Log.Instance.Info(ELogModule.Character, ELogAuthor.CWZ, "TryStartClimb检测非法，进入攀爬失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return;
			}
			this.TmpQuat.FromUeQuat(this.RefTransform.GetRotation());
			this.TmpQuat.GetForwardVector(this.TmpVector);
			if (GravityUtils.Instance.GetAngleOffsetInGravityAbsForActor(this.ActorComp, this.TmpVector, speedDirect) > 35f)
			{
				if (log)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CWZ;
					string message = "超过一定角度则不允许进入攀爬";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("speedDirect", speedDirect);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TmpVector", this.TmpVector);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return;
			}
			this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Custom,
				CustomMode = 0,
				Context = "CharacterClimbComponent.DetectEnterClimbWithDirectInternal",
				Callback = delegate()
				{
					if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]))
					{
						this.SetClimbState(EClimbState.攀爬中);
					}
					else
					{
						this.SetClimbState(EClimbState.进入攀爬);
					}
					this.SetEnterClimbType(enterType);
					if (enterType == EEnterClimb.技能进入)
					{
						this.UnifiedStateComponent.SwitchFastClimb(true, false);
						global::Vector vector = global::Vector.Create(this.RefTransform.GetRotation().GetForwardVector());
						vector.Normalize(1E-08);
						this.OnWallAngle = this.CalculateClimbAngle(this.ActorComp.ActorForwardProxy, vector);
					}
					else
					{
						this.OnWallAngle = 0f;
					}
					this.ConfirmMove(this.RefTransform, 200f);
					this.ClimbDownCompleted = true;
					if (log)
					{
						Log.Instance.Info(ELogModule.Character, ELogAuthor.CWZ, "成功进入攀爬状态", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
			});
		}

		// Token: 0x06046808 RID: 288776 RVA: 0x011B5F74 File Offset: 0x011B4174
		private void DownArrive()
		{
			this.NormalExitClimb();
		}

		// Token: 0x06046809 RID: 288777 RVA: 0x011B5F7C File Offset: 0x011B417C
		private void DetectSprintVault()
		{
			ESprintVaultType esprintVaultType = this.KuroClimbObject.D_TrySprintVault(this.GetTimeFromTraceType(this.DebugVaultClimbTrace), ref this.RefTransform, ref this.RefFloat);
			if (esprintVaultType != ESprintVaultType.Short)
			{
				if (esprintVaultType != ESprintVaultType.Long)
				{
					return;
				}
				FTransformDouble refTransform = this.RefTransform;
				this.UpArrive(EExitClimb.冲刺跨越远, refTransform, true);
				this.TmpQuat.FromUeQuat(refTransform.GetRotation());
				this.TmpQuat.RotateVector(global::Vector.ForwardVectorProxy, this.TmpVector);
				this.TmpVector.MultiplyEqual((double)this.RefFloat);
				BlackboardController.Instance.SetVectorValueByEntity(base.Entity.Id, "ClimbAddMove", this.TmpVector.X, this.TmpVector.Y, this.TmpVector.Z);
			}
			else
			{
				this.UpArrive(EExitClimb.冲刺跨越近, this.RefTransform, true);
			}
			RoleAudioController.Instance.PlayRoleAudio(base.Entity, ERoleAudioType.ClimbLeap, null);
		}

		// Token: 0x0604680A RID: 288778 RVA: 0x011B606C File Offset: 0x011B426C
		public void DealClimbUpStart()
		{
		}

		// Token: 0x0604680B RID: 288779 RVA: 0x011B6070 File Offset: 0x011B4270
		public unsafe void DealClimbUpFinish()
		{
			EResultForExitClimb eresultForExitClimb = LocomotionUtils.FindSpaceForExitClimb(this.ActorComp, this.ActorComp.DefaultHalfHeight, this.ActorComp.DefaultRadius, 5f, this.TmpVector);
			if (eresultForExitClimb == EResultForExitClimb.Safety)
			{
				this.TmpTransform.Set(this.TmpVector, this.ActorComp.ActorQuatProxy, this.ActorComp.ActorScaleProxy);
				this.SetCharacterTransformAndBuffer(this.TmpTransform.ToUeTransform(), 100f, null, false);
			}
			else if (eresultForExitClimb == EResultForExitClimb.NoSafety)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "DealClimbUpFinish NotSafety";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "CurrentLocation";
				CharacterActorComponent actorComp = this.ActorComp;
				ptr = new ValueTuple<string, object>(item, (actorComp != null) ? actorComp.ActorLocationProxy : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Last", this.LastSafeLocation);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.TmpTransform.Set(this.LastSafeLocation, this.ActorComp.ActorQuatProxy, this.ActorComp.ActorScaleProxy);
				this.SetCharacterTransformAndBuffer(this.TmpTransform.ToUeTransform(), 100f, null, false);
			}
			this.ActorComp.ResetCapsuleRadiusAndHeight(false);
		}

		// Token: 0x0604680C RID: 288780 RVA: 0x011B61AC File Offset: 0x011B43AC
		private unsafe void ClimbEvent(float deltaTime)
		{
			bool flag = this.NeedProcessTransform();
			if (SundryModel.Instance.SceneCheckOn)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "ProcessClimbing";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Location", this.ActorComp.ActorLocationProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HasKuroRootMotionAnim", this.AnimComp.GetAnimInstance().HasKuroRootMotionAnim());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("MoveSpeed", this.MoveComp.CharacterMovement.AnimRootMotionVelocity);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("DeltaTime", deltaTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("NeedProcess", flag);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
			global::Vector tmpVector = this.TmpVector;
			FVector animRootMotionVelocity = this.MoveComp.CharacterMovement.AnimRootMotionVelocity;
			FVectorDouble fvectorDouble = animRootMotionVelocity;
			tmpVector.DeepCopy(fvectorDouble);
			if (this.BufferTimeLength != null)
			{
				this.BufferNowTime += deltaTime;
				float bufferNowTime = this.BufferNowTime;
				float? bufferTimeLength = this.BufferTimeLength;
				float num;
				if (bufferNowTime > bufferTimeLength.GetValueOrDefault() & bufferTimeLength != null)
				{
					num = (this.BufferTimeLength.Value - this.BufferNowTime + deltaTime) / deltaTime;
				}
				else
				{
					num = 1f;
				}
				this.BufferOffsetSpeed.Multiply((double)num, this.TmpVector2);
				this.TmpVector.AdditionEqual(this.TmpVector2);
				float bufferNowTime2 = this.BufferNowTime;
				bufferTimeLength = this.BufferTimeLength;
				if (bufferNowTime2 > bufferTimeLength.GetValueOrDefault() & bufferTimeLength != null)
				{
					this.BufferTimeLength = null;
				}
			}
			if (!this.KuroClimbObject.D_ProcessClimbing(this.TmpVector.ToUeVector(false), deltaTime, flag, this.GetTimeFromTraceType(this.DebugClimbingTrace), ref this.RefTransform))
			{
				if (SundryModel.Instance.SceneCheckOn)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Test;
					ELogAuthor author2 = ELogAuthor.LCZ;
					string message2 = "ProcessClimbing Failed";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Location", this.ActorComp.Actor.D_K2_GetActorLocation());
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.NormalExitClimb();
				return;
			}
			this.ClimbBlocking = this.KuroClimbObject.ClimbBlock();
			if (SundryModel.Instance.SceneCheckOn)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Test;
				ELogAuthor author3 = ELogAuthor.LCZ;
				string message3 = "ProcessClimbing Success";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Location", this.ActorComp.Actor.D_K2_GetActorLocation());
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			this.ActorComp.ResetLocationCachedTime();
			if (!flag)
			{
				return;
			}
			switch (this.KuroClimbObject.D_TryClimbingArrives(this.ActorComp.InputDirect, this.GetTimeFromTraceType(this.DebugUpArriveClimbTrace), ref this.RefTransform, this.IsSprintClimb()))
			{
			case EClimbingArriveType.ClimbOnTop:
				this.UpArrive(EExitClimb.到顶退出, this.RefTransform, false);
				return;
			case EClimbingArriveType.ClimbVault:
				this.UpArrive(EExitClimb.地面登上, this.RefTransform, false);
				return;
			case EClimbingArriveType.ClimbDownArrive:
				this.DownArrive();
				return;
			case EClimbingArriveType.ClimbBlockUp:
				this.UpArrive(EExitClimb.反斜登顶, this.RefTransform, false);
				return;
			default:
				return;
			}
		}

		// Token: 0x0604680D RID: 288781 RVA: 0x011B6510 File Offset: 0x011B4710
		public SClimbInfo GetClimbInfo()
		{
			if (this.ClimbInputDirect.ContainsNaN())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "GetClimbInfo Nan.";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ClimbInput", this.ClimbInputDirect);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ClimbInputDirect.Reset();
			}
			this.ClimbInfo.攀爬移动中 = !this.AwakeInput;
			this.ClimbInfo.攀爬输入向量 = this.ClimbInputDirect.ToUeVector2D(false);
			return this.ClimbInfo;
		}

		// Token: 0x0604680E RID: 288782 RVA: 0x011B6594 File Offset: 0x011B4794
		public FClimbInfoStruct GetClimbInfoNew()
		{
			if (this.ClimbInputDirect.ContainsNaN())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "GetClimbInfo Nan.";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ClimbInput", this.ClimbInputDirect);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ClimbInputDirect.Reset();
			}
			this.ClimbInfoNew.IsClimbMoving = !this.AwakeInput;
			this.ClimbInfoNew.ClimbInput = this.ClimbInputDirect.ToUeVector2D(false);
			this.ClimbInfoNew.OnWallAngle = this.OnWallAngle;
			return this.ClimbInfoNew;
		}

		// Token: 0x0604680F RID: 288783 RVA: 0x011B6628 File Offset: 0x011B4828
		public SClimbInfo GetTsClimbInfo()
		{
			if (this.ClimbInputDirect.ContainsNaN())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "GetClimbInfo Nan.";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ClimbInput", this.ClimbInputDirect);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ClimbInputDirect.Reset();
			}
			this.TsClimbInfo.攀爬移动中 = !this.AwakeInput;
			this.TsClimbInfo.攀爬输入向量.DeepCopy(this.ClimbInputDirect);
			this.TsClimbInfo.OnWallAngle = this.OnWallAngle;
			return this.TsClimbInfo;
		}

		// Token: 0x06046810 RID: 288784 RVA: 0x011B66BC File Offset: 0x011B48BC
		public void FinishClimbDown()
		{
			this.ClimbDownCompleted = true;
			if (this.KuroClimbObject.D_TryStartClimb(this.ActorComp.ActorTransform, 0f, ref this.RefTransform))
			{
				this.ConfirmMove(this.RefTransform, 200f);
				return;
			}
			Log.Instance.Error(ELogModule.Movement, ELogAuthor.LCZ, "下爬动作完成后停留在了一个不太适合攀爬的地点", default(ReadOnlySpan<ValueTuple<string, object>>));
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[CharacterClimbComponent.FinishClimbDown]"
			});
		}

		// Token: 0x06046811 RID: 288785 RVA: 0x011B674C File Offset: 0x011B494C
		[NullableContext(2)]
		public void SetCharacterTransformAndBuffer(FTransformDouble newTransform, float smoothTime, global::Vector newLocation = null, bool sweep = true)
		{
			this.BufferTimeLength = null;
			if (newLocation != null)
			{
				if (smoothTime > 0f)
				{
					global::Vector tmpVector = this.TmpVector;
					FVectorDouble fvectorDouble = newTransform.GetTranslation();
					tmpVector.FromUeVector(fvectorDouble);
					newLocation.Subtraction(this.TmpVector, this.BufferOffsetSpeed);
					this.BufferOffsetSpeed.DivisionEqual((double)smoothTime * TimeUtil.Instance.Millisecond);
					this.BufferNowTime = 0f;
					this.BufferTimeLength = new float?(smoothTime * (float)TimeUtil.Instance.Millisecond);
				}
				else
				{
					FVectorDouble fvectorDouble = newLocation.ToUeVector(false);
					newTransform.SetLocation(fvectorDouble);
				}
			}
			if (this.AnimComp != null && this.AnimComp.Valid)
			{
				this.AnimComp.SetTransformWithModelBuffer(newTransform, smoothTime, null, sweep);
				return;
			}
			this.ActorComp.SetActorTransform(newTransform, "攀爬.SetCharacterTransformAndBuffer", sweep, null);
		}

		// Token: 0x06046812 RID: 288786 RVA: 0x011B6832 File Offset: 0x011B4A32
		public void KickWallExit()
		{
			this.SetExitClimbType(EExitClimb.蹬墙退出);
			this.SetClimbState(EClimbState.退出攀爬);
		}

		// Token: 0x06046813 RID: 288787 RVA: 0x011B6844 File Offset: 0x011B4A44
		public unsafe void SetClimbState(EClimbState climbState)
		{
			if (this.ClimbState == climbState)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "SetClimbState";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("From", this.ClimbState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("To", climbState);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.ClimbState = climbState;
			this.TsOutputClimbState.攀爬状态 = climbState;
			if (this.UnifiedStateComponent.PositionState != global::ECharPositionState.Climb)
			{
				return;
			}
			switch (climbState)
			{
			case EClimbState.进入攀爬:
				this.UnifiedStateComponent.SetMoveState(global::ECharMoveState.EnterClimb);
				return;
			case EClimbState.攀爬中:
				if (this.ClimbInputDirect.IsNearlyZero(9.999999747378752E-05))
				{
					this.UnifiedStateComponent.SetMoveState(global::ECharMoveState.Other);
					return;
				}
				this.UnifiedStateComponent.SwitchFastClimb(this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]), true);
				return;
			case EClimbState.退出攀爬:
				this.UnifiedStateComponent.SetMoveState(global::ECharMoveState.ExitClimb);
				return;
			default:
				return;
			}
		}

		// Token: 0x06046814 RID: 288788 RVA: 0x011B697F File Offset: 0x011B4B7F
		public void SetEnterClimbType(EEnterClimb enterType)
		{
			this.EnterClimbType = enterType;
			this.TsOutputClimbState.进入攀爬类型 = enterType;
		}

		// Token: 0x06046815 RID: 288789 RVA: 0x011B6994 File Offset: 0x011B4B94
		public void SetExitClimbType(EExitClimb exitClimbType)
		{
			bool flag = this.NotConsumeStrengthExitClimbTypes.Contains(this.ExitClimbType);
			bool flag2 = this.NotConsumeStrengthExitClimbTypes.Contains(exitClimbType);
			if (flag)
			{
				if (!flag2)
				{
					this.TagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFFID.体力消耗.Buff体力消耗无效"]));
				}
			}
			else if (flag2)
			{
				this.TagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFFID.体力消耗.Buff体力消耗无效"]));
			}
			this.ExitClimbType = exitClimbType;
			this.TsOutputClimbState.退出攀爬类型 = exitClimbType;
			if (exitClimbType != EExitClimb.未知方式)
			{
				this.LastExitClimbType = exitClimbType;
				this.LastExitClimbTime = (float)Time.Instance.PlayerWorldTime;
			}
		}

		// Token: 0x06046816 RID: 288790 RVA: 0x011B6A38 File Offset: 0x011B4C38
		public SClimbState GetClimbState()
		{
			this.OutputClimbState.攀爬状态 = this.ClimbState;
			this.OutputClimbState.进入攀爬类型 = this.EnterClimbType;
			this.OutputClimbState.退出攀爬类型 = this.ExitClimbType;
			return this.OutputClimbState;
		}

		// Token: 0x06046817 RID: 288791 RVA: 0x011B6A8D File Offset: 0x011B4C8D
		public FClimbStateStruct GetClimbStateNew()
		{
			this.OutputClimbStateNew.ClimbState = (EClimbStateType)this.ClimbState;
			this.OutputClimbStateNew.EnterClimbType = (EEnterClimbType)this.EnterClimbType;
			this.OutputClimbStateNew.ExitClimbType = (EExitClimbType)this.ExitClimbType;
			return this.OutputClimbStateNew;
		}

		// Token: 0x06046818 RID: 288792 RVA: 0x011B6AC8 File Offset: 0x011B4CC8
		public SClimbState GetTsClimbState()
		{
			return this.TsOutputClimbState;
		}

		// Token: 0x06046819 RID: 288793 RVA: 0x011B6AD0 File Offset: 0x011B4CD0
		public float GetOnWallAngle()
		{
			return this.OnWallAngle;
		}

		// Token: 0x0604681A RID: 288794 RVA: 0x011B6AD8 File Offset: 0x011B4CD8
		public void OnEnterClimb()
		{
			if (this.ClimbState != EClimbState.进入攀爬)
			{
				return;
			}
			this.SetClimbState(EClimbState.攀爬中);
			this.SetExitClimbType(EExitClimb.未知方式);
		}

		// Token: 0x0604681B RID: 288795 RVA: 0x011B6AF4 File Offset: 0x011B4CF4
		public unsafe void OnExitClimb()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "OnExitClimb";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.ClimbState == EClimbState.无)
			{
				return;
			}
			switch (this.ExitClimbType)
			{
			case EExitClimb.到顶退出:
			case EExitClimb.到底退出:
			case EExitClimb.跑墙退出:
			case EExitClimb.地面登上:
			case EExitClimb.冲刺跨越近:
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp == null)
				{
					goto IL_CB;
				}
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Walking,
					Context = "[CharacterClimbComponent.OnExitClimb] Walking"
				});
				goto IL_CB;
			}
			}
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Falling,
					Context = "[CharacterClimbComponent.OnExitClimb] Falling"
				});
			}
			IL_CB:
			float? bufferTimeLength = this.BufferTimeLength;
			float num = 0f;
			if (bufferTimeLength.GetValueOrDefault() > num & bufferTimeLength != null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Movement;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "ClimbUp Buffer is not finished";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Now", this.BufferNowTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TimeLength", this.BufferTimeLength);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.BufferTimeLength = null;
			}
		}

		// Token: 0x0604681C RID: 288796 RVA: 0x011B6C61 File Offset: 0x011B4E61
		public void ClimbKeyPressed(bool pressed)
		{
			this.ClimbPress(pressed);
		}

		// Token: 0x0604681D RID: 288797 RVA: 0x011B6C6A File Offset: 0x011B4E6A
		public void AwakeClimbInput(bool awake)
		{
			this.AwakeInput = awake;
		}

		// Token: 0x0604681E RID: 288798 RVA: 0x011B6C74 File Offset: 0x011B4E74
		public void KickExitCheck()
		{
			if (this.UnifiedStateComponent.PositionState == global::ECharPositionState.Climb)
			{
				if (this.ClimbInputDirect.X < -0.7070000171661377)
				{
					this.KickWallExit();
					return;
				}
				CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
				if (component.Valid)
				{
					component.ClimbDash();
				}
			}
		}

		// Token: 0x0604681F RID: 288799 RVA: 0x011B6CC8 File Offset: 0x011B4EC8
		public float GetClimbRadius()
		{
			if (this.ClimbConfig == null)
			{
				return 0f;
			}
			return this.ClimbConfig.Value.ClimbRadius;
		}

		// Token: 0x06046820 RID: 288800 RVA: 0x011B6CFC File Offset: 0x011B4EFC
		public bool DetectClimbWithDirect(bool bSprintEnter, FVectorDouble direct, bool log = false)
		{
			if (!base.Active || this.UnifiedStateComponent.PositionState == global::ECharPositionState.Climb)
			{
				if (log)
				{
					Log.Instance.Info(ELogModule.Character, ELogAuthor.CWZ, "已处于攀爬状态，进入攀爬检测失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return false;
			}
			this.SetClimbState(EClimbState.无);
			EClimbingArriveType eclimbingArriveType = this.KuroClimbObject.D_TryUpArrives(direct, this.GetTimeFromTraceType(this.DebugEnterClimbTrace), ref this.RefTransform);
			if (eclimbingArriveType == EClimbingArriveType.ClimbOnTop)
			{
				this.UpArrive(EExitClimb.到顶退出, this.RefTransform, true);
				if (log)
				{
					Log.Instance.Info(ELogModule.Character, ELogAuthor.CWZ, "到顶退出进入攀爬", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return true;
			}
			if (eclimbingArriveType != EClimbingArriveType.ClimbVault)
			{
				this.SpeedDirect.FromUeVector(direct);
				this.DetectEnterClimbWithDirectInternal(bSprintEnter ? EEnterClimb.技能进入 : (this.MoveComp.IsJump ? EEnterClimb.地面上爬进入 : EEnterClimb.空中进入), this.SpeedDirect, log);
				return this.ClimbState > EClimbState.无;
			}
			this.UpArrive(EExitClimb.地面登上, this.RefTransform, true);
			if (log)
			{
				Log.Instance.Info(ELogModule.Character, ELogAuthor.CWZ, "地面登上进入攀爬", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return true;
		}

		// Token: 0x06046821 RID: 288801 RVA: 0x011B6E0D File Offset: 0x011B500D
		public void ResetClimbObjectConfig(string key)
		{
			this.InitClimbConfig(key);
		}

		// Token: 0x06046822 RID: 288802 RVA: 0x011B6E18 File Offset: 0x011B5018
		private bool InitClimbConfig(string key)
		{
			this.ClimbConfig = ConfigClimbById.GetConfig(key, true);
			if (this.ClimbConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "没有配置攀爬";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleBody", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (this.KuroClimbObject == null)
			{
				this.KuroClimbObject = new UKuroClimbObject(this.ActorComp.Actor, null, EObjectFlags.RF_NoFlags);
			}
			TArray<FVector> tarray = new TArray<FVector>();
			foreach (Aki.Config.Vector value in this.ClimbConfig.Value.ClimbDetectPointsIter())
			{
				tarray.Add(WorldGlobal.ToUeVectorOld(VectorExtension.ToProtocolVector(new Aki.Config.Vector?(value))));
			}
			this.KuroClimbObject.InitBase(this.ActorComp.Actor.CapsuleComponent, KuroCollisionChannel.Climb, tarray, this.ClimbConfig.Value.DetectRadius, this.ClimbConfig.Value.ClimbRadius, 150f, 0f, 0f);
			this.KuroClimbObject.InitClimbSafety(25f, 85f, 100f);
			this.ClimbVault = new FVector?(WorldGlobal.ToUeVectorOld(VectorExtension.ToProtocolVector(this.ClimbConfig.Value.ClimbVault)));
			this.ClimbOnTop = new FVector?(WorldGlobal.ToUeVectorOld(VectorExtension.ToProtocolVector(this.ClimbConfig.Value.ClimbOnTop)));
			this.ClimbFromTop = new FVector?(WorldGlobal.ToUeVectorOld(VectorExtension.ToProtocolVector(this.ClimbConfig.Value.ClimbFromTop)));
			this.ClimbSprintVault = new FVector?(WorldGlobal.ToUeVectorOld(VectorExtension.ToProtocolVector(this.ClimbConfig.Value.ClimbSprintVault)));
			this.ClimbInfo = default(SClimbInfo);
			this.ClimbInfoNew = new FClimbInfoStruct();
			this.TsClimbInfo = new SClimbInfo(null, null, null);
			this.OutputClimbState = default(SClimbState);
			this.OutputClimbStateNew = new FClimbStateStruct();
			this.TsOutputClimbState = new SClimbState(null, null, null);
			tarray.Empty(true);
			TArray<float> tarray2 = new TArray<float>();
			TArray<float> tarray3 = new TArray<float>();
			tarray.Add(this.ClimbOnTop.Value);
			tarray2.Add(this.ClimbConfig.Value.UpArriveRange.Value.Min);
			tarray3.Add(this.ClimbConfig.Value.UpArriveRange.Value.Max);
			tarray.Add(this.ClimbVault.Value);
			tarray2.Add(this.ClimbConfig.Value.VaultRange.Value.Min);
			tarray3.Add(this.ClimbConfig.Value.VaultRange.Value.Max);
			this.KuroClimbObject.InitUpArrives(tarray, tarray2, tarray3);
			this.KuroClimbObject.InitSprintVault(this.ClimbConfig.Value.ForwardBlockHeight, this.ClimbConfig.Value.ForwardBlockRadius, this.ClimbConfig.Value.ForwardBlockDistance.Value.Min, this.ClimbConfig.Value.ForwardBlockDistance.Value.Max, this.ClimbSprintVault.Value, this.ClimbConfig.Value.SprintVaultRange.Value.Min, this.ClimbConfig.Value.SprintVaultRange.Value.Max, this.ClimbConfig.Value.SprintVaultLongNeedDistance, this.ClimbConfig.Value.SprintVaultLongHeight, KuroTraceTypeQuery.AcrossBlock, this.ClimbConfig.Value.SprintVaultLongRange.Value.Min, this.ClimbConfig.Value.SprintVaultLongRange.Value.Max, 45f);
			this.KuroClimbObject.InitBlockUps(WorldGlobal.ToUeVectorOld(VectorExtension.ToProtocolVector(this.ClimbConfig.Value.BlockUpOffset)), this.ClimbConfig.Value.BlockUpDetectRadius, this.ClimbConfig.Value.BlockUpDetectDistance, this.ClimbConfig.Value.BlockUpBackDistance, this.ClimbConfig.Value.BlockUpBackMinDist, new FVector?(WorldGlobal.ToUeVectorOld(VectorExtension.ToProtocolVector(this.ClimbConfig.Value.BlockUpFinalMove))), this.ClimbConfig.Value.BlockUpVerticalRange.Value.Min, this.ClimbConfig.Value.BlockUpVerticalRange.Value.Max);
			return true;
		}

		// Token: 0x06046823 RID: 288803 RVA: 0x011B73B0 File Offset: 0x011B55B0
		private void ClimbingExitPositionFix()
		{
			global::Vector tmpVector = this.TmpVector2;
			FVectorDouble fvectorDouble = this.KuroClimbObject.D_GetSafetyLocation();
			tmpVector.FromUeVector(fvectorDouble);
			this.ActorComp.ActorLocationProxy.Subtraction(this.TmpVector2, this.TmpVector);
			float num = this.ActorComp.DefaultHalfHeight - this.ActorComp.DefaultRadius;
			float num2 = 60f - num;
			double num3 = GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TmpVector);
			double num4 = this.TmpVector.SizeSquared();
			float num5 = 25f - this.ActorComp.DefaultRadius;
			if (num5 <= 0f)
			{
				this.TmpVector.Reset();
			}
			else if (num4 > (double)(num5 * num5))
			{
				float num6 = num5 / (float)Math.Sqrt(num4);
				this.TmpVector.MultiplyEqual((double)num6);
			}
			if (num2 <= 0f)
			{
				num3 = 0.0;
			}
			else if (num3 > (double)num2)
			{
				num3 = (double)num2;
			}
			else if (num3 < (double)(-(double)num2))
			{
				num3 = (double)(-(double)num2);
			}
			GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, num3);
			this.TmpVector.AdditionEqual(this.TmpVector2);
			MathUtils.Instance.LookRotationUpFirst(this.ActorComp.ActorForwardProxy, this.MoveComp.GravityUp, this.TmpQuat);
			this.TmpTransform.Set(this.TmpVector, this.TmpQuat, this.ActorComp.ActorScaleProxy);
			this.SetCharacterTransformAndBuffer(this.TmpTransform.ToUeTransform(), 200f, null, false);
			this.ActorComp.ResetCapsuleRadiusAndHeight(false);
		}

		// Token: 0x06046824 RID: 288804 RVA: 0x011B7544 File Offset: 0x011B5744
		private bool IsSprintClimb()
		{
			return (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.冲刺保持"]) && !this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.快速攀爬禁止"])) || this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制快速攀爬"]);
		}

		// Token: 0x06046825 RID: 288805 RVA: 0x011B75A5 File Offset: 0x011B57A5
		public void SetLastSafeLocation(global::Vector location)
		{
			this.LastSafeLocation.DeepCopy(location);
		}

		// Token: 0x06046826 RID: 288806 RVA: 0x011B75B3 File Offset: 0x011B57B3
		private void OnTeleportStart(bool loading)
		{
			CharacterUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Climb)
			{
				this.OnExitClimb();
			}
		}

		// Token: 0x06046827 RID: 288807 RVA: 0x011B75D4 File Offset: 0x011B57D4
		private void PrintClimbDebugLog()
		{
			UAnimInstance mainAnimInstance = base.Entity.GetComponent<CharacterAnimationComponent>().MainAnimInstance;
			if (UKuroStaticLibrary.IsObjectClassByName(mainAnimInstance, CharacterNameDefines.Instance.ABP_BASEROLE))
			{
				ABP_BaseRole_C abp_BaseRole_C = mainAnimInstance as ABP_BaseRole_C;
				FVector2D climbInput = abp_BaseRole_C.LogicParams.ClimbInfoRef.ClimbInput;
				float num = (float)(57.29577951308232 * Math.Atan2((double)climbInput.Y, (double)climbInput.X));
				if (num < 0f)
				{
					num += 360f;
				}
				num += abp_BaseRole_C.LogicParams.ClimbOnWallAngleRef;
				float currentValue;
				if (num < 90f)
				{
					currentValue = num / 90f;
				}
				else if (num < 180f)
				{
					currentValue = 1f;
				}
				else if (num < 270f)
				{
					currentValue = -1f;
				}
				else
				{
					currentValue = (num - 360f) / 90f;
				}
				currentValue = MathUtils.Instance.Clamp(currentValue, -1f, 1f);
			}
		}

		// Token: 0x06046828 RID: 288808 RVA: 0x011B76C0 File Offset: 0x011B58C0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterClimbComponent characterClimbComponent = (CharacterClimbComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterClimbComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (characterClimbComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AnimComp"))
			{
				if (characterClimbComponent.AnimComp == null)
				{
					this.AnimComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClimbConfig"))
			{
				this.ClimbConfig = characterClimbComponent.ClimbConfig;
			}
			if (base.CanResetComponentProperty("ClimbVault"))
			{
				this.ClimbVault = characterClimbComponent.ClimbVault;
			}
			if (base.CanResetComponentProperty("ClimbOnTop"))
			{
				this.ClimbOnTop = characterClimbComponent.ClimbOnTop;
			}
			if (base.CanResetComponentProperty("ClimbFromTop"))
			{
				this.ClimbFromTop = characterClimbComponent.ClimbFromTop;
			}
			if (base.CanResetComponentProperty("ClimbInfo"))
			{
				this.ClimbInfo = characterClimbComponent.ClimbInfo;
			}
			if (base.CanResetComponentProperty("ClimbInfoNew"))
			{
				if (characterClimbComponent.ClimbInfoNew == null)
				{
					this.ClimbInfoNew = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FClimbInfoStruct>(this.ClimbInfoNew), "ClimbInfoNew"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TsClimbInfo"))
			{
				if (characterClimbComponent.TsClimbInfo == null)
				{
					this.TsClimbInfo = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SClimbInfo>(this.TsClimbInfo), "TsClimbInfo"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OutputClimbState"))
			{
				this.OutputClimbState = characterClimbComponent.OutputClimbState;
			}
			if (base.CanResetComponentProperty("OutputClimbStateNew"))
			{
				if (characterClimbComponent.OutputClimbStateNew == null)
				{
					this.OutputClimbStateNew = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FClimbStateStruct>(this.OutputClimbStateNew), "OutputClimbStateNew"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TsOutputClimbState"))
			{
				if (characterClimbComponent.TsOutputClimbState == null)
				{
					this.TsOutputClimbState = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SClimbState>(this.TsOutputClimbState), "TsOutputClimbState"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClimbUpNewTransform"))
			{
				this.ClimbUpNewTransform = characterClimbComponent.ClimbUpNewTransform;
			}
			if (base.CanResetComponentProperty("ClimbUpNewLocation"))
			{
				if (characterClimbComponent.ClimbUpNewLocation == null)
				{
					this.ClimbUpNewLocation = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.ClimbUpNewLocation), "ClimbUpNewLocation"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClimbSprintVault"))
			{
				this.ClimbSprintVault = characterClimbComponent.ClimbSprintVault;
			}
			if (base.CanResetComponentProperty("CacheTransformBeforeMove"))
			{
				this.CacheTransformBeforeMove = characterClimbComponent.CacheTransformBeforeMove;
			}
			if (base.CanResetComponentProperty("CacheLastMoveDirect") && characterClimbComponent.CacheLastMoveDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheLastMoveDirect), "CacheLastMoveDirect"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ClimbInputDirect") && characterClimbComponent.ClimbInputDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector2D>(this.ClimbInputDirect), "ClimbInputDirect"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("PrevClimbInputDirect") && characterClimbComponent.PrevClimbInputDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector2D>(this.PrevClimbInputDirect), "PrevClimbInputDirect"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("CapsuleHalfHeight"))
			{
				this.CapsuleHalfHeight = characterClimbComponent.CapsuleHalfHeight;
			}
			if (base.CanResetComponentProperty("AwakeInput"))
			{
				this.AwakeInput = characterClimbComponent.AwakeInput;
			}
			if (base.CanResetComponentProperty("ClimbDownCompleted"))
			{
				this.ClimbDownCompleted = characterClimbComponent.ClimbDownCompleted;
			}
			if (base.CanResetComponentProperty("PreCharacterStateInClimb"))
			{
				this.PreCharacterStateInClimb = characterClimbComponent.PreCharacterStateInClimb;
			}
			if (base.CanResetComponentProperty("ClimbState"))
			{
				this.ClimbState = characterClimbComponent.ClimbState;
			}
			if (base.CanResetComponentProperty("ExitClimbType"))
			{
				this.ExitClimbType = characterClimbComponent.ExitClimbType;
			}
			if (base.CanResetComponentProperty("EnterClimbType"))
			{
				this.EnterClimbType = characterClimbComponent.EnterClimbType;
			}
			if (base.CanResetComponentProperty("ExitClimbCountDown"))
			{
				this.ExitClimbCountDown = characterClimbComponent.ExitClimbCountDown;
			}
			if (base.CanResetComponentProperty("LastExitClimbTime"))
			{
				this.LastExitClimbTime = characterClimbComponent.LastExitClimbTime;
			}
			if (base.CanResetComponentProperty("LastExitClimbType"))
			{
				this.LastExitClimbType = characterClimbComponent.LastExitClimbType;
			}
			if (base.CanResetComponentProperty("ClimbBlockingInternal"))
			{
				this.ClimbBlockingInternal = characterClimbComponent.ClimbBlockingInternal;
			}
			if (base.CanResetComponentProperty("OnWallAngle"))
			{
				this.OnWallAngle = characterClimbComponent.OnWallAngle;
			}
			if (base.CanResetComponentProperty("IsAllowEarlyExitClimb"))
			{
				this.IsAllowEarlyExitClimb = characterClimbComponent.IsAllowEarlyExitClimb;
			}
			if (base.CanResetComponentProperty("RefTransform"))
			{
				this.RefTransform = characterClimbComponent.RefTransform;
			}
			if (base.CanResetComponentProperty("RefFloat"))
			{
				this.RefFloat = characterClimbComponent.RefFloat;
			}
			if (base.CanResetComponentProperty("LastSafeLocation") && characterClimbComponent.LastSafeLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LastSafeLocation), "LastSafeLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TagComponent"))
			{
				if (characterClimbComponent.TagComponent == null)
				{
					this.TagComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("UnifiedStateComponent"))
			{
				if (characterClimbComponent.UnifiedStateComponent == null)
				{
					this.UnifiedStateComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComponent), "UnifiedStateComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BufferOffsetSpeed") && characterClimbComponent.BufferOffsetSpeed != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.BufferOffsetSpeed), "BufferOffsetSpeed"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("BufferTimeLength"))
			{
				this.BufferTimeLength = characterClimbComponent.BufferTimeLength;
			}
			if (base.CanResetComponentProperty("BufferNowTime"))
			{
				this.BufferNowTime = characterClimbComponent.BufferNowTime;
			}
			if (base.CanResetComponentProperty("SpeedDirect") && characterClimbComponent.SpeedDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SpeedDirect), "SpeedDirect"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpVector") && characterClimbComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector), "TmpVector"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpVector2") && characterClimbComponent.TmpVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector2), "TmpVector2"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpVector3") && characterClimbComponent.TmpVector3 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector3), "TmpVector3"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpQuat") && characterClimbComponent.TmpQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat), "TmpQuat"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpRotator") && characterClimbComponent.TmpRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.TmpRotator), "TmpRotator"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TmpTransform") && characterClimbComponent.TmpTransform != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Transform>(this.TmpTransform), "TmpTransform"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("KuroClimbObject"))
			{
				if (characterClimbComponent.KuroClimbObject == null)
				{
					this.KuroClimbObject = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroClimbObject>(this.KuroClimbObject), "KuroClimbObject"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DebugNoTop"))
			{
				this.DebugNoTop = characterClimbComponent.DebugNoTop;
			}
			if (base.CanResetComponentProperty("DebugEnterClimbTrace"))
			{
				this.DebugEnterClimbTrace = characterClimbComponent.DebugEnterClimbTrace;
			}
			if (base.CanResetComponentProperty("DebugVaultClimbTrace"))
			{
				this.DebugVaultClimbTrace = characterClimbComponent.DebugVaultClimbTrace;
			}
			if (base.CanResetComponentProperty("DebugUpArriveClimbTrace"))
			{
				this.DebugUpArriveClimbTrace = characterClimbComponent.DebugUpArriveClimbTrace;
			}
			if (base.CanResetComponentProperty("DebugClimbingTrace"))
			{
				this.DebugClimbingTrace = characterClimbComponent.DebugClimbingTrace;
			}
			if (base.CanResetComponentProperty("TraceElement"))
			{
				if (characterClimbComponent.TraceElement == null)
				{
					this.TraceElement = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.TraceElement), "TraceElement"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("NextCanEnterClimbTime"))
			{
				this.NextCanEnterClimbTime = characterClimbComponent.NextCanEnterClimbTime;
			}
			if (base.CanResetComponentProperty("ForbiddenClimbKey"))
			{
				this.ForbiddenClimbKey = characterClimbComponent.ForbiddenClimbKey;
			}
			if (base.CanResetComponentProperty("ForceFastClimb"))
			{
				this.ForceFastClimb = characterClimbComponent.ForceFastClimb;
			}
			if (base.CanResetComponentProperty("CachedActorLocation") && characterClimbComponent.CachedActorLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedActorLocation), "CachedActorLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("OnTickStat1") && characterClimbComponent.OnTickStat1 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.OnTickStat1), "OnTickStat1"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("OnTickStat2") && characterClimbComponent.OnTickStat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.OnTickStat2), "OnTickStat2"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("OnTickStat3") && characterClimbComponent.OnTickStat3 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.OnTickStat3), "OnTickStat3"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DetectClimbStat1") && characterClimbComponent.DetectClimbStat1 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.DetectClimbStat1), "DetectClimbStat1"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DetectClimbStat2") && characterClimbComponent.DetectClimbStat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.DetectClimbStat2), "DetectClimbStat2"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DetectClimbStat3") && characterClimbComponent.DetectClimbStat3 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.DetectClimbStat3), "DetectClimbStat3"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DetectUpArriveBothVaultAndOnTopStat1") && characterClimbComponent.DetectUpArriveBothVaultAndOnTopStat1 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.DetectUpArriveBothVaultAndOnTopStat1), "DetectUpArriveBothVaultAndOnTopStat1"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DetectUpArriveBothVaultAndOnTopStat2") && characterClimbComponent.DetectUpArriveBothVaultAndOnTopStat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.DetectUpArriveBothVaultAndOnTopStat2), "DetectUpArriveBothVaultAndOnTopStat2"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DetectClimbWalkingStat1") && characterClimbComponent.DetectClimbWalkingStat1 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.DetectClimbWalkingStat1), "DetectClimbWalkingStat1"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("Rotator180"))
			{
				if (characterClimbComponent.Rotator180 == null)
				{
					this.Rotator180 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.Rotator180), "Rotator180"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DetectEnterClimbStat1"))
			{
				if (characterClimbComponent.DetectEnterClimbStat1 == null)
				{
					this.DetectEnterClimbStat1 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.DetectEnterClimbStat1), "DetectEnterClimbStat1"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DetectEnterClimbStat2"))
			{
				if (characterClimbComponent.DetectEnterClimbStat2 == null)
				{
					this.DetectEnterClimbStat2 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.DetectEnterClimbStat2), "DetectEnterClimbStat2"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClimbTrans"))
			{
				if (characterClimbComponent.ClimbTrans == null)
				{
					this.ClimbTrans = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Transform>(this.ClimbTrans), "ClimbTrans"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("NotConsumeStrengthExitClimbTypes") && characterClimbComponent.NotConsumeStrengthExitClimbTypes != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EExitClimb>(this.NotConsumeStrengthExitClimbTypes), "NotConsumeStrengthExitClimbTypes"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ClimbingExitPositionFixStat1"))
			{
				if (characterClimbComponent.ClimbingExitPositionFixStat1 == null)
				{
					this.ClimbingExitPositionFixStat1 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.ClimbingExitPositionFixStat1), "ClimbingExitPositionFixStat1"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClimbingExitPositionFixStat2"))
			{
				if (characterClimbComponent.ClimbingExitPositionFixStat2 == null)
				{
					this.ClimbingExitPositionFixStat2 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.ClimbingExitPositionFixStat2), "ClimbingExitPositionFixStat2"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ClimbingExitPositionFixStat3"))
			{
				if (characterClimbComponent.ClimbingExitPositionFixStat3 == null)
				{
					this.ClimbingExitPositionFixStat3 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.ClimbingExitPositionFixStat3), "ClimbingExitPositionFixStat3"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024F2F RID: 151343
		private const string PROFILE_KEY = "CharacterClimbComponent_DetectClimbFromTop";

		// Token: 0x04024F30 RID: 151344
		private const float THREAHOLD_JUMP_LEAVE = -0.707f;

		// Token: 0x04024F31 RID: 151345
		private const float THREADHOLD_ENTER_CLIMB_FORWARD_NEED = 0.707f;

		// Token: 0x04024F32 RID: 151346
		private const float THREAHOLD_ENTER_CLIMB_MIN_Z_SPEED = -500f;

		// Token: 0x04024F33 RID: 151347
		private const float FIVE_SECONDS = 5f;

		// Token: 0x04024F34 RID: 151348
		private const float NORMAL_CACHE_TIME = 200f;

		// Token: 0x04024F35 RID: 151349
		private const float FAST_CACHE_TIME = 100f;

		// Token: 0x04024F36 RID: 151350
		private const float CACHE_TIME_FROM_TOP = 400f;

		// Token: 0x04024F37 RID: 151351
		private const float CACHE_TIME_UP_ARRIVE = 300f;

		// Token: 0x04024F38 RID: 151352
		private const float EXIT_CLIMB_CACHE_TIME = 300f;

		// Token: 0x04024F39 RID: 151353
		private const float INPUT_ADD_LENGTH = 500f;

		// Token: 0x04024F3A RID: 151354
		private const float DOUBLE_HALFHEIGHT = 2f;

		// Token: 0x04024F3B RID: 151355
		private const float ONE_POINT_FIVE_HALFHRIGHT = 1.5f;

		// Token: 0x04024F3C RID: 151356
		private const float KINDA_LESS_THAN_ONE = 0.85f;

		// Token: 0x04024F3D RID: 151357
		private const float STRENGTH_THREADHOLD = 10f;

		// Token: 0x04024F3E RID: 151358
		private const float THREADHOLD_FORWARD_BLOCK = -0.707f;

		// Token: 0x04024F3F RID: 151359
		private const float THREADHOLD_MODEL_BUFFER = 0.9f;

		// Token: 0x04024F40 RID: 151360
		private const int NORMAL_GROUP_ID = 1;

		// Token: 0x04024F41 RID: 151361
		private const float SHORT_DRAW_TIME = 0.1f;

		// Token: 0x04024F42 RID: 151362
		private const float LONG_DRAW_TIME = 5f;

		// Token: 0x04024F43 RID: 151363
		private const float CAN_ENTER_CLIMB_CD = 500f;

		// Token: 0x04024F44 RID: 151364
		private const float CLIMBING_CAPSULE_SIZE = 5f;

		// Token: 0x04024F45 RID: 151365
		private const float MAX_ROLE_HALF_HEIGHT = 85f;

		// Token: 0x04024F46 RID: 151366
		private const float MAX_ROLE_RADIUS = 25f;

		// Token: 0x04024F47 RID: 151367
		private const float MAX_ROLE_CYLINDER_HALF_HEIGHT = 60f;

		// Token: 0x04024F48 RID: 151368
		private const float MAX_SAFETY_DIST = 100f;

		// Token: 0x04024F49 RID: 151369
		private const float ENTER_CLIMB_ANGLE = 35f;

		// Token: 0x04024F4A RID: 151370
		private const float ENTER_SPINT_VAULT_ANGLE = 45f;

		// Token: 0x04024F4B RID: 151371
		private const float DEFAULT_DETECT_LENGTH = 150f;

		// Token: 0x04024F4C RID: 151372
		private const float EXIT_CLIMB_TIME = 800f;

		// Token: 0x04024F4D RID: 151373
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor TraceColor = new FLinearColor(1f, 0f, 0f, 1f);

		// Token: 0x04024F4E RID: 151374
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor TraceSuccessColor = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x04024F4F RID: 151375
		[StaticVariableRuleIgnore]
		private static readonly HashSet<global::ECharMoveState> CanEnterClimbAirStates = new HashSet<global::ECharMoveState>
		{
			global::ECharMoveState.Other,
			global::ECharMoveState.Flying,
			global::ECharMoveState.Glide,
			global::ECharMoveState.Slide
		};

		// Token: 0x04024F50 RID: 151376
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04024F51 RID: 151377
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x04024F52 RID: 151378
		[Nullable(2)]
		private CharacterAnimationComponent AnimComp;

		// Token: 0x04024F53 RID: 151379
		private Climb? ClimbConfig;

		// Token: 0x04024F54 RID: 151380
		private FVector? ClimbVault;

		// Token: 0x04024F55 RID: 151381
		private FVector? ClimbOnTop;

		// Token: 0x04024F56 RID: 151382
		private FVector? ClimbFromTop;

		// Token: 0x04024F57 RID: 151383
		private SClimbInfo ClimbInfo;

		// Token: 0x04024F58 RID: 151384
		[Nullable(2)]
		private FClimbInfoStruct ClimbInfoNew;

		// Token: 0x04024F59 RID: 151385
		[Nullable(2)]
		private SClimbInfo TsClimbInfo;

		// Token: 0x04024F5A RID: 151386
		private SClimbState OutputClimbState;

		// Token: 0x04024F5B RID: 151387
		[Nullable(2)]
		private FClimbStateStruct OutputClimbStateNew;

		// Token: 0x04024F5C RID: 151388
		[Nullable(2)]
		private SClimbState TsOutputClimbState;

		// Token: 0x04024F5D RID: 151389
		private FTransform? ClimbUpNewTransform;

		// Token: 0x04024F5E RID: 151390
		private global::Vector ClimbUpNewLocation = global::Vector.Create();

		// Token: 0x04024F5F RID: 151391
		private FVector? ClimbSprintVault;

		// Token: 0x04024F60 RID: 151392
		private FTransform? CacheTransformBeforeMove;

		// Token: 0x04024F61 RID: 151393
		private readonly global::Vector CacheLastMoveDirect = global::Vector.Create();

		// Token: 0x04024F62 RID: 151394
		private readonly Vector2D ClimbInputDirect = Vector2D.Create();

		// Token: 0x04024F63 RID: 151395
		private readonly Vector2D PrevClimbInputDirect = Vector2D.Create();

		// Token: 0x04024F64 RID: 151396
		private float CapsuleHalfHeight;

		// Token: 0x04024F65 RID: 151397
		private bool AwakeInput;

		// Token: 0x04024F66 RID: 151398
		private bool ClimbDownCompleted;

		// Token: 0x04024F67 RID: 151399
		private bool PreCharacterStateInClimb;

		// Token: 0x04024F68 RID: 151400
		private EClimbState ClimbState;

		// Token: 0x04024F69 RID: 151401
		private EExitClimb ExitClimbType = EExitClimb.未知方式;

		// Token: 0x04024F6A RID: 151402
		private EEnterClimb EnterClimbType;

		// Token: 0x04024F6B RID: 151403
		private float ExitClimbCountDown;

		// Token: 0x04024F6C RID: 151404
		public float LastExitClimbTime;

		// Token: 0x04024F6D RID: 151405
		public EExitClimb LastExitClimbType = EExitClimb.未知方式;

		// Token: 0x04024F6E RID: 151406
		private bool ClimbBlockingInternal;

		// Token: 0x04024F6F RID: 151407
		private float OnWallAngle;

		// Token: 0x04024F70 RID: 151408
		private bool IsAllowEarlyExitClimb;

		// Token: 0x04024F71 RID: 151409
		private FTransformDouble RefTransform;

		// Token: 0x04024F72 RID: 151410
		private float RefFloat;

		// Token: 0x04024F73 RID: 151411
		private readonly global::Vector LastSafeLocation = global::Vector.Create();

		// Token: 0x04024F74 RID: 151412
		[Nullable(2)]
		private BaseTagComponent TagComponent;

		// Token: 0x04024F75 RID: 151413
		[Nullable(2)]
		private CharacterUnifiedStateComponent UnifiedStateComponent;

		// Token: 0x04024F76 RID: 151414
		private readonly global::Vector BufferOffsetSpeed = global::Vector.Create();

		// Token: 0x04024F77 RID: 151415
		private float? BufferTimeLength;

		// Token: 0x04024F78 RID: 151416
		private float BufferNowTime;

		// Token: 0x04024F79 RID: 151417
		private readonly global::Vector SpeedDirect = global::Vector.Create();

		// Token: 0x04024F7A RID: 151418
		private readonly global::Vector TmpVector = global::Vector.Create();

		// Token: 0x04024F7B RID: 151419
		private readonly global::Vector TmpVector2 = global::Vector.Create();

		// Token: 0x04024F7C RID: 151420
		private readonly global::Vector TmpVector3 = global::Vector.Create();

		// Token: 0x04024F7D RID: 151421
		private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04024F7E RID: 151422
		private readonly global::Rotator TmpRotator = global::Rotator.Create();

		// Token: 0x04024F7F RID: 151423
		private readonly global::Transform TmpTransform = global::Transform.Create();

		// Token: 0x04024F80 RID: 151424
		[Nullable(2)]
		private UKuroClimbObject KuroClimbObject;

		// Token: 0x04024F81 RID: 151425
		protected bool DebugNoTop;

		// Token: 0x04024F82 RID: 151426
		private EDrawDebugTrace DebugEnterClimbTrace;

		// Token: 0x04024F83 RID: 151427
		private EDrawDebugTrace DebugVaultClimbTrace;

		// Token: 0x04024F84 RID: 151428
		private EDrawDebugTrace DebugUpArriveClimbTrace;

		// Token: 0x04024F85 RID: 151429
		private EDrawDebugTrace DebugClimbingTrace;

		// Token: 0x04024F86 RID: 151430
		[Nullable(2)]
		private UTraceSphereElement TraceElement;

		// Token: 0x04024F87 RID: 151431
		private float NextCanEnterClimbTime;

		// Token: 0x04024F88 RID: 151432
		private int? ForbiddenClimbKey;

		// Token: 0x04024F89 RID: 151433
		private bool ForceFastClimb;

		// Token: 0x04024F8A RID: 151434
		private readonly global::Vector CachedActorLocation = global::Vector.Create();

		// Token: 0x04024F8B RID: 151435
		private readonly Stat OnTickStat1 = Stat.Create("OnTick1", "", "");

		// Token: 0x04024F8C RID: 151436
		private readonly Stat OnTickStat2 = Stat.Create("OnTick2", "", "");

		// Token: 0x04024F8D RID: 151437
		private readonly Stat OnTickStat3 = Stat.Create("OnTick3", "", "");

		// Token: 0x04024F8E RID: 151438
		private readonly Stat DetectClimbStat1 = Stat.Create("DetectClimb1", "", "");

		// Token: 0x04024F8F RID: 151439
		private readonly Stat DetectClimbStat2 = Stat.Create("DetectClimb2", "", "");

		// Token: 0x04024F90 RID: 151440
		private readonly Stat DetectClimbStat3 = Stat.Create("DetectClimb3", "", "");

		// Token: 0x04024F91 RID: 151441
		private readonly Stat DetectUpArriveBothVaultAndOnTopStat1 = Stat.Create("DetectUpArriveBothVaultAndOnTop1", "", "");

		// Token: 0x04024F92 RID: 151442
		private readonly Stat DetectUpArriveBothVaultAndOnTopStat2 = Stat.Create("DetectUpArriveBothVaultAndOnTop2", "", "");

		// Token: 0x04024F93 RID: 151443
		private readonly Stat DetectClimbWalkingStat1 = Stat.Create("DetectClimbWalking1", "", "");

		// Token: 0x04024F94 RID: 151444
		private global::Rotator Rotator180 = global::Rotator.Create(0f, 180f, 0f);

		// Token: 0x04024F95 RID: 151445
		private Stat DetectEnterClimbStat1 = Stat.Create("DetectEnterClimb1", "", "");

		// Token: 0x04024F96 RID: 151446
		private Stat DetectEnterClimbStat2 = Stat.Create("DetectEnterClimb2", "", "");

		// Token: 0x04024F97 RID: 151447
		[Nullable(2)]
		private global::Transform ClimbTrans;

		// Token: 0x04024F98 RID: 151448
		[StaticVariableRuleIgnore]
		private static Stat Stat1 = Stat.Create("ClimbStat1", "", "");

		// Token: 0x04024F99 RID: 151449
		[StaticVariableRuleIgnore]
		private static Stat Stat2 = Stat.Create("ClimbStat2", "", "");

		// Token: 0x04024F9A RID: 151450
		[StaticVariableRuleIgnore]
		private static Stat Stat3 = Stat.Create("ClimbStat3", "", "");

		// Token: 0x04024F9B RID: 151451
		private readonly HashSet<EExitClimb> NotConsumeStrengthExitClimbTypes = new HashSet<EExitClimb>
		{
			EExitClimb.到顶退出,
			EExitClimb.地面登上,
			EExitClimb.冲刺跨越近,
			EExitClimb.冲刺跨越远
		};

		// Token: 0x04024F9C RID: 151452
		private Stat ClimbingExitPositionFixStat1 = Stat.Create("ClimbingExitPositionFix1", "", "");

		// Token: 0x04024F9D RID: 151453
		private Stat ClimbingExitPositionFixStat2 = Stat.Create("ClimbingExitPositionFix2", "", "");

		// Token: 0x04024F9E RID: 151454
		private Stat ClimbingExitPositionFixStat3 = Stat.Create("ClimbingExitPositionFix3", "", "");

		// Token: 0x04024F9F RID: 151455
		[StaticVariableRuleIgnore]
		public static bool DebugLogController = false;
	}
}
