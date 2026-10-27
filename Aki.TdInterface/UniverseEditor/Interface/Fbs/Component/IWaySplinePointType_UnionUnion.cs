using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B63 RID: 23395
	public class IWaySplinePointType_UnionUnion
	{
		// Token: 0x1700B0C0 RID: 45248
		// (get) Token: 0x0602807F RID: 163967 RVA: 0x00581055 File Offset: 0x0057F255
		// (set) Token: 0x06028080 RID: 163968 RVA: 0x0058105D File Offset: 0x0057F25D
		public IWaySplinePointType_Union Type { get; set; }

		// Token: 0x1700B0C1 RID: 45249
		// (get) Token: 0x06028081 RID: 163969 RVA: 0x00581066 File Offset: 0x0057F266
		// (set) Token: 0x06028082 RID: 163970 RVA: 0x0058106E File Offset: 0x0057F26E
		public object Value { get; set; }

		// Token: 0x06028083 RID: 163971 RVA: 0x00581077 File Offset: 0x0057F277
		public IWaySplinePointType_UnionUnion()
		{
			this.Type = IWaySplinePointType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028084 RID: 163972 RVA: 0x0058108D File Offset: 0x0057F28D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028085 RID: 163973 RVA: 0x0058109F File Offset: 0x0057F29F
		public IWaySplinePointTypeT AsIWaySplinePointType()
		{
			return this.As<IWaySplinePointTypeT>();
		}

		// Token: 0x06028086 RID: 163974 RVA: 0x005810A7 File Offset: 0x0057F2A7
		public static IWaySplinePointType_UnionUnion FromIWaySplinePointType(IWaySplinePointTypeT _iwaysplinepointtype)
		{
			return new IWaySplinePointType_UnionUnion
			{
				Type = IWaySplinePointType_Union.IWaySplinePointType,
				Value = _iwaysplinepointtype
			};
		}

		// Token: 0x06028087 RID: 163975 RVA: 0x005810BC File Offset: 0x0057F2BC
		public IWaySplineCommonPointT AsIWaySplineCommonPoint()
		{
			return this.As<IWaySplineCommonPointT>();
		}

		// Token: 0x06028088 RID: 163976 RVA: 0x005810C4 File Offset: 0x0057F2C4
		public static IWaySplinePointType_UnionUnion FromIWaySplineCommonPoint(IWaySplineCommonPointT _iwaysplinecommonpoint)
		{
			return new IWaySplinePointType_UnionUnion
			{
				Type = IWaySplinePointType_Union.IWaySplineCommonPoint,
				Value = _iwaysplinecommonpoint
			};
		}

		// Token: 0x06028089 RID: 163977 RVA: 0x005810D9 File Offset: 0x0057F2D9
		public IWaySplineStartPointT AsIWaySplineStartPoint()
		{
			return this.As<IWaySplineStartPointT>();
		}

		// Token: 0x0602808A RID: 163978 RVA: 0x005810E1 File Offset: 0x0057F2E1
		public static IWaySplinePointType_UnionUnion FromIWaySplineStartPoint(IWaySplineStartPointT _iwaysplinestartpoint)
		{
			return new IWaySplinePointType_UnionUnion
			{
				Type = IWaySplinePointType_Union.IWaySplineStartPoint,
				Value = _iwaysplinestartpoint
			};
		}

		// Token: 0x0602808B RID: 163979 RVA: 0x005810F8 File Offset: 0x0057F2F8
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
