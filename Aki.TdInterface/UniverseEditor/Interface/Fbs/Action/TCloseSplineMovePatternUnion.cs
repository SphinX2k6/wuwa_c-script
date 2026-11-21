using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E95 RID: 32405
	public class TCloseSplineMovePatternUnion
	{
		// Token: 0x1700F22B RID: 61995
		// (get) Token: 0x0603A7F3 RID: 239603 RVA: 0x007DF92A File Offset: 0x007DDB2A
		// (set) Token: 0x0603A7F4 RID: 239604 RVA: 0x007DF932 File Offset: 0x007DDB32
		public TCloseSplineMovePattern Type { get; set; }

		// Token: 0x1700F22C RID: 61996
		// (get) Token: 0x0603A7F5 RID: 239605 RVA: 0x007DF93B File Offset: 0x007DDB3B
		// (set) Token: 0x0603A7F6 RID: 239606 RVA: 0x007DF943 File Offset: 0x007DDB43
		public object Value { get; set; }

		// Token: 0x0603A7F7 RID: 239607 RVA: 0x007DF94C File Offset: 0x007DDB4C
		public TCloseSplineMovePatternUnion()
		{
			this.Type = TCloseSplineMovePattern.NONE;
			this.Value = null;
		}

		// Token: 0x0603A7F8 RID: 239608 RVA: 0x007DF962 File Offset: 0x007DDB62
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A7F9 RID: 239609 RVA: 0x007DF974 File Offset: 0x007DDB74
		public ICloseAirPassageMoveT AsICloseAirPassageMove()
		{
			return this.As<ICloseAirPassageMoveT>();
		}

		// Token: 0x0603A7FA RID: 239610 RVA: 0x007DF97C File Offset: 0x007DDB7C
		public static TCloseSplineMovePatternUnion FromICloseAirPassageMove(ICloseAirPassageMoveT _icloseairpassagemove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.ICloseAirPassageMove,
				Value = _icloseairpassagemove
			};
		}

		// Token: 0x0603A7FB RID: 239611 RVA: 0x007DF991 File Offset: 0x007DDB91
		public ICloseMotorcycleTrackMoveT AsICloseMotorcycleTrackMove()
		{
			return this.As<ICloseMotorcycleTrackMoveT>();
		}

		// Token: 0x0603A7FC RID: 239612 RVA: 0x007DF999 File Offset: 0x007DDB99
		public static TCloseSplineMovePatternUnion FromICloseMotorcycleTrackMove(ICloseMotorcycleTrackMoveT _iclosemotorcycletrackmove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.ICloseMotorcycleTrackMove,
				Value = _iclosemotorcycletrackmove
			};
		}

		// Token: 0x0603A7FD RID: 239613 RVA: 0x007DF9AE File Offset: 0x007DDBAE
		public IClosePathLineMoveT AsIClosePathLineMove()
		{
			return this.As<IClosePathLineMoveT>();
		}

		// Token: 0x0603A7FE RID: 239614 RVA: 0x007DF9B6 File Offset: 0x007DDBB6
		public static TCloseSplineMovePatternUnion FromIClosePathLineMove(IClosePathLineMoveT _iclosepathlinemove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.IClosePathLineMove,
				Value = _iclosepathlinemove
			};
		}

		// Token: 0x0603A7FF RID: 239615 RVA: 0x007DF9CB File Offset: 0x007DDBCB
		public ICloseRacingTrackMoveT AsICloseRacingTrackMove()
		{
			return this.As<ICloseRacingTrackMoveT>();
		}

		// Token: 0x0603A800 RID: 239616 RVA: 0x007DF9D3 File Offset: 0x007DDBD3
		public static TCloseSplineMovePatternUnion FromICloseRacingTrackMove(ICloseRacingTrackMoveT _icloseracingtrackmove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.ICloseRacingTrackMove,
				Value = _icloseracingtrackmove
			};
		}

		// Token: 0x0603A801 RID: 239617 RVA: 0x007DF9E8 File Offset: 0x007DDBE8
		public ICloseSlideTrackMoveT AsICloseSlideTrackMove()
		{
			return this.As<ICloseSlideTrackMoveT>();
		}

		// Token: 0x0603A802 RID: 239618 RVA: 0x007DF9F0 File Offset: 0x007DDBF0
		public static TCloseSplineMovePatternUnion FromICloseSlideTrackMove(ICloseSlideTrackMoveT _icloseslidetrackmove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.ICloseSlideTrackMove,
				Value = _icloseslidetrackmove
			};
		}

		// Token: 0x0603A803 RID: 239619 RVA: 0x007DFA08 File Offset: 0x007DDC08
		public static int Pack(FlatBufferBuilder builder, TCloseSplineMovePatternUnion _o)
		{
			switch (_o.Type)
			{
			case TCloseSplineMovePattern.ICloseAirPassageMove:
				return ICloseAirPassageMove.Pack(builder, _o.AsICloseAirPassageMove()).Value;
			case TCloseSplineMovePattern.ICloseMotorcycleTrackMove:
				return ICloseMotorcycleTrackMove.Pack(builder, _o.AsICloseMotorcycleTrackMove()).Value;
			case TCloseSplineMovePattern.IClosePathLineMove:
				return IClosePathLineMove.Pack(builder, _o.AsIClosePathLineMove()).Value;
			case TCloseSplineMovePattern.ICloseRacingTrackMove:
				return ICloseRacingTrackMove.Pack(builder, _o.AsICloseRacingTrackMove()).Value;
			case TCloseSplineMovePattern.ICloseSlideTrackMove:
				return ICloseSlideTrackMove.Pack(builder, _o.AsICloseSlideTrackMove()).Value;
			default:
				return 0;
			}
		}
	}
}
