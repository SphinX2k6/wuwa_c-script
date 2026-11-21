using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C3 RID: 31171
	public class IStopNewMoveWithSplineType_UnionUnion
	{
		// Token: 0x1700E48F RID: 58511
		// (get) Token: 0x06036EAE RID: 224942 RVA: 0x0075803D File Offset: 0x0075623D
		// (set) Token: 0x06036EAF RID: 224943 RVA: 0x00758045 File Offset: 0x00756245
		public IStopNewMoveWithSplineType_Union Type { get; set; }

		// Token: 0x1700E490 RID: 58512
		// (get) Token: 0x06036EB0 RID: 224944 RVA: 0x0075804E File Offset: 0x0075624E
		// (set) Token: 0x06036EB1 RID: 224945 RVA: 0x00758056 File Offset: 0x00756256
		public object Value { get; set; }

		// Token: 0x06036EB2 RID: 224946 RVA: 0x0075805F File Offset: 0x0075625F
		public IStopNewMoveWithSplineType_UnionUnion()
		{
			this.Type = IStopNewMoveWithSplineType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036EB3 RID: 224947 RVA: 0x00758075 File Offset: 0x00756275
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036EB4 RID: 224948 RVA: 0x00758087 File Offset: 0x00756287
		public IStopNewMoveWithSplineTypeT AsIStopNewMoveWithSplineType()
		{
			return this.As<IStopNewMoveWithSplineTypeT>();
		}

		// Token: 0x06036EB5 RID: 224949 RVA: 0x0075808F File Offset: 0x0075628F
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineType(IStopNewMoveWithSplineTypeT _istopnewmovewithsplinetype)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineType,
				Value = _istopnewmovewithsplinetype
			};
		}

		// Token: 0x06036EB6 RID: 224950 RVA: 0x007580A4 File Offset: 0x007562A4
		public IStopNewMoveWithSplineAtCurrentPosT AsIStopNewMoveWithSplineAtCurrentPos()
		{
			return this.As<IStopNewMoveWithSplineAtCurrentPosT>();
		}

		// Token: 0x06036EB7 RID: 224951 RVA: 0x007580AC File Offset: 0x007562AC
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineAtCurrentPos(IStopNewMoveWithSplineAtCurrentPosT _istopnewmovewithsplineatcurrentpos)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtCurrentPos,
				Value = _istopnewmovewithsplineatcurrentpos
			};
		}

		// Token: 0x06036EB8 RID: 224952 RVA: 0x007580C1 File Offset: 0x007562C1
		public IStopNewMoveWithSplineAtStartPointT AsIStopNewMoveWithSplineAtStartPoint()
		{
			return this.As<IStopNewMoveWithSplineAtStartPointT>();
		}

		// Token: 0x06036EB9 RID: 224953 RVA: 0x007580C9 File Offset: 0x007562C9
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineAtStartPoint(IStopNewMoveWithSplineAtStartPointT _istopnewmovewithsplineatstartpoint)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtStartPoint,
				Value = _istopnewmovewithsplineatstartpoint
			};
		}

		// Token: 0x06036EBA RID: 224954 RVA: 0x007580DE File Offset: 0x007562DE
		public IStopNewMoveWithSplineAtEndPointT AsIStopNewMoveWithSplineAtEndPoint()
		{
			return this.As<IStopNewMoveWithSplineAtEndPointT>();
		}

		// Token: 0x06036EBB RID: 224955 RVA: 0x007580E6 File Offset: 0x007562E6
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineAtEndPoint(IStopNewMoveWithSplineAtEndPointT _istopnewmovewithsplineatendpoint)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtEndPoint,
				Value = _istopnewmovewithsplineatendpoint
			};
		}

		// Token: 0x06036EBC RID: 224956 RVA: 0x007580FB File Offset: 0x007562FB
		public IStopNewMoveWithSplineAtTargetPointT AsIStopNewMoveWithSplineAtTargetPoint()
		{
			return this.As<IStopNewMoveWithSplineAtTargetPointT>();
		}

		// Token: 0x06036EBD RID: 224957 RVA: 0x00758103 File Offset: 0x00756303
		public static IStopNewMoveWithSplineType_UnionUnion FromIStopNewMoveWithSplineAtTargetPoint(IStopNewMoveWithSplineAtTargetPointT _istopnewmovewithsplineattargetpoint)
		{
			return new IStopNewMoveWithSplineType_UnionUnion
			{
				Type = IStopNewMoveWithSplineType_Union.IStopNewMoveWithSplineAtTargetPoint,
				Value = _istopnewmovewithsplineattargetpoint
			};
		}

		// Token: 0x06036EBE RID: 224958 RVA: 0x00758118 File Offset: 0x00756318
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
