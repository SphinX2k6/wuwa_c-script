using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007394 RID: 29588
	public struct IOpenSkiConfig : IFlatbufferObject
	{
		// Token: 0x1700D917 RID: 55575
		// (get) Token: 0x06033AD6 RID: 211670 RVA: 0x006F7B00 File Offset: 0x006F5D00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033AD7 RID: 211671 RVA: 0x006F7B0D File Offset: 0x006F5D0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033AD8 RID: 211672 RVA: 0x006F7B14 File Offset: 0x006F5D14
		public static IOpenSkiConfig GetRootAsIOpenSkiConfig(ByteBuffer _bb)
		{
			return IOpenSkiConfig.GetRootAsIOpenSkiConfig(_bb, default(IOpenSkiConfig));
		}

		// Token: 0x06033AD9 RID: 211673 RVA: 0x006F7B30 File Offset: 0x006F5D30
		public static IOpenSkiConfig GetRootAsIOpenSkiConfig(ByteBuffer _bb, IOpenSkiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033ADA RID: 211674 RVA: 0x006F7B4D File Offset: 0x006F5D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033ADB RID: 211675 RVA: 0x006F7B5C File Offset: 0x006F5D5C
		public IOpenSkiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D918 RID: 55576
		// (get) Token: 0x06033ADC RID: 211676 RVA: 0x006F7B6C File Offset: 0x006F5D6C
		public ESkiConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkiConfig.Open;
				}
				return (ESkiConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D919 RID: 55577
		// (get) Token: 0x06033ADD RID: 211677 RVA: 0x006F7BA8 File Offset: 0x006F5DA8
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

		// Token: 0x06033ADE RID: 211678 RVA: 0x006F7BE4 File Offset: 0x006F5DE4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033ADF RID: 211679 RVA: 0x006F7C28 File Offset: 0x006F5E28
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06033AE0 RID: 211680 RVA: 0x006F7C44 File Offset: 0x006F5E44
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06033AE1 RID: 211681 RVA: 0x006F7C60 File Offset: 0x006F5E60
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06033AE2 RID: 211682 RVA: 0x006F7C7C File Offset: 0x006F5E7C
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06033AE3 RID: 211683 RVA: 0x006F7C98 File Offset: 0x006F5E98
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700D91A RID: 55578
		// (get) Token: 0x06033AE4 RID: 211684 RVA: 0x006F7CB4 File Offset: 0x006F5EB4
		public string SkiConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033AE5 RID: 211685 RVA: 0x006F7CEC File Offset: 0x006F5EEC
		public Span<byte> GetSkiConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06033AE6 RID: 211686 RVA: 0x006F7CFC File Offset: 0x006F5EFC
		public byte[] GetSkiConfigArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06033AE7 RID: 211687 RVA: 0x006F7D0B File Offset: 0x006F5F0B
		public static Offset<IOpenSkiConfig> CreateIOpenSkiConfig(FlatBufferBuilder builder, ESkiConfig Type = ESkiConfig.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, StringOffset SkiConfigOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IOpenSkiConfig.AddSkiConfig(builder, SkiConfigOffset);
			IOpenSkiConfig.AddTarget(builder, TargetOffset);
			IOpenSkiConfig.AddTargetType(builder, Target_type);
			IOpenSkiConfig.AddType(builder, Type);
			return IOpenSkiConfig.EndIOpenSkiConfig(builder);
		}

		// Token: 0x06033AE8 RID: 211688 RVA: 0x006F7D37 File Offset: 0x006F5F37
		public static void StartIOpenSkiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033AE9 RID: 211689 RVA: 0x006F7D40 File Offset: 0x006F5F40
		public static void AddType(FlatBufferBuilder builder, ESkiConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033AEA RID: 211690 RVA: 0x006F7D4B File Offset: 0x006F5F4B
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06033AEB RID: 211691 RVA: 0x006F7D56 File Offset: 0x006F5F56
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06033AEC RID: 211692 RVA: 0x006F7D61 File Offset: 0x006F5F61
		public static void AddSkiConfig(FlatBufferBuilder builder, StringOffset skiConfigOffset)
		{
			builder.AddOffset(3, skiConfigOffset.Value, 0);
		}

		// Token: 0x06033AED RID: 211693 RVA: 0x006F7D71 File Offset: 0x006F5F71
		public static Offset<IOpenSkiConfig> EndIOpenSkiConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSkiConfig>(builder.EndTable());
		}

		// Token: 0x06033AEE RID: 211694 RVA: 0x006F7D80 File Offset: 0x006F5F80
		public IOpenSkiConfigT UnPack()
		{
			IOpenSkiConfigT openSkiConfigT = new IOpenSkiConfigT();
			this.UnPackTo(openSkiConfigT);
			return openSkiConfigT;
		}

		// Token: 0x06033AEF RID: 211695 RVA: 0x006F7D9C File Offset: 0x006F5F9C
		public void UnPackTo(IOpenSkiConfigT _o)
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
			_o.SkiConfig = this.SkiConfig;
		}

		// Token: 0x06033AF0 RID: 211696 RVA: 0x006F7F24 File Offset: 0x006F6124
		public static Offset<IOpenSkiConfig> Pack(FlatBufferBuilder builder, IOpenSkiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSkiConfig>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			StringOffset skiConfigOffset = (_o.SkiConfig == null) ? default(StringOffset) : builder.CreateString(_o.SkiConfig);
			return IOpenSkiConfig.CreateIOpenSkiConfig(builder, _o.Type, target_type, targetOffset, skiConfigOffset);
		}

		// Token: 0x04012492 RID: 74898
		private Table __p;
	}
}
