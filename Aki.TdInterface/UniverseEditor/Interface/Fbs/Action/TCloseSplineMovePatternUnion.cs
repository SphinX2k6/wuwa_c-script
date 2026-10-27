using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007687 RID: 30343
	public class TCloseSplineMovePatternUnion
	{
		// Token: 0x1700E5ED RID: 58861
		// (get) Token: 0x0603734C RID: 226124 RVA: 0x0077B7E2 File Offset: 0x007799E2
		// (set) Token: 0x0603734D RID: 226125 RVA: 0x0077B7EA File Offset: 0x007799EA
		public TCloseSplineMovePattern Type { get; set; }

		// Token: 0x1700E5EE RID: 58862
		// (get) Token: 0x0603734E RID: 226126 RVA: 0x0077B7F3 File Offset: 0x007799F3
		// (set) Token: 0x0603734F RID: 226127 RVA: 0x0077B7FB File Offset: 0x007799FB
		public object Value { get; set; }

		// Token: 0x06037350 RID: 226128 RVA: 0x0077B804 File Offset: 0x00779A04
		public TCloseSplineMovePatternUnion()
		{
			this.Type = TCloseSplineMovePattern.NONE;
			this.Value = null;
		}

		// Token: 0x06037351 RID: 226129 RVA: 0x0077B81A File Offset: 0x00779A1A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037352 RID: 226130 RVA: 0x0077B82C File Offset: 0x00779A2C
		public ICloseAirPassageMoveT AsICloseAirPassageMove()
		{
			return this.As<ICloseAirPassageMoveT>();
		}

		// Token: 0x06037353 RID: 226131 RVA: 0x0077B834 File Offset: 0x00779A34
		public static TCloseSplineMovePatternUnion FromICloseAirPassageMove(ICloseAirPassageMoveT _icloseairpassagemove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.ICloseAirPassageMove,
				Value = _icloseairpassagemove
			};
		}

		// Token: 0x06037354 RID: 226132 RVA: 0x0077B849 File Offset: 0x00779A49
		public ICloseMotorcycleTrackMoveT AsICloseMotorcycleTrackMove()
		{
			return this.As<ICloseMotorcycleTrackMoveT>();
		}

		// Token: 0x06037355 RID: 226133 RVA: 0x0077B851 File Offset: 0x00779A51
		public static TCloseSplineMovePatternUnion FromICloseMotorcycleTrackMove(ICloseMotorcycleTrackMoveT _iclosemotorcycletrackmove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.ICloseMotorcycleTrackMove,
				Value = _iclosemotorcycletrackmove
			};
		}

		// Token: 0x06037356 RID: 226134 RVA: 0x0077B866 File Offset: 0x00779A66
		public IClosePathLineMoveT AsIClosePathLineMove()
		{
			return this.As<IClosePathLineMoveT>();
		}

		// Token: 0x06037357 RID: 226135 RVA: 0x0077B86E File Offset: 0x00779A6E
		public static TCloseSplineMovePatternUnion FromIClosePathLineMove(IClosePathLineMoveT _iclosepathlinemove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.IClosePathLineMove,
				Value = _iclosepathlinemove
			};
		}

		// Token: 0x06037358 RID: 226136 RVA: 0x0077B883 File Offset: 0x00779A83
		public ICloseRacingTrackMoveT AsICloseRacingTrackMove()
		{
			return this.As<ICloseRacingTrackMoveT>();
		}

		// Token: 0x06037359 RID: 226137 RVA: 0x0077B88B File Offset: 0x00779A8B
		public static TCloseSplineMovePatternUnion FromICloseRacingTrackMove(ICloseRacingTrackMoveT _icloseracingtrackmove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.ICloseRacingTrackMove,
				Value = _icloseracingtrackmove
			};
		}

		// Token: 0x0603735A RID: 226138 RVA: 0x0077B8A0 File Offset: 0x00779AA0
		public ICloseSlideTrackMoveT AsICloseSlideTrackMove()
		{
			return this.As<ICloseSlideTrackMoveT>();
		}

		// Token: 0x0603735B RID: 226139 RVA: 0x0077B8A8 File Offset: 0x00779AA8
		public static TCloseSplineMovePatternUnion FromICloseSlideTrackMove(ICloseSlideTrackMoveT _icloseslidetrackmove)
		{
			return new TCloseSplineMovePatternUnion
			{
				Type = TCloseSplineMovePattern.ICloseSlideTrackMove,
				Value = _icloseslidetrackmove
			};
		}

		// Token: 0x0603735C RID: 226140 RVA: 0x0077B8C0 File Offset: 0x00779AC0
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
