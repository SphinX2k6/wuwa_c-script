using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200630A RID: 25354
	public class TWaySplinePointTypeUnion
	{
		// Token: 0x1700BBC8 RID: 48072
		// (get) Token: 0x0602B107 RID: 176391 RVA: 0x005DEC3E File Offset: 0x005DCE3E
		// (set) Token: 0x0602B108 RID: 176392 RVA: 0x005DEC46 File Offset: 0x005DCE46
		public TWaySplinePointType Type { get; set; }

		// Token: 0x1700BBC9 RID: 48073
		// (get) Token: 0x0602B109 RID: 176393 RVA: 0x005DEC4F File Offset: 0x005DCE4F
		// (set) Token: 0x0602B10A RID: 176394 RVA: 0x005DEC57 File Offset: 0x005DCE57
		public object Value { get; set; }

		// Token: 0x0602B10B RID: 176395 RVA: 0x005DEC60 File Offset: 0x005DCE60
		public TWaySplinePointTypeUnion()
		{
			this.Type = TWaySplinePointType.NONE;
			this.Value = null;
		}

		// Token: 0x0602B10C RID: 176396 RVA: 0x005DEC76 File Offset: 0x005DCE76
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B10D RID: 176397 RVA: 0x005DEC88 File Offset: 0x005DCE88
		public IWaySplineCommonPointT AsIWaySplineCommonPoint()
		{
			return this.As<IWaySplineCommonPointT>();
		}

		// Token: 0x0602B10E RID: 176398 RVA: 0x005DEC90 File Offset: 0x005DCE90
		public static TWaySplinePointTypeUnion FromIWaySplineCommonPoint(IWaySplineCommonPointT _iwaysplinecommonpoint)
		{
			return new TWaySplinePointTypeUnion
			{
				Type = TWaySplinePointType.IWaySplineCommonPoint,
				Value = _iwaysplinecommonpoint
			};
		}

		// Token: 0x0602B10F RID: 176399 RVA: 0x005DECA5 File Offset: 0x005DCEA5
		public IWaySplineStartPointT AsIWaySplineStartPoint()
		{
			return this.As<IWaySplineStartPointT>();
		}

		// Token: 0x0602B110 RID: 176400 RVA: 0x005DECAD File Offset: 0x005DCEAD
		public static TWaySplinePointTypeUnion FromIWaySplineStartPoint(IWaySplineStartPointT _iwaysplinestartpoint)
		{
			return new TWaySplinePointTypeUnion
			{
				Type = TWaySplinePointType.IWaySplineStartPoint,
				Value = _iwaysplinestartpoint
			};
		}

		// Token: 0x0602B111 RID: 176401 RVA: 0x005DECC4 File Offset: 0x005DCEC4
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
