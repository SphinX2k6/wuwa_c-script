using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200523D RID: 21053
	public struct IFanStateEffect : IFlatbufferObject
	{
		// Token: 0x17009A3B RID: 39483
		// (get) Token: 0x060223D7 RID: 140247 RVA: 0x004BFCEC File Offset: 0x004BDEEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060223D8 RID: 140248 RVA: 0x004BFCF9 File Offset: 0x004BDEF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060223D9 RID: 140249 RVA: 0x004BFD00 File Offset: 0x004BDF00
		public static IFanStateEffect GetRootAsIFanStateEffect(ByteBuffer _bb)
		{
			return IFanStateEffect.GetRootAsIFanStateEffect(_bb, default(IFanStateEffect));
		}

		// Token: 0x060223DA RID: 140250 RVA: 0x004BFD1C File Offset: 0x004BDF1C
		public static IFanStateEffect GetRootAsIFanStateEffect(ByteBuffer _bb, IFanStateEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060223DB RID: 140251 RVA: 0x004BFD39 File Offset: 0x004BDF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060223DC RID: 140252 RVA: 0x004BFD48 File Offset: 0x004BDF48
		public IFanStateEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A3C RID: 39484
		// (get) Token: 0x060223DD RID: 140253 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public string EntityState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060223DE RID: 140254 RVA: 0x004BFD8F File Offset: 0x004BDF8F
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060223DF RID: 140255 RVA: 0x004BFD9E File Offset: 0x004BDF9E
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009A3D RID: 39485
		// (get) Token: 0x060223E0 RID: 140256 RVA: 0x004BFDAC File Offset: 0x004BDFAC
		public IFanEffectConfig? EffectConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFanEffectConfig?(default(IFanEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060223E1 RID: 140257 RVA: 0x004BFE09 File Offset: 0x004BE009
		public static Offset<IFanStateEffect> CreateIFanStateEffect(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), Offset<IFanEffectConfig> EffectConfigOffset = default(Offset<IFanEffectConfig>))
		{
			builder.StartTable(2);
			IFanStateEffect.AddEffectConfig(builder, EffectConfigOffset);
			IFanStateEffect.AddEntityState(builder, EntityStateOffset);
			return IFanStateEffect.EndIFanStateEffect(builder);
		}

		// Token: 0x060223E2 RID: 140258 RVA: 0x004BFE26 File Offset: 0x004BE026
		public static void StartIFanStateEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060223E3 RID: 140259 RVA: 0x004BFE2F File Offset: 0x004BE02F
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x060223E4 RID: 140260 RVA: 0x004BFE3F File Offset: 0x004BE03F
		public static void AddEffectConfig(FlatBufferBuilder builder, Offset<IFanEffectConfig> effectConfigOffset)
		{
			builder.AddOffset(1, effectConfigOffset.Value, 0);
		}

		// Token: 0x060223E5 RID: 140261 RVA: 0x004BFE4F File Offset: 0x004BE04F
		public static Offset<IFanStateEffect> EndIFanStateEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFanStateEffect>(builder.EndTable());
		}

		// Token: 0x060223E6 RID: 140262 RVA: 0x004BFE5C File Offset: 0x004BE05C
		public IFanStateEffectT UnPack()
		{
			IFanStateEffectT fanStateEffectT = new IFanStateEffectT();
			this.UnPackTo(fanStateEffectT);
			return fanStateEffectT;
		}

		// Token: 0x060223E7 RID: 140263 RVA: 0x004BFE78 File Offset: 0x004BE078
		public void UnPackTo(IFanStateEffectT _o)
		{
			_o.EntityState = this.EntityState;
			_o.EffectConfig = ((this.EffectConfig != null) ? this.EffectConfig.Value.UnPack() : null);
		}

		// Token: 0x060223E8 RID: 140264 RVA: 0x004BFEC0 File Offset: 0x004BE0C0
		public static Offset<IFanStateEffect> Pack(FlatBufferBuilder builder, IFanStateEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanStateEffect>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			Offset<IFanEffectConfig> effectConfigOffset = (_o.EffectConfig == null) ? default(Offset<IFanEffectConfig>) : IFanEffectConfig.Pack(builder, _o.EffectConfig);
			return IFanStateEffect.CreateIFanStateEffect(builder, entityStateOffset, effectConfigOffset);
		}

		// Token: 0x0400E385 RID: 58245
		private Table __p;
	}
}
