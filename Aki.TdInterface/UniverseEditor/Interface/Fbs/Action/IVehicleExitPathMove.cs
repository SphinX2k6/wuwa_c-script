using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751A RID: 29978
	public struct IVehicleExitPathMove : IFlatbufferObject
	{
		// Token: 0x1700E379 RID: 58233
		// (get) Token: 0x06036861 RID: 223329 RVA: 0x00768304 File Offset: 0x00766504
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036862 RID: 223330 RVA: 0x00768311 File Offset: 0x00766511
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036863 RID: 223331 RVA: 0x00768318 File Offset: 0x00766518
		public static IVehicleExitPathMove GetRootAsIVehicleExitPathMove(ByteBuffer _bb)
		{
			return IVehicleExitPathMove.GetRootAsIVehicleExitPathMove(_bb, default(IVehicleExitPathMove));
		}

		// Token: 0x06036864 RID: 223332 RVA: 0x00768334 File Offset: 0x00766534
		public static IVehicleExitPathMove GetRootAsIVehicleExitPathMove(ByteBuffer _bb, IVehicleExitPathMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036865 RID: 223333 RVA: 0x00768351 File Offset: 0x00766551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036866 RID: 223334 RVA: 0x00768360 File Offset: 0x00766560
		public IVehicleExitPathMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E37A RID: 58234
		// (get) Token: 0x06036867 RID: 223335 RVA: 0x00768370 File Offset: 0x00766570
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

		// Token: 0x1700E37B RID: 58235
		// (get) Token: 0x06036868 RID: 223336 RVA: 0x007683AC File Offset: 0x007665AC
		public TCloseSplineMovePattern PatternType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCloseSplineMovePattern.NONE;
				}
				return (TCloseSplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036869 RID: 223337 RVA: 0x007683E8 File Offset: 0x007665E8
		public TTable? Pattern<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603686A RID: 223338 RVA: 0x0076842C File Offset: 0x0076662C
		public ICloseAirPassageMove PatternAsICloseAirPassageMove()
		{
			return this.Pattern<ICloseAirPassageMove>().Value;
		}

		// Token: 0x0603686B RID: 223339 RVA: 0x00768448 File Offset: 0x00766648
		public ICloseMotorcycleTrackMove PatternAsICloseMotorcycleTrackMove()
		{
			return this.Pattern<ICloseMotorcycleTrackMove>().Value;
		}

		// Token: 0x0603686C RID: 223340 RVA: 0x00768464 File Offset: 0x00766664
		public IClosePathLineMove PatternAsIClosePathLineMove()
		{
			return this.Pattern<IClosePathLineMove>().Value;
		}

		// Token: 0x0603686D RID: 223341 RVA: 0x00768480 File Offset: 0x00766680
		public ICloseRacingTrackMove PatternAsICloseRacingTrackMove()
		{
			return this.Pattern<ICloseRacingTrackMove>().Value;
		}

		// Token: 0x0603686E RID: 223342 RVA: 0x0076849C File Offset: 0x0076669C
		public ICloseSlideTrackMove PatternAsICloseSlideTrackMove()
		{
			return this.Pattern<ICloseSlideTrackMove>().Value;
		}

		// Token: 0x0603686F RID: 223343 RVA: 0x007684B7 File Offset: 0x007666B7
		public static Offset<IVehicleExitPathMove> CreateIVehicleExitPathMove(FlatBufferBuilder builder, EVehicleControlType Type = EVehicleControlType.EnterPathMoving, TCloseSplineMovePattern Pattern_type = TCloseSplineMovePattern.NONE, int PatternOffset = 0)
		{
			builder.StartTable(3);
			IVehicleExitPathMove.AddPattern(builder, PatternOffset);
			IVehicleExitPathMove.AddPatternType(builder, Pattern_type);
			IVehicleExitPathMove.AddType(builder, Type);
			return IVehicleExitPathMove.EndIVehicleExitPathMove(builder);
		}

		// Token: 0x06036870 RID: 223344 RVA: 0x007684DB File Offset: 0x007666DB
		public static void StartIVehicleExitPathMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036871 RID: 223345 RVA: 0x007684E4 File Offset: 0x007666E4
		public static void AddType(FlatBufferBuilder builder, EVehicleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036872 RID: 223346 RVA: 0x007684EF File Offset: 0x007666EF
		public static void AddPatternType(FlatBufferBuilder builder, TCloseSplineMovePattern patternType)
		{
			builder.AddByte(1, (byte)patternType, 0);
		}

		// Token: 0x06036873 RID: 223347 RVA: 0x007684FA File Offset: 0x007666FA
		public static void AddPattern(FlatBufferBuilder builder, int patternOffset)
		{
			builder.AddOffset(2, patternOffset, 0);
		}

		// Token: 0x06036874 RID: 223348 RVA: 0x00768505 File Offset: 0x00766705
		public static Offset<IVehicleExitPathMove> EndIVehicleExitPathMove(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleExitPathMove>(builder.EndTable());
		}

		// Token: 0x06036875 RID: 223349 RVA: 0x00768514 File Offset: 0x00766714
		public IVehicleExitPathMoveT UnPack()
		{
			IVehicleExitPathMoveT vehicleExitPathMoveT = new IVehicleExitPathMoveT();
			this.UnPackTo(vehicleExitPathMoveT);
			return vehicleExitPathMoveT;
		}

		// Token: 0x06036876 RID: 223350 RVA: 0x00768530 File Offset: 0x00766730
		public void UnPackTo(IVehicleExitPathMoveT _o)
		{
			_o.Type = this.Type;
			_o.Pattern = new TCloseSplineMovePatternUnion();
			_o.Pattern.Type = this.PatternType;
			switch (this.PatternType)
			{
			case TCloseSplineMovePattern.ICloseAirPassageMove:
				_o.Pattern.Value = ((this.Pattern<ICloseAirPassageMove>() != null) ? this.Pattern<ICloseAirPassageMove>().Value.UnPack() : null);
				return;
			case TCloseSplineMovePattern.ICloseMotorcycleTrackMove:
				_o.Pattern.Value = ((this.Pattern<ICloseMotorcycleTrackMove>() != null) ? this.Pattern<ICloseMotorcycleTrackMove>().Value.UnPack() : null);
				return;
			case TCloseSplineMovePattern.IClosePathLineMove:
				_o.Pattern.Value = ((this.Pattern<IClosePathLineMove>() != null) ? this.Pattern<IClosePathLineMove>().Value.UnPack() : null);
				return;
			case TCloseSplineMovePattern.ICloseRacingTrackMove:
				_o.Pattern.Value = ((this.Pattern<ICloseRacingTrackMove>() != null) ? this.Pattern<ICloseRacingTrackMove>().Value.UnPack() : null);
				return;
			case TCloseSplineMovePattern.ICloseSlideTrackMove:
				_o.Pattern.Value = ((this.Pattern<ICloseSlideTrackMove>() != null) ? this.Pattern<ICloseSlideTrackMove>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06036877 RID: 223351 RVA: 0x0076869C File Offset: 0x0076689C
		public static Offset<IVehicleExitPathMove> Pack(FlatBufferBuilder builder, IVehicleExitPathMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleExitPathMove>);
			}
			TCloseSplineMovePattern pattern_type = (_o.Pattern == null) ? TCloseSplineMovePattern.NONE : _o.Pattern.Type;
			int patternOffset = (_o.Pattern == null) ? 0 : TCloseSplineMovePatternUnion.Pack(builder, _o.Pattern);
			return IVehicleExitPathMove.CreateIVehicleExitPathMove(builder, _o.Type, pattern_type, patternOffset);
		}

		// Token: 0x04012408 RID: 74760
		private Table __p;
	}
}
