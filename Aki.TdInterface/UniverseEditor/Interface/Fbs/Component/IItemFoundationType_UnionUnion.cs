using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A21 RID: 23073
	public class IItemFoundationType_UnionUnion
	{
		// Token: 0x1700A7B6 RID: 42934
		// (get) Token: 0x06025B10 RID: 154384 RVA: 0x0052ABD5 File Offset: 0x00528DD5
		// (set) Token: 0x06025B11 RID: 154385 RVA: 0x0052ABDD File Offset: 0x00528DDD
		public IItemFoundationType_Union Type { get; set; }

		// Token: 0x1700A7B7 RID: 42935
		// (get) Token: 0x06025B12 RID: 154386 RVA: 0x0052ABE6 File Offset: 0x00528DE6
		// (set) Token: 0x06025B13 RID: 154387 RVA: 0x0052ABEE File Offset: 0x00528DEE
		public object Value { get; set; }

		// Token: 0x06025B14 RID: 154388 RVA: 0x0052ABF7 File Offset: 0x00528DF7
		public IItemFoundationType_UnionUnion()
		{
			this.Type = IItemFoundationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025B15 RID: 154389 RVA: 0x0052AC0D File Offset: 0x00528E0D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025B16 RID: 154390 RVA: 0x0052AC1F File Offset: 0x00528E1F
		public IItemFoundationTypeT AsIItemFoundationType()
		{
			return this.As<IItemFoundationTypeT>();
		}

		// Token: 0x06025B17 RID: 154391 RVA: 0x0052AC27 File Offset: 0x00528E27
		public static IItemFoundationType_UnionUnion FromIItemFoundationType(IItemFoundationTypeT _iitemfoundationtype)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.IItemFoundationType,
				Value = _iitemfoundationtype
			};
		}

		// Token: 0x06025B18 RID: 154392 RVA: 0x0052AC3C File Offset: 0x00528E3C
		public ICategoryMatchingFoundationT AsICategoryMatchingFoundation()
		{
			return this.As<ICategoryMatchingFoundationT>();
		}

		// Token: 0x06025B19 RID: 154393 RVA: 0x0052AC44 File Offset: 0x00528E44
		public static IItemFoundationType_UnionUnion FromICategoryMatchingFoundation(ICategoryMatchingFoundationT _icategorymatchingfoundation)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.ICategoryMatchingFoundation,
				Value = _icategorymatchingfoundation
			};
		}

		// Token: 0x06025B1A RID: 154394 RVA: 0x0052AC59 File Offset: 0x00528E59
		public IBuildingBlockFoundationT AsIBuildingBlockFoundation()
		{
			return this.As<IBuildingBlockFoundationT>();
		}

		// Token: 0x06025B1B RID: 154395 RVA: 0x0052AC61 File Offset: 0x00528E61
		public static IItemFoundationType_UnionUnion FromIBuildingBlockFoundation(IBuildingBlockFoundationT _ibuildingblockfoundation)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.IBuildingBlockFoundation,
				Value = _ibuildingblockfoundation
			};
		}

		// Token: 0x06025B1C RID: 154396 RVA: 0x0052AC76 File Offset: 0x00528E76
		public IPulseDeviceFoundationT AsIPulseDeviceFoundation()
		{
			return this.As<IPulseDeviceFoundationT>();
		}

		// Token: 0x06025B1D RID: 154397 RVA: 0x0052AC7E File Offset: 0x00528E7E
		public static IItemFoundationType_UnionUnion FromIPulseDeviceFoundation(IPulseDeviceFoundationT _ipulsedevicefoundation)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.IPulseDeviceFoundation,
				Value = _ipulsedevicefoundation
			};
		}

		// Token: 0x06025B1E RID: 154398 RVA: 0x0052AC93 File Offset: 0x00528E93
		public IRangeAdsorptionFoundationT AsIRangeAdsorptionFoundation()
		{
			return this.As<IRangeAdsorptionFoundationT>();
		}

		// Token: 0x06025B1F RID: 154399 RVA: 0x0052AC9B File Offset: 0x00528E9B
		public static IItemFoundationType_UnionUnion FromIRangeAdsorptionFoundation(IRangeAdsorptionFoundationT _irangeadsorptionfoundation)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.IRangeAdsorptionFoundation,
				Value = _irangeadsorptionfoundation
			};
		}

		// Token: 0x06025B20 RID: 154400 RVA: 0x0052ACB0 File Offset: 0x00528EB0
		public static int Pack(FlatBufferBuilder builder, IItemFoundationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IItemFoundationType_Union.IItemFoundationType:
				return IItemFoundationType.Pack(builder, _o.AsIItemFoundationType()).Value;
			case IItemFoundationType_Union.ICategoryMatchingFoundation:
				return ICategoryMatchingFoundation.Pack(builder, _o.AsICategoryMatchingFoundation()).Value;
			case IItemFoundationType_Union.IBuildingBlockFoundation:
				return IBuildingBlockFoundation.Pack(builder, _o.AsIBuildingBlockFoundation()).Value;
			case IItemFoundationType_Union.IPulseDeviceFoundation:
				return IPulseDeviceFoundation.Pack(builder, _o.AsIPulseDeviceFoundation()).Value;
			case IItemFoundationType_Union.IRangeAdsorptionFoundation:
				return IRangeAdsorptionFoundation.Pack(builder, _o.AsIRangeAdsorptionFoundation()).Value;
			default:
				return 0;
			}
		}
	}
}
