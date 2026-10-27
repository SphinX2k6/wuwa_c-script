using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD6 RID: 23766
	public class TWaySplinePointTypeUnion
	{
		// Token: 0x1700B26C RID: 45676
		// (get) Token: 0x06028AB3 RID: 166579 RVA: 0x005963CE File Offset: 0x005945CE
		// (set) Token: 0x06028AB4 RID: 166580 RVA: 0x005963D6 File Offset: 0x005945D6
		public TWaySplinePointType Type { get; set; }

		// Token: 0x1700B26D RID: 45677
		// (get) Token: 0x06028AB5 RID: 166581 RVA: 0x005963DF File Offset: 0x005945DF
		// (set) Token: 0x06028AB6 RID: 166582 RVA: 0x005963E7 File Offset: 0x005945E7
		public object Value { get; set; }

		// Token: 0x06028AB7 RID: 166583 RVA: 0x005963F0 File Offset: 0x005945F0
		public TWaySplinePointTypeUnion()
		{
			this.Type = TWaySplinePointType.NONE;
			this.Value = null;
		}

		// Token: 0x06028AB8 RID: 166584 RVA: 0x00596406 File Offset: 0x00594606
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028AB9 RID: 166585 RVA: 0x00596418 File Offset: 0x00594618
		public IWaySplineCommonPointT AsIWaySplineCommonPoint()
		{
			return this.As<IWaySplineCommonPointT>();
		}

		// Token: 0x06028ABA RID: 166586 RVA: 0x00596420 File Offset: 0x00594620
		public static TWaySplinePointTypeUnion FromIWaySplineCommonPoint(IWaySplineCommonPointT _iwaysplinecommonpoint)
		{
			return new TWaySplinePointTypeUnion
			{
				Type = TWaySplinePointType.IWaySplineCommonPoint,
				Value = _iwaysplinecommonpoint
			};
		}

		// Token: 0x06028ABB RID: 166587 RVA: 0x00596435 File Offset: 0x00594635
		public IWaySplineStartPointT AsIWaySplineStartPoint()
		{
			return this.As<IWaySplineStartPointT>();
		}

		// Token: 0x06028ABC RID: 166588 RVA: 0x0059643D File Offset: 0x0059463D
		public static TWaySplinePointTypeUnion FromIWaySplineStartPoint(IWaySplineStartPointT _iwaysplinestartpoint)
		{
			return new TWaySplinePointTypeUnion
			{
				Type = TWaySplinePointType.IWaySplineStartPoint,
				Value = _iwaysplinestartpoint
			};
		}

		// Token: 0x06028ABD RID: 166589 RVA: 0x00596454 File Offset: 0x00594654
		public static int Pack(FlatBufferBuilder builder, TWaySplinePointTypeUnion _o)
		{
			TWaySplinePointType type = _o.Type;
			if (type == TWaySplinePointType.IWaySplineCommonPoint)
			{
				return IWaySplineCommonPoint.Pack(builder, _o.AsIWaySplineCommonPoint()).Value;
			}
			if (type != TWaySplinePointType.IWaySplineStartPoint)
			{
				return 0;
			}
			return IWaySplineStartPoint.Pack(builder, _o.AsIWaySplineStartPoint()).Value;
		}
	}
}
