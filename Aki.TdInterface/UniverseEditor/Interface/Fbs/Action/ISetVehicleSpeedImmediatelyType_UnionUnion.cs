using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007876 RID: 30838
	public class ISetVehicleSpeedImmediatelyType_UnionUnion
	{
		// Token: 0x1700E224 RID: 57892
		// (get) Token: 0x060363C3 RID: 222147 RVA: 0x00743CD9 File Offset: 0x00741ED9
		// (set) Token: 0x060363C4 RID: 222148 RVA: 0x00743CE1 File Offset: 0x00741EE1
		public ISetVehicleSpeedImmediatelyType_Union Type { get; set; }

		// Token: 0x1700E225 RID: 57893
		// (get) Token: 0x060363C5 RID: 222149 RVA: 0x00743CEA File Offset: 0x00741EEA
		// (set) Token: 0x060363C6 RID: 222150 RVA: 0x00743CF2 File Offset: 0x00741EF2
		public object Value { get; set; }

		// Token: 0x060363C7 RID: 222151 RVA: 0x00743CFB File Offset: 0x00741EFB
		public ISetVehicleSpeedImmediatelyType_UnionUnion()
		{
			this.Type = ISetVehicleSpeedImmediatelyType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060363C8 RID: 222152 RVA: 0x00743D11 File Offset: 0x00741F11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060363C9 RID: 222153 RVA: 0x00743D23 File Offset: 0x00741F23
		public ISetVehicleSpeedImmediatelyTypeT AsISetVehicleSpeedImmediatelyType()
		{
			return this.As<ISetVehicleSpeedImmediatelyTypeT>();
		}

		// Token: 0x060363CA RID: 222154 RVA: 0x00743D2B File Offset: 0x00741F2B
		public static ISetVehicleSpeedImmediatelyType_UnionUnion FromISetVehicleSpeedImmediatelyType(ISetVehicleSpeedImmediatelyTypeT _isetvehiclespeedimmediatelytype)
		{
			return new ISetVehicleSpeedImmediatelyType_UnionUnion
			{
				Type = ISetVehicleSpeedImmediatelyType_Union.ISetVehicleSpeedImmediatelyType,
				Value = _isetvehiclespeedimmediatelytype
			};
		}

		// Token: 0x060363CB RID: 222155 RVA: 0x00743D40 File Offset: 0x00741F40
		public ISetTotalVehicleSpeedImmediatelyT AsISetTotalVehicleSpeedImmediately()
		{
			return this.As<ISetTotalVehicleSpeedImmediatelyT>();
		}

		// Token: 0x060363CC RID: 222156 RVA: 0x00743D48 File Offset: 0x00741F48
		public static ISetVehicleSpeedImmediatelyType_UnionUnion FromISetTotalVehicleSpeedImmediately(ISetTotalVehicleSpeedImmediatelyT _isettotalvehiclespeedimmediately)
		{
			return new ISetVehicleSpeedImmediatelyType_UnionUnion
			{
				Type = ISetVehicleSpeedImmediatelyType_Union.ISetTotalVehicleSpeedImmediately,
				Value = _isettotalvehiclespeedimmediately
			};
		}

		// Token: 0x060363CD RID: 222157 RVA: 0x00743D5D File Offset: 0x00741F5D
		public ISetHorizontalVerticalSpeedImmediatelyT AsISetHorizontalVerticalSpeedImmediately()
		{
			return this.As<ISetHorizontalVerticalSpeedImmediatelyT>();
		}

		// Token: 0x060363CE RID: 222158 RVA: 0x00743D65 File Offset: 0x00741F65
		public static ISetVehicleSpeedImmediatelyType_UnionUnion FromISetHorizontalVerticalSpeedImmediately(ISetHorizontalVerticalSpeedImmediatelyT _isethorizontalverticalspeedimmediately)
		{
			return new ISetVehicleSpeedImmediatelyType_UnionUnion
			{
				Type = ISetVehicleSpeedImmediatelyType_Union.ISetHorizontalVerticalSpeedImmediately,
				Value = _isethorizontalverticalspeedimmediately
			};
		}

		// Token: 0x060363CF RID: 222159 RVA: 0x00743D7C File Offset: 0x00741F7C
		public static int Pack(FlatBufferBuilder builder, ISetVehicleSpeedImmediatelyType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISetVehicleSpeedImmediatelyType_Union.ISetVehicleSpeedImmediatelyType:
				return ISetVehicleSpeedImmediatelyType.Pack(builder, _o.AsISetVehicleSpeedImmediatelyType()).Value;
			case ISetVehicleSpeedImmediatelyType_Union.ISetTotalVehicleSpeedImmediately:
				return ISetTotalVehicleSpeedImmediately.Pack(builder, _o.AsISetTotalVehicleSpeedImmediately()).Value;
			case ISetVehicleSpeedImmediatelyType_Union.ISetHorizontalVerticalSpeedImmediately:
				return ISetHorizontalVerticalSpeedImmediately.Pack(builder, _o.AsISetHorizontalVerticalSpeedImmediately()).Value;
			default:
				return 0;
			}
		}
	}
}
