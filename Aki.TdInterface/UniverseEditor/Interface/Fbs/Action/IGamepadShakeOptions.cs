using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F17 RID: 28439
	public struct IGamepadShakeOptions : IFlatbufferObject
	{
		// Token: 0x1700D085 RID: 53381
		// (get) Token: 0x06031369 RID: 201577 RVA: 0x006AB34C File Offset: 0x006A954C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603136A RID: 201578 RVA: 0x006AB359 File Offset: 0x006A9559
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603136B RID: 201579 RVA: 0x006AB360 File Offset: 0x006A9560
		public static IGamepadShakeOptions GetRootAsIGamepadShakeOptions(ByteBuffer _bb)
		{
			return IGamepadShakeOptions.GetRootAsIGamepadShakeOptions(_bb, default(IGamepadShakeOptions));
		}

		// Token: 0x0603136C RID: 201580 RVA: 0x006AB37C File Offset: 0x006A957C
		public static IGamepadShakeOptions GetRootAsIGamepadShakeOptions(ByteBuffer _bb, IGamepadShakeOptions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603136D RID: 201581 RVA: 0x006AB399 File Offset: 0x006A9599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603136E RID: 201582 RVA: 0x006AB3A8 File Offset: 0x006A95A8
		public IGamepadShakeOptions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D086 RID: 53382
		// (get) Token: 0x0603136F RID: 201583 RVA: 0x006AB3B8 File Offset: 0x006A95B8
		public string KuroForceFeedbackEffect
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

		// Token: 0x06031370 RID: 201584 RVA: 0x006AB3EF File Offset: 0x006A95EF
		public Span<byte> GetKuroForceFeedbackEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031371 RID: 201585 RVA: 0x006AB3FE File Offset: 0x006A95FE
		public byte[] GetKuroForceFeedbackEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D087 RID: 53383
		// (get) Token: 0x06031372 RID: 201586 RVA: 0x006AB40C File Offset: 0x006A960C
		public TGamepadShakeConfig GamepadShakeConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGamepadShakeConfig.NONE;
				}
				return (TGamepadShakeConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031373 RID: 201587 RVA: 0x006AB448 File Offset: 0x006A9648
		public TTable? GamepadShakeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031374 RID: 201588 RVA: 0x006AB48C File Offset: 0x006A968C
		public IAttenuatedGamepadShake GamepadShakeConfigAsIAttenuatedGamepadShake()
		{
			return this.GamepadShakeConfig<IAttenuatedGamepadShake>().Value;
		}

		// Token: 0x06031375 RID: 201589 RVA: 0x006AB4A8 File Offset: 0x006A96A8
		public IContinualGamepadShake GamepadShakeConfigAsIContinualGamepadShake()
		{
			return this.GamepadShakeConfig<IContinualGamepadShake>().Value;
		}

		// Token: 0x06031376 RID: 201590 RVA: 0x006AB4C4 File Offset: 0x006A96C4
		public IMp4GamepadShake GamepadShakeConfigAsIMp4GamepadShake()
		{
			return this.GamepadShakeConfig<IMp4GamepadShake>().Value;
		}

		// Token: 0x06031377 RID: 201591 RVA: 0x006AB4E0 File Offset: 0x006A96E0
		public IOnetimeGamepadShake GamepadShakeConfigAsIOnetimeGamepadShake()
		{
			return this.GamepadShakeConfig<IOnetimeGamepadShake>().Value;
		}

		// Token: 0x06031378 RID: 201592 RVA: 0x006AB4FB File Offset: 0x006A96FB
		public static Offset<IGamepadShakeOptions> CreateIGamepadShakeOptions(FlatBufferBuilder builder, StringOffset KuroForceFeedbackEffectOffset = default(StringOffset), TGamepadShakeConfig GamepadShakeConfig_type = TGamepadShakeConfig.NONE, int GamepadShakeConfigOffset = 0)
		{
			builder.StartTable(3);
			IGamepadShakeOptions.AddGamepadShakeConfig(builder, GamepadShakeConfigOffset);
			IGamepadShakeOptions.AddKuroForceFeedbackEffect(builder, KuroForceFeedbackEffectOffset);
			IGamepadShakeOptions.AddGamepadShakeConfigType(builder, GamepadShakeConfig_type);
			return IGamepadShakeOptions.EndIGamepadShakeOptions(builder);
		}

		// Token: 0x06031379 RID: 201593 RVA: 0x006AB51F File Offset: 0x006A971F
		public static void StartIGamepadShakeOptions(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603137A RID: 201594 RVA: 0x006AB528 File Offset: 0x006A9728
		public static void AddKuroForceFeedbackEffect(FlatBufferBuilder builder, StringOffset kuroForceFeedbackEffectOffset)
		{
			builder.AddOffset(0, kuroForceFeedbackEffectOffset.Value, 0);
		}

		// Token: 0x0603137B RID: 201595 RVA: 0x006AB538 File Offset: 0x006A9738
		public static void AddGamepadShakeConfigType(FlatBufferBuilder builder, TGamepadShakeConfig gamepadShakeConfigType)
		{
			builder.AddByte(1, (byte)gamepadShakeConfigType, 0);
		}

		// Token: 0x0603137C RID: 201596 RVA: 0x006AB543 File Offset: 0x006A9743
		public static void AddGamepadShakeConfig(FlatBufferBuilder builder, int gamepadShakeConfigOffset)
		{
			builder.AddOffset(2, gamepadShakeConfigOffset, 0);
		}

		// Token: 0x0603137D RID: 201597 RVA: 0x006AB54E File Offset: 0x006A974E
		public static Offset<IGamepadShakeOptions> EndIGamepadShakeOptions(FlatBufferBuilder builder)
		{
			return new Offset<IGamepadShakeOptions>(builder.EndTable());
		}

		// Token: 0x0603137E RID: 201598 RVA: 0x006AB55C File Offset: 0x006A975C
		public IGamepadShakeOptionsT UnPack()
		{
			IGamepadShakeOptionsT gamepadShakeOptionsT = new IGamepadShakeOptionsT();
			this.UnPackTo(gamepadShakeOptionsT);
			return gamepadShakeOptionsT;
		}

		// Token: 0x0603137F RID: 201599 RVA: 0x006AB578 File Offset: 0x006A9778
		public void UnPackTo(IGamepadShakeOptionsT _o)
		{
			_o.KuroForceFeedbackEffect = this.KuroForceFeedbackEffect;
			_o.GamepadShakeConfig = new TGamepadShakeConfigUnion();
			_o.GamepadShakeConfig.Type = this.GamepadShakeConfigType;
			switch (this.GamepadShakeConfigType)
			{
			case TGamepadShakeConfig.IAttenuatedGamepadShake:
				_o.GamepadShakeConfig.Value = ((this.GamepadShakeConfig<IAttenuatedGamepadShake>() != null) ? this.GamepadShakeConfig<IAttenuatedGamepadShake>().Value.UnPack() : null);
				return;
			case TGamepadShakeConfig.IContinualGamepadShake:
				_o.GamepadShakeConfig.Value = ((this.GamepadShakeConfig<IContinualGamepadShake>() != null) ? this.GamepadShakeConfig<IContinualGamepadShake>().Value.UnPack() : null);
				return;
			case TGamepadShakeConfig.IMp4GamepadShake:
				_o.GamepadShakeConfig.Value = ((this.GamepadShakeConfig<IMp4GamepadShake>() != null) ? this.GamepadShakeConfig<IMp4GamepadShake>().Value.UnPack() : null);
				return;
			case TGamepadShakeConfig.IOnetimeGamepadShake:
				_o.GamepadShakeConfig.Value = ((this.GamepadShakeConfig<IOnetimeGamepadShake>() != null) ? this.GamepadShakeConfig<IOnetimeGamepadShake>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06031380 RID: 201600 RVA: 0x006AB6A8 File Offset: 0x006A98A8
		public static Offset<IGamepadShakeOptions> Pack(FlatBufferBuilder builder, IGamepadShakeOptionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGamepadShakeOptions>);
			}
			StringOffset kuroForceFeedbackEffectOffset = (_o.KuroForceFeedbackEffect == null) ? default(StringOffset) : builder.CreateString(_o.KuroForceFeedbackEffect);
			TGamepadShakeConfig gamepadShakeConfig_type = (_o.GamepadShakeConfig == null) ? TGamepadShakeConfig.NONE : _o.GamepadShakeConfig.Type;
			int gamepadShakeConfigOffset = (_o.GamepadShakeConfig == null) ? 0 : TGamepadShakeConfigUnion.Pack(builder, _o.GamepadShakeConfig);
			return IGamepadShakeOptions.CreateIGamepadShakeOptions(builder, kuroForceFeedbackEffectOffset, gamepadShakeConfig_type, gamepadShakeConfigOffset);
		}

		// Token: 0x04011E22 RID: 73250
		private Table __p;
	}
}
