using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DF RID: 21727
	public class ICircuitConnectLayoutBase_UnionUnion
	{
		// Token: 0x17009B35 RID: 39733
		// (get) Token: 0x060224B9 RID: 140473 RVA: 0x004BA439 File Offset: 0x004B8639
		// (set) Token: 0x060224BA RID: 140474 RVA: 0x004BA441 File Offset: 0x004B8641
		public ICircuitConnectLayoutBase_Union Type { get; set; }

		// Token: 0x17009B36 RID: 39734
		// (get) Token: 0x060224BB RID: 140475 RVA: 0x004BA44A File Offset: 0x004B864A
		// (set) Token: 0x060224BC RID: 140476 RVA: 0x004BA452 File Offset: 0x004B8652
		public object Value { get; set; }

		// Token: 0x060224BD RID: 140477 RVA: 0x004BA45B File Offset: 0x004B865B
		public ICircuitConnectLayoutBase_UnionUnion()
		{
			this.Type = ICircuitConnectLayoutBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060224BE RID: 140478 RVA: 0x004BA471 File Offset: 0x004B8671
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060224BF RID: 140479 RVA: 0x004BA483 File Offset: 0x004B8683
		public ICircuitConnectLayoutBaseT AsICircuitConnectLayoutBase()
		{
			return this.As<ICircuitConnectLayoutBaseT>();
		}

		// Token: 0x060224C0 RID: 140480 RVA: 0x004BA48B File Offset: 0x004B868B
		public static ICircuitConnectLayoutBase_UnionUnion FromICircuitConnectLayoutBase(ICircuitConnectLayoutBaseT _icircuitconnectlayoutbase)
		{
			return new ICircuitConnectLayoutBase_UnionUnion
			{
				Type = ICircuitConnectLayoutBase_Union.ICircuitConnectLayoutBase,
				Value = _icircuitconnectlayoutbase
			};
		}

		// Token: 0x060224C1 RID: 140481 RVA: 0x004BA4A0 File Offset: 0x004B86A0
		public ICircuitConnectStraightLayoutT AsICircuitConnectStraightLayout()
		{
			return this.As<ICircuitConnectStraightLayoutT>();
		}

		// Token: 0x060224C2 RID: 140482 RVA: 0x004BA4A8 File Offset: 0x004B86A8
		public static ICircuitConnectLayoutBase_UnionUnion FromICircuitConnectStraightLayout(ICircuitConnectStraightLayoutT _icircuitconnectstraightlayout)
		{
			return new ICircuitConnectLayoutBase_UnionUnion
			{
				Type = ICircuitConnectLayoutBase_Union.ICircuitConnectStraightLayout,
				Value = _icircuitconnectstraightlayout
			};
		}

		// Token: 0x060224C3 RID: 140483 RVA: 0x004BA4BD File Offset: 0x004B86BD
		public ICircuitConnectCurveLayoutT AsICircuitConnectCurveLayout()
		{
			return this.As<ICircuitConnectCurveLayoutT>();
		}

		// Token: 0x060224C4 RID: 140484 RVA: 0x004BA4C5 File Offset: 0x004B86C5
		public static ICircuitConnectLayoutBase_UnionUnion FromICircuitConnectCurveLayout(ICircuitConnectCurveLayoutT _icircuitconnectcurvelayout)
		{
			return new ICircuitConnectLayoutBase_UnionUnion
			{
				Type = ICircuitConnectLayoutBase_Union.ICircuitConnectCurveLayout,
				Value = _icircuitconnectcurvelayout
			};
		}

		// Token: 0x060224C5 RID: 140485 RVA: 0x004BA4DA File Offset: 0x004B86DA
		public ICircuitConnectPowerPortLayoutT AsICircuitConnectPowerPortLayout()
		{
			return this.As<ICircuitConnectPowerPortLayoutT>();
		}

		// Token: 0x060224C6 RID: 140486 RVA: 0x004BA4E2 File Offset: 0x004B86E2
		public static ICircuitConnectLayoutBase_UnionUnion FromICircuitConnectPowerPortLayout(ICircuitConnectPowerPortLayoutT _icircuitconnectpowerportlayout)
		{
			return new ICircuitConnectLayoutBase_UnionUnion
			{
				Type = ICircuitConnectLayoutBase_Union.ICircuitConnectPowerPortLayout,
				Value = _icircuitconnectpowerportlayout
			};
		}

		// Token: 0x060224C7 RID: 140487 RVA: 0x004BA4F7 File Offset: 0x004B86F7
		public ICircuitConnectOutputPortLayoutT AsICircuitConnectOutputPortLayout()
		{
			return this.As<ICircuitConnectOutputPortLayoutT>();
		}

		// Token: 0x060224C8 RID: 140488 RVA: 0x004BA4FF File Offset: 0x004B86FF
		public static ICircuitConnectLayoutBase_UnionUnion FromICircuitConnectOutputPortLayout(ICircuitConnectOutputPortLayoutT _icircuitconnectoutputportlayout)
		{
			return new ICircuitConnectLayoutBase_UnionUnion
			{
				Type = ICircuitConnectLayoutBase_Union.ICircuitConnectOutputPortLayout,
				Value = _icircuitconnectoutputportlayout
			};
		}

		// Token: 0x060224C9 RID: 140489 RVA: 0x004BA514 File Offset: 0x004B8714
		public static int Pack(FlatBufferBuilder builder, ICircuitConnectLayoutBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICircuitConnectLayoutBase_Union.ICircuitConnectLayoutBase:
				return ICircuitConnectLayoutBase.Pack(builder, _o.AsICircuitConnectLayoutBase()).Value;
			case ICircuitConnectLayoutBase_Union.ICircuitConnectStraightLayout:
				return ICircuitConnectStraightLayout.Pack(builder, _o.AsICircuitConnectStraightLayout()).Value;
			case ICircuitConnectLayoutBase_Union.ICircuitConnectCurveLayout:
				return ICircuitConnectCurveLayout.Pack(builder, _o.AsICircuitConnectCurveLayout()).Value;
			case ICircuitConnectLayoutBase_Union.ICircuitConnectPowerPortLayout:
				return ICircuitConnectPowerPortLayout.Pack(builder, _o.AsICircuitConnectPowerPortLayout()).Value;
			case ICircuitConnectLayoutBase_Union.ICircuitConnectOutputPortLayout:
				return ICircuitConnectOutputPortLayout.Pack(builder, _o.AsICircuitConnectOutputPortLayout()).Value;
			default:
				return 0;
			}
		}
	}
}
