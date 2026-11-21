using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020027EF RID: 10223
[NullableContext(1)]
[Nullable(0)]
public class UeMovementTickManageComponent : EntityComponent, IUeMovementComp
{
	// Token: 0x17002941 RID: 10561
	// (get) Token: 0x06019B6C RID: 105324 RVA: 0x007EB410 File Offset: 0x007E9610
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

	// Token: 0x17002942 RID: 10562
	// (get) Token: 0x06019B6D RID: 105325 RVA: 0x007EB425 File Offset: 0x007E9625
	// (set) Token: 0x06019B6E RID: 105326 RVA: 0x007EB42D File Offset: 0x007E962D
	[Nullable(2)]
	public UeSkeletalTickManageComponent SkelTickMgr { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17002943 RID: 10563
	// (get) Token: 0x06019B6F RID: 105327 RVA: 0x007EB436 File Offset: 0x007E9636
	// (set) Token: 0x06019B70 RID: 105328 RVA: 0x007EB440 File Offset: 0x007E9640
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

	// Token: 0x17002944 RID: 10564
	// (get) Token: 0x06019B71 RID: 105329 RVA: 0x007EB522 File Offset: 0x007E9722
	// (set) Token: 0x06019B72 RID: 105330 RVA: 0x007EB52A File Offset: 0x007E972A
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

	// Token: 0x17002945 RID: 10565
	// (get) Token: 0x06019B73 RID: 105331 RVA: 0x007EB549 File Offset: 0x007E9749
	// (set) Token: 0x06019B74 RID: 105332 RVA: 0x007EB551 File Offset: 0x007E9751
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

	// Token: 0x06019B75 RID: 105333 RVA: 0x007EB574 File Offset: 0x007E9774
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
		this.ForbiddenTickPose = (base.Entity.GetTickInterval() > 1 || UeTickManageDefine.EnabledNewSkelTickTiming);
		this.DebugLastTickFrame = (long)Time.Instance.Frame;
		this.TeleportLockInternal = false;
		this.TickMode = (UeTickManageDefine.EnabledMovementParallel ? EMovementTickMode.TsProxy : EMovementTickMode.TsTakeOver);
		if (SundryModel.Instance.RoleFallingDebugLogOn && this.ActorComp.IsRoleAndCtrlByMe)
		{
			this.SetVelocityInfoCacheEnable(true);
		}
		this.UroParams = new FAnimUpdateRateParameters();
		return true;
	}

	// Token: 0x06019B76 RID: 105334 RVA: 0x007EB69F File Offset: 0x007E989F
	protected override bool OnEnd()
	{
		this.TickMode = EMovementTickMode.None;
		this.OldMeshTransform = null;
		return true;
	}

	// Token: 0x06019B77 RID: 105335 RVA: 0x007EB6B8 File Offset: 0x007E98B8
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

	// Token: 0x06019B78 RID: 105336 RVA: 0x007EB76C File Offset: 0x007E996C
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

	// Token: 0x06019B79 RID: 105337 RVA: 0x007EB7E4 File Offset: 0x007E99E4
	protected override void OnTick(float delta)
	{
		if (this.TickMode != EMovementTickMode.TsTakeOver)
		{
			return;
		}
		this.TickMovement(delta);
		this.ResetCachedTransformAndSetModelBuffer();
		if (UeTickManageDefine.EnabledMovementParallel)
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

	// Token: 0x06019B7A RID: 105338 RVA: 0x007EB858 File Offset: 0x007E9A58
	public bool CanTickDefault()
	{
		return base.Active;
	}

	// Token: 0x06019B7B RID: 105339 RVA: 0x007EB860 File Offset: 0x007E9A60
	public bool CanTickWithDistance()
	{
		if (this.CharacterMoveComp != null)
		{
			return base.Active && this.CharacterMoveComp.CanMoveWithDistance();
		}
		return base.Active;
	}

	// Token: 0x06019B7C RID: 105340 RVA: 0x007EB888 File Offset: 0x007E9A88
	public void PreProxyTick(float delta)
	{
		this.ProxyTickCount++;
		this.ProxyTickDelta += base.Entity.TimeDilation * delta;
		if (this.ProxyTickCount >= base.Entity.GetTickInterval())
		{
			this.TickMovement(this.ProxyTickDelta);
		}
	}

	// Token: 0x06019B7D RID: 105341 RVA: 0x007EB8DC File Offset: 0x007E9ADC
	public void ProxyTick()
	{
		if (this.ProxyTickCount >= base.Entity.GetTickInterval())
		{
			this.ResetCachedTransformAndSetModelBuffer();
			this.ProxyTickCount = 0;
			this.ProxyTickDelta = 0f;
		}
		if (!UeTickManageDefine.EnabledMovementParallel)
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

	// Token: 0x06019B7E RID: 105342 RVA: 0x007EB96C File Offset: 0x007E9B6C
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
				goto IL_492;
			}
		}
		if (this.CharacterMoveComp != null)
		{
			if (UeTickManageDefine.EnabledFacingUpdateOnAddMove)
			{
				CharacterMoveComponent characterMoveComponent = this.CharacterMoveComp as CharacterMoveComponent;
				if (characterMoveComponent != null)
				{
					characterMoveComponent.GetUpdateFacingOffset(delta * 0.001f * num, UeMovementTickManageComponent.TmpFacingQuat);
					Rotator rotator = UeMovementTickManageComponent.TmpFacingQuat.Rotator(UeMovementTickManageComponent.TmpFacingRotator);
					if (!rotator.IsNearlyZero())
					{
						characterMoveComponent.SetAddMoveRotation(rotator.ToUeRotator());
					}
				}
			}
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
		this.ForbiddenTickPose = (flag || this.Frozen || UeTickManageDefine.EnabledNewSkelTickTiming);
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
		IL_492:
		this.HasMove = true;
	}

