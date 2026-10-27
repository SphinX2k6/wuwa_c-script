using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007481 RID: 29825
	public struct ITriggerGamepadShake : IFlatbufferObject
	{
		// Token: 0x1700E26A RID: 57962
		// (get) Token: 0x0603632A RID: 221994 RVA: 0x0075E589 File Offset: 0x0075C789
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603632B RID: 221995 RVA: 0x0075E596 File Offset: 0x0075C796
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603632C RID: 221996 RVA: 0x0075E5A0 File Offset: 0x0075C7A0
		public static ITriggerGamepadShake GetRootAsITriggerGamepadShake(ByteBuffer _bb)
		{
			return ITriggerGamepadShake.GetRootAsITriggerGamepadShake(_bb, default(ITriggerGamepadShake));
		}

		// Token: 0x0603632D RID: 221997 RVA: 0x0075E5BC File Offset: 0x0075C7BC
		public static ITriggerGamepadShake GetRootAsITriggerGamepadShake(ByteBuffer _bb, ITriggerGamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603632E RID: 221998 RVA: 0x0075E5D9 File Offset: 0x0075C7D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603632F RID: 221999 RVA: 0x0075E5E8 File Offset: 0x0075C7E8
		public ITriggerGamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E26B RID: 57963
		// (get) Token: 0x06036330 RID: 222000 RVA: 0x0075E5F8 File Offset: 0x0075C7F8
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

		// Token: 0x06036331 RID: 222001 RVA: 0x0075E62F File Offset: 0x0075C82F
		public Span<byte> GetKuroForceFeedbackEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036332 RID: 222002 RVA: 0x0075E63E File Offset: 0x0075C83E
		public byte[] GetKuroForceFeedbackEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E26C RID: 57964
		// (get) Token: 0x06036333 RID: 222003 RVA: 0x0075E64C File Offset: 0x0075C84C
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

		// Token: 0x06036334 RID: 222004 RVA: 0x0075E688 File Offset: 0x0075C888
		public TTable? GamepadShakeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036335 RID: 222005 RVA: 0x0075E6CC File Offset: 0x0075C8CC
		public IAttenuatedGamepadShake GamepadShakeConfigAsIAttenuatedGamepadShake()
		{
			return this.GamepadShakeConfig<IAttenuatedGamepadShake>().Value;
		}

		// Token: 0x06036336 RID: 222006 RVA: 0x0075E6E8 File Offset: 0x0075C8E8
		public IContinualGamepadShake GamepadShakeConfigAsIContinualGamepadShake()
		{
			return this.GamepadShakeConfig<IContinualGamepadShake>().Value;
		}

		// Token: 0x06036337 RID: 222007 RVA: 0x0075E704 File Offset: 0x0075C904
		public IMp4GamepadShake GamepadShakeConfigAsIMp4GamepadShake()
		{
			return this.GamepadShakeConfig<IMp4GamepadShake>().Value;
		}

		// Token: 0x06036338 RID: 222008 RVA: 0x0075E720 File Offset: 0x0075C920
		public IOnetimeGamepadShake GamepadShakeConfigAsIOnetimeGamepadShake()
		{
			return this.GamepadShakeConfig<IOnetimeGamepadShake>().Value;
		}

		// Token: 0x06036339 RID: 222009 RVA: 0x0075E73B File Offset: 0x0075C93B
		public static Offset<ITriggerGamepadShake> CreateITriggerGamepadShake(FlatBufferBuilder builder, StringOffset KuroForceFeedbackEffectOffset = default(StringOffset), TGamepadShakeConfig GamepadShakeConfig_type = TGamepadShakeConfig.NONE, int GamepadShakeConfigOffset = 0)
		{
			builder.StartTable(3);
			ITriggerGamepadShake.AddGamepadShakeConfig(builder, GamepadShakeConfigOffset);
			ITriggerGamepadShake.AddKuroForceFeedbackEffect(builder, KuroForceFeedbackEffectOffset);
			ITriggerGamepadShake.AddGamepadShakeConfigType(builder, GamepadShakeConfig_type);
			return ITriggerGamepadShake.EndITriggerGamepadShake(builder);
		}

		// Token: 0x0603633A RID: 222010 RVA: 0x0075E75F File Offset: 0x0075C95F
		public static void StartITriggerGamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603633B RID: 222011 RVA: 0x0075E768 File Offset: 0x0075C968
		public static void AddKuroForceFeedbackEffect(FlatBufferBuilder builder, StringOffset kuroForceFeedbackEffectOffset)
		{
			builder.AddOffset(0, kuroForceFeedbackEffectOffset.Value, 0);
		}

		// Token: 0x0603633C RID: 222012 RVA: 0x0075E778 File Offset: 0x0075C978
		public static void AddGamepadShakeConfigType(FlatBufferBuilder builder, TGamepadShakeConfig gamepadShakeConfigType)
		{
			builder.AddByte(1, (byte)gamepadShakeConfigType, 0);
		}

		// Token: 0x0603633D RID: 222013 RVA: 0x0075E783 File Offset: 0x0075C983
		public static void AddGamepadShakeConfig(FlatBufferBuilder builder, int gamepadShakeConfigOffset)
		{
			builder.AddOffset(2, gamepadShakeConfigOffset, 0);
		}

		// Token: 0x0603633E RID: 222014 RVA: 0x0075E78E File Offset: 0x0075C98E
		public static Offset<ITriggerGamepadShake> EndITriggerGamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerGamepadShake>(builder.EndTable());
		}

		// Token: 0x0603633F RID: 222015 RVA: 0x0075E79C File Offset: 0x0075C99C
		public ITriggerGamepadShakeT UnPack()
		{
			ITriggerGamepadShakeT triggerGamepadShakeT = new ITriggerGamepadShakeT();
			this.UnPackTo(triggerGamepadShakeT);
			return triggerGamepadShakeT;
		}

		// Token: 0x06036340 RID: 222016 RVA: 0x0075E7B8 File Offset: 0x0075C9B8
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

		// Token: 0x06036341 RID: 222017 RVA: 0x0075E8E8 File Offset: 0x0075CAE8
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

		// Token: 0x04012316 RID: 74518
		private Table __p;
	}
}
