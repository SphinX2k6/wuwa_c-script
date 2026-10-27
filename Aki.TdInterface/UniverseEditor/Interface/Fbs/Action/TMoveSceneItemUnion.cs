using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772F RID: 30511
	public class TMoveSceneItemUnion
	{
		// Token: 0x1700E663 RID: 58979
		// (get) Token: 0x06037724 RID: 227108 RVA: 0x00781C4A File Offset: 0x0077FE4A
		// (set) Token: 0x06037725 RID: 227109 RVA: 0x00781C52 File Offset: 0x0077FE52
		public TMoveSceneItem Type { get; set; }

		// Token: 0x1700E664 RID: 58980
		// (get) Token: 0x06037726 RID: 227110 RVA: 0x00781C5B File Offset: 0x0077FE5B
		// (set) Token: 0x06037727 RID: 227111 RVA: 0x00781C63 File Offset: 0x0077FE63
		public object Value { get; set; }

		// Token: 0x06037728 RID: 227112 RVA: 0x00781C6C File Offset: 0x0077FE6C
		public TMoveSceneItemUnion()
		{
			this.Type = TMoveSceneItem.NONE;
			this.Value = null;
		}

		// Token: 0x06037729 RID: 227113 RVA: 0x00781C82 File Offset: 0x0077FE82
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603772A RID: 227114 RVA: 0x00781C94 File Offset: 0x0077FE94
		public ICycleMoveToPointsT AsICycleMoveToPoints()
		{
			return this.As<ICycleMoveToPointsT>();
		}

		// Token: 0x0603772B RID: 227115 RVA: 0x00781C9C File Offset: 0x0077FE9C
		public static TMoveSceneItemUnion FromICycleMoveToPoints(ICycleMoveToPointsT _icyclemovetopoints)
		{
			return new TMoveSceneItemUnion
			{
				Type = TMoveSceneItem.ICycleMoveToPoints,
				Value = _icyclemovetopoints
			};
		}

		// Token: 0x0603772C RID: 227116 RVA: 0x00781CB1 File Offset: 0x0077FEB1
		public IMoveToEntityT AsIMoveToEntity()
		{
			return this.As<IMoveToEntityT>();
		}

		// Token: 0x0603772D RID: 227117 RVA: 0x00781CB9 File Offset: 0x0077FEB9
		public static TMoveSceneItemUnion FromIMoveToEntity(IMoveToEntityT _imovetoentity)
		{
			return new TMoveSceneItemUnion
			{
				Type = TMoveSceneItem.IMoveToEntity,
				Value = _imovetoentity
			};
		}

		// Token: 0x0603772E RID: 227118 RVA: 0x00781CCE File Offset: 0x0077FECE
		public IMoveToPointT AsIMoveToPoint()
		{
			return this.As<IMoveToPointT>();
		}

		// Token: 0x0603772F RID: 227119 RVA: 0x00781CD6 File Offset: 0x0077FED6
		public static TMoveSceneItemUnion FromIMoveToPoint(IMoveToPointT _imovetopoint)
		{
			return new TMoveSceneItemUnion
			{
				Type = TMoveSceneItem.IMoveToPoint,
				Value = _imovetopoint
			};
		}

		// Token: 0x06037730 RID: 227120 RVA: 0x00781CEB File Offset: 0x0077FEEB
		public IMoveToRelativePositionT AsIMoveToRelativePosition()
		{
			return this.As<IMoveToRelativePositionT>();
		}

		// Token: 0x06037731 RID: 227121 RVA: 0x00781CF3 File Offset: 0x0077FEF3
		public static TMoveSceneItemUnion FromIMoveToRelativePosition(IMoveToRelativePositionT _imovetorelativeposition)
		{
			return new TMoveSceneItemUnion
			{
				Type = TMoveSceneItem.IMoveToRelativePosition,
				Value = _imovetorelativeposition
			};
		}

		// Token: 0x06037732 RID: 227122 RVA: 0x00781D08 File Offset: 0x0077FF08
		public static int Pack(FlatBufferBuilder builder, TMoveSceneItemUnion _o)
		{
			switch (_o.Type)
			{
			case TMoveSceneItem.ICycleMoveToPoints:
				return ICycleMoveToPoints.Pack(builder, _o.AsICycleMoveToPoints()).Value;
			case TMoveSceneItem.IMoveToEntity:
				return IMoveToEntity.Pack(builder, _o.AsIMoveToEntity()).Value;
			case TMoveSceneItem.IMoveToPoint:
				return IMoveToPoint.Pack(builder, _o.AsIMoveToPoint()).Value;
			case TMoveSceneItem.IMoveToRelativePosition:
				return IMoveToRelativePosition.Pack(builder, _o.AsIMoveToRelativePosition()).Value;
			default:
				return 0;
			}
		}
	}
}
