using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020032CB RID: 13003
[NullableContext(1)]
[Nullable(0)]
public class VehicleGravityComponent : BaseGravityComponent
{
	// Token: 0x0601C405 RID: 115717 RVA: 0x007E03CC File Offset: 0x007DE5CC
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

	// Token: 0x0601C406 RID: 115718 RVA: 0x007E0425 File Offset: 0x007DE625
	protected override bool OnEnd()
	{
		this.VehicleMoveComp = null;
		this.PerformComp = null;
		this.NeedResetPassengerGravity = false;
		return base.OnEnd();
	}

	// Token: 0x0601C407 RID: 115719 RVA: 0x007E0442 File Offset: 0x007DE642
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

	// Token: 0x0601C408 RID: 115720 RVA: 0x007E046C File Offset: 0x007DE66C
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

	// Token: 0x0601C409 RID: 115721 RVA: 0x007E04C8 File Offset: 0x007DE6C8
	public void SetGravityDirectForVehicle(int priority, IVector gravity, bool needResetPassengerGravity = false, float overrideSmoothTime = -1f, bool withoutRotate = false)
	{
		this.NeedResetPassengerGravity = needResetPassengerGravity;
		base.SetGravityByPriority(priority, gravity, true, overrideSmoothTime, withoutRotate);
		this.SyncPassengerGravity(gravity, priority);
	}

	// Token: 0x0601C40A RID: 115722 RVA: 0x007E04E6 File Offset: 0x007DE6E6
	public void StopGravityDirectForVehicle(int priority)
	{
		this.NeedResetPassengerGravity = false;
		base.StopGravityByPriority(priority, true, -1f, false);
		this.SyncPassengerGravityStop(priority);
	}

	// Token: 0x0601C40B RID: 115723 RVA: 0x007E0504 File Offset: 0x007DE704
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

	// Token: 0x0601C40C RID: 115724 RVA: 0x007E0588 File Offset: 0x007DE788
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

	// Token: 0x0601C40D RID: 115725 RVA: 0x007E060C File Offset: 0x007DE80C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleGravityComponent vehicleGravityComponent = (VehicleGravityComponent)componentTemplate;
		if (base.CanResetComponentProperty("VehicleMoveComp"))
		{
			if (vehicleGravityComponent.VehicleMoveComp == null)
			{
				this.VehicleMoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleMoveComponent>(this.VehicleMoveComp), "VehicleMoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PerformComp"))
		{
			if (vehicleGravityComponent.PerformComp == null)
			{
				this.PerformComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseVehiclePerformComponent>(this.PerformComp), "PerformComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("NeedResetPassengerGravity"))
		{
			this.NeedResetPassengerGravity = vehicleGravityComponent.NeedResetPassengerGravity;
		}
		return true;
	}

	// Token: 0x0400DF96 RID: 57238
	[Nullable(2)]
	private VehicleMoveComponent VehicleMoveComp;

	// Token: 0x0400DF97 RID: 57239
	[Nullable(2)]
	private BaseVehiclePerformComponent PerformComp;

	// Token: 0x0400DF98 RID: 57240
	public bool NeedResetPassengerGravity;
}
