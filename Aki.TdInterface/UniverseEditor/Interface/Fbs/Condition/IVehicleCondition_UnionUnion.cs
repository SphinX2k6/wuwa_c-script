using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200520C RID: 21004
	public class IVehicleCondition_UnionUnion
	{
		// Token: 0x1700964D RID: 38477
		// (get) Token: 0x0602113B RID: 135483 RVA: 0x00491DB5 File Offset: 0x0048FFB5
		// (set) Token: 0x0602113C RID: 135484 RVA: 0x00491DBD File Offset: 0x0048FFBD
		public IVehicleCondition_Union Type { get; set; }

		// Token: 0x1700964E RID: 38478
		// (get) Token: 0x0602113D RID: 135485 RVA: 0x00491DC6 File Offset: 0x0048FFC6
		// (set) Token: 0x0602113E RID: 135486 RVA: 0x00491DCE File Offset: 0x0048FFCE
		public object Value { get; set; }

		// Token: 0x0602113F RID: 135487 RVA: 0x00491DD7 File Offset: 0x0048FFD7
		public IVehicleCondition_UnionUnion()
		{
			this.Type = IVehicleCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021140 RID: 135488 RVA: 0x00491DED File Offset: 0x0048FFED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021141 RID: 135489 RVA: 0x00491DFF File Offset: 0x0048FFFF
		public IVehicleConditionT AsIVehicleCondition()
		{
			return this.As<IVehicleConditionT>();
		}

		// Token: 0x06021142 RID: 135490 RVA: 0x00491E07 File Offset: 0x00490007
		public static IVehicleCondition_UnionUnion FromIVehicleCondition(IVehicleConditionT _ivehiclecondition)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.IVehicleCondition,
				Value = _ivehiclecondition
			};
		}

		// Token: 0x06021143 RID: 135491 RVA: 0x00491E1C File Offset: 0x0049001C
		public ICheckIsUsingVehicleT AsICheckIsUsingVehicle()
		{
			return this.As<ICheckIsUsingVehicleT>();
		}

		// Token: 0x06021144 RID: 135492 RVA: 0x00491E24 File Offset: 0x00490024
		public static IVehicleCondition_UnionUnion FromICheckIsUsingVehicle(ICheckIsUsingVehicleT _icheckisusingvehicle)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.ICheckIsUsingVehicle,
				Value = _icheckisusingvehicle
			};
		}

		// Token: 0x06021145 RID: 135493 RVA: 0x00491E39 File Offset: 0x00490039
		public ICheckIsPlayerUsingVehicleT AsICheckIsPlayerUsingVehicle()
		{
			return this.As<ICheckIsPlayerUsingVehicleT>();
		}

		// Token: 0x06021146 RID: 135494 RVA: 0x00491E41 File Offset: 0x00490041
		public static IVehicleCondition_UnionUnion FromICheckIsPlayerUsingVehicle(ICheckIsPlayerUsingVehicleT _icheckisplayerusingvehicle)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.ICheckIsPlayerUsingVehicle,
				Value = _icheckisplayerusingvehicle
			};
		}

		// Token: 0x06021147 RID: 135495 RVA: 0x00491E56 File Offset: 0x00490056
		public ICheckVehicleSpeedConditionT AsICheckVehicleSpeedCondition()
		{
			return this.As<ICheckVehicleSpeedConditionT>();
		}

		// Token: 0x06021148 RID: 135496 RVA: 0x00491E5E File Offset: 0x0049005E
		public static IVehicleCondition_UnionUnion FromICheckVehicleSpeedCondition(ICheckVehicleSpeedConditionT _icheckvehiclespeedcondition)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.ICheckVehicleSpeedCondition,
				Value = _icheckvehiclespeedcondition
			};
		}

		// Token: 0x06021149 RID: 135497 RVA: 0x00491E73 File Offset: 0x00490073
		public ICheckVehicleTriggerAngleConditionT AsICheckVehicleTriggerAngleCondition()
		{
			return this.As<ICheckVehicleTriggerAngleConditionT>();
		}

		// Token: 0x0602114A RID: 135498 RVA: 0x00491E7B File Offset: 0x0049007B
		public static IVehicleCondition_UnionUnion FromICheckVehicleTriggerAngleCondition(ICheckVehicleTriggerAngleConditionT _icheckvehicletriggeranglecondition)
		{
			return new IVehicleCondition_UnionUnion
			{
				Type = IVehicleCondition_Union.ICheckVehicleTriggerAngleCondition,
				Value = _icheckvehicletriggeranglecondition
			};
		}

		// Token: 0x0602114B RID: 135499 RVA: 0x00491E90 File Offset: 0x00490090
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
