using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AA RID: 28842
	public class ISetVehicleSpeedImmediatelyType_UnionUnion
	{
		// Token: 0x1700D641 RID: 54849
		// (get) Token: 0x06033121 RID: 209185 RVA: 0x006E36CD File Offset: 0x006E18CD
		// (set) Token: 0x06033122 RID: 209186 RVA: 0x006E36D5 File Offset: 0x006E18D5
		public ISetVehicleSpeedImmediatelyType_Union Type { get; set; }

		// Token: 0x1700D642 RID: 54850
		// (get) Token: 0x06033123 RID: 209187 RVA: 0x006E36DE File Offset: 0x006E18DE
		// (set) Token: 0x06033124 RID: 209188 RVA: 0x006E36E6 File Offset: 0x006E18E6
		public object Value { get; set; }

		// Token: 0x06033125 RID: 209189 RVA: 0x006E36EF File Offset: 0x006E18EF
		public ISetVehicleSpeedImmediatelyType_UnionUnion()
		{
			this.Type = ISetVehicleSpeedImmediatelyType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033126 RID: 209190 RVA: 0x006E3705 File Offset: 0x006E1905
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033127 RID: 209191 RVA: 0x006E3717 File Offset: 0x006E1917
		public ISetVehicleSpeedImmediatelyTypeT AsISetVehicleSpeedImmediatelyType()
		{
			return this.As<ISetVehicleSpeedImmediatelyTypeT>();
		}

		// Token: 0x06033128 RID: 209192 RVA: 0x006E371F File Offset: 0x006E191F
		public static ISetVehicleSpeedImmediatelyType_UnionUnion FromISetVehicleSpeedImmediatelyType(ISetVehicleSpeedImmediatelyTypeT _isetvehiclespeedimmediatelytype)
		{
			return new ISetVehicleSpeedImmediatelyType_UnionUnion
			{
				Type = ISetVehicleSpeedImmediatelyType_Union.ISetVehicleSpeedImmediatelyType,
				Value = _isetvehiclespeedimmediatelytype
			};
		}

		// Token: 0x06033129 RID: 209193 RVA: 0x006E3734 File Offset: 0x006E1934
		public ISetTotalVehicleSpeedImmediatelyT AsISetTotalVehicleSpeedImmediately()
		{
			return this.As<ISetTotalVehicleSpeedImmediatelyT>();
		}

		// Token: 0x0603312A RID: 209194 RVA: 0x006E373C File Offset: 0x006E193C
		public static ISetVehicleSpeedImmediatelyType_UnionUnion FromISetTotalVehicleSpeedImmediately(ISetTotalVehicleSpeedImmediatelyT _isettotalvehiclespeedimmediately)
		{
			return new ISetVehicleSpeedImmediatelyType_UnionUnion
			{
				Type = ISetVehicleSpeedImmediatelyType_Union.ISetTotalVehicleSpeedImmediately,
				Value = _isettotalvehiclespeedimmediately
			};
		}

		// Token: 0x0603312B RID: 209195 RVA: 0x006E3751 File Offset: 0x006E1951
		public ISetHorizontalVerticalSpeedImmediatelyT AsISetHorizontalVerticalSpeedImmediately()
		{
			return this.As<ISetHorizontalVerticalSpeedImmediatelyT>();
		}

		// Token: 0x0603312C RID: 209196 RVA: 0x006E3759 File Offset: 0x006E1959
		public static ISetVehicleSpeedImmediatelyType_UnionUnion FromISetHorizontalVerticalSpeedImmediately(ISetHorizontalVerticalSpeedImmediatelyT _isethorizontalverticalspeedimmediately)
		{
			return new ISetVehicleSpeedImmediatelyType_UnionUnion
			{
				Type = ISetVehicleSpeedImmediatelyType_Union.ISetHorizontalVerticalSpeedImmediately,
				Value = _isethorizontalverticalspeedimmediately
			};
		}

		// Token: 0x0603312D RID: 209197 RVA: 0x006E3770 File Offset: 0x006E1970
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
