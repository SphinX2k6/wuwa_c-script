using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200643D RID: 25661
	public class ICloseSplineMovePattern_UnionUnion
	{
		// Token: 0x1700BF13 RID: 48915
		// (get) Token: 0x0602C696 RID: 181910 RVA: 0x00617E1C File Offset: 0x0061601C
		// (set) Token: 0x0602C697 RID: 181911 RVA: 0x00617E24 File Offset: 0x00616024
		public ICloseSplineMovePattern_Union Type { get; set; }

		// Token: 0x1700BF14 RID: 48916
		// (get) Token: 0x0602C698 RID: 181912 RVA: 0x00617E2D File Offset: 0x0061602D
		// (set) Token: 0x0602C699 RID: 181913 RVA: 0x00617E35 File Offset: 0x00616035
		public object Value { get; set; }

		// Token: 0x0602C69A RID: 181914 RVA: 0x00617E3E File Offset: 0x0061603E
		public ICloseSplineMovePattern_UnionUnion()
		{
			this.Type = ICloseSplineMovePattern_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C69B RID: 181915 RVA: 0x00617E54 File Offset: 0x00616054
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C69C RID: 181916 RVA: 0x00617E66 File Offset: 0x00616066
		public ICloseSplineMovePatternT AsICloseSplineMovePattern()
		{
			return this.As<ICloseSplineMovePatternT>();
		}

		// Token: 0x0602C69D RID: 181917 RVA: 0x00617E6E File Offset: 0x0061606E
		public static ICloseSplineMovePattern_UnionUnion FromICloseSplineMovePattern(ICloseSplineMovePatternT _iclosesplinemovepattern)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseSplineMovePattern,
				Value = _iclosesplinemovepattern
			};
		}

		// Token: 0x0602C69E RID: 181918 RVA: 0x00617E83 File Offset: 0x00616083
		public ICloseAirPassageMoveT AsICloseAirPassageMove()
		{
			return this.As<ICloseAirPassageMoveT>();
		}

		// Token: 0x0602C69F RID: 181919 RVA: 0x00617E8B File Offset: 0x0061608B
		public static ICloseSplineMovePattern_UnionUnion FromICloseAirPassageMove(ICloseAirPassageMoveT _icloseairpassagemove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseAirPassageMove,
				Value = _icloseairpassagemove
			};
		}

		// Token: 0x0602C6A0 RID: 181920 RVA: 0x00617EA0 File Offset: 0x006160A0
		public ICloseMotorcycleTrackMoveT AsICloseMotorcycleTrackMove()
		{
			return this.As<ICloseMotorcycleTrackMoveT>();
		}

		// Token: 0x0602C6A1 RID: 181921 RVA: 0x00617EA8 File Offset: 0x006160A8
		public static ICloseSplineMovePattern_UnionUnion FromICloseMotorcycleTrackMove(ICloseMotorcycleTrackMoveT _iclosemotorcycletrackmove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseMotorcycleTrackMove,
				Value = _iclosemotorcycletrackmove
			};
		}

		// Token: 0x0602C6A2 RID: 181922 RVA: 0x00617EBD File Offset: 0x006160BD
		public IClosePathLineMoveT AsIClosePathLineMove()
		{
			return this.As<IClosePathLineMoveT>();
		}

		// Token: 0x0602C6A3 RID: 181923 RVA: 0x00617EC5 File Offset: 0x006160C5
		public static ICloseSplineMovePattern_UnionUnion FromIClosePathLineMove(IClosePathLineMoveT _iclosepathlinemove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.IClosePathLineMove,
				Value = _iclosepathlinemove
			};
		}

		// Token: 0x0602C6A4 RID: 181924 RVA: 0x00617EDA File Offset: 0x006160DA
		public ICloseRacingTrackMoveT AsICloseRacingTrackMove()
		{
			return this.As<ICloseRacingTrackMoveT>();
		}

		// Token: 0x0602C6A5 RID: 181925 RVA: 0x00617EE2 File Offset: 0x006160E2
		public static ICloseSplineMovePattern_UnionUnion FromICloseRacingTrackMove(ICloseRacingTrackMoveT _icloseracingtrackmove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseRacingTrackMove,
				Value = _icloseracingtrackmove
			};
		}

		// Token: 0x0602C6A6 RID: 181926 RVA: 0x00617EF7 File Offset: 0x006160F7
		public ICloseSlideTrackMoveT AsICloseSlideTrackMove()
		{
			return this.As<ICloseSlideTrackMoveT>();
		}

		// Token: 0x0602C6A7 RID: 181927 RVA: 0x00617EFF File Offset: 0x006160FF
		public static ICloseSplineMovePattern_UnionUnion FromICloseSlideTrackMove(ICloseSlideTrackMoveT _icloseslidetrackmove)
		{
			return new ICloseSplineMovePattern_UnionUnion
			{
				Type = ICloseSplineMovePattern_Union.ICloseSlideTrackMove,
				Value = _icloseslidetrackmove
			};
		}

		// Token: 0x0602C6A8 RID: 181928 RVA: 0x00617F14 File Offset: 0x00616114
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
