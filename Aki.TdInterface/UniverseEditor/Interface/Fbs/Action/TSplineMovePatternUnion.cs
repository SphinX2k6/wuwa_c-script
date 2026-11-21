using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FD7 RID: 32727
	public class TSplineMovePatternUnion
	{
		// Token: 0x1700F307 RID: 62215
		// (get) Token: 0x0603AEBD RID: 241341 RVA: 0x007EA35A File Offset: 0x007E855A
		// (set) Token: 0x0603AEBE RID: 241342 RVA: 0x007EA362 File Offset: 0x007E8562
		public TSplineMovePattern Type { get; set; }

		// Token: 0x1700F308 RID: 62216
		// (get) Token: 0x0603AEBF RID: 241343 RVA: 0x007EA36B File Offset: 0x007E856B
		// (set) Token: 0x0603AEC0 RID: 241344 RVA: 0x007EA373 File Offset: 0x007E8573
		public object Value { get; set; }

		// Token: 0x0603AEC1 RID: 241345 RVA: 0x007EA37C File Offset: 0x007E857C
		public TSplineMovePatternUnion()
		{
			this.Type = TSplineMovePattern.NONE;
			this.Value = null;
		}

		// Token: 0x0603AEC2 RID: 241346 RVA: 0x007EA392 File Offset: 0x007E8592
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AEC3 RID: 241347 RVA: 0x007EA3A4 File Offset: 0x007E85A4
		public IAirPassageMoveT AsIAirPassageMove()
		{
			return this.As<IAirPassageMoveT>();
		}

		// Token: 0x0603AEC4 RID: 241348 RVA: 0x007EA3AC File Offset: 0x007E85AC
		public static TSplineMovePatternUnion FromIAirPassageMove(IAirPassageMoveT _iairpassagemove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IAirPassageMove,
				Value = _iairpassagemove
			};
		}

		// Token: 0x0603AEC5 RID: 241349 RVA: 0x007EA3C1 File Offset: 0x007E85C1
		public IMechaAirPassageMoveT AsIMechaAirPassageMove()
		{
			return this.As<IMechaAirPassageMoveT>();
		}

		// Token: 0x0603AEC6 RID: 241350 RVA: 0x007EA3C9 File Offset: 0x007E85C9
		public static TSplineMovePatternUnion FromIMechaAirPassageMove(IMechaAirPassageMoveT _imechaairpassagemove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IMechaAirPassageMove,
				Value = _imechaairpassagemove
			};
		}

		// Token: 0x0603AEC7 RID: 241351 RVA: 0x007EA3DE File Offset: 0x007E85DE
		public IMotorcycleTrackT AsIMotorcycleTrack()
		{
			return this.As<IMotorcycleTrackT>();
		}

		// Token: 0x0603AEC8 RID: 241352 RVA: 0x007EA3E6 File Offset: 0x007E85E6
		public static TSplineMovePatternUnion FromIMotorcycleTrack(IMotorcycleTrackT _imotorcycletrack)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IMotorcycleTrack,
				Value = _imotorcycletrack
			};
		}

		// Token: 0x0603AEC9 RID: 241353 RVA: 0x007EA3FB File Offset: 0x007E85FB
		public IPathLineMoveT AsIPathLineMove()
		{
			return this.As<IPathLineMoveT>();
		}

		// Token: 0x0603AECA RID: 241354 RVA: 0x007EA403 File Offset: 0x007E8603
		public static TSplineMovePatternUnion FromIPathLineMove(IPathLineMoveT _ipathlinemove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IPathLineMove,
				Value = _ipathlinemove
			};
		}

		// Token: 0x0603AECB RID: 241355 RVA: 0x007EA418 File Offset: 0x007E8618
		public IPetalGrabMoveT AsIPetalGrabMove()
		{
			return this.As<IPetalGrabMoveT>();
		}

		// Token: 0x0603AECC RID: 241356 RVA: 0x007EA420 File Offset: 0x007E8620
		public static TSplineMovePatternUnion FromIPetalGrabMove(IPetalGrabMoveT _ipetalgrabmove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IPetalGrabMove,
				Value = _ipetalgrabmove
			};
		}

		// Token: 0x0603AECD RID: 241357 RVA: 0x007EA435 File Offset: 0x007E8635
		public IRacingTrackMoveT AsIRacingTrackMove()
		{
			return this.As<IRacingTrackMoveT>();
		}

		// Token: 0x0603AECE RID: 241358 RVA: 0x007EA43D File Offset: 0x007E863D
		public static TSplineMovePatternUnion FromIRacingTrackMove(IRacingTrackMoveT _iracingtrackmove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.IRacingTrackMove,
				Value = _iracingtrackmove
			};
		}

		// Token: 0x0603AECF RID: 241359 RVA: 0x007EA452 File Offset: 0x007E8652
		public ISlideTrackMoveT AsISlideTrackMove()
		{
			return this.As<ISlideTrackMoveT>();
		}

		// Token: 0x0603AED0 RID: 241360 RVA: 0x007EA45A File Offset: 0x007E865A
		public static TSplineMovePatternUnion FromISlideTrackMove(ISlideTrackMoveT _islidetrackmove)
		{
			return new TSplineMovePatternUnion
			{
				Type = TSplineMovePattern.ISlideTrackMove,
				Value = _islidetrackmove
			};
		}

		// Token: 0x0603AED1 RID: 241361 RVA: 0x007EA470 File Offset: 0x007E8670
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
			case TSplineMovePattern.IPetalGrabMove:
				return IPetalGrabMove.Pack(builder, _o.AsIPetalGrabMove()).Value;
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
