using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F58 RID: 32600
	public class TMoveSceneItemUnion
	{
		// Token: 0x1700F2B3 RID: 62131
		// (get) Token: 0x0603AC5F RID: 240735 RVA: 0x007E6BDA File Offset: 0x007E4DDA
		// (set) Token: 0x0603AC60 RID: 240736 RVA: 0x007E6BE2 File Offset: 0x007E4DE2
		public TMoveSceneItem Type { get; set; }

		// Token: 0x1700F2B4 RID: 62132
		// (get) Token: 0x0603AC61 RID: 240737 RVA: 0x007E6BEB File Offset: 0x007E4DEB
		// (set) Token: 0x0603AC62 RID: 240738 RVA: 0x007E6BF3 File Offset: 0x007E4DF3
		public object Value { get; set; }

		// Token: 0x0603AC63 RID: 240739 RVA: 0x007E6BFC File Offset: 0x007E4DFC
		public TMoveSceneItemUnion()
		{
			this.Type = TMoveSceneItem.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC64 RID: 240740 RVA: 0x007E6C12 File Offset: 0x007E4E12
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC65 RID: 240741 RVA: 0x007E6C24 File Offset: 0x007E4E24
		public ICycleMoveToPointsT AsICycleMoveToPoints()
		{
			return this.As<ICycleMoveToPointsT>();
		}

		// Token: 0x0603AC66 RID: 240742 RVA: 0x007E6C2C File Offset: 0x007E4E2C
		public static TMoveSceneItemUnion FromICycleMoveToPoints(ICycleMoveToPointsT _icyclemovetopoints)
		{
			return new TMoveSceneItemUnion
			{
				Type = TMoveSceneItem.ICycleMoveToPoints,
				Value = _icyclemovetopoints
			};
		}

		// Token: 0x0603AC67 RID: 240743 RVA: 0x007E6C41 File Offset: 0x007E4E41
		public IMoveToEntityT AsIMoveToEntity()
		{
			return this.As<IMoveToEntityT>();
		}

		// Token: 0x0603AC68 RID: 240744 RVA: 0x007E6C49 File Offset: 0x007E4E49
		public static TMoveSceneItemUnion FromIMoveToEntity(IMoveToEntityT _imovetoentity)
		{
			return new TMoveSceneItemUnion
			{
				Type = TMoveSceneItem.IMoveToEntity,
				Value = _imovetoentity
			};
		}

		// Token: 0x0603AC69 RID: 240745 RVA: 0x007E6C5E File Offset: 0x007E4E5E
		public IMoveToPointT AsIMoveToPoint()
		{
			return this.As<IMoveToPointT>();
		}

		// Token: 0x0603AC6A RID: 240746 RVA: 0x007E6C66 File Offset: 0x007E4E66
		public static TMoveSceneItemUnion FromIMoveToPoint(IMoveToPointT _imovetopoint)
		{
			return new TMoveSceneItemUnion
			{
				Type = TMoveSceneItem.IMoveToPoint,
				Value = _imovetopoint
			};
		}

		// Token: 0x0603AC6B RID: 240747 RVA: 0x007E6C7B File Offset: 0x007E4E7B
		public IMoveToRelativePositionT AsIMoveToRelativePosition()
		{
			return this.As<IMoveToRelativePositionT>();
		}

		// Token: 0x0603AC6C RID: 240748 RVA: 0x007E6C83 File Offset: 0x007E4E83
		public static TMoveSceneItemUnion FromIMoveToRelativePosition(IMoveToRelativePositionT _imovetorelativeposition)
		{
			return new TMoveSceneItemUnion
			{
				Type = TMoveSceneItem.IMoveToRelativePosition,
				Value = _imovetorelativeposition
			};
		}

		// Token: 0x0603AC6D RID: 240749 RVA: 0x007E6C98 File Offset: 0x007E4E98
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
