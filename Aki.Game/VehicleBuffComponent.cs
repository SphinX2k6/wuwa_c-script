using System;
using System.Runtime.CompilerServices;

// Token: 0x02002838 RID: 10296
[NullableContext(1)]
[Nullable(0)]
public class VehicleBuffComponent : CharacterBuffComponent
{
	// Token: 0x0601A044 RID: 106564 RVA: 0x00805B83 File Offset: 0x00803D83
	protected override bool OnStart()
	{
		this.VehiclePerformComp = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		this.MotorContextId = ((component != null) ? component.MotorContextId : 0L);
		return base.OnStart();
	}

	// Token: 0x0601A045 RID: 106565 RVA: 0x00805BBC File Offset: 0x00803DBC
	public override bool HasBuffAuthority()
	{
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null;
		int? id = PlayerInfoModel.Instance.GetId();
		int? num2 = num;
		return id.GetValueOrDefault() == num2.GetValueOrDefault() & id != null == (num2 != null);
	}

	// Token: 0x0601A046 RID: 106566 RVA: 0x00805C15 File Offset: 0x00803E15
	[NullableContext(2)]
	protected override bool NeedBroadcastBuff(ActiveBuffInternal buff, bool fromServer = false)
	{
		return (buff == null || !NoBroadCastBuff.Values.Contains(buff.Id)) && base.NeedBroadcastBuff(buff, fromServer);
	}

	// Token: 0x0601A047 RID: 106567 RVA: 0x00805C38 File Offset: 0x00803E38
	public override void AddBuff(long buffId, AddBuffParam buffParams)
	{
		if (buffParams.PreMessageId == null && this.MotorContextId != 0L)
		{
			buffParams.PreMessageId = new long?(this.MotorContextId);
		}
		base.AddBuff(buffId, buffParams);
	}

	// Token: 0x0601A048 RID: 106568 RVA: 0x00805C78 File Offset: 0x00803E78
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleBuffComponent vehicleBuffComponent = (VehicleBuffComponent)componentTemplate;
		if (vehicleBuffComponent.VehiclePerformComp == null)
		{
			this.VehiclePerformComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehiclePerformComp), "VehiclePerformComp"))
		{
			return false;
		}
		this.MotorContextId = vehicleBuffComponent.MotorContextId;
		return true;
	}

	// Token: 0x17002A42 RID: 10818
	// (get) Token: 0x0601A049 RID: 106569 RVA: 0x00805CCF File Offset: 0x00803ECF
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A43 RID: 10819
	// (get) Token: 0x0601A04A RID: 106570 RVA: 0x00805CD2 File Offset: 0x00803ED2
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A44 RID: 10820
	// (get) Token: 0x0601A04B RID: 106571 RVA: 0x00805CD5 File Offset: 0x00803ED5
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A45 RID: 10821
	// (get) Token: 0x0601A04C RID: 106572 RVA: 0x00805CD8 File Offset: 0x00803ED8
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A46 RID: 10822
	// (get) Token: 0x0601A04D RID: 106573 RVA: 0x00805CDB File Offset: 0x00803EDB
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A47 RID: 10823
	// (get) Token: 0x0601A04E RID: 106574 RVA: 0x00805CDE File Offset: 0x00803EDE
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E410 RID: 58384
	[Nullable(2)]
	public BaseVehiclePerformComponent VehiclePerformComp;

	// Token: 0x0400E411 RID: 58385
	public long MotorContextId;
}
