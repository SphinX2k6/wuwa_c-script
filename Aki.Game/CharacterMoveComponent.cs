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

// Token: 0x020025D0 RID: 9680
[NullableContext(1)]
[Nullable(0)]
public class CharacterMoveComponent : BaseMoveComponent, IStaticVariableResetter
{
	// Token: 0x0601816C RID: 98668 RVA: 0x007391D0 File Offset: 0x007373D0
	static CharacterMoveComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterMoveComponent.CreateStaticDefaultValue), new Action(CharacterMoveComponent.ResetStaticDefaultValue));
	}

	// Token: 0x170025AE RID: 9646
	// (get) Token: 0x0601816D RID: 98669 RVA: 0x00739286 File Offset: 0x00737486
	// (set) Token: 0x0601816E RID: 98670 RVA: 0x0073928D File Offset: 0x0073748D
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

	// Token: 0x170025AF RID: 9647
	// (get) Token: 0x0601816F RID: 98671 RVA: 0x00739295 File Offset: 0x00737495
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent)
			};
		}
	}

	// Token: 0x06018170 RID: 98672 RVA: 0x007392AC File Offset: 0x007374AC
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

	// Token: 0x06018171 RID: 98673 RVA: 0x00739330 File Offset: 0x00737530
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

	// Token: 0x170025B0 RID: 9648
	// (get) Token: 0x06018172 RID: 98674 RVA: 0x007393F1 File Offset: 0x007375F1
	public float WalkSpeed
	{
		get
		{
			return base.CurrentMovementSettings.WalkSpeed;
		}
	}

	// Token: 0x170025B1 RID: 9649
	// (get) Token: 0x06018173 RID: 98675 RVA: 0x007393FE File Offset: 0x007375FE
	public float RunSpeed
	{
		get
		{
			return base.CurrentMovementSettings.RunSpeed;
		}
	}

	// Token: 0x170025B2 RID: 9650
	// (get) Token: 0x06018174 RID: 98676 RVA: 0x0073940B File Offset: 0x0073760B
	public float SprintSpeed
	{
		get
		{
			return base.CurrentMovementSettings.SprintSpeed;
		}
	}

	// Token: 0x170025B3 RID: 9651
	// (get) Token: 0x06018175 RID: 98677 RVA: 0x00739418 File Offset: 0x00737618
	public float SwimSpeed
	{
		get
		{
			return base.CurrentMovementSettings.NormalSwimSpeed;
		}
	}

	// Token: 0x170025B4 RID: 9652
	// (get) Token: 0x06018176 RID: 98678 RVA: 0x00739425 File Offset: 0x00737625
	public float FastSwimSpeed
	{
		get
		{
			return base.CurrentMovementSettings.FastSwimSpeed;
		}
	}

	// Token: 0x170025B5 RID: 9653
	// (get) Token: 0x06018177 RID: 98679 RVA: 0x00739432 File Offset: 0x00737632
	public bool IsKuroPlanarPhysWalkingEnable
	{
		get
		{
			return this.IsKuroPlanarPhysWalkingEnableInternal;
		}
	}

	// Token: 0x06018178 RID: 98680 RVA: 0x0073943A File Offset: 0x0073763A
	public void SetOverrideMaxFallingSpeed(float v)
	{
		this.OverrideMaxFallingSpeed = v;
	}

	// Token: 0x06018179 RID: 98681 RVA: 0x00739443 File Offset: 0x00737643
	public void ResetOverrideMaxFallingSpeed()
	{
		this.OverrideMaxFallingSpeed = 0f;
	}

	// Token: 0x0601817A RID: 98682 RVA: 0x00739450 File Offset: 0x00737650
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

	// Token: 0x0601817B RID: 98683 RVA: 0x00739550 File Offset: 0x00737750
	protected void OnLand()
	{
		this.GroundedTimeUe = UGameplayStatics.GetGamePlayTimeSeconds(this.ActorComp.Actor);
		this.GroundedFrame = Time.Instance.Frame;
		if (AActor.GetKuroNetMode() == EKuroNetMode.KNM_Net && this.ActorComp.IsAutonomousProxy)
		{
			EventSystem.Instance.Emit<Entity>(EEventName.EntityOnLandedPush, base.Entity);
		}
	}

	// Token: 0x0601817C RID: 98684 RVA: 0x007395B8 File Offset: 0x007377B8
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

	// Token: 0x0601817D RID: 98685 RVA: 0x00739758 File Offset: 0x00737958
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
		this.ActorComp.SetInputDirect(component.ActorComp.InputDirectProxy, false, EInputDirectSpace.World);
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

	// Token: 0x0601817E RID: 98686 RVA: 0x007398C4 File Offset: 0x00737AC4
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

	// Token: 0x0601817F RID: 98687 RVA: 0x00739990 File Offset: 0x00737B90
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

	// Token: 0x06018180 RID: 98688 RVA: 0x00739B5C File Offset: 0x00737D5C
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

	// Token: 0x06018181 RID: 98689 RVA: 0x00739D54 File Offset: 0x00737F54
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

	// Token: 0x06018182 RID: 98690 RVA: 0x00739DCB File Offset: 0x00737FCB
	protected void OnEnableWalkOnAirTag(int tagId, bool tagExist)
	{
		this.CharacterMovement.bKuroWalkOnAir = tagExist;
	}

	// Token: 0x06018183 RID: 98691 RVA: 0x00739DDC File Offset: 0x00737FDC
	[NullableContext(2)]
	protected void OnVisionMorphBegin(EntityHandle visionEntity, EntityHandle roleEntity)
	{
		if ((roleEntity == null || !roleEntity.Valid || roleEntity.Id != base.Entity.Id) && (visionEntity == null || !visionEntity.Valid || visionEntity.Id != base.Entity.Id))
		{
			return;
		}
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x06018184 RID: 98692 RVA: 0x00739E38 File Offset: 0x00738038
	[NullableContext(2)]
	protected void OnVisionMorphEnd(EntityHandle roleEntity, EntityHandle visionEntity)
	{
		if ((roleEntity == null || !roleEntity.Valid || roleEntity.Id != base.Entity.Id) && (visionEntity == null || !visionEntity.Valid || visionEntity.Id != base.Entity.Id))
		{
			return;
		}
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x06018185 RID: 98693 RVA: 0x00739E94 File Offset: 0x00738094
	[NullableContext(2)]
	protected void OnTeleportComplete(TeleportContext teleportContext)
	{
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x06018186 RID: 98694 RVA: 0x00739E9C File Offset: 0x0073809C
	protected void OnWorldDone()
	{
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x06018187 RID: 98695 RVA: 0x00739EA4 File Offset: 0x007380A4
	protected void OnRoleGoUp()
	{
		this.ResetPlanarPhysWalking();
	}

	// Token: 0x06018188 RID: 98696 RVA: 0x00739EAC File Offset: 0x007380AC
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		base.OnInitData(args);
		this.ForceFallingSpeedCache = new ForceFallingSpeedCache();
		return true;
	}

	// Token: 0x06018189 RID: 98697 RVA: 0x00739EC4 File Offset: 0x007380C4
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

	// Token: 0x0601818A RID: 98698 RVA: 0x00739F14 File Offset: 0x00738114
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
		this.PredictMotionNeverCompensateCount = 0;
		for (int j = 0; j < CharacterMoveComponent.predictMotionNeverCompensateTag.Length; j++)
		{
			int num2 = CharacterMoveComponent.predictMotionNeverCompensateTag[j];
			if (this.TagComponent != null)
			{
				if (this.TagComponent.HasTag(num2))
				{
					this.PredictMotionNeverCompensateCount++;
				}
				this.PredictMotionNeverCompensateTasks.Add(this.TagComponent.ListenForTagAddOrRemove(new int?(num2), new BaseTagComponent.TTagSwitchedCallback(this.OnPredictMotionNeverCompensateTagsChanged), null));
			}
		}
		this.ApplyPredictMotionNeverCompensate();
		base.InitTraceInfo();
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.前闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag), null);
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.后闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag), null);
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中前闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag), null);
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中后闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag), null);
		this.TagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["功能.功能制作.开启空中步行状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnableWalkOnAirTag), null);
		this.InitInputMoveLimit();
		return base.OnStart();
	}

	// Token: 0x0601818B RID: 98699 RVA: 0x0073A54C File Offset: 0x0073874C
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
		for (int j = 0; j < this.PredictMotionNeverCompensateTasks.Count; j++)
		{
			this.PredictMotionNeverCompensateTasks[j].EndTask();
		}
		this.PredictMotionNeverCompensateTasks.Clear();
		this.PredictMotionNeverCompensateCount = 0;
		this.PredictMotionNeverCompensateExtraCount = 0;
		this.TagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.前闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag));
		this.TagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.后闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag));
		this.TagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中前闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag));
		this.TagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.闪避.空中后闪"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTag));
		this.IsKuroPlanarPhysWalkingEnableInternal = false;
		return true;
	}

	// Token: 0x0601818C RID: 98700 RVA: 0x0073A85C File Offset: 0x00738A5C
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

	// Token: 0x0601818D RID: 98701 RVA: 0x0073A924 File Offset: 0x00738B24
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

	// Token: 0x0601818E RID: 98702 RVA: 0x0073A9A1 File Offset: 0x00738BA1
	protected override void OnDisable(string reason)
	{
		this.DeltaTimeSeconds = 0f;
		if (this.GetWhirlpoolEnable())
		{
			this.EndWhirlpool("实体Disable");
		}
	}

	// Token: 0x0601818F RID: 98703 RVA: 0x0073A9C4 File Offset: 0x00738BC4
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
				if (!UeTickManageDefine.EnabledFacingUpdateOnAddMove)
				{
					this.UpdateFacing();
				}
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
			if (!UeTickManageDefine.EnabledFacingUpdateOnAddMove)
			{
				this.UpdateFacing();
			}
			base.CacheVar();
			return;
		}
		this.HasMoveInput = false;
	}

	// Token: 0x06018190 RID: 98704 RVA: 0x0073AE59 File Offset: 0x00739059
	protected bool ContainsTag(int tag)
	{
		BaseTagComponent tagComponent = this.TagComponent;
		return tagComponent != null && tagComponent.HasTag(tag);
	}

	// Token: 0x06018191 RID: 98705 RVA: 0x0073AE70 File Offset: 0x00739070
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

	// Token: 0x06018192 RID: 98706 RVA: 0x0073AEC0 File Offset: 0x007390C0
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

	// Token: 0x06018193 RID: 98707 RVA: 0x0073AF1C File Offset: 0x0073911C
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

	// Token: 0x06018194 RID: 98708 RVA: 0x0073B021 File Offset: 0x00739221
	public override bool CanWalkPress()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		return unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Ground;
	}

	// Token: 0x06018195 RID: 98709 RVA: 0x0073B038 File Offset: 0x00739238
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

	// Token: 0x06018196 RID: 98710 RVA: 0x0073B0EC File Offset: 0x007392EC
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

	// Token: 0x06018197 RID: 98711 RVA: 0x0073B154 File Offset: 0x00739354
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

	// Token: 0x06018198 RID: 98712 RVA: 0x0073B182 File Offset: 0x00739382
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

	// Token: 0x06018199 RID: 98713 RVA: 0x0073B1B0 File Offset: 0x007393B0
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

	// Token: 0x0601819A RID: 98714 RVA: 0x0073B360 File Offset: 0x00739560
	protected bool CheckInHit()
	{
		return this.TagComponent != null && (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击"]) || this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]));
	}

	// Token: 0x0601819B RID: 98715 RVA: 0x0073B3B0 File Offset: 0x007395B0
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

	// Token: 0x0601819C RID: 98716 RVA: 0x0073B590 File Offset: 0x00739790
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

	// Token: 0x0601819D RID: 98717 RVA: 0x0073B78C File Offset: 0x0073998C
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

	// Token: 0x0601819E RID: 98718 RVA: 0x0073B854 File Offset: 0x00739A54
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

	// Token: 0x0601819F RID: 98719 RVA: 0x0073B9AC File Offset: 0x00739BAC
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

	// Token: 0x060181A0 RID: 98720 RVA: 0x0073BA68 File Offset: 0x00739C68
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

	// Token: 0x060181A1 RID: 98721 RVA: 0x0073BB28 File Offset: 0x00739D28
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

	// Token: 0x060181A2 RID: 98722 RVA: 0x0073BB78 File Offset: 0x00739D78
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

	// Token: 0x060181A3 RID: 98723 RVA: 0x0073BC34 File Offset: 0x00739E34
	public int SetAddMoveSpeed(FVectorDouble speed, int? handler = null)
	{
		FRotator actorRotation = this.ActorComp.ActorRotation;
		FVector fvector = speed;
		FVector fvector2 = actorRotation.RotateVector(fvector);
		FVectorDouble value = fvector2;
		return base.SetAddMoveWorld(new FVectorDouble?(value), -1f, null, handler, null, global::EVelocityCurveType.None, 0f, 1f);
	}

	// Token: 0x060181A4 RID: 98724 RVA: 0x0073BC90 File Offset: 0x00739E90
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

	// Token: 0x060181A5 RID: 98725 RVA: 0x0073BD54 File Offset: 0x00739F54
	[NullableContext(2)]
	public int SetAddMove(FVectorDouble speed, float timeLength, UCurveFloat curve = null, int? handler = null, global::EVelocityCurveType? velocityCurveType = null, float? velocityCurveMin = null, float? velocityCurveMax = null)
	{
		FRotator actorRotation = this.ActorComp.ActorRotation;
		FVector fvector = speed;
		FVector fvector2 = actorRotation.RotateVector(fvector);
		FVectorDouble value = fvector2;
		return base.SetAddMoveWorld(new FVectorDouble?(value), timeLength, curve, handler, null, velocityCurveType.GetValueOrDefault(), velocityCurveMin.GetValueOrDefault(), velocityCurveMax.GetValueOrDefault(1f));
	}

	// Token: 0x060181A6 RID: 98726 RVA: 0x0073BDBC File Offset: 0x00739FBC
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

	// Token: 0x060181A7 RID: 98727 RVA: 0x0073BE80 File Offset: 0x0073A080
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

	// Token: 0x060181A8 RID: 98728 RVA: 0x0073BF38 File Offset: 0x0073A138
	public FVector GetLastUpdateVelocity()
	{
		return this.CharacterMovement.GetLastUpdateVelocity();
	}

	// Token: 0x170025B6 RID: 9654
	// (get) Token: 0x060181A9 RID: 98729 RVA: 0x0073BF45 File Offset: 0x0073A145
	public float CharacterWeight
	{
		get
		{
			return (float)((this.CreatureProperty != null) ? this.CreatureProperty.重量 : 0);
		}
	}

	// Token: 0x170025B7 RID: 9655
	// (get) Token: 0x060181AA RID: 98730 RVA: 0x0073BF64 File Offset: 0x0073A164
	public bool HasSwimmingBlock
	{
		get
		{
			return this.CharacterMovement.CustomMovementMode == 1 && this.CharacterMovement.Kuro_GetBlockDirectWhenMove().SizeSquared() > 0f;
		}
	}

	// Token: 0x060181AB RID: 98731 RVA: 0x0073BF9B File Offset: 0x0073A19B
	protected bool UpdateSkillRotation()
	{
		return !(!this.SkillComp) && (this.SkillComp.Active && this.SkillComp.UpdateAllSkillRotator(this.DeltaTimeSeconds));
	}

	// Token: 0x060181AC RID: 98732 RVA: 0x0073BFD0 File Offset: 0x0073A1D0
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

	// Token: 0x060181AD RID: 98733 RVA: 0x0073C104 File Offset: 0x0073A304
	public void GetUpdateFacingOffset(float deltaTime, Quat outQuat)
	{
		outQuat.Reset();
		float deltaTimeSeconds = this.DeltaTimeSeconds;
		bool captureFacingMode = this.CaptureFacingMode;
		this.DeltaTimeSeconds = deltaTime;
		this.CaptureFacingMode = true;
		this.HasCapturedFacing = false;
		this.ActorComp.ActorRotationProxy.Quaternion(this.FacingOffsetStartQuat);
		try
		{
			this.UpdateFacing();
		}
		finally
		{
			this.DeltaTimeSeconds = deltaTimeSeconds;
			this.CaptureFacingMode = captureFacingMode;
		}
		if (!this.HasCapturedFacing)
		{
			return;
		}
		this.CapturedFacingRotator.Quaternion(this.FacingOffsetTargetQuat);
		this.FacingOffsetStartQuat.Inverse(this.FacingOffsetStartInvQuat);
		this.FacingOffsetStartInvQuat.Multiply(this.FacingOffsetTargetQuat, outQuat);
	}

	// Token: 0x060181AE RID: 98734 RVA: 0x0073C1B8 File Offset: 0x0073A3B8
	protected override float SpeedScaled(float speed)
	{
		if (this.TimeScaleComp == null)
		{
			return speed;
		}
		return speed * this.TimeScaleComp.CurrentTimeScale * this.ActorComp.TimeDilation;
	}

	// Token: 0x060181AF RID: 98735 RVA: 0x0073C1DD File Offset: 0x0073A3DD
	public override bool CanMove()
	{
		return base.CanMove() && !this.ContainsTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]);
	}

	// Token: 0x060181B0 RID: 98736 RVA: 0x0073C204 File Offset: 0x0073A404
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

	// Token: 0x060181B1 RID: 98737 RVA: 0x0073C250 File Offset: 0x0073A450
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

	// Token: 0x060181B2 RID: 98738 RVA: 0x0073C2AC File Offset: 0x0073A4AC
	protected void OnPredictMotionNeverCompensateTagsChanged(int tagId, bool tagExist)
	{
		if (tagExist)
		{
			this.PredictMotionNeverCompensateCount++;
		}
		else
		{
			this.PredictMotionNeverCompensateCount--;
		}
		this.ApplyPredictMotionNeverCompensate();
	}

	// Token: 0x060181B3 RID: 98739 RVA: 0x0073C2D5 File Offset: 0x0073A4D5
	public void AddPredictMotionNeverCompensate()
	{
		this.PredictMotionNeverCompensateExtraCount++;
		this.ApplyPredictMotionNeverCompensate();
	}

	// Token: 0x060181B4 RID: 98740 RVA: 0x0073C2EB File Offset: 0x0073A4EB
	public void RemovePredictMotionNeverCompensate()
	{
		if (this.PredictMotionNeverCompensateExtraCount <= 0)
		{
			return;
		}
		this.PredictMotionNeverCompensateExtraCount--;
		this.ApplyPredictMotionNeverCompensate();
	}

	// Token: 0x060181B5 RID: 98741 RVA: 0x0073C30C File Offset: 0x0073A50C
	private void ApplyPredictMotionNeverCompensate()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		byte kuroPredictMotionMask = this.CharacterMovement.KuroPredictMotionMask;
		this.CharacterMovement.KuroPredictMotionMask = ((this.PredictMotionNeverCompensateCount + this.PredictMotionNeverCompensateExtraCount > 0) ? (kuroPredictMotionMask | 4) : ((byte)((int)kuroPredictMotionMask & -5)));
	}

	// Token: 0x060181B6 RID: 98742 RVA: 0x0073C354 File Offset: 0x0073A554
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

	// Token: 0x060181B7 RID: 98743 RVA: 0x0073C3AC File Offset: 0x0073A5AC
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

	// Token: 0x060181B8 RID: 98744 RVA: 0x0073C478 File Offset: 0x0073A678
	public void PlayerMotionRequest(MotionType type)
	{
		PlayerMotionRequest playerMotionRequest = Aki.Protocol.PlayerMotionRequest.Create();
		playerMotionRequest.Motion = type;
		Net.Instance.Call(ERequestMessageId.PlayerMotionRequest, playerMotionRequest, null, 0);
	}

	// Token: 0x060181B9 RID: 98745 RVA: 0x0073C4A4 File Offset: 0x0073A6A4
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

	// Token: 0x060181BA RID: 98746 RVA: 0x0073C538 File Offset: 0x0073A738
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

	// Token: 0x060181BB RID: 98747 RVA: 0x0073C64C File Offset: 0x0073A84C
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

	// Token: 0x060181BC RID: 98748 RVA: 0x0073C6F5 File Offset: 0x0073A8F5
	public bool GetWhirlpoolEnable()
	{
		return this.WhirlpoolPoint.GetEnable();
	}

	// Token: 0x060181BD RID: 98749 RVA: 0x0073C702 File Offset: 0x0073A902
	public bool GetWhirlpoolCancelByHit()
	{
		return this.WhirlpoolPoint.GetCancelByHit();
	}

	// Token: 0x060181BE RID: 98750 RVA: 0x0073C70F File Offset: 0x0073A90F
	public int GetWhirlpoolId()
	{
		return this.WhirlpoolPoint.GetId();
	}

	// Token: 0x060181BF RID: 98751 RVA: 0x0073C71C File Offset: 0x0073A91C
	public bool CompareWhirlpoolPriority(float moveTime)
	{
		return moveTime < this.WhirlpoolPoint.GetMoveTime();
	}

	// Token: 0x060181C0 RID: 98752 RVA: 0x0073C72C File Offset: 0x0073A92C
	public void UpdateWhirlpoolLocation(global::Vector location)
	{
		this.WhirlpoolPoint.UpdateLocation(location);
	}

	// Token: 0x060181C1 RID: 98753 RVA: 0x0073C73A File Offset: 0x0073A93A
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

	// Token: 0x060181C2 RID: 98754 RVA: 0x0073C778 File Offset: 0x0073A978
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

	// Token: 0x060181C3 RID: 98755 RVA: 0x0073C7B7 File Offset: 0x0073A9B7
	protected void SetStepUpParams()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.StepUpDeltaPrecent = 1f;
		this.CharacterMovement.StepUpStandardSpeed = 1f;
	}

	// Token: 0x060181C4 RID: 98756 RVA: 0x0073C7E2 File Offset: 0x0073A9E2
	protected void ResetStepUpParams()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.StepUpDeltaPrecent = this.InitStepUpPercent;
		this.CharacterMovement.StepUpStandardSpeed = this.InitStepUpStandardSpeed;
	}

	// Token: 0x060181C5 RID: 98757 RVA: 0x0073C80F File Offset: 0x0073AA0F
	public void SetStepHeight(float value)
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.MaxStepHeight = value;
	}

	// Token: 0x060181C6 RID: 98758 RVA: 0x0073C826 File Offset: 0x0073AA26
	public void ResetStepHeight()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.MaxStepHeight = this.InitMaxStepHeight;
	}

	// Token: 0x060181C7 RID: 98759 RVA: 0x0073C842 File Offset: 0x0073AA42
	public void SetWalkableFloorAngle(float value)
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.SetWalkableFloorAngle(value);
	}

	// Token: 0x060181C8 RID: 98760 RVA: 0x0073C859 File Offset: 0x0073AA59
	public void ResetWalkableFloorAngle()
	{
		if (this.CharacterMovement == null)
		{
			return;
		}
		this.CharacterMovement.SetWalkableFloorAngle(this.MovementData.WalkableFloorAngle);
	}

	// Token: 0x060181C9 RID: 98761 RVA: 0x0073C87A File Offset: 0x0073AA7A
	public void SetKuroPlanarPhysWalking(bool enable)
	{
		this.IsKuroPlanarPhysWalkingEnableInternal = enable;
		this.CharacterMovement.SetKuroPlanarPhysWalking(enable);
	}

	// Token: 0x060181CA RID: 98762 RVA: 0x0073C88F File Offset: 0x0073AA8F
	public void ResetPlanarPhysWalking()
	{
		this.CharacterMovement.bKuroPlanarNeedFindFloor = true;
	}

	// Token: 0x060181CB RID: 98763 RVA: 0x0073C8A0 File Offset: 0x0073AAA0
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

	// Token: 0x060181CC RID: 98764 RVA: 0x0073C8F0 File Offset: 0x0073AAF0
	public bool IsOnGroundOrOnWater()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		return (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Ground) || (this.CharacterMovement.MovementMode == EMovementMode.MOVE_Custom && this.CharacterMovement.CustomMovementMode == 5);
	}

	// Token: 0x060181CD RID: 98765 RVA: 0x0073C93F File Offset: 0x0073AB3F
	[Conditional("DEBUG")]
	private void UpdateKuroAsyncRootMotion()
	{
	}

	// Token: 0x060181CE RID: 98766 RVA: 0x0073C944 File Offset: 0x0073AB44
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

	// Token: 0x060181CF RID: 98767 RVA: 0x0073C990 File Offset: 0x0073AB90
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

	// Token: 0x060181D0 RID: 98768 RVA: 0x0073CA44 File Offset: 0x0073AC44
	private bool IsEnablePlanarPhysWalking()
	{
		return this.CheckPerformanceOptimizationCondition();
	}

	// Token: 0x060181D1 RID: 98769 RVA: 0x0073CA51 File Offset: 0x0073AC51
	private bool IsEnableAsyncRootMotion()
	{
		return CharacterMoveComponent.EnableKuroAsyncRootMotion && this.CheckPerformanceOptimizationCondition();
	}

	// Token: 0x060181D2 RID: 98770 RVA: 0x0073CA67 File Offset: 0x0073AC67
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

	// Token: 0x060181D3 RID: 98771 RVA: 0x0073CA98 File Offset: 0x0073AC98
	private void InitInputMoveLimit()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		if (UKuroStaticLibrary.IsObjectClassByName((animComp != null) ? animComp.MainAnimInstance : null, CharacterNameDefines.Instance.ABP_BASERUNANIMAL))
		{
			this.MaxMoveDegree = this.MovementData.CustomSetting00.Standing.ControllerRotationSpeedSetting.最大角度差;
		}
	}

	// Token: 0x060181D4 RID: 98772 RVA: 0x0073CAE8 File Offset: 0x0073ACE8
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

	// Token: 0x060181D5 RID: 98773 RVA: 0x0073CC00 File Offset: 0x0073AE00
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

	// Token: 0x060181D6 RID: 98774 RVA: 0x0073CC7C File Offset: 0x0073AE7C
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

	// Token: 0x060181D7 RID: 98775 RVA: 0x0073CD0B File Offset: 0x0073AF0B
	public new static void CreateStaticDefaultValue()
	{
		BaseMoveComponent.CreateStaticDefaultValue();
		CharacterMoveComponent.EnableKuroAsyncRootMotionInternal = true;
	}

	// Token: 0x060181D8 RID: 98776 RVA: 0x0073CD18 File Offset: 0x0073AF18
	public new static void ResetStaticDefaultValue()
	{
		BaseMoveComponent.ResetStaticDefaultValue();
		CharacterMoveComponent.EnableKuroAsyncRootMotionInternal = false;
		BaseMoveComponent.BaseMoveInheritCurveInternal = null;
	}

	// Token: 0x060181D9 RID: 98777 RVA: 0x0073CD2C File Offset: 0x0073AF2C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterMoveComponent characterMoveComponent = (CharacterMoveComponent)componentTemplate;
		if (characterMoveComponent.GlideComp == null)
		{
			this.GlideComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GlideComp), "GlideComp"))
		{
			return false;
		}
		if (characterMoveComponent.SwimComp == null)
		{
			this.SwimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SwimComp), "SwimComp"))
		{
			return false;
		}
		if (characterMoveComponent.WalkOnWaterComp == null)
		{
			this.WalkOnWaterComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WalkOnWaterComp), "WalkOnWaterComp"))
		{
			return false;
		}
		if (characterMoveComponent.FloatingComp == null)
		{
			this.FloatingComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FloatingComp), "FloatingComp"))
		{
			return false;
		}
		if (characterMoveComponent.ForceFallingSpeedCache == null)
		{
			this.ForceFallingSpeedCache = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForceFallingSpeedCache), "ForceFallingSpeedCache"))
		{
			return false;
		}
		if (characterMoveComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		this.LastGlidingControlTime = characterMoveComponent.LastGlidingControlTime;
		if (characterMoveComponent.AttributeComponent == null)
		{
			this.AttributeComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeComponent), "AttributeComponent"))
		{
			return false;
		}
		if (characterMoveComponent.TagComponent == null)
		{
			this.TagComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
		{
			return false;
		}
		if (characterMoveComponent.DeathComponent == null)
		{
			this.DeathComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DeathComponent), "DeathComponent"))
		{
			return false;
		}
		this.AirInertiaHandler = characterMoveComponent.AirInertiaHandler;
		if (characterMoveComponent.CanResponseInputTasks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CanResponseInputTasks), "CanResponseInputTasks"))
		{
			return false;
		}
		if (characterMoveComponent.PredictMotionNeverCompensateTasks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PredictMotionNeverCompensateTasks), "PredictMotionNeverCompensateTasks"))
		{
			return false;
		}
		this.PredictMotionNeverCompensateCount = characterMoveComponent.PredictMotionNeverCompensateCount;
		this.PredictMotionNeverCompensateExtraCount = characterMoveComponent.PredictMotionNeverCompensateExtraCount;
		this.LastJumpTime = characterMoveComponent.LastJumpTime;
		this.TryGlideTime = characterMoveComponent.TryGlideTime;
		if (characterMoveComponent.WhirlpoolPoint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.WhirlpoolPoint), "WhirlpoolPoint"))
		{
			return false;
		}
		this.IsKuroPlanarPhysWalkingEnableInternal = characterMoveComponent.IsKuroPlanarPhysWalkingEnableInternal;
		this.IsKuroAsyncRootMotionEnable = characterMoveComponent.IsKuroAsyncRootMotionEnable;
		this.OverrideMaxFallingSpeed = characterMoveComponent.OverrideMaxFallingSpeed;
		this.GroundedFrame = characterMoveComponent.GroundedFrame;
		if (characterMoveComponent.SlideTrans == null)
		{
			this.SlideTrans = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SlideTrans), "SlideTrans"))
		{
			return false;
		}
		if (characterMoveComponent.FacingOffsetStartQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FacingOffsetStartQuat), "FacingOffsetStartQuat"))
		{
			return false;
		}
		if (characterMoveComponent.FacingOffsetStartInvQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FacingOffsetStartInvQuat), "FacingOffsetStartInvQuat"))
		{
			return false;
		}
		if (characterMoveComponent.FacingOffsetTargetQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FacingOffsetTargetQuat), "FacingOffsetTargetQuat"))
		{
			return false;
		}
		this.StepUpOffCount = characterMoveComponent.StepUpOffCount;
		this.InitMaxStepHeight = characterMoveComponent.InitMaxStepHeight;
		this.InitStepUpPercent = characterMoveComponent.InitStepUpPercent;
		this.InitStepUpStandardSpeed = characterMoveComponent.InitStepUpStandardSpeed;
		this.PerfConditionCachedInstanceId = characterMoveComponent.PerfConditionCachedInstanceId;
		this.PerfConditionCachedSubType = characterMoveComponent.PerfConditionCachedSubType;
		return true;
	}

	// Token: 0x170025B8 RID: 9656
	// (get) Token: 0x060181DA RID: 98778 RVA: 0x0073D086 File Offset: 0x0073B286
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025B9 RID: 9657
	// (get) Token: 0x060181DB RID: 98779 RVA: 0x0073D089 File Offset: 0x0073B289
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025BA RID: 9658
	// (get) Token: 0x060181DC RID: 98780 RVA: 0x0073D08C File Offset: 0x0073B28C
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025BB RID: 9659
	// (get) Token: 0x060181DD RID: 98781 RVA: 0x0073D08F File Offset: 0x0073B28F
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025BC RID: 9660
	// (get) Token: 0x060181DE RID: 98782 RVA: 0x0073D092 File Offset: 0x0073B292
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025BD RID: 9661
	// (get) Token: 0x060181DF RID: 98783 RVA: 0x0073D095 File Offset: 0x0073B295
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025BE RID: 9662
	// (get) Token: 0x060181E0 RID: 98784 RVA: 0x0073D098 File Offset: 0x0073B298
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CF08 RID: 53000
	private const int MIN_MOVE_SPEED = 20;

	// Token: 0x0400CF09 RID: 53001
	private const float GLIDING_CONTROL_OFFSET = 0.3f;

	// Token: 0x0400CF0A RID: 53002
	public const int GLIDING_HEIGHT_THREDHOLD = 250;

	// Token: 0x0400CF0B RID: 53003
	private const int MAX_IN_WATER_SPEED = 800;

	// Token: 0x0400CF0C RID: 53004
	public const int GLIDE_STRENGTH_THREADHOLD = 10;

	// Token: 0x0400CF0D RID: 53005
	private const int SQUARE_MAX_INHERIT_SPEED = 1000000;

	// Token: 0x0400CF0E RID: 53006
	[StaticVariableRuleIgnore]
	private static readonly int[] cannotResponseInputTag = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"],
		GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]
	};

	// Token: 0x0400CF0F RID: 53007
	[StaticVariableRuleIgnore]
	private static readonly int[] predictMotionNeverCompensateTag = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"],
		GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.逻辑.强制更新移动"]
	};

	// Token: 0x0400CF10 RID: 53008
	private const byte PREDICT_MOTION_NEVER_COMPENSATE_MASK = 4;

	// Token: 0x0400CF11 RID: 53009
	private const int JUMP_FRAME_COUNT = 3;

	// Token: 0x0400CF12 RID: 53010
	private const int SLIDE_JUMP_LERP_TIME = 100;

	// Token: 0x0400CF13 RID: 53011
	private const int SLIDE_JUMP_SPEED = 900;

	// Token: 0x0400CF14 RID: 53012
	private const float OVER_VELOCITY_PERCENT = 1.01f;

	// Token: 0x0400CF15 RID: 53013
	private const float BASE_MOVE_INHERIT_TIME = 1.5f;

	// Token: 0x0400CF16 RID: 53014
	private const int TRY_GLIDE_TIME = 500;

	// Token: 0x0400CF17 RID: 53015
	private const int MAX_WALK_FLOOR_ANGLE = 55;

	// Token: 0x0400CF18 RID: 53016
	private const int DEFAULT_MAX_STEP_HEIGHT = 45;

	// Token: 0x0400CF19 RID: 53017
	private const float DEFAULT_STEP_UP_PERCENT = 0.08f;

	// Token: 0x0400CF1A RID: 53018
	private const int DEFAULT_STEP_UP_STANDARD_SPEED = 400;

	// Token: 0x0400CF1B RID: 53019
	private static bool EnableKuroAsyncRootMotionInternal;

	// Token: 0x0400CF1C RID: 53020
	[Nullable(2)]
	protected CharacterGlideComponent GlideComp;

	// Token: 0x0400CF1D RID: 53021
	[Nullable(2)]
	protected CharacterSwimComponent SwimComp;

	// Token: 0x0400CF1E RID: 53022
	[Nullable(2)]
	protected CharacterWalkOnWaterComponent WalkOnWaterComp;

	// Token: 0x0400CF1F RID: 53023
	[Nullable(2)]
	protected CharacterFloatingComponent FloatingComp;

	// Token: 0x0400CF20 RID: 53024
	[Nullable(2)]
	public ForceFallingSpeedCache ForceFallingSpeedCache;

	// Token: 0x0400CF21 RID: 53025
	[Nullable(2)]
	protected CharacterSkillComponent SkillComp;

	// Token: 0x0400CF22 RID: 53026
	protected double LastGlidingControlTime;

	// Token: 0x0400CF23 RID: 53027
	[Nullable(2)]
	protected BaseAttributeComponent AttributeComponent;

	// Token: 0x0400CF24 RID: 53028
	[Nullable(2)]
	protected BaseTagComponent TagComponent;

	// Token: 0x0400CF25 RID: 53029
	[Nullable(2)]
	protected BaseDeathComponent DeathComponent;

	// Token: 0x0400CF26 RID: 53030
	protected int AirInertiaHandler;

	// Token: 0x0400CF27 RID: 53031
	protected readonly List<ITagTask> CanResponseInputTasks = new List<ITagTask>();

	// Token: 0x0400CF28 RID: 53032
	private readonly List<ITagTask> PredictMotionNeverCompensateTasks = new List<ITagTask>();

	// Token: 0x0400CF29 RID: 53033
	private int PredictMotionNeverCompensateCount;

	// Token: 0x0400CF2A RID: 53034
	private int PredictMotionNeverCompensateExtraCount;

	// Token: 0x0400CF2B RID: 53035
	public double LastJumpTime;

	// Token: 0x0400CF2C RID: 53036
	protected double TryGlideTime;

	// Token: 0x0400CF2D RID: 53037
	private readonly WhirlpoolPoint WhirlpoolPoint = new WhirlpoolPoint();

	// Token: 0x0400CF2E RID: 53038
	private bool IsKuroPlanarPhysWalkingEnableInternal;

	// Token: 0x0400CF2F RID: 53039
	private bool IsKuroAsyncRootMotionEnable;

	// Token: 0x0400CF30 RID: 53040
	private float OverrideMaxFallingSpeed;

	// Token: 0x0400CF31 RID: 53041
	protected int GroundedFrame;

	// Token: 0x0400CF32 RID: 53042
	[StaticVariableRuleIgnore]
	protected static readonly global::Vector TempVelocity = global::Vector.Create();

	// Token: 0x0400CF33 RID: 53043
	[Nullable(2)]
	protected global::Transform SlideTrans;

	// Token: 0x0400CF34 RID: 53044
	private readonly Quat FacingOffsetStartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CF35 RID: 53045
	private readonly Quat FacingOffsetStartInvQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CF36 RID: 53046
	private readonly Quat FacingOffsetTargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CF37 RID: 53047
	private int StepUpOffCount;

	// Token: 0x0400CF38 RID: 53048
	protected float InitMaxStepHeight = 45f;

	// Token: 0x0400CF39 RID: 53049
	protected float InitStepUpPercent = 0.08f;

	// Token: 0x0400CF3A RID: 53050
	protected float InitStepUpStandardSpeed = 400f;

	// Token: 0x0400CF3B RID: 53051
	private int PerfConditionCachedInstanceId = int.MinValue;

	// Token: 0x0400CF3C RID: 53052
	private EDungeonSubType? PerfConditionCachedSubType;
}
