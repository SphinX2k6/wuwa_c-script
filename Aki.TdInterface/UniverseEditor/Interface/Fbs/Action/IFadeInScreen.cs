using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E12 RID: 28178
	public struct IFadeInScreen : IFlatbufferObject
	{
		// Token: 0x1700CE7C RID: 52860
		// (get) Token: 0x06030A4F RID: 199247 RVA: 0x0069A5DE File Offset: 0x006987DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A50 RID: 199248 RVA: 0x0069A5EB File Offset: 0x006987EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A51 RID: 199249 RVA: 0x0069A5F4 File Offset: 0x006987F4
		public static IFadeInScreen GetRootAsIFadeInScreen(ByteBuffer _bb)
		{
			return IFadeInScreen.GetRootAsIFadeInScreen(_bb, default(IFadeInScreen));
		}

		// Token: 0x06030A52 RID: 199250 RVA: 0x0069A610 File Offset: 0x00698810
		public static IFadeInScreen GetRootAsIFadeInScreen(ByteBuffer _bb, IFadeInScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A53 RID: 199251 RVA: 0x0069A62D File Offset: 0x0069882D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A54 RID: 199252 RVA: 0x0069A63C File Offset: 0x0069883C
		public IFadeInScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE7D RID: 52861
		// (get) Token: 0x06030A55 RID: 199253 RVA: 0x0069A64C File Offset: 0x0069884C
		public EFadeUiOverride TypeOverride
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeUiOverride.ShowTalkDialog;
				}
				return (EFadeUiOverride)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE7E RID: 52862
		// (get) Token: 0x06030A56 RID: 199254 RVA: 0x0069A688 File Offset: 0x00698888
		public IEaseData? Ease
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEaseData?(default(IEaseData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CE7F RID: 52863
		// (get) Token: 0x06030A57 RID: 199255 RVA: 0x0069A6E8 File Offset: 0x006988E8
		public EFadeInScreenShowType ScreenType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EFadeInScreenShowType.White;
				}
				return (EFadeInScreenShowType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE80 RID: 52864
		// (get) Token: 0x06030A58 RID: 199256 RVA: 0x0069A724 File Offset: 0x00698924
		public bool KeepFadeAfterTreeEnd
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE81 RID: 52865
		// (get) Token: 0x06030A59 RID: 199257 RVA: 0x0069A764 File Offset: 0x00698964
		public bool KeepFadeAfterTreeRollBack
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE82 RID: 52866
		// (get) Token: 0x06030A5A RID: 199258 RVA: 0x0069A7A4 File Offset: 0x006989A4
		public TFadeBackground FadeBackgroundType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TFadeBackground.NONE;
				}
				return (TFadeBackground)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030A5B RID: 199259 RVA: 0x0069A7E4 File Offset: 0x006989E4
		public TTable? FadeBackground<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030A5C RID: 199260 RVA: 0x0069A82C File Offset: 0x00698A2C
		public IFadeBackgroundImage FadeBackgroundAsIFadeBackgroundImage()
		{
			return this.FadeBackground<IFadeBackgroundImage>().Value;
		}

		// Token: 0x06030A5D RID: 199261 RVA: 0x0069A848 File Offset: 0x00698A48
		public IFadeBackgroundSpine FadeBackgroundAsIFadeBackgroundSpine()
		{
			return this.FadeBackground<IFadeBackgroundSpine>().Value;
		}

		// Token: 0x06030A5E RID: 199262 RVA: 0x0069A864 File Offset: 0x00698A64
		public IFadeBackgroundUiPrefab FadeBackgroundAsIFadeBackgroundUiPrefab()
		{
			return this.FadeBackground<IFadeBackgroundUiPrefab>().Value;
		}

		// Token: 0x1700CE83 RID: 52867
		// (get) Token: 0x06030A5F RID: 199263 RVA: 0x0069A880 File Offset: 0x00698A80
		public bool OnlyLowMemoryDeviceExecute
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE84 RID: 52868
		// (get) Token: 0x06030A60 RID: 199264 RVA: 0x0069A8C0 File Offset: 0x00698AC0
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

		// Token: 0x06030A61 RID: 199265 RVA: 0x0069A900 File Offset: 0x00698B00
		public static Offset<IFadeInScreen> CreateIFadeInScreen(FlatBufferBuilder builder, EFadeUiOverride TypeOverride = EFadeUiOverride.ShowTalkDialog, Offset<IEaseData> EaseOffset = default(Offset<IEaseData>), EFadeInScreenShowType ScreenType = EFadeInScreenShowType.White, bool KeepFadeAfterTreeEnd = false, bool KeepFadeAfterTreeRollBack = false, TFadeBackground FadeBackground_type = TFadeBackground.NONE, int FadeBackgroundOffset = 0, bool OnlyLowMemoryDeviceExecute = false, byte NullMask = 0)
		{
			builder.StartTable(9);
			IFadeInScreen.AddFadeBackground(builder, FadeBackgroundOffset);
			IFadeInScreen.AddEase(builder, EaseOffset);
			IFadeInScreen.AddNullMask(builder, NullMask);
			IFadeInScreen.AddOnlyLowMemoryDeviceExecute(builder, OnlyLowMemoryDeviceExecute);
			IFadeInScreen.AddFadeBackgroundType(builder, FadeBackground_type);
			IFadeInScreen.AddKeepFadeAfterTreeRollBack(builder, KeepFadeAfterTreeRollBack);
			IFadeInScreen.AddKeepFadeAfterTreeEnd(builder, KeepFadeAfterTreeEnd);
			IFadeInScreen.AddScreenType(builder, ScreenType);
			IFadeInScreen.AddTypeOverride(builder, TypeOverride);
			return IFadeInScreen.EndIFadeInScreen(builder);
		}

		// Token: 0x06030A62 RID: 199266 RVA: 0x0069A960 File Offset: 0x00698B60
		public static void StartIFadeInScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06030A63 RID: 199267 RVA: 0x0069A96A File Offset: 0x00698B6A
		public static void AddTypeOverride(FlatBufferBuilder builder, EFadeUiOverride typeOverride)
		{
			builder.AddByte(0, (byte)typeOverride, 0);
		}

		// Token: 0x06030A64 RID: 199268 RVA: 0x0069A975 File Offset: 0x00698B75
		public static void AddEase(FlatBufferBuilder builder, Offset<IEaseData> easeOffset)
		{
			builder.AddOffset(1, easeOffset.Value, 0);
		}

		// Token: 0x06030A65 RID: 199269 RVA: 0x0069A985 File Offset: 0x00698B85
		public static void AddScreenType(FlatBufferBuilder builder, EFadeInScreenShowType screenType)
		{
			builder.AddByte(2, (byte)screenType, 0);
		}

		// Token: 0x06030A66 RID: 199270 RVA: 0x0069A990 File Offset: 0x00698B90
		public static void AddKeepFadeAfterTreeEnd(FlatBufferBuilder builder, bool keepFadeAfterTreeEnd)
		{
			builder.AddBool(3, keepFadeAfterTreeEnd, false);
		}

		// Token: 0x06030A67 RID: 199271 RVA: 0x0069A99B File Offset: 0x00698B9B
		public static void AddKeepFadeAfterTreeRollBack(FlatBufferBuilder builder, bool keepFadeAfterTreeRollBack)
		{
			builder.AddBool(4, keepFadeAfterTreeRollBack, false);
		}

		// Token: 0x06030A68 RID: 199272 RVA: 0x0069A9A6 File Offset: 0x00698BA6
		public static void AddFadeBackgroundType(FlatBufferBuilder builder, TFadeBackground fadeBackgroundType)
		{
			builder.AddByte(5, (byte)fadeBackgroundType, 0);
		}

		// Token: 0x06030A69 RID: 199273 RVA: 0x0069A9B1 File Offset: 0x00698BB1
		public static void AddFadeBackground(FlatBufferBuilder builder, int fadeBackgroundOffset)
		{
			builder.AddOffset(6, fadeBackgroundOffset, 0);
		}

		// Token: 0x06030A6A RID: 199274 RVA: 0x0069A9BC File Offset: 0x00698BBC
		public static void AddOnlyLowMemoryDeviceExecute(FlatBufferBuilder builder, bool onlyLowMemoryDeviceExecute)
		{
			builder.AddBool(7, onlyLowMemoryDeviceExecute, false);
		}

		// Token: 0x06030A6B RID: 199275 RVA: 0x0069A9C7 File Offset: 0x00698BC7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06030A6C RID: 199276 RVA: 0x0069A9D2 File Offset: 0x00698BD2
		public static Offset<IFadeInScreen> EndIFadeInScreen(FlatBufferBuilder builder)
		{
			return new Offset<IFadeInScreen>(builder.EndTable());
		}

		// Token: 0x06030A6D RID: 199277 RVA: 0x0069A9E0 File Offset: 0x00698BE0
		public IFadeInScreenT UnPack()
		{
			IFadeInScreenT fadeInScreenT = new IFadeInScreenT();
			this.UnPackTo(fadeInScreenT);
			return fadeInScreenT;
		}

		// Token: 0x06030A6E RID: 199278 RVA: 0x0069A9FC File Offset: 0x00698BFC
		public void UnPackTo(IFadeInScreenT _o)
		{
			_o.TypeOverride = this.TypeOverride;
			_o.Ease = ((this.Ease != null) ? this.Ease.Value.UnPack() : null);
			_o.ScreenType = this.ScreenType;
			_o.KeepFadeAfterTreeEnd = this.KeepFadeAfterTreeEnd;
			_o.KeepFadeAfterTreeRollBack = this.KeepFadeAfterTreeRollBack;
			_o.FadeBackground = new TFadeBackgroundUnion();
			_o.FadeBackground.Type = this.FadeBackgroundType;
			switch (this.FadeBackgroundType)
			{
			case TFadeBackground.IFadeBackgroundImage:
				_o.FadeBackground.Value = ((this.FadeBackground<IFadeBackgroundImage>() != null) ? this.FadeBackground<IFadeBackgroundImage>().Value.UnPack() : null);
				break;
			case TFadeBackground.IFadeBackgroundSpine:
				_o.FadeBackground.Value = ((this.FadeBackground<IFadeBackgroundSpine>() != null) ? this.FadeBackground<IFadeBackgroundSpine>().Value.UnPack() : null);
				break;
			case TFadeBackground.IFadeBackgroundUiPrefab:
				_o.FadeBackground.Value = ((this.FadeBackground<IFadeBackgroundUiPrefab>() != null) ? this.FadeBackground<IFadeBackgroundUiPrefab>().Value.UnPack() : null);
				break;
			}
			_o.OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030A6F RID: 199279 RVA: 0x0069AB64 File Offset: 0x00698D64
		public static Offset<IFadeInScreen> Pack(FlatBufferBuilder builder, IFadeInScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeInScreen>);
			}
			Offset<IEaseData> easeOffset = (_o.Ease == null) ? default(Offset<IEaseData>) : IEaseData.Pack(builder, _o.Ease);
			TFadeBackground fadeBackground_type = (_o.FadeBackground == null) ? TFadeBackground.NONE : _o.FadeBackground.Type;
			int fadeBackgroundOffset = (_o.FadeBackground == null) ? 0 : TFadeBackgroundUnion.Pack(builder, _o.FadeBackground);
			return IFadeInScreen.CreateIFadeInScreen(builder, _o.TypeOverride, easeOffset, _o.ScreenType, _o.KeepFadeAfterTreeEnd, _o.KeepFadeAfterTreeRollBack, fadeBackground_type, fadeBackgroundOffset, _o.OnlyLowMemoryDeviceExecute, _o.NullMask);
		}

		// Token: 0x04011CCC RID: 72908
		private Table __p;
	}
}
