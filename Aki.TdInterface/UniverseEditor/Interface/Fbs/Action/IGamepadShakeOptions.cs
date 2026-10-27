using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006876 RID: 26742
	public struct IGamepadShakeOptions : IFlatbufferObject
	{
		// Token: 0x1700C69F RID: 50847
		// (get) Token: 0x0602EA2F RID: 191023 RVA: 0x0065C2CC File Offset: 0x0065A4CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA30 RID: 191024 RVA: 0x0065C2D9 File Offset: 0x0065A4D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA31 RID: 191025 RVA: 0x0065C2E0 File Offset: 0x0065A4E0
		public static IGamepadShakeOptions GetRootAsIGamepadShakeOptions(ByteBuffer _bb)
		{
			return IGamepadShakeOptions.GetRootAsIGamepadShakeOptions(_bb, default(IGamepadShakeOptions));
		}

		// Token: 0x0602EA32 RID: 191026 RVA: 0x0065C2FC File Offset: 0x0065A4FC
		public static IGamepadShakeOptions GetRootAsIGamepadShakeOptions(ByteBuffer _bb, IGamepadShakeOptions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA33 RID: 191027 RVA: 0x0065C319 File Offset: 0x0065A519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA34 RID: 191028 RVA: 0x0065C328 File Offset: 0x0065A528
		public IGamepadShakeOptions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6A0 RID: 50848
		// (get) Token: 0x0602EA35 RID: 191029 RVA: 0x0065C338 File Offset: 0x0065A538
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

		// Token: 0x0602EA36 RID: 191030 RVA: 0x0065C36F File Offset: 0x0065A56F
		public Span<byte> GetKuroForceFeedbackEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602EA37 RID: 191031 RVA: 0x0065C37E File Offset: 0x0065A57E
		public byte[] GetKuroForceFeedbackEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C6A1 RID: 50849
		// (get) Token: 0x0602EA38 RID: 191032 RVA: 0x0065C38C File Offset: 0x0065A58C
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

		// Token: 0x0602EA39 RID: 191033 RVA: 0x0065C3C8 File Offset: 0x0065A5C8
		public TTable? GamepadShakeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EA3A RID: 191034 RVA: 0x0065C40C File Offset: 0x0065A60C
		public IAttenuatedGamepadShake GamepadShakeConfigAsIAttenuatedGamepadShake()
		{
			return this.GamepadShakeConfig<IAttenuatedGamepadShake>().Value;
		}

		// Token: 0x0602EA3B RID: 191035 RVA: 0x0065C428 File Offset: 0x0065A628
		public IContinualGamepadShake GamepadShakeConfigAsIContinualGamepadShake()
		{
			return this.GamepadShakeConfig<IContinualGamepadShake>().Value;
		}

		// Token: 0x0602EA3C RID: 191036 RVA: 0x0065C444 File Offset: 0x0065A644
		public IMp4GamepadShake GamepadShakeConfigAsIMp4GamepadShake()
		{
			return this.GamepadShakeConfig<IMp4GamepadShake>().Value;
		}

		// Token: 0x0602EA3D RID: 191037 RVA: 0x0065C460 File Offset: 0x0065A660
		public IOnetimeGamepadShake GamepadShakeConfigAsIOnetimeGamepadShake()
		{
			return this.GamepadShakeConfig<IOnetimeGamepadShake>().Value;
		}

		// Token: 0x0602EA3E RID: 191038 RVA: 0x0065C47B File Offset: 0x0065A67B
		public static Offset<IGamepadShakeOptions> CreateIGamepadShakeOptions(FlatBufferBuilder builder, StringOffset KuroForceFeedbackEffectOffset = default(StringOffset), TGamepadShakeConfig GamepadShakeConfig_type = TGamepadShakeConfig.NONE, int GamepadShakeConfigOffset = 0)
		{
			builder.StartTable(3);
			IGamepadShakeOptions.AddGamepadShakeConfig(builder, GamepadShakeConfigOffset);
			IGamepadShakeOptions.AddKuroForceFeedbackEffect(builder, KuroForceFeedbackEffectOffset);
			IGamepadShakeOptions.AddGamepadShakeConfigType(builder, GamepadShakeConfig_type);
			return IGamepadShakeOptions.EndIGamepadShakeOptions(builder);
		}

		// Token: 0x0602EA3F RID: 191039 RVA: 0x0065C49F File Offset: 0x0065A69F
		public static void StartIGamepadShakeOptions(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EA40 RID: 191040 RVA: 0x0065C4A8 File Offset: 0x0065A6A8
		public static void AddKuroForceFeedbackEffect(FlatBufferBuilder builder, StringOffset kuroForceFeedbackEffectOffset)
		{
			builder.AddOffset(0, kuroForceFeedbackEffectOffset.Value, 0);
		}

		// Token: 0x0602EA41 RID: 191041 RVA: 0x0065C4B8 File Offset: 0x0065A6B8
		public static void AddGamepadShakeConfigType(FlatBufferBuilder builder, TGamepadShakeConfig gamepadShakeConfigType)
		{
			builder.AddByte(1, (byte)gamepadShakeConfigType, 0);
		}

		// Token: 0x0602EA42 RID: 191042 RVA: 0x0065C4C3 File Offset: 0x0065A6C3
		public static void AddGamepadShakeConfig(FlatBufferBuilder builder, int gamepadShakeConfigOffset)
		{
			builder.AddOffset(2, gamepadShakeConfigOffset, 0);
		}

		// Token: 0x0602EA43 RID: 191043 RVA: 0x0065C4CE File Offset: 0x0065A6CE
		public static Offset<IGamepadShakeOptions> EndIGamepadShakeOptions(FlatBufferBuilder builder)
		{
			return new Offset<IGamepadShakeOptions>(builder.EndTable());
		}

		// Token: 0x0602EA44 RID: 191044 RVA: 0x0065C4DC File Offset: 0x0065A6DC
		public IGamepadShakeOptionsT UnPack()
		{
			IGamepadShakeOptionsT gamepadShakeOptionsT = new IGamepadShakeOptionsT();
			this.UnPackTo(gamepadShakeOptionsT);
			return gamepadShakeOptionsT;
		}

		// Token: 0x0602EA45 RID: 191045 RVA: 0x0065C4F8 File Offset: 0x0065A6F8
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

		// Token: 0x0602EA46 RID: 191046 RVA: 0x0065C628 File Offset: 0x0065A828
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

		// Token: 0x04010FCD RID: 69581
		private Table __p;
	}
}
