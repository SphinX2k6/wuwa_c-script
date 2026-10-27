using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5B RID: 27483
	public class IMoveSceneItemType_UnionUnion
	{
		// Token: 0x1700CC2F RID: 52271
		// (get) Token: 0x060303D3 RID: 197587 RVA: 0x0068DF9D File Offset: 0x0068C19D
		// (set) Token: 0x060303D4 RID: 197588 RVA: 0x0068DFA5 File Offset: 0x0068C1A5
		public IMoveSceneItemType_Union Type { get; set; }

		// Token: 0x1700CC30 RID: 52272
		// (get) Token: 0x060303D5 RID: 197589 RVA: 0x0068DFAE File Offset: 0x0068C1AE
		// (set) Token: 0x060303D6 RID: 197590 RVA: 0x0068DFB6 File Offset: 0x0068C1B6
		public object Value { get; set; }

		// Token: 0x060303D7 RID: 197591 RVA: 0x0068DFBF File Offset: 0x0068C1BF
		public IMoveSceneItemType_UnionUnion()
		{
			this.Type = IMoveSceneItemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060303D8 RID: 197592 RVA: 0x0068DFD5 File Offset: 0x0068C1D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060303D9 RID: 197593 RVA: 0x0068DFE7 File Offset: 0x0068C1E7
		public IMoveSceneItemTypeT AsIMoveSceneItemType()
		{
			return this.As<IMoveSceneItemTypeT>();
		}

		// Token: 0x060303DA RID: 197594 RVA: 0x0068DFEF File Offset: 0x0068C1EF
		public static IMoveSceneItemType_UnionUnion FromIMoveSceneItemType(IMoveSceneItemTypeT _imovesceneitemtype)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.IMoveSceneItemType,
				Value = _imovesceneitemtype
			};
		}

		// Token: 0x060303DB RID: 197595 RVA: 0x0068E004 File Offset: 0x0068C204
		public IMoveToPointT AsIMoveToPoint()
		{
			return this.As<IMoveToPointT>();
		}

		// Token: 0x060303DC RID: 197596 RVA: 0x0068E00C File Offset: 0x0068C20C
		public static IMoveSceneItemType_UnionUnion FromIMoveToPoint(IMoveToPointT _imovetopoint)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.IMoveToPoint,
				Value = _imovetopoint
			};
		}

		// Token: 0x060303DD RID: 197597 RVA: 0x0068E021 File Offset: 0x0068C221
		public ICycleMoveToPointsT AsICycleMoveToPoints()
		{
			return this.As<ICycleMoveToPointsT>();
		}

		// Token: 0x060303DE RID: 197598 RVA: 0x0068E029 File Offset: 0x0068C229
		public static IMoveSceneItemType_UnionUnion FromICycleMoveToPoints(ICycleMoveToPointsT _icyclemovetopoints)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.ICycleMoveToPoints,
				Value = _icyclemovetopoints
			};
		}

		// Token: 0x060303DF RID: 197599 RVA: 0x0068E03E File Offset: 0x0068C23E
		public IMoveToRelativePositionT AsIMoveToRelativePosition()
		{
			return this.As<IMoveToRelativePositionT>();
		}

		// Token: 0x060303E0 RID: 197600 RVA: 0x0068E046 File Offset: 0x0068C246
		public static IMoveSceneItemType_UnionUnion FromIMoveToRelativePosition(IMoveToRelativePositionT _imovetorelativeposition)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.IMoveToRelativePosition,
				Value = _imovetorelativeposition
			};
		}

		// Token: 0x060303E1 RID: 197601 RVA: 0x0068E05B File Offset: 0x0068C25B
		public IMoveToEntityT AsIMoveToEntity()
		{
			return this.As<IMoveToEntityT>();
		}

		// Token: 0x060303E2 RID: 197602 RVA: 0x0068E063 File Offset: 0x0068C263
		public static IMoveSceneItemType_UnionUnion FromIMoveToEntity(IMoveToEntityT _imovetoentity)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.IMoveToEntity,
				Value = _imovetoentity
			};
		}

		// Token: 0x060303E3 RID: 197603 RVA: 0x0068E078 File Offset: 0x0068C278
		public static int Pack(FlatBufferBuilder builder, IMoveSceneItemType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMoveSceneItemType_Union.IMoveSceneItemType:
				return IMoveSceneItemType.Pack(builder, _o.AsIMoveSceneItemType()).Value;
			case IMoveSceneItemType_Union.IMoveToPoint:
				return IMoveToPoint.Pack(builder, _o.AsIMoveToPoint()).Value;
			case IMoveSceneItemType_Union.ICycleMoveToPoints:
				return ICycleMoveToPoints.Pack(builder, _o.AsICycleMoveToPoints()).Value;
			case IMoveSceneItemType_Union.IMoveToRelativePosition:
				return IMoveToRelativePosition.Pack(builder, _o.AsIMoveToRelativePosition()).Value;
			case IMoveSceneItemType_Union.IMoveToEntity:
				return IMoveToEntity.Pack(builder, _o.AsIMoveToEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
