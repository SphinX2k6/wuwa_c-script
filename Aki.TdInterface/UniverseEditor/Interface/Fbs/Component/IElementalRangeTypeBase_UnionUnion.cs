using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200513C RID: 20796
	public class IElementalRangeTypeBase_UnionUnion
	{
		// Token: 0x1700978F RID: 38799
		// (get) Token: 0x060218A2 RID: 137378 RVA: 0x004A80AD File Offset: 0x004A62AD
		// (set) Token: 0x060218A3 RID: 137379 RVA: 0x004A80B5 File Offset: 0x004A62B5
		public IElementalRangeTypeBase_Union Type { get; set; }

		// Token: 0x17009790 RID: 38800
		// (get) Token: 0x060218A4 RID: 137380 RVA: 0x004A80BE File Offset: 0x004A62BE
		// (set) Token: 0x060218A5 RID: 137381 RVA: 0x004A80C6 File Offset: 0x004A62C6
		public object Value { get; set; }

		// Token: 0x060218A6 RID: 137382 RVA: 0x004A80CF File Offset: 0x004A62CF
		public IElementalRangeTypeBase_UnionUnion()
		{
			this.Type = IElementalRangeTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060218A7 RID: 137383 RVA: 0x004A80E5 File Offset: 0x004A62E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060218A8 RID: 137384 RVA: 0x004A80F7 File Offset: 0x004A62F7
		public IElementalRangeTypeBaseT AsIElementalRangeTypeBase()
		{
			return this.As<IElementalRangeTypeBaseT>();
		}

		// Token: 0x060218A9 RID: 137385 RVA: 0x004A80FF File Offset: 0x004A62FF
		public static IElementalRangeTypeBase_UnionUnion FromIElementalRangeTypeBase(IElementalRangeTypeBaseT _ielementalrangetypebase)
		{
			return new IElementalRangeTypeBase_UnionUnion
			{
				Type = IElementalRangeTypeBase_Union.IElementalRangeTypeBase,
				Value = _ielementalrangetypebase
			};
		}

		// Token: 0x060218AA RID: 137386 RVA: 0x004A8114 File Offset: 0x004A6314
		public IBaseShapeElementalRangeT AsIBaseShapeElementalRange()
		{
			return this.As<IBaseShapeElementalRangeT>();
		}

		// Token: 0x060218AB RID: 137387 RVA: 0x004A811C File Offset: 0x004A631C
		public static IElementalRangeTypeBase_UnionUnion FromIBaseShapeElementalRange(IBaseShapeElementalRangeT _ibaseshapeelementalrange)
		{
			return new IElementalRangeTypeBase_UnionUnion
			{
				Type = IElementalRangeTypeBase_Union.IBaseShapeElementalRange,
				Value = _ibaseshapeelementalrange
			};
		}

		// Token: 0x060218AC RID: 137388 RVA: 0x004A8131 File Offset: 0x004A6331
		public ITransportBoxElementalRangeT AsITransportBoxElementalRange()
		{
			return this.As<ITransportBoxElementalRangeT>();
		}

		// Token: 0x060218AD RID: 137389 RVA: 0x004A8139 File Offset: 0x004A6339
		public static IElementalRangeTypeBase_UnionUnion FromITransportBoxElementalRange(ITransportBoxElementalRangeT _itransportboxelementalrange)
		{
			return new IElementalRangeTypeBase_UnionUnion
			{
				Type = IElementalRangeTypeBase_Union.ITransportBoxElementalRange,
				Value = _itransportboxelementalrange
			};
		}

		// Token: 0x060218AE RID: 137390 RVA: 0x004A8150 File Offset: 0x004A6350
		public static int Pack(FlatBufferBuilder builder, IElementalRangeTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IElementalRangeTypeBase_Union.IElementalRangeTypeBase:
				return IElementalRangeTypeBase.Pack(builder, _o.AsIElementalRangeTypeBase()).Value;
			case IElementalRangeTypeBase_Union.IBaseShapeElementalRange:
				return IBaseShapeElementalRange.Pack(builder, _o.AsIBaseShapeElementalRange()).Value;
			case IElementalRangeTypeBase_Union.ITransportBoxElementalRange:
				return ITransportBoxElementalRange.Pack(builder, _o.AsITransportBoxElementalRange()).Value;
			default:
				return 0;
			}
		}
	}
}
