using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B99 RID: 31641
	public struct ITeleportTransitionWithCustomScreen : IFlatbufferObject
	{
		// Token: 0x1700ECE3 RID: 60643
		// (get) Token: 0x06038FE2 RID: 233442 RVA: 0x007B3CB6 File Offset: 0x007B1EB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038FE3 RID: 233443 RVA: 0x007B3CC3 File Offset: 0x007B1EC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038FE4 RID: 233444 RVA: 0x007B3CCC File Offset: 0x007B1ECC
		public static ITeleportTransitionWithCustomScreen GetRootAsITeleportTransitionWithCustomScreen(ByteBuffer _bb)
		{
			return ITeleportTransitionWithCustomScreen.GetRootAsITeleportTransitionWithCustomScreen(_bb, default(ITeleportTransitionWithCustomScreen));
		}

		// Token: 0x06038FE5 RID: 233445 RVA: 0x007B3CE8 File Offset: 0x007B1EE8
		public static ITeleportTransitionWithCustomScreen GetRootAsITeleportTransitionWithCustomScreen(ByteBuffer _bb, ITeleportTransitionWithCustomScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038FE6 RID: 233446 RVA: 0x007B3D05 File Offset: 0x007B1F05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038FE7 RID: 233447 RVA: 0x007B3D14 File Offset: 0x007B1F14
		public ITeleportTransitionWithCustomScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECE4 RID: 60644
		// (get) Token: 0x06038FE8 RID: 233448 RVA: 0x007B3D24 File Offset: 0x007B1F24
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ECE5 RID: 60645
		// (get) Token: 0x06038FE9 RID: 233449 RVA: 0x007B3D60 File Offset: 0x007B1F60
		public TCustomScreen ScreenTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCustomScreen.NONE;
				}
				return (TCustomScreen)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038FEA RID: 233450 RVA: 0x007B3D9C File Offset: 0x007B1F9C
		public TTable? ScreenType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038FEB RID: 233451 RVA: 0x007B3DE0 File Offset: 0x007B1FE0
		public ICustomScreenBackgroundImage ScreenTypeAsICustomScreenBackgroundImage()
		{
			return this.ScreenType<ICustomScreenBackgroundImage>().Value;
		}

		// Token: 0x06038FEC RID: 233452 RVA: 0x007B3DFC File Offset: 0x007B1FFC
		public ICustomScreenLoading ScreenTypeAsICustomScreenLoading()
		{
			return this.ScreenType<ICustomScreenLoading>().Value;
		}

		// Token: 0x06038FED RID: 233453 RVA: 0x007B3E18 File Offset: 0x007B2018
		public ICustomScreenSpine ScreenTypeAsICustomScreenSpine()
		{
			return this.ScreenType<ICustomScreenSpine>().Value;
		}

		// Token: 0x1700ECE6 RID: 60646
		// (get) Token: 0x06038FEE RID: 233454 RVA: 0x007B3E34 File Offset: 0x007B2034
		public IFadeBackgroundFadeInEffect? FadeInEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundFadeInEffect?(default(IFadeBackgroundFadeInEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ECE7 RID: 60647
		// (get) Token: 0x06038FEF RID: 233455 RVA: 0x007B3E94 File Offset: 0x007B2094
		public IFadeBackgroundFadeOutEffect? FadeOutEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundFadeOutEffect?(default(IFadeBackgroundFadeOutEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ECE8 RID: 60648
		// (get) Token: 0x06038FF0 RID: 233456 RVA: 0x007B3EF4 File Offset: 0x007B20F4
		public float KeepTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ECE9 RID: 60649
		// (get) Token: 0x06038FF1 RID: 233457 RVA: 0x007B3F38 File Offset: 0x007B2138
		public ICustomShowUi? CustomShowUi
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ICustomShowUi?(default(ICustomShowUi).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ECEA RID: 60650
		// (get) Token: 0x06038FF2 RID: 233458 RVA: 0x007B3F98 File Offset: 0x007B2198
		public string StartAkEvent
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038FF3 RID: 233459 RVA: 0x007B3FD0 File Offset: 0x007B21D0
		public Span<byte> GetStartAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06038FF4 RID: 233460 RVA: 0x007B3FE0 File Offset: 0x007B21E0
		public byte[] GetStartAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700ECEB RID: 60651
		// (get) Token: 0x06038FF5 RID: 233461 RVA: 0x007B3FF0 File Offset: 0x007B21F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038FF6 RID: 233462 RVA: 0x007B4030 File Offset: 0x007B2230
		public static Offset<ITeleportTransitionWithCustomScreen> CreateITeleportTransitionWithCustomScreen(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, TCustomScreen ScreenType_type = TCustomScreen.NONE, int ScreenTypeOffset = 0, Offset<IFadeBackgroundFadeInEffect> FadeInEffectOffset = default(Offset<IFadeBackgroundFadeInEffect>), Offset<IFadeBackgroundFadeOutEffect> FadeOutEffectOffset = default(Offset<IFadeBackgroundFadeOutEffect>), float KeepTime = 0f, Offset<ICustomShowUi> CustomShowUiOffset = default(Offset<ICustomShowUi>), StringOffset StartAkEventOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			ITeleportTransitionWithCustomScreen.AddStartAkEvent(builder, StartAkEventOffset);
			ITeleportTransitionWithCustomScreen.AddCustomShowUi(builder, CustomShowUiOffset);
			ITeleportTransitionWithCustomScreen.AddKeepTime(builder, KeepTime);
			ITeleportTransitionWithCustomScreen.AddFadeOutEffect(builder, FadeOutEffectOffset);
			ITeleportTransitionWithCustomScreen.AddFadeInEffect(builder, FadeInEffectOffset);
			ITeleportTransitionWithCustomScreen.AddScreenType(builder, ScreenTypeOffset);
			ITeleportTransitionWithCustomScreen.AddNullMask(builder, NullMask);
			ITeleportTransitionWithCustomScreen.AddScreenTypeType(builder, ScreenType_type);
			ITeleportTransitionWithCustomScreen.AddType(builder, Type);
			return ITeleportTransitionWithCustomScreen.EndITeleportTransitionWithCustomScreen(builder);
		}

		// Token: 0x06038FF7 RID: 233463 RVA: 0x007B4090 File Offset: 0x007B2290
		public static void StartITeleportTransitionWithCustomScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06038FF8 RID: 233464 RVA: 0x007B409A File Offset: 0x007B229A
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038FF9 RID: 233465 RVA: 0x007B40A5 File Offset: 0x007B22A5
		public static void AddScreenTypeType(FlatBufferBuilder builder, TCustomScreen screenTypeType)
		{
			builder.AddByte(1, (byte)screenTypeType, 0);
		}

		// Token: 0x06038FFA RID: 233466 RVA: 0x007B40B0 File Offset: 0x007B22B0
		public static void AddScreenType(FlatBufferBuilder builder, int screenTypeOffset)
		{
			builder.AddOffset(2, screenTypeOffset, 0);
		}

		// Token: 0x06038FFB RID: 233467 RVA: 0x007B40BB File Offset: 0x007B22BB
		public static void AddFadeInEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset)
		{
			builder.AddOffset(3, fadeInEffectOffset.Value, 0);
		}

		// Token: 0x06038FFC RID: 233468 RVA: 0x007B40CB File Offset: 0x007B22CB
		public static void AddFadeOutEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset)
		{
			builder.AddOffset(4, fadeOutEffectOffset.Value, 0);
		}

		// Token: 0x06038FFD RID: 233469 RVA: 0x007B40DB File Offset: 0x007B22DB
		public static void AddKeepTime(FlatBufferBuilder builder, float keepTime)
		{
			builder.AddFloat(5, keepTime, 0.0);
		}

		// Token: 0x06038FFE RID: 233470 RVA: 0x007B40EE File Offset: 0x007B22EE
		public static void AddCustomShowUi(FlatBufferBuilder builder, Offset<ICustomShowUi> customShowUiOffset)
		{
			builder.AddOffset(6, customShowUiOffset.Value, 0);
		}

		// Token: 0x06038FFF RID: 233471 RVA: 0x007B40FE File Offset: 0x007B22FE
		public static void AddStartAkEvent(FlatBufferBuilder builder, StringOffset startAkEventOffset)
		{
			builder.AddOffset(7, startAkEventOffset.Value, 0);
		}

		// Token: 0x06039000 RID: 233472 RVA: 0x007B410E File Offset: 0x007B230E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06039001 RID: 233473 RVA: 0x007B4119 File Offset: 0x007B2319
		public static Offset<ITeleportTransitionWithCustomScreen> EndITeleportTransitionWithCustomScreen(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithCustomScreen>(builder.EndTable());
		}

		// Token: 0x06039002 RID: 233474 RVA: 0x007B4128 File Offset: 0x007B2328
		public ITeleportTransitionWithCustomScreenT UnPack()
		{
			ITeleportTransitionWithCustomScreenT teleportTransitionWithCustomScreenT = new ITeleportTransitionWithCustomScreenT();
			this.UnPackTo(teleportTransitionWithCustomScreenT);
			return teleportTransitionWithCustomScreenT;
		}

		// Token: 0x06039003 RID: 233475 RVA: 0x007B4144 File Offset: 0x007B2344
		public void UnPackTo(ITeleportTransitionWithCustomScreenT _o)
		{
			_o.Type = this.Type;
			_o.ScreenType = new TCustomScreenUnion();
			_o.ScreenType.Type = this.ScreenTypeType;
			switch (this.ScreenTypeType)
			{
			case TCustomScreen.ICustomScreenBackgroundImage:
				_o.ScreenType.Value = ((this.ScreenType<ICustomScreenBackgroundImage>() != null) ? this.ScreenType<ICustomScreenBackgroundImage>().Value.UnPack() : null);
				break;
			case TCustomScreen.ICustomScreenLoading:
				_o.ScreenType.Value = ((this.ScreenType<ICustomScreenLoading>() != null) ? this.ScreenType<ICustomScreenLoading>().Value.UnPack() : null);
				break;
			case TCustomScreen.ICustomScreenSpine:
				_o.ScreenType.Value = ((this.ScreenType<ICustomScreenSpine>() != null) ? this.ScreenType<ICustomScreenSpine>().Value.UnPack() : null);
				break;
			}
			_o.FadeInEffect = ((this.FadeInEffect != null) ? this.FadeInEffect.Value.UnPack() : null);
			_o.FadeOutEffect = ((this.FadeOutEffect != null) ? this.FadeOutEffect.Value.UnPack() : null);
			_o.KeepTime = this.KeepTime;
			_o.CustomShowUi = ((this.CustomShowUi != null) ? this.CustomShowUi.Value.UnPack() : null);
			_o.StartAkEvent = this.StartAkEvent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039004 RID: 233476 RVA: 0x007B42F8 File Offset: 0x007B24F8
		public static Offset<ITeleportTransitionWithCustomScreen> Pack(FlatBufferBuilder builder, ITeleportTransitionWithCustomScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithCustomScreen>);
			}
			TCustomScreen screenType_type = (_o.ScreenType == null) ? TCustomScreen.NONE : _o.ScreenType.Type;
			int screenTypeOffset = (_o.ScreenType == null) ? 0 : TCustomScreenUnion.Pack(builder, _o.ScreenType);
			Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset = (_o.FadeInEffect == null) ? default(Offset<IFadeBackgroundFadeInEffect>) : IFadeBackgroundFadeInEffect.Pack(builder, _o.FadeInEffect);
			Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset = (_o.FadeOutEffect == null) ? default(Offset<IFadeBackgroundFadeOutEffect>) : IFadeBackgroundFadeOutEffect.Pack(builder, _o.FadeOutEffect);
			Offset<ICustomShowUi> customShowUiOffset = (_o.CustomShowUi == null) ? default(Offset<ICustomShowUi>) : ICustomShowUi.Pack(builder, _o.CustomShowUi);
			StringOffset startAkEventOffset = (_o.StartAkEvent == null) ? default(StringOffset) : builder.CreateString(_o.StartAkEvent);
			return ITeleportTransitionWithCustomScreen.CreateITeleportTransitionWithCustomScreen(builder, _o.Type, screenType_type, screenTypeOffset, fadeInEffectOffset, fadeOutEffectOffset, _o.KeepTime, customShowUiOffset, startAkEventOffset, _o.NullMask);
		}

		// Token: 0x040131FF RID: 78335
		private Table __p;
	}
}
