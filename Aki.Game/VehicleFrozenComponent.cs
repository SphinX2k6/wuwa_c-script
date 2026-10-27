using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020032CA RID: 13002
[NullableContext(2)]
[Nullable(0)]
public class VehicleFrozenComponent : MonsterFrozenComponent
{
	// Token: 0x0601C3FC RID: 115708 RVA: 0x007E0190 File Offset: 0x007DE390
	protected override bool OnStart()
	{
		base.OnStart();
		this.AddEvent();
		this.VehiclePerformComponent = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		return true;
	}

	// Token: 0x0601C3FD RID: 115709 RVA: 0x007E01B1 File Offset: 0x007DE3B1
	protected override bool OnEnd()
	{
		base.OnEnd();
		this.RemoveEvent();
		return true;
	}

	// Token: 0x0601C3FE RID: 115710 RVA: 0x007E01C4 File Offset: 0x007DE3C4
	private void AddEvent()
	{
		if (!EventSystem.Instance.HasWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange)))
		{
			EventSystem.Instance.AddWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
		}
	}

	// Token: 0x0601C3FF RID: 115711 RVA: 0x007E0218 File Offset: 0x007DE418
	private void RemoveEvent()
	{
		if (EventSystem.Instance.HasWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange)))
		{
			EventSystem.Instance.RemoveWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
		}
	}

	// Token: 0x0601C400 RID: 115712 RVA: 0x007E026C File Offset: 0x007DE46C
	private void OnVehicleDriverChange(Entity preDriver, Entity newDriver)
	{
		if (preDriver != null && EventSystem.Instance.HasWithTarget<bool>(preDriver, EEventName.CharAfterFrozenChange, new Action<bool>(this.OnFrozenChange)))
		{
			EventSystem.Instance.RemoveWithTarget<bool>(preDriver, EEventName.CharAfterFrozenChange, new Action<bool>(this.OnFrozenChange));
		}
		if (newDriver != null && !EventSystem.Instance.HasWithTarget<bool>(newDriver, EEventName.CharAfterFrozenChange, new Action<bool>(this.OnFrozenChange)))
		{
			EventSystem.Instance.AddWithTarget<bool>(newDriver, EEventName.CharAfterFrozenChange, new Action<bool>(this.OnFrozenChange));
		}
		this.RefreshFrozen();
	}

	// Token: 0x0601C401 RID: 115713 RVA: 0x007E02F0 File Offset: 0x007DE4F0
	protected override void RefreshFrozen()
	{
		if (this.FrozenLockSet.Count > 0)
		{
			this.SetFrozen(true);
			return;
		}
		BaseVehiclePerformComponent vehiclePerformComponent = this.VehiclePerformComponent;
		Entity entity = (vehiclePerformComponent != null) ? vehiclePerformComponent.Driver : null;
		bool flag;
		if (entity == null)
		{
			flag = false;
		}
		else
		{
			BaseFrozenComponent component = entity.GetComponent<BaseFrozenComponent>();
			flag = ((component != null) ? new bool?(component.IsFrozen()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			this.SetFrozen(true);
			return;
		}
		this.SetFrozen(false);
	}

	// Token: 0x0601C402 RID: 115714 RVA: 0x007E0363 File Offset: 0x007DE563
	private void OnFrozenChange(bool _)
	{
		this.RefreshFrozen();
	}

	// Token: 0x0601C403 RID: 115715 RVA: 0x007E036C File Offset: 0x007DE56C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleFrozenComponent vehicleFrozenComponent = (VehicleFrozenComponent)componentTemplate;
		if (base.CanResetComponentProperty("VehiclePerformComponent"))
		{
			if (vehicleFrozenComponent.VehiclePerformComponent == null)
			{
				this.VehiclePerformComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseVehiclePerformComponent>(this.VehiclePerformComponent), "VehiclePerformComponent"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DF95 RID: 57237
	protected BaseVehiclePerformComponent VehiclePerformComponent;
}
