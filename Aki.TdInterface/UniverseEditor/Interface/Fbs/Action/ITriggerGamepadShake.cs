using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C74 RID: 31860
	public struct ITriggerGamepadShake : IFlatbufferObject
	{
		// Token: 0x1700EE87 RID: 61063
		// (get) Token: 0x06039713 RID: 235283 RVA: 0x007C12B5 File Offset: 0x007BF4B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039714 RID: 235284 RVA: 0x007C12C2 File Offset: 0x007BF4C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039715 RID: 235285 RVA: 0x007C12CC File Offset: 0x007BF4CC
		public static ITriggerGamepadShake GetRootAsITriggerGamepadShake(ByteBuffer _bb)
		{
			return ITriggerGamepadShake.GetRootAsITriggerGamepadShake(_bb, default(ITriggerGamepadShake));
		}

		// Token: 0x06039716 RID: 235286 RVA: 0x007C12E8 File Offset: 0x007BF4E8
		public static ITriggerGamepadShake GetRootAsITriggerGamepadShake(ByteBuffer _bb, ITriggerGamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039717 RID: 235287 RVA: 0x007C1305 File Offset: 0x007BF505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039718 RID: 235288 RVA: 0x007C1314 File Offset: 0x007BF514
		public ITriggerGamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE88 RID: 61064
		// (get) Token: 0x06039719 RID: 235289 RVA: 0x007C1324 File Offset: 0x007BF524
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

		// Token: 0x0603971A RID: 235290 RVA: 0x007C135B File Offset: 0x007BF55B
		public Span<byte> GetKuroForceFeedbackEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603971B RID: 235291 RVA: 0x007C136A File Offset: 0x007BF56A
		public byte[] GetKuroForceFeedbackEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700EE89 RID: 61065
		// (get) Token: 0x0603971C RID: 235292 RVA: 0x007C1378 File Offset: 0x007BF578
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

		// Token: 0x0603971D RID: 235293 RVA: 0x007C13B4 File Offset: 0x007BF5B4
		public TTable? GamepadShakeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603971E RID: 235294 RVA: 0x007C13F8 File Offset: 0x007BF5F8
		public IAttenuatedGamepadShake GamepadShakeConfigAsIAttenuatedGamepadShake()
		{
			return this.GamepadShakeConfig<IAttenuatedGamepadShake>().Value;
		}

		// Token: 0x0603971F RID: 235295 RVA: 0x007C1414 File Offset: 0x007BF614
		public IContinualGamepadShake GamepadShakeConfigAsIContinualGamepadShake()
		{
			return this.GamepadShakeConfig<IContinualGamepadShake>().Value;
		}

		// Token: 0x06039720 RID: 235296 RVA: 0x007C1430 File Offset: 0x007BF630
		public IMp4GamepadShake GamepadShakeConfigAsIMp4GamepadShake()
		{
			return this.GamepadShakeConfig<IMp4GamepadShake>().Value;
		}

		// Token: 0x06039721 RID: 235297 RVA: 0x007C144C File Offset: 0x007BF64C
		public IOnetimeGamepadShake GamepadShakeConfigAsIOnetimeGamepadShake()
		{
			return this.GamepadShakeConfig<IOnetimeGamepadShake>().Value;
		}

		// Token: 0x06039722 RID: 235298 RVA: 0x007C1467 File Offset: 0x007BF667
		public static Offset<ITriggerGamepadShake> CreateITriggerGamepadShake(FlatBufferBuilder builder, StringOffset KuroForceFeedbackEffectOffset = default(StringOffset), TGamepadShakeConfig GamepadShakeConfig_type = TGamepadShakeConfig.NONE, int GamepadShakeConfigOffset = 0)
		{
			builder.StartTable(3);
			ITriggerGamepadShake.AddGamepadShakeConfig(builder, GamepadShakeConfigOffset);
			ITriggerGamepadShake.AddKuroForceFeedbackEffect(builder, KuroForceFeedbackEffectOffset);
			ITriggerGamepadShake.AddGamepadShakeConfigType(builder, GamepadShakeConfig_type);
			return ITriggerGamepadShake.EndITriggerGamepadShake(builder);
		}

		// Token: 0x06039723 RID: 235299 RVA: 0x007C148B File Offset: 0x007BF68B
		public static void StartITriggerGamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039724 RID: 235300 RVA: 0x007C1494 File Offset: 0x007BF694
		public static void AddKuroForceFeedbackEffect(FlatBufferBuilder builder, StringOffset kuroForceFeedbackEffectOffset)
		{
			builder.AddOffset(0, kuroForceFeedbackEffectOffset.Value, 0);
		}

		// Token: 0x06039725 RID: 235301 RVA: 0x007C14A4 File Offset: 0x007BF6A4
		public static void AddGamepadShakeConfigType(FlatBufferBuilder builder, TGamepadShakeConfig gamepadShakeConfigType)
		{
			builder.AddByte(1, (byte)gamepadShakeConfigType, 0);
		}

		// Token: 0x06039726 RID: 235302 RVA: 0x007C14AF File Offset: 0x007BF6AF
		public static void AddGamepadShakeConfig(FlatBufferBuilder builder, int gamepadShakeConfigOffset)
		{
			builder.AddOffset(2, gamepadShakeConfigOffset, 0);
		}

		// Token: 0x06039727 RID: 235303 RVA: 0x007C14BA File Offset: 0x007BF6BA
		public static Offset<ITriggerGamepadShake> EndITriggerGamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerGamepadShake>(builder.EndTable());
		}

		// Token: 0x06039728 RID: 235304 RVA: 0x007C14C8 File Offset: 0x007BF6C8
		public ITriggerGamepadShakeT UnPack()
		{
			ITriggerGamepadShakeT triggerGamepadShakeT = new ITriggerGamepadShakeT();
			this.UnPackTo(triggerGamepadShakeT);
			return triggerGamepadShakeT;
		}

		// Token: 0x06039729 RID: 235305 RVA: 0x007C14E4 File Offset: 0x007BF6E4
		public void UnPackTo(ITriggerGamepadShakeT _o)
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

		// Token: 0x0603972A RID: 235306 RVA: 0x007C1614 File Offset: 0x007BF814
		public static Offset<ITriggerGamepadShake> Pack(FlatBufferBuilder builder, ITriggerGamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerGamepadShake>);
			}
			StringOffset kuroForceFeedbackEffectOffset = (_o.KuroForceFeedbackEffect == null) ? default(StringOffset) : builder.CreateString(_o.KuroForceFeedbackEffect);
			TGamepadShakeConfig gamepadShakeConfig_type = (_o.GamepadShakeConfig == null) ? TGamepadShakeConfig.NONE : _o.GamepadShakeConfig.Type;
			int gamepadShakeConfigOffset = (_o.GamepadShakeConfig == null) ? 0 : TGamepadShakeConfigUnion.Pack(builder, _o.GamepadShakeConfig);
			return ITriggerGamepadShake.CreateITriggerGamepadShake(builder, kuroForceFeedbackEffectOffset, gamepadShakeConfig_type, gamepadShakeConfigOffset);
		}

		// Token: 0x0401333D RID: 78653
		private Table __p;
	}
}
