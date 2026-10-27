using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C7A RID: 15482
	public class TRangeUnion
	{
		// Token: 0x17006AC0 RID: 27328
		// (get) Token: 0x060156E5 RID: 87781 RVA: 0x00318EB0 File Offset: 0x003170B0
		// (set) Token: 0x060156E6 RID: 87782 RVA: 0x00318EB8 File Offset: 0x003170B8
		public TRange Type { get; set; }

		// Token: 0x17006AC1 RID: 27329
		// (get) Token: 0x060156E7 RID: 87783 RVA: 0x00318EC1 File Offset: 0x003170C1
		// (set) Token: 0x060156E8 RID: 87784 RVA: 0x00318EC9 File Offset: 0x003170C9
		public object Value { get; set; }

		// Token: 0x060156E9 RID: 87785 RVA: 0x00318ED2 File Offset: 0x003170D2
		public TRangeUnion()
		{
			this.Type = TRange.NONE;
			this.Value = null;
		}

		// Token: 0x060156EA RID: 87786 RVA: 0x00318EE8 File Offset: 0x003170E8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060156EB RID: 87787 RVA: 0x00318EFA File Offset: 0x003170FA
		public IBoxRangeT AsIBoxRange()
		{
			return this.As<IBoxRangeT>();
		}

		// Token: 0x060156EC RID: 87788 RVA: 0x00318F02 File Offset: 0x00317102
		public static TRangeUnion FromIBoxRange(IBoxRangeT _iboxrange)
		{
			return new TRangeUnion
			{
				Type = TRange.IBoxRange,
				Value = _iboxrange
			};
		}

		// Token: 0x060156ED RID: 87789 RVA: 0x00318F17 File Offset: 0x00317117
		public ICircleRangeT AsICircleRange()
		{
			return this.As<ICircleRangeT>();
		}

		// Token: 0x060156EE RID: 87790 RVA: 0x00318F1F File Offset: 0x0031711F
		public static TRangeUnion FromICircleRange(ICircleRangeT _icirclerange)
		{
			return new TRangeUnion
			{
				Type = TRange.ICircleRange,
				Value = _icirclerange
			};
		}

		// Token: 0x060156EF RID: 87791 RVA: 0x00318F34 File Offset: 0x00317134
		public ICylinderT AsICylinder()
		{
			return this.As<ICylinderT>();
		}

		// Token: 0x060156F0 RID: 87792 RVA: 0x00318F3C File Offset: 0x0031713C
		public static TRangeUnion FromICylinder(ICylinderT _icylinder)
		{
			return new TRangeUnion
			{
				Type = TRange.ICylinder,
				Value = _icylinder
			};
		}

		// Token: 0x060156F1 RID: 87793 RVA: 0x00318F54 File Offset: 0x00317154
		public static int Pack(FlatBufferBuilder builder, TRangeUnion _o)
		{
			switch (_o.Type)
			{
			case TRange.IBoxRange:
				return IBoxRange.Pack(builder, _o.AsIBoxRange()).Value;
			case TRange.ICircleRange:
				return ICircleRange.Pack(builder, _o.AsICircleRange()).Value;
			case TRange.ICylinder:
				return ICylinder.Pack(builder, _o.AsICylinder()).Value;
			default:
				return 0;
			}
		}
	}
}
