using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D10 RID: 19728
	public class IVehicleCondition_UnionUnion
	{
		// Token: 0x17008F14 RID: 36628
		// (get) Token: 0x0601F4F6 RID: 128246 RVA: 0x0045DE65 File Offset: 0x0045C065
		// (set) Token: 0x0601F4F7 RID: 128247 RVA: 0x0045DE6D File Offset: 0x0045C06D
		public IVehicleCondition_Union Type { get; set; }

		// Token: 0x17008F15 RID: 36629
		// (get) Token: 0x0601F4F8 RID: 128248 RVA: 0x0045DE76 File Offset: 0x0045C076
		// (set) Token: 0x0601F4F9 RID: 128249 RVA: 0x0045DE7E File Offset: 0x0045C07E
		public object Value { get; set; }

		// Token: 0x0601F4FA RID: 128250 RVA: 0x0045DE87 File Offset: 0x0045C087
		public IVehicleCondition_UnionUnion()
		{
			this.Type = IVehicleCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F4FB RID: 128251 RVA: 0x0045DE9D File Offset: 0x0045C09D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F4FC RID: 128252 RVA: 0x0045DEAF File Offset: 0x0045C0AF
		public IVehicleConditionT AsIVehicleCondition()
		{
			return this.As<IVehicleConditionT>();
		}

		// Token: 0x0601F4FD RID: 128253 RVA: 0x0045DEB7 File Offset: 0x0045C0B7
		public static IVehicleCondition_UnionUnion FromIVehicleCondition(IVehicleConditionT _ivehiclecondition)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.IVehicleCondition,
				Value = _ivehiclecondition
			};
		}

		// Token: 0x0601F4FE RID: 128254 RVA: 0x0045DECC File Offset: 0x0045C0CC
		public ICheckIsUsingVehicleT AsICheckIsUsingVehicle()
		{
			return this.As<ICheckIsUsingVehicleT>();
		}

		// Token: 0x0601F4FF RID: 128255 RVA: 0x0045DED4 File Offset: 0x0045C0D4
		public static IVehicleCondition_UnionUnion FromICheckIsUsingVehicle(ICheckIsUsingVehicleT _icheckisusingvehicle)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.ICheckIsUsingVehicle,
				Value = _icheckisusingvehicle
			};
		}

		// Token: 0x0601F500 RID: 128256 RVA: 0x0045DEE9 File Offset: 0x0045C0E9
		public ICheckIsPlayerUsingVehicleT AsICheckIsPlayerUsingVehicle()
		{
			return this.As<ICheckIsPlayerUsingVehicleT>();
		}

		// Token: 0x0601F501 RID: 128257 RVA: 0x0045DEF1 File Offset: 0x0045C0F1
		public static IVehicleCondition_UnionUnion FromICheckIsPlayerUsingVehicle(ICheckIsPlayerUsingVehicleT _icheckisplayerusingvehicle)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.ICheckIsPlayerUsingVehicle,
				Value = _icheckisplayerusingvehicle
			};
		}

		// Token: 0x0601F502 RID: 128258 RVA: 0x0045DF06 File Offset: 0x0045C106
		public ICheckVehicleSpeedConditionT AsICheckVehicleSpeedCondition()
		{
			return this.As<ICheckVehicleSpeedConditionT>();
		}

		// Token: 0x0601F503 RID: 128259 RVA: 0x0045DF0E File Offset: 0x0045C10E
		public static IVehicleCondition_UnionUnion FromICheckVehicleSpeedCondition(ICheckVehicleSpeedConditionT _icheckvehiclespeedcondition)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.ICheckVehicleSpeedCondition,
				Value = _icheckvehiclespeedcondition
			};
		}

		// Token: 0x0601F504 RID: 128260 RVA: 0x0045DF23 File Offset: 0x0045C123
		public ICheckVehicleTriggerAngleConditionT AsICheckVehicleTriggerAngleCondition()
		{
			return this.As<ICheckVehicleTriggerAngleConditionT>();
		}

		// Token: 0x0601F505 RID: 128261 RVA: 0x0045DF2B File Offset: 0x0045C12B
		public static IVehicleCondition_UnionUnion FromICheckVehicleTriggerAngleCondition(ICheckVehicleTriggerAngleConditionT _icheckvehicletriggeranglecondition)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.ICheckVehicleTriggerAngleCondition,
				Value = _icheckvehicletriggeranglecondition
			};
		}

		// Token: 0x0601F506 RID: 128262 RVA: 0x0045DF40 File Offset: 0x0045C140
		public static int Pack(FlatBufferBuilder builder, IVehicleCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVehicleCondition_Union.IVehicleCondition:
				return IVehicleCondition.Pack(builder, _o.AsIVehicleCondition()).Value;
			case IVehicleCondition_Union.ICheckIsUsingVehicle:
				return ICheckIsUsingVehicle.Pack(builder, _o.AsICheckIsUsingVehicle()).Value;
			case IVehicleCondition_Union.ICheckIsPlayerUsingVehicle:
				return ICheckIsPlayerUsingVehicle.Pack(builder, _o.AsICheckIsPlayerUsingVehicle()).Value;
			case IVehicleCondition_Union.ICheckVehicleSpeedCondition:
				return ICheckVehicleSpeedCondition.Pack(builder, _o.AsICheckVehicleSpeedCondition()).Value;
			case IVehicleCondition_Union.ICheckVehicleTriggerAngleCondition:
				return ICheckVehicleTriggerAngleCondition.Pack(builder, _o.AsICheckVehicleTriggerAngleCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
