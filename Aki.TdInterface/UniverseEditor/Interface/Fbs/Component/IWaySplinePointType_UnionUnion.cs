using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006179 RID: 24953
	public class IWaySplinePointType_UnionUnion
	{
		// Token: 0x1700BA08 RID: 47624
		// (get) Token: 0x0602A643 RID: 173635 RVA: 0x005C8AE5 File Offset: 0x005C6CE5
		// (set) Token: 0x0602A644 RID: 173636 RVA: 0x005C8AED File Offset: 0x005C6CED
		public IWaySplinePointType_Union Type { get; set; }

		// Token: 0x1700BA09 RID: 47625
		// (get) Token: 0x0602A645 RID: 173637 RVA: 0x005C8AF6 File Offset: 0x005C6CF6
		// (set) Token: 0x0602A646 RID: 173638 RVA: 0x005C8AFE File Offset: 0x005C6CFE
		public object Value { get; set; }

		// Token: 0x0602A647 RID: 173639 RVA: 0x005C8B07 File Offset: 0x005C6D07
		public IWaySplinePointType_UnionUnion()
		{
			this.Type = IWaySplinePointType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A648 RID: 173640 RVA: 0x005C8B1D File Offset: 0x005C6D1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A649 RID: 173641 RVA: 0x005C8B2F File Offset: 0x005C6D2F
		public IWaySplinePointTypeT AsIWaySplinePointType()
		{
			return this.As<IWaySplinePointTypeT>();
		}

		// Token: 0x0602A64A RID: 173642 RVA: 0x005C8B37 File Offset: 0x005C6D37
		public static IWaySplinePointType_UnionUnion FromIWaySplinePointType(IWaySplinePointTypeT _iwaysplinepointtype)
		{
			return new IWaySplinePointType_UnionUnion
			{
				Type = IWaySplinePointType_Union.IWaySplinePointType,
				Value = _iwaysplinepointtype
			};
		}

		// Token: 0x0602A64B RID: 173643 RVA: 0x005C8B4C File Offset: 0x005C6D4C
		public IWaySplineCommonPointT AsIWaySplineCommonPoint()
		{
			return this.As<IWaySplineCommonPointT>();
		}

		// Token: 0x0602A64C RID: 173644 RVA: 0x005C8B54 File Offset: 0x005C6D54
		public static IWaySplinePointType_UnionUnion FromIWaySplineCommonPoint(IWaySplineCommonPointT _iwaysplinecommonpoint)
		{
			return new IWaySplinePointType_UnionUnion
			{
				Type = IWaySplinePointType_Union.IWaySplineCommonPoint,
				Value = _iwaysplinecommonpoint
			};
		}

		// Token: 0x0602A64D RID: 173645 RVA: 0x005C8B69 File Offset: 0x005C6D69
		public IWaySplineStartPointT AsIWaySplineStartPoint()
		{
			return this.As<IWaySplineStartPointT>();
		}

		// Token: 0x0602A64E RID: 173646 RVA: 0x005C8B71 File Offset: 0x005C6D71
		public static IWaySplinePointType_UnionUnion FromIWaySplineStartPoint(IWaySplineStartPointT _iwaysplinestartpoint)
		{
			return new IWaySplinePointType_UnionUnion
			{
				Type = IWaySplinePointType_Union.IWaySplineStartPoint,
				Value = _iwaysplinestartpoint
			};
		}

		// Token: 0x0602A64F RID: 173647 RVA: 0x005C8B88 File Offset: 0x005C6D88
		public static int Pack(FlatBufferBuilder builder, IWaySplinePointType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IWaySplinePointType_Union.IWaySplinePointType:
				return IWaySplinePointType.Pack(builder, _o.AsIWaySplinePointType()).Value;
			case IWaySplinePointType_Union.IWaySplineCommonPoint:
				return IWaySplineCommonPoint.Pack(builder, _o.AsIWaySplineCommonPoint()).Value;
			case IWaySplinePointType_Union.IWaySplineStartPoint:
				return IWaySplineStartPoint.Pack(builder, _o.AsIWaySplineStartPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
