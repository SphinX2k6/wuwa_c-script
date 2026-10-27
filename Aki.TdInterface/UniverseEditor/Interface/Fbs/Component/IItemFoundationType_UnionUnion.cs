using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549B RID: 21659
	public class IItemFoundationType_UnionUnion
	{
		// Token: 0x17009F7C RID: 40828
		// (get) Token: 0x06023A58 RID: 146008 RVA: 0x004EDB61 File Offset: 0x004EBD61
		// (set) Token: 0x06023A59 RID: 146009 RVA: 0x004EDB69 File Offset: 0x004EBD69
		public IItemFoundationType_Union Type { get; set; }

		// Token: 0x17009F7D RID: 40829
		// (get) Token: 0x06023A5A RID: 146010 RVA: 0x004EDB72 File Offset: 0x004EBD72
		// (set) Token: 0x06023A5B RID: 146011 RVA: 0x004EDB7A File Offset: 0x004EBD7A
		public object Value { get; set; }

		// Token: 0x06023A5C RID: 146012 RVA: 0x004EDB83 File Offset: 0x004EBD83
		public IItemFoundationType_UnionUnion()
		{
			this.Type = IItemFoundationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023A5D RID: 146013 RVA: 0x004EDB99 File Offset: 0x004EBD99
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023A5E RID: 146014 RVA: 0x004EDBAB File Offset: 0x004EBDAB
		public IItemFoundationTypeT AsIItemFoundationType()
		{
			return this.As<IItemFoundationTypeT>();
		}

		// Token: 0x06023A5F RID: 146015 RVA: 0x004EDBB3 File Offset: 0x004EBDB3
		public static IItemFoundationType_UnionUnion FromIItemFoundationType(IItemFoundationTypeT _iitemfoundationtype)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.IItemFoundationType,
				Value = _iitemfoundationtype
			};
		}

		// Token: 0x06023A60 RID: 146016 RVA: 0x004EDBC8 File Offset: 0x004EBDC8
		public ICategoryMatchingFoundationT AsICategoryMatchingFoundation()
		{
			return this.As<ICategoryMatchingFoundationT>();
		}

		// Token: 0x06023A61 RID: 146017 RVA: 0x004EDBD0 File Offset: 0x004EBDD0
		public static IItemFoundationType_UnionUnion FromICategoryMatchingFoundation(ICategoryMatchingFoundationT _icategorymatchingfoundation)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.ICategoryMatchingFoundation,
				Value = _icategorymatchingfoundation
			};
		}

		// Token: 0x06023A62 RID: 146018 RVA: 0x004EDBE5 File Offset: 0x004EBDE5
		public IBuildingBlockFoundationT AsIBuildingBlockFoundation()
		{
			return this.As<IBuildingBlockFoundationT>();
		}

		// Token: 0x06023A63 RID: 146019 RVA: 0x004EDBED File Offset: 0x004EBDED
		public static IItemFoundationType_UnionUnion FromIBuildingBlockFoundation(IBuildingBlockFoundationT _ibuildingblockfoundation)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.IBuildingBlockFoundation,
				Value = _ibuildingblockfoundation
			};
		}

		// Token: 0x06023A64 RID: 146020 RVA: 0x004EDC02 File Offset: 0x004EBE02
		public IPulseDeviceFoundationT AsIPulseDeviceFoundation()
		{
			return this.As<IPulseDeviceFoundationT>();
		}

		// Token: 0x06023A65 RID: 146021 RVA: 0x004EDC0A File Offset: 0x004EBE0A
		public static IItemFoundationType_UnionUnion FromIPulseDeviceFoundation(IPulseDeviceFoundationT _ipulsedevicefoundation)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.IPulseDeviceFoundation,
				Value = _ipulsedevicefoundation
			};
		}

		// Token: 0x06023A66 RID: 146022 RVA: 0x004EDC1F File Offset: 0x004EBE1F
		public IRangeAdsorptionFoundationT AsIRangeAdsorptionFoundation()
		{
			return this.As<IRangeAdsorptionFoundationT>();
		}

		// Token: 0x06023A67 RID: 146023 RVA: 0x004EDC27 File Offset: 0x004EBE27
		public static IItemFoundationType_UnionUnion FromIRangeAdsorptionFoundation(IRangeAdsorptionFoundationT _irangeadsorptionfoundation)
		{
			return new IItemFoundationType_UnionUnion
			{
				Type = IItemFoundationType_Union.IRangeAdsorptionFoundation,
				Value = _irangeadsorptionfoundation
			};
		}

		// Token: 0x06023A68 RID: 146024 RVA: 0x004EDC3C File Offset: 0x004EBE3C
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
