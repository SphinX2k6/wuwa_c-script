using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D07 RID: 32007
	public struct IVehicleEnterPathMove : IFlatbufferObject
	{
		// Token: 0x1700EF92 RID: 61330
		// (get) Token: 0x06039C19 RID: 236569 RVA: 0x007CA5EC File Offset: 0x007C87EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039C1A RID: 236570 RVA: 0x007CA5F9 File Offset: 0x007C87F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039C1B RID: 236571 RVA: 0x007CA600 File Offset: 0x007C8800
		public static IVehicleEnterPathMove GetRootAsIVehicleEnterPathMove(ByteBuffer _bb)
		{
			return IVehicleEnterPathMove.GetRootAsIVehicleEnterPathMove(_bb, default(IVehicleEnterPathMove));
		}

		// Token: 0x06039C1C RID: 236572 RVA: 0x007CA61C File Offset: 0x007C881C
		public static IVehicleEnterPathMove GetRootAsIVehicleEnterPathMove(ByteBuffer _bb, IVehicleEnterPathMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039C1D RID: 236573 RVA: 0x007CA639 File Offset: 0x007C8839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039C1E RID: 236574 RVA: 0x007CA648 File Offset: 0x007C8848
		public IVehicleEnterPathMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF93 RID: 61331
		// (get) Token: 0x06039C1F RID: 236575 RVA: 0x007CA658 File Offset: 0x007C8858
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

		// Token: 0x1700EF94 RID: 61332
		// (get) Token: 0x06039C20 RID: 236576 RVA: 0x007CA694 File Offset: 0x007C8894
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

		// Token: 0x1700EF95 RID: 61333
		// (get) Token: 0x06039C21 RID: 236577 RVA: 0x007CA6F4 File Offset: 0x007C88F4
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

		// Token: 0x06039C22 RID: 236578 RVA: 0x007CA730 File Offset: 0x007C8930
		public TTable? Pattern<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039C23 RID: 236579 RVA: 0x007CA778 File Offset: 0x007C8978
		public IAirPassageMove PatternAsIAirPassageMove()
		{
			return this.Pattern<IAirPassageMove>().Value;
		}

		// Token: 0x06039C24 RID: 236580 RVA: 0x007CA794 File Offset: 0x007C8994
		public IMechaAirPassageMove PatternAsIMechaAirPassageMove()
		{
			return this.Pattern<IMechaAirPassageMove>().Value;
		}

		// Token: 0x06039C25 RID: 236581 RVA: 0x007CA7B0 File Offset: 0x007C89B0
		public IMotorcycleTrack PatternAsIMotorcycleTrack()
		{
			return this.Pattern<IMotorcycleTrack>().Value;
		}

		// Token: 0x06039C26 RID: 236582 RVA: 0x007CA7CC File Offset: 0x007C89CC
		public IPathLineMove PatternAsIPathLineMove()
		{
			return this.Pattern<IPathLineMove>().Value;
		}

		// Token: 0x06039C27 RID: 236583 RVA: 0x007CA7E8 File Offset: 0x007C89E8
		public IPetalGrabMove PatternAsIPetalGrabMove()
		{
			return this.Pattern<IPetalGrabMove>().Value;
		}

		// Token: 0x06039C28 RID: 236584 RVA: 0x007CA804 File Offset: 0x007C8A04
		public IRacingTrackMove PatternAsIRacingTrackMove()
		{
			return this.Pattern<IRacingTrackMove>().Value;
		}

		// Token: 0x06039C29 RID: 236585 RVA: 0x007CA820 File Offset: 0x007C8A20
		public ISlideTrackMove PatternAsISlideTrackMove()
		{
			return this.Pattern<ISlideTrackMove>().Value;
		}

		// Token: 0x06039C2A RID: 236586 RVA: 0x007CA83B File Offset: 0x007C8A3B
		public static Offset<IVehicleEnterPathMove> CreateIVehicleEnterPathMove(FlatBufferBuilder builder, EVehicleControlType Type = EVehicleControlType.EnterPathMoving, Offset<IVehicleCruisingParams> ControlParamsOffset = default(Offset<IVehicleCruisingParams>), TSplineMovePattern Pattern_type = TSplineMovePattern.NONE, int PatternOffset = 0)
		{
			builder.StartTable(4);
			IVehicleEnterPathMove.AddPattern(builder, PatternOffset);
			IVehicleEnterPathMove.AddControlParams(builder, ControlParamsOffset);
			IVehicleEnterPathMove.AddPatternType(builder, Pattern_type);
			IVehicleEnterPathMove.AddType(builder, Type);
			return IVehicleEnterPathMove.EndIVehicleEnterPathMove(builder);
		}

		// Token: 0x06039C2B RID: 236587 RVA: 0x007CA867 File Offset: 0x007C8A67
		public static void StartIVehicleEnterPathMove(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06039C2C RID: 236588 RVA: 0x007CA870 File Offset: 0x007C8A70
		public static void AddType(FlatBufferBuilder builder, EVehicleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039C2D RID: 236589 RVA: 0x007CA87B File Offset: 0x007C8A7B
		public static void AddControlParams(FlatBufferBuilder builder, Offset<IVehicleCruisingParams> controlParamsOffset)
		{
			builder.AddOffset(1, controlParamsOffset.Value, 0);
		}

		// Token: 0x06039C2E RID: 236590 RVA: 0x007CA88B File Offset: 0x007C8A8B
		public static void AddPatternType(FlatBufferBuilder builder, TSplineMovePattern patternType)
		{
			builder.AddByte(2, (byte)patternType, 0);
		}

		// Token: 0x06039C2F RID: 236591 RVA: 0x007CA896 File Offset: 0x007C8A96
		public static void AddPattern(FlatBufferBuilder builder, int patternOffset)
		{
			builder.AddOffset(3, patternOffset, 0);
		}

		// Token: 0x06039C30 RID: 236592 RVA: 0x007CA8A1 File Offset: 0x007C8AA1
		public static Offset<IVehicleEnterPathMove> EndIVehicleEnterPathMove(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnterPathMove>(builder.EndTable());
		}

		// Token: 0x06039C31 RID: 236593 RVA: 0x007CA8B0 File Offset: 0x007C8AB0
		public IVehicleEnterPathMoveT UnPack()
		{
			IVehicleEnterPathMoveT vehicleEnterPathMoveT = new IVehicleEnterPathMoveT();
			this.UnPackTo(vehicleEnterPathMoveT);
			return vehicleEnterPathMoveT;
		}

		// Token: 0x06039C32 RID: 236594 RVA: 0x007CA8CC File Offset: 0x007C8ACC
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
			case TSplineMovePattern.IPetalGrabMove:
				_o.Pattern.Value = ((this.Pattern<IPetalGrabMove>() != null) ? this.Pattern<IPetalGrabMove>().Value.UnPack() : null);
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

		// Token: 0x06039C33 RID: 236595 RVA: 0x007CAAE4 File Offset: 0x007C8CE4
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

		// Token: 0x0401342F RID: 78895
		private Table __p;
	}
}
