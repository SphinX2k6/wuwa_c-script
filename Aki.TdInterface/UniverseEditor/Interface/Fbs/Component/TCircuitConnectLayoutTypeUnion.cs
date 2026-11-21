using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200620E RID: 25102
	public class TCircuitConnectLayoutTypeUnion
	{
		// Token: 0x1700BB17 RID: 47895
		// (get) Token: 0x0602AB2D RID: 174893 RVA: 0x005D23F8 File Offset: 0x005D05F8
		// (set) Token: 0x0602AB2E RID: 174894 RVA: 0x005D2400 File Offset: 0x005D0600
		public TCircuitConnectLayoutType Type { get; set; }

		// Token: 0x1700BB18 RID: 47896
		// (get) Token: 0x0602AB2F RID: 174895 RVA: 0x005D2409 File Offset: 0x005D0609
		// (set) Token: 0x0602AB30 RID: 174896 RVA: 0x005D2411 File Offset: 0x005D0611
		public object Value { get; set; }

		// Token: 0x0602AB31 RID: 174897 RVA: 0x005D241A File Offset: 0x005D061A
		public TCircuitConnectLayoutTypeUnion()
		{
			this.Type = TCircuitConnectLayoutType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AB32 RID: 174898 RVA: 0x005D2430 File Offset: 0x005D0630
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AB33 RID: 174899 RVA: 0x005D2442 File Offset: 0x005D0642
		public ICircuitConnectCurveLayoutT AsICircuitConnectCurveLayout()
		{
			return this.As<ICircuitConnectCurveLayoutT>();
		}

		// Token: 0x0602AB34 RID: 174900 RVA: 0x005D244A File Offset: 0x005D064A
		public static TCircuitConnectLayoutTypeUnion FromICircuitConnectCurveLayout(ICircuitConnectCurveLayoutT _icircuitconnectcurvelayout)
		{
			return new TCircuitConnectLayoutTypeUnion
			{
				Type = TCircuitConnectLayoutType.ICircuitConnectCurveLayout,
				Value = _icircuitconnectcurvelayout
			};
		}

		// Token: 0x0602AB35 RID: 174901 RVA: 0x005D245F File Offset: 0x005D065F
		public ICircuitConnectOutputPortLayoutT AsICircuitConnectOutputPortLayout()
		{
			return this.As<ICircuitConnectOutputPortLayoutT>();
		}

		// Token: 0x0602AB36 RID: 174902 RVA: 0x005D2467 File Offset: 0x005D0667
		public static TCircuitConnectLayoutTypeUnion FromICircuitConnectOutputPortLayout(ICircuitConnectOutputPortLayoutT _icircuitconnectoutputportlayout)
		{
			return new TCircuitConnectLayoutTypeUnion
			{
				Type = TCircuitConnectLayoutType.ICircuitConnectOutputPortLayout,
				Value = _icircuitconnectoutputportlayout
			};
		}

		// Token: 0x0602AB37 RID: 174903 RVA: 0x005D247C File Offset: 0x005D067C
		public ICircuitConnectPowerPortLayoutT AsICircuitConnectPowerPortLayout()
		{
			return this.As<ICircuitConnectPowerPortLayoutT>();
		}

		// Token: 0x0602AB38 RID: 174904 RVA: 0x005D2484 File Offset: 0x005D0684
		public static TCircuitConnectLayoutTypeUnion FromICircuitConnectPowerPortLayout(ICircuitConnectPowerPortLayoutT _icircuitconnectpowerportlayout)
		{
			return new TCircuitConnectLayoutTypeUnion
			{
				Type = TCircuitConnectLayoutType.ICircuitConnectPowerPortLayout,
				Value = _icircuitconnectpowerportlayout
			};
		}

		// Token: 0x0602AB39 RID: 174905 RVA: 0x005D2499 File Offset: 0x005D0699
		public ICircuitConnectStraightLayoutT AsICircuitConnectStraightLayout()
		{
			return this.As<ICircuitConnectStraightLayoutT>();
		}

		// Token: 0x0602AB3A RID: 174906 RVA: 0x005D24A1 File Offset: 0x005D06A1
		public static TCircuitConnectLayoutTypeUnion FromICircuitConnectStraightLayout(ICircuitConnectStraightLayoutT _icircuitconnectstraightlayout)
		{
			return new TCircuitConnectLayoutTypeUnion
			{
				Type = TCircuitConnectLayoutType.ICircuitConnectStraightLayout,
				Value = _icircuitconnectstraightlayout
			};
		}

		// Token: 0x0602AB3B RID: 174907 RVA: 0x005D24B8 File Offset: 0x005D06B8
		public static int Pack(FlatBufferBuilder builder, TCircuitConnectLayoutTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TCircuitConnectLayoutType.ICircuitConnectCurveLayout:
				return ICircuitConnectCurveLayout.Pack(builder, _o.AsICircuitConnectCurveLayout()).Value;
			case TCircuitConnectLayoutType.ICircuitConnectOutputPortLayout:
				return ICircuitConnectOutputPortLayout.Pack(builder, _o.AsICircuitConnectOutputPortLayout()).Value;
			case TCircuitConnectLayoutType.ICircuitConnectPowerPortLayout:
				return ICircuitConnectPowerPortLayout.Pack(builder, _o.AsICircuitConnectPowerPortLayout()).Value;
			case TCircuitConnectLayoutType.ICircuitConnectStraightLayout:
				return ICircuitConnectStraightLayout.Pack(builder, _o.AsICircuitConnectStraightLayout()).Value;
			default:
				return 0;
			}
		}
	}
}
