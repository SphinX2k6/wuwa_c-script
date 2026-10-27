using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D5E RID: 19806
	public class TVehicleConditionUnion
	{
		// Token: 0x17008F59 RID: 36697
		// (get) Token: 0x0601F6BE RID: 128702 RVA: 0x00460A4E File Offset: 0x0045EC4E
		// (set) Token: 0x0601F6BF RID: 128703 RVA: 0x00460A56 File Offset: 0x0045EC56
		public TVehicleCondition Type { get; set; }

		// Token: 0x17008F5A RID: 36698
		// (get) Token: 0x0601F6C0 RID: 128704 RVA: 0x00460A5F File Offset: 0x0045EC5F
		// (set) Token: 0x0601F6C1 RID: 128705 RVA: 0x00460A67 File Offset: 0x0045EC67
		public object Value { get; set; }

		// Token: 0x0601F6C2 RID: 128706 RVA: 0x00460A70 File Offset: 0x0045EC70
		public TVehicleConditionUnion()
		{
			this.Type = TVehicleCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601F6C3 RID: 128707 RVA: 0x00460A86 File Offset: 0x0045EC86
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F6C4 RID: 128708 RVA: 0x00460A98 File Offset: 0x0045EC98
		public ICheckIsPlayerUsingVehicleT AsICheckIsPlayerUsingVehicle()
		{
			return this.As<ICheckIsPlayerUsingVehicleT>();
		}

		// Token: 0x0601F6C5 RID: 128709 RVA: 0x00460AA0 File Offset: 0x0045ECA0
		public static TVehicleConditionUnion FromICheckIsPlayerUsingVehicle(ICheckIsPlayerUsingVehicleT _icheckisplayerusingvehicle)
		{
			return new TVehicleConditionUnion
			{
				Type = TVehicleCondition.ICheckIsPlayerUsingVehicle,
				Value = _icheckisplayerusingvehicle
			};
		}

		// Token: 0x0601F6C6 RID: 128710 RVA: 0x00460AB5 File Offset: 0x0045ECB5
		public ICheckIsUsingVehicleT AsICheckIsUsingVehicle()
		{
			return this.As<ICheckIsUsingVehicleT>();
		}

		// Token: 0x0601F6C7 RID: 128711 RVA: 0x00460ABD File Offset: 0x0045ECBD
		public static TVehicleConditionUnion FromICheckIsUsingVehicle(ICheckIsUsingVehicleT _icheckisusingvehicle)
		{
			return new TVehicleConditionUnion
			{
				Type = TVehicleCondition.ICheckIsUsingVehicle,
				Value = _icheckisusingvehicle
			};
		}

		// Token: 0x0601F6C8 RID: 128712 RVA: 0x00460AD2 File Offset: 0x0045ECD2
		public ICheckVehicleSpeedConditionT AsICheckVehicleSpeedCondition()
		{
			return this.As<ICheckVehicleSpeedConditionT>();
		}

		// Token: 0x0601F6C9 RID: 128713 RVA: 0x00460ADA File Offset: 0x0045ECDA
		public static TVehicleConditionUnion FromICheckVehicleSpeedCondition(ICheckVehicleSpeedConditionT _icheckvehiclespeedcondition)
		{
			return new TVehicleConditionUnion
			{
				Type = TVehicleCondition.ICheckVehicleSpeedCondition,
				Value = _icheckvehiclespeedcondition
			};
		}

		// Token: 0x0601F6CA RID: 128714 RVA: 0x00460AEF File Offset: 0x0045ECEF
		public ICheckVehicleTriggerAngleConditionT AsICheckVehicleTriggerAngleCondition()
		{
			return this.As<ICheckVehicleTriggerAngleConditionT>();
		}

		// Token: 0x0601F6CB RID: 128715 RVA: 0x00460AF7 File Offset: 0x0045ECF7
		public static TVehicleConditionUnion FromICheckVehicleTriggerAngleCondition(ICheckVehicleTriggerAngleConditionT _icheckvehicletriggeranglecondition)
		{
			return new TVehicleConditionUnion
			{
				Type = TVehicleCondition.ICheckVehicleTriggerAngleCondition,
				Value = _icheckvehicletriggeranglecondition
			};
		}

		// Token: 0x0601F6CC RID: 128716 RVA: 0x00460B0C File Offset: 0x0045ED0C
		public static int Pack(FlatBufferBuilder builder, TVehicleConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TVehicleCondition.ICheckIsPlayerUsingVehicle:
				return ICheckIsPlayerUsingVehicle.Pack(builder, _o.AsICheckIsPlayerUsingVehicle()).Value;
			case TVehicleCondition.ICheckIsUsingVehicle:
				return ICheckIsUsingVehicle.Pack(builder, _o.AsICheckIsUsingVehicle()).Value;
			case TVehicleCondition.ICheckVehicleSpeedCondition:
				return ICheckVehicleSpeedCondition.Pack(builder, _o.AsICheckVehicleSpeedCondition()).Value;
			case TVehicleCondition.ICheckVehicleTriggerAngleCondition:
				return ICheckVehicleTriggerAngleCondition.Pack(builder, _o.AsICheckVehicleTriggerAngleCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
