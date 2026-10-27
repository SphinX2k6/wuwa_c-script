using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707F RID: 28799
	public struct ISetSubScreenData : IFlatbufferObject
	{
		// Token: 0x1700D602 RID: 54786
		// (get) Token: 0x06032FD1 RID: 208849 RVA: 0x006E0A4E File Offset: 0x006DEC4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032FD2 RID: 208850 RVA: 0x006E0A5B File Offset: 0x006DEC5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032FD3 RID: 208851 RVA: 0x006E0A64 File Offset: 0x006DEC64
		public static ISetSubScreenData GetRootAsISetSubScreenData(ByteBuffer _bb)
		{
			return ISetSubScreenData.GetRootAsISetSubScreenData(_bb, default(ISetSubScreenData));
		}

		// Token: 0x06032FD4 RID: 208852 RVA: 0x006E0A80 File Offset: 0x006DEC80
		public static ISetSubScreenData GetRootAsISetSubScreenData(ByteBuffer _bb, ISetSubScreenData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032FD5 RID: 208853 RVA: 0x006E0A9D File Offset: 0x006DEC9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032FD6 RID: 208854 RVA: 0x006E0AAC File Offset: 0x006DECAC
		public ISetSubScreenData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D603 RID: 54787
		// (get) Token: 0x06032FD7 RID: 208855 RVA: 0x006E0ABC File Offset: 0x006DECBC
		public TScreen TargetScreenType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TScreen.NONE;
				}
				return (TScreen)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032FD8 RID: 208856 RVA: 0x006E0AF8 File Offset: 0x006DECF8
		public TTable? TargetScreen<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032FD9 RID: 208857 RVA: 0x006E0B3C File Offset: 0x006DED3C
		public IMainScreen TargetScreenAsIMainScreen()
		{
			return this.TargetScreen<IMainScreen>().Value;
		}

		// Token: 0x06032FDA RID: 208858 RVA: 0x006E0B58 File Offset: 0x006DED58
		public ISubScreen TargetScreenAsISubScreen()
		{
			return this.TargetScreen<ISubScreen>().Value;
		}

		// Token: 0x1700D604 RID: 54788
		// (get) Token: 0x06032FDB RID: 208859 RVA: 0x006E0B74 File Offset: 0x006DED74
		public ISubScreenConfig? TargetSubScreenConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISubScreenConfig?(default(ISubScreenConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D605 RID: 54789
		// (get) Token: 0x06032FDC RID: 208860 RVA: 0x006E0BD4 File Offset: 0x006DEDD4
		public ISubScreenTransition? Transition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISubScreenTransition?(default(ISubScreenTransition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032FDD RID: 208861 RVA: 0x006E0C32 File Offset: 0x006DEE32
		public static Offset<ISetSubScreenData> CreateISetSubScreenData(FlatBufferBuilder builder, TScreen TargetScreen_type = TScreen.NONE, int TargetScreenOffset = 0, Offset<ISubScreenConfig> TargetSubScreenConfigOffset = default(Offset<ISubScreenConfig>), Offset<ISubScreenTransition> TransitionOffset = default(Offset<ISubScreenTransition>))
		{
			builder.StartTable(4);
			ISetSubScreenData.AddTransition(builder, TransitionOffset);
			ISetSubScreenData.AddTargetSubScreenConfig(builder, TargetSubScreenConfigOffset);
			ISetSubScreenData.AddTargetScreen(builder, TargetScreenOffset);
			ISetSubScreenData.AddTargetScreenType(builder, TargetScreen_type);
			return ISetSubScreenData.EndISetSubScreenData(builder);
		}

		// Token: 0x06032FDE RID: 208862 RVA: 0x006E0C5E File Offset: 0x006DEE5E
		public static void StartISetSubScreenData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032FDF RID: 208863 RVA: 0x006E0C67 File Offset: 0x006DEE67
		public static void AddTargetScreenType(FlatBufferBuilder builder, TScreen targetScreenType)
		{
			builder.AddByte(0, (byte)targetScreenType, 0);
		}

		// Token: 0x06032FE0 RID: 208864 RVA: 0x006E0C72 File Offset: 0x006DEE72
		public static void AddTargetScreen(FlatBufferBuilder builder, int targetScreenOffset)
		{
			builder.AddOffset(1, targetScreenOffset, 0);
		}

		// Token: 0x06032FE1 RID: 208865 RVA: 0x006E0C7D File Offset: 0x006DEE7D
		public static void AddTargetSubScreenConfig(FlatBufferBuilder builder, Offset<ISubScreenConfig> targetSubScreenConfigOffset)
		{
			builder.AddOffset(2, targetSubScreenConfigOffset.Value, 0);
		}

		// Token: 0x06032FE2 RID: 208866 RVA: 0x006E0C8D File Offset: 0x006DEE8D
		public static void AddTransition(FlatBufferBuilder builder, Offset<ISubScreenTransition> transitionOffset)
		{
			builder.AddOffset(3, transitionOffset.Value, 0);
		}

		// Token: 0x06032FE3 RID: 208867 RVA: 0x006E0C9D File Offset: 0x006DEE9D
		public static Offset<ISetSubScreenData> EndISetSubScreenData(FlatBufferBuilder builder)
		{
			return new Offset<ISetSubScreenData>(builder.EndTable());
		}

		// Token: 0x06032FE4 RID: 208868 RVA: 0x006E0CAC File Offset: 0x006DEEAC
		public ISetSubScreenDataT UnPack()
		{
			ISetSubScreenDataT setSubScreenDataT = new ISetSubScreenDataT();
			this.UnPackTo(setSubScreenDataT);
			return setSubScreenDataT;
		}

		// Token: 0x06032FE5 RID: 208869 RVA: 0x006E0CC8 File Offset: 0x006DEEC8
		public void UnPackTo(ISetSubScreenDataT _o)
		{
			_o.TargetScreen = new TScreenUnion();
			_o.TargetScreen.Type = this.TargetScreenType;
			TScreen targetScreenType = this.TargetScreenType;
			if (targetScreenType != TScreen.IMainScreen)
			{
				if (targetScreenType == TScreen.ISubScreen)
				{
					_o.TargetScreen.Value = ((this.TargetScreen<ISubScreen>() != null) ? this.TargetScreen<ISubScreen>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.TargetScreen.Value = ((this.TargetScreen<IMainScreen>() != null) ? this.TargetScreen<IMainScreen>().Value.UnPack() : null);
			}
			_o.TargetSubScreenConfig = ((this.TargetSubScreenConfig != null) ? this.TargetSubScreenConfig.Value.UnPack() : null);
			_o.Transition = ((this.Transition != null) ? this.Transition.Value.UnPack() : null);
		}

		// Token: 0x06032FE6 RID: 208870 RVA: 0x006E0DD4 File Offset: 0x006DEFD4
		public static Offset<ISetSubScreenData> Pack(FlatBufferBuilder builder, ISetSubScreenDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetSubScreenData>);
			}
			TScreen targetScreen_type = (_o.TargetScreen == null) ? TScreen.NONE : _o.TargetScreen.Type;
			int targetScreenOffset = (_o.TargetScreen == null) ? 0 : TScreenUnion.Pack(builder, _o.TargetScreen);
			Offset<ISubScreenConfig> targetSubScreenConfigOffset = (_o.TargetSubScreenConfig == null) ? default(Offset<ISubScreenConfig>) : ISubScreenConfig.Pack(builder, _o.TargetSubScreenConfig);
			Offset<ISubScreenTransition> transitionOffset = (_o.Transition == null) ? default(Offset<ISubScreenTransition>) : ISubScreenTransition.Pack(builder, _o.Transition);
			return ISetSubScreenData.CreateISetSubScreenData(builder, targetScreen_type, targetScreenOffset, targetSubScreenConfigOffset, transitionOffset);
		}

		// Token: 0x04011AE4 RID: 72420
		private Table __p;
	}
}
