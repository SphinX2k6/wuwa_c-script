using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007963 RID: 31075
	public class ISplineMovePattern_UnionUnion
	{
		// Token: 0x1700E3E7 RID: 58343
		// (get) Token: 0x06036B9A RID: 224154 RVA: 0x0075250B File Offset: 0x0075070B
		// (set) Token: 0x06036B9B RID: 224155 RVA: 0x00752513 File Offset: 0x00750713
		public ISplineMovePattern_Union Type { get; set; }

		// Token: 0x1700E3E8 RID: 58344
		// (get) Token: 0x06036B9C RID: 224156 RVA: 0x0075251C File Offset: 0x0075071C
		// (set) Token: 0x06036B9D RID: 224157 RVA: 0x00752524 File Offset: 0x00750724
		public object Value { get; set; }

		// Token: 0x06036B9E RID: 224158 RVA: 0x0075252D File Offset: 0x0075072D
		public ISplineMovePattern_UnionUnion()
		{
			this.Type = ISplineMovePattern_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036B9F RID: 224159 RVA: 0x00752543 File Offset: 0x00750743
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036BA0 RID: 224160 RVA: 0x00752555 File Offset: 0x00750755
		public ISplineMovePatternT AsISplineMovePattern()
		{
			return this.As<ISplineMovePatternT>();
		}

		// Token: 0x06036BA1 RID: 224161 RVA: 0x0075255D File Offset: 0x0075075D
		public static ISplineMovePattern_UnionUnion FromISplineMovePattern(ISplineMovePatternT _isplinemovepattern)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.ISplineMovePattern,
				Value = _isplinemovepattern
			};
		}

		// Token: 0x06036BA2 RID: 224162 RVA: 0x00752572 File Offset: 0x00750772
		public IPathLineMoveT AsIPathLineMove()
		{
			return this.As<IPathLineMoveT>();
		}

		// Token: 0x06036BA3 RID: 224163 RVA: 0x0075257A File Offset: 0x0075077A
		public static ISplineMovePattern_UnionUnion FromIPathLineMove(IPathLineMoveT _ipathlinemove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IPathLineMove,
				Value = _ipathlinemove
			};
		}

		// Token: 0x06036BA4 RID: 224164 RVA: 0x0075258F File Offset: 0x0075078F
		public IRacingTrackMoveT AsIRacingTrackMove()
		{
			return this.As<IRacingTrackMoveT>();
		}

		// Token: 0x06036BA5 RID: 224165 RVA: 0x00752597 File Offset: 0x00750797
		public static ISplineMovePattern_UnionUnion FromIRacingTrackMove(IRacingTrackMoveT _iracingtrackmove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IRacingTrackMove,
				Value = _iracingtrackmove
			};
		}

		// Token: 0x06036BA6 RID: 224166 RVA: 0x007525AC File Offset: 0x007507AC
		public ISlideTrackMoveT AsISlideTrackMove()
		{
			return this.As<ISlideTrackMoveT>();
		}

		// Token: 0x06036BA7 RID: 224167 RVA: 0x007525B4 File Offset: 0x007507B4
		public static ISplineMovePattern_UnionUnion FromISlideTrackMove(ISlideTrackMoveT _islidetrackmove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.ISlideTrackMove,
				Value = _islidetrackmove
			};
		}

		// Token: 0x06036BA8 RID: 224168 RVA: 0x007525C9 File Offset: 0x007507C9
		public IAirPassageMoveT AsIAirPassageMove()
		{
			return this.As<IAirPassageMoveT>();
		}

		// Token: 0x06036BA9 RID: 224169 RVA: 0x007525D1 File Offset: 0x007507D1
		public static ISplineMovePattern_UnionUnion FromIAirPassageMove(IAirPassageMoveT _iairpassagemove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IAirPassageMove,
				Value = _iairpassagemove
			};
		}

		// Token: 0x06036BAA RID: 224170 RVA: 0x007525E6 File Offset: 0x007507E6
		public IMechaAirPassageMoveT AsIMechaAirPassageMove()
		{
			return this.As<IMechaAirPassageMoveT>();
		}

		// Token: 0x06036BAB RID: 224171 RVA: 0x007525EE File Offset: 0x007507EE
		public static ISplineMovePattern_UnionUnion FromIMechaAirPassageMove(IMechaAirPassageMoveT _imechaairpassagemove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IMechaAirPassageMove,
				Value = _imechaairpassagemove
			};
		}

		// Token: 0x06036BAC RID: 224172 RVA: 0x00752603 File Offset: 0x00750803
		public IPetalGrabMoveT AsIPetalGrabMove()
		{
			return this.As<IPetalGrabMoveT>();
		}

		// Token: 0x06036BAD RID: 224173 RVA: 0x0075260B File Offset: 0x0075080B
		public static ISplineMovePattern_UnionUnion FromIPetalGrabMove(IPetalGrabMoveT _ipetalgrabmove)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IPetalGrabMove,
				Value = _ipetalgrabmove
			};
		}

		// Token: 0x06036BAE RID: 224174 RVA: 0x00752620 File Offset: 0x00750820
		public IMotorcycleTrackT AsIMotorcycleTrack()
		{
			return this.As<IMotorcycleTrackT>();
		}

		// Token: 0x06036BAF RID: 224175 RVA: 0x00752628 File Offset: 0x00750828
		public static ISplineMovePattern_UnionUnion FromIMotorcycleTrack(IMotorcycleTrackT _imotorcycletrack)
		{
			return new ISplineMovePattern_UnionUnion
			{
				Type = ISplineMovePattern_Union.IMotorcycleTrack,
				Value = _imotorcycletrack
			};
		}

		// Token: 0x06036BB0 RID: 224176 RVA: 0x00752640 File Offset: 0x00750840
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
			case ISplineMovePattern_Union.IPetalGrabMove:
				return IPetalGrabMove.Pack(builder, _o.AsIPetalGrabMove()).Value;
			case ISplineMovePattern_Union.IMotorcycleTrack:
				return IMotorcycleTrack.Pack(builder, _o.AsIMotorcycleTrack()).Value;
			default:
				return 0;
			}
		}
	}
}
