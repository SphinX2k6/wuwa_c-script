using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739A RID: 29594
	public struct IOpenSplineMove : IFlatbufferObject
	{
		// Token: 0x1700D92B RID: 55595
		// (get) Token: 0x06033B2D RID: 211757 RVA: 0x006F89C6 File Offset: 0x006F6BC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B2E RID: 211758 RVA: 0x006F89D3 File Offset: 0x006F6BD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B2F RID: 211759 RVA: 0x006F89DC File Offset: 0x006F6BDC
		public static IOpenSplineMove GetRootAsIOpenSplineMove(ByteBuffer _bb)
		{
			return IOpenSplineMove.GetRootAsIOpenSplineMove(_bb, default(IOpenSplineMove));
		}

		// Token: 0x06033B30 RID: 211760 RVA: 0x006F89F8 File Offset: 0x006F6BF8
		public static IOpenSplineMove GetRootAsIOpenSplineMove(ByteBuffer _bb, IOpenSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B31 RID: 211761 RVA: 0x006F8A15 File Offset: 0x006F6C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B32 RID: 211762 RVA: 0x006F8A24 File Offset: 0x006F6C24
		public IOpenSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D92C RID: 55596
		// (get) Token: 0x06033B33 RID: 211763 RVA: 0x006F8A34 File Offset: 0x006F6C34
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

		// Token: 0x1700D92D RID: 55597
		// (get) Token: 0x06033B34 RID: 211764 RVA: 0x006F8A70 File Offset: 0x006F6C70
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

		// Token: 0x06033B35 RID: 211765 RVA: 0x006F8AAC File Offset: 0x006F6CAC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033B36 RID: 211766 RVA: 0x006F8AF0 File Offset: 0x006F6CF0
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06033B37 RID: 211767 RVA: 0x006F8B0C File Offset: 0x006F6D0C
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06033B38 RID: 211768 RVA: 0x006F8B28 File Offset: 0x006F6D28
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06033B39 RID: 211769 RVA: 0x006F8B44 File Offset: 0x006F6D44
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06033B3A RID: 211770 RVA: 0x006F8B60 File Offset: 0x006F6D60
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700D92E RID: 55598
		// (get) Token: 0x06033B3B RID: 211771 RVA: 0x006F8B7C File Offset: 0x006F6D7C
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

		// Token: 0x1700D92F RID: 55599
		// (get) Token: 0x06033B3C RID: 211772 RVA: 0x006F8BBC File Offset: 0x006F6DBC
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

		// Token: 0x06033B3D RID: 211773 RVA: 0x006F8BFC File Offset: 0x006F6DFC
		public TTable? Pattern<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033B3E RID: 211774 RVA: 0x006F8C44 File Offset: 0x006F6E44
		public IAirPassageMove PatternAsIAirPassageMove()
		{
			return this.Pattern<IAirPassageMove>().Value;
		}

		// Token: 0x06033B3F RID: 211775 RVA: 0x006F8C60 File Offset: 0x006F6E60
		public IMechaAirPassageMove PatternAsIMechaAirPassageMove()
		{
			return this.Pattern<IMechaAirPassageMove>().Value;
		}

		// Token: 0x06033B40 RID: 211776 RVA: 0x006F8C7C File Offset: 0x006F6E7C
		public IMotorcycleTrack PatternAsIMotorcycleTrack()
		{
			return this.Pattern<IMotorcycleTrack>().Value;
		}

		// Token: 0x06033B41 RID: 211777 RVA: 0x006F8C98 File Offset: 0x006F6E98
		public IPathLineMove PatternAsIPathLineMove()
		{
			return this.Pattern<IPathLineMove>().Value;
		}

		// Token: 0x06033B42 RID: 211778 RVA: 0x006F8CB4 File Offset: 0x006F6EB4
		public IPetalGrabMove PatternAsIPetalGrabMove()
		{
			return this.Pattern<IPetalGrabMove>().Value;
		}

		// Token: 0x06033B43 RID: 211779 RVA: 0x006F8CD0 File Offset: 0x006F6ED0
		public IRacingTrackMove PatternAsIRacingTrackMove()
		{
			return this.Pattern<IRacingTrackMove>().Value;
		}

		// Token: 0x06033B44 RID: 211780 RVA: 0x006F8CEC File Offset: 0x006F6EEC
		public ISlideTrackMove PatternAsISlideTrackMove()
		{
			return this.Pattern<ISlideTrackMove>().Value;
		}

		// Token: 0x06033B45 RID: 211781 RVA: 0x006F8D07 File Offset: 0x006F6F07
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

		// Token: 0x06033B46 RID: 211782 RVA: 0x006F8D43 File Offset: 0x006F6F43
		public static void StartIOpenSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06033B47 RID: 211783 RVA: 0x006F8D4C File Offset: 0x006F6F4C
		public static void AddType(FlatBufferBuilder builder, ESplineMoveConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033B48 RID: 211784 RVA: 0x006F8D57 File Offset: 0x006F6F57
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06033B49 RID: 211785 RVA: 0x006F8D62 File Offset: 0x006F6F62
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06033B4A RID: 211786 RVA: 0x006F8D6D File Offset: 0x006F6F6D
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06033B4B RID: 211787 RVA: 0x006F8D78 File Offset: 0x006F6F78
		public static void AddPatternType(FlatBufferBuilder builder, TSplineMovePattern patternType)
		{
			builder.AddByte(4, (byte)patternType, 0);
		}

		// Token: 0x06033B4C RID: 211788 RVA: 0x006F8D83 File Offset: 0x006F6F83
		public static void AddPattern(FlatBufferBuilder builder, int patternOffset)
		{
			builder.AddOffset(5, patternOffset, 0);
		}

		// Token: 0x06033B4D RID: 211789 RVA: 0x006F8D8E File Offset: 0x006F6F8E
		public static Offset<IOpenSplineMove> EndIOpenSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSplineMove>(builder.EndTable());
		}

		// Token: 0x06033B4E RID: 211790 RVA: 0x006F8D9C File Offset: 0x006F6F9C
		public IOpenSplineMoveT UnPack()
		{
			IOpenSplineMoveT openSplineMoveT = new IOpenSplineMoveT();
			this.UnPackTo(openSplineMoveT);
			return openSplineMoveT;
		}

		// Token: 0x06033B4F RID: 211791 RVA: 0x006F8DB8 File Offset: 0x006F6FB8
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

		// Token: 0x06033B50 RID: 211792 RVA: 0x006F9110 File Offset: 0x006F7310
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

		// Token: 0x0401249D RID: 74909
		private Table __p;
	}
}
