using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0A RID: 23562
	public class TElementalRangeUnion
	{
		// Token: 0x1700B1E4 RID: 45540
		// (get) Token: 0x060286AF RID: 165551 RVA: 0x0059042C File Offset: 0x0058E62C
		// (set) Token: 0x060286B0 RID: 165552 RVA: 0x00590434 File Offset: 0x0058E634
		public TElementalRange Type { get; set; }

		// Token: 0x1700B1E5 RID: 45541
		// (get) Token: 0x060286B1 RID: 165553 RVA: 0x0059043D File Offset: 0x0058E63D
		// (set) Token: 0x060286B2 RID: 165554 RVA: 0x00590445 File Offset: 0x0058E645
		public object Value { get; set; }

		// Token: 0x060286B3 RID: 165555 RVA: 0x0059044E File Offset: 0x0058E64E
		public TElementalRangeUnion()
		{
			this.Type = TElementalRange.NONE;
			this.Value = null;
		}

		// Token: 0x060286B4 RID: 165556 RVA: 0x00590464 File Offset: 0x0058E664
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060286B5 RID: 165557 RVA: 0x00590476 File Offset: 0x0058E676
		public IBaseShapeElementalRangeT AsIBaseShapeElementalRange()
		{
			return this.As<IBaseShapeElementalRangeT>();
		}

		// Token: 0x060286B6 RID: 165558 RVA: 0x0059047E File Offset: 0x0058E67E
		public static TElementalRangeUnion FromIBaseShapeElementalRange(IBaseShapeElementalRangeT _ibaseshapeelementalrange)
		{
			return new TElementalRangeUnion
			{
				Type = TElementalRange.IBaseShapeElementalRange,
				Value = _ibaseshapeelementalrange
			};
		}

		// Token: 0x060286B7 RID: 165559 RVA: 0x00590493 File Offset: 0x0058E693
		public ITransportBoxElementalRangeT AsITransportBoxElementalRange()
		{
			return this.As<ITransportBoxElementalRangeT>();
		}

		// Token: 0x060286B8 RID: 165560 RVA: 0x0059049B File Offset: 0x0058E69B
		public static TElementalRangeUnion FromITransportBoxElementalRange(ITransportBoxElementalRangeT _itransportboxelementalrange)
		{
			return new TElementalRangeUnion
			{
				Type = TElementalRange.ITransportBoxElementalRange,
				Value = _itransportboxelementalrange
			};
		}

		// Token: 0x060286B9 RID: 165561 RVA: 0x005904B0 File Offset: 0x0058E6B0
		public static int Pack(FlatBufferBuilder builder, TElementalRangeUnion _o)
		{
			TElementalRange type = _o.Type;
			if (type == TElementalRange.IBaseShapeElementalRange)
			{
				return IBaseShapeElementalRange.Pack(builder, _o.AsIBaseShapeElementalRange()).Value;
			}
			if (type != TElementalRange.ITransportBoxElementalRange)
			{
				return 0;
			}
			return ITransportBoxElementalRange.Pack(builder, _o.AsITransportBoxElementalRange()).Value;
		}
	}
}
