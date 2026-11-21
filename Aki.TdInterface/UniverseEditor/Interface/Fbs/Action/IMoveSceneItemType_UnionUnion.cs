using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A1 RID: 29345
	public class IMoveSceneItemType_UnionUnion
	{
		// Token: 0x1700D714 RID: 55060
		// (get) Token: 0x0603322A RID: 209450 RVA: 0x006E6559 File Offset: 0x006E4759
		// (set) Token: 0x0603322B RID: 209451 RVA: 0x006E6561 File Offset: 0x006E4761
		public IMoveSceneItemType_Union Type { get; set; }

		// Token: 0x1700D715 RID: 55061
		// (get) Token: 0x0603322C RID: 209452 RVA: 0x006E656A File Offset: 0x006E476A
		// (set) Token: 0x0603322D RID: 209453 RVA: 0x006E6572 File Offset: 0x006E4772
		public object Value { get; set; }

		// Token: 0x0603322E RID: 209454 RVA: 0x006E657B File Offset: 0x006E477B
		public IMoveSceneItemType_UnionUnion()
		{
			this.Type = IMoveSceneItemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603322F RID: 209455 RVA: 0x006E6591 File Offset: 0x006E4791
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033230 RID: 209456 RVA: 0x006E65A3 File Offset: 0x006E47A3
		public IMoveSceneItemTypeT AsIMoveSceneItemType()
		{
			return this.As<IMoveSceneItemTypeT>();
		}

		// Token: 0x06033231 RID: 209457 RVA: 0x006E65AB File Offset: 0x006E47AB
		public static IMoveSceneItemType_UnionUnion FromIMoveSceneItemType(IMoveSceneItemTypeT _imovesceneitemtype)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.IMoveSceneItemType,
				Value = _imovesceneitemtype
			};
		}

		// Token: 0x06033232 RID: 209458 RVA: 0x006E65C0 File Offset: 0x006E47C0
		public IMoveToPointT AsIMoveToPoint()
		{
			return this.As<IMoveToPointT>();
		}

		// Token: 0x06033233 RID: 209459 RVA: 0x006E65C8 File Offset: 0x006E47C8
		public static IMoveSceneItemType_UnionUnion FromIMoveToPoint(IMoveToPointT _imovetopoint)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.IMoveToPoint,
				Value = _imovetopoint
			};
		}

		// Token: 0x06033234 RID: 209460 RVA: 0x006E65DD File Offset: 0x006E47DD
		public ICycleMoveToPointsT AsICycleMoveToPoints()
		{
			return this.As<ICycleMoveToPointsT>();
		}

		// Token: 0x06033235 RID: 209461 RVA: 0x006E65E5 File Offset: 0x006E47E5
		public static IMoveSceneItemType_UnionUnion FromICycleMoveToPoints(ICycleMoveToPointsT _icyclemovetopoints)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.ICycleMoveToPoints,
				Value = _icyclemovetopoints
			};
		}

		// Token: 0x06033236 RID: 209462 RVA: 0x006E65FA File Offset: 0x006E47FA
		public IMoveToRelativePositionT AsIMoveToRelativePosition()
		{
			return this.As<IMoveToRelativePositionT>();
		}

		// Token: 0x06033237 RID: 209463 RVA: 0x006E6602 File Offset: 0x006E4802
		public static IMoveSceneItemType_UnionUnion FromIMoveToRelativePosition(IMoveToRelativePositionT _imovetorelativeposition)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.IMoveToRelativePosition,
				Value = _imovetorelativeposition
			};
		}

		// Token: 0x06033238 RID: 209464 RVA: 0x006E6617 File Offset: 0x006E4817
		public IMoveToEntityT AsIMoveToEntity()
		{
			return this.As<IMoveToEntityT>();
		}

		// Token: 0x06033239 RID: 209465 RVA: 0x006E661F File Offset: 0x006E481F
		public static IMoveSceneItemType_UnionUnion FromIMoveToEntity(IMoveToEntityT _imovetoentity)
		{
			return new IMoveSceneItemType_UnionUnion
			{
				Type = IMoveSceneItemType_Union.IMoveToEntity,
				Value = _imovetoentity
			};
		}

		// Token: 0x0603323A RID: 209466 RVA: 0x006E6634 File Offset: 0x006E4834
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
