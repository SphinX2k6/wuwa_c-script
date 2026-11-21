using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200283B RID: 10299
[NullableContext(2)]
[Nullable(0)]
public class VehicleFrozenComponent : MonsterFrozenComponent
{
	// Token: 0x0601A06E RID: 106606 RVA: 0x00806E84 File Offset: 0x00805084
	protected override bool OnStart()
	{
		base.OnStart();
		this.AddEvent();
		this.VehiclePerformComponent = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		return true;
	}

	// Token: 0x0601A06F RID: 106607 RVA: 0x00806EA5 File Offset: 0x008050A5
	protected override bool OnEnd()
	{
		base.OnEnd();
		this.RemoveEvent();
		return true;
	}

	// Token: 0x0601A070 RID: 106608 RVA: 0x00806EB8 File Offset: 0x008050B8
	private void AddEvent()
	{
		if (!EventSystem.Instance.HasWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange)))
		{
			EventSystem.Instance.AddWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
		}
	}

	// Token: 0x0601A071 RID: 106609 RVA: 0x00806F0C File Offset: 0x0080510C
	private void RemoveEvent()
	{
		if (EventSystem.Instance.HasWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange)))
		{
			EventSystem.Instance.RemoveWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
		}
	}

	// Token: 0x0601A072 RID: 106610 RVA: 0x00806F60 File Offset: 0x00805160
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

	// Token: 0x0601A073 RID: 106611 RVA: 0x00806FE4 File Offset: 0x008051E4
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

	// Token: 0x0601A074 RID: 106612 RVA: 0x00807057 File Offset: 0x00805257
	private void OnFrozenChange(bool _)
	{
		this.RefreshFrozen();
	}

	// Token: 0x0601A075 RID: 106613 RVA: 0x0080705F File Offset: 0x0080525F
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		if (((VehicleFrozenComponent)componentTemplate).VehiclePerformComponent == null)
		{
			this.VehiclePerformComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehiclePerformComponent), "VehiclePerformComponent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002A4F RID: 10831
	// (get) Token: 0x0601A076 RID: 106614 RVA: 0x0080709D File Offset: 0x0080529D
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A50 RID: 10832
	// (get) Token: 0x0601A077 RID: 106615 RVA: 0x008070A0 File Offset: 0x008052A0
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A51 RID: 10833
	// (get) Token: 0x0601A078 RID: 106616 RVA: 0x008070A3 File Offset: 0x008052A3
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E438 RID: 58424
	protected BaseVehiclePerformComponent VehiclePerformComponent;
}
