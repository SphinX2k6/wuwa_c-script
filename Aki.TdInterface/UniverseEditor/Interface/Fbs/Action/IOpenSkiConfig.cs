using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2D RID: 27693
	public struct IOpenSkiConfig : IFlatbufferObject
	{
		// Token: 0x1700CDFC RID: 52732
		// (get) Token: 0x06030B7F RID: 199551 RVA: 0x0069D6F0 File Offset: 0x0069B8F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B80 RID: 199552 RVA: 0x0069D6FD File Offset: 0x0069B8FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B81 RID: 199553 RVA: 0x0069D704 File Offset: 0x0069B904
		public static IOpenSkiConfig GetRootAsIOpenSkiConfig(ByteBuffer _bb)
		{
			return IOpenSkiConfig.GetRootAsIOpenSkiConfig(_bb, default(IOpenSkiConfig));
		}

		// Token: 0x06030B82 RID: 199554 RVA: 0x0069D720 File Offset: 0x0069B920
		public static IOpenSkiConfig GetRootAsIOpenSkiConfig(ByteBuffer _bb, IOpenSkiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B83 RID: 199555 RVA: 0x0069D73D File Offset: 0x0069B93D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B84 RID: 199556 RVA: 0x0069D74C File Offset: 0x0069B94C
		public IOpenSkiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDFD RID: 52733
		// (get) Token: 0x06030B85 RID: 199557 RVA: 0x0069D75C File Offset: 0x0069B95C
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

		// Token: 0x1700CDFE RID: 52734
		// (get) Token: 0x06030B86 RID: 199558 RVA: 0x0069D798 File Offset: 0x0069B998
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

		// Token: 0x06030B87 RID: 199559 RVA: 0x0069D7D4 File Offset: 0x0069B9D4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030B88 RID: 199560 RVA: 0x0069D818 File Offset: 0x0069BA18
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06030B89 RID: 199561 RVA: 0x0069D834 File Offset: 0x0069BA34
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06030B8A RID: 199562 RVA: 0x0069D850 File Offset: 0x0069BA50
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06030B8B RID: 199563 RVA: 0x0069D86C File Offset: 0x0069BA6C
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06030B8C RID: 199564 RVA: 0x0069D888 File Offset: 0x0069BA88
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700CDFF RID: 52735
		// (get) Token: 0x06030B8D RID: 199565 RVA: 0x0069D8A4 File Offset: 0x0069BAA4
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

		// Token: 0x06030B8E RID: 199566 RVA: 0x0069D8DC File Offset: 0x0069BADC
		public Span<byte> GetSkiConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06030B8F RID: 199567 RVA: 0x0069D8EC File Offset: 0x0069BAEC
		public byte[] GetSkiConfigArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06030B90 RID: 199568 RVA: 0x0069D8FB File Offset: 0x0069BAFB
		public static Offset<IOpenSkiConfig> CreateIOpenSkiConfig(FlatBufferBuilder builder, ESkiConfig Type = ESkiConfig.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, StringOffset SkiConfigOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IOpenSkiConfig.AddSkiConfig(builder, SkiConfigOffset);
			IOpenSkiConfig.AddTarget(builder, TargetOffset);
			IOpenSkiConfig.AddTargetType(builder, Target_type);
			IOpenSkiConfig.AddType(builder, Type);
			return IOpenSkiConfig.EndIOpenSkiConfig(builder);
		}

		// Token: 0x06030B91 RID: 199569 RVA: 0x0069D927 File Offset: 0x0069BB27
		public static void StartIOpenSkiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030B92 RID: 199570 RVA: 0x0069D930 File Offset: 0x0069BB30
		public static void AddType(FlatBufferBuilder builder, ESkiConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030B93 RID: 199571 RVA: 0x0069D93B File Offset: 0x0069BB3B
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06030B94 RID: 199572 RVA: 0x0069D946 File Offset: 0x0069BB46
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06030B95 RID: 199573 RVA: 0x0069D951 File Offset: 0x0069BB51
		public static void AddSkiConfig(FlatBufferBuilder builder, StringOffset skiConfigOffset)
		{
			builder.AddOffset(3, skiConfigOffset.Value, 0);
		}

		// Token: 0x06030B96 RID: 199574 RVA: 0x0069D961 File Offset: 0x0069BB61
		public static Offset<IOpenSkiConfig> EndIOpenSkiConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSkiConfig>(builder.EndTable());
		}

		// Token: 0x06030B97 RID: 199575 RVA: 0x0069D970 File Offset: 0x0069BB70
		public IOpenSkiConfigT UnPack()
		{
			IOpenSkiConfigT openSkiConfigT = new IOpenSkiConfigT();
			this.UnPackTo(openSkiConfigT);
			return openSkiConfigT;
		}

		// Token: 0x06030B98 RID: 199576 RVA: 0x0069D98C File Offset: 0x0069BB8C
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

		// Token: 0x06030B99 RID: 199577 RVA: 0x0069DB14 File Offset: 0x0069BD14
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

		// Token: 0x0401153B RID: 70971
		private Table __p;
	}
}
