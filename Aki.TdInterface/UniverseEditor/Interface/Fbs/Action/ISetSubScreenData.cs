using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200784B RID: 30795
	public struct ISetSubScreenData : IFlatbufferObject
	{
		// Token: 0x1700E1E5 RID: 57829
		// (get) Token: 0x06036273 RID: 221811 RVA: 0x0074105A File Offset: 0x0073F25A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036274 RID: 221812 RVA: 0x00741067 File Offset: 0x0073F267
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036275 RID: 221813 RVA: 0x00741070 File Offset: 0x0073F270
		public static ISetSubScreenData GetRootAsISetSubScreenData(ByteBuffer _bb)
		{
			return ISetSubScreenData.GetRootAsISetSubScreenData(_bb, default(ISetSubScreenData));
		}

		// Token: 0x06036276 RID: 221814 RVA: 0x0074108C File Offset: 0x0073F28C
		public static ISetSubScreenData GetRootAsISetSubScreenData(ByteBuffer _bb, ISetSubScreenData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036277 RID: 221815 RVA: 0x007410A9 File Offset: 0x0073F2A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036278 RID: 221816 RVA: 0x007410B8 File Offset: 0x0073F2B8
		public ISetSubScreenData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1E6 RID: 57830
		// (get) Token: 0x06036279 RID: 221817 RVA: 0x007410C8 File Offset: 0x0073F2C8
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

		// Token: 0x0603627A RID: 221818 RVA: 0x00741104 File Offset: 0x0073F304
		public TTable? TargetScreen<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603627B RID: 221819 RVA: 0x00741148 File Offset: 0x0073F348
		public IMainScreen TargetScreenAsIMainScreen()
		{
			return this.TargetScreen<IMainScreen>().Value;
		}

		// Token: 0x0603627C RID: 221820 RVA: 0x00741164 File Offset: 0x0073F364
		public ISubScreen TargetScreenAsISubScreen()
		{
			return this.TargetScreen<ISubScreen>().Value;
		}

		// Token: 0x1700E1E7 RID: 57831
		// (get) Token: 0x0603627D RID: 221821 RVA: 0x00741180 File Offset: 0x0073F380
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

		// Token: 0x1700E1E8 RID: 57832
		// (get) Token: 0x0603627E RID: 221822 RVA: 0x007411E0 File Offset: 0x0073F3E0
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

		// Token: 0x0603627F RID: 221823 RVA: 0x0074123E File Offset: 0x0073F43E
		public static Offset<ISetSubScreenData> CreateISetSubScreenData(FlatBufferBuilder builder, TScreen TargetScreen_type = TScreen.NONE, int TargetScreenOffset = 0, Offset<ISubScreenConfig> TargetSubScreenConfigOffset = default(Offset<ISubScreenConfig>), Offset<ISubScreenTransition> TransitionOffset = default(Offset<ISubScreenTransition>))
		{
			builder.StartTable(4);
			ISetSubScreenData.AddTransition(builder, TransitionOffset);
			ISetSubScreenData.AddTargetSubScreenConfig(builder, TargetSubScreenConfigOffset);
			ISetSubScreenData.AddTargetScreen(builder, TargetScreenOffset);
			ISetSubScreenData.AddTargetScreenType(builder, TargetScreen_type);
			return ISetSubScreenData.EndISetSubScreenData(builder);
		}

		// Token: 0x06036280 RID: 221824 RVA: 0x0074126A File Offset: 0x0073F46A
		public static void StartISetSubScreenData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036281 RID: 221825 RVA: 0x00741273 File Offset: 0x0073F473
		public static void AddTargetScreenType(FlatBufferBuilder builder, TScreen targetScreenType)
		{
			builder.AddByte(0, (byte)targetScreenType, 0);
		}

		// Token: 0x06036282 RID: 221826 RVA: 0x0074127E File Offset: 0x0073F47E
		public static void AddTargetScreen(FlatBufferBuilder builder, int targetScreenOffset)
		{
			builder.AddOffset(1, targetScreenOffset, 0);
		}

		// Token: 0x06036283 RID: 221827 RVA: 0x00741289 File Offset: 0x0073F489
		public static void AddTargetSubScreenConfig(FlatBufferBuilder builder, Offset<ISubScreenConfig> targetSubScreenConfigOffset)
		{
			builder.AddOffset(2, targetSubScreenConfigOffset.Value, 0);
		}

		// Token: 0x06036284 RID: 221828 RVA: 0x00741299 File Offset: 0x0073F499
		public static void AddTransition(FlatBufferBuilder builder, Offset<ISubScreenTransition> transitionOffset)
		{
			builder.AddOffset(3, transitionOffset.Value, 0);
		}

		// Token: 0x06036285 RID: 221829 RVA: 0x007412A9 File Offset: 0x0073F4A9
		public static Offset<ISetSubScreenData> EndISetSubScreenData(FlatBufferBuilder builder)
		{
			return new Offset<ISetSubScreenData>(builder.EndTable());
		}

		// Token: 0x06036286 RID: 221830 RVA: 0x007412B8 File Offset: 0x0073F4B8
		public ISetSubScreenDataT UnPack()
		{
			ISetSubScreenDataT setSubScreenDataT = new ISetSubScreenDataT();
			this.UnPackTo(setSubScreenDataT);
			return setSubScreenDataT;
		}

		// Token: 0x06036287 RID: 221831 RVA: 0x007412D4 File Offset: 0x0073F4D4
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

		// Token: 0x06036288 RID: 221832 RVA: 0x007413E0 File Offset: 0x0073F5E0
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

		// Token: 0x04012AD2 RID: 76498
		private Table __p;
	}
}
