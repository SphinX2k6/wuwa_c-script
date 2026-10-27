using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071EE RID: 29166
	public class IStopNewMoveWithSplineType_UnionUnion
	{
		// Token: 0x1700D896 RID: 55446
		// (get) Token: 0x06033BAC RID: 211884 RVA: 0x006F6CDD File Offset: 0x006F4EDD
		// (set) Token: 0x06033BAD RID: 211885 RVA: 0x006F6CE5 File Offset: 0x006F4EE5
		public IStopNewMoveWithSplineType_Union Type { get; set; }

		// Token: 0x1700D897 RID: 55447
		// (get) Token: 0x06033BAE RID: 211886 RVA: 0x006F6CEE File Offset: 0x006F4EEE
		// (set) Token: 0x06033BAF RID: 211887 RVA: 0x006F6CF6 File Offset: 0x006F4EF6
		public object Value { get; set; }

		// Token: 0x06033BB0 RID: 211888 RVA: 0x006F6CFF File Offset: 0x006F4EFF
		public IStopNewMoveWithSplineType_UnionUnion()
		{
			this.Type = IStopNewMoveWithSplineType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033BB1 RID: 211889 RVA: 0x006F6D15 File Offset: 0x006F4F15
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033BB2 RID: 211890 RVA: 0x006F6D27 File Offset: 0x006F4F27
		public IStopNewMoveWithSplineTypeT AsIStopNewMoveWithSplineType()
		{
			return this.As<IStopNewMoveWithSplineTypeT>();
		}

		// Token: 0x06033BB3 RID: 211891 RVA: 0x006F6D2F File Offset: 0x006F4F2F
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineType(IStopNewMoveWithSplineTypeT _istopnewmovewithsplinetype)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineType,
				Value = _istopnewmovewithsplinetype
			};
		}

		// Token: 0x06033BB4 RID: 211892 RVA: 0x006F6D44 File Offset: 0x006F4F44
		public IStopNewMoveWithSplineAtCurrentPosT AsIStopNewMoveWithSplineAtCurrentPos()
		{
			return this.As<IStopNewMoveWithSplineAtCurrentPosT>();
		}

		// Token: 0x06033BB5 RID: 211893 RVA: 0x006F6D4C File Offset: 0x006F4F4C
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineAtCurrentPos(IStopNewMoveWithSplineAtCurrentPosT _istopnewmovewithsplineatcurrentpos)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtCurrentPos,
				Value = _istopnewmovewithsplineatcurrentpos
			};
		}

		// Token: 0x06033BB6 RID: 211894 RVA: 0x006F6D61 File Offset: 0x006F4F61
		public IStopNewMoveWithSplineAtStartPointT AsIStopNewMoveWithSplineAtStartPoint()
		{
			return this.As<IStopNewMoveWithSplineAtStartPointT>();
		}

		// Token: 0x06033BB7 RID: 211895 RVA: 0x006F6D69 File Offset: 0x006F4F69
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineAtStartPoint(IStopNewMoveWithSplineAtStartPointT _istopnewmovewithsplineatstartpoint)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtStartPoint,
				Value = _istopnewmovewithsplineatstartpoint
			};
		}

		// Token: 0x06033BB8 RID: 211896 RVA: 0x006F6D7E File Offset: 0x006F4F7E
		public IStopNewMoveWithSplineAtEndPointT AsIStopNewMoveWithSplineAtEndPoint()
		{
			return this.As<IStopNewMoveWithSplineAtEndPointT>();
		}

		// Token: 0x06033BB9 RID: 211897 RVA: 0x006F6D86 File Offset: 0x006F4F86
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineAtEndPoint(IStopNewMoveWithSplineAtEndPointT _istopnewmovewithsplineatendpoint)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtEndPoint,
				Value = _istopnewmovewithsplineatendpoint
			};
		}

		// Token: 0x06033BBA RID: 211898 RVA: 0x006F6D9B File Offset: 0x006F4F9B
		public IStopNewMoveWithSplineAtTargetPointT AsIStopNewMoveWithSplineAtTargetPoint()
		{
			return this.As<IStopNewMoveWithSplineAtTargetPointT>();
		}

		// Token: 0x06033BBB RID: 211899 RVA: 0x006F6DA3 File Offset: 0x006F4FA3
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineAtTargetPoint(IStopNewMoveWithSplineAtTargetPointT _istopnewmovewithsplineattargetpoint)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtTargetPoint,
				Value = _istopnewmovewithsplineattargetpoint
			};
		}

		// Token: 0x06033BBC RID: 211900 RVA: 0x006F6DB8 File Offset: 0x006F4FB8
		public static int Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineType:
				return IStopNewMoveWithSplineType.Pack(builder, _o.AsIStopNewMoveWithSplineType()).Value;
			case IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtCurrentPos:
				return IStopNewMoveWithSplineAtCurrentPos.Pack(builder, _o.AsIStopNewMoveWithSplineAtCurrentPos()).Value;
			case IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtStartPoint:
				return IStopNewMoveWithSplineAtStartPoint.Pack(builder, _o.AsIStopNewMoveWithSplineAtStartPoint()).Value;
			case IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtEndPoint:
				return IStopNewMoveWithSplineAtEndPoint.Pack(builder, _o.AsIStopNewMoveWithSplineAtEndPoint()).Value;
			case IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtTargetPoint:
				return IStopNewMoveWithSplineAtTargetPoint.Pack(builder, _o.AsIStopNewMoveWithSplineAtTargetPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
