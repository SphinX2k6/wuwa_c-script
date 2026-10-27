using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007511 RID: 29969
	public struct IVehicleEnterPathMove : IFlatbufferObject
	{
		// Token: 0x1700E368 RID: 58216
		// (get) Token: 0x06036804 RID: 223236 RVA: 0x0076739C File Offset: 0x0076559C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036805 RID: 223237 RVA: 0x007673A9 File Offset: 0x007655A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036806 RID: 223238 RVA: 0x007673B0 File Offset: 0x007655B0
		public static IVehicleEnterPathMove GetRootAsIVehicleEnterPathMove(ByteBuffer _bb)
		{
			return IVehicleEnterPathMove.GetRootAsIVehicleEnterPathMove(_bb, default(IVehicleEnterPathMove));
		}

		// Token: 0x06036807 RID: 223239 RVA: 0x007673CC File Offset: 0x007655CC
		public static IVehicleEnterPathMove GetRootAsIVehicleEnterPathMove(ByteBuffer _bb, IVehicleEnterPathMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036808 RID: 223240 RVA: 0x007673E9 File Offset: 0x007655E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036809 RID: 223241 RVA: 0x007673F8 File Offset: 0x007655F8
		public IVehicleEnterPathMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E369 RID: 58217
		// (get) Token: 0x0603680A RID: 223242 RVA: 0x00767408 File Offset: 0x00765608
		public EVehicleControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleControlType.EnterPathMoving;
				}
				return (EVehicleControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E36A RID: 58218
		// (get) Token: 0x0603680B RID: 223243 RVA: 0x00767444 File Offset: 0x00765644
		public IVehicleCruisingParams? ControlParams
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVehicleCruisingParams?(default(IVehicleCruisingParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E36B RID: 58219
		// (get) Token: 0x0603680C RID: 223244 RVA: 0x007674A4 File Offset: 0x007656A4
		public TSplineMovePattern PatternType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TSplineMovePattern.NONE;
				}
				return (TSplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603680D RID: 223245 RVA: 0x007674E0 File Offset: 0x007656E0
		public TTable? Pattern<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603680E RID: 223246 RVA: 0x00767528 File Offset: 0x00765728
		public IAirPassageMove PatternAsIAirPassageMove()
		{
			return this.Pattern<IAirPassageMove>().Value;
		}

		// Token: 0x0603680F RID: 223247 RVA: 0x00767544 File Offset: 0x00765744
		public IMechaAirPassageMove PatternAsIMechaAirPassageMove()
		{
			return this.Pattern<IMechaAirPassageMove>().Value;
		}

		// Token: 0x06036810 RID: 223248 RVA: 0x00767560 File Offset: 0x00765760
		public IMotorcycleTrack PatternAsIMotorcycleTrack()
		{
			return this.Pattern<IMotorcycleTrack>().Value;
		}

		// Token: 0x06036811 RID: 223249 RVA: 0x0076757C File Offset: 0x0076577C
		public IPathLineMove PatternAsIPathLineMove()
		{
			return this.Pattern<IPathLineMove>().Value;
		}

		// Token: 0x06036812 RID: 223250 RVA: 0x00767598 File Offset: 0x00765798
		public IRacingTrackMove PatternAsIRacingTrackMove()
		{
			return this.Pattern<IRacingTrackMove>().Value;
		}

		// Token: 0x06036813 RID: 223251 RVA: 0x007675B4 File Offset: 0x007657B4
		public ISlideTrackMove PatternAsISlideTrackMove()
		{
			return this.Pattern<ISlideTrackMove>().Value;
		}

		// Token: 0x06036814 RID: 223252 RVA: 0x007675CF File Offset: 0x007657CF
		public static Offset<IVehicleEnterPathMove> CreateIVehicleEnterPathMove(FlatBufferBuilder builder, EVehicleControlType Type = EVehicleControlType.EnterPathMoving, Offset<IVehicleCruisingParams> ControlParamsOffset = default(Offset<IVehicleCruisingParams>), TSplineMovePattern Pattern_type = TSplineMovePattern.NONE, int PatternOffset = 0)
		{
			builder.StartTable(4);
			IVehicleEnterPathMove.AddPattern(builder, PatternOffset);
			IVehicleEnterPathMove.AddControlParams(builder, ControlParamsOffset);
			IVehicleEnterPathMove.AddPatternType(builder, Pattern_type);
			IVehicleEnterPathMove.AddType(builder, Type);
			return IVehicleEnterPathMove.EndIVehicleEnterPathMove(builder);
		}

		// Token: 0x06036815 RID: 223253 RVA: 0x007675FB File Offset: 0x007657FB
		public static void StartIVehicleEnterPathMove(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036816 RID: 223254 RVA: 0x00767604 File Offset: 0x00765804
		public static void AddType(FlatBufferBuilder builder, EVehicleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036817 RID: 223255 RVA: 0x0076760F File Offset: 0x0076580F
		public static void AddControlParams(FlatBufferBuilder builder, Offset<IVehicleCruisingParams> controlParamsOffset)
		{
			builder.AddOffset(1, controlParamsOffset.Value, 0);
		}

		// Token: 0x06036818 RID: 223256 RVA: 0x0076761F File Offset: 0x0076581F
		public static void AddPatternType(FlatBufferBuilder builder, TSplineMovePattern patternType)
		{
			builder.AddByte(2, (byte)patternType, 0);
		}

		// Token: 0x06036819 RID: 223257 RVA: 0x0076762A File Offset: 0x0076582A
		public static void AddPattern(FlatBufferBuilder builder, int patternOffset)
		{
			builder.AddOffset(3, patternOffset, 0);
		}

		// Token: 0x0603681A RID: 223258 RVA: 0x00767635 File Offset: 0x00765835
		public static Offset<IVehicleEnterPathMove> EndIVehicleEnterPathMove(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnterPathMove>(builder.EndTable());
		}

		// Token: 0x0603681B RID: 223259 RVA: 0x00767644 File Offset: 0x00765844
		public IVehicleEnterPathMoveT UnPack()
		{
			IVehicleEnterPathMoveT vehicleEnterPathMoveT = new IVehicleEnterPathMoveT();
			this.UnPackTo(vehicleEnterPathMoveT);
			return vehicleEnterPathMoveT;
		}

		// Token: 0x0603681C RID: 223260 RVA: 0x00767660 File Offset: 0x00765860
		public void UnPackTo(IVehicleEnterPathMoveT _o)
		{
			_o.Type = this.Type;
			_o.ControlParams = ((this.ControlParams != null) ? this.ControlParams.Value.UnPack() : null);
			_o.Pattern = new TSplineMovePatternUnion();
			_o.Pattern.Type = this.PatternType;
			switch (this.PatternType)
			{
			case TSplineMovePattern.IAirPassageMove:
				_o.Pattern.Value = ((this.Pattern<IAirPassageMove>() != null) ? this.Pattern<IAirPassageMove>().Value.UnPack() : null);
				return;
			case TSplineMovePattern.IMechaAirPassageMove:
				_o.Pattern.Value = ((this.Pattern<IMechaAirPassageMove>() != null) ? this.Pattern<IMechaAirPassageMove>().Value.UnPack() : null);
				return;
			case TSplineMovePattern.IMotorcycleTrack:
				_o.Pattern.Value = ((this.Pattern<IMotorcycleTrack>() != null) ? this.Pattern<IMotorcycleTrack>().Value.UnPack() : null);
				return;
			case TSplineMovePattern.IPathLineMove:
				_o.Pattern.Value = ((this.Pattern<IPathLineMove>() != null) ? this.Pattern<IPathLineMove>().Value.UnPack() : null);
				return;
			case TSplineMovePattern.IRacingTrackMove:
				_o.Pattern.Value = ((this.Pattern<IRacingTrackMove>() != null) ? this.Pattern<IRacingTrackMove>().Value.UnPack() : null);
				return;
			case TSplineMovePattern.ISlideTrackMove:
				_o.Pattern.Value = ((this.Pattern<ISlideTrackMove>() != null) ? this.Pattern<ISlideTrackMove>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603681D RID: 223261 RVA: 0x0076783C File Offset: 0x00765A3C
		public static Offset<IVehicleEnterPathMove> Pack(FlatBufferBuilder builder, IVehicleEnterPathMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEnterPathMove>);
			}
			Offset<IVehicleCruisingParams> controlParamsOffset = (_o.ControlParams == null) ? default(Offset<IVehicleCruisingParams>) : IVehicleCruisingParams.Pack(builder, _o.ControlParams);
			TSplineMovePattern pattern_type = (_o.Pattern == null) ? TSplineMovePattern.NONE : _o.Pattern.Type;
			int patternOffset = (_o.Pattern == null) ? 0 : TSplineMovePatternUnion.Pack(builder, _o.Pattern);
			return IVehicleEnterPathMove.CreateIVehicleEnterPathMove(builder, _o.Type, controlParamsOffset, pattern_type, patternOffset);
		}

		// Token: 0x040123FE RID: 74750
		private Table __p;
	}
}
