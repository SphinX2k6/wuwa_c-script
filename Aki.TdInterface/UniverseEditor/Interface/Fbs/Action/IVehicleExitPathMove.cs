using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D10 RID: 32016
	public struct IVehicleExitPathMove : IFlatbufferObject
	{
		// Token: 0x1700EFA3 RID: 61347
		// (get) Token: 0x06039C77 RID: 236663 RVA: 0x007CB5AC File Offset: 0x007C97AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039C78 RID: 236664 RVA: 0x007CB5B9 File Offset: 0x007C97B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039C79 RID: 236665 RVA: 0x007CB5C0 File Offset: 0x007C97C0
		public static IVehicleExitPathMove GetRootAsIVehicleExitPathMove(ByteBuffer _bb)
		{
			return IVehicleExitPathMove.GetRootAsIVehicleExitPathMove(_bb, default(IVehicleExitPathMove));
		}

		// Token: 0x06039C7A RID: 236666 RVA: 0x007CB5DC File Offset: 0x007C97DC
		public static IVehicleExitPathMove GetRootAsIVehicleExitPathMove(ByteBuffer _bb, IVehicleExitPathMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039C7B RID: 236667 RVA: 0x007CB5F9 File Offset: 0x007C97F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039C7C RID: 236668 RVA: 0x007CB608 File Offset: 0x007C9808
		public IVehicleExitPathMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFA4 RID: 61348
		// (get) Token: 0x06039C7D RID: 236669 RVA: 0x007CB618 File Offset: 0x007C9818
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

		// Token: 0x1700EFA5 RID: 61349
		// (get) Token: 0x06039C7E RID: 236670 RVA: 0x007CB654 File Offset: 0x007C9854
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

		// Token: 0x06039C7F RID: 236671 RVA: 0x007CB690 File Offset: 0x007C9890
		public TTable? Pattern<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039C80 RID: 236672 RVA: 0x007CB6D4 File Offset: 0x007C98D4
		public ICloseAirPassageMove PatternAsICloseAirPassageMove()
		{
			return this.Pattern<ICloseAirPassageMove>().Value;
		}

		// Token: 0x06039C81 RID: 236673 RVA: 0x007CB6F0 File Offset: 0x007C98F0
		public ICloseMotorcycleTrackMove PatternAsICloseMotorcycleTrackMove()
		{
			return this.Pattern<ICloseMotorcycleTrackMove>().Value;
		}

		// Token: 0x06039C82 RID: 236674 RVA: 0x007CB70C File Offset: 0x007C990C
		public IClosePathLineMove PatternAsIClosePathLineMove()
		{
			return this.Pattern<IClosePathLineMove>().Value;
		}

		// Token: 0x06039C83 RID: 236675 RVA: 0x007CB728 File Offset: 0x007C9928
		public ICloseRacingTrackMove PatternAsICloseRacingTrackMove()
		{
			return this.Pattern<ICloseRacingTrackMove>().Value;
		}

		// Token: 0x06039C84 RID: 236676 RVA: 0x007CB744 File Offset: 0x007C9944
		public ICloseSlideTrackMove PatternAsICloseSlideTrackMove()
		{
			return this.Pattern<ICloseSlideTrackMove>().Value;
		}

		// Token: 0x06039C85 RID: 236677 RVA: 0x007CB75F File Offset: 0x007C995F
		public static Offset<IVehicleExitPathMove> CreateIVehicleExitPathMove(FlatBufferBuilder builder, EVehicleControlType Type = EVehicleControlType.EnterPathMoving, TCloseSplineMovePattern Pattern_type = TCloseSplineMovePattern.NONE, int PatternOffset = 0)
		{
			builder.StartTable(3);
			IVehicleExitPathMove.AddPattern(builder, PatternOffset);
			IVehicleExitPathMove.AddPatternType(builder, Pattern_type);
			IVehicleExitPathMove.AddType(builder, Type);
			return IVehicleExitPathMove.EndIVehicleExitPathMove(builder);
		}

		// Token: 0x06039C86 RID: 236678 RVA: 0x007CB783 File Offset: 0x007C9983
		public static void StartIVehicleExitPathMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039C87 RID: 236679 RVA: 0x007CB78C File Offset: 0x007C998C
		public static void AddType(FlatBufferBuilder builder, EVehicleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039C88 RID: 236680 RVA: 0x007CB797 File Offset: 0x007C9997
		public static void AddPatternType(FlatBufferBuilder builder, TCloseSplineMovePattern patternType)
		{
			builder.AddByte(1, (byte)patternType, 0);
		}

		// Token: 0x06039C89 RID: 236681 RVA: 0x007CB7A2 File Offset: 0x007C99A2
		public static void AddPattern(FlatBufferBuilder builder, int patternOffset)
		{
			builder.AddOffset(2, patternOffset, 0);
		}

		// Token: 0x06039C8A RID: 236682 RVA: 0x007CB7AD File Offset: 0x007C99AD
		public static Offset<IVehicleExitPathMove> EndIVehicleExitPathMove(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleExitPathMove>(builder.EndTable());
		}

		// Token: 0x06039C8B RID: 236683 RVA: 0x007CB7BC File Offset: 0x007C99BC
		public IVehicleExitPathMoveT UnPack()
		{
			IVehicleExitPathMoveT vehicleExitPathMoveT = new IVehicleExitPathMoveT();
			this.UnPackTo(vehicleExitPathMoveT);
			return vehicleExitPathMoveT;
		}

		// Token: 0x06039C8C RID: 236684 RVA: 0x007CB7D8 File Offset: 0x007C99D8
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

		// Token: 0x06039C8D RID: 236685 RVA: 0x007CB944 File Offset: 0x007C9B44
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

		// Token: 0x04013439 RID: 78905
		private Table __p;
	}
}
