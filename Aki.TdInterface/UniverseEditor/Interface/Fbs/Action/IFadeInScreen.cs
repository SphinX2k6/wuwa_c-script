using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006792 RID: 26514
	public struct IFadeInScreen : IFlatbufferObject
	{
		// Token: 0x1700C4C6 RID: 50374
		// (get) Token: 0x0602E209 RID: 188937 RVA: 0x0064CE9A File Offset: 0x0064B09A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E20A RID: 188938 RVA: 0x0064CEA7 File Offset: 0x0064B0A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E20B RID: 188939 RVA: 0x0064CEB0 File Offset: 0x0064B0B0
		public static IFadeInScreen GetRootAsIFadeInScreen(ByteBuffer _bb)
		{
			return IFadeInScreen.GetRootAsIFadeInScreen(_bb, default(IFadeInScreen));
		}

		// Token: 0x0602E20C RID: 188940 RVA: 0x0064CECC File Offset: 0x0064B0CC
		public static IFadeInScreen GetRootAsIFadeInScreen(ByteBuffer _bb, IFadeInScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E20D RID: 188941 RVA: 0x0064CEE9 File Offset: 0x0064B0E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E20E RID: 188942 RVA: 0x0064CEF8 File Offset: 0x0064B0F8
		public IFadeInScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4C7 RID: 50375
		// (get) Token: 0x0602E20F RID: 188943 RVA: 0x0064CF08 File Offset: 0x0064B108
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

		// Token: 0x1700C4C8 RID: 50376
		// (get) Token: 0x0602E210 RID: 188944 RVA: 0x0064CF44 File Offset: 0x0064B144
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

		// Token: 0x1700C4C9 RID: 50377
		// (get) Token: 0x0602E211 RID: 188945 RVA: 0x0064CFA4 File Offset: 0x0064B1A4
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

		// Token: 0x1700C4CA RID: 50378
		// (get) Token: 0x0602E212 RID: 188946 RVA: 0x0064CFE0 File Offset: 0x0064B1E0
		public bool KeepFadeAfterTreeEnd
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C4CB RID: 50379
		// (get) Token: 0x0602E213 RID: 188947 RVA: 0x0064D020 File Offset: 0x0064B220
		public bool KeepFadeAfterTreeRollBack
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C4CC RID: 50380
		// (get) Token: 0x0602E214 RID: 188948 RVA: 0x0064D060 File Offset: 0x0064B260
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

		// Token: 0x0602E215 RID: 188949 RVA: 0x0064D0A0 File Offset: 0x0064B2A0
		public TTable? FadeBackground<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E216 RID: 188950 RVA: 0x0064D0E8 File Offset: 0x0064B2E8
		public IFadeBackgroundImage FadeBackgroundAsIFadeBackgroundImage()
		{
			return this.FadeBackground<IFadeBackgroundImage>().Value;
		}

		// Token: 0x0602E217 RID: 188951 RVA: 0x0064D104 File Offset: 0x0064B304
		public IFadeBackgroundSpine FadeBackgroundAsIFadeBackgroundSpine()
		{
			return this.FadeBackground<IFadeBackgroundSpine>().Value;
		}

		// Token: 0x0602E218 RID: 188952 RVA: 0x0064D120 File Offset: 0x0064B320
		public IFadeBackgroundUiPrefab FadeBackgroundAsIFadeBackgroundUiPrefab()
		{
			return this.FadeBackground<IFadeBackgroundUiPrefab>().Value;
		}

		// Token: 0x1700C4CD RID: 50381
		// (get) Token: 0x0602E219 RID: 188953 RVA: 0x0064D13C File Offset: 0x0064B33C
		public bool OnlyLowMemoryDeviceExecute
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C4CE RID: 50382
		// (get) Token: 0x0602E21A RID: 188954 RVA: 0x0064D17C File Offset: 0x0064B37C
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

		// Token: 0x0602E21B RID: 188955 RVA: 0x0064D1BC File Offset: 0x0064B3BC
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

		// Token: 0x0602E21C RID: 188956 RVA: 0x0064D21C File Offset: 0x0064B41C
		public static void StartIFadeInScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602E21D RID: 188957 RVA: 0x0064D226 File Offset: 0x0064B426
		public static void AddTypeOverride(FlatBufferBuilder builder, EFadeUiOverride typeOverride)
		{
			builder.AddByte(0, (byte)typeOverride, 0);
		}

		// Token: 0x0602E21E RID: 188958 RVA: 0x0064D231 File Offset: 0x0064B431
		public static void AddEase(FlatBufferBuilder builder, Offset<IEaseData> easeOffset)
		{
			builder.AddOffset(1, easeOffset.Value, 0);
		}

		// Token: 0x0602E21F RID: 188959 RVA: 0x0064D241 File Offset: 0x0064B441
		public static void AddScreenType(FlatBufferBuilder builder, EFadeInScreenShowType screenType)
		{
			builder.AddByte(2, (byte)screenType, 0);
		}

		// Token: 0x0602E220 RID: 188960 RVA: 0x0064D24C File Offset: 0x0064B44C
		public static void AddKeepFadeAfterTreeEnd(FlatBufferBuilder builder, bool keepFadeAfterTreeEnd)
		{
			builder.AddBool(3, keepFadeAfterTreeEnd, false);
		}

		// Token: 0x0602E221 RID: 188961 RVA: 0x0064D257 File Offset: 0x0064B457
		public static void AddKeepFadeAfterTreeRollBack(FlatBufferBuilder builder, bool keepFadeAfterTreeRollBack)
		{
			builder.AddBool(4, keepFadeAfterTreeRollBack, false);
		}

		// Token: 0x0602E222 RID: 188962 RVA: 0x0064D262 File Offset: 0x0064B462
		public static void AddFadeBackgroundType(FlatBufferBuilder builder, TFadeBackground fadeBackgroundType)
		{
			builder.AddByte(5, (byte)fadeBackgroundType, 0);
		}

		// Token: 0x0602E223 RID: 188963 RVA: 0x0064D26D File Offset: 0x0064B46D
		public static void AddFadeBackground(FlatBufferBuilder builder, int fadeBackgroundOffset)
		{
			builder.AddOffset(6, fadeBackgroundOffset, 0);
		}

		// Token: 0x0602E224 RID: 188964 RVA: 0x0064D278 File Offset: 0x0064B478
		public static void AddOnlyLowMemoryDeviceExecute(FlatBufferBuilder builder, bool onlyLowMemoryDeviceExecute)
		{
			builder.AddBool(7, onlyLowMemoryDeviceExecute, false);
		}

		// Token: 0x0602E225 RID: 188965 RVA: 0x0064D283 File Offset: 0x0064B483
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602E226 RID: 188966 RVA: 0x0064D28E File Offset: 0x0064B48E
		public static Offset<IFadeInScreen> EndIFadeInScreen(FlatBufferBuilder builder)
		{
			return new Offset<IFadeInScreen>(builder.EndTable());
		}

		// Token: 0x0602E227 RID: 188967 RVA: 0x0064D29C File Offset: 0x0064B49C
		public IFadeInScreenT UnPack()
		{
			IFadeInScreenT fadeInScreenT = new IFadeInScreenT();
			this.UnPackTo(fadeInScreenT);
			return fadeInScreenT;
		}

		// Token: 0x0602E228 RID: 188968 RVA: 0x0064D2B8 File Offset: 0x0064B4B8
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

		// Token: 0x0602E229 RID: 188969 RVA: 0x0064D420 File Offset: 0x0064B620
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

		// Token: 0x04010E9A RID: 69274
		private Table __p;
	}
}
