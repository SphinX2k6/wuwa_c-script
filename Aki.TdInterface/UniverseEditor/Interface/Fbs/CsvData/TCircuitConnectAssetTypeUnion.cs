using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC5 RID: 19909
	public class TCircuitConnectAssetTypeUnion
	{
		// Token: 0x17008E68 RID: 36456
		// (get) Token: 0x0601EE39 RID: 126521 RVA: 0x00450CDC File Offset: 0x0044EEDC
		// (set) Token: 0x0601EE3A RID: 126522 RVA: 0x00450CE4 File Offset: 0x0044EEE4
		public TCircuitConnectAssetType Type { get; set; }

		// Token: 0x17008E69 RID: 36457
		// (get) Token: 0x0601EE3B RID: 126523 RVA: 0x00450CED File Offset: 0x0044EEED
		// (set) Token: 0x0601EE3C RID: 126524 RVA: 0x00450CF5 File Offset: 0x0044EEF5
		public object Value { get; set; }

		// Token: 0x0601EE3D RID: 126525 RVA: 0x00450CFE File Offset: 0x0044EEFE
		public TCircuitConnectAssetTypeUnion()
		{
			this.Type = TCircuitConnectAssetType.NONE;
			this.Value = null;
		}

		// Token: 0x0601EE3E RID: 126526 RVA: 0x00450D14 File Offset: 0x0044EF14
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EE3F RID: 126527 RVA: 0x00450D26 File Offset: 0x0044EF26
		public ICircuitConnectCurveAssetT AsICircuitConnectCurveAsset()
		{
			return this.As<ICircuitConnectCurveAssetT>();
		}

		// Token: 0x0601EE40 RID: 126528 RVA: 0x00450D2E File Offset: 0x0044EF2E
		public static TCircuitConnectAssetTypeUnion FromICircuitConnectCurveAsset(ICircuitConnectCurveAssetT _icircuitconnectcurveasset)
		{
			return new TCircuitConnectAssetTypeUnion
			{
				Type = TCircuitConnectAssetType.ICircuitConnectCurveAsset,
				Value = _icircuitconnectcurveasset
			};
		}

		// Token: 0x0601EE41 RID: 126529 RVA: 0x00450D43 File Offset: 0x0044EF43
		public ICircuitConnectOutputPortAssetT AsICircuitConnectOutputPortAsset()
		{
			return this.As<ICircuitConnectOutputPortAssetT>();
		}

		// Token: 0x0601EE42 RID: 126530 RVA: 0x00450D4B File Offset: 0x0044EF4B
		public static TCircuitConnectAssetTypeUnion FromICircuitConnectOutputPortAsset(ICircuitConnectOutputPortAssetT _icircuitconnectoutputportasset)
		{
			return new TCircuitConnectAssetTypeUnion
			{
				Type = TCircuitConnectAssetType.ICircuitConnectOutputPortAsset,
				Value = _icircuitconnectoutputportasset
			};
		}

		// Token: 0x0601EE43 RID: 126531 RVA: 0x00450D60 File Offset: 0x0044EF60
		public ICircuitConnectPowerPortAssetT AsICircuitConnectPowerPortAsset()
		{
			return this.As<ICircuitConnectPowerPortAssetT>();
		}

		// Token: 0x0601EE44 RID: 126532 RVA: 0x00450D68 File Offset: 0x0044EF68
		public static TCircuitConnectAssetTypeUnion FromICircuitConnectPowerPortAsset(ICircuitConnectPowerPortAssetT _icircuitconnectpowerportasset)
		{
			return new TCircuitConnectAssetTypeUnion
			{
				Type = TCircuitConnectAssetType.ICircuitConnectPowerPortAsset,
				Value = _icircuitconnectpowerportasset
			};
		}

		// Token: 0x0601EE45 RID: 126533 RVA: 0x00450D7D File Offset: 0x0044EF7D
		public ICircuitConnectStraightAssetT AsICircuitConnectStraightAsset()
		{
			return this.As<ICircuitConnectStraightAssetT>();
		}

		// Token: 0x0601EE46 RID: 126534 RVA: 0x00450D85 File Offset: 0x0044EF85
		public static TCircuitConnectAssetTypeUnion FromICircuitConnectStraightAsset(ICircuitConnectStraightAssetT _icircuitconnectstraightasset)
		{
			return new TCircuitConnectAssetTypeUnion
			{
				Type = TCircuitConnectAssetType.ICircuitConnectStraightAsset,
				Value = _icircuitconnectstraightasset
			};
		}

		// Token: 0x0601EE47 RID: 126535 RVA: 0x00450D9C File Offset: 0x0044EF9C
		public static int Pack(FlatBufferBuilder builder, TCircuitConnectAssetTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TCircuitConnectAssetType.ICircuitConnectCurveAsset:
				return ICircuitConnectCurveAsset.Pack(builder, _o.AsICircuitConnectCurveAsset()).Value;
			case TCircuitConnectAssetType.ICircuitConnectOutputPortAsset:
				return ICircuitConnectOutputPortAsset.Pack(builder, _o.AsICircuitConnectOutputPortAsset()).Value;
			case TCircuitConnectAssetType.ICircuitConnectPowerPortAsset:
				return ICircuitConnectPowerPortAsset.Pack(builder, _o.AsICircuitConnectPowerPortAsset()).Value;
			case TCircuitConnectAssetType.ICircuitConnectStraightAsset:
				return ICircuitConnectStraightAsset.Pack(builder, _o.AsICircuitConnectStraightAsset()).Value;
			default:
				return 0;
			}
		}
	}
}
