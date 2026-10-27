using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C4F RID: 23631
	public class TItemFoundationUnion
	{
		// Token: 0x1700B212 RID: 45586
		// (get) Token: 0x06028825 RID: 165925 RVA: 0x005927E6 File Offset: 0x005909E6
		// (set) Token: 0x06028826 RID: 165926 RVA: 0x005927EE File Offset: 0x005909EE
		public TItemFoundation Type { get; set; }

		// Token: 0x1700B213 RID: 45587
		// (get) Token: 0x06028827 RID: 165927 RVA: 0x005927F7 File Offset: 0x005909F7
		// (set) Token: 0x06028828 RID: 165928 RVA: 0x005927FF File Offset: 0x005909FF
		public object Value { get; set; }

		// Token: 0x06028829 RID: 165929 RVA: 0x00592808 File Offset: 0x00590A08
		public TItemFoundationUnion()
		{
			this.Type = TItemFoundation.NONE;
			this.Value = null;
		}

		// Token: 0x0602882A RID: 165930 RVA: 0x0059281E File Offset: 0x00590A1E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602882B RID: 165931 RVA: 0x00592830 File Offset: 0x00590A30
		public IBuildingBlockFoundationT AsIBuildingBlockFoundation()
		{
			return this.As<IBuildingBlockFoundationT>();
		}

		// Token: 0x0602882C RID: 165932 RVA: 0x00592838 File Offset: 0x00590A38
		public static TItemFoundationUnion FromIBuildingBlockFoundation(IBuildingBlockFoundationT _ibuildingblockfoundation)
		{
			return new TItemFoundationUnion
			{
				Type = TItemFoundation.IBuildingBlockFoundation,
				Value = _ibuildingblockfoundation
			};
		}

		// Token: 0x0602882D RID: 165933 RVA: 0x0059284D File Offset: 0x00590A4D
		public ICategoryMatchingFoundationT AsICategoryMatchingFoundation()
		{
			return this.As<ICategoryMatchingFoundationT>();
		}

		// Token: 0x0602882E RID: 165934 RVA: 0x00592855 File Offset: 0x00590A55
		public static TItemFoundationUnion FromICategoryMatchingFoundation(ICategoryMatchingFoundationT _icategorymatchingfoundation)
		{
			return new TItemFoundationUnion
			{
				Type = TItemFoundation.ICategoryMatchingFoundation,
				Value = _icategorymatchingfoundation
			};
		}

		// Token: 0x0602882F RID: 165935 RVA: 0x0059286A File Offset: 0x00590A6A
		public IPulseDeviceFoundationT AsIPulseDeviceFoundation()
		{
			return this.As<IPulseDeviceFoundationT>();
		}

		// Token: 0x06028830 RID: 165936 RVA: 0x00592872 File Offset: 0x00590A72
		public static TItemFoundationUnion FromIPulseDeviceFoundation(IPulseDeviceFoundationT _ipulsedevicefoundation)
		{
			return new TItemFoundationUnion
			{
				Type = TItemFoundation.IPulseDeviceFoundation,
				Value = _ipulsedevicefoundation
			};
		}

		// Token: 0x06028831 RID: 165937 RVA: 0x00592887 File Offset: 0x00590A87
		public IRangeAdsorptionFoundationT AsIRangeAdsorptionFoundation()
		{
			return this.As<IRangeAdsorptionFoundationT>();
		}

		// Token: 0x06028832 RID: 165938 RVA: 0x0059288F File Offset: 0x00590A8F
		public static TItemFoundationUnion FromIRangeAdsorptionFoundation(IRangeAdsorptionFoundationT _irangeadsorptionfoundation)
		{
			return new TItemFoundationUnion
			{
				Type = TItemFoundation.IRangeAdsorptionFoundation,
				Value = _irangeadsorptionfoundation
			};
		}

		// Token: 0x06028833 RID: 165939 RVA: 0x005928A4 File Offset: 0x00590AA4
		public static int Pack(FlatBufferBuilder builder, TItemFoundationUnion _o)
		{
			switch (_o.Type)
			{
			case TItemFoundation.IBuildingBlockFoundation:
				return IBuildingBlockFoundation.Pack(builder, _o.AsIBuildingBlockFoundation()).Value;
			case TItemFoundation.ICategoryMatchingFoundation:
				return ICategoryMatchingFoundation.Pack(builder, _o.AsICategoryMatchingFoundation()).Value;
			case TItemFoundation.IPulseDeviceFoundation:
				return IPulseDeviceFoundation.Pack(builder, _o.AsIPulseDeviceFoundation()).Value;
			case TItemFoundation.IRangeAdsorptionFoundation:
				return IRangeAdsorptionFoundation.Pack(builder, _o.AsIRangeAdsorptionFoundation()).Value;
			default:
				return 0;
			}
		}
	}
}
