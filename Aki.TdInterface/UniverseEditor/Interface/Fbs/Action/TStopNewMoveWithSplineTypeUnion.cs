using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AB RID: 30635
	public class TStopNewMoveWithSplineTypeUnion
	{
		// Token: 0x1700E6B5 RID: 59061
		// (get) Token: 0x0603797E RID: 227710 RVA: 0x007853FC File Offset: 0x007835FC
		// (set) Token: 0x0603797F RID: 227711 RVA: 0x00785404 File Offset: 0x00783604
		public TStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x1700E6B6 RID: 59062
		// (get) Token: 0x06037980 RID: 227712 RVA: 0x0078540D File Offset: 0x0078360D
		// (set) Token: 0x06037981 RID: 227713 RVA: 0x00785415 File Offset: 0x00783615
		public object Value { get; set; }

		// Token: 0x06037982 RID: 227714 RVA: 0x0078541E File Offset: 0x0078361E
		public TStopNewMoveWithSplineTypeUnion()
		{
			this.Type = TStopNewMoveWithSplineType.NONE;
			this.Value = null;
		}

		// Token: 0x06037983 RID: 227715 RVA: 0x00785434 File Offset: 0x00783634
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037984 RID: 227716 RVA: 0x00785446 File Offset: 0x00783646
		public IStopNewMoveWithSplineAtCurrentPosT AsIStopNewMoveWithSplineAtCurrentPos()
		{
			return this.As<IStopNewMoveWithSplineAtCurrentPosT>();
		}

		// Token: 0x06037985 RID: 227717 RVA: 0x0078544E File Offset: 0x0078364E
		public static TStopNewMoveWithSplineTypeUnion FromIStopNewMoveWithSplineAtCurrentPos(IStopNewMoveWithSplineAtCurrentPosT _istopnewmovewithsplineatcurrentpos)
		{
			return new TStopNewMoveWithSplineTypeUnion
			{
				Type = TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtCurrentPos,
				Value = _istopnewmovewithsplineatcurrentpos
			};
		}

		// Token: 0x06037986 RID: 227718 RVA: 0x00785463 File Offset: 0x00783663
		public IStopNewMoveWithSplineAtEndPointT AsIStopNewMoveWithSplineAtEndPoint()
		{
			return this.As<IStopNewMoveWithSplineAtEndPointT>();
		}

		// Token: 0x06037987 RID: 227719 RVA: 0x0078546B File Offset: 0x0078366B
		public static TStopNewMoveWithSplineTypeUnion FromIStopNewMoveWithSplineAtEndPoint(IStopNewMoveWithSplineAtEndPointT _istopnewmovewithsplineatendpoint)
		{
			return new TStopNewMoveWithSplineTypeUnion
			{
				Type = TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtEndPoint,
				Value = _istopnewmovewithsplineatendpoint
			};
		}

		// Token: 0x06037988 RID: 227720 RVA: 0x00785480 File Offset: 0x00783680
		public IStopNewMoveWithSplineAtStartPointT AsIStopNewMoveWithSplineAtStartPoint()
		{
			return this.As<IStopNewMoveWithSplineAtStartPointT>();
		}

		// Token: 0x06037989 RID: 227721 RVA: 0x00785488 File Offset: 0x00783688
		public static TStopNewMoveWithSplineTypeUnion FromIStopNewMoveWithSplineAtStartPoint(IStopNewMoveWithSplineAtStartPointT _istopnewmovewithsplineatstartpoint)
		{
			return new TStopNewMoveWithSplineTypeUnion
			{
				Type = TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtStartPoint,
				Value = _istopnewmovewithsplineatstartpoint
			};
		}

		// Token: 0x0603798A RID: 227722 RVA: 0x0078549D File Offset: 0x0078369D
		public IStopNewMoveWithSplineAtTargetPointT AsIStopNewMoveWithSplineAtTargetPoint()
		{
			return this.As<IStopNewMoveWithSplineAtTargetPointT>();
		}

		// Token: 0x0603798B RID: 227723 RVA: 0x007854A5 File Offset: 0x007836A5
		public static TStopNewMoveWithSplineTypeUnion FromIStopNewMoveWithSplineAtTargetPoint(IStopNewMoveWithSplineAtTargetPointT _istopnewmovewithsplineattargetpoint)
		{
			return new TStopNewMoveWithSplineTypeUnion
			{
				Type = TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtTargetPoint,
				Value = _istopnewmovewithsplineattargetpoint
			};
		}

		// Token: 0x0603798C RID: 227724 RVA: 0x007854BC File Offset: 0x007836BC
		public static int Pack(FlatBufferBuilder builder, TStopNewMoveWithSplineTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtCurrentPos:
				return IStopNewMoveWithSplineAtCurrentPos.Pack(builder, _o.AsIStopNewMoveWithSplineAtCurrentPos()).Value;
			case TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtEndPoint:
				return IStopNewMoveWithSplineAtEndPoint.Pack(builder, _o.AsIStopNewMoveWithSplineAtEndPoint()).Value;
			case TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtStartPoint:
				return IStopNewMoveWithSplineAtStartPoint.Pack(builder, _o.AsIStopNewMoveWithSplineAtStartPoint()).Value;
			case TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtTargetPoint:
				return IStopNewMoveWithSplineAtTargetPoint.Pack(builder, _o.AsIStopNewMoveWithSplineAtTargetPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
