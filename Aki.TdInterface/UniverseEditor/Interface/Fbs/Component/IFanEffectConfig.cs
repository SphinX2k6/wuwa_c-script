using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005796 RID: 22422
	public struct IFanEffectConfig : IFlatbufferObject
	{
		// Token: 0x1700A223 RID: 41507
		// (get) Token: 0x06024305 RID: 148229 RVA: 0x004F9E44 File Offset: 0x004F8044
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024306 RID: 148230 RVA: 0x004F9E51 File Offset: 0x004F8051
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024307 RID: 148231 RVA: 0x004F9E58 File Offset: 0x004F8058
		public static IFanEffectConfig GetRootAsIFanEffectConfig(ByteBuffer _bb)
		{
			return IFanEffectConfig.GetRootAsIFanEffectConfig(_bb, default(IFanEffectConfig));
		}

		// Token: 0x06024308 RID: 148232 RVA: 0x004F9E74 File Offset: 0x004F8074
		public static IFanEffectConfig GetRootAsIFanEffectConfig(ByteBuffer _bb, IFanEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024309 RID: 148233 RVA: 0x004F9E91 File Offset: 0x004F8091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602430A RID: 148234 RVA: 0x004F9EA0 File Offset: 0x004F80A0
		public IFanEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A224 RID: 41508
		// (get) Token: 0x0602430B RID: 148235 RVA: 0x004F9EB0 File Offset: 0x004F80B0
		public string EffectPath
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

		// Token: 0x0602430C RID: 148236 RVA: 0x004F9EE7 File Offset: 0x004F80E7
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602430D RID: 148237 RVA: 0x004F9EF6 File Offset: 0x004F80F6
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A225 RID: 41509
		// (get) Token: 0x0602430E RID: 148238 RVA: 0x004F9F04 File Offset: 0x004F8104
		public float DefaultEffectLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A226 RID: 41510
		// (get) Token: 0x0602430F RID: 148239 RVA: 0x004F9F44 File Offset: 0x004F8144
		public string HitEffectPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024310 RID: 148240 RVA: 0x004F9F7B File Offset: 0x004F817B
		public Span<byte> GetHitEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024311 RID: 148241 RVA: 0x004F9F8A File Offset: 0x004F818A
		public byte[] GetHitEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06024312 RID: 148242 RVA: 0x004F9F98 File Offset: 0x004F8198
		public static Offset<IFanEffectConfig> CreateIFanEffectConfig(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), float DefaultEffectLength = 0f, StringOffset HitEffectPathOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IFanEffectConfig.AddHitEffectPath(builder, HitEffectPathOffset);
			IFanEffectConfig.AddDefaultEffectLength(builder, DefaultEffectLength);
			IFanEffectConfig.AddEffectPath(builder, EffectPathOffset);
			return IFanEffectConfig.EndIFanEffectConfig(builder);
		}

		// Token: 0x06024313 RID: 148243 RVA: 0x004F9FBC File Offset: 0x004F81BC
		public static void StartIFanEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024314 RID: 148244 RVA: 0x004F9FC5 File Offset: 0x004F81C5
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06024315 RID: 148245 RVA: 0x004F9FD5 File Offset: 0x004F81D5
		public static void AddDefaultEffectLength(FlatBufferBuilder builder, float defaultEffectLength)
		{
			builder.AddFloat(1, defaultEffectLength, 0.0);
		}

		// Token: 0x06024316 RID: 148246 RVA: 0x004F9FE8 File Offset: 0x004F81E8
		public static void AddHitEffectPath(FlatBufferBuilder builder, StringOffset hitEffectPathOffset)
		{
			builder.AddOffset(2, hitEffectPathOffset.Value, 0);
		}

		// Token: 0x06024317 RID: 148247 RVA: 0x004F9FF8 File Offset: 0x004F81F8
		public static Offset<IFanEffectConfig> EndIFanEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFanEffectConfig>(builder.EndTable());
		}

		// Token: 0x06024318 RID: 148248 RVA: 0x004FA008 File Offset: 0x004F8208
		public IFanEffectConfigT UnPack()
		{
			IFanEffectConfigT fanEffectConfigT = new IFanEffectConfigT();
			this.UnPackTo(fanEffectConfigT);
			return fanEffectConfigT;
		}

		// Token: 0x06024319 RID: 148249 RVA: 0x004FA023 File Offset: 0x004F8223
		public void UnPackTo(IFanEffectConfigT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.DefaultEffectLength = this.DefaultEffectLength;
			_o.HitEffectPath = this.HitEffectPath;
		}

		// Token: 0x0602431A RID: 148250 RVA: 0x004FA04C File Offset: 0x004F824C
		public static Offset<IFanEffectConfig> Pack(FlatBufferBuilder builder, IFanEffectConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFanEffectConfig>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			StringOffset hitEffectPathOffset = (_o.HitEffectPath == null) ? default(StringOffset) : builder.CreateString(_o.HitEffectPath);
			return IFanEffectConfig.CreateIFanEffectConfig(builder, effectPathOffset, _o.DefaultEffectLength, hitEffectPathOffset);
		}

		// Token: 0x0400EF79 RID: 61305
		private Table __p;
	}
}
