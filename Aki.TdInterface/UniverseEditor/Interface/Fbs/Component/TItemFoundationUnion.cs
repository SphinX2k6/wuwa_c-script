using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006274 RID: 25204
	public class TItemFoundationUnion
	{
		// Token: 0x1700BB64 RID: 47972
		// (get) Token: 0x0602AE33 RID: 175667 RVA: 0x005DA9FE File Offset: 0x005D8BFE
		// (set) Token: 0x0602AE34 RID: 175668 RVA: 0x005DAA06 File Offset: 0x005D8C06
		public TItemFoundation Type { get; set; }

		// Token: 0x1700BB65 RID: 47973
		// (get) Token: 0x0602AE35 RID: 175669 RVA: 0x005DAA0F File Offset: 0x005D8C0F
		// (set) Token: 0x0602AE36 RID: 175670 RVA: 0x005DAA17 File Offset: 0x005D8C17
		public object Value { get; set; }

		// Token: 0x0602AE37 RID: 175671 RVA: 0x005DAA20 File Offset: 0x005D8C20
		public TItemFoundationUnion()
		{
			this.Type = TItemFoundation.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE38 RID: 175672 RVA: 0x005DAA36 File Offset: 0x005D8C36
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE39 RID: 175673 RVA: 0x005DAA48 File Offset: 0x005D8C48
		public IBuildingBlockFoundationT AsIBuildingBlockFoundation()
		{
			return this.As<IBuildingBlockFoundationT>();
		}

		// Token: 0x0602AE3A RID: 175674 RVA: 0x005DAA50 File Offset: 0x005D8C50
		public static TItemFoundationUnion FromIBuildingBlockFoundation(IBuildingBlockFoundationT _ibuildingblockfoundation)
		{
			return new TItemFoundationUnion
			{
				Type = TItemFoundation.IBuildingBlockFoundation,
				Value = _ibuildingblockfoundation
			};
		}

		// Token: 0x0602AE3B RID: 175675 RVA: 0x005DAA65 File Offset: 0x005D8C65
		public ICategoryMatchingFoundationT AsICategoryMatchingFoundation()
		{
			return this.As<ICategoryMatchingFoundationT>();
		}

		// Token: 0x0602AE3C RID: 175676 RVA: 0x005DAA6D File Offset: 0x005D8C6D
		public static TItemFoundationUnion FromICategoryMatchingFoundation(ICategoryMatchingFoundationT _icategorymatchingfoundation)
		{
			return new TItemFoundationUnion
			{
				Type = TItemFoundation.ICategoryMatchingFoundation,
				Value = _icategorymatchingfoundation
			};
		}

		// Token: 0x0602AE3D RID: 175677 RVA: 0x005DAA82 File Offset: 0x005D8C82
		public IPulseDeviceFoundationT AsIPulseDeviceFoundation()
		{
			return this.As<IPulseDeviceFoundationT>();
		}

		// Token: 0x0602AE3E RID: 175678 RVA: 0x005DAA8A File Offset: 0x005D8C8A
		public static TItemFoundationUnion FromIPulseDeviceFoundation(IPulseDeviceFoundationT _ipulsedevicefoundation)
		{
			return new TItemFoundationUnion
			{
				Type = TItemFoundation.IPulseDeviceFoundation,
				Value = _ipulsedevicefoundation
			};
		}

		// Token: 0x0602AE3F RID: 175679 RVA: 0x005DAA9F File Offset: 0x005D8C9F
		public IRangeAdsorptionFoundationT AsIRangeAdsorptionFoundation()
		{
			return this.As<IRangeAdsorptionFoundationT>();
		}

		// Token: 0x0602AE40 RID: 175680 RVA: 0x005DAAA7 File Offset: 0x005D8CA7
		public static TItemFoundationUnion FromIRangeAdsorptionFoundation(IRangeAdsorptionFoundationT _irangeadsorptionfoundation)
		{
			return new TItemFoundationUnion
			{
				Type = TItemFoundation.IRangeAdsorptionFoundation,
				Value = _irangeadsorptionfoundation
			};
		}

		// Token: 0x0602AE41 RID: 175681 RVA: 0x005DAABC File Offset: 0x005D8CBC
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
