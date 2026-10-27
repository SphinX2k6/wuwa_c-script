using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779F RID: 30623
	public class TSplineMovePatternUnion
	{
		// Token: 0x1700E6AD RID: 59053
		// (get) Token: 0x06037942 RID: 227650 RVA: 0x00784E5A File Offset: 0x0078305A
		// (set) Token: 0x06037943 RID: 227651 RVA: 0x00784E62 File Offset: 0x00783062
		public TSplineMovePattern Type { get; set; }

		// Token: 0x1700E6AE RID: 59054
		// (get) Token: 0x06037944 RID: 227652 RVA: 0x00784E6B File Offset: 0x0078306B
		// (set) Token: 0x06037945 RID: 227653 RVA: 0x00784E73 File Offset: 0x00783073
		public object Value { get; set; }

		// Token: 0x06037946 RID: 227654 RVA: 0x00784E7C File Offset: 0x0078307C
		public TSplineMovePatternUnion()
		{
			this.Type = TSplineMovePattern.NONE;
			this.Value = null;
		}

		// Token: 0x06037947 RID: 227655 RVA: 0x00784E92 File Offset: 0x00783092
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037948 RID: 227656 RVA: 0x00784EA4 File Offset: 0x007830A4
		public IAirPassageMoveT AsIAirPassageMove()
		{
			return this.As<IAirPassageMoveT>();
		}

		// Token: 0x06037949 RID: 227657 RVA: 0x00784EAC File Offset: 0x007830AC
		public static TSplineMovePatternUnion FromIAirPassageMove(IAirPassageMoveT _iairpassagemove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IAirPassageMove,
				Value = _iairpassagemove
			};
		}

		// Token: 0x0603794A RID: 227658 RVA: 0x00784EC1 File Offset: 0x007830C1
		public IMechaAirPassageMoveT AsIMechaAirPassageMove()
		{
			return this.As<IMechaAirPassageMoveT>();
		}

		// Token: 0x0603794B RID: 227659 RVA: 0x00784EC9 File Offset: 0x007830C9
		public static TSplineMovePatternUnion FromIMechaAirPassageMove(IMechaAirPassageMoveT _imechaairpassagemove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IMechaAirPassageMove,
				Value = _imechaairpassagemove
			};
		}

		// Token: 0x0603794C RID: 227660 RVA: 0x00784EDE File Offset: 0x007830DE
		public IMotorcycleTrackT AsIMotorcycleTrack()
		{
			return this.As<IMotorcycleTrackT>();
		}

		// Token: 0x0603794D RID: 227661 RVA: 0x00784EE6 File Offset: 0x007830E6
		public static TSplineMovePatternUnion FromIMotorcycleTrack(IMotorcycleTrackT _imotorcycletrack)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IMotorcycleTrack,
				Value = _imotorcycletrack
			};
		}

		// Token: 0x0603794E RID: 227662 RVA: 0x00784EFB File Offset: 0x007830FB
		public IPathLineMoveT AsIPathLineMove()
		{
			return this.As<IPathLineMoveT>();
		}

		// Token: 0x0603794F RID: 227663 RVA: 0x00784F03 File Offset: 0x00783103
		public static TSplineMovePatternUnion FromIPathLineMove(IPathLineMoveT _ipathlinemove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IPathLineMove,
				Value = _ipathlinemove
			};
		}

		// Token: 0x06037950 RID: 227664 RVA: 0x00784F18 File Offset: 0x00783118
		public IRacingTrackMoveT AsIRacingTrackMove()
		{
			return this.As<IRacingTrackMoveT>();
		}

		// Token: 0x06037951 RID: 227665 RVA: 0x00784F20 File Offset: 0x00783120
		public static TSplineMovePatternUnion FromIRacingTrackMove(IRacingTrackMoveT _iracingtrackmove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IRacingTrackMove,
				Value = _iracingtrackmove
			};
		}

		// Token: 0x06037952 RID: 227666 RVA: 0x00784F35 File Offset: 0x00783135
		public ISlideTrackMoveT AsISlideTrackMove()
		{
			return this.As<ISlideTrackMoveT>();
		}

		// Token: 0x06037953 RID: 227667 RVA: 0x00784F3D File Offset: 0x0078313D
		public static TSplineMovePatternUnion FromISlideTrackMove(ISlideTrackMoveT _islidetrackmove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.ISlideTrackMove,
				Value = _islidetrackmove
			};
		}

		// Token: 0x06037954 RID: 227668 RVA: 0x00784F54 File Offset: 0x00783154
		public static int Pack(FlatBufferBuilder builder, TSplineMovePatternUnion _o)
		{
			switch (_o.Type)
			{
			case TSplineMovePattern.IAirPassageMove:
				return IAirPassageMove.Pack(builder, _o.AsIAirPassageMove()).Value;
			case TSplineMovePattern.IMechaAirPassageMove:
				return IMechaAirPassageMove.Pack(builder, _o.AsIMechaAirPassageMove()).Value;
			case TSplineMovePattern.IMotorcycleTrack:
				return IMotorcycleTrack.Pack(builder, _o.AsIMotorcycleTrack()).Value;
			case TSplineMovePattern.IPathLineMove:
				return IPathLineMove.Pack(builder, _o.AsIPathLineMove()).Value;
			case TSplineMovePattern.IRacingTrackMove:
				return IRacingTrackMove.Pack(builder, _o.AsIRacingTrackMove()).Value;
			case TSplineMovePattern.ISlideTrackMove:
				return ISlideTrackMove.Pack(builder, _o.AsISlideTrackMove()).Value;
			default:
				return 0;
			}
		}
	}
}
