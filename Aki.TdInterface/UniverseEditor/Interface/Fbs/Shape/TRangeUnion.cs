using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200408C RID: 16524
	public class TRangeUnion
	{
		// Token: 0x1700707A RID: 28794
		// (get) Token: 0x06016C19 RID: 93209 RVA: 0x0034009C File Offset: 0x0033E29C
		// (set) Token: 0x06016C1A RID: 93210 RVA: 0x003400A4 File Offset: 0x0033E2A4
		public TRange Type { get; set; }

		// Token: 0x1700707B RID: 28795
		// (get) Token: 0x06016C1B RID: 93211 RVA: 0x003400AD File Offset: 0x0033E2AD
		// (set) Token: 0x06016C1C RID: 93212 RVA: 0x003400B5 File Offset: 0x0033E2B5
		public object Value { get; set; }

		// Token: 0x06016C1D RID: 93213 RVA: 0x003400BE File Offset: 0x0033E2BE
		public TRangeUnion()
		{
			this.Type = TRange.NONE;
			this.Value = null;
		}

		// Token: 0x06016C1E RID: 93214 RVA: 0x003400D4 File Offset: 0x0033E2D4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016C1F RID: 93215 RVA: 0x003400E6 File Offset: 0x0033E2E6
		public IBoxRangeT AsIBoxRange()
		{
			return this.As<IBoxRangeT>();
		}

		// Token: 0x06016C20 RID: 93216 RVA: 0x003400EE File Offset: 0x0033E2EE
		public static TRangeUnion FromIBoxRange(IBoxRangeT _iboxrange)
		{
			return new TRangeUnion
			{
				Type = TRange.IBoxRange,
				Value = _iboxrange
			};
		}

		// Token: 0x06016C21 RID: 93217 RVA: 0x00340103 File Offset: 0x0033E303
		public ICircleRangeT AsICircleRange()
		{
			return this.As<ICircleRangeT>();
		}

		// Token: 0x06016C22 RID: 93218 RVA: 0x0034010B File Offset: 0x0033E30B
		public static TRangeUnion FromICircleRange(ICircleRangeT _icirclerange)
		{
			return new TRangeUnion
			{
				Type = TRange.ICircleRange,
				Value = _icirclerange
			};
		}

		// Token: 0x06016C23 RID: 93219 RVA: 0x00340120 File Offset: 0x0033E320
		public ICylinderT AsICylinder()
		{
			return this.As<ICylinderT>();
		}

		// Token: 0x06016C24 RID: 93220 RVA: 0x00340128 File Offset: 0x0033E328
		public static TRangeUnion FromICylinder(ICylinderT _icylinder)
		{
			return new TRangeUnion
			{
				Type = TRange.ICylinder,
				Value = _icylinder
			};
		}

		// Token: 0x06016C25 RID: 93221 RVA: 0x00340140 File Offset: 0x0033E340
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
