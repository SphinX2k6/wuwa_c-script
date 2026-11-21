using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D6B RID: 19819
	public class ICircuitConnectAssetBase_UnionUnion
	{
		// Token: 0x17008DD0 RID: 36304
		// (get) Token: 0x0601EB65 RID: 125797 RVA: 0x0044BC79 File Offset: 0x00449E79
		// (set) Token: 0x0601EB66 RID: 125798 RVA: 0x0044BC81 File Offset: 0x00449E81
		public ICircuitConnectAssetBase_Union Type { get; set; }

		// Token: 0x17008DD1 RID: 36305
		// (get) Token: 0x0601EB67 RID: 125799 RVA: 0x0044BC8A File Offset: 0x00449E8A
		// (set) Token: 0x0601EB68 RID: 125800 RVA: 0x0044BC92 File Offset: 0x00449E92
		public object Value { get; set; }

		// Token: 0x0601EB69 RID: 125801 RVA: 0x0044BC9B File Offset: 0x00449E9B
		public ICircuitConnectAssetBase_UnionUnion()
		{
			this.Type = ICircuitConnectAssetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EB6A RID: 125802 RVA: 0x0044BCB1 File Offset: 0x00449EB1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EB6B RID: 125803 RVA: 0x0044BCC3 File Offset: 0x00449EC3
		public ICircuitConnectAssetBaseT AsICircuitConnectAssetBase()
		{
			return this.As<ICircuitConnectAssetBaseT>();
		}

		// Token: 0x0601EB6C RID: 125804 RVA: 0x0044BCCB File Offset: 0x00449ECB
		public static ICircuitConnectAssetBase_UnionUnion FromICircuitConnectAssetBase(ICircuitConnectAssetBaseT _icircuitconnectassetbase)
		{
			return new ICircuitConnectAssetBase_UnionUnion
			{
				Type = ICircuitConnectAssetBase_Union.ICircuitConnectAssetBase,
				Value = _icircuitconnectassetbase
			};
		}

		// Token: 0x0601EB6D RID: 125805 RVA: 0x0044BCE0 File Offset: 0x00449EE0
		public ICircuitConnectStraightAssetT AsICircuitConnectStraightAsset()
		{
			return this.As<ICircuitConnectStraightAssetT>();
		}

		// Token: 0x0601EB6E RID: 125806 RVA: 0x0044BCE8 File Offset: 0x00449EE8
		public static ICircuitConnectAssetBase_UnionUnion FromICircuitConnectStraightAsset(ICircuitConnectStraightAssetT _icircuitconnectstraightasset)
		{
			return new ICircuitConnectAssetBase_UnionUnion
			{
				Type = ICircuitConnectAssetBase_Union.ICircuitConnectStraightAsset,
				Value = _icircuitconnectstraightasset
			};
		}

		// Token: 0x0601EB6F RID: 125807 RVA: 0x0044BCFD File Offset: 0x00449EFD
		public ICircuitConnectCurveAssetT AsICircuitConnectCurveAsset()
		{
			return this.As<ICircuitConnectCurveAssetT>();
		}

		// Token: 0x0601EB70 RID: 125808 RVA: 0x0044BD05 File Offset: 0x00449F05
		public static ICircuitConnectAssetBase_UnionUnion FromICircuitConnectCurveAsset(ICircuitConnectCurveAssetT _icircuitconnectcurveasset)
		{
			return new ICircuitConnectAssetBase_UnionUnion
			{
				Type = ICircuitConnectAssetBase_Union.ICircuitConnectCurveAsset,
				Value = _icircuitconnectcurveasset
			};
		}

		// Token: 0x0601EB71 RID: 125809 RVA: 0x0044BD1A File Offset: 0x00449F1A
		public ICircuitConnectPowerPortAssetT AsICircuitConnectPowerPortAsset()
		{
			return this.As<ICircuitConnectPowerPortAssetT>();
		}

		// Token: 0x0601EB72 RID: 125810 RVA: 0x0044BD22 File Offset: 0x00449F22
		public static ICircuitConnectAssetBase_UnionUnion FromICircuitConnectPowerPortAsset(ICircuitConnectPowerPortAssetT _icircuitconnectpowerportasset)
		{
			return new ICircuitConnectAssetBase_UnionUnion
			{
				Type = ICircuitConnectAssetBase_Union.ICircuitConnectPowerPortAsset,
				Value = _icircuitconnectpowerportasset
			};
		}

		// Token: 0x0601EB73 RID: 125811 RVA: 0x0044BD37 File Offset: 0x00449F37
		public ICircuitConnectOutputPortAssetT AsICircuitConnectOutputPortAsset()
		{
			return this.As<ICircuitConnectOutputPortAssetT>();
		}

		// Token: 0x0601EB74 RID: 125812 RVA: 0x0044BD3F File Offset: 0x00449F3F
		public static ICircuitConnectAssetBase_UnionUnion FromICircuitConnectOutputPortAsset(ICircuitConnectOutputPortAssetT _icircuitconnectoutputportasset)
		{
			return new ICircuitConnectAssetBase_UnionUnion
			{
				Type = ICircuitConnectAssetBase_Union.ICircuitConnectOutputPortAsset,
				Value = _icircuitconnectoutputportasset
			};
		}

		// Token: 0x0601EB75 RID: 125813 RVA: 0x0044BD54 File Offset: 0x00449F54
		public static int Pack(FlatBufferBuilder builder, ICircuitConnectAssetBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICircuitConnectAssetBase_Union.ICircuitConnectAssetBase:
				return ICircuitConnectAssetBase.Pack(builder, _o.AsICircuitConnectAssetBase()).Value;
			case ICircuitConnectAssetBase_Union.ICircuitConnectStraightAsset:
				return ICircuitConnectStraightAsset.Pack(builder, _o.AsICircuitConnectStraightAsset()).Value;
			case ICircuitConnectAssetBase_Union.ICircuitConnectCurveAsset:
				return ICircuitConnectCurveAsset.Pack(builder, _o.AsICircuitConnectCurveAsset()).Value;
			case ICircuitConnectAssetBase_Union.ICircuitConnectPowerPortAsset:
				return ICircuitConnectPowerPortAsset.Pack(builder, _o.AsICircuitConnectPowerPortAsset()).Value;
			case ICircuitConnectAssetBase_Union.ICircuitConnectOutputPortAsset:
				return ICircuitConnectOutputPortAsset.Pack(builder, _o.AsICircuitConnectOutputPortAsset()).Value;
			default:
				return 0;
			}
		}
	}
}
