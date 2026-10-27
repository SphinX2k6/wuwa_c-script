using System;
using System.Runtime.CompilerServices;

// Token: 0x020032C7 RID: 12999
[NullableContext(1)]
[Nullable(0)]
public class VehicleBuffComponent : CharacterBuffComponent
{
	// Token: 0x0601C3DD RID: 115677 RVA: 0x007DEE10 File Offset: 0x007DD010
	protected override bool OnStart()
	{
		this.VehiclePerformComp = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		this.MotorContextId = ((component != null) ? component.MotorContextId : 0L);
		return base.OnStart();
	}

	// Token: 0x0601C3DE RID: 115678 RVA: 0x007DEE48 File Offset: 0x007DD048
	public override bool HasBuffAuthority()
	{
		CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
		int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null;
		int? id = PlayerInfoModel.Instance.GetId();
		int? num2 = num;
		return id.GetValueOrDefault() == num2.GetValueOrDefault() & id != null == (num2 != null);
	}

	// Token: 0x0601C3DF RID: 115679 RVA: 0x007DEEA1 File Offset: 0x007DD0A1
	[NullableContext(2)]
	protected override bool NeedBroadcastBuff(ActiveBuffInternal buff, bool fromServer = false)
	{
		return (buff == null || !NoBroadCastBuff.Values.Contains(buff.Id)) && base.NeedBroadcastBuff(buff, fromServer);
	}

	// Token: 0x0601C3E0 RID: 115680 RVA: 0x007DEEC4 File Offset: 0x007DD0C4
	public override void AddBuff(long buffId, AddBuffParam buffParams)
	{
		if (buffParams.PreMessageId == null && this.MotorContextId != 0L)
		{
			buffParams.PreMessageId = new long?(this.MotorContextId);
		}
		base.AddBuff(buffId, buffParams);
	}

	// Token: 0x0601C3E1 RID: 115681 RVA: 0x007DEF04 File Offset: 0x007DD104
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleBuffComponent vehicleBuffComponent = (VehicleBuffComponent)componentTemplate;
		if (base.CanResetComponentProperty("VehiclePerformComp"))
		{
			if (vehicleBuffComponent.VehiclePerformComp == null)
			{
				this.VehiclePerformComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseVehiclePerformComponent>(this.VehiclePerformComp), "VehiclePerformComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MotorContextId"))
		{
			this.MotorContextId = vehicleBuffComponent.MotorContextId;
		}
		return true;
	}

	// Token: 0x0400DF6D RID: 57197
	[Nullable(2)]
	public BaseVehiclePerformComponent VehiclePerformComp;

	// Token: 0x0400DF6E RID: 57198
	public long MotorContextId;
}
