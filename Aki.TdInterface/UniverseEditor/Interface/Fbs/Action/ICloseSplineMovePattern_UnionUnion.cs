using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB1 RID: 27313
	public class ICloseSplineMovePattern_UnionUnion
	{
		// Token: 0x1700C89F RID: 51359
		// (get) Token: 0x0602EE1B RID: 192027 RVA: 0x00663460 File Offset: 0x00661660
		// (set) Token: 0x0602EE1C RID: 192028 RVA: 0x00663468 File Offset: 0x00661668
		public ICloseSplineMovePattern_Union Type { get; set; }

		// Token: 0x1700C8A0 RID: 51360
		// (get) Token: 0x0602EE1D RID: 192029 RVA: 0x00663471 File Offset: 0x00661671
		// (set) Token: 0x0602EE1E RID: 192030 RVA: 0x00663479 File Offset: 0x00661679
		public object Value { get; set; }

		// Token: 0x0602EE1F RID: 192031 RVA: 0x00663482 File Offset: 0x00661682
		public ICloseSplineMovePattern_UnionUnion()
		{
			this.Type = ICloseSplineMovePattern_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EE20 RID: 192032 RVA: 0x00663498 File Offset: 0x00661698
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EE21 RID: 192033 RVA: 0x006634AA File Offset: 0x006616AA
		public ICloseSplineMovePatternT AsICloseSplineMovePattern()
		{
			return this.As<ICloseSplineMovePatternT>();
		}

		// Token: 0x0602EE22 RID: 192034 RVA: 0x006634B2 File Offset: 0x006616B2
		public static ICloseSplineMovePattern_UnionUnion FromICloseSplineMovePattern(ICloseSplineMovePatternT _iclosesplinemovepattern)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseSplineMovePattern,
				Value = _iclosesplinemovepattern
			};
		}

		// Token: 0x0602EE23 RID: 192035 RVA: 0x006634C7 File Offset: 0x006616C7
		public ICloseAirPassageMoveT AsICloseAirPassageMove()
		{
			return this.As<ICloseAirPassageMoveT>();
		}

		// Token: 0x0602EE24 RID: 192036 RVA: 0x006634CF File Offset: 0x006616CF
		public static ICloseSplineMovePattern_UnionUnion FromICloseAirPassageMove(ICloseAirPassageMoveT _icloseairpassagemove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseAirPassageMove,
				Value = _icloseairpassagemove
			};
		}

		// Token: 0x0602EE25 RID: 192037 RVA: 0x006634E4 File Offset: 0x006616E4
		public ICloseMotorcycleTrackMoveT AsICloseMotorcycleTrackMove()
		{
			return this.As<ICloseMotorcycleTrackMoveT>();
		}

		// Token: 0x0602EE26 RID: 192038 RVA: 0x006634EC File Offset: 0x006616EC
		public static ICloseSplineMovePattern_UnionUnion FromICloseMotorcycleTrackMove(ICloseMotorcycleTrackMoveT _iclosemotorcycletrackmove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseMotorcycleTrackMove,
				Value = _iclosemotorcycletrackmove
			};
		}

		// Token: 0x0602EE27 RID: 192039 RVA: 0x00663501 File Offset: 0x00661701
		public IClosePathLineMoveT AsIClosePathLineMove()
		{
			return this.As<IClosePathLineMoveT>();
		}

		// Token: 0x0602EE28 RID: 192040 RVA: 0x00663509 File Offset: 0x00661709
		public static ICloseSplineMovePattern_UnionUnion FromIClosePathLineMove(IClosePathLineMoveT _iclosepathlinemove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.IClosePathLineMove,
				Value = _iclosepathlinemove
			};
		}

		// Token: 0x0602EE29 RID: 192041 RVA: 0x0066351E File Offset: 0x0066171E
		public ICloseRacingTrackMoveT AsICloseRacingTrackMove()
		{
			return this.As<ICloseRacingTrackMoveT>();
		}

		// Token: 0x0602EE2A RID: 192042 RVA: 0x00663526 File Offset: 0x00661726
		public static ICloseSplineMovePattern_UnionUnion FromICloseRacingTrackMove(ICloseRacingTrackMoveT _icloseracingtrackmove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseRacingTrackMove,
				Value = _icloseracingtrackmove
			};
		}

		// Token: 0x0602EE2B RID: 192043 RVA: 0x0066353B File Offset: 0x0066173B
		public ICloseSlideTrackMoveT AsICloseSlideTrackMove()
		{
			return this.As<ICloseSlideTrackMoveT>();
		}

		// Token: 0x0602EE2C RID: 192044 RVA: 0x00663543 File Offset: 0x00661743
		public static ICloseSplineMovePattern_UnionUnion FromICloseSlideTrackMove(ICloseSlideTrackMoveT _icloseslidetrackmove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseSlideTrackMove,
				Value = _icloseslidetrackmove
			};
		}

		// Token: 0x0602EE2D RID: 192045 RVA: 0x00663558 File Offset: 0x00661758
		public static int Pack(FlatBufferBuilder builder, ICloseSplineMovePattern_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICloseSplineMovePattern_Union.ICloseSplineMovePattern:
				return ICloseSplineMovePattern.Pack(builder, _o.AsICloseSplineMovePattern()).Value;
			case ICloseSplineMovePattern_Union.ICloseAirPassageMove:
				return ICloseAirPassageMove.Pack(builder, _o.AsICloseAirPassageMove()).Value;
			case ICloseSplineMovePattern_Union.ICloseMotorcycleTrackMove:
				return ICloseMotorcycleTrackMove.Pack(builder, _o.AsICloseMotorcycleTrackMove()).Value;
			case ICloseSplineMovePattern_Union.IClosePathLineMove:
				return IClosePathLineMove.Pack(builder, _o.AsIClosePathLineMove()).Value;
			case ICloseSplineMovePattern_Union.ICloseRacingTrackMove:
				return ICloseRacingTrackMove.Pack(builder, _o.AsICloseRacingTrackMove()).Value;
			case ICloseSplineMovePattern_Union.ICloseSlideTrackMove:
				return ICloseSlideTrackMove.Pack(builder, _o.AsICloseSlideTrackMove()).Value;
			default:
				return 0;
			}
		}
	}
}
