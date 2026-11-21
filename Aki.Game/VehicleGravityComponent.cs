using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200283C RID: 10300
[NullableContext(1)]
[Nullable(0)]
public class VehicleGravityComponent : BaseGravityComponent
{
	// Token: 0x0601A07A RID: 106618 RVA: 0x008070B0 File Offset: 0x008052B0
	protected override bool OnStart()
	{
		this.VehicleMoveComp = base.Entity.GetComponent<VehicleMoveComponent>();
		if (this.VehicleMoveComp == null)
		{
			Log.Instance.Error(ELogModule.Movement, ELogAuthor.YZ, "[VehicleGravityComponent] VehicleMoveComponent not found", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.PerformComp = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		base.InitGravityDirect();
		return true;
	}

	// Token: 0x0601A07B RID: 106619 RVA: 0x00807109 File Offset: 0x00805309
	protected override bool OnEnd()
	{
		this.VehicleMoveComp = null;
		this.PerformComp = null;
		this.NeedResetPassengerGravity = false;
		return base.OnEnd();
	}

	// Token: 0x0601A07C RID: 106620 RVA: 0x00807126 File Offset: 0x00805326
	protected override void ApplyGravityToMoveComp(Vector direction, bool clearGround = true, float overrideSmoothTime = -1f, bool withoutRotate = false)
	{
		if (this.VehicleMoveComp == null)
		{
			return;
		}
		if (withoutRotate)
		{
			this.VehicleMoveComp.SetGravityDirectWithoutRotate(direction);
			return;
		}
		this.VehicleMoveComp.SetGravityDirect(direction, overrideSmoothTime);
	}

	// Token: 0x0601A07D RID: 106621 RVA: 0x00807150 File Offset: 0x00805350
	public void OnPassengerLeave(Entity entity)
	{
		if (!this.NeedResetPassengerGravity)
		{
			return;
		}
		BaseGravityComponent component = entity.GetComponent<BaseGravityComponent>();
		int? activePriority = base.GetActivePriority();
		if (activePriority != null)
		{
			int? num = activePriority;
			int num2 = 0;
			if ((num.GetValueOrDefault() > num2 & num != null) && component != null)
			{
				component.StopGravityByPriority(activePriority.Value, true, -1f, false);
			}
		}
	}

	// Token: 0x0601A07E RID: 106622 RVA: 0x008071AC File Offset: 0x008053AC
	public void SetGravityDirectForVehicle(int priority, IVector gravity, bool needResetPassengerGravity = false, float overrideSmoothTime = -1f, bool withoutRotate = false)
	{
		this.NeedResetPassengerGravity = needResetPassengerGravity;
		base.SetGravityByPriority(priority, gravity, true, overrideSmoothTime, withoutRotate);
		this.SyncPassengerGravity(gravity, priority);
	}

	// Token: 0x0601A07F RID: 106623 RVA: 0x008071CA File Offset: 0x008053CA
	public void StopGravityDirectForVehicle(int priority)
	{
		this.NeedResetPassengerGravity = false;
		base.StopGravityByPriority(priority, true, -1f, false);
		this.SyncPassengerGravityStop(priority);
	}

	// Token: 0x0601A080 RID: 106624 RVA: 0x008071E8 File Offset: 0x008053E8
	private void SyncPassengerGravity(IVector gravity, int priority)
	{
		if (this.PerformComp == null)
		{
			return;
		}
		foreach (VehiclePassengerInfo vehiclePassengerInfo in this.PerformComp.PassengerInfoMap.Values)
		{
			Entity passengerEntity = vehiclePassengerInfo.PassengerEntity;
			BaseGravityComponent baseGravityComponent = (passengerEntity != null) ? passengerEntity.GetComponent<BaseGravityComponent>() : null;
			if (baseGravityComponent != null)
			{
				baseGravityComponent.SetGravityByPriority(priority, gravity, true, -1f, true);
			}
		}
	}

	// Token: 0x0601A081 RID: 106625 RVA: 0x0080726C File Offset: 0x0080546C
	private void SyncPassengerGravityStop(int priority)
	{
		if (this.PerformComp == null)
		{
			return;
		}
		foreach (VehiclePassengerInfo vehiclePassengerInfo in this.PerformComp.PassengerInfoMap.Values)
		{
			Entity passengerEntity = vehiclePassengerInfo.PassengerEntity;
			BaseGravityComponent baseGravityComponent = (passengerEntity != null) ? passengerEntity.GetComponent<BaseGravityComponent>() : null;
			if (baseGravityComponent != null)
			{
				baseGravityComponent.StopGravityByPriority(priority, true, -1f, true);
			}
		}
	}

	// Token: 0x0601A082 RID: 106626 RVA: 0x008072F0 File Offset: 0x008054F0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleGravityComponent vehicleGravityComponent = (VehicleGravityComponent)componentTemplate;
		if (vehicleGravityComponent.VehicleMoveComp == null)
		{
			this.VehicleMoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleMoveComp), "VehicleMoveComp"))
		{
			return false;
		}
		if (vehicleGravityComponent.PerformComp == null)
		{
			this.PerformComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PerformComp), "PerformComp"))
		{
			return false;
		}
		this.NeedResetPassengerGravity = vehicleGravityComponent.NeedResetPassengerGravity;
		return true;
	}

	// Token: 0x17002A52 RID: 10834
	// (get) Token: 0x0601A083 RID: 106627 RVA: 0x00807372 File Offset: 0x00805572
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A53 RID: 10835
	// (get) Token: 0x0601A084 RID: 106628 RVA: 0x00807375 File Offset: 0x00805575
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E439 RID: 58425
	[Nullable(2)]
	private VehicleMoveComponent VehicleMoveComp;

	// Token: 0x0400E43A RID: 58426
	[Nullable(2)]
	private BaseVehiclePerformComponent PerformComp;

	// Token: 0x0400E43B RID: 58427
	public bool NeedResetPassengerGravity;
}
