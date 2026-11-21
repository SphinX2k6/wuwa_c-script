using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072EA RID: 29418
	public class INewSplineMoveType_UnionUnion
	{
		// Token: 0x1700D7B4 RID: 55220
		// (get) Token: 0x060334B1 RID: 210097 RVA: 0x006EB3A5 File Offset: 0x006E95A5
		// (set) Token: 0x060334B2 RID: 210098 RVA: 0x006EB3AD File Offset: 0x006E95AD
		public INewSplineMoveType_Union Type { get; set; }

		// Token: 0x1700D7B5 RID: 55221
		// (get) Token: 0x060334B3 RID: 210099 RVA: 0x006EB3B6 File Offset: 0x006E95B6
		// (set) Token: 0x060334B4 RID: 210100 RVA: 0x006EB3BE File Offset: 0x006E95BE
		public object Value { get; set; }

		// Token: 0x060334B5 RID: 210101 RVA: 0x006EB3C7 File Offset: 0x006E95C7
		public INewSplineMoveType_UnionUnion()
		{
			this.Type = INewSplineMoveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060334B6 RID: 210102 RVA: 0x006EB3DD File Offset: 0x006E95DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060334B7 RID: 210103 RVA: 0x006EB3EF File Offset: 0x006E95EF
		public INewSplineMoveTypeT AsINewSplineMoveType()
		{
			return this.As<INewSplineMoveTypeT>();
		}

		// Token: 0x060334B8 RID: 210104 RVA: 0x006EB3F7 File Offset: 0x006E95F7
		public static INewSplineMoveType_UnionUnion FromINewSplineMoveType(INewSplineMoveTypeT _inewsplinemovetype)
		{
			return new INewSplineMoveType_UnionUnion
			{
				Type = INewSplineMoveType_Union.INewSplineMoveType,
				Value = _inewsplinemovetype
			};
		}

		// Token: 0x060334B9 RID: 210105 RVA: 0x006EB40C File Offset: 0x006E960C
		public IFrontAxleTrackingSplineMoveT AsIFrontAxleTrackingSplineMove()
		{
			return this.As<IFrontAxleTrackingSplineMoveT>();
		}

		// Token: 0x060334BA RID: 210106 RVA: 0x006EB414 File Offset: 0x006E9614
		public static INewSplineMoveType_UnionUnion FromIFrontAxleTrackingSplineMove(IFrontAxleTrackingSplineMoveT _ifrontaxletrackingsplinemove)
		{
			return new INewSplineMoveType_UnionUnion
			{
				Type = INewSplineMoveType_Union.IFrontAxleTrackingSplineMove,
				Value = _ifrontaxletrackingsplinemove
			};
		}

		// Token: 0x060334BB RID: 210107 RVA: 0x006EB42C File Offset: 0x006E962C
		public static int Pack(FlatBufferBuilder builder, INewSplineMoveType_UnionUnion _o)
		{
			INewSplineMoveType_Union type = _o.Type;
			if (type == INewSplineMoveType_Union.INewSplineMoveType)
			{
				return INewSplineMoveType.Pack(builder, _o.AsINewSplineMoveType()).Value;
			}
			if (type != INewSplineMoveType_Union.IFrontAxleTrackingSplineMove)
			{
				return 0;
			}
			return IFrontAxleTrackingSplineMove.Pack(builder, _o.AsIFrontAxleTrackingSplineMove()).Value;
		}
	}
}
