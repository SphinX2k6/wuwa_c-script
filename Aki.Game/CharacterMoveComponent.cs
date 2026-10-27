using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02003079 RID: 12409
[NullableContext(1)]
[Nullable(0)]
public class CharacterMoveComponent : BaseMoveComponent, IComponentDependency, IStaticVariableResetter
{
	// Token: 0x0601A7A7 RID: 108455 RVA: 0x00712CD8 File Offset: 0x00710ED8
	static CharacterMoveComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterMoveComponent.CreateStaticDefaultValue), new Action(CharacterMoveComponent.ResetStaticDefaultValue));
	}

	// Token: 0x17002470 RID: 9328
	// (get) Token: 0x0601A7A8 RID: 108456 RVA: 0x00712D5F File Offset: 0x00710F5F
	// (set) Token: 0x0601A7A9 RID: 108457 RVA: 0x00712D66 File Offset: 0x00710F66
	[StaticVariableRuleIgnore]
	public static bool EnableKuroAsyncRootMotion
	{
		get
		{
			return CharacterMoveComponent.EnableKuroAsyncRootMotionInternal;
		}
		set
		{
			CharacterMoveComponent.EnableKuroAsyncRootMotionInternal = value;
		}
	}

	// Token: 0x17002471 RID: 9329
	// (get) Token: 0x0601A7AA RID: 108458 RVA: 0x00712D6E File Offset: 0x00710F6E
	public static Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent)
			};
		}
	}

	// Token: 0x0601A7AB RID: 108459 RVA: 0x00712D84 File Offset: 0x00710F84
	public void SetForceFallingSpeed(FVector speed, int tagId)
	{
		this.ForceFallingSpeedCache.ForceFallingSpeed.FromUeVector(speed);
		double addZ = GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.ForceFallingSpeedCache.ForceFallingSpeed);
		this.TmpVector.Reset();
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, addZ);
		base.SetForceSpeed(this.TmpVector);
		this.ForceFallingSpeedCache.Tag = tagId;
		this.ForceFallingSpeedCache.HasForceFallingSpeed = true;
	}

	// Token: 0x0601A7AC RID: 108460 RVA: 0x00712E08 File Offset: 0x00711008
	public override bool ConsumeForceFallingSpeed()
	{
		if (!this.ForceFallingSpeedCache.HasForceFallingSpeed)
		{
			return false;
		}
		if (!this.TagComponent.HasTag(this.ForceFallingSpeedCache.Tag))
		{
			this.ForceFallingSpeedCache.HasForceFallingSpeed = false;
			return false;
		}
		if (!this.AnimComp.HasKuroRootMotion && this.CharacterMovement.MovementMode == EMovementMode.MOVE_Falling)
		{
			double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy);
			GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, this.ForceFallingSpeedCache.ForceFallingSpeed, (double)((float)znInGravityForActor));
			base.SetForceSpeed(this.ForceFallingSpeedCache.ForceFallingSpeed);
			this.ForceFallingSpeedCache.HasForceFallingSpeed = false;
			return true;
		}
		return false;
	}

	// Token: 0x17002472 RID: 9330
	// (get) Token: 0x0601A7AD RID: 108461 RVA: 0x00712EC9 File Offset: 0x007110C9
	public float WalkSpeed
	{
		get
		{
			return base.CurrentMovementSettings.WalkSpeed;
		}
	}

	// Token: 0x17002473 RID: 9331
	// (get) Token: 0x0601A7AE RID: 108462 RVA: 0x00712ED6 File Offset: 0x007110D6
	public float RunSpeed
	{
		get
		{
			return base.CurrentMovementSettings.RunSpeed;
		}
	}

	// Token: 0x17002474 RID: 9332
	// (get) Token: 0x0601A7AF RID: 108463 RVA: 0x00712EE3 File Offset: 0x007110E3
	public float SprintSpeed
	{
		get
		{
			return base.CurrentMovementSettings.SprintSpeed;
		}
	}

	// Token: 0x17002475 RID: 9333
	// (get) Token: 0x0601A7B0 RID: 108464 RVA: 0x00712EF0 File Offset: 0x007110F0
	public float SwimSpeed
	{
		get
		{
			return base.CurrentMovementSettings.NormalSwimSpeed;
		}
	}

	// Token: 0x17002476 RID: 9334
	// (get) Token: 0x0601A7B1 RID: 108465 RVA: 0x00712EFD File Offset: 0x007110FD
	public float FastSwimSpeed
	{
		get
		{
			return base.CurrentMovementSettings.FastSwimSpeed;
		}
	}

	// Token: 0x17002477 RID: 9335
	// (get) Token: 0x0601A7B2 RID: 108466 RVA: 0x00712F0A File Offset: 0x0071110A
	public bool IsKuroPlanarPhysWalkingEnable
	{
		get
		{
			return this.IsKuroPlanarPhysWalkingEnableInternal;
		}
	}

	// Token: 0x0601A7B3 RID: 108467 RVA: 0x00712F12 File Offset: 0x00711112
	public void SetOverrideMaxFallingSpeed(float v)
	{
		this.OverrideMaxFallingSpeed = v;
	}

	// Token: 0x0601A7B4 RID: 108468 RVA: 0x00712F1B File Offset: 0x0071111B
	public void ResetOverrideMaxFallingSpeed()
	{
		this.OverrideMaxFallingSpeed = 0f;
	}

	// Token: 0x0601A7B5 RID: 108469 RVA: 0x00712F28 File Offset: 0x00711128
	public override void SetMaxSpeed(float newSpeed)
	{
		if (this.OverrideMaxSpeed > 0f)
		{
			newSpeed = this.OverrideMaxSpeed;
		}
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		float? num = (attributeComponent != null) ? new float?(attributeComponent.GetCurrentValue(EAttributeType.SpeedRatio)) : null;
		if (num == null || num.Value <= 0f)
		{
			num = new float?((float)10000);
		}
		num = new float?(num.Value / 10000f);
		EMovementMode emovementMode = this.CharacterMovement.MovementMode;
		if (emovementMode == EMovementMode.MOVE_Flying)
		{
			this.CharacterMovement.MaxFlySpeed = newSpeed * num.Value;
		}
		else if (emovementMode == EMovementMode.MOVE_Falling)
		{
			this.CharacterMovement.MaxWalkSpeed = ((this.OverrideMaxFallingSpeed > 0f) ? this.OverrideMaxFallingSpeed : newSpeed) * num.Value;
		}
		else
		{
			this.CharacterMovement.MaxWalkSpeed = newSpeed * num.Value;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			bool isRoleAndCtrlByMe = actorComp.IsRoleAndCtrlByMe;
		}
	}

	// Token: 0x0601A7B6 RID: 108470 RVA: 0x00713028 File Offset: 0x00711228
	protected void OnLand()
	{
		this.GroundedTimeUe = UGameplayStatics.GetGamePlayTimeSeconds(this.ActorComp.Actor);
		this.GroundedFrame = Time.Instance.Frame;
		if (AActor.GetKuroNetMode() == EKuroNetMode.KNM_Net && this.ActorComp.IsAutonomousProxy)
		{
			EventSystem.Instance.Emit<Entity>(EEventName.EntityOnLandedPush, base.Entity);
		}
	}

	// Token: 0x0601A7B7 RID: 108471 RVA: 0x00713090 File Offset: 0x00711290
	protected void OnPositionStateChanged(global::ECharPositionState oldPositionState, global::ECharPositionState newPositionState)
	{
		if (oldPositionState == global::ECharPositionState.Air)
		{
			this.IsFallingIntoWater = false;
			base.StopAddMove(this.AirInertiaHandler);
			this.AirInertiaHandler = 0;
			if (this.ActorComp.IsRoleAndCtrlByMe && newPositionState == global::ECharPositionState.Ground)
			{
				this.PlayerMotionRequest(MotionType.BeLand);
			}
		}
		switch (newPositionState)
		{
		case global::ECharPositionState.Ground:
			if (base.Entity.Active && this.ActorComp.IsAutonomousProxy)
			{
				CharacterDamageComponent component = base.Entity.GetComponent<CharacterDamageComponent>();
				if (component == null)
				{
					return;
				}
				component.FallInjure();
				return;
			}
			break;
		case global::ECharPositionState.Climb:
			break;
		case global::ECharPositionState.Air:
			if (this.HasBaseMovement && !this.ActorComp.Actor.BasedMovement.bRelativeRotation && this.DeltaBaseMovementSpeed != null)
			{
				this.AirInertiaHandler = base.SetAddMoveWorld(this.DeltaBaseMovementSpeed, 1.5f, BaseMoveComponent.BaseMoveInheritCurve, new int?(this.AirInertiaHandler), null, global::EVelocityCurveType.None, 0f, 1f);
			}
			if (this.DeltaConveyBeltSpeed != null)
			{
				this.AirInertiaHandler = base.SetAddMoveWorld(this.DeltaConveyBeltSpeed, 1.5f, BaseMoveComponent.BaseMoveInheritCurve, new int?(this.AirInertiaHandler), null, global::EVelocityCurveType.None, 0f, 1f);
			}
			break;
		case global::ECharPositionState.Water:
		{
			this.VelocityVector.FromUeVector(this.ActorComp.ActorVelocityProxy);
			double num = this.VelocityVector.Size();
			if (num > 800.0)
			{
				this.VelocityVector.MultiplyEqual(800.0 / num);
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp == null)
				{
					return;
				}
				actorComp.SetActorVelocity(this.VelocityVector);
				return;
			}
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x0601A7B8 RID: 108472 RVA: 0x00713230 File Offset: 0x00711430
	[NullableContext(2)]
	protected void OnStateInherit(Entity other, bool notInheritMoveAndAnim)
	{
		if (other == null || !other.Valid)
		{
			return;
		}
		CharacterMoveComponent component = other.GetComponent<CharacterMoveComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		CharacterInputComponent component2 = other.GetComponent<CharacterInputComponent>();
		CharacterInputComponent component3 = base.Entity.GetComponent<CharacterInputComponent>();
		if (component2 != null && component3 != null)
		{
			InputContinuously autoMovingConfig = component2.GetAutoMovingConfig();
			if (autoMovingConfig.GetAutoMovingState())
			{
				component3.SetAutoMovingConfig(autoMovingConfig);
				autoMovingConfig.ResetAutoMovingState("切人");
			}
			component3.IsLocalInput = component2.IsLocalInput;
		}
		BaseGravityComponent component4 = base.Entity.GetComponent<BaseGravityComponent>();
		if (component4 != null)
		{
			component4.SetGravityByPriority(0, component.GravityDirect, true, -1f, true);
		}
		this.CharacterMovement.ConsumeInputVector();
		this.CharacterMovement.AddInputVector(component.CharacterMovement.GetLastInputVector(), true);
		this.ActorComp.SetInputDirect(component.ActorComp.InputDirectProxy, false);
		this.ActorComp.SetInputFacing(component.ActorComp.InputFacingProxy, false);
		this.ActorComp.SetOverrideTurnSpeed(component.ActorComp.OverrideTurnSpeed);
		this.HasMoveInput = component.HasMoveInput;
		this.CharacterMovement.LastUpdateVelocity = component.GetLastUpdateVelocity();
		this.ActorComp.ResetCachedVelocityTime();
		CharacterActorComponent actorComp = component.ActorComp;
		if (actorComp != null)
		{
			actorComp.ClearInput(false, false);
		}
		if (component2 != null)
		{
			component2.ResetMoveVectorCache();
		}
		if (notInheritMoveAndAnim)
		{
			return;
		}
		this.MoveInherit(component);
		this.TagInherit(other, component);
	}

	// Token: 0x0601A7B9 RID: 108473 RVA: 0x0071339C File Offset: 0x0071159C
	protected unsafe void OnTeleportStart(bool b)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.CreatureData.IsRole())
		{
			return;
		}
		if (base.IsMovingToLocation())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "因传送打断当前移动,设置移动结果失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "PbDataId";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp2 != null) ? new int?(actorComp2.CreatureData.GetPbDataId()) : null);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.StopMoveWithCallback(ELevelEventState.Failure, "CharacterMoveComponent.OnTeleportStart");
		}
	}

	// Token: 0x0601A7BA RID: 108474 RVA: 0x00713468 File Offset: 0x00711668
	private void MoveInherit(CharacterMoveComponent otherMoveComp)
	{
		this.IsMoving = otherMoveComp.IsMoving;
		this.LastJumpTime = otherMoveComp.LastJumpTime;
		CharacterMoveComponent.TempVelocity.DeepCopy(otherMoveComp.ActorComp.ActorVelocityProxy);
		double num = CharacterMoveComponent.TempVelocity.SizeSquared();
		if (num > 1000000.0)
		{
			CharacterMoveComponent.TempVelocity.MultiplyEqual((double)((float)Math.Sqrt(1000000.0 / num)));
		}
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.切人不继承速度"]))
		{
			this.ForceSpeed.DeepCopy(CharacterMoveComponent.TempVelocity);
			this.Speed = (float)Math.Sqrt(GravityUtils.Instance.GetPlanarSizeSquared2dForActor(this.ActorComp, this.ForceSpeed));
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetActorVelocity(this.ForceSpeed);
			}
			this.CharacterMovement.LastUpdateVelocity = otherMoveComp.CharacterMovement.LastUpdateVelocity;
		}
		UeMovementTickManageComponent component2 = otherMoveComp.Entity.GetComponent<UeMovementTickManageComponent>();
		if (component2 != null)
		{
			component2.DumpVelocityCacheInfo("战斗换人", false);
		}
		if (otherMoveComp.ActorComp.Actor.BasedMovement.MovementBase == null)
		{
			this.ActorComp.Actor.BasedMovement.MovementBase = null;
		}
		FFindFloorResult currentFloor = this.ActorComp.Actor.CharacterMovement.CurrentFloor;
		FFindFloorResult currentFloor2 = otherMoveComp.ActorComp.Actor.CharacterMovement.CurrentFloor;
		currentFloor.bBlockingHit = currentFloor2.bBlockingHit;
		currentFloor.bLineTrace = currentFloor2.bLineTrace;
		currentFloor.bWalkableFloor = currentFloor2.bWalkableFloor;
		currentFloor.FloorDist = currentFloor2.FloorDist;
		currentFloor.HitResult = currentFloor2.HitResult;
		currentFloor.LineDist = currentFloor2.LineDist;
		UKuroStaticLibrary.SetBaseAndSaveBaseLocation(this.CharacterMovement, otherMoveComp.CharacterMovement.GetMovementBase());
	}

	// Token: 0x0601A7BB RID: 108475 RVA: 0x00713634 File Offset: 0x00711834
	private void TagInherit(Entity other, CharacterMoveComponent otherMoveComp)
	{
		BaseTagComponent component = other.GetComponent<BaseTagComponent>();
		CharacterUnifiedStateComponent component2 = other.GetComponent<CharacterUnifiedStateComponent>();
		if (otherMoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_None || (component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"])))
		{
			this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Walking,
				CustomMode = 0,
				Context = "[CharacterMoveComponent.OnStateInherit] MOVE_None"
			});
			return;
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.不继承移动模式"]))
		{
			if (otherMoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Flying)
			{
				BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
				if ((unifiedStateComponent == null || unifiedStateComponent.MoveState != global::ECharMoveState.Roll) && (component2 == null || component2.PositionState != global::ECharPositionState.Floating) && (component2 == null || component2.PositionState != global::ECharPositionState.Ride))
				{
					CharacterWalkOnWaterComponent walkOnWaterComp = this.WalkOnWaterComp;
					if (walkOnWaterComp == null || !walkOnWaterComp.BlockMoveModeInherit(otherMoveComp.CharacterMovement))
					{
						this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
						{
							Mode = otherMoveComp.CharacterMovement.MovementMode,
							CustomMode = otherMoveComp.CharacterMovement.CustomMovementMode,
							Context = "[CharacterMoveComponent.OnStateInherit]"
						});
					}
				}
			}
			return;
		}
		if (otherMoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Walking)
		{
			this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = otherMoveComp.CharacterMovement.MovementMode,
				CustomMode = otherMoveComp.CharacterMovement.CustomMovementMode,
				Context = "[CharacterMoveComponent.OnStateInherit.]"
			});
			return;
		}
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Falling,
			CustomMode = 0,
			Context = "[CharacterMoveComponent.OnStateInherit]"
		});
	}

	// Token: 0x0601A7BC RID: 108476 RVA: 0x0071382C File Offset: 0x00711A2C
	protected void OnSprintTag(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			if (tagId == GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.前闪"])
			{
				this.PlayerMotionRequest(MotionType.Spurt);
				return;
			}
			if (tagId == GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.后闪"])
			{
				this.PlayerMotionRequest(MotionType.Pullback);
				return;
			}
			if (tagId == GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中前闪"])
			{
				this.PlayerMotionRequest(MotionType.AirSprint);
				return;
			}
			if (tagId == GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中后闪"])
			{
				this.PlayerMotionRequest(MotionType.BackFlip);
			}
		}
	}

	// Token: 0x0601A7BD RID: 108477 RVA: 0x007138A3 File Offset: 0x00711AA3
	protected void OnEnableWalkOnAirTag(int tagId, bool tagExist)
	{
		this.CharacterMovement.bKuroWalkOnAir = tagExist;
	}

	// Token: 0x0601A7BE RID: 108478 RVA: 0x007138B4 File Offset: 0x00711AB4
	[NullableContext(2)]
	protected void OnVisionMorphBegin(EntityHandle visionEntity, EntityHandle roleEntity)
	{
		if ((roleEntity == null || !roleEntity.Valid || roleEntity.Id != base.Entity.Id) && (visionEntity == null || !visionEntity.Valid || visionEntity.Id != base.Entity.Id))
		{
			return;
		}
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x0601A7BF RID: 108479 RVA: 0x00713910 File Offset: 0x00711B10
	[NullableContext(2)]
	protected void OnVisionMorphEnd(EntityHandle roleEntity, EntityHandle visionEntity)
	{
		if ((roleEntity == null || !roleEntity.Valid || roleEntity.Id != base.Entity.Id) && (visionEntity == null || !visionEntity.Valid || visionEntity.Id != base.Entity.Id))
		{
			return;
		}
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x0601A7C0 RID: 108480 RVA: 0x0071396C File Offset: 0x00711B6C
	[NullableContext(2)]
	protected void OnTeleportComplete(TeleportContext teleportContext)
	{
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x0601A7C1 RID: 108481 RVA: 0x00713974 File Offset: 0x00711B74
	protected void OnWorldDone()
	{
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x0601A7C2 RID: 108482 RVA: 0x0071397C File Offset: 0x00711B7C
	protected void OnRoleGoUp()
	{
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x0601A7C3 RID: 108483 RVA: 0x00713984 File Offset: 0x00711B84
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		base.OnInitData(args);
		this.ForceFallingSpeedCache = new ForceFallingSpeedCache();
		return true;
	}

	// Token: 0x0601A7C4 RID: 108484 RVA: 0x0071399C File Offset: 0x00711B9C
	protected override bool OnClear()
	{
		base.OnClear();
		if (this.JumpDelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.JumpDelayTimer);
		}
		CharacterMoveComponent.TempVelocity.Reset();
		MoveToLocationController moveController = base.MoveController;
		if (moveController != null)
		{
			moveController.Dispose();
		}
		this.UnInitMovementData();
		return true;
	}

	// Token: 0x0601A7C5 RID: 108485 RVA: 0x007139EC File Offset: 0x00711BEC
	protected override bool OnStart()
	{
		this.AccelerationLerpCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/Character/Role/Common/Data/Curves/CT_MoveFAcceleration.CT_MoveFAcceleration");
		UCurveFloat accelerationLerpCurve = this.AccelerationLerpCurve;
		if (accelerationLerpCurve == null || !accelerationLerpCurve.IsValid())
		{
			PreloadModelNew.Instance.CommonAssetElement.PrintDebugInfo();
		}
		base.AccelerationLerpTime = 0f;
		this.AccelerationChangeMoveState = new global::ECharMoveState?(global::ECharMoveState.Other);
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		this.IsHidden = false;
		this.ActorComp = component;
		this.CharacterMovement = component.Actor.CharacterMovement;
		global::Vector gravityDirectInternal = this.GravityDirectInternal;
		FVector fvector = this.CharacterMovement.Kuro_GetGravityDirect();
		gravityDirectInternal.FromUeVector(fvector);
		this.IsStandardGravityInternal = (Math.Abs(this.GravityDirectInternal.Z + 1.0) < 1E-08);
		if (this.IsStandardGravityInternal)
		{
			this.GravityDirectInternal.Set(0.0, 0.0, -1.0);
		}
		this.GravityDirectInternal.UnaryNegation(this.GravityUpInternal);
		this.CharacterMovement.GravityScale = 2f;
		this.CharacterMovement.bRotationFollowBaseMovement = true;
		this.CharacterMovement.SetWalkableFloorAngle(55f);
		this.CharacterMovement.bEnablePhysicsInteraction = false;
		this.SetKuroPlanarPhysWalking(this.IsEnablePlanarPhysWalking());
		this.SetKuroAsyncRootMotion(this.IsEnableAsyncRootMotion());
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.GlideComp = base.Entity.GetComponent<CharacterGlideComponent>();
		this.SwimComp = base.Entity.GetComponent<CharacterSwimComponent>();
		this.WalkOnWaterComp = base.Entity.GetComponent<CharacterWalkOnWaterComponent>();
		this.FloatingComp = base.Entity.GetComponent<CharacterFloatingComponent>();
		this.AttributeComponent = base.Entity.GetComponent<BaseAttributeComponent>();
		this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
		this.DeathComponent = base.Entity.GetComponent<BaseDeathComponent>();
		this.UnifiedStateComponent = base.Entity.GetComponent<BaseUnifiedStateComponent>();
		this.SkillComp = base.Entity.GetComponent<CharacterSkillComponent>();
		this.CapsuleOffset = global::Vector.Create(0.0, 0.0, (double)(this.ActorComp.Radius - this.ActorComp.HalfHeight));
		this.InitCreatureProperty();
		this.InitStepUpParams();
		this.InitMovementData();
		if (this.ActorComp.Actor.DtBaseMovementSetting == null || this.MovementData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "以下BP_{Character}没有在蓝图中配置Dt_BaseMovementSetting找对应的蓝图负责人处理";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Character", this.ActorComp.Actor.GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(base.OnMoveStateChange));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(base.OnPositionStateChange));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(base.OnDirectionStateChange));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnLand, new Action(this.OnLand));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		if (this.IsKuroPlanarPhysWalkingEnableInternal)
		{
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.VisionMorphBegin, new Action<EntityHandle, EntityHandle>(this.OnVisionMorphBegin));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.VisionMorphEnd, new Action<EntityHandle, EntityHandle>(this.OnVisionMorphEnd));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnRoleGoUp, new Action(this.OnRoleGoUp));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}
		this.IsStopInternal = false;
		base.InitBaseState();
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.AddListener(EAttributeType.SpeedRatio, new Action<EAttributeType, float, float>(this.OnSpeedRatioAttributeChanged), null);
		}
		this.CannotResponseInputCount = 0;
		for (int i = 0; i < CharacterMoveComponent.cannotResponseInputTag.Length; i++)
		{
			int num = CharacterMoveComponent.cannotResponseInputTag[i];
			if (this.TagComponent != null)
			{
				if (this.TagComponent.HasTag(num))
				{
					this.CannotResponseInputCount++;
				}
				this.CanResponseInputTasks.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(num), new BaseTagComponent.TTagSwitchedCallback(this.OnResponseInputTagsChanged), null));
			}
		}
		base.InitTraceInfo();
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.前闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag), null);
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.后闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag), null);
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中前闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag), null);
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中后闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag), null);
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["功能.功能制作.开启空中步行状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnableWalkOnAirTag), null);
		this.InitInputMoveLimit();
		return base.OnStart();
	}

	// Token: 0x0601A7C6 RID: 108486 RVA: 0x00713FA8 File Offset: 0x007121A8
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(base.OnMoveStateChange));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(base.OnPositionStateChange));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(base.OnDirectionStateChange));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnLand, new Action(this.OnLand));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.OnPositionStateChanged));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		if (this.IsKuroPlanarPhysWalkingEnableInternal)
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.VisionMorphBegin, new Action<EntityHandle, EntityHandle>(this.OnVisionMorphBegin));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.VisionMorphEnd, new Action<EntityHandle, EntityHandle>(this.OnVisionMorphEnd));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnRoleGoUp, new Action(this.OnRoleGoUp));
			EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}
		EventSystem.Instance.Remove(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		if (EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.InitHandlePbMoveToPoint)))
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.InitHandlePbMoveToPoint));
		}
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent != null)
		{
			attributeComponent.RemoveListener(EAttributeType.SpeedRatio, new Action<EAttributeType, float, float>(this.OnSpeedRatioAttributeChanged));
		}
		for (int i = 0; i < this.CanResponseInputTasks.Count; i++)
		{
			this.CanResponseInputTasks[i].EndTask();
		}
		this.CanResponseInputTasks.Clear();
		this.IsHidden = false;
		this.TagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.前闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag));
		this.TagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.后闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag));
		this.TagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中前闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag));
		this.TagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中后闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag));
		this.IsKuroPlanarPhysWalkingEnableInternal = false;
		return true;
	}

	// Token: 0x0601A7C7 RID: 108487 RVA: 0x00714278 File Offset: 0x00712478
	protected override void OnActivate()
	{
		base.OnMoveStateChange(global::ECharMoveState.Stand, global::ECharMoveState.Run);
		if (this.CharacterMovement.MovementMode == EMovementMode.MOVE_NavWalking)
		{
			this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Walking,
				Context = "[CharacterMoveComponent.OnActivate]"
			});
		}
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		bool flag;
		if (component == null)
		{
			flag = (null != null);
		}
		else
		{
			CharacterMoveToPointConfig pbMoveToPointConfig = component.PbMoveToPointConfig;
			flag = (((pbMoveToPointConfig != null) ? pbMoveToPointConfig.TargetPos : null) != null);
		}
		if (flag)
		{
			if (GameModeModel.Instance.WorldDoneAndLoadingClosed)
			{
				this.InitHandlePbMoveToPoint();
				return;
			}
			if (!EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.InitHandlePbMoveToPoint)))
			{
				EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.InitHandlePbMoveToPoint));
			}
		}
	}

	// Token: 0x0601A7C8 RID: 108488 RVA: 0x00714340 File Offset: 0x00712540
	private void InitHandlePbMoveToPoint()
	{
		if (EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.InitHandlePbMoveToPoint)))
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.InitHandlePbMoveToPoint));
		}
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		bool flag;
		if (component == null)
		{
			flag = (null != null);
		}
		else
		{
			CharacterMoveToPointConfig pbMoveToPointConfig = component.PbMoveToPointConfig;
			flag = (((pbMoveToPointConfig != null) ? pbMoveToPointConfig.TargetPos : null) != null);
		}
		if (flag)
		{
			LevelGeneralNetworks.HandleRecvCharacterMoveToPoint(base.Entity, component.PbMoveToPointConfig);
		}
	}

	// Token: 0x0601A7C9 RID: 108489 RVA: 0x007143BD File Offset: 0x007125BD
	protected override void OnDisable(string reason)
	{
		this.DeltaTimeSeconds = 0f;
		if (this.GetWhirlpoolEnable())
		{
			this.EndWhirlpool("实体Disable");
		}
	}

	// Token: 0x0601A7CA RID: 108490 RVA: 0x007143E0 File Offset: 0x007125E0
	protected unsafe override void OnTick(float delta)
	{
		if ((double)delta < 1E-08)
		{
			return;
		}
		base.OnTick(delta);
		if (this.ActorComp == null || this.DeathComponent == null || (!this.WhirlpoolPoint.GetEnable() && this.DeathComponent.IsDead()))
		{
			return;
		}
		this.DeltaTimeSeconds = delta * 0.001f;
		MoveToLocationController moveController = base.MoveController;
		if (moveController != null)
		{
			moveController.UpdateMove(this.DeltaTimeSeconds);
		}
		if (this.SpeedLockFrame > 0)
		{
			this.SpeedLockFrame--;
		}
		if (base.IsJump)
		{
			this.LastJumpTime = Time.Instance.PlayerWorldTime;
			this.JumpFrameCount--;
		}
		base.LerpMaxAcceleration();
		base.UpdateBaseMovement();
		if (this.IsSpecialMove)
		{
			return;
		}
		if (this.IsStopInternal)
		{
			this.Speed = 0f;
		}
		else
		{
			this.Speed = (float)Math.Sqrt(GravityUtils.Instance.GetPlanarSizeSquared2dForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy));
		}
		this.IsMoving = (this.Speed > 20f);
		if (this.ActorComp.IsMoveAutonomousProxy)
		{
			this.UpdateInputOrder();
			BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (unifiedStateComponent != null && unifiedStateComponent.Valid && this.UnifiedStateComponent.PositionState == global::ECharPositionState.Air && this.UnifiedStateComponent.MoveState == global::ECharMoveState.Other && !this.AnimComp.HasKuroRootMotion)
			{
				float num = Math.Max(this.FallingHorizontalMaxSpeed, this.OverrideMaxFallingSpeed);
				if (this.Speed > num * 1.01f)
				{
					CharacterMoveComponent.TempVelocity.DeepCopy(this.ActorComp.ActorVelocityProxy);
					double addZ = GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, CharacterMoveComponent.TempVelocity);
					CharacterMoveComponent.TempVelocity.MultiplyEqual((double)(num / this.Speed));
					if (CharacterMoveComponent.TempVelocity.ContainsNaN())
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Movement;
						ELogAuthor author = ELogAuthor.LCZ;
						string message = "Air Speed Limit has NaN";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("velocity", CharacterMoveComponent.TempVelocity);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("speed", this.Speed);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("max", num);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, CharacterMoveComponent.TempVelocity, addZ);
					this.ActorComp.SetActorVelocity(CharacterMoveComponent.TempVelocity);
					this.Speed = this.FallingHorizontalMaxSpeed;
				}
			}
			bool? flag = null;
			if (base.Entity.GetTickInterval() > 1)
			{
				CharacterAnimationComponent animComp = this.AnimComp;
				if (animComp != null && animComp.Valid && this.ActorComp.Owner.WasRecentlyRenderedOnScreen(0.2f))
				{
					flag = new bool?(true);
				}
			}
			FTransformDouble? ftransformDouble = null;
			if (flag.GetValueOrDefault())
			{
				ftransformDouble = new FTransformDouble?(this.AnimComp.GetMeshTransform());
			}
			bool flag2 = false;
			if (base.CanResponseInput())
			{
				base.SetInfoVar();
				float pitch = this.ActorComp.ActorRotationProxy.Pitch;
				this.UpdateFacing();
				flag2 = (flag2 || pitch != this.ActorComp.ActorRotationProxy.Pitch);
				base.CacheVar();
			}
			else
			{
				this.HasMoveInput = false;
			}
			if (this.WhirlpoolPoint.GetEnable())
			{
				flag2 = this.UpdateInAreaWhirlpool();
				WhirlpoolPoint whirlpoolPoint = this.WhirlpoolPoint;
				float deltaTimeSeconds = this.DeltaTimeSeconds;
				PawnTimeScaleComponent timeScaleComp = this.TimeScaleComp;
				if (!whirlpoolPoint.OnTick(deltaTimeSeconds * ((timeScaleComp != null) ? timeScaleComp.CurrentTimeScale : 1f)))
				{
					this.EndWhirlpool("时间到了");
				}
			}
			if (flag.GetValueOrDefault() && flag2)
			{
				this.AnimComp.SetModelBuffer(ftransformDouble.Value, delta * CharacterModel.Instance.InverseSelfCenteredTimeDilation);
			}
			base.OnTickGravityScale();
			if (this.HasBaseMovement)
			{
				this.DeltaBaseMovementQuat.RotateVector(this.ActorComp.InputFacingProxy, this.TmpVector);
				this.ActorComp.SetInputFacing(this.TmpVector, true);
			}
			if (SundryModel.Instance.SceneCheckOn)
			{
				base.PrintAnimInstanceMovementInfo();
			}
			this.UpdateMoveChain();
			if (this.TryGlideTime != 0.0)
			{
				if (this.TrySetGlide())
				{
					this.TryGlideTime = 0.0;
				}
				this.TryGlideTime = (double)((int)Math.Max(this.TryGlideTime - (double)delta, 0.0));
			}
			return;
		}
		if (base.CanResponseInput())
		{
			base.SetInfoVar();
			this.UpdateFacing();
			base.CacheVar();
			return;
		}
		this.HasMoveInput = false;
	}

	// Token: 0x0601A7CB RID: 108491 RVA: 0x00714867 File Offset: 0x00712A67
	protected bool ContainsTag(int tag)
	{
		BaseTagComponent tagComponent = this.TagComponent;
		return tagComponent != null && tagComponent.HasTag(tag);
	}

	// Token: 0x0601A7CC RID: 108492 RVA: 0x0071487C File Offset: 0x00712A7C
	public void JumpRelease()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent == null || unifiedStateComponent.PositionState != global::ECharPositionState.Floating)
		{
			this.ActorComp.Actor.StopJumping();
			return;
		}
		Entity entity = base.Entity;
		if (entity == null)
		{
			return;
		}
		CharacterFloatingComponent component = entity.GetComponent<CharacterFloatingComponent>();
		if (component == null)
		{
			return;
		}
		component.JumpRelease();
	}

	// Token: 0x0601A7CD RID: 108493 RVA: 0x007148CC File Offset: 0x00712ACC
	protected bool JumpCheck()
	{
		if (!base.CanResponseInput() || this.ContainsTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止跳跃"]))
		{
			return false;
		}
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent == null || unifiedStateComponent.PositionState != global::ECharPositionState.Ground)
		{
			BaseUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
			return unifiedStateComponent2 != null && unifiedStateComponent2.PositionState == global::ECharPositionState.Ski;
		}
		return true;
	}

	// Token: 0x0601A7CE RID: 108494 RVA: 0x00714928 File Offset: 0x00712B28
	public override bool CanJumpPress()
	{
		if (this.GroundedFrame > Time.Instance.Frame - 2)
		{
			return false;
		}
		CharacterSkillComponent component = base.Entity.GetComponent<CharacterSkillComponent>();
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		global::ECharPositionState? echarPositionState = (unifiedStateComponent != null) ? new global::ECharPositionState?(unifiedStateComponent.PositionState) : null;
		BaseUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
		global::ECharMoveState? echarMoveState = (unifiedStateComponent2 != null) ? new global::ECharMoveState?(unifiedStateComponent2.MoveState) : null;
		if (echarPositionState != null)
		{
			switch (echarPositionState.GetValueOrDefault())
			{
			case global::ECharPositionState.Ground:
			case global::ECharPositionState.Climb:
			case global::ECharPositionState.Ski:
				return (component == null || !component.Valid || component.CheckJumpCanInterrupt()) && this.JumpCheck();
			case global::ECharPositionState.Air:
				if (echarMoveState.GetValueOrDefault() == global::ECharMoveState.Glide)
				{
					return Time.Instance.WorldTime - this.LastGlidingControlTime > 0.30000001192092896;
				}
				echarMoveState.GetValueOrDefault();
				return true;
			case global::ECharPositionState.RailSlide:
			case global::ECharPositionState.Floating:
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601A7CF RID: 108495 RVA: 0x00714A2D File Offset: 0x00712C2D
	public override bool CanWalkPress()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		return unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Ground;
	}

	// Token: 0x0601A7D0 RID: 108496 RVA: 0x00714A44 File Offset: 0x00712C44
	protected void LimitMaxSpeed()
	{
		this.VelocityVector.FromUeVector(this.ActorComp.ActorVelocityProxy);
		double num = this.VelocityVector.Size();
		SMovementSetting currentMovementSettings = base.CurrentMovementSettings;
		float? num2 = (currentMovementSettings != null) ? new float?(currentMovementSettings.SprintSpeed) : null;
		double num3 = num;
		float? num4 = num2;
		double? num5 = (num4 != null) ? new double?((double)num4.GetValueOrDefault()) : null;
		if (num3 > num5.GetValueOrDefault() & num5 != null)
		{
			this.VelocityVector.MultiplyEqual((double)num2.Value / num);
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.SetActorVelocity(this.VelocityVector);
		}
	}

	// Token: 0x0601A7D1 RID: 108497 RVA: 0x00714AF8 File Offset: 0x00712CF8
	protected void OnJump()
	{
		CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
		if (component != null && component.Valid && component.MainAnimInstance != null)
		{
			component.MainAnimInstance.Montage_Stop(0f, null);
		}
		this.JumpFrameCount = 3;
		this.AnimComp.OnJump();
		EventSystem.Instance.Emit<int>(EEventName.OnCharJump, base.Entity.Id);
	}

	// Token: 0x0601A7D2 RID: 108498 RVA: 0x00714B60 File Offset: 0x00712D60
	public void OnDropPress()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Floating)
		{
			CharacterFloatingComponent component = base.Entity.GetComponent<CharacterFloatingComponent>();
			if (component == null)
			{
				return;
			}
			component.CtrlPress();
		}
	}

	// Token: 0x0601A7D3 RID: 108499 RVA: 0x00714B8E File Offset: 0x00712D8E
	public void OnDropRelease()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Floating)
		{
			CharacterFloatingComponent component = base.Entity.GetComponent<CharacterFloatingComponent>();
			if (component == null)
			{
				return;
			}
			component.CtrlRelease();
		}
	}

	// Token: 0x0601A7D4 RID: 108500 RVA: 0x00714BBC File Offset: 0x00712DBC
	public void JumpPress()
	{
		if (this.CheckInHit())
		{
			return;
		}
		if (!this.CanJumpPress())
		{
			return;
		}
		CharacterFloatingComponent floatingComp = this.FloatingComp;
		if (floatingComp != null && floatingComp.IsFloating)
		{
			CharacterFloatingComponent component = base.Entity.GetComponent<CharacterFloatingComponent>();
			if (component != null)
			{
				component.JumpPressInAir();
			}
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]));
			}
			CharacterSkillComponent component2 = base.Entity.GetComponent<CharacterSkillComponent>();
			if (component2 != null && component2.Valid && component2.CurrentSkill != null)
			{
				component2.StopGroup1Skill("悬浮跳跃打断技能");
			}
			this.OnJump();
			this.PlayerMotionRequest(MotionType.MotionJump);
			return;
		}
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		global::ECharPositionState? echarPositionState = (unifiedStateComponent != null) ? new global::ECharPositionState?(unifiedStateComponent.PositionState) : null;
		global::ECharPositionState? echarPositionState2 = echarPositionState;
		global::ECharPositionState echarPositionState3 = global::ECharPositionState.Ground;
		bool flag = echarPositionState2.GetValueOrDefault() == echarPositionState3 & echarPositionState2 != null;
		bool flag2 = echarPositionState.GetValueOrDefault() == global::ECharPositionState.Climb;
		if (flag || flag2)
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null)
			{
				tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]));
			}
			CharacterSkillComponent component3 = base.Entity.GetComponent<CharacterSkillComponent>();
			if (component3 != null && component3.Valid && component3.CurrentSkill != null)
			{
				component3.StopGroup1Skill("跳跃打断技能");
				this.LimitMaxSpeed();
			}
			this.OnJump();
			if (flag)
			{
				this.PlayerMotionRequest(MotionType.MotionJump);
			}
			return;
		}
		if (echarPositionState.GetValueOrDefault() == global::ECharPositionState.Air)
		{
			if (this.JumpPressInAir())
			{
				return;
			}
		}
		else if (echarPositionState.GetValueOrDefault() == global::ECharPositionState.Ski)
		{
			if (this.JumpPressInSki())
			{
				return;
			}
		}
		else if (echarPositionState.GetValueOrDefault() == global::ECharPositionState.RailSlide && this.JumpPressInRailSlide())
		{
			return;
		}
		if (this.TrySetGlide())
		{
			return;
		}
		this.TryGlideTime = 500.0;
	}

	// Token: 0x0601A7D5 RID: 108501 RVA: 0x00714D6C File Offset: 0x00712F6C
	protected bool CheckInHit()
	{
		return this.TagComponent != null && (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击"]) || this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]));
	}

	// Token: 0x0601A7D6 RID: 108502 RVA: 0x00714DBC File Offset: 0x00712FBC
	protected bool JumpPressInAir()
	{
		if (this.CheckInHit())
		{
			return false;
		}
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		global::ECharMoveState? echarMoveState = (unifiedStateComponent != null) ? new global::ECharMoveState?(unifiedStateComponent.MoveState) : null;
		if (echarMoveState.GetValueOrDefault() == global::ECharMoveState.Glide)
		{
			CharacterGlideComponent glideComp = this.GlideComp;
			if (glideComp != null && glideComp.Valid)
			{
				this.GlideComp.ExitGlideState("MoveComp");
				this.LastGlidingControlTime = Time.Instance.WorldTime;
			}
			return true;
		}
		if (echarMoveState.GetValueOrDefault() == global::ECharMoveState.Slide)
		{
			global::Vector tempVelocity = CharacterMoveComponent.TempVelocity;
			FVector fvector = this.CharacterMovement.Kuro_GetBlockDirectWhenMove();
			tempVelocity.FromUeVector(fvector);
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null && animComp.Valid)
			{
				if (this.SlideTrans == null)
				{
					this.SlideTrans = global::Transform.Create();
				}
				MathUtils.Instance.LookRotationUpFirst(CharacterMoveComponent.TempVelocity, base.GravityUp, this.TmpQuat);
				this.SlideTrans.Set(this.ActorComp.ActorLocationProxy, this.TmpQuat, this.ActorComp.ActorScaleProxy);
				this.AnimComp.SetTransformWithModelBuffer(this.SlideTrans.ToUeTransform(), 100f, null, true);
			}
			GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, CharacterMoveComponent.TempVelocity);
			if (!CharacterMoveComponent.TempVelocity.Normalize(9.99999993922529E-09))
			{
				CharacterMoveComponent.TempVelocity.DeepCopy(this.ActorComp.ActorForwardProxy);
			}
			CharacterMoveComponent.TempVelocity.MultiplyEqual(900.0 / CharacterMoveComponent.TempVelocity.Size());
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetActorVelocity(CharacterMoveComponent.TempVelocity);
			}
			this.OnJump();
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Falling,
					Context = "[CharacterMoveComponent.JumpPressInAir]"
				});
			}
			this.PlayerMotionRequest(MotionType.MotionJump);
			return true;
		}
		return false;
	}

	// Token: 0x0601A7D7 RID: 108503 RVA: 0x00714F9C File Offset: 0x0071319C
	protected bool JumpPressInSki()
	{
		if (this.CheckInHit())
		{
			return false;
		}
		CharacterSlideComponent component = base.Entity.GetComponent<CharacterSlideComponent>();
		if (!component)
		{
			return false;
		}
		UCharacterMovementComponent characterMovement = this.CharacterMovement;
		if (!(((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null) != EMovementMode.MOVE_Custom))
		{
			UCharacterMovementComponent characterMovement2 = this.CharacterMovement;
			byte? b = (characterMovement2 != null) ? new byte?(characterMovement2.CustomMovementMode) : null;
			if (((b != null) ? new int?((int)b.GetValueOrDefault()) : null).GetValueOrDefault() == 8)
			{
				CharacterMoveComponent.TempVelocity.FromUeVector(this.ActorComp.ActorForwardProxy);
				CharacterAnimationComponent animComp = this.AnimComp;
				if (animComp != null && animComp.Valid)
				{
					if (this.SlideTrans == null)
					{
						this.SlideTrans = global::Transform.Create();
					}
					MathUtils.Instance.LookRotationUpFirst(CharacterMoveComponent.TempVelocity, component.SlideForward, this.TmpQuat);
					this.SlideTrans.Set(this.ActorComp.ActorLocationProxy, this.TmpQuat, this.ActorComp.ActorScaleProxy);
					this.AnimComp.SetTransformWithModelBuffer(this.SlideTrans.ToUeTransform(), 100f, null, true);
				}
				GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, CharacterMoveComponent.TempVelocity);
				if (!CharacterMoveComponent.TempVelocity.Normalize(9.99999993922529E-09))
				{
					CharacterMoveComponent.TempVelocity.DeepCopy(this.ActorComp.ActorForwardProxy);
				}
				CharacterMoveComponent.TempVelocity.MultiplyEqual((double)((float)Math.Sqrt(GravityUtils.Instance.GetPlanarSizeSquared2dForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy))));
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					actorComp.SetActorVelocity(CharacterMoveComponent.TempVelocity);
				}
				this.OnJump();
				component.OnJump();
				this.PlayerMotionRequest(MotionType.MotionJump);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601A7D8 RID: 108504 RVA: 0x00715198 File Offset: 0x00713398
	protected bool JumpPressInRailSlide()
	{
		if (this.CheckInHit())
		{
			return false;
		}
		CharacterRailSlideComponent component = base.Entity.GetComponent<CharacterRailSlideComponent>();
		if (!component)
		{
			return false;
		}
		UCharacterMovementComponent characterMovement = this.CharacterMovement;
		if (!(((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null) != EMovementMode.MOVE_Custom))
		{
			UCharacterMovementComponent characterMovement2 = this.CharacterMovement;
			byte? b = (characterMovement2 != null) ? new byte?(characterMovement2.CustomMovementMode) : null;
			if (((b != null) ? new int?((int)b.GetValueOrDefault()) : null).GetValueOrDefault() == 12)
			{
				component.OnJump();
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601A7D9 RID: 108505 RVA: 0x00715260 File Offset: 0x00713460
	public bool TrySetGlide()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent == null || unifiedStateComponent.PositionState != global::ECharPositionState.Air)
		{
			return false;
		}
		global::ECharMoveState moveState = this.UnifiedStateComponent.MoveState;
		if (moveState == global::ECharMoveState.Glide || moveState == global::ECharMoveState.Slide)
		{
			return false;
		}
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.滑翔禁止"]))
		{
			return false;
		}
		if (Time.Instance.WorldTime - this.LastGlidingControlTime > 0.30000001192092896)
		{
			if (base.GetHeightAboveGround(500f) <= 250f)
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null || !tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为改变.跳跃进滑翔"]))
				{
					return false;
				}
			}
			if (FormationAttributeController.Instance.GetValue(EFormationAttributeId.Strength) > 10f)
			{
				CharacterSkillComponent component = base.Entity.GetComponent<CharacterSkillComponent>();
				if (component != null && component.Valid && component.CurrentSkill != null)
				{
					if (!component.CheckGlideCanInterrupt())
					{
						return false;
					}
					component.StopGroup1Skill("滑翔打断技能");
					this.LimitMaxSpeed();
				}
				CharacterGlideComponent glideComp = this.GlideComp;
				if (glideComp != null && glideComp.Valid)
				{
					this.GlideComp.EnterGlideState("MoveComp");
					base.StopAddMove(this.AirInertiaHandler);
					this.AirInertiaHandler = 0;
					this.LastGlidingControlTime = Time.Instance.WorldTime;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601A7DA RID: 108506 RVA: 0x007153B8 File Offset: 0x007135B8
	protected void PlayerMovementInput(FVectorDouble inputDirect)
	{
		CharacterActionComponent component = base.Entity.GetComponent<CharacterActionComponent>();
		if (component != null && component.GetSitDownState())
		{
			return;
		}
		CharacterSkillComponent skillComp = this.SkillComp;
		if (skillComp != null && skillComp.Valid && this.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"]) && !this.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.摇荡"]))
		{
			if (!base.CanResponseInput() || !skillComp.IsMainSkillReadyEnd || inputDirect.SizeSquared() < 1E-08 || this.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.禁止移动打断技能"]))
			{
				return;
			}
			skillComp.StopGroup1Skill("移动打断技能");
		}
		if (!base.CanApplyInputMovement())
		{
			return;
		}
		this.ApplyCharacterMovementInput(inputDirect);
	}

	// Token: 0x0601A7DB RID: 108507 RVA: 0x00715474 File Offset: 0x00713674
	private void ApplyCharacterMovementInput(FVectorDouble inputDirect)
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		global::ECharPositionState? echarPositionState = (unifiedStateComponent != null) ? new global::ECharPositionState?(unifiedStateComponent.PositionState) : null;
		if (echarPositionState != null)
		{
			switch (echarPositionState.GetValueOrDefault())
			{
			case global::ECharPositionState.Ground:
			{
				APawn actor = this.ActorComp.Actor;
				CharacterAnimationComponent animComp = this.AnimComp;
				actor.D_AddMovementInput(inputDirect, (animComp != null && animComp.Valid) ? this.AnimComp.GetWalkRunMix() : 1f, false);
				return;
			}
			case global::ECharPositionState.Climb:
				break;
			case global::ECharPositionState.Air:
				this.ActorComp.Actor.D_AddMovementInput(inputDirect, 1f, false);
				return;
			case global::ECharPositionState.Water:
				this.ActorComp.Actor.D_AddMovementInput(inputDirect, 1f, false);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x0601A7DC RID: 108508 RVA: 0x00715534 File Offset: 0x00713734
	protected void UpdateInputOrder()
	{
		if (!base.CanResponseInput())
		{
			if (base.MoveController.IsMoving() && base.CanApplyInputMovement())
			{
				this.ApplyCharacterMovementInput(this.ActorComp.InputDirect);
			}
			return;
		}
		this.PlayerMovementInput(this.ActorComp.InputDirect);
	}

	// Token: 0x0601A7DD RID: 108509 RVA: 0x00715584 File Offset: 0x00713784
	public void SmoothCharacterRotationByValue(float pitch, float yaw, float roll, float speed, float deltaTimeSeconds, string context = "Movement.SmoothCharacterRotationByValue")
	{
		if (base.LockedRotation)
		{
			return;
		}
		this.TmpRotator.Pitch = pitch;
		this.TmpRotator.Yaw = yaw;
		this.TmpRotator.Roll = roll;
		global::Rotator actorRotationProxy = this.ActorComp.ActorRotationProxy;
		if (this.TmpRotator.Equals(actorRotationProxy, 0.0001f))
		{
			return;
		}
		if (base.IsStandardGravity)
		{
			MathUtils.Instance.RotatorInterpConstantTo(actorRotationProxy, this.TmpRotator, deltaTimeSeconds, speed, this.TmpRotator);
		}
		else
		{
			GravityUtils.Instance.RotatorInterpConstantToForActor(this.ActorComp, actorRotationProxy, this.TmpRotator, deltaTimeSeconds, speed, this.TmpRotator);
		}
		this.ActorComp.SetActorRotationWithPriority(this.TmpRotator.ToUeRotator(), context, ESetRotationPriority.Movement, false, false);
	}

	// Token: 0x0601A7DE RID: 108510 RVA: 0x00715640 File Offset: 0x00713840
	public int SetAddMoveSpeed(FVectorDouble speed, int? handler = null)
	{
		FRotator actorRotation = this.ActorComp.ActorRotation;
		FVector fvector = speed;
		FVector fvector2 = actorRotation.RotateVector(fvector);
		FVectorDouble value = fvector2;
		return base.SetAddMoveWorld(new FVectorDouble?(value), -1f, null, handler, null, global::EVelocityCurveType.None, 0f, 1f);
	}

	// Token: 0x0601A7DF RID: 108511 RVA: 0x0071569C File Offset: 0x0071389C
	public void SetAddMoveSpeedWithMesh(USkeletalMeshComponent mesh, FVectorDouble speed)
	{
		if (mesh == null)
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.WCL, "[CharacterMoveComponent.SetAddMoveSpeedWithMesh] 叠加位移失败，mesh为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int? handler = new int?(this.VelocityAdditionMapByMesh.ContainsKey(mesh) ? this.VelocityAdditionMapByMesh[mesh] : 0);
		FRotator actorRotation = this.ActorComp.ActorRotation;
		FVector fvector = speed;
		FVector fvector2 = actorRotation.RotateVector(fvector);
		FVectorDouble value = fvector2;
		handler = new int?(base.SetAddMoveWorld(new FVectorDouble?(value), -1f, null, handler, null, global::EVelocityCurveType.None, 0f, 1f));
		if (handler != null)
		{
			this.VelocityAdditionMapByMesh[mesh] = handler.Value;
		}
	}

	// Token: 0x0601A7E0 RID: 108512 RVA: 0x00715760 File Offset: 0x00713960
	[NullableContext(2)]
	public int SetAddMove(FVectorDouble speed, float timeLength, UCurveFloat curve = null, int? handler = null, global::EVelocityCurveType? velocityCurveType = null, float? velocityCurveMin = null, float? velocityCurveMax = null)
	{
		FRotator actorRotation = this.ActorComp.ActorRotation;
		FVector fvector = speed;
		FVector fvector2 = actorRotation.RotateVector(fvector);
		FVectorDouble value = fvector2;
		return base.SetAddMoveWorld(new FVectorDouble?(value), timeLength, curve, handler, null, velocityCurveType.GetValueOrDefault(), velocityCurveMin.GetValueOrDefault(), velocityCurveMax.GetValueOrDefault(1f));
	}

	// Token: 0x0601A7E1 RID: 108513 RVA: 0x007157C8 File Offset: 0x007139C8
	public override void SetAddMoveWithMesh(UMeshComponent mesh, FVectorDouble speed, float timeLength, [Nullable(2)] UCurveFloat curve = null)
	{
		if (mesh == null)
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.WCL, "[CharacterMoveComponent.SetAddMoveWithMesh] 叠加位移失败，mesh为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int? handler = new int?(this.VelocityAdditionMapByMesh.ContainsKey(mesh) ? this.VelocityAdditionMapByMesh[mesh] : 0);
		FRotator actorRotation = this.ActorComp.ActorRotation;
		FVector fvector = speed;
		FVector fvector2 = actorRotation.RotateVector(fvector);
		FVectorDouble value = fvector2;
		handler = new int?(base.SetAddMoveWorld(new FVectorDouble?(value), timeLength, curve, handler, null, global::EVelocityCurveType.None, 0f, 1f));
		if (handler != null)
		{
			this.VelocityAdditionMapByMesh[mesh] = handler.Value;
		}
	}

	// Token: 0x0601A7E2 RID: 108514 RVA: 0x0071588C File Offset: 0x00713A8C
	public void SetGravityScale(float scaleUp, float scaleDown, float scaleTop, float velocityTop, float duration, bool forceVelocityZero, Entity attacker)
	{
		if (Math.Abs(scaleUp - 1f) < 0.0001f && Math.Abs(scaleDown - 1f) < 0.0001f && Math.Abs(scaleTop - 1f) < 0.0001f)
		{
			return;
		}
		if (duration <= 0f)
		{
			return;
		}
		this.CurrentGravityScale.ScaleUp = scaleUp;
		this.CurrentGravityScale.ScaleDown = scaleDown;
		this.CurrentGravityScale.ScaleTop = scaleTop;
		this.CurrentGravityScale.VelocityTop = velocityTop;
		this.CurrentGravityScale.Duration = duration;
		this.CurrentGravityScale.ElapsedTime = 0f;
		this.CurrentGravityScale.ForceVelocityZero = forceVelocityZero;
		this.CurrentGravityScale.Enable = true;
	}

	// Token: 0x0601A7E3 RID: 108515 RVA: 0x00715944 File Offset: 0x00713B44
	public FVector GetLastUpdateVelocity()
	{
		return this.CharacterMovement.GetLastUpdateVelocity();
	}

	// Token: 0x17002478 RID: 9336
	// (get) Token: 0x0601A7E4 RID: 108516 RVA: 0x00715951 File Offset: 0x00713B51
	public float CharacterWeight
	{
		get
		{
			return (float)((this.CreatureProperty != null) ? this.CreatureProperty.重量 : 0);
		}
	}

	// Token: 0x17002479 RID: 9337
	// (get) Token: 0x0601A7E5 RID: 108517 RVA: 0x00715970 File Offset: 0x00713B70
	public bool HasSwimmingBlock
	{
		get
		{
			return this.CharacterMovement.CustomMovementMode == 1 && this.CharacterMovement.Kuro_GetBlockDirectWhenMove().SizeSquared() > 0f;
		}
	}

	// Token: 0x0601A7E6 RID: 108518 RVA: 0x007159A7 File Offset: 0x00713BA7
	protected bool UpdateSkillRotation()
	{
		return !(!this.SkillComp) && (this.SkillComp.Active && this.SkillComp.UpdateAllSkillRotator(this.DeltaTimeSeconds));
	}

	// Token: 0x0601A7E7 RID: 108519 RVA: 0x007159DC File Offset: 0x00713BDC
	protected void UpdateFacing()
	{
		if (!base.CanUpdateMovingRotation())
		{
			this.UpdateSkillRotation();
			return;
		}
		CharacterActionComponent component = base.Entity.GetComponent<CharacterActionComponent>();
		if (component != null && component.GetSitDownState())
		{
			return;
		}
		if (this.ActorComp.OverrideTurnSpeed.GetValueOrDefault() != 0f)
		{
			base.SmoothCharacterRotation(this.ActorComp.InputRotatorProxy, this.ActorComp.OverrideTurnSpeed.Value, this.DeltaTimeSeconds, false, "Movement.UpdateFacing", true);
			this.ActorComp.SetOverrideTurnSpeed(null);
			return;
		}
		if (this.UpdateSkillRotation())
		{
			return;
		}
		if (!this.IsInputDrivenCharacter)
		{
			return;
		}
		if (this.AnimComp.BattleIdleEndTime > 0f)
		{
			return;
		}
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent != null && unifiedStateComponent.Valid)
		{
			global::ECharPositionState positionState = unifiedStateComponent.PositionState;
			if (!this.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"]))
			{
				if (this.ActorComp.UseControllerRotation)
				{
					base.UpdateUsingControllerRotation();
					return;
				}
				if (positionState == global::ECharPositionState.Ground)
				{
					base.UpdateGroundedRotation();
					return;
				}
				if (positionState != global::ECharPositionState.Air)
				{
					if (positionState != global::ECharPositionState.Floating)
					{
						return;
					}
					base.UpdateGroundedRotation();
					return;
				}
				else
				{
					if (unifiedStateComponent.MoveState == global::ECharMoveState.WalkOnAir)
					{
						base.UpdateGroundedRotation();
						return;
					}
					base.UpdateInAirRotation();
					return;
				}
			}
		}
		else
		{
			base.UpdateGroundedRotation();
		}
	}

	// Token: 0x0601A7E8 RID: 108520 RVA: 0x00715B0E File Offset: 0x00713D0E
	protected override float SpeedScaled(float speed)
	{
		if (this.TimeScaleComp == null)
		{
			return speed;
		}
		return speed * this.TimeScaleComp.CurrentTimeScale * this.ActorComp.TimeDilation;
	}

	// Token: 0x0601A7E9 RID: 108521 RVA: 0x00715B33 File Offset: 0x00713D33
	public override bool CanMove()
	{
		return base.CanMove() && !this.ContainsTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]);
	}

	// Token: 0x0601A7EA RID: 108522 RVA: 0x00715B58 File Offset: 0x00713D58
	protected void OnSpeedRatioAttributeChanged(EAttributeType attribute, float newValue, float oldValue)
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		global::ECharMoveState? newMoveState = (unifiedStateComponent != null) ? new global::ECharMoveState?(unifiedStateComponent.MoveState) : null;
		CharacterMoveComponent component = base.Entity.GetComponent<CharacterMoveComponent>();
		if (component != null && component.Valid)
		{
			component.ResetMaxSpeed(newMoveState);
		}
	}

	// Token: 0x0601A7EB RID: 108523 RVA: 0x00715BA4 File Offset: 0x00713DA4
	protected void OnResponseInputTagsChanged(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			if (this.CannotResponseInputCount == 0)
			{
				this.HasMoveInput = false;
				CharacterFloatingComponent floatingComp = this.FloatingComp;
				if (floatingComp != null && floatingComp.Valid)
				{
					this.FloatingComp.HasFloatingMoveInput = false;
				}
			}
			this.CannotResponseInputCount++;
			return;
		}
		this.CannotResponseInputCount--;
	}

	// Token: 0x0601A7EC RID: 108524 RVA: 0x00715C00 File Offset: 0x00713E00
	[NullableContext(2)]
	public void SetChain(float length, global::Vector centerLocation = null)
	{
		if (length < 0f)
		{
			this.ConfigChainLengthSquared = -1.0;
		}
		else
		{
			this.ConfigChainLengthSquared = (double)(length * length);
		}
		if (centerLocation != null)
		{
			this.ChainCenter.FromUeVector(centerLocation);
			return;
		}
		this.ChainCenter.FromUeVector(this.ActorComp.GetInitLocation());
	}

	// Token: 0x0601A7ED RID: 108525 RVA: 0x00715C58 File Offset: 0x00713E58
	public void UpdateMoveChain()
	{
		if (this.ConfigChainLengthSquared < 0.0)
		{
			return;
		}
		this.CurrentChainLengthSquared = Math.Max(this.CurrentChainLengthSquared, this.ConfigChainLengthSquared);
		this.ChainCenter.Subtraction(this.ActorComp.ActorLocationProxy, CharacterMoveComponent.TempVelocity);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, CharacterMoveComponent.TempVelocity);
		double num = CharacterMoveComponent.TempVelocity.SizeSquared();
		if (num > this.CurrentChainLengthSquared)
		{
			CharacterMoveComponent.TempVelocity.MultiplyEqual((double)(((float)Math.Sqrt(num) - (float)Math.Sqrt(this.CurrentChainLengthSquared)) / (float)Math.Sqrt(num)));
			base.MoveCharacter(CharacterMoveComponent.TempVelocity, this.DeltaTimeSeconds, "");
			return;
		}
		if (num > this.ConfigChainLengthSquared)
		{
			this.CurrentChainLengthSquared = num;
		}
	}

	// Token: 0x0601A7EE RID: 108526 RVA: 0x00715D24 File Offset: 0x00713F24
	public void PlayerMotionRequest(MotionType type)
	{
		PlayerMotionRequest playerMotionRequest = Aki.Protocol.PlayerMotionRequest.Create();
		playerMotionRequest.Motion = type;
		Net.Instance.Call(ERequestMessageId.PlayerMotionRequest, playerMotionRequest, null, 0);
	}

	// Token: 0x0601A7EF RID: 108527 RVA: 0x00715D50 File Offset: 0x00713F50
	private bool UpdateInAreaWhirlpool()
	{
		int needTagId = this.WhirlpoolPoint.GetNeedTagId();
		if (needTagId != 0)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(needTagId))
			{
				return false;
			}
		}
		float num = MathUtils.Instance.Clamp(this.WhirlpoolPoint.GetAlpha(), 0f, 1f);
		global::Vector velocityAdditionDestination = BaseMoveComponent.VelocityAdditionDestination;
		global::Vector.Lerp(this.WhirlpoolPoint.BeginLocation, this.WhirlpoolPoint.ToLocation, (double)num, velocityAdditionDestination);
		this.ActorComp.SetActorLocation(velocityAdditionDestination.ToUeVector(false), "移动.被吸引", true);
		return true;
	}

	// Token: 0x0601A7F0 RID: 108528 RVA: 0x00715DE4 File Offset: 0x00713FE4
	public void BeginWhirlpool(int id, float moveTime, global::Vector location, global::Vector beginLocation, float duration = -1f, global::EVelocityCurveType curveType = global::EVelocityCurveType.None, bool cancelByHit = true, int needTagId = 0)
	{
		if (needTagId != 0)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(needTagId))
			{
				return;
			}
		}
		this.CharacterMovement.GravityScale = 0f;
		base.Entity.GetComponent<CharacterUnifiedStateComponent>().SetMoveState(global::ECharMoveState.KnockUp);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[CharacterMoveComponent.BeginWhirlpool]"
			});
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		bool flag;
		if (actorComp2 == null)
		{
			flag = false;
		}
		else
		{
			UCapsuleComponent capsuleComponent = actorComp2.Actor.CapsuleComponent;
			flag = ((capsuleComponent != null) ? new bool?(capsuleComponent.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			CollisionUtils.Instance.SetCollisionResponseToPawn(this.ActorComp.Actor.CapsuleComponent, EPawnChannel.All, ECollisionResponse.ECR_Ignore);
		}
		this.SetForceFallingSpeed(global::Vector.ZeroVector, GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.击飞"]);
		this.WhirlpoolPoint.Begin(id, moveTime, location, beginLocation, duration, curveType, cancelByHit, needTagId);
		base.Entity.GetComponent<CharacterHitComponent>().ActiveStiff(-1f);
	}

	// Token: 0x0601A7F1 RID: 108529 RVA: 0x00715EF8 File Offset: 0x007140F8
	public void EndWhirlpool(string reason)
	{
		this.CharacterMovement.GravityScale = 2f;
		this.WhirlpoolPoint.OnEnd();
		CharacterActorComponent actorComp = this.ActorComp;
		bool flag;
		if (actorComp == null)
		{
			flag = false;
		}
		else
		{
			UCapsuleComponent capsuleComponent = actorComp.Actor.CapsuleComponent;
			flag = ((capsuleComponent != null) ? new bool?(capsuleComponent.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			CollisionUtils.Instance.SetCollisionResponseToPawn(this.ActorComp.Actor.CapsuleComponent, EPawnChannel.All, ECollisionResponse.ECR_Block);
		}
		if (this.UnifiedStateComponent != null && this.UnifiedStateComponent.PositionState != global::ECharPositionState.Air)
		{
			base.Entity.GetComponent<CharacterHitComponent>().DeActiveStiff("EndWhirlpool");
		}
	}

	// Token: 0x0601A7F2 RID: 108530 RVA: 0x00715FA1 File Offset: 0x007141A1
	public bool GetWhirlpoolEnable()
	{
		return this.WhirlpoolPoint.GetEnable();
	}

	// Token: 0x0601A7F3 RID: 108531 RVA: 0x00715FAE File Offset: 0x007141AE
	public bool GetWhirlpoolCancelByHit()
	{
		return this.WhirlpoolPoint.GetCancelByHit();
	}

	// Token: 0x0601A7F4 RID: 108532 RVA: 0x00715FBB File Offset: 0x007141BB
	public int GetWhirlpoolId()
	{
		return this.WhirlpoolPoint.GetId();
	}

	// Token: 0x0601A7F5 RID: 108533 RVA: 0x00715FC8 File Offset: 0x007141C8
	public bool CompareWhirlpoolPriority(float moveTime)
	{
		return moveTime < this.WhirlpoolPoint.GetMoveTime();
	}

	// Token: 0x0601A7F6 RID: 108534 RVA: 0x00715FD8 File Offset: 0x007141D8
	public void UpdateWhirlpoolLocation(global::Vector location)
	{
		this.WhirlpoolPoint.UpdateLocation(location);
	}

	// Token: 0x0601A7F7 RID: 108535 RVA: 0x00715FE6 File Offset: 0x007141E6
	protected void InitStepUpParams()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.InitMaxStepHeight = this.CharacterMovement.MaxStepHeight;
		this.InitStepUpPercent = this.CharacterMovement.StepUpDeltaPrecent;
		this.InitStepUpStandardSpeed = this.CharacterMovement.StepUpStandardSpeed;
	}

	// Token: 0x0601A7F8 RID: 108536 RVA: 0x00716024 File Offset: 0x00714224
	public void SetStepUpParamsRecord(bool reset)
	{
		if (reset)
		{
			this.StepUpOffCount--;
			if (this.StepUpOffCount == 0)
			{
				this.ResetStepUpParams();
				return;
			}
		}
		else
		{
			this.StepUpOffCount++;
			if (this.StepUpOffCount == 1)
			{
				this.SetStepUpParams();
			}
		}
	}

	// Token: 0x0601A7F9 RID: 108537 RVA: 0x00716063 File Offset: 0x00714263
	protected void SetStepUpParams()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.StepUpDeltaPrecent = 1f;
		this.CharacterMovement.StepUpStandardSpeed = 1f;
	}

	// Token: 0x0601A7FA RID: 108538 RVA: 0x0071608E File Offset: 0x0071428E
	protected void ResetStepUpParams()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.StepUpDeltaPrecent = this.InitStepUpPercent;
		this.CharacterMovement.StepUpStandardSpeed = this.InitStepUpStandardSpeed;
	}

	// Token: 0x0601A7FB RID: 108539 RVA: 0x007160BB File Offset: 0x007142BB
	public void SetStepHeight(float value)
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.MaxStepHeight = value;
	}

	// Token: 0x0601A7FC RID: 108540 RVA: 0x007160D2 File Offset: 0x007142D2
	public void ResetStepHeight()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.MaxStepHeight = this.InitMaxStepHeight;
	}

	// Token: 0x0601A7FD RID: 108541 RVA: 0x007160EE File Offset: 0x007142EE
	public void SetWalkableFloorAngle(float value)
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.SetWalkableFloorAngle(value);
	}

	// Token: 0x0601A7FE RID: 108542 RVA: 0x00716105 File Offset: 0x00714305
	public void ResetWalkableFloorAngle()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.SetWalkableFloorAngle(this.MovementData.WalkableFloorAngle);
	}

	// Token: 0x0601A7FF RID: 108543 RVA: 0x00716126 File Offset: 0x00714326
	public void SetKuroPlanarPhysWalking(bool enable)
	{
		this.IsKuroPlanarPhysWalkingEnableInternal = enable;
		this.CharacterMovement.SetKuroPlanarPhysWalking(enable);
	}

	// Token: 0x0601A800 RID: 108544 RVA: 0x0071613B File Offset: 0x0071433B
	public void ResetPlanarPhysWalking()
	{
		this.CharacterMovement.bKuroPlanarNeedFindFloor = true;
	}

	// Token: 0x0601A801 RID: 108545 RVA: 0x0071614C File Offset: 0x0071434C
	public void TryJumpInFreeRunning()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Ground)
		{
			this.OnJump();
			this.PlayerMotionRequest(MotionType.MotionJump);
			return;
		}
		BaseUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
		if (unifiedStateComponent2 != null && unifiedStateComponent2.PositionState == global::ECharPositionState.Ski)
		{
			this.JumpPressInSki();
		}
	}

	// Token: 0x0601A802 RID: 108546 RVA: 0x0071619C File Offset: 0x0071439C
	public bool IsOnGroundOrOnWater()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		return (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Ground) || (this.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom && this.CharacterMovement.CustomMovementMode == 5);
	}

	// Token: 0x0601A803 RID: 108547 RVA: 0x007161EB File Offset: 0x007143EB
	[Conditional("DEBUG")]
	private void UpdateKuroAsyncRootMotion()
	{
	}

	// Token: 0x0601A804 RID: 108548 RVA: 0x007161F0 File Offset: 0x007143F0
	public void SetKuroAsyncRootMotion(bool enable)
	{
		this.IsKuroAsyncRootMotionEnable = enable;
		this.CharacterMovement.SetKuroAsyncRootMotion(enable);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Movement;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "设置Kuro异步RootMotion";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("enable", enable);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601A805 RID: 108549 RVA: 0x0071623C File Offset: 0x0071443C
	private bool CheckPerformanceOptimizationCondition()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		if (instanceId != this.PerfConditionCachedInstanceId)
		{
			this.PerfConditionCachedInstanceId = instanceId;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			int? num = (config != null) ? new int?(config.GetValueOrDefault().InstSubType) : null;
			this.PerfConditionCachedSubType = ((num != null) ? new EDungeonSubType?((EDungeonSubType)num.GetValueOrDefault()) : null);
		}
		return (this.PerfConditionCachedSubType.GetValueOrDefault() == EDungeonSubType.DangoAbyss && DangoAbyssModel.Instance.IsPlanarDungeon()) || this.PerfConditionCachedSubType.GetValueOrDefault() == EDungeonSubType.PhantomArena;
	}

	// Token: 0x0601A806 RID: 108550 RVA: 0x007162F0 File Offset: 0x007144F0
	private bool IsEnablePlanarPhysWalking()
	{
		return this.CheckPerformanceOptimizationCondition();
	}

	// Token: 0x0601A807 RID: 108551 RVA: 0x007162FD File Offset: 0x007144FD
	private bool IsEnableAsyncRootMotion()
	{
		return CharacterMoveComponent.EnableKuroAsyncRootMotion && this.CheckPerformanceOptimizationCondition();
	}

	// Token: 0x0601A808 RID: 108552 RVA: 0x00716313 File Offset: 0x00714513
	public void SetMovementData(SMovementSetting_State movementData, bool refresh = false)
	{
		this.MovementData = movementData;
		UCharacterMovementComponent characterMovement = this.CharacterMovement;
		if (characterMovement != null)
		{
			characterMovement.SetWalkableFloorAngle(this.MovementData.WalkableFloorAngle);
		}
		if (refresh)
		{
			base.OnPositionStateChange(global::ECharPositionState.Ground, global::ECharPositionState.Ground);
		}
	}

	// Token: 0x0601A809 RID: 108553 RVA: 0x00716344 File Offset: 0x00714544
	private void InitInputMoveLimit()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		if (UKuroStaticLibrary.IsObjectClassByName((animComp != null) ? animComp.MainAnimInstance : null, CharacterNameDefines.Instance.ABP_BASERUNANIMAL))
		{
			this.MaxMoveDegree = this.MovementData.CustomSetting00.Standing.ControllerRotationSpeedSetting.最大角度差;
		}
	}

	// Token: 0x0601A80A RID: 108554 RVA: 0x00716394 File Offset: 0x00714594
	private void InitMovementData()
	{
		this.DefaultMovementData = DataTableUtil.GetDataTableRow<SMovementSetting_State>(this.ActorComp.Actor.DtBaseMovementSetting, CharacterNameDefines.Instance.NORMAL.ToString());
		this.MovementData = this.DefaultMovementData;
		List<SMovementSetting_State> dataTableAllRowFromTable = DataTableUtil.GetDataTableAllRowFromTable<SMovementSetting_State>(this.ActorComp.Actor.DtBaseMovementSetting);
		for (int i = 0; i < dataTableAllRowFromTable.Count; i++)
		{
			SMovementSetting_State smovementSetting_State = dataTableAllRowFromTable[i];
			if (!(smovementSetting_State.EnableTag.TagName == FName.NAME_None))
			{
				this.MovementDataMap[smovementSetting_State.EnableTag.TagId()] = smovementSetting_State;
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null && tagComponent.HasTag(smovementSetting_State.EnableTag.TagId()))
				{
					this.MovementData = smovementSetting_State;
				}
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null)
				{
					tagComponent2.AddTagAddOrRemoveListener(smovementSetting_State.EnableTag.TagId(), new BaseTagComponent.TTagSwitchedCallback(this.OnMovementDataTagChanged), null);
				}
			}
		}
		UCharacterMovementComponent characterMovement = this.CharacterMovement;
		if (characterMovement == null)
		{
			return;
		}
		characterMovement.SetWalkableFloorAngle(this.MovementData.WalkableFloorAngle);
	}

	// Token: 0x0601A80B RID: 108555 RVA: 0x007164AC File Offset: 0x007146AC
	private void UnInitMovementData()
	{
		foreach (KeyValuePair<int, SMovementSetting_State> keyValuePair in this.MovementDataMap)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTagAddOrRemoveListener(keyValuePair.Key, new BaseTagComponent.TTagSwitchedCallback(this.OnMovementDataTagChanged));
			}
		}
		this.MovementDataMap.Clear();
	}

	// Token: 0x0601A80C RID: 108556 RVA: 0x00716528 File Offset: 0x00714728
	private void OnMovementDataTagChanged(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			this.MovementData = (this.MovementDataMap.ContainsKey(tagId) ? this.MovementDataMap[tagId] : null);
		}
		else if (this.MovementData == (this.MovementDataMap.ContainsKey(tagId) ? this.MovementDataMap[tagId] : null))
		{
			this.MovementData = this.DefaultMovementData;
		}
		UCharacterMovementComponent characterMovement = this.CharacterMovement;
		if (characterMovement != null)
		{
			characterMovement.SetWalkableFloorAngle(this.MovementData.WalkableFloorAngle);
		}
		base.OnPositionStateChange(global::ECharPositionState.Ground, global::ECharPositionState.Ground);
	}

	// Token: 0x0601A80D RID: 108557 RVA: 0x007165B7 File Offset: 0x007147B7
	public new static void CreateStaticDefaultValue()
	{
		BaseMoveComponent.CreateStaticDefaultValue();
		CharacterMoveComponent.EnableKuroAsyncRootMotionInternal = true;
	}

	// Token: 0x0601A80E RID: 108558 RVA: 0x007165C4 File Offset: 0x007147C4
	public new static void ResetStaticDefaultValue()
	{
		BaseMoveComponent.ResetStaticDefaultValue();
		CharacterMoveComponent.EnableKuroAsyncRootMotionInternal = false;
		BaseMoveComponent.BaseMoveInheritCurveInternal = null;
	}

	// Token: 0x0601A80F RID: 108559 RVA: 0x007165D8 File Offset: 0x007147D8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterMoveComponent characterMoveComponent = (CharacterMoveComponent)componentTemplate;
		if (base.CanResetComponentProperty("GlideComp"))
		{
			if (characterMoveComponent.GlideComp == null)
			{
				this.GlideComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterGlideComponent>(this.GlideComp), "GlideComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SwimComp"))
		{
			if (characterMoveComponent.SwimComp == null)
			{
				this.SwimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSwimComponent>(this.SwimComp), "SwimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WalkOnWaterComp"))
		{
			if (characterMoveComponent.WalkOnWaterComp == null)
			{
				this.WalkOnWaterComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterWalkOnWaterComponent>(this.WalkOnWaterComp), "WalkOnWaterComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FloatingComp"))
		{
			if (characterMoveComponent.FloatingComp == null)
			{
				this.FloatingComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterFloatingComponent>(this.FloatingComp), "FloatingComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ForceFallingSpeedCache"))
		{
			if (characterMoveComponent.ForceFallingSpeedCache == null)
			{
				this.ForceFallingSpeedCache = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ForceFallingSpeedCache>(this.ForceFallingSpeedCache), "ForceFallingSpeedCache"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterMoveComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LastGlidingControlTime"))
		{
			this.LastGlidingControlTime = characterMoveComponent.LastGlidingControlTime;
		}
		if (base.CanResetComponentProperty("AttributeComponent"))
		{
			if (characterMoveComponent.AttributeComponent == null)
			{
				this.AttributeComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComponent), "AttributeComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComponent"))
		{
			if (characterMoveComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComponent), "TagComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DeathComponent"))
		{
			if (characterMoveComponent.DeathComponent == null)
			{
				this.DeathComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseDeathComponent>(this.DeathComponent), "DeathComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AirInertiaHandler"))
		{
			this.AirInertiaHandler = characterMoveComponent.AirInertiaHandler;
		}
		if (base.CanResetComponentProperty("CanResponseInputTasks") && characterMoveComponent.CanResponseInputTasks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.CanResponseInputTasks), "CanResponseInputTasks"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("LastJumpTime"))
		{
			this.LastJumpTime = characterMoveComponent.LastJumpTime;
		}
		if (base.CanResetComponentProperty("TryGlideTime"))
		{
			this.TryGlideTime = characterMoveComponent.TryGlideTime;
		}
		if (base.CanResetComponentProperty("WhirlpoolPoint") && characterMoveComponent.WhirlpoolPoint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<WhirlpoolPoint>(this.WhirlpoolPoint), "WhirlpoolPoint"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsKuroPlanarPhysWalkingEnableInternal"))
		{
			this.IsKuroPlanarPhysWalkingEnableInternal = characterMoveComponent.IsKuroPlanarPhysWalkingEnableInternal;
		}
		if (base.CanResetComponentProperty("IsKuroAsyncRootMotionEnable"))
		{
			this.IsKuroAsyncRootMotionEnable = characterMoveComponent.IsKuroAsyncRootMotionEnable;
		}
		if (base.CanResetComponentProperty("OverrideMaxFallingSpeed"))
		{
			this.OverrideMaxFallingSpeed = characterMoveComponent.OverrideMaxFallingSpeed;
		}
		if (base.CanResetComponentProperty("GroundedFrame"))
		{
			this.GroundedFrame = characterMoveComponent.GroundedFrame;
		}
		if (base.CanResetComponentProperty("SlideTrans"))
		{
			if (characterMoveComponent.SlideTrans == null)
			{
				this.SlideTrans = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Transform>(this.SlideTrans), "SlideTrans"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StepUpOffCount"))
		{
			this.StepUpOffCount = characterMoveComponent.StepUpOffCount;
		}
		if (base.CanResetComponentProperty("InitMaxStepHeight"))
		{
			this.InitMaxStepHeight = characterMoveComponent.InitMaxStepHeight;
		}
		if (base.CanResetComponentProperty("InitStepUpPercent"))
		{
			this.InitStepUpPercent = characterMoveComponent.InitStepUpPercent;
		}
		if (base.CanResetComponentProperty("InitStepUpStandardSpeed"))
		{
			this.InitStepUpStandardSpeed = characterMoveComponent.InitStepUpStandardSpeed;
		}
		if (base.CanResetComponentProperty("PerfConditionCachedInstanceId"))
		{
			this.PerfConditionCachedInstanceId = characterMoveComponent.PerfConditionCachedInstanceId;
		}
		if (base.CanResetComponentProperty("PerfConditionCachedSubType"))
		{
			this.PerfConditionCachedSubType = characterMoveComponent.PerfConditionCachedSubType;
		}
		return true;
	}

	// Token: 0x0400CB2D RID: 52013
	private const int MIN_MOVE_SPEED = 20;

	// Token: 0x0400CB2E RID: 52014
	private const float GLIDING_CONTROL_OFFSET = 0.3f;

	// Token: 0x0400CB2F RID: 52015
	public const int GLIDING_HEIGHT_THREDHOLD = 250;

	// Token: 0x0400CB30 RID: 52016
	private const int MAX_IN_WATER_SPEED = 800;

	// Token: 0x0400CB31 RID: 52017
	public const int GLIDE_STRENGTH_THREADHOLD = 10;

	// Token: 0x0400CB32 RID: 52018
	private const int SQUARE_MAX_INHERIT_SPEED = 1000000;

	// Token: 0x0400CB33 RID: 52019
	[StaticVariableRuleIgnore]
	private static readonly int[] cannotResponseInputTag = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"],
		GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]
	};

	// Token: 0x0400CB34 RID: 52020
	private const int JUMP_FRAME_COUNT = 3;

	// Token: 0x0400CB35 RID: 52021
	private const int SLIDE_JUMP_LERP_TIME = 100;

	// Token: 0x0400CB36 RID: 52022
	private const int SLIDE_JUMP_SPEED = 900;

	// Token: 0x0400CB37 RID: 52023
	private const float OVER_VELOCITY_PERCENT = 1.01f;

	// Token: 0x0400CB38 RID: 52024
	private const float BASE_MOVE_INHERIT_TIME = 1.5f;

	// Token: 0x0400CB39 RID: 52025
	private const int TRY_GLIDE_TIME = 500;

	// Token: 0x0400CB3A RID: 52026
	private const int MAX_WALK_FLOOR_ANGLE = 55;

	// Token: 0x0400CB3B RID: 52027
	private const int DEFAULT_MAX_STEP_HEIGHT = 45;

	// Token: 0x0400CB3C RID: 52028
	private const float DEFAULT_STEP_UP_PERCENT = 0.08f;

	// Token: 0x0400CB3D RID: 52029
	private const int DEFAULT_STEP_UP_STANDARD_SPEED = 400;

	// Token: 0x0400CB3E RID: 52030
	private static bool EnableKuroAsyncRootMotionInternal;

	// Token: 0x0400CB3F RID: 52031
	[Nullable(2)]
	protected CharacterGlideComponent GlideComp;

	// Token: 0x0400CB40 RID: 52032
	[Nullable(2)]
	protected CharacterSwimComponent SwimComp;

	// Token: 0x0400CB41 RID: 52033
	[Nullable(2)]
	protected CharacterWalkOnWaterComponent WalkOnWaterComp;

	// Token: 0x0400CB42 RID: 52034
	[Nullable(2)]
	protected CharacterFloatingComponent FloatingComp;

	// Token: 0x0400CB43 RID: 52035
	[Nullable(2)]
	public ForceFallingSpeedCache ForceFallingSpeedCache;

	// Token: 0x0400CB44 RID: 52036
	[Nullable(2)]
	protected CharacterSkillComponent SkillComp;

	// Token: 0x0400CB45 RID: 52037
	protected double LastGlidingControlTime;

	// Token: 0x0400CB46 RID: 52038
	[Nullable(2)]
	protected BaseAttributeComponent AttributeComponent;

	// Token: 0x0400CB47 RID: 52039
	[Nullable(2)]
	protected BaseTagComponent TagComponent;

	// Token: 0x0400CB48 RID: 52040
	[Nullable(2)]
	protected BaseDeathComponent DeathComponent;

	// Token: 0x0400CB49 RID: 52041
	protected int AirInertiaHandler;

	// Token: 0x0400CB4A RID: 52042
	protected readonly List<ITagTask> CanResponseInputTasks = new List<ITagTask>();

	// Token: 0x0400CB4B RID: 52043
	public double LastJumpTime;

	// Token: 0x0400CB4C RID: 52044
	protected double TryGlideTime;

	// Token: 0x0400CB4D RID: 52045
	private readonly WhirlpoolPoint WhirlpoolPoint = new WhirlpoolPoint();

	// Token: 0x0400CB4E RID: 52046
	private bool IsKuroPlanarPhysWalkingEnableInternal;

	// Token: 0x0400CB4F RID: 52047
	private bool IsKuroAsyncRootMotionEnable;

	// Token: 0x0400CB50 RID: 52048
	private float OverrideMaxFallingSpeed;

	// Token: 0x0400CB51 RID: 52049
	protected int GroundedFrame;

	// Token: 0x0400CB52 RID: 52050
	[StaticVariableRuleIgnore]
	protected static readonly global::Vector TempVelocity = global::Vector.Create();

	// Token: 0x0400CB53 RID: 52051
	[Nullable(2)]
	protected global::Transform SlideTrans;

	// Token: 0x0400CB54 RID: 52052
	private int StepUpOffCount;

	// Token: 0x0400CB55 RID: 52053
	protected float InitMaxStepHeight = 45f;

	// Token: 0x0400CB56 RID: 52054
	protected float InitStepUpPercent = 0.08f;

	// Token: 0x0400CB57 RID: 52055
	protected float InitStepUpStandardSpeed = 400f;

	// Token: 0x0400CB58 RID: 52056
	private int PerfConditionCachedInstanceId = int.MinValue;

	// Token: 0x0400CB59 RID: 52057
	private EDungeonSubType? PerfConditionCachedSubType;
}
