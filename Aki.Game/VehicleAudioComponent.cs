using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002837 RID: 10295
[NullableContext(1)]
[Nullable(0)]
public class VehicleAudioComponent : BaseAudioComponent
{
	// Token: 0x17002A3D RID: 10813
	// (get) Token: 0x0601A037 RID: 106551 RVA: 0x00805A15 File Offset: 0x00803C15
	[Nullable(2)]
	protected new VehicleActorComponent ActorComp
	{
		[NullableContext(2)]
		get
		{
			return this.ActorComp as VehicleActorComponent;
		}
	}

	// Token: 0x0601A038 RID: 106552 RVA: 0x00805A24 File Offset: 0x00803C24
	protected override bool OnInit()
	{
		base.OnInit();
		this.ActorComp = base.Entity.CheckGetComponent<VehicleActorComponent>();
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
		return true;
	}

	// Token: 0x0601A039 RID: 106553 RVA: 0x00805A90 File Offset: 0x00803C90
	protected override bool OnClear()
	{
		if (EventSystem.Instance.HasWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered)))
		{
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
		}
		if (EventSystem.Instance.HasWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved)))
		{
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
		}
		return base.OnClear();
	}

	// Token: 0x0601A03A RID: 106554 RVA: 0x00805B31 File Offset: 0x00803D31
	protected override bool OnStart()
	{
		base.OnStart();
		VehicleActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Valid || this.ActorComp.Owner == null)
		{
			return false;
		}
		this.InitVehicleAudioPlayPriority();
		return true;
	}

	// Token: 0x0601A03B RID: 106555 RVA: 0x00805B67 File Offset: 0x00803D67
	private void InitVehicleAudioPlayPriority()
	{
	}

	// Token: 0x0601A03C RID: 106556 RVA: 0x00805B69 File Offset: 0x00803D69
	public virtual void UpdateVehicleMoveSound(float speed, AActor owner)
	{
	}

	// Token: 0x0601A03D RID: 106557 RVA: 0x00805B6B File Offset: 0x00803D6B
	protected virtual void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
	{
	}

	// Token: 0x0601A03E RID: 106558 RVA: 0x00805B6D File Offset: 0x00803D6D
	protected virtual void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
	{
	}

	// Token: 0x17002A3E RID: 10814
	// (get) Token: 0x0601A03F RID: 106559 RVA: 0x00805B6F File Offset: 0x00803D6F
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A3F RID: 10815
	// (get) Token: 0x0601A040 RID: 106560 RVA: 0x00805B72 File Offset: 0x00803D72
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A40 RID: 10816
	// (get) Token: 0x0601A041 RID: 106561 RVA: 0x00805B75 File Offset: 0x00803D75
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A41 RID: 10817
	// (get) Token: 0x0601A042 RID: 106562 RVA: 0x00805B78 File Offset: 0x00803D78
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}
}
