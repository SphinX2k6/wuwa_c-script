using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200522E RID: 21038
	public struct IFanEffectConfig : IFlatbufferObject
	{
		// Token: 0x17009A27 RID: 39463
		// (get) Token: 0x0602236F RID: 140143 RVA: 0x004BF380 File Offset: 0x004BD580
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022370 RID: 140144 RVA: 0x004BF38D File Offset: 0x004BD58D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022371 RID: 140145 RVA: 0x004BF394 File Offset: 0x004BD594
		public static IFanEffectConfig GetRootAsIFanEffectConfig(ByteBuffer _bb)
		{
			return IFanEffectConfig.GetRootAsIFanEffectConfig(_bb, default(IFanEffectConfig));
		}

		// Token: 0x06022372 RID: 140146 RVA: 0x004BF3B0 File Offset: 0x004BD5B0
		public static IFanEffectConfig GetRootAsIFanEffectConfig(ByteBuffer _bb, IFanEffectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022373 RID: 140147 RVA: 0x004BF3CD File Offset: 0x004BD5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022374 RID: 140148 RVA: 0x004BF3DC File Offset: 0x004BD5DC
		public IFanEffectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A28 RID: 39464
		// (get) Token: 0x06022375 RID: 140149 RVA: 0x004BF3EC File Offset: 0x004BD5EC
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

		// Token: 0x06022376 RID: 140150 RVA: 0x004BF423 File Offset: 0x004BD623
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022377 RID: 140151 RVA: 0x004BF432 File Offset: 0x004BD632
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009A29 RID: 39465
		// (get) Token: 0x06022378 RID: 140152 RVA: 0x004BF440 File Offset: 0x004BD640
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

		// Token: 0x17009A2A RID: 39466
		// (get) Token: 0x06022379 RID: 140153 RVA: 0x004BF480 File Offset: 0x004BD680
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

		// Token: 0x0602237A RID: 140154 RVA: 0x004BF4B7 File Offset: 0x004BD6B7
		public Span<byte> GetHitEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602237B RID: 140155 RVA: 0x004BF4C6 File Offset: 0x004BD6C6
		public byte[] GetHitEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602237C RID: 140156 RVA: 0x004BF4D4 File Offset: 0x004BD6D4
		public static Offset<IFanEffectConfig> CreateIFanEffectConfig(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), float DefaultEffectLength = 0f, StringOffset HitEffectPathOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IFanEffectConfig.AddHitEffectPath(builder, HitEffectPathOffset);
			IFanEffectConfig.AddDefaultEffectLength(builder, DefaultEffectLength);
			IFanEffectConfig.AddEffectPath(builder, EffectPathOffset);
			return IFanEffectConfig.EndIFanEffectConfig(builder);
		}

		// Token: 0x0602237D RID: 140157 RVA: 0x004BF4F8 File Offset: 0x004BD6F8
		public static void StartIFanEffectConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602237E RID: 140158 RVA: 0x004BF501 File Offset: 0x004BD701
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x0602237F RID: 140159 RVA: 0x004BF511 File Offset: 0x004BD711
		public static void AddDefaultEffectLength(FlatBufferBuilder builder, float defaultEffectLength)
		{
			builder.AddFloat(1, defaultEffectLength, 0.0);
		}

		// Token: 0x06022380 RID: 140160 RVA: 0x004BF524 File Offset: 0x004BD724
		public static void AddHitEffectPath(FlatBufferBuilder builder, StringOffset hitEffectPathOffset)
		{
			builder.AddOffset(2, hitEffectPathOffset.Value, 0);
		}

		// Token: 0x06022381 RID: 140161 RVA: 0x004BF534 File Offset: 0x004BD734
		public static Offset<IFanEffectConfig> EndIFanEffectConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFanEffectConfig>(builder.EndTable());
		}

		// Token: 0x06022382 RID: 140162 RVA: 0x004BF544 File Offset: 0x004BD744
		public IFanEffectConfigT UnPack()
		{
			IFanEffectConfigT fanEffectConfigT = new IFanEffectConfigT();
			this.UnPackTo(fanEffectConfigT);
			return fanEffectConfigT;
		}

		// Token: 0x06022383 RID: 140163 RVA: 0x004BF55F File Offset: 0x004BD75F
		public void UnPackTo(IFanEffectConfigT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.DefaultEffectLength = this.DefaultEffectLength;
			_o.HitEffectPath = this.HitEffectPath;
		}

		// Token: 0x06022384 RID: 140164 RVA: 0x004BF588 File Offset: 0x004BD788
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

		// Token: 0x0400E373 RID: 58227
		private Table __p;
	}
}
