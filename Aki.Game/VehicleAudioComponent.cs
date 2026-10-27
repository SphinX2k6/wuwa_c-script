using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020032C6 RID: 12998
[NullableContext(1)]
[Nullable(0)]
public class VehicleAudioComponent : BaseAudioComponent
{
	// Token: 0x1700272F RID: 10031
	// (get) Token: 0x0601C3D3 RID: 115667 RVA: 0x007DEC99 File Offset: 0x007DCE99
	[Nullable(2)]
	protected new VehicleActorComponent ActorComp
	{
		[NullableContext(2)]
		get
		{
			return this.ActorComp as VehicleActorComponent;
		}
	}

	// Token: 0x0601C3D4 RID: 115668 RVA: 0x007DECA8 File Offset: 0x007DCEA8
	protected override bool OnInit()
	{
		base.OnInit();
		this.ActorComp = base.Entity.CheckGetComponent<VehicleActorComponent>();
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
		return true;
	}

	// Token: 0x0601C3D5 RID: 115669 RVA: 0x007DED14 File Offset: 0x007DCF14
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

	// Token: 0x0601C3D6 RID: 115670 RVA: 0x007DEDB5 File Offset: 0x007DCFB5
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

	// Token: 0x0601C3D7 RID: 115671 RVA: 0x007DEDEB File Offset: 0x007DCFEB
	private void InitVehicleAudioPlayPriority()
	{
	}

	// Token: 0x0601C3D8 RID: 115672 RVA: 0x007DEDED File Offset: 0x007DCFED
	public virtual void UpdateVehicleMoveSound(float speed, AActor owner)
	{
	}

	// Token: 0x0601C3D9 RID: 115673 RVA: 0x007DEDEF File Offset: 0x007DCFEF
	protected virtual void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
	{
	}

	// Token: 0x0601C3DA RID: 115674 RVA: 0x007DEDF1 File Offset: 0x007DCFF1
	protected virtual void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
	{
	}

	// Token: 0x0601C3DB RID: 115675 RVA: 0x007DEDF3 File Offset: 0x007DCFF3
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleAudioComponent vehicleAudioComponent = (VehicleAudioComponent)componentTemplate;
		return true;
	}
}
