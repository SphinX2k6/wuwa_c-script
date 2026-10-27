using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B2 RID: 29618
	public struct ITeleportTransitionWithCustomScreen : IFlatbufferObject
	{
		// Token: 0x1700E0D3 RID: 57555
		// (get) Token: 0x06035C47 RID: 220231 RVA: 0x00751776 File Offset: 0x0074F976
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C48 RID: 220232 RVA: 0x00751783 File Offset: 0x0074F983
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C49 RID: 220233 RVA: 0x0075178C File Offset: 0x0074F98C
		public static ITeleportTransitionWithCustomScreen GetRootAsITeleportTransitionWithCustomScreen(ByteBuffer _bb)
		{
			return ITeleportTransitionWithCustomScreen.GetRootAsITeleportTransitionWithCustomScreen(_bb, default(ITeleportTransitionWithCustomScreen));
		}

		// Token: 0x06035C4A RID: 220234 RVA: 0x007517A8 File Offset: 0x0074F9A8
		public static ITeleportTransitionWithCustomScreen GetRootAsITeleportTransitionWithCustomScreen(ByteBuffer _bb, ITeleportTransitionWithCustomScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C4B RID: 220235 RVA: 0x007517C5 File Offset: 0x0074F9C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C4C RID: 220236 RVA: 0x007517D4 File Offset: 0x0074F9D4
		public ITeleportTransitionWithCustomScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0D4 RID: 57556
		// (get) Token: 0x06035C4D RID: 220237 RVA: 0x007517E4 File Offset: 0x0074F9E4
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

		// Token: 0x1700E0D5 RID: 57557
		// (get) Token: 0x06035C4E RID: 220238 RVA: 0x00751820 File Offset: 0x0074FA20
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

		// Token: 0x06035C4F RID: 220239 RVA: 0x0075185C File Offset: 0x0074FA5C
		public TTable? ScreenType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035C50 RID: 220240 RVA: 0x007518A0 File Offset: 0x0074FAA0
		public ICustomScreenBackgroundImage ScreenTypeAsICustomScreenBackgroundImage()
		{
			return this.ScreenType<ICustomScreenBackgroundImage>().Value;
		}

		// Token: 0x06035C51 RID: 220241 RVA: 0x007518BC File Offset: 0x0074FABC
		public ICustomScreenLoading ScreenTypeAsICustomScreenLoading()
		{
			return this.ScreenType<ICustomScreenLoading>().Value;
		}

		// Token: 0x06035C52 RID: 220242 RVA: 0x007518D8 File Offset: 0x0074FAD8
		public ICustomScreenSpine ScreenTypeAsICustomScreenSpine()
		{
			return this.ScreenType<ICustomScreenSpine>().Value;
		}

		// Token: 0x1700E0D6 RID: 57558
		// (get) Token: 0x06035C53 RID: 220243 RVA: 0x007518F4 File Offset: 0x0074FAF4
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

		// Token: 0x1700E0D7 RID: 57559
		// (get) Token: 0x06035C54 RID: 220244 RVA: 0x00751954 File Offset: 0x0074FB54
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

		// Token: 0x1700E0D8 RID: 57560
		// (get) Token: 0x06035C55 RID: 220245 RVA: 0x007519B4 File Offset: 0x0074FBB4
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

		// Token: 0x1700E0D9 RID: 57561
		// (get) Token: 0x06035C56 RID: 220246 RVA: 0x007519F8 File Offset: 0x0074FBF8
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

		// Token: 0x1700E0DA RID: 57562
		// (get) Token: 0x06035C57 RID: 220247 RVA: 0x00751A58 File Offset: 0x0074FC58
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

		// Token: 0x06035C58 RID: 220248 RVA: 0x00751A90 File Offset: 0x0074FC90
		public Span<byte> GetStartAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06035C59 RID: 220249 RVA: 0x00751AA0 File Offset: 0x0074FCA0
		public byte[] GetStartAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700E0DB RID: 57563
		// (get) Token: 0x06035C5A RID: 220250 RVA: 0x00751AB0 File Offset: 0x0074FCB0
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

		// Token: 0x06035C5B RID: 220251 RVA: 0x00751AF0 File Offset: 0x0074FCF0
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

		// Token: 0x06035C5C RID: 220252 RVA: 0x00751B50 File Offset: 0x0074FD50
		public static void StartITeleportTransitionWithCustomScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06035C5D RID: 220253 RVA: 0x00751B5A File Offset: 0x0074FD5A
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035C5E RID: 220254 RVA: 0x00751B65 File Offset: 0x0074FD65
		public static void AddScreenTypeType(FlatBufferBuilder builder, TCustomScreen screenTypeType)
		{
			builder.AddByte(1, (byte)screenTypeType, 0);
		}

		// Token: 0x06035C5F RID: 220255 RVA: 0x00751B70 File Offset: 0x0074FD70
		public static void AddScreenType(FlatBufferBuilder builder, int screenTypeOffset)
		{
			builder.AddOffset(2, screenTypeOffset, 0);
		}

		// Token: 0x06035C60 RID: 220256 RVA: 0x00751B7B File Offset: 0x0074FD7B
		public static void AddFadeInEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset)
		{
			builder.AddOffset(3, fadeInEffectOffset.Value, 0);
		}

		// Token: 0x06035C61 RID: 220257 RVA: 0x00751B8B File Offset: 0x0074FD8B
		public static void AddFadeOutEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset)
		{
			builder.AddOffset(4, fadeOutEffectOffset.Value, 0);
		}

		// Token: 0x06035C62 RID: 220258 RVA: 0x00751B9B File Offset: 0x0074FD9B
		public static void AddKeepTime(FlatBufferBuilder builder, float keepTime)
		{
			builder.AddFloat(5, keepTime, 0.0);
		}

		// Token: 0x06035C63 RID: 220259 RVA: 0x00751BAE File Offset: 0x0074FDAE
		public static void AddCustomShowUi(FlatBufferBuilder builder, Offset<ICustomShowUi> customShowUiOffset)
		{
			builder.AddOffset(6, customShowUiOffset.Value, 0);
		}

		// Token: 0x06035C64 RID: 220260 RVA: 0x00751BBE File Offset: 0x0074FDBE
		public static void AddStartAkEvent(FlatBufferBuilder builder, StringOffset startAkEventOffset)
		{
			builder.AddOffset(7, startAkEventOffset.Value, 0);
		}

		// Token: 0x06035C65 RID: 220261 RVA: 0x00751BCE File Offset: 0x0074FDCE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06035C66 RID: 220262 RVA: 0x00751BD9 File Offset: 0x0074FDD9
		public static Offset<ITeleportTransitionWithCustomScreen> EndITeleportTransitionWithCustomScreen(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithCustomScreen>(builder.EndTable());
		}

		// Token: 0x06035C67 RID: 220263 RVA: 0x00751BE8 File Offset: 0x0074FDE8
		public ITeleportTransitionWithCustomScreenT UnPack()
		{
			ITeleportTransitionWithCustomScreenT teleportTransitionWithCustomScreenT = new ITeleportTransitionWithCustomScreenT();
			this.UnPackTo(teleportTransitionWithCustomScreenT);
			return teleportTransitionWithCustomScreenT;
		}

		// Token: 0x06035C68 RID: 220264 RVA: 0x00751C04 File Offset: 0x0074FE04
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

		// Token: 0x06035C69 RID: 220265 RVA: 0x00751DB8 File Offset: 0x0074FFB8
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

		// Token: 0x040121E6 RID: 74214
		private Table __p;
	}
}
