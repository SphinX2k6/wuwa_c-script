using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C33 RID: 27699
	public struct IOpenSplineMove : IFlatbufferObject
	{
		// Token: 0x1700CE10 RID: 52752
		// (get) Token: 0x06030BD6 RID: 199638 RVA: 0x0069E5B6 File Offset: 0x0069C7B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030BD7 RID: 199639 RVA: 0x0069E5C3 File Offset: 0x0069C7C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030BD8 RID: 199640 RVA: 0x0069E5CC File Offset: 0x0069C7CC
		public static IOpenSplineMove GetRootAsIOpenSplineMove(ByteBuffer _bb)
		{
			return IOpenSplineMove.GetRootAsIOpenSplineMove(_bb, default(IOpenSplineMove));
		}

		// Token: 0x06030BD9 RID: 199641 RVA: 0x0069E5E8 File Offset: 0x0069C7E8
		public static IOpenSplineMove GetRootAsIOpenSplineMove(ByteBuffer _bb, IOpenSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030BDA RID: 199642 RVA: 0x0069E605 File Offset: 0x0069C805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030BDB RID: 199643 RVA: 0x0069E614 File Offset: 0x0069C814
		public IOpenSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE11 RID: 52753
		// (get) Token: 0x06030BDC RID: 199644 RVA: 0x0069E624 File Offset: 0x0069C824
		public ESplineMoveConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveConfigType.Open;
				}
				return (ESplineMoveConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE12 RID: 52754
		// (get) Token: 0x06030BDD RID: 199645 RVA: 0x0069E660 File Offset: 0x0069C860
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030BDE RID: 199646 RVA: 0x0069E69C File Offset: 0x0069C89C
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030BDF RID: 199647 RVA: 0x0069E6E0 File Offset: 0x0069C8E0
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06030BE0 RID: 199648 RVA: 0x0069E6FC File Offset: 0x0069C8FC
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06030BE1 RID: 199649 RVA: 0x0069E718 File Offset: 0x0069C918
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06030BE2 RID: 199650 RVA: 0x0069E734 File Offset: 0x0069C934
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06030BE3 RID: 199651 RVA: 0x0069E750 File Offset: 0x0069C950
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700CE13 RID: 52755
		// (get) Token: 0x06030BE4 RID: 199652 RVA: 0x0069E76C File Offset: 0x0069C96C
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE14 RID: 52756
		// (get) Token: 0x06030BE5 RID: 199653 RVA: 0x0069E7AC File Offset: 0x0069C9AC
		public TSplineMovePattern PatternType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TSplineMovePattern.NONE;
				}
				return (TSplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030BE6 RID: 199654 RVA: 0x0069E7EC File Offset: 0x0069C9EC
		public TTable? Pattern<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030BE7 RID: 199655 RVA: 0x0069E834 File Offset: 0x0069CA34
		public IAirPassageMove PatternAsIAirPassageMove()
		{
			return this.Pattern<IAirPassageMove>().Value;
		}

		// Token: 0x06030BE8 RID: 199656 RVA: 0x0069E850 File Offset: 0x0069CA50
		public IMechaAirPassageMove PatternAsIMechaAirPassageMove()
		{
			return this.Pattern<IMechaAirPassageMove>().Value;
		}

		// Token: 0x06030BE9 RID: 199657 RVA: 0x0069E86C File Offset: 0x0069CA6C
		public IMotorcycleTrack PatternAsIMotorcycleTrack()
		{
			return this.Pattern<IMotorcycleTrack>().Value;
		}

		// Token: 0x06030BEA RID: 199658 RVA: 0x0069E888 File Offset: 0x0069CA88
		public IPathLineMove PatternAsIPathLineMove()
		{
			return this.Pattern<IPathLineMove>().Value;
		}

		// Token: 0x06030BEB RID: 199659 RVA: 0x0069E8A4 File Offset: 0x0069CAA4
		public IRacingTrackMove PatternAsIRacingTrackMove()
		{
			return this.Pattern<IRacingTrackMove>().Value;
		}

		// Token: 0x06030BEC RID: 199660 RVA: 0x0069E8C0 File Offset: 0x0069CAC0
		public ISlideTrackMove PatternAsISlideTrackMove()
		{
			return this.Pattern<ISlideTrackMove>().Value;
		}

		// Token: 0x06030BED RID: 199661 RVA: 0x0069E8DB File Offset: 0x0069CADB
		public static Offset<IOpenSplineMove> CreateIOpenSplineMove(FlatBufferBuilder builder, ESplineMoveConfigType Type = ESplineMoveConfigType.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, int SplineEntityId = 0, TSplineMovePattern Pattern_type = TSplineMovePattern.NONE, int PatternOffset = 0)
		{
			builder.StartTable(6);
			IOpenSplineMove.AddPattern(builder, PatternOffset);
			IOpenSplineMove.AddSplineEntityId(builder, SplineEntityId);
			IOpenSplineMove.AddTarget(builder, TargetOffset);
			IOpenSplineMove.AddPatternType(builder, Pattern_type);
			IOpenSplineMove.AddTargetType(builder, Target_type);
			IOpenSplineMove.AddType(builder, Type);
			return IOpenSplineMove.EndIOpenSplineMove(builder);
		}

		// Token: 0x06030BEE RID: 199662 RVA: 0x0069E917 File Offset: 0x0069CB17
		public static void StartIOpenSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06030BEF RID: 199663 RVA: 0x0069E920 File Offset: 0x0069CB20
		public static void AddType(FlatBufferBuilder builder, ESplineMoveConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030BF0 RID: 199664 RVA: 0x0069E92B File Offset: 0x0069CB2B
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06030BF1 RID: 199665 RVA: 0x0069E936 File Offset: 0x0069CB36
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06030BF2 RID: 199666 RVA: 0x0069E941 File Offset: 0x0069CB41
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06030BF3 RID: 199667 RVA: 0x0069E94C File Offset: 0x0069CB4C
		public static void AddPatternType(FlatBufferBuilder builder, TSplineMovePattern patternType)
		{
			builder.AddByte(4, (byte)patternType, 0);
		}

		// Token: 0x06030BF4 RID: 199668 RVA: 0x0069E957 File Offset: 0x0069CB57
		public static void AddPattern(FlatBufferBuilder builder, int patternOffset)
		{
			builder.AddOffset(5, patternOffset, 0);
		}

		// Token: 0x06030BF5 RID: 199669 RVA: 0x0069E962 File Offset: 0x0069CB62
		public static Offset<IOpenSplineMove> EndIOpenSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSplineMove>(builder.EndTable());
		}

		// Token: 0x06030BF6 RID: 199670 RVA: 0x0069E970 File Offset: 0x0069CB70
		public IOpenSplineMoveT UnPack()
		{
			IOpenSplineMoveT openSplineMoveT = new IOpenSplineMoveT();
			this.UnPackTo(openSplineMoveT);
			return openSplineMoveT;
		}

		// Token: 0x06030BF7 RID: 199671 RVA: 0x0069E98C File Offset: 0x0069CB8C
		public void UnPackTo(IOpenSplineMoveT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.SplineEntityId = this.SplineEntityId;
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

		// Token: 0x06030BF8 RID: 199672 RVA: 0x0069ECA8 File Offset: 0x0069CEA8
		public static Offset<IOpenSplineMove> Pack(FlatBufferBuilder builder, IOpenSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSplineMove>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			TSplineMovePattern pattern_type = (_o.Pattern == null) ? TSplineMovePattern.NONE : _o.Pattern.Type;
			int patternOffset = (_o.Pattern == null) ? 0 : TSplineMovePatternUnion.Pack(builder, _o.Pattern);
			return IOpenSplineMove.CreateIOpenSplineMove(builder, _o.Type, target_type, targetOffset, _o.SplineEntityId, pattern_type, patternOffset);
		}

		// Token: 0x04011546 RID: 70982
		private Table __p;
	}
}
