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

// Token: 0x020032D9 RID: 13017
[NullableContext(1)]
[Nullable(0)]
public class VehiclePerformComponent : BaseVehiclePerformComponent
{
	// Token: 0x17002737 RID: 10039
	// (get) Token: 0x0601C4B7 RID: 115895 RVA: 0x007E5CB5 File Offset: 0x007E3EB5
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

	// Token: 0x17002738 RID: 10040
	// (get) Token: 0x0601C4B8 RID: 115896 RVA: 0x007E5CC8 File Offset: 0x007E3EC8
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

	// Token: 0x0601C4B9 RID: 115897 RVA: 0x007E5CDC File Offset: 0x007E3EDC
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

	// Token: 0x0601C4BA RID: 115898 RVA: 0x007E5D89 File Offset: 0x007E3F89
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

	// Token: 0x0601C4BB RID: 115899 RVA: 0x007E5DC0 File Offset: 0x007E3FC0
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

	// Token: 0x0601C4BC RID: 115900 RVA: 0x007E5E14 File Offset: 0x007E4014
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

	// Token: 0x0601C4BD RID: 115901 RVA: 0x007E5EC8 File Offset: 0x007E40C8
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

	// Token: 0x0601C4BE RID: 115902 RVA: 0x007E5F9C File Offset: 0x007E419C
	public virtual bool CheckIfCanLeave()
	{
		return true;
	}

	// Token: 0x0601C4BF RID: 115903 RVA: 0x007E5F9F File Offset: 0x007E419F
	public virtual bool CheckIfCanSprint()
	{
		return true;
	}

	// Token: 0x0601C4C0 RID: 115904 RVA: 0x007E5FA2 File Offset: 0x007E41A2
	public virtual bool CheckIfCanRiderSharing()
	{
		return VehicleModel.Instance.IsReadyRiderSharing && !VehicleModel.Instance.IsForbidRiderSharing;
	}

	// Token: 0x0601C4C1 RID: 115905 RVA: 0x007E5FBF File Offset: 0x007E41BF
	public virtual void AddVehicleTagListeners()
	{
	}

	// Token: 0x0601C4C2 RID: 115906 RVA: 0x007E5FC1 File Offset: 0x007E41C1
	public virtual void RemoveVehicleTagListeners()
	{
	}

	// Token: 0x0601C4C3 RID: 115907 RVA: 0x007E5FC3 File Offset: 0x007E41C3
	public void RefreshRideSharingSkillState()
	{
		EventSystem.Instance.Emit<bool, EInputAction>(EEventName.OnVehicleSkillEnableChanged, this.CheckIfCanRiderSharing(), EInputAction.技能1);
	}

	// Token: 0x0601C4C4 RID: 115908 RVA: 0x007E5FE0 File Offset: 0x007E41E0
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

	// Token: 0x0601C4C5 RID: 115909 RVA: 0x007E6016 File Offset: 0x007E4216
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

	// Token: 0x0601C4C6 RID: 115910 RVA: 0x007E604C File Offset: 0x007E424C
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

	// Token: 0x0601C4C7 RID: 115911 RVA: 0x007E60F0 File Offset: 0x007E42F0
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

	// Token: 0x0601C4C8 RID: 115912 RVA: 0x007E616B File Offset: 0x007E436B
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

	// Token: 0x0601C4C9 RID: 115913 RVA: 0x007E6192 File Offset: 0x007E4392
	public virtual bool CheckCanPerformHit()
	{
		return true;
	}

	// Token: 0x0601C4CA RID: 115914 RVA: 0x007E6195 File Offset: 0x007E4395
	public virtual void OnBulletHit(HitInformation hitData, BulletInfo bulletInfo)
	{
	}

