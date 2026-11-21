using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200794D RID: 31053
	public struct ISplineMoveConfig : IFlatbufferObject
	{
		// Token: 0x1700E3C3 RID: 58307
		// (get) Token: 0x06036AFF RID: 223999 RVA: 0x007513B8 File Offset: 0x0074F5B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B00 RID: 224000 RVA: 0x007513C5 File Offset: 0x0074F5C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B01 RID: 224001 RVA: 0x007513CC File Offset: 0x0074F5CC
		public static ISplineMoveConfig GetRootAsISplineMoveConfig(ByteBuffer _bb)
		{
			return ISplineMoveConfig.GetRootAsISplineMoveConfig(_bb, default(ISplineMoveConfig));
		}

		// Token: 0x06036B02 RID: 224002 RVA: 0x007513E8 File Offset: 0x0074F5E8
		public static ISplineMoveConfig GetRootAsISplineMoveConfig(ByteBuffer _bb, ISplineMoveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B03 RID: 224003 RVA: 0x00751405 File Offset: 0x0074F605
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B04 RID: 224004 RVA: 0x00751414 File Offset: 0x0074F614
		public ISplineMoveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3C4 RID: 58308
		// (get) Token: 0x06036B05 RID: 224005 RVA: 0x00751424 File Offset: 0x0074F624
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

		// Token: 0x1700E3C5 RID: 58309
		// (get) Token: 0x06036B06 RID: 224006 RVA: 0x00751460 File Offset: 0x0074F660
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

		// Token: 0x06036B07 RID: 224007 RVA: 0x0075149C File Offset: 0x0074F69C
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036B08 RID: 224008 RVA: 0x007514E0 File Offset: 0x0074F6E0
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06036B09 RID: 224009 RVA: 0x007514FC File Offset: 0x0074F6FC
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06036B0A RID: 224010 RVA: 0x00751518 File Offset: 0x0074F718
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06036B0B RID: 224011 RVA: 0x00751534 File Offset: 0x0074F734
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06036B0C RID: 224012 RVA: 0x00751550 File Offset: 0x0074F750
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700E3C6 RID: 58310
		// (get) Token: 0x06036B0D RID: 224013 RVA: 0x0075156C File Offset: 0x0074F76C
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

		// Token: 0x06036B0E RID: 224014 RVA: 0x007515A9 File Offset: 0x0074F7A9
		public static Offset<ISplineMoveConfig> CreateISplineMoveConfig(FlatBufferBuilder builder, ESplineMoveConfigType Type = ESplineMoveConfigType.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, int SplineEntityId = 0)
		{
			builder.StartTable(4);
			ISplineMoveConfig.AddSplineEntityId(builder, SplineEntityId);
			ISplineMoveConfig.AddTarget(builder, TargetOffset);
			ISplineMoveConfig.AddTargetType(builder, Target_type);
			ISplineMoveConfig.AddType(builder, Type);
			return ISplineMoveConfig.EndISplineMoveConfig(builder);
		}

		// Token: 0x06036B0F RID: 224015 RVA: 0x007515D5 File Offset: 0x0074F7D5
		public static void StartISplineMoveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036B10 RID: 224016 RVA: 0x007515DE File Offset: 0x0074F7DE
		public static void AddType(FlatBufferBuilder builder, ESplineMoveConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036B11 RID: 224017 RVA: 0x007515E9 File Offset: 0x0074F7E9
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06036B12 RID: 224018 RVA: 0x007515F4 File Offset: 0x0074F7F4
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06036B13 RID: 224019 RVA: 0x007515FF File Offset: 0x0074F7FF
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06036B14 RID: 224020 RVA: 0x0075160A File Offset: 0x0074F80A
		public static Offset<ISplineMoveConfig> EndISplineMoveConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMoveConfig>(builder.EndTable());
		}

		// Token: 0x06036B15 RID: 224021 RVA: 0x00751618 File Offset: 0x0074F818
		public ISplineMoveConfigT UnPack()
		{
			ISplineMoveConfigT splineMoveConfigT = new ISplineMoveConfigT();
			this.UnPackTo(splineMoveConfigT);
			return splineMoveConfigT;
		}

		// Token: 0x06036B16 RID: 224022 RVA: 0x00751634 File Offset: 0x0074F834
		public void UnPackTo(ISplineMoveConfigT _o)
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
		}

		// Token: 0x06036B17 RID: 224023 RVA: 0x007517BC File Offset: 0x0074F9BC
		public static Offset<ISplineMoveConfig> Pack(FlatBufferBuilder builder, ISplineMoveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMoveConfig>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ISplineMoveConfig.CreateISplineMoveConfig(builder, _o.Type, target_type, targetOffset, _o.SplineEntityId);
		}

		// Token: 0x04012C1D RID: 76829
		private Table __p;
	}
}
