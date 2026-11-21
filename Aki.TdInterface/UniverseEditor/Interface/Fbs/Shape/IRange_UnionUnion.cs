using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200403E RID: 16446
	public class IRange_UnionUnion
	{
		// Token: 0x17006FC2 RID: 28610
		// (get) Token: 0x0601694D RID: 92493 RVA: 0x0033AED5 File Offset: 0x003390D5
		// (set) Token: 0x0601694E RID: 92494 RVA: 0x0033AEDD File Offset: 0x003390DD
		public IRange_Union Type { get; set; }

		// Token: 0x17006FC3 RID: 28611
		// (get) Token: 0x0601694F RID: 92495 RVA: 0x0033AEE6 File Offset: 0x003390E6
		// (set) Token: 0x06016950 RID: 92496 RVA: 0x0033AEEE File Offset: 0x003390EE
		public object Value { get; set; }

		// Token: 0x06016951 RID: 92497 RVA: 0x0033AEF7 File Offset: 0x003390F7
		public IRange_UnionUnion()
		{
			this.Type = IRange_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016952 RID: 92498 RVA: 0x0033AF0D File Offset: 0x0033910D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016953 RID: 92499 RVA: 0x0033AF1F File Offset: 0x0033911F
		public IRangeT AsIRange()
		{
			return this.As<IRangeT>();
		}

		// Token: 0x06016954 RID: 92500 RVA: 0x0033AF27 File Offset: 0x00339127
		public static IRange_UnionUnion FromIRange(IRangeT _irange)
		{
			return new IRange_UnionUnion
			{
				Type = IRange_Union.IRange,
				Value = _irange
			};
		}

		// Token: 0x06016955 RID: 92501 RVA: 0x0033AF3C File Offset: 0x0033913C
		public ICircleRangeT AsICircleRange()
		{
			return this.As<ICircleRangeT>();
		}

		// Token: 0x06016956 RID: 92502 RVA: 0x0033AF44 File Offset: 0x00339144
		public static IRange_UnionUnion FromICircleRange(ICircleRangeT _icirclerange)
		{
			return new IRange_UnionUnion
			{
				Type = IRange_Union.ICircleRange,
				Value = _icirclerange
			};
		}

		// Token: 0x06016957 RID: 92503 RVA: 0x0033AF59 File Offset: 0x00339159
		public IBoxRangeT AsIBoxRange()
		{
			return this.As<IBoxRangeT>();
		}

		// Token: 0x06016958 RID: 92504 RVA: 0x0033AF61 File Offset: 0x00339161
		public static IRange_UnionUnion FromIBoxRange(IBoxRangeT _iboxrange)
		{
			return new IRange_UnionUnion
			{
				Type = IRange_Union.IBoxRange,
				Value = _iboxrange
			};
		}

		// Token: 0x06016959 RID: 92505 RVA: 0x0033AF76 File Offset: 0x00339176
		public ICylinderT AsICylinder()
		{
			return this.As<ICylinderT>();
		}

		// Token: 0x0601695A RID: 92506 RVA: 0x0033AF7E File Offset: 0x0033917E
		public static IRange_UnionUnion FromICylinder(ICylinderT _icylinder)
		{
			return new IRange_UnionUnion
			{
				Type = IRange_Union.ICylinder,
				Value = _icylinder
			};
		}

		// Token: 0x0601695B RID: 92507 RVA: 0x0033AF94 File Offset: 0x00339194
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
