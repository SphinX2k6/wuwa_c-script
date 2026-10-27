using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718E RID: 29070
	public class ISplineMovePattern_UnionUnion
	{
		// Token: 0x1700D7F0 RID: 55280
		// (get) Token: 0x060338A2 RID: 211106 RVA: 0x006F1307 File Offset: 0x006EF507
		// (set) Token: 0x060338A3 RID: 211107 RVA: 0x006F130F File Offset: 0x006EF50F
		public ISplineMovePattern_Union Type { get; set; }

		// Token: 0x1700D7F1 RID: 55281
		// (get) Token: 0x060338A4 RID: 211108 RVA: 0x006F1318 File Offset: 0x006EF518
		// (set) Token: 0x060338A5 RID: 211109 RVA: 0x006F1320 File Offset: 0x006EF520
		public object Value { get; set; }

		// Token: 0x060338A6 RID: 211110 RVA: 0x006F1329 File Offset: 0x006EF529
		public ISplineMovePattern_UnionUnion()
		{
			this.Type = ISplineMovePattern_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060338A7 RID: 211111 RVA: 0x006F133F File Offset: 0x006EF53F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060338A8 RID: 211112 RVA: 0x006F1351 File Offset: 0x006EF551
		public ISplineMovePatternT AsISplineMovePattern()
		{
			return this.As<ISplineMovePatternT>();
		}

		// Token: 0x060338A9 RID: 211113 RVA: 0x006F1359 File Offset: 0x006EF559
		public static ISplineMovePattern_UnionUnion FromISplineMovePattern(ISplineMovePatternT _isplinemovepattern)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.ISplineMovePattern,
				Value = _isplinemovepattern
			};
		}

		// Token: 0x060338AA RID: 211114 RVA: 0x006F136E File Offset: 0x006EF56E
		public IPathLineMoveT AsIPathLineMove()
		{
			return this.As<IPathLineMoveT>();
		}

		// Token: 0x060338AB RID: 211115 RVA: 0x006F1376 File Offset: 0x006EF576
		public static ISplineMovePattern_UnionUnion FromIPathLineMove(IPathLineMoveT _ipathlinemove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IPathLineMove,
				Value = _ipathlinemove
			};
		}

		// Token: 0x060338AC RID: 211116 RVA: 0x006F138B File Offset: 0x006EF58B
		public IRacingTrackMoveT AsIRacingTrackMove()
		{
			return this.As<IRacingTrackMoveT>();
		}

		// Token: 0x060338AD RID: 211117 RVA: 0x006F1393 File Offset: 0x006EF593
		public static ISplineMovePattern_UnionUnion FromIRacingTrackMove(IRacingTrackMoveT _iracingtrackmove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IRacingTrackMove,
				Value = _iracingtrackmove
			};
		}

		// Token: 0x060338AE RID: 211118 RVA: 0x006F13A8 File Offset: 0x006EF5A8
		public ISlideTrackMoveT AsISlideTrackMove()
		{
			return this.As<ISlideTrackMoveT>();
		}

		// Token: 0x060338AF RID: 211119 RVA: 0x006F13B0 File Offset: 0x006EF5B0
		public static ISplineMovePattern_UnionUnion FromISlideTrackMove(ISlideTrackMoveT _islidetrackmove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.ISlideTrackMove,
				Value = _islidetrackmove
			};
		}

		// Token: 0x060338B0 RID: 211120 RVA: 0x006F13C5 File Offset: 0x006EF5C5
		public IAirPassageMoveT AsIAirPassageMove()
		{
			return this.As<IAirPassageMoveT>();
		}

		// Token: 0x060338B1 RID: 211121 RVA: 0x006F13CD File Offset: 0x006EF5CD
		public static ISplineMovePattern_UnionUnion FromIAirPassageMove(IAirPassageMoveT _iairpassagemove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IAirPassageMove,
				Value = _iairpassagemove
			};
		}

		// Token: 0x060338B2 RID: 211122 RVA: 0x006F13E2 File Offset: 0x006EF5E2
		public IMechaAirPassageMoveT AsIMechaAirPassageMove()
		{
			return this.As<IMechaAirPassageMoveT>();
		}

		// Token: 0x060338B3 RID: 211123 RVA: 0x006F13EA File Offset: 0x006EF5EA
		public static ISplineMovePattern_UnionUnion FromIMechaAirPassageMove(IMechaAirPassageMoveT _imechaairpassagemove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IMechaAirPassageMove,
				Value = _imechaairpassagemove
			};
		}

		// Token: 0x060338B4 RID: 211124 RVA: 0x006F13FF File Offset: 0x006EF5FF
		public IMotorcycleTrackT AsIMotorcycleTrack()
		{
			return this.As<IMotorcycleTrackT>();
		}

		// Token: 0x060338B5 RID: 211125 RVA: 0x006F1407 File Offset: 0x006EF607
		public static ISplineMovePattern_UnionUnion FromIMotorcycleTrack(IMotorcycleTrackT _imotorcycletrack)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IMotorcycleTrack,
				Value = _imotorcycletrack
			};
		}

		// Token: 0x060338B6 RID: 211126 RVA: 0x006F141C File Offset: 0x006EF61C
		public static int Pack(FlatBufferBuilder builder, ISplineMovePattern_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISplineMovePattern_Union.ISplineMovePattern:
				return ISplineMovePattern.Pack(builder, _o.AsISplineMovePattern()).Value;
			case ISplineMovePattern_Union.IPathLineMove:
				return IPathLineMove.Pack(builder, _o.AsIPathLineMove()).Value;
			case ISplineMovePattern_Union.IRacingTrackMove:
				return IRacingTrackMove.Pack(builder, _o.AsIRacingTrackMove()).Value;
			case ISplineMovePattern_Union.ISlideTrackMove:
				return ISlideTrackMove.Pack(builder, _o.AsISlideTrackMove()).Value;
			case ISplineMovePattern_Union.IAirPassageMove:
				return IAirPassageMove.Pack(builder, _o.AsIAirPassageMove()).Value;
			case ISplineMovePattern_Union.IMechaAirPassageMove:
				return IMechaAirPassageMove.Pack(builder, _o.AsIMechaAirPassageMove()).Value;
			case ISplineMovePattern_Union.IMotorcycleTrack:
				return IMotorcycleTrack.Pack(builder, _o.AsIMotorcycleTrack()).Value;
			default:
				return 0;
			}
		}
	}
}
