using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7F RID: 27519
	public struct IMp4GamepadShake : IFlatbufferObject
	{
		// Token: 0x1700CC8B RID: 52363
		// (get) Token: 0x06030533 RID: 197939 RVA: 0x00690D5C File Offset: 0x0068EF5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030534 RID: 197940 RVA: 0x00690D69 File Offset: 0x0068EF69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030535 RID: 197941 RVA: 0x00690D70 File Offset: 0x0068EF70
		public static IMp4GamepadShake GetRootAsIMp4GamepadShake(ByteBuffer _bb)
		{
			return IMp4GamepadShake.GetRootAsIMp4GamepadShake(_bb, default(IMp4GamepadShake));
		}

		// Token: 0x06030536 RID: 197942 RVA: 0x00690D8C File Offset: 0x0068EF8C
		public static IMp4GamepadShake GetRootAsIMp4GamepadShake(ByteBuffer _bb, IMp4GamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030537 RID: 197943 RVA: 0x00690DA9 File Offset: 0x0068EFA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030538 RID: 197944 RVA: 0x00690DB8 File Offset: 0x0068EFB8
		public IMp4GamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC8C RID: 52364
		// (get) Token: 0x06030539 RID: 197945 RVA: 0x00690DC8 File Offset: 0x0068EFC8
		public EGamepadShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGamepadShakeType.Onetime;
				}
				return (EGamepadShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC8D RID: 52365
		// (get) Token: 0x0603053A RID: 197946 RVA: 0x00690E04 File Offset: 0x0068F004
		public IMp4GamepadShakeFadeInConfig? FadeInConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMp4GamepadShakeFadeInConfig?(default(IMp4GamepadShakeFadeInConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CC8E RID: 52366
		// (get) Token: 0x0603053B RID: 197947 RVA: 0x00690E64 File Offset: 0x0068F064
		public IMp4GamepadShakeFadeOutConfig? FadeOutConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMp4GamepadShakeFadeOutConfig?(default(IMp4GamepadShakeFadeOutConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CC8F RID: 52367
		// (get) Token: 0x0603053C RID: 197948 RVA: 0x00690EC4 File Offset: 0x0068F0C4
		public float ShakeScale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC90 RID: 52368
		// (get) Token: 0x0603053D RID: 197949 RVA: 0x00690F08 File Offset: 0x0068F108
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603053E RID: 197950 RVA: 0x00690F45 File Offset: 0x0068F145
		public static Offset<IMp4GamepadShake> CreateIMp4GamepadShake(FlatBufferBuilder builder, EGamepadShakeType Type = EGamepadShakeType.Onetime, Offset<IMp4GamepadShakeFadeInConfig> FadeInConfigOffset = default(Offset<IMp4GamepadShakeFadeInConfig>), Offset<IMp4GamepadShakeFadeOutConfig> FadeOutConfigOffset = default(Offset<IMp4GamepadShakeFadeOutConfig>), float ShakeScale = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IMp4GamepadShake.AddShakeScale(builder, ShakeScale);
			IMp4GamepadShake.AddFadeOutConfig(builder, FadeOutConfigOffset);
			IMp4GamepadShake.AddFadeInConfig(builder, FadeInConfigOffset);
			IMp4GamepadShake.AddNullMask(builder, NullMask);
			IMp4GamepadShake.AddType(builder, Type);
			return IMp4GamepadShake.EndIMp4GamepadShake(builder);
		}

		// Token: 0x0603053F RID: 197951 RVA: 0x00690F79 File Offset: 0x0068F179
		public static void StartIMp4GamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030540 RID: 197952 RVA: 0x00690F82 File Offset: 0x0068F182
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030541 RID: 197953 RVA: 0x00690F8D File Offset: 0x0068F18D
		public static void AddFadeInConfig(FlatBufferBuilder builder, Offset<IMp4GamepadShakeFadeInConfig> fadeInConfigOffset)
		{
			builder.AddOffset(1, fadeInConfigOffset.Value, 0);
		}

		// Token: 0x06030542 RID: 197954 RVA: 0x00690F9D File Offset: 0x0068F19D
		public static void AddFadeOutConfig(FlatBufferBuilder builder, Offset<IMp4GamepadShakeFadeOutConfig> fadeOutConfigOffset)
		{
			builder.AddOffset(2, fadeOutConfigOffset.Value, 0);
		}

		// Token: 0x06030543 RID: 197955 RVA: 0x00690FAD File Offset: 0x0068F1AD
		public static void AddShakeScale(FlatBufferBuilder builder, float shakeScale)
		{
			builder.AddFloat(3, shakeScale, 0.0);
		}

		// Token: 0x06030544 RID: 197956 RVA: 0x00690FC0 File Offset: 0x0068F1C0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06030545 RID: 197957 RVA: 0x00690FCB File Offset: 0x0068F1CB
		public static Offset<IMp4GamepadShake> EndIMp4GamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<IMp4GamepadShake>(builder.EndTable());
		}

		// Token: 0x06030546 RID: 197958 RVA: 0x00690FD8 File Offset: 0x0068F1D8
		public IMp4GamepadShakeT UnPack()
		{
			IMp4GamepadShakeT mp4GamepadShakeT = new IMp4GamepadShakeT();
			this.UnPackTo(mp4GamepadShakeT);
			return mp4GamepadShakeT;
		}

		// Token: 0x06030547 RID: 197959 RVA: 0x00690FF4 File Offset: 0x0068F1F4
		public void UnPackTo(IMp4GamepadShakeT _o)
		{
			_o.Type = this.Type;
			_o.FadeInConfig = ((this.FadeInConfig != null) ? this.FadeInConfig.Value.UnPack() : null);
			_o.FadeOutConfig = ((this.FadeOutConfig != null) ? this.FadeOutConfig.Value.UnPack() : null);
			_o.ShakeScale = this.ShakeScale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030548 RID: 197960 RVA: 0x00691084 File Offset: 0x0068F284
		public static Offset<IMp4GamepadShake> Pack(FlatBufferBuilder builder, IMp4GamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4GamepadShake>);
			}
			Offset<IMp4GamepadShakeFadeInConfig> fadeInConfigOffset = (_o.FadeInConfig == null) ? default(Offset<IMp4GamepadShakeFadeInConfig>) : IMp4GamepadShakeFadeInConfig.Pack(builder, _o.FadeInConfig);
			Offset<IMp4GamepadShakeFadeOutConfig> fadeOutConfigOffset = (_o.FadeOutConfig == null) ? default(Offset<IMp4GamepadShakeFadeOutConfig>) : IMp4GamepadShakeFadeOutConfig.Pack(builder, _o.FadeOutConfig);
			return IMp4GamepadShake.CreateIMp4GamepadShake(builder, _o.Type, fadeInConfigOffset, fadeOutConfigOffset, _o.ShakeScale, _o.NullMask);
		}

		// Token: 0x0401143A RID: 70714
		private Table __p;
	}
}
