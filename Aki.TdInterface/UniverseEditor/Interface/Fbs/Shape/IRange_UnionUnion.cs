using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C2F RID: 15407
	public class IRange_UnionUnion
	{
		// Token: 0x17006A11 RID: 27153
		// (get) Token: 0x06015439 RID: 87097 RVA: 0x00314035 File Offset: 0x00312235
		// (set) Token: 0x0601543A RID: 87098 RVA: 0x0031403D File Offset: 0x0031223D
		public IRange_Union Type { get; set; }

		// Token: 0x17006A12 RID: 27154
		// (get) Token: 0x0601543B RID: 87099 RVA: 0x00314046 File Offset: 0x00312246
		// (set) Token: 0x0601543C RID: 87100 RVA: 0x0031404E File Offset: 0x0031224E
		public object Value { get; set; }

		// Token: 0x0601543D RID: 87101 RVA: 0x00314057 File Offset: 0x00312257
		public IRange_UnionUnion()
		{
			this.Type = IRange_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601543E RID: 87102 RVA: 0x0031406D File Offset: 0x0031226D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601543F RID: 87103 RVA: 0x0031407F File Offset: 0x0031227F
		public IRangeT AsIRange()
		{
			return this.As<IRangeT>();
		}

		// Token: 0x06015440 RID: 87104 RVA: 0x00314087 File Offset: 0x00312287
		public static IRange_UnionUnion FromIRange(IRangeT _irange)
		{
			return new IRange_UnionUnion
			{
				Type = IRange_Union.IRange,
				Value = _irange
			};
		}

		// Token: 0x06015441 RID: 87105 RVA: 0x0031409C File Offset: 0x0031229C
		public ICircleRangeT AsICircleRange()
		{
			return this.As<ICircleRangeT>();
		}

		// Token: 0x06015442 RID: 87106 RVA: 0x003140A4 File Offset: 0x003122A4
		public static IRange_UnionUnion FromICircleRange(ICircleRangeT _icirclerange)
		{
			return new IRange_UnionUnion
			{
				Type = IRange_Union.ICircleRange,
				Value = _icirclerange
			};
		}

		// Token: 0x06015443 RID: 87107 RVA: 0x003140B9 File Offset: 0x003122B9
		public IBoxRangeT AsIBoxRange()
		{
			return this.As<IBoxRangeT>();
		}

		// Token: 0x06015444 RID: 87108 RVA: 0x003140C1 File Offset: 0x003122C1
		public static IRange_UnionUnion FromIBoxRange(IBoxRangeT _iboxrange)
		{
			return new IRange_UnionUnion
			{
				Type = IRange_Union.IBoxRange,
				Value = _iboxrange
			};
		}

		// Token: 0x06015445 RID: 87109 RVA: 0x003140D6 File Offset: 0x003122D6
		public ICylinderT AsICylinder()
		{
			return this.As<ICylinderT>();
		}

		// Token: 0x06015446 RID: 87110 RVA: 0x003140DE File Offset: 0x003122DE
		public static IRange_UnionUnion FromICylinder(ICylinderT _icylinder)
		{
			return new IRange_UnionUnion
			{
				Type = IRange_Union.ICylinder,
				Value = _icylinder
			};
		}

		// Token: 0x06015447 RID: 87111 RVA: 0x003140F4 File Offset: 0x003122F4
		public static int Pack(FlatBufferBuilder builder, IRange_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRange_Union.IRange:
				return IRange.Pack(builder, _o.AsIRange()).Value;
			case IRange_Union.ICircleRange:
				return ICircleRange.Pack(builder, _o.AsICircleRange()).Value;
			case IRange_Union.IBoxRange:
				return IBoxRange.Pack(builder, _o.AsIBoxRange()).Value;
			case IRange_Union.ICylinder:
				return ICylinder.Pack(builder, _o.AsICylinder()).Value;
			default:
				return 0;
			}
		}
	}
}
