using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200525A RID: 21082
	public class TVehicleConditionUnion
	{
		// Token: 0x17009692 RID: 38546
		// (get) Token: 0x06021307 RID: 135943 RVA: 0x00494A22 File Offset: 0x00492C22
		// (set) Token: 0x06021308 RID: 135944 RVA: 0x00494A2A File Offset: 0x00492C2A
		public TVehicleCondition Type { get; set; }

		// Token: 0x17009693 RID: 38547
		// (get) Token: 0x06021309 RID: 135945 RVA: 0x00494A33 File Offset: 0x00492C33
		// (set) Token: 0x0602130A RID: 135946 RVA: 0x00494A3B File Offset: 0x00492C3B
		public object Value { get; set; }

		// Token: 0x0602130B RID: 135947 RVA: 0x00494A44 File Offset: 0x00492C44
		public TVehicleConditionUnion()
		{
			this.Type = TVehicleCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602130C RID: 135948 RVA: 0x00494A5A File Offset: 0x00492C5A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602130D RID: 135949 RVA: 0x00494A6C File Offset: 0x00492C6C
		public ICheckIsPlayerUsingVehicleT AsICheckIsPlayerUsingVehicle()
		{
			return this.As<ICheckIsPlayerUsingVehicleT>();
		}

		// Token: 0x0602130E RID: 135950 RVA: 0x00494A74 File Offset: 0x00492C74
		public static TVehicleConditionUnion FromICheckIsPlayerUsingVehicle(ICheckIsPlayerUsingVehicleT _icheckisplayerusingvehicle)
		{
			return new TVehicleConditionUnion
			{
				Type = TVehicleCondition.ICheckIsPlayerUsingVehicle,
				Value = _icheckisplayerusingvehicle
			};
		}

		// Token: 0x0602130F RID: 135951 RVA: 0x00494A89 File Offset: 0x00492C89
		public ICheckIsUsingVehicleT AsICheckIsUsingVehicle()
		{
			return this.As<ICheckIsUsingVehicleT>();
		}

		// Token: 0x06021310 RID: 135952 RVA: 0x00494A91 File Offset: 0x00492C91
		public static TVehicleConditionUnion FromICheckIsUsingVehicle(ICheckIsUsingVehicleT _icheckisusingvehicle)
		{
			return new TVehicleConditionUnion
			{
				Type = TVehicleCondition.ICheckIsUsingVehicle,
				Value = _icheckisusingvehicle
			};
		}

		// Token: 0x06021311 RID: 135953 RVA: 0x00494AA6 File Offset: 0x00492CA6
		public ICheckVehicleSpeedConditionT AsICheckVehicleSpeedCondition()
		{
			return this.As<ICheckVehicleSpeedConditionT>();
		}

		// Token: 0x06021312 RID: 135954 RVA: 0x00494AAE File Offset: 0x00492CAE
		public static TVehicleConditionUnion FromICheckVehicleSpeedCondition(ICheckVehicleSpeedConditionT _icheckvehiclespeedcondition)
		{
			return new TVehicleConditionUnion
			{
				Type = TVehicleCondition.ICheckVehicleSpeedCondition,
				Value = _icheckvehiclespeedcondition
			};
		}

		// Token: 0x06021313 RID: 135955 RVA: 0x00494AC3 File Offset: 0x00492CC3
		public ICheckVehicleTriggerAngleConditionT AsICheckVehicleTriggerAngleCondition()
		{
			return this.As<ICheckVehicleTriggerAngleConditionT>();
		}

		// Token: 0x06021314 RID: 135956 RVA: 0x00494ACB File Offset: 0x00492CCB
		public static TVehicleConditionUnion FromICheckVehicleTriggerAngleCondition(ICheckVehicleTriggerAngleConditionT _icheckvehicletriggeranglecondition)
		{
			return new TVehicleConditionUnion
			{
				Type = TVehicleCondition.ICheckVehicleTriggerAngleCondition,
				Value = _icheckvehicletriggeranglecondition
			};
		}

		// Token: 0x06021315 RID: 135957 RVA: 0x00494AE0 File Offset: 0x00492CE0
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
