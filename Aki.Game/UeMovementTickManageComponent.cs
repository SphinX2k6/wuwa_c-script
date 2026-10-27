using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x0200327F RID: 12927
[NullableContext(1)]
[Nullable(0)]
public class UeMovementTickManageComponent : EntityComponent, IUeMovementComp
{
	// Token: 0x1700269B RID: 9883
	// (get) Token: 0x0601BF80 RID: 114560 RVA: 0x007C40B3 File Offset: 0x007C22B3
	public new static Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent)
			};
		}
	}

	// Token: 0x1700269C RID: 9884
	// (get) Token: 0x0601BF81 RID: 114561 RVA: 0x007C40C8 File Offset: 0x007C22C8
	// (set) Token: 0x0601BF82 RID: 114562 RVA: 0x007C40D0 File Offset: 0x007C22D0
	[Nullable(2)]
	public UeSkeletalTickManageComponent SkelTickMgr { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700269D RID: 9885
	// (get) Token: 0x0601BF83 RID: 114563 RVA: 0x007C40D9 File Offset: 0x007C22D9
	// (set) Token: 0x0601BF84 RID: 114564 RVA: 0x007C40E4 File Offset: 0x007C22E4
	public EMovementTickMode TickMode
	{
		get
		{
			return this.TickModeInternal;
		}
		protected set
		{
			if (this.TickModeInternal == value)
			{
				return;
			}
			EMovementTickMode tickModeInternal = this.TickModeInternal;
			this.TickModeInternal = value;
			switch (tickModeInternal)
			{
			case EMovementTickMode.TsProxy:
				UeMovementTickController.DeleteManager(this, 0);
				TickSystem.Instance.CleanMovementProxyTickFunction(this.MoveComponent);
				if (value != EMovementTickMode.TsProxyNotParallel)
				{
					this.ProxyTickCount = 0;
					this.ProxyTickDelta = 0f;
				}
				break;
			case EMovementTickMode.UeUpdate:
				this.MoveComponent.SetKuroOnlyTickOutside(true);
				this.MoveComponent.SetComponentTickEnabled(false);
				break;
			case EMovementTickMode.TsProxyNotParallel:
				UeMovementTickController.DeleteManager(this, 0);
				break;
			}
			switch (value)
			{
			case EMovementTickMode.TsProxy:
				UeMovementTickController.AddManager(this, 0);
				TickSystem.Instance.SetMovementProxyTickFunction(ETickingGroup.TG_PrePhysics, this.MoveComponent, 1);
				return;
			case EMovementTickMode.TsTakeOver:
				break;
			case EMovementTickMode.UeUpdate:
				this.MoveComponent.SetKuroOnlyTickOutside(false);
				this.MoveComponent.SetComponentTickEnabled(true);
				return;
			case EMovementTickMode.TsProxyNotParallel:
				UeMovementTickController.AddManager(this, 0);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x1700269E RID: 9886
	// (get) Token: 0x0601BF85 RID: 114565 RVA: 0x007C41C6 File Offset: 0x007C23C6
	// (set) Token: 0x0601BF86 RID: 114566 RVA: 0x007C41CE File Offset: 0x007C23CE
	protected bool ForbiddenTickPose
	{
		get
		{
			return this.ForbiddenTickPoseInternal;
		}
		set
		{
			if (this.ForbiddenTickPoseInternal == value)
			{
				return;
			}
			this.ForbiddenTickPoseInternal = value;
			this.MoveComponent.bForbiddenTickPose = value;
		}
	}

	// Token: 0x1700269F RID: 9887
	// (get) Token: 0x0601BF87 RID: 114567 RVA: 0x007C41ED File Offset: 0x007C23ED
	// (set) Token: 0x0601BF88 RID: 114568 RVA: 0x007C41F5 File Offset: 0x007C23F5
	public bool TeleportLock
	{
		get
		{
			return this.TeleportLockInternal;
		}
		set
		{
			if (this.TeleportLockInternal == value)
			{
				return;
			}
			this.TeleportLockInternal = value;
			this.ActorComp.SetActorVelocity(Vector.ZeroVectorProxy);
		}
	}

	// Token: 0x0601BF89 RID: 114569 RVA: 0x007C4218 File Offset: 0x007C2418
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.CharacterMoveComp = base.Entity.GetComponent<BaseMoveComponent>();
		this.VehiclePerformComp = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		this.MoveComponent = (this.ActorComp.Owner.GetComponentByClass(UCharacterMovementComponent.StaticClass()) as UCharacterMovementComponent);
		if (this.MoveComponent == null)
		{
			return false;
		}
		this.DebugComp = base.Entity.GetComponent<ActorDebugMovementComponent>();
		this.SkelTickMgr = base.Entity.GetComponent<UeSkeletalTickManageComponent>();
		this.MoveComponent.SetKuroOnlyTickOutside(true);
		this.MoveComponent.SetComponentTickEnabled(false);
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.ForbiddenTickPose = (base.Entity.GetTickInterval() > 1 || UeSkeletalTickController.EnabledNewSkelTickTiming);
		this.DebugLastTickFrame = (long)Time.Instance.Frame;
		this.TeleportLockInternal = false;
		this.TickMode = (UeMovementTickController.EnabledMovementParallel ? EMovementTickMode.TsProxy : EMovementTickMode.TsTakeOver);
		if (SundryModel.Instance.RoleFallingDebugLogOn && this.ActorComp.IsRoleAndCtrlByMe)
		{
			this.SetVelocityInfoCacheEnable(true);
		}
		this.UroParams = new FAnimUpdateRateParameters();
		return true;
	}

	// Token: 0x0601BF8A RID: 114570 RVA: 0x007C4343 File Offset: 0x007C2543
	protected override bool OnEnd()
	{
		this.TickMode = EMovementTickMode.None;
		this.OldMeshTransform = null;
		return true;
	}

	// Token: 0x0601BF8B RID: 114571 RVA: 0x007C435C File Offset: 0x007C255C
	protected unsafe override void OnDisable(string reason)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (((actorComp != null) ? actorComp.Actor : null) != null)
		{
			this.ActorComp.Actor.BasedMovement.MovementBase = null;
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 != null && actorComp2.IsRoleAndCtrlByMe)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "UeMovementTickManageComponent Disable";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DisableInfo", base.DumpDisableInfo());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0601BF8C RID: 114572 RVA: 0x007C4410 File Offset: 0x007C2610
	protected override void OnEnable()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "UeMovementTickManageComponent Enable";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.DebugLastTickFrame = (long)Time.Instance.Frame;
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp == null)
		{
			return;
		}
		animComp.ConsumeRootMotion();
	}

	// Token: 0x0601BF8D RID: 114573 RVA: 0x007C4488 File Offset: 0x007C2688
	protected override void OnTick(float delta)
	{
		if (this.TickMode != EMovementTickMode.TsTakeOver)
		{
			return;
		}
		this.TickMovement(delta);
		this.ResetCachedTransformAndSetModelBuffer();
		if (UeMovementTickController.EnabledMovementParallel)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			bool flag;
			if (actorComp == null)
			{
				flag = false;
			}
			else
			{
				AActor attachRootParentActor = actorComp.Actor.GetAttachRootParentActor();
				flag = ((attachRootParentActor != null) ? new bool?(attachRootParentActor.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				this.TickMode = EMovementTickMode.TsProxyNotParallel;
				return;
			}
			this.TickMode = EMovementTickMode.TsProxy;
		}
	}

	// Token: 0x0601BF8E RID: 114574 RVA: 0x007C44FC File Offset: 0x007C26FC
	public bool CanTickDefault()
	{
		return base.Active;
	}

	// Token: 0x0601BF8F RID: 114575 RVA: 0x007C4504 File Offset: 0x007C2704
	public bool CanTickWithDistance()
	{
		if (this.CharacterMoveComp != null)
		{
			return base.Active && this.CharacterMoveComp.CanMoveWithDistance();
		}
		return base.Active;
	}

	// Token: 0x0601BF90 RID: 114576 RVA: 0x007C452C File Offset: 0x007C272C
	public void PreProxyTick(float delta)
	{
		this.ProxyTickCount++;
		this.ProxyTickDelta += base.Entity.TimeDilation * delta;
		if (this.ProxyTickCount >= base.Entity.GetTickInterval())
		{
			this.TickMovement(this.ProxyTickDelta);
		}
	}

	// Token: 0x0601BF91 RID: 114577 RVA: 0x007C4580 File Offset: 0x007C2780
	public void ProxyTick()
	{
		if (this.ProxyTickCount >= base.Entity.GetTickInterval())
		{
			this.ResetCachedTransformAndSetModelBuffer();
			this.ProxyTickCount = 0;
			this.ProxyTickDelta = 0f;
		}
		if (!UeMovementTickController.EnabledMovementParallel)
		{
			this.TickMode = EMovementTickMode.TsTakeOver;
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		bool flag;
		if (actorComp == null)
		{
			flag = false;
		}
		else
		{
			AActor attachRootParentActor = actorComp.Actor.GetAttachRootParentActor();
			flag = ((attachRootParentActor != null) ? new bool?(attachRootParentActor.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			this.TickMode = EMovementTickMode.TsProxyNotParallel;
			return;
		}
		this.TickMode = EMovementTickMode.TsProxy;
	}

	// Token: 0x0601BF92 RID: 114578 RVA: 0x007C4610 File Offset: 0x007C2810
	protected void TickMovement(float delta)
	{
		this.HasMove = false;
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.LastActorLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 != null)
		{
			actorComp2.LastActorRotation.DeepCopy(this.ActorComp.ActorRotationProxy);
		}
		this.CheckTickFrame();
		if (this.MoveComponent == null || this.TeleportLock)
		{
			return;
		}
		if (WorldController.Instance.GetIsWorldOriginInUiMode() && this.MoveComponent.MovementMode != EMovementMode.MOVE_Falling)
		{
			return;
		}
		CharacterActorComponent actorComp3 = this.ActorComp;
		if (((actorComp3 != null) ? actorComp3.Actor.GetAttachRootParentActor() : null) != null)
		{
			BaseMoveComponent characterMoveComp = this.CharacterMoveComp;
			if (characterMoveComp == null || !characterMoveComp.NeedRootMotionWhenAttached)
			{
				return;
			}
		}
		if (this.DebugComp != null)
		{
			this.DebugComp.MarkDebugRecord("移动组件更新前 ", null, true);
		}
		if (this.VehiclePerformComp != null)
		{
			foreach (VehiclePassengerInfo vehiclePassengerInfo in this.VehiclePerformComp.PassengerInfoMap.Values)
			{
				Entity passengerEntity = vehiclePassengerInfo.PassengerEntity;
				ActorDebugMovementComponent actorDebugMovementComponent = (passengerEntity != null) ? passengerEntity.GetComponent<ActorDebugMovementComponent>() : null;
				if (actorDebugMovementComponent != null)
				{
					actorDebugMovementComponent.MarkDebugRecord("载具移动组件更新前", null, true);
				}
			}
		}
		this.CharacterMoveComp.ConsumeForceFallingSpeed();
		PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
		float num = (component != null) ? component.CurrentTimeScale : 1f;
		BaseMoveComponent characterMoveComp2 = this.CharacterMoveComp;
		if (characterMoveComp2 == null || !characterMoveComp2.NeedRootMotionWhenAttached)
		{
			BaseMoveComponent characterMoveComp3 = this.CharacterMoveComp;
			if (characterMoveComp3 != null && characterMoveComp3.IsSpecialMove)
			{
				goto IL_43D;
			}
		}
		if (this.CharacterMoveComp != null)
		{
			this.CharacterMoveComp.GetAndConsumeAddMove(delta * 0.001f * num, UeMovementTickManageComponent.TmpVector, UeMovementTickManageComponent.TmpRotator);
			if (!UeMovementTickManageComponent.TmpVector.IsNearlyZero(9.999999747378752E-05))
			{
				if (this.MoveComponent.MovementMode == EMovementMode.MOVE_Falling)
				{
					this.ActorComp.AddActorWorldOffset(UeMovementTickManageComponent.TmpVector.ToUeVector(false), "AddMove", true);
				}
				else
				{
					this.MoveComponent.SetAddMove(UeMovementTickManageComponent.TmpVector.ToUeVector(false));
				}
			}
			if (!UeMovementTickManageComponent.TmpRotator.IsNearlyZero())
			{
				CharacterActorComponent actorComp4 = this.ActorComp;
				if (actorComp4 != null)
				{
					actorComp4.AddActorLocalRotation(UeMovementTickManageComponent.TmpRotator.ToUeRotator(), "叠加旋转", false);
				}
			}
		}
		bool flag = base.Entity.GetTickInterval() > 1;
		this.ForbiddenTickPose = (flag || this.Frozen || UeSkeletalTickController.EnabledNewSkelTickTiming);
		this.ModelBufferTimeLength = 0f;
		CharacterAnimationComponent animComp = this.AnimComp;
		USkeletalMeshComponent uskeletalMeshComponent;
		if (animComp == null)
		{
			uskeletalMeshComponent = null;
		}
		else
		{
			TsBaseCharacter actor = animComp.Actor;
			uskeletalMeshComponent = ((actor != null) ? actor.Mesh : null);
		}
		USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
		if (uskeletalMeshComponent2 != null && uskeletalMeshComponent2.bEnableUpdateRateOptimizations)
		{
			CharacterAnimationComponent animComp2 = this.AnimComp;
			bool flag2;
			if (animComp2 == null)
			{
				flag2 = false;
			}
			else
			{
				UAnimInstance mainAnimInstance = animComp2.MainAnimInstance;
				flag2 = ((mainAnimInstance != null) ? new bool?(mainAnimInstance.HasKuroRootMotionAnim()) : null).GetValueOrDefault();
			}
			if (flag2)
			{
				BaseMoveComponent characterMoveComp4 = this.CharacterMoveComp;
				if (((characterMoveComp4 != null) ? characterMoveComp4.BasePlatform : null) == null)
				{
					uskeletalMeshComponent2.GetAnimUpdateRateParameters(ref this.UroParams);
					if (!this.UroParams.bSkipUpdate && this.UroParams.UpdateRate > base.Entity.GetTickInterval())
					{
						this.ModelBufferTimeLength = (float)this.UroParams.UpdateRate * delta * CharacterModel.Instance.InverseSelfCenteredTimeDilation / (float)Math.Max(1, base.Entity.GetTickInterval());
					}
				}
			}
		}
		if (flag)
		{
			CharacterAnimationComponent animComp3 = this.AnimComp;
			if (animComp3 != null && animComp3.Valid && this.ActorComp.Owner.WasRecentlyRenderedOnScreen(0.2f))
			{
				this.ModelBufferTimeLength = Math.Max(delta * CharacterModel.Instance.InverseSelfCenteredTimeDilation, this.ModelBufferTimeLength);
			}
		}
		if (this.ModelBufferTimeLength <= 10f || this.AnimComp == null)
		{
			this.MoveComponent.KuroTickComponentOutside(delta * 0.001f * num);
		}
		else
		{
			this.OldMeshTransform = new FTransformDouble?(this.AnimComp.GetMeshTransform());
			this.OldActorLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.OldActorRotator.DeepCopy(this.ActorComp.ActorRotationProxy);
			this.MoveComponent.KuroTickComponentOutside(delta * 0.001f * num);
			this.ActorComp.ResetAllCachedTime();
		}
		IL_43D:
		this.HasMove = true;
	}

	// Token: 0x0601BF93 RID: 114579 RVA: 0x007C4A74 File Offset: 0x007C2C74
	protected void ResetCachedTransformAndSetModelBuffer()
	{
		this.CacheVelocityInfo("AfterTickMovement");
		this.UpdateVelocityCache();
		if (!this.HasMove)
		{
			return;
		}
		BaseMoveComponent characterMoveComp = this.CharacterMoveComp;
		if (characterMoveComp == null || !characterMoveComp.IsSpecialMove)
		{
			this.ActorComp.ResetAllCachedTime();
		}
		if (this.OldMeshTransform != null && this.ModelBufferTimeLength >= 10f && (!this.OldActorLocation.Equals(this.ActorComp.ActorLocationProxy, 9.999999747378752E-05) || !this.OldActorRotator.Equals(this.ActorComp.ActorRotationProxy, 0.0001f)))
		{
			this.AnimComp.SetModelBuffer(this.OldMeshTransform.Value, this.ModelBufferTimeLength);
			this.OldMeshTransform = null;
		}
		this.CharacterMoveComp.ApplyForceSpeedAndRecordSpeed();
		if (this.DebugComp != null)
		{
			this.DebugComp.MarkDebugRecord("移动组件更新后", null, true);
		}
		if (this.VehiclePerformComp != null)
		{
			foreach (VehiclePassengerInfo vehiclePassengerInfo in this.VehiclePerformComp.PassengerInfoMap.Values)
			{
				Entity passengerEntity = vehiclePassengerInfo.PassengerEntity;
				ActorDebugMovementComponent actorDebugMovementComponent = (passengerEntity != null) ? passengerEntity.GetComponent<ActorDebugMovementComponent>() : null;
				Entity passengerEntity2 = vehiclePassengerInfo.PassengerEntity;
				BaseActorComponent baseActorComponent = (passengerEntity2 != null) ? passengerEntity2.GetComponent<BaseActorComponent>() : null;
				if (baseActorComponent != null)
				{
					baseActorComponent.ResetAllCachedTime();
				}
				if (actorDebugMovementComponent != null)
				{
					actorDebugMovementComponent.MarkDebugRecord("载具移动组件更新后", null, true);
				}
			}
		}
		if (this.FixFacingForVelocity)
		{
			this.FixFacingForVelocity = false;
			MathUtils.Instance.CommonTempVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
			if (MathUtils.Instance.CommonTempVector.Normalize(9.99999993922529E-09))
			{
				this.ActorComp.SetInputFacing(MathUtils.Instance.CommonTempVector, true);
				this.ActorComp.SetOverrideTurnSpeed(new float?(this.FixFacingTurnSpeed));
			}
		}
	}

	// Token: 0x0601BF94 RID: 114580 RVA: 0x007C4C78 File Offset: 0x007C2E78
	private unsafe void CheckTickFrame()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.IsRoleAndCtrlByMe && (long)Time.Instance.Frame - this.DebugLastTickFrame > 1L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "[b1057126] 角色更新异常";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DebugLastTickFrame", this.DebugLastTickFrame);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Current", Time.Instance.Frame);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.DebugLastTickFrame = (long)Time.Instance.Frame;
	}

	// Token: 0x0601BF95 RID: 114581 RVA: 0x007C4D2D File Offset: 0x007C2F2D
	public override void OnEntityBudgetTickEnableChange(bool isEnable)
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null && animComp.Valid && isEnable)
		{
			this.AnimComp.ConsumeRootMotion();
		}
	}

	// Token: 0x0601BF96 RID: 114582 RVA: 0x007C4D50 File Offset: 0x007C2F50
	public void EnableFixFacingForVelocityOneFrame(bool enable, float? turnSpeed)
	{
		if (this.FixFacingForVelocity == enable)
		{
			return;
		}
		this.FixFacingForVelocity = enable;
		float? num = turnSpeed;
		float valueOrDefault;
		if (num == null)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			valueOrDefault = ((actorComp != null) ? actorComp.OverrideTurnSpeed : null).GetValueOrDefault(180f);
		}
		else
		{
			valueOrDefault = num.GetValueOrDefault();
		}
		this.FixFacingTurnSpeed = valueOrDefault;
	}

	// Token: 0x0601BF97 RID: 114583 RVA: 0x007C4DB0 File Offset: 0x007C2FB0
	public void SetVelocityInfoCacheEnable(bool enable)
	{
		if (this.EnableVelocityInfoCache == enable)
		{
			return;
		}
		this.ActorComp.Actor.CharacterMovement.bKuroVelocityDebug = enable;
		this.ActorComp.Actor.Mesh.bRootMotionDebug = enable;
		this.EnableVelocityInfoCache = enable;
		this.VelocityInfoCacheArray.Clear();
		this.FrameCounter = 0;
	}

	// Token: 0x0601BF98 RID: 114584 RVA: 0x007C4E0C File Offset: 0x007C300C
	public void UpdateVelocityCache()
	{
		if (!this.EnableVelocityInfoCache)
		{
			return;
		}
		while (this.FrameCounter > this.VelocityInfoFrameSize)
		{
			long? num = null;
			if (this.VelocityInfoCacheArray.Count > 0)
			{
				VelocityCacheInfo velocityCacheInfo = this.VelocityInfoCacheArray[0];
				num = ((velocityCacheInfo != null) ? new long?(velocityCacheInfo.Frame) : null);
				this.VelocityInfoCacheArray.RemoveAt(0);
			}
			while (this.VelocityInfoCacheArray.Count != 0)
			{
				long? num2 = num;
				long num3 = this.LastFrame;
				if (num2.GetValueOrDefault() == num3 & num2 != null)
				{
					break;
				}
				num2 = num;
				num3 = this.VelocityInfoCacheArray[0].Frame;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					break;
				}
				this.VelocityInfoCacheArray.RemoveAt(0);
			}
			this.FrameCounter--;
		}
	}

	// Token: 0x0601BF99 RID: 114585 RVA: 0x007C4EEC File Offset: 0x007C30EC
	public void CacheVelocityInfo(string context)
	{
		if (!this.EnableVelocityInfoCache)
		{
			return;
		}
		VelocityCacheInfo velocityCacheInfo = new VelocityCacheInfo();
		velocityCacheInfo.Frame = UKismetSystemLibrary.GetFrameCount();
		velocityCacheInfo.SpeedZ = new float?((float)GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.ActorComp.ActorVelocityProxy));
		velocityCacheInfo.MoveMode = new EMovementMode?(this.ActorComp.Actor.CharacterMovement.MovementMode);
		Vector tmpVectorField = this.TmpVectorField;
		FVector fvector = this.ActorComp.Actor.CharacterMovement.Velocity;
		tmpVectorField.FromUeVector(fvector);
		velocityCacheInfo.VelocityZ = new float?((float)GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TmpVectorField));
		Vector tmpVectorField2 = this.TmpVectorField;
		fvector = this.ActorComp.Actor.CharacterMovement.GetLastUpdateVelocity();
		tmpVectorField2.FromUeVector(fvector);
		velocityCacheInfo.LastZ = new float?((float)GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TmpVectorField));
		velocityCacheInfo.Context = context;
		long frameCount = UKismetSystemLibrary.GetFrameCount();
		this.VelocityInfoCacheArray.Add(velocityCacheInfo);
		this.FrameCounter += ((this.LastFrame != frameCount) ? 1 : 0);
		this.LastFrame = frameCount;
	}

	// Token: 0x0601BF9A RID: 114586 RVA: 0x007C5024 File Offset: 0x007C3224
	public unsafe void DumpVelocityCacheInfo(string reason = "", bool onlyLast = false)
	{
		if (!this.EnableVelocityInfoCache)
		{
			return;
		}
		if (this.VelocityInfoCacheArray.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[b1123700] Cannot dump velocity infos for empty cache";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Frame", UKismetSystemLibrary.GetFrameCount());
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item2 = "Name";
			CharacterActorComponent actorComp2 = this.ActorComp;
			object item3;
			if (actorComp2 == null)
			{
				item3 = null;
			}
			else
			{
				TsBaseCharacter actor = actorComp2.Actor;
				item3 = ((actor != null) ? actor.GetName() : null);
			}
			ptr2 = new ValueTuple<string, object>(item2, item3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Test;
		ELogAuthor author2 = ELogAuthor.YJX;
		string message2 = "[b1123700] Dump cached velocity infos";
		<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
		string item4 = "PbDataId";
		CharacterActorComponent actorComp3 = this.ActorComp;
		ptr3 = new ValueTuple<string, object>(item4, (actorComp3 != null) ? new int?(actorComp3.CreatureData.GetPbDataId()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Frame", UKismetSystemLibrary.GetFrameCount());
		ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
		string item5 = "Name";
		CharacterActorComponent actorComp4 = this.ActorComp;
		ptr4 = new ValueTuple<string, object>(item5, (actorComp4 != null) ? actorComp4.Actor : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Size", this.VelocityInfoCacheArray.Count);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("OnlyLast", onlyLast);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("Reason", reason);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
		string text = "";
		if (onlyLast)
		{
			int count = this.VelocityInfoCacheArray.Count;
			text += this.VelocityInfoCacheArray[count - 1].Dump();
		}
		else
		{
			foreach (VelocityCacheInfo velocityCacheInfo in this.VelocityInfoCacheArray)
			{
				text += velocityCacheInfo.Dump();
			}
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Test;
		ELogAuthor author3 = ELogAuthor.YJX;
		string message3 = "[b1123700] DumpInfos";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Info", text);
		instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601BF9B RID: 114587 RVA: 0x007C52D0 File Offset: 0x007C34D0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		UeMovementTickManageComponent ueMovementTickManageComponent = (UeMovementTickManageComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (ueMovementTickManageComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComponent"))
		{
			if (ueMovementTickManageComponent.MoveComponent == null)
			{
				this.MoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCharacterMovementComponent>(this.MoveComponent), "MoveComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (ueMovementTickManageComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("VehiclePerformComp"))
		{
			if (ueMovementTickManageComponent.VehiclePerformComp == null)
			{
				this.VehiclePerformComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseVehiclePerformComponent>(this.VehiclePerformComp), "VehiclePerformComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CharacterMoveComp"))
		{
			if (ueMovementTickManageComponent.CharacterMoveComp == null)
			{
				this.CharacterMoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMoveComponent>(this.CharacterMoveComp), "CharacterMoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DebugComp"))
		{
			if (ueMovementTickManageComponent.DebugComp == null)
			{
				this.DebugComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ActorDebugMovementComponent>(this.DebugComp), "DebugComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("<SkelTickMgr>k__BackingField"))
		{
			if (ueMovementTickManageComponent.SkelTickMgr == null)
			{
				this.SkelTickMgr = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UeSkeletalTickManageComponent>(this.SkelTickMgr), "<SkelTickMgr>k__BackingField"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FixFacingForVelocity"))
		{
			this.FixFacingForVelocity = ueMovementTickManageComponent.FixFacingForVelocity;
		}
		if (base.CanResetComponentProperty("FixFacingTurnSpeed"))
		{
			this.FixFacingTurnSpeed = ueMovementTickManageComponent.FixFacingTurnSpeed;
		}
		if (base.CanResetComponentProperty("ProxyTickCount"))
		{
			this.ProxyTickCount = ueMovementTickManageComponent.ProxyTickCount;
		}
		if (base.CanResetComponentProperty("ProxyTickDelta"))
		{
			this.ProxyTickDelta = ueMovementTickManageComponent.ProxyTickDelta;
		}
		if (base.CanResetComponentProperty("TickModeInternal"))
		{
			this.TickModeInternal = ueMovementTickManageComponent.TickModeInternal;
		}
		if (base.CanResetComponentProperty("HasMove"))
		{
			this.HasMove = ueMovementTickManageComponent.HasMove;
		}
		if (base.CanResetComponentProperty("ModelBufferTimeLength"))
		{
			this.ModelBufferTimeLength = ueMovementTickManageComponent.ModelBufferTimeLength;
		}
		if (base.CanResetComponentProperty("OldMeshTransform"))
		{
			this.OldMeshTransform = ueMovementTickManageComponent.OldMeshTransform;
		}
		if (base.CanResetComponentProperty("OldActorLocation") && ueMovementTickManageComponent.OldActorLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.OldActorLocation), "OldActorLocation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("OldActorRotator") && ueMovementTickManageComponent.OldActorRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.OldActorRotator), "OldActorRotator"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ForbiddenTickPoseInternal"))
		{
			this.ForbiddenTickPoseInternal = ueMovementTickManageComponent.ForbiddenTickPoseInternal;
		}
		if (base.CanResetComponentProperty("UroParams"))
		{
			if (ueMovementTickManageComponent.UroParams == null)
			{
				this.UroParams = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FAnimUpdateRateParameters>(this.UroParams), "UroParams"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TeleportLockInternal"))
		{
			this.TeleportLockInternal = ueMovementTickManageComponent.TeleportLockInternal;
		}
		if (base.CanResetComponentProperty("Frozen"))
		{
			this.Frozen = ueMovementTickManageComponent.Frozen;
		}
		if (base.CanResetComponentProperty("DebugLastTickFrame"))
		{
			this.DebugLastTickFrame = ueMovementTickManageComponent.DebugLastTickFrame;
		}
		if (base.CanResetComponentProperty("EnableVelocityInfoCache"))
		{
			this.EnableVelocityInfoCache = ueMovementTickManageComponent.EnableVelocityInfoCache;
		}
		if (base.CanResetComponentProperty("VelocityInfoCacheArray"))
		{
			if (ueMovementTickManageComponent.VelocityInfoCacheArray == null)
			{
				this.VelocityInfoCacheArray = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<VelocityCacheInfo>>(this.VelocityInfoCacheArray), "VelocityInfoCacheArray"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("VelocityInfoFrameSize"))
		{
			this.VelocityInfoFrameSize = ueMovementTickManageComponent.VelocityInfoFrameSize;
		}
		if (base.CanResetComponentProperty("FrameCounter"))
		{
			this.FrameCounter = ueMovementTickManageComponent.FrameCounter;
		}
		if (base.CanResetComponentProperty("LastFrame"))
		{
			this.LastFrame = ueMovementTickManageComponent.LastFrame;
		}
		if (base.CanResetComponentProperty("TmpVectorField"))
		{
			if (ueMovementTickManageComponent.TmpVectorField == null)
			{
				this.TmpVectorField = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVectorField), "TmpVectorField"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DCF7 RID: 56567
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DCF8 RID: 56568
	[Nullable(2)]
	private UCharacterMovementComponent MoveComponent;

	// Token: 0x0400DCF9 RID: 56569
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400DCFA RID: 56570
	[Nullable(2)]
	private BaseVehiclePerformComponent VehiclePerformComp;

	// Token: 0x0400DCFB RID: 56571
	[Nullable(2)]
	private BaseMoveComponent CharacterMoveComp;

	// Token: 0x0400DCFC RID: 56572
	[Nullable(2)]
	private ActorDebugMovementComponent DebugComp;

	// Token: 0x0400DCFE RID: 56574
	private bool FixFacingForVelocity;

	// Token: 0x0400DCFF RID: 56575
	private float FixFacingTurnSpeed;

	// Token: 0x0400DD00 RID: 56576
	private int ProxyTickCount;

	// Token: 0x0400DD01 RID: 56577
	private float ProxyTickDelta;

	// Token: 0x0400DD02 RID: 56578
	private EMovementTickMode TickModeInternal;

	// Token: 0x0400DD03 RID: 56579
	private bool HasMove;

	// Token: 0x0400DD04 RID: 56580
	private float ModelBufferTimeLength;

	// Token: 0x0400DD05 RID: 56581
	private FTransformDouble? OldMeshTransform;

	// Token: 0x0400DD06 RID: 56582
	private readonly Vector OldActorLocation = Vector.Create();

	// Token: 0x0400DD07 RID: 56583
	private readonly Rotator OldActorRotator = Rotator.Create();

	// Token: 0x0400DD08 RID: 56584
	private bool ForbiddenTickPoseInternal;

	// Token: 0x0400DD09 RID: 56585
	[Nullable(2)]
	private FAnimUpdateRateParameters UroParams;

	// Token: 0x0400DD0A RID: 56586
	private bool TeleportLockInternal;

	// Token: 0x0400DD0B RID: 56587
	public bool Frozen;

	// Token: 0x0400DD0C RID: 56588
	private long DebugLastTickFrame;

	// Token: 0x0400DD0D RID: 56589
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400DD0E RID: 56590
	[StaticVariableRuleIgnore]
	private static readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400DD0F RID: 56591
	public bool EnableVelocityInfoCache;

	// Token: 0x0400DD10 RID: 56592
	public List<VelocityCacheInfo> VelocityInfoCacheArray = new List<VelocityCacheInfo>();

	// Token: 0x0400DD11 RID: 56593
	public int VelocityInfoFrameSize = 5;

	// Token: 0x0400DD12 RID: 56594
	public int FrameCounter;

	// Token: 0x0400DD13 RID: 56595
	public long LastFrame;

	// Token: 0x0400DD14 RID: 56596
	public Vector TmpVectorField = Vector.Create();
}
