using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.World.Define;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200284B RID: 10315
[NullableContext(1)]
[Nullable(0)]
public class VehiclePerformComponent : BaseVehiclePerformComponent
{
	// Token: 0x17002A6B RID: 10859
	// (get) Token: 0x0601A140 RID: 106816 RVA: 0x0080C5AC File Offset: 0x0080A7AC
	[Nullable(2)]
	public Vector ActorLocationProxy
	{
		[NullableContext(2)]
		get
		{
			VehicleActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return null;
			}
			return actorComp.ActorLocationProxy;
		}
	}

	// Token: 0x17002A6C RID: 10860
	// (get) Token: 0x0601A141 RID: 106817 RVA: 0x0080C5BF File Offset: 0x0080A7BF
	[Nullable(2)]
	public Rotator ActorRotationProxy
	{
		[NullableContext(2)]
		get
		{
			VehicleActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return null;
			}
			return actorComp.ActorRotationProxy;
		}
	}

	// Token: 0x0601A142 RID: 106818 RVA: 0x0080C5D4 File Offset: 0x0080A7D4
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.ActorComp = base.Entity.GetComponent<VehicleActorComponent>();
		this.AnimComp = base.Entity.GetComponent<VehicleAnimationComponent>();
		this.MoveComp = base.Entity.GetComponent<VehicleMoveComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		this.HasRoleAndCtrlByMe = false;
		VehicleActorComponent actorComp = this.ActorComp;
		TsBaseVehicle tsBaseVehicle = ((actorComp != null) ? actorComp.Owner : null) as TsBaseVehicle;
		if (tsBaseVehicle != null && tsBaseVehicle.IsValid())
		{
			tsBaseVehicle.CapsuleComponent.OnComponentHit.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, FVector, FHitResult>(this.OnEnterHitCollision));
		}
		return this.InitVehicleConfig();
	}

	// Token: 0x0601A143 RID: 106819 RVA: 0x0080C681 File Offset: 0x0080A881
	protected override void OnTick(float delta)
	{
		this.UpdateRotYawSpeed(delta);
		if (Time.Instance.Frame != this.LastImpactFrame)
		{
			VehicleActorComponent actorComp = this.ActorComp;
			if (actorComp != null && actorComp.IsMoveAutonomousProxy)
			{
				this.IsBeingImpacted = false;
			}
		}
	}

	// Token: 0x0601A144 RID: 106820 RVA: 0x0080C6B8 File Offset: 0x0080A8B8
	[NullableContext(2)]
	protected override BP_VehicleConfig_C LoadVehicleConfigAsset()
	{
		VehicleActorComponent actorComp = this.ActorComp;
		bool flag;
		if (actorComp == null)
		{
			flag = true;
		}
		else
		{
			UKuroVehicleMovementComponent vehicleMovementComponent = actorComp.Actor.VehicleMovementComponent;
			flag = !((vehicleMovementComponent != null) ? new bool?(vehicleMovementComponent.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return null;
		}
		return base.LoadVehicleConfigAsset();
	}

	// Token: 0x0601A145 RID: 106821 RVA: 0x0080C70C File Offset: 0x0080A90C
	public override void Enter(Entity entity, int seat, bool byChangeRole = false)
	{
		base.Enter(entity, seat, byChangeRole);
		foreach (VehiclePassengerInfo vehiclePassengerInfo in this.PassengerInfoMap.Values)
		{
			if (vehiclePassengerInfo.IsDriver && vehiclePassengerInfo.IsRolePassenger(false))
			{
				if (base.Entity.GameBudgetManagedToken != 0U)
				{
					UKuroGameBudgetAllocatorCSharpInterface.MarkActorInFighting(GameBudgetAllocatorConfigCreator.Instance.TsNormalEntityGroupConfig.GroupName, base.Entity.GameBudgetManagedToken, true);
					break;
				}
				break;
			}
		}
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		if (component != null && component.IsRoleAndCtrlByMe)
		{
			this.AddVehicleTagListeners();
		}
	}

	// Token: 0x0601A146 RID: 106822 RVA: 0x0080C7C0 File Offset: 0x0080A9C0
	public override void Leave(Entity entity, ELeaveVehicleType type = ELeaveVehicleType.Launch, bool byChangeRole = false)
	{
		base.Leave(entity, type, byChangeRole);
		bool flag = false;
		foreach (VehiclePassengerInfo vehiclePassengerInfo in this.PassengerInfoMap.Values)
		{
			if (vehiclePassengerInfo.IsDriver && vehiclePassengerInfo.IsRolePassenger(false))
			{
				flag = true;
				break;
			}
		}
		if (!flag && base.Entity.GameBudgetManagedToken != 0U)
		{
			UKuroGameBudgetAllocatorCSharpInterface.MarkActorInFighting(GameBudgetAllocatorConfigCreator.Instance.TsNormalEntityGroupConfig.GroupName, base.Entity.GameBudgetManagedToken, false);
		}
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		if (component != null && component.IsRoleAndCtrlByMe)
		{
			this.RemoveVehicleTagListeners();
		}
		VehicleGravityComponent component2 = base.Entity.GetComponent<VehicleGravityComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.OnPassengerLeave(entity);
	}

	// Token: 0x0601A147 RID: 106823 RVA: 0x0080C894 File Offset: 0x0080AA94
	public virtual bool CheckIfCanLeave()
	{
		return true;
	}

	// Token: 0x0601A148 RID: 106824 RVA: 0x0080C897 File Offset: 0x0080AA97
	public virtual bool CheckIfCanSprint()
	{
		return true;
	}

	// Token: 0x0601A149 RID: 106825 RVA: 0x0080C89A File Offset: 0x0080AA9A
	public virtual bool CheckIfCanRiderSharing()
	{
		return VehicleModel.Instance.IsReadyRiderSharing && !VehicleModel.Instance.IsForbidRiderSharing;
	}

	// Token: 0x0601A14A RID: 106826 RVA: 0x0080C8B7 File Offset: 0x0080AAB7
	public virtual void AddVehicleTagListeners()
	{
	}

	// Token: 0x0601A14B RID: 106827 RVA: 0x0080C8B9 File Offset: 0x0080AAB9
	public virtual void RemoveVehicleTagListeners()
	{
	}

	// Token: 0x0601A14C RID: 106828 RVA: 0x0080C8BB File Offset: 0x0080AABB
	public void RefreshRideSharingSkillState()
	{
		EventSystem.Instance.Emit<bool, EInputAction>(EEventName.OnVehicleSkillEnableChanged, this.CheckIfCanRiderSharing(), EInputAction.技能1);
	}

	// Token: 0x0601A14D RID: 106829 RVA: 0x0080C8D8 File Offset: 0x0080AAD8
	protected override void EnterVehiclePerform(VehiclePassengerInfo info)
	{
		if (info.IsRolePassenger(true))
		{
			this.HasRoleAndCtrlByMe = true;
			this.IgnorePlatformCollisionToCamera(true);
		}
		if (this.IsHidePassenger && info.PassengerEntity != null)
		{
			this.SetPassengerVisible(info.PassengerEntity, false);
		}
	}

	// Token: 0x0601A14E RID: 106830 RVA: 0x0080C90E File Offset: 0x0080AB0E
	protected override void LeaveVehiclePerform(VehiclePassengerInfo info)
	{
		if (info.IsRolePassenger(true))
		{
			this.HasRoleAndCtrlByMe = false;
			this.IgnorePlatformCollisionToCamera(false);
		}
		if (this.IsHidePassenger && info.PassengerEntity != null)
		{
			this.SetPassengerVisible(info.PassengerEntity, true);
		}
	}

	// Token: 0x0601A14F RID: 106831 RVA: 0x0080C944 File Offset: 0x0080AB44
	private void SetPassengerVisible(Entity entity, bool visible)
	{
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		int id = entity.Id;
		if (visible)
		{
			Dictionary<int, int> disableActorHandleMap = this.DisableActorHandleMap;
			int? num = (disableActorHandleMap != null) ? new int?(disableActorHandleMap.GetValueOrDefault(id)) : null;
			if (num != null)
			{
				component.EnableActor(num.Value);
				this.DisableActorHandleMap.Remove(id);
				return;
			}
		}
		else
		{
			if (this.DisableActorHandleMap == null)
			{
				this.DisableActorHandleMap = new Dictionary<int, int>();
			}
			int value = component.DisableActor("SetPassengerVisible");
			this.DisableActorHandleMap[id] = value;
		}
	}

	// Token: 0x0601A150 RID: 106832 RVA: 0x0080C9E8 File Offset: 0x0080ABE8
	protected void IgnorePlatformCollisionToCamera(bool ignore)
	{
		VehicleActorComponent actorComp = this.ActorComp;
		AActor aactor = (actorComp != null) ? actorComp.Actor.PlatformActor : null;
		if (aactor == null || !aactor.IsValid())
		{
			return;
		}
		UStaticMeshComponent ustaticMeshComponent = aactor.GetComponentByClass(UStaticMeshComponent.StaticClass()) as UStaticMeshComponent;
		if (ustaticMeshComponent == null || !ustaticMeshComponent.IsValid())
		{
			return;
		}
		if (ignore)
		{
			ustaticMeshComponent.SetCollisionResponseToChannel(KuroCollisionChannel.Camera, ECollisionResponse.ECR_Ignore);
			return;
		}
		ustaticMeshComponent.SetCollisionResponseToChannel(KuroCollisionChannel.Camera, ECollisionResponse.ECR_Block);
	}

	// Token: 0x0601A151 RID: 106833 RVA: 0x0080CA63 File Offset: 0x0080AC63
	[NullableContext(2)]
	protected virtual void OnEnterHitCollision(UPrimitiveComponent hitComp, AActor otherActor, UPrimitiveComponent otherComp, FVector normalImpulse, [Nullable(1)] FHitResult hitResult)
	{
		this.CacheImpact(hitResult);
		this.OnHit(hitResult);
		VehicleMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		moveComp.EnableUeMovementTick("载具受到碰撞");
	}

	// Token: 0x0601A152 RID: 106834 RVA: 0x0080CA8A File Offset: 0x0080AC8A
	public virtual bool CheckCanPerformHit()
	{
		return true;
	}

	// Token: 0x0601A153 RID: 106835 RVA: 0x0080CA8D File Offset: 0x0080AC8D
	public virtual void OnBulletHit(HitInformation hitData, BulletInfo bulletInfo)
	{
	}

	// Token: 0x0601A154 RID: 106836 RVA: 0x0080CA8F File Offset: 0x0080AC8F
	public override void GetVehicleVelocity(Vector output)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		output.DeepCopy(this.ActorComp.ActorVelocityProxy);
	}

	// Token: 0x0601A155 RID: 106837 RVA: 0x0080CAAC File Offset: 0x0080ACAC
	public void UpdateRotYawSpeed(float delta)
	{
		float yaw = this.LastActorRotation.Yaw;
		float yaw2 = this.ActorComp.ActorRotationProxy.Yaw;
		this.ActorComp.SimulatedRotYawSpeed = MathUtils.Instance.WrapAngle(yaw2 - yaw) / (delta * 0.001f);
		this.LastActorRotation.DeepCopy(this.ActorComp.ActorRotationProxy);
	}

	// Token: 0x0601A156 RID: 106838 RVA: 0x0080CB0C File Offset: 0x0080AD0C
	protected void CacheImpact(FHitResult hitResult)
	{
		VehicleActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.IsMoveAutonomousProxy)
		{
			return;
		}
		this.LastImpactFrame = Time.Instance.Frame;
		this.IsBeingImpacted = true;
		Vector impactedVelocity = this.ImpactedVelocity;
		FVector velocity = this.MoveComp.VehicleMovement.Velocity;
		impactedVelocity.FromUeVector(velocity);
		this.CacheImpactHitResult = hitResult;
	}

	// Token: 0x0601A157 RID: 106839 RVA: 0x0080CB70 File Offset: 0x0080AD70
	public void SimulatedImpactInfo(float velocityX, float velocityY, float velocityZ, float normalX, float normalY, float normalZ)
	{
		if (this.CacheImpactHitResult == null)
		{
			this.CacheImpactHitResult = new FHitResult();
		}
		this.CacheImpactHitResult.Normal = new FVector_NetQuantizeNormal(normalX, normalY, normalZ);
		this.ImpactedVelocity.Set((double)velocityX, (double)velocityY, (double)velocityZ);
	}

	// Token: 0x0601A158 RID: 106840 RVA: 0x0080CBC0 File Offset: 0x0080ADC0
	protected virtual void OnHit(FHitResult hitResult)
	{
		VehicleConfig configInternal = this.ConfigInternal;
		if (((configInternal != null) ? configInternal.Asset : null) != null)
		{
			Entity driver = base.Driver;
			bool flag;
			if (driver == null)
			{
				flag = true;
			}
			else
			{
				CharacterActorComponent component = driver.GetComponent<CharacterActorComponent>();
				flag = !((component != null) ? new bool?(component.IsRoleAndCtrlByMe) : null).GetValueOrDefault();
			}
			if (!flag && Time.Instance.NowSeconds > this.NextCameraShakeTime)
			{
				Vector tmpVector = this.TmpVector1;
				FVector velocity = this.MoveComp.VehicleMovement.Velocity;
				tmpVector.FromUeVector(velocity);
				Vector tmpVector2 = this.TmpVector2;
				FVector_NetQuantizeNormal normal = hitResult.Normal;
				tmpVector2.FromUeVector(normal);
				double num = -this.TmpVector1.DotProduct(this.TmpVector2);
				if (num < 100.0)
				{
					return;
				}
				this.ActorComp.ActorQuatProxy.UnRotateVector(this.TmpVector2, this.TmpVector1);
				double num2 = Math.Abs(this.TmpVector1.Z) * num;
				double num3 = this.TmpVector1.Size2D() * num;
				BaseTagComponent tagComp = this.TagComp;
				bool flag2;
				if (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.第一人称"]))
				{
					if (num3 >= num2)
					{
						flag2 = (this.ChooseCameraShake(this.ConfigInternal.Asset.撞击震屏_第一人称, num3) || this.ChooseCameraShake(this.ConfigInternal.Asset.撞击震屏Z_第一人称, num2));
					}
					else
					{
						flag2 = (this.ChooseCameraShake(this.ConfigInternal.Asset.撞击震屏Z_第一人称, num2) || this.ChooseCameraShake(this.ConfigInternal.Asset.撞击震屏_第一人称, num3));
					}
				}
				else if (num3 >= num2)
				{
					flag2 = (this.ChooseCameraShake(this.ConfigInternal.Asset.撞击震屏, num3) || this.ChooseCameraShake(this.ConfigInternal.Asset.撞击震屏Z, num2));
				}
				else
				{
					flag2 = (this.ChooseCameraShake(this.ConfigInternal.Asset.撞击震屏Z, num2) || this.ChooseCameraShake(this.ConfigInternal.Asset.撞击震屏, num3));
				}
				if (flag2)
				{
					this.NextCameraShakeTime = Time.Instance.NowSeconds + (double)this.ConfigInternal.Asset.震屏CD;
				}
				return;
			}
		}
	}

	// Token: 0x0601A159 RID: 106841 RVA: 0x0080CDEC File Offset: 0x0080AFEC
	protected bool ChooseCameraShake([Nullable(new byte[]
	{
		2,
		1
	})] TArray<SFloatThresholdAndCameraShake> shakeConfigs, double speed)
	{
		if (shakeConfigs == null)
		{
			return false;
		}
		int num = shakeConfigs.Num();
		int i = 0;
		while (i < num)
		{
			SFloatThresholdAndCameraShake sfloatThresholdAndCameraShake = shakeConfigs.Get(i);
			if (speed < (double)sfloatThresholdAndCameraShake.Threshold)
			{
				if (sfloatThresholdAndCameraShake.CameraShakeAndForceFeedback != null)
				{
					CameraController.Instance.PlayCameraShake(sfloatThresholdAndCameraShake.CameraShakeAndForceFeedback.Get().ToWeakClass(), null, null, null, true, false, "MainCamera");
					return true;
				}
				return false;
			}
			else
			{
				i++;
			}
		}
		return false;
	}

	// Token: 0x0601A15A RID: 106842 RVA: 0x0080CE88 File Offset: 0x0080B088
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehiclePerformComponent vehiclePerformComponent = (VehiclePerformComponent)componentTemplate;
		if (vehiclePerformComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (vehiclePerformComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (vehiclePerformComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (vehiclePerformComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		this.IsBeingImpacted = vehiclePerformComponent.IsBeingImpacted;
		if (vehiclePerformComponent.ImpactedVelocity == null)
		{
			this.ImpactedVelocity = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ImpactedVelocity), "ImpactedVelocity"))
		{
			return false;
		}
		if (vehiclePerformComponent.CacheImpactHitResult == null)
		{
			this.CacheImpactHitResult = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheImpactHitResult), "CacheImpactHitResult"))
		{
			return false;
		}
		this.LastImpactFrame = vehiclePerformComponent.LastImpactFrame;
		if (vehiclePerformComponent.CollisionVelocity == null)
		{
			this.CollisionVelocity = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CollisionVelocity), "CollisionVelocity"))
		{
			return false;
		}
		this.HasRoleAndCtrlByMe = vehiclePerformComponent.HasRoleAndCtrlByMe;
		this.IsHidePassenger = vehiclePerformComponent.IsHidePassenger;
		if (vehiclePerformComponent.LastActorRotation == null)
		{
			this.LastActorRotation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastActorRotation), "LastActorRotation"))
		{
			return false;
		}
		if (vehiclePerformComponent.VehicleTagListeners == null)
		{
			this.VehicleTagListeners = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleTagListeners), "VehicleTagListeners"))
		{
			return false;
		}
		if (vehiclePerformComponent.DisableActorHandleMap == null)
		{
			this.DisableActorHandleMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisableActorHandleMap), "DisableActorHandleMap"))
		{
			return false;
		}
		this.NextCameraShakeTime = vehiclePerformComponent.NextCameraShakeTime;
		return true;
	}

	// Token: 0x17002A6D RID: 10861
	// (get) Token: 0x0601A15B RID: 106843 RVA: 0x0080D098 File Offset: 0x0080B298
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A6E RID: 10862
	// (get) Token: 0x0601A15C RID: 106844 RVA: 0x0080D09B File Offset: 0x0080B29B
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A6F RID: 10863
	// (get) Token: 0x0601A15D RID: 106845 RVA: 0x0080D09E File Offset: 0x0080B29E
	public override bool NeedPostActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A70 RID: 10864
	// (get) Token: 0x0601A15E RID: 106846 RVA: 0x0080D0A1 File Offset: 0x0080B2A1
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A71 RID: 10865
	// (get) Token: 0x0601A15F RID: 106847 RVA: 0x0080D0A4 File Offset: 0x0080B2A4
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A72 RID: 10866
	// (get) Token: 0x0601A160 RID: 106848 RVA: 0x0080D0A7 File Offset: 0x0080B2A7
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A73 RID: 10867
	// (get) Token: 0x0601A161 RID: 106849 RVA: 0x0080D0AA File Offset: 0x0080B2AA
	public override bool NeedAfterTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E4E5 RID: 58597
	[Nullable(2)]
	public VehicleActorComponent ActorComp;

	// Token: 0x0400E4E6 RID: 58598
	[Nullable(2)]
	protected VehicleAnimationComponent AnimComp;

	// Token: 0x0400E4E7 RID: 58599
	[Nullable(2)]
	protected VehicleMoveComponent MoveComp;

	// Token: 0x0400E4E8 RID: 58600
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400E4E9 RID: 58601
	public bool IsBeingImpacted;

	// Token: 0x0400E4EA RID: 58602
	public Vector ImpactedVelocity = Vector.Create();

	// Token: 0x0400E4EB RID: 58603
	[Nullable(2)]
	public FHitResult CacheImpactHitResult;

	// Token: 0x0400E4EC RID: 58604
	private int LastImpactFrame;

	// Token: 0x0400E4ED RID: 58605
	public Vector CollisionVelocity = Vector.Create();

	// Token: 0x0400E4EE RID: 58606
	public bool HasRoleAndCtrlByMe;

	// Token: 0x0400E4EF RID: 58607
	public bool IsHidePassenger;

	// Token: 0x0400E4F0 RID: 58608
	public Rotator LastActorRotation = Rotator.Create();

	// Token: 0x0400E4F1 RID: 58609
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<ITagTask> VehicleTagListeners;

	// Token: 0x0400E4F2 RID: 58610
	[Nullable(2)]
	private Dictionary<int, int> DisableActorHandleMap;

	// Token: 0x0400E4F3 RID: 58611
	private double NextCameraShakeTime;
}