	// Token: 0x0601C4CB RID: 115915 RVA: 0x007E6197 File Offset: 0x007E4397
	public override void GetVehicleVelocity(Vector output)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		output.DeepCopy(this.ActorComp.ActorVelocityProxy);
	}

	// Token: 0x0601C4CC RID: 115916 RVA: 0x007E61B4 File Offset: 0x007E43B4
	public void UpdateRotYawSpeed(float delta)
	{
		float yaw = this.LastActorRotation.Yaw;
		float yaw2 = this.ActorComp.ActorRotationProxy.Yaw;
		this.ActorComp.SimulatedRotYawSpeed = MathUtils.Instance.WrapAngle(yaw2 - yaw) / (delta * 0.001f);
		this.LastActorRotation.DeepCopy(this.ActorComp.ActorRotationProxy);
	}

	// Token: 0x0601C4CD RID: 115917 RVA: 0x007E6214 File Offset: 0x007E4414
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

	// Token: 0x0601C4CE RID: 115918 RVA: 0x007E6278 File Offset: 0x007E4478
	public void SimulatedImpactInfo(float velocityX, float velocityY, float velocityZ, float normalX, float normalY, float normalZ)
	{
		if (this.CacheImpactHitResult == null)
		{
			this.CacheImpactHitResult = new FHitResult();
		}
		this.CacheImpactHitResult.Normal = new FVector_NetQuantizeNormal(normalX, normalY, normalZ);
		this.ImpactedVelocity.Set((double)velocityX, (double)velocityY, (double)velocityZ);
	}

	// Token: 0x0601C4CF RID: 115919 RVA: 0x007E62C8 File Offset: 0x007E44C8
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

	// Token: 0x0601C4D0 RID: 115920 RVA: 0x007E64F4 File Offset: 0x007E46F4
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

	// Token: 0x0601C4D1 RID: 115921 RVA: 0x007E6590 File Offset: 0x007E4790
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehiclePerformComponent vehiclePerformComponent = (VehiclePerformComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (vehiclePerformComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (vehiclePerformComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (vehiclePerformComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (vehiclePerformComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsBeingImpacted"))
		{
			this.IsBeingImpacted = vehiclePerformComponent.IsBeingImpacted;
		}
		if (base.CanResetComponentProperty("ImpactedVelocity"))
		{
			if (vehiclePerformComponent.ImpactedVelocity == null)
			{
				this.ImpactedVelocity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.ImpactedVelocity), "ImpactedVelocity"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CacheImpactHitResult"))
		{
			if (vehiclePerformComponent.CacheImpactHitResult == null)
			{
				this.CacheImpactHitResult = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FHitResult>(this.CacheImpactHitResult), "CacheImpactHitResult"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LastImpactFrame"))
		{
			this.LastImpactFrame = vehiclePerformComponent.LastImpactFrame;
		}
		if (base.CanResetComponentProperty("CollisionVelocity"))
		{
			if (vehiclePerformComponent.CollisionVelocity == null)
			{
				this.CollisionVelocity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.CollisionVelocity), "CollisionVelocity"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HasRoleAndCtrlByMe"))
		{
			this.HasRoleAndCtrlByMe = vehiclePerformComponent.HasRoleAndCtrlByMe;
		}
		if (base.CanResetComponentProperty("IsHidePassenger"))
		{
			this.IsHidePassenger = vehiclePerformComponent.IsHidePassenger;
		}
		if (base.CanResetComponentProperty("LastActorRotation"))
		{
			if (vehiclePerformComponent.LastActorRotation == null)
			{
				this.LastActorRotation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.LastActorRotation), "LastActorRotation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("VehicleTagListeners"))
		{
			if (vehiclePerformComponent.VehicleTagListeners == null)
			{
				this.VehicleTagListeners = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.VehicleTagListeners), "VehicleTagListeners"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DisableActorHandleMap"))
		{
			if (vehiclePerformComponent.DisableActorHandleMap == null)
			{
				this.DisableActorHandleMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.DisableActorHandleMap), "DisableActorHandleMap"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("NextCameraShakeTime"))
		{
			this.NextCameraShakeTime = vehiclePerformComponent.NextCameraShakeTime;
		}
		return true;
	}

	// Token: 0x0400E03A RID: 57402
	[Nullable(2)]
	public VehicleActorComponent ActorComp;

	// Token: 0x0400E03B RID: 57403
	[Nullable(2)]
	protected VehicleAnimationComponent AnimComp;

	// Token: 0x0400E03C RID: 57404
	[Nullable(2)]
	protected VehicleMoveComponent MoveComp;

	// Token: 0x0400E03D RID: 57405
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x0400E03E RID: 57406
	public bool IsBeingImpacted;

	// Token: 0x0400E03F RID: 57407
	public Vector ImpactedVelocity = Vector.Create();

	// Token: 0x0400E040 RID: 57408
	[Nullable(2)]
	public FHitResult CacheImpactHitResult;

	// Token: 0x0400E041 RID: 57409
	private int LastImpactFrame;

	// Token: 0x0400E042 RID: 57410
	public Vector CollisionVelocity = Vector.Create();

	// Token: 0x0400E043 RID: 57411
	public bool HasRoleAndCtrlByMe;

	// Token: 0x0400E044 RID: 57412
	public bool IsHidePassenger;

	// Token: 0x0400E045 RID: 57413
	public Rotator LastActorRotation = Rotator.Create();

	// Token: 0x0400E046 RID: 57414
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<ITagTask> VehicleTagListeners;

	// Token: 0x0400E047 RID: 57415
	[Nullable(2)]
	private Dictionary<int, int> DisableActorHandleMap;

	// Token: 0x0400E048 RID: 57416
	private double NextCameraShakeTime;
}
