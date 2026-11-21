using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FE3 RID: 32739
	public class TStopNewMoveWithSplineTypeUnion
	{
		// Token: 0x1700F30F RID: 62223
		// (get) Token: 0x0603AEFF RID: 241407 RVA: 0x007EA9CC File Offset: 0x007E8BCC
		// (set) Token: 0x0603AF00 RID: 241408 RVA: 0x007EA9D4 File Offset: 0x007E8BD4
		public TStopNewMoveWithSplineType Type { get; set; }

		// Token: 0x1700F310 RID: 62224
		// (get) Token: 0x0603AF01 RID: 241409 RVA: 0x007EA9DD File Offset: 0x007E8BDD
		// (set) Token: 0x0603AF02 RID: 241410 RVA: 0x007EA9E5 File Offset: 0x007E8BE5
		public object Value { get; set; }

		// Token: 0x0603AF03 RID: 241411 RVA: 0x007EA9EE File Offset: 0x007E8BEE
		public TStopNewMoveWithSplineTypeUnion()
		{
			this.Type = TStopNewMoveWithSplineType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF04 RID: 241412 RVA: 0x007EAA04 File Offset: 0x007E8C04
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF05 RID: 241413 RVA: 0x007EAA16 File Offset: 0x007E8C16
		public IStopNewMoveWithSplineAtCurrentPosT AsIStopNewMoveWithSplineAtCurrentPos()
		{
			return this.As<IStopNewMoveWithSplineAtCurrentPosT>();
		}

		// Token: 0x0603AF06 RID: 241414 RVA: 0x007EAA1E File Offset: 0x007E8C1E
		public static TStopNewMoveWithSplineTypeUnion FromIStopNewMoveWithSplineAtCurrentPos(IStopNewMoveWithSplineAtCurrentPosT _istopnewmovewithsplineatcurrentpos)
		{
			return new TStopNewMoveWithSplineTypeUnion
			{
				Type = TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtCurrentPos,
				Value = _istopnewmovewithsplineatcurrentpos
			};
		}

		// Token: 0x0603AF07 RID: 241415 RVA: 0x007EAA33 File Offset: 0x007E8C33
		public IStopNewMoveWithSplineAtEndPointT AsIStopNewMoveWithSplineAtEndPoint()
		{
			return this.As<IStopNewMoveWithSplineAtEndPointT>();
		}

		// Token: 0x0603AF08 RID: 241416 RVA: 0x007EAA3B File Offset: 0x007E8C3B
		public static TStopNewMoveWithSplineTypeUnion FromIStopNewMoveWithSplineAtEndPoint(IStopNewMoveWithSplineAtEndPointT _istopnewmovewithsplineatendpoint)
		{
			return new TStopNewMoveWithSplineTypeUnion
			{
				Type = TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtEndPoint,
				Value = _istopnewmovewithsplineatendpoint
			};
		}

		// Token: 0x0603AF09 RID: 241417 RVA: 0x007EAA50 File Offset: 0x007E8C50
		public IStopNewMoveWithSplineAtStartPointT AsIStopNewMoveWithSplineAtStartPoint()
		{
			return this.As<IStopNewMoveWithSplineAtStartPointT>();
		}

		// Token: 0x0603AF0A RID: 241418 RVA: 0x007EAA58 File Offset: 0x007E8C58
		public static TStopNewMoveWithSplineTypeUnion FromIStopNewMoveWithSplineAtStartPoint(IStopNewMoveWithSplineAtStartPointT _istopnewmovewithsplineatstartpoint)
		{
			return new TStopNewMoveWithSplineTypeUnion
			{
				Type = TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtStartPoint,
				Value = _istopnewmovewithsplineatstartpoint
			};
		}

		// Token: 0x0603AF0B RID: 241419 RVA: 0x007EAA6D File Offset: 0x007E8C6D
		public IStopNewMoveWithSplineAtTargetPointT AsIStopNewMoveWithSplineAtTargetPoint()
		{
			return this.As<IStopNewMoveWithSplineAtTargetPointT>();
		}

		// Token: 0x0603AF0C RID: 241420 RVA: 0x007EAA75 File Offset: 0x007E8C75
		public static TStopNewMoveWithSplineTypeUnion FromIStopNewMoveWithSplineAtTargetPoint(IStopNewMoveWithSplineAtTargetPointT _istopnewmovewithsplineattargetpoint)
		{
			return new TStopNewMoveWithSplineTypeUnion
			{
				Type = TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtTargetPoint,
				Value = _istopnewmovewithsplineattargetpoint
			};
		}

		// Token: 0x0603AF0D RID: 241421 RVA: 0x007EAA8C File Offset: 0x007E8C8C
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