	// Token: 0x06019B7F RID: 105343 RVA: 0x007EBE24 File Offset: 0x007EA024
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

	// Token: 0x06019B80 RID: 105344 RVA: 0x007EC028 File Offset: 0x007EA228
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

	// Token: 0x06019B81 RID: 105345 RVA: 0x007EC0DD File Offset: 0x007EA2DD
	public override void OnEntityBudgetTickEnableChange(bool isEnable)
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null && animComp.Valid && isEnable)
		{
			this.AnimComp.ConsumeRootMotion();
		}
	}

	// Token: 0x06019B82 RID: 105346 RVA: 0x007EC100 File Offset: 0x007EA300
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

	// Token: 0x06019B83 RID: 105347 RVA: 0x007EC160 File Offset: 0x007EA360
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

	// Token: 0x06019B84 RID: 105348 RVA: 0x007EC1BC File Offset: 0x007EA3BC
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

	// Token: 0x06019B85 RID: 105349 RVA: 0x007EC29C File Offset: 0x007EA49C
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

	// Token: 0x06019B86 RID: 105350 RVA: 0x007EC3D4 File Offset: 0x007EA5D4
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

	// Token: 0x06019B87 RID: 105351 RVA: 0x007EC680 File Offset: 0x007EA880
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		UeMovementTickManageComponent ueMovementTickManageComponent = (UeMovementTickManageComponent)componentTemplate;
		if (ueMovementTickManageComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (ueMovementTickManageComponent.MoveComponent == null)
		{
			this.MoveComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComponent), "MoveComponent"))
		{
			return false;
		}
		if (ueMovementTickManageComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (ueMovementTickManageComponent.VehiclePerformComp == null)
		{
			this.VehiclePerformComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehiclePerformComp), "VehiclePerformComp"))
		{
			return false;
		}
		if (ueMovementTickManageComponent.CharacterMoveComp == null)
		{
			this.CharacterMoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterMoveComp), "CharacterMoveComp"))
		{
			return false;
		}
		if (ueMovementTickManageComponent.DebugComp == null)
		{
			this.DebugComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DebugComp), "DebugComp"))
		{
			return false;
		}
		if (ueMovementTickManageComponent.SkelTickMgr == null)
		{
			this.SkelTickMgr = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkelTickMgr), "SkelTickMgr"))
		{
			return false;
		}
		this.FixFacingForVelocity = ueMovementTickManageComponent.FixFacingForVelocity;
		this.FixFacingTurnSpeed = ueMovementTickManageComponent.FixFacingTurnSpeed;
		this.ProxyTickCount = ueMovementTickManageComponent.ProxyTickCount;
		this.ProxyTickDelta = ueMovementTickManageComponent.ProxyTickDelta;
		this.TickModeInternal = ueMovementTickManageComponent.TickModeInternal;
		this.HasMove = ueMovementTickManageComponent.HasMove;
		this.ModelBufferTimeLength = ueMovementTickManageComponent.ModelBufferTimeLength;
		this.OldMeshTransform = ueMovementTickManageComponent.OldMeshTransform;
		if (ueMovementTickManageComponent.OldActorLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.OldActorLocation), "OldActorLocation"))
		{
			return false;
		}
		if (ueMovementTickManageComponent.OldActorRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.OldActorRotator), "OldActorRotator"))
		{
			return false;
		}
		this.ForbiddenTickPoseInternal = ueMovementTickManageComponent.ForbiddenTickPoseInternal;
		if (ueMovementTickManageComponent.UroParams == null)
		{
			this.UroParams = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UroParams), "UroParams"))
		{
			return false;
		}
		this.TeleportLockInternal = ueMovementTickManageComponent.TeleportLockInternal;
		this.Frozen = ueMovementTickManageComponent.Frozen;
		this.DebugLastTickFrame = ueMovementTickManageComponent.DebugLastTickFrame;
		this.EnableVelocityInfoCache = ueMovementTickManageComponent.EnableVelocityInfoCache;
		if (ueMovementTickManageComponent.VelocityInfoCacheArray == null)
		{
			this.VelocityInfoCacheArray = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VelocityInfoCacheArray), "VelocityInfoCacheArray"))
		{
			return false;
		}
		this.VelocityInfoFrameSize = ueMovementTickManageComponent.VelocityInfoFrameSize;
		this.FrameCounter = ueMovementTickManageComponent.FrameCounter;
		this.LastFrame = ueMovementTickManageComponent.LastFrame;
		if (ueMovementTickManageComponent.TmpVectorField == null)
		{
			this.TmpVectorField = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVectorField), "TmpVectorField"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002946 RID: 10566
	// (get) Token: 0x06019B88 RID: 105352 RVA: 0x007EC958 File Offset: 0x007EAB58
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002947 RID: 10567
	// (get) Token: 0x06019B89 RID: 105353 RVA: 0x007EC95B File Offset: 0x007EAB5B
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002948 RID: 10568
	// (get) Token: 0x06019B8A RID: 105354 RVA: 0x007EC95E File Offset: 0x007EAB5E
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002949 RID: 10569
	// (get) Token: 0x06019B8B RID: 105355 RVA: 0x007EC961 File Offset: 0x007EAB61
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700294A RID: 10570
	// (get) Token: 0x06019B8C RID: 105356 RVA: 0x007EC964 File Offset: 0x007EAB64
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700294B RID: 10571
	// (get) Token: 0x06019B8D RID: 105357 RVA: 0x007EC967 File Offset: 0x007EAB67
	public override bool NeedEntityBudgetTickEnableChangeInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E197 RID: 57751
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400E198 RID: 57752
	[Nullable(2)]
	private UCharacterMovementComponent MoveComponent;

	// Token: 0x0400E199 RID: 57753
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400E19A RID: 57754
	[Nullable(2)]
	private BaseVehiclePerformComponent VehiclePerformComp;

	// Token: 0x0400E19B RID: 57755
	[Nullable(2)]
	private BaseMoveComponent CharacterMoveComp;

	// Token: 0x0400E19C RID: 57756
	[Nullable(2)]
	private ActorDebugMovementComponent DebugComp;

	// Token: 0x0400E19E RID: 57758
	private bool FixFacingForVelocity;

	// Token: 0x0400E19F RID: 57759
	private float FixFacingTurnSpeed;

	// Token: 0x0400E1A0 RID: 57760
	private int ProxyTickCount;

	// Token: 0x0400E1A1 RID: 57761
	private float ProxyTickDelta;

	// Token: 0x0400E1A2 RID: 57762
	private EMovementTickMode TickModeInternal;

	// Token: 0x0400E1A3 RID: 57763
	private bool HasMove;

	// Token: 0x0400E1A4 RID: 57764
	private float ModelBufferTimeLength;

	// Token: 0x0400E1A5 RID: 57765
	private FTransformDouble? OldMeshTransform;

	// Token: 0x0400E1A6 RID: 57766
	private readonly Vector OldActorLocation = Vector.Create();

	// Token: 0x0400E1A7 RID: 57767
	private readonly Rotator OldActorRotator = Rotator.Create();

	// Token: 0x0400E1A8 RID: 57768
	private bool ForbiddenTickPoseInternal;

	// Token: 0x0400E1A9 RID: 57769
	[Nullable(2)]
	private FAnimUpdateRateParameters UroParams;

	// Token: 0x0400E1AA RID: 57770
	private bool TeleportLockInternal;

	// Token: 0x0400E1AB RID: 57771
	public bool Frozen;

	// Token: 0x0400E1AC RID: 57772
	private long DebugLastTickFrame;

	// Token: 0x0400E1AD RID: 57773
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400E1AE RID: 57774
	[StaticVariableRuleIgnore]
	private static readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400E1AF RID: 57775
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpFacingQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E1B0 RID: 57776
	[StaticVariableRuleIgnore]
	private static readonly Rotator TmpFacingRotator = Rotator.Create();

	// Token: 0x0400E1B1 RID: 57777
	public bool EnableVelocityInfoCache;

	// Token: 0x0400E1B2 RID: 57778
	public List<VelocityCacheInfo> VelocityInfoCacheArray = new List<VelocityCacheInfo>();

	// Token: 0x0400E1B3 RID: 57779
	public int VelocityInfoFrameSize = 5;

	// Token: 0x0400E1B4 RID: 57780
	public int FrameCounter;

	// Token: 0x0400E1B5 RID: 57781
	public long LastFrame;

	// Token: 0x0400E1B6 RID: 57782
	public Vector TmpVectorField = Vector.Create();
}
