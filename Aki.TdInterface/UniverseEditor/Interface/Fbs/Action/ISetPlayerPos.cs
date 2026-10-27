using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007055 RID: 28757
	public struct ISetPlayerPos : IFlatbufferObject
	{
		// Token: 0x1700D596 RID: 54678
		// (get) Token: 0x06032E35 RID: 208437 RVA: 0x006DD116 File Offset: 0x006DB316
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032E36 RID: 208438 RVA: 0x006DD123 File Offset: 0x006DB323
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032E37 RID: 208439 RVA: 0x006DD12C File Offset: 0x006DB32C
		public static ISetPlayerPos GetRootAsISetPlayerPos(ByteBuffer _bb)
		{
			return ISetPlayerPos.GetRootAsISetPlayerPos(_bb, default(ISetPlayerPos));
		}

		// Token: 0x06032E38 RID: 208440 RVA: 0x006DD148 File Offset: 0x006DB348
		public static ISetPlayerPos GetRootAsISetPlayerPos(ByteBuffer _bb, ISetPlayerPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032E39 RID: 208441 RVA: 0x006DD165 File Offset: 0x006DB365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032E3A RID: 208442 RVA: 0x006DD174 File Offset: 0x006DB374
		public ISetPlayerPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D597 RID: 54679
		// (get) Token: 0x06032E3B RID: 208443 RVA: 0x006DD184 File Offset: 0x006DB384
		public TTeleportConfig TelePortConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTeleportConfig.NONE;
				}
				return (TTeleportConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E3C RID: 208444 RVA: 0x006DD1C0 File Offset: 0x006DB3C0
		public TTable? TelePortConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032E3D RID: 208445 RVA: 0x006DD204 File Offset: 0x006DB404
		public IFixedPos TelePortConfigAsIFixedPos()
		{
			return this.TelePortConfig<IFixedPos>().Value;
		}

		// Token: 0x06032E3E RID: 208446 RVA: 0x006DD220 File Offset: 0x006DB420
		public IGravityFlipFixedPos TelePortConfigAsIGravityFlipFixedPos()
		{
			return this.TelePortConfig<IGravityFlipFixedPos>().Value;
		}

		// Token: 0x06032E3F RID: 208447 RVA: 0x006DD23C File Offset: 0x006DB43C
		public INearestEntity TelePortConfigAsINearestEntity()
		{
			return this.TelePortConfig<INearestEntity>().Value;
		}

		// Token: 0x06032E40 RID: 208448 RVA: 0x006DD258 File Offset: 0x006DB458
		public ISafePos TelePortConfigAsISafePos()
		{
			return this.TelePortConfig<ISafePos>().Value;
		}

		// Token: 0x1700D598 RID: 54680
		// (get) Token: 0x06032E41 RID: 208449 RVA: 0x006DD274 File Offset: 0x006DB474
		public ITelePortAfterTimeOut? TeammateTeleportConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITelePortAfterTimeOut?(default(ITelePortAfterTimeOut).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D599 RID: 54681
		// (get) Token: 0x06032E42 RID: 208450 RVA: 0x006DD2D4 File Offset: 0x006DB4D4
		public TTeleportTransitionOption TransitionOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E43 RID: 208451 RVA: 0x006DD314 File Offset: 0x006DB514
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032E44 RID: 208452 RVA: 0x006DD35C File Offset: 0x006DB55C
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06032E45 RID: 208453 RVA: 0x006DD378 File Offset: 0x006DB578
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06032E46 RID: 208454 RVA: 0x006DD394 File Offset: 0x006DB594
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06032E47 RID: 208455 RVA: 0x006DD3B0 File Offset: 0x006DB5B0
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06032E48 RID: 208456 RVA: 0x006DD3CC File Offset: 0x006DB5CC
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06032E49 RID: 208457 RVA: 0x006DD3E8 File Offset: 0x006DB5E8
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06032E4A RID: 208458 RVA: 0x006DD404 File Offset: 0x006DB604
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06032E4B RID: 208459 RVA: 0x006DD420 File Offset: 0x006DB620
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06032E4C RID: 208460 RVA: 0x006DD43C File Offset: 0x006DB63C
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06032E4D RID: 208461 RVA: 0x006DD458 File Offset: 0x006DB658
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06032E4E RID: 208462 RVA: 0x006DD474 File Offset: 0x006DB674
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700D59A RID: 54682
		// (get) Token: 0x06032E4F RID: 208463 RVA: 0x006DD490 File Offset: 0x006DB690
		public bool DisableAutoFadeInScreen
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D59B RID: 54683
		// (get) Token: 0x06032E50 RID: 208464 RVA: 0x006DD4D0 File Offset: 0x006DB6D0
		public bool OnlinePreciseTransport
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D59C RID: 54684
		// (get) Token: 0x06032E51 RID: 208465 RVA: 0x006DD510 File Offset: 0x006DB710
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E52 RID: 208466 RVA: 0x006DD550 File Offset: 0x006DB750
		public static Offset<ISetPlayerPos> CreateISetPlayerPos(FlatBufferBuilder builder, TTeleportConfig TelePortConfig_type = TTeleportConfig.NONE, int TelePortConfigOffset = 0, Offset<ITelePortAfterTimeOut> TeammateTeleportConfigOffset = default(Offset<ITelePortAfterTimeOut>), TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0, bool DisableAutoFadeInScreen = false, bool OnlinePreciseTransport = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			ISetPlayerPos.AddTransitionOption(builder, TransitionOptionOffset);
			ISetPlayerPos.AddTeammateTeleportConfig(builder, TeammateTeleportConfigOffset);
			ISetPlayerPos.AddTelePortConfig(builder, TelePortConfigOffset);
			ISetPlayerPos.AddNullMask(builder, NullMask);
			ISetPlayerPos.AddOnlinePreciseTransport(builder, OnlinePreciseTransport);
			ISetPlayerPos.AddDisableAutoFadeInScreen(builder, DisableAutoFadeInScreen);
			ISetPlayerPos.AddTransitionOptionType(builder, TransitionOption_type);
			ISetPlayerPos.AddTelePortConfigType(builder, TelePortConfig_type);
			return ISetPlayerPos.EndISetPlayerPos(builder);
		}

		// Token: 0x06032E53 RID: 208467 RVA: 0x006DD5A7 File Offset: 0x006DB7A7
		public static void StartISetPlayerPos(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06032E54 RID: 208468 RVA: 0x006DD5B0 File Offset: 0x006DB7B0
		public static void AddTelePortConfigType(FlatBufferBuilder builder, TTeleportConfig telePortConfigType)
		{
			builder.AddByte(0, (byte)telePortConfigType, 0);
		}

		// Token: 0x06032E55 RID: 208469 RVA: 0x006DD5BB File Offset: 0x006DB7BB
		public static void AddTelePortConfig(FlatBufferBuilder builder, int telePortConfigOffset)
		{
			builder.AddOffset(1, telePortConfigOffset, 0);
		}

		// Token: 0x06032E56 RID: 208470 RVA: 0x006DD5C6 File Offset: 0x006DB7C6
		public static void AddTeammateTeleportConfig(FlatBufferBuilder builder, Offset<ITelePortAfterTimeOut> teammateTeleportConfigOffset)
		{
			builder.AddOffset(2, teammateTeleportConfigOffset.Value, 0);
		}

		// Token: 0x06032E57 RID: 208471 RVA: 0x006DD5D6 File Offset: 0x006DB7D6
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(3, (byte)transitionOptionType, 0);
		}

		// Token: 0x06032E58 RID: 208472 RVA: 0x006DD5E1 File Offset: 0x006DB7E1
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(4, transitionOptionOffset, 0);
		}

		// Token: 0x06032E59 RID: 208473 RVA: 0x006DD5EC File Offset: 0x006DB7EC
		public static void AddDisableAutoFadeInScreen(FlatBufferBuilder builder, bool disableAutoFadeInScreen)
		{
			builder.AddBool(5, disableAutoFadeInScreen, false);
		}

		// Token: 0x06032E5A RID: 208474 RVA: 0x006DD5F7 File Offset: 0x006DB7F7
		public static void AddOnlinePreciseTransport(FlatBufferBuilder builder, bool onlinePreciseTransport)
		{
			builder.AddBool(6, onlinePreciseTransport, false);
		}

		// Token: 0x06032E5B RID: 208475 RVA: 0x006DD602 File Offset: 0x006DB802
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06032E5C RID: 208476 RVA: 0x006DD60D File Offset: 0x006DB80D
		public static Offset<ISetPlayerPos> EndISetPlayerPos(FlatBufferBuilder builder)
		{
			return new Offset<ISetPlayerPos>(builder.EndTable());
		}

		// Token: 0x06032E5D RID: 208477 RVA: 0x006DD61C File Offset: 0x006DB81C
		public ISetPlayerPosT UnPack()
		{
			ISetPlayerPosT setPlayerPosT = new ISetPlayerPosT();
			this.UnPackTo(setPlayerPosT);
			return setPlayerPosT;
		}

		// Token: 0x06032E5E RID: 208478 RVA: 0x006DD638 File Offset: 0x006DB838
		public void UnPackTo(ISetPlayerPosT _o)
		{
			_o.TelePortConfig = new TTeleportConfigUnion();
			_o.TelePortConfig.Type = this.TelePortConfigType;
			switch (this.TelePortConfigType)
			{
			case TTeleportConfig.IFixedPos:
				_o.TelePortConfig.Value = ((this.TelePortConfig<IFixedPos>() != null) ? this.TelePortConfig<IFixedPos>().Value.UnPack() : null);
				break;
			case TTeleportConfig.IGravityFlipFixedPos:
				_o.TelePortConfig.Value = ((this.TelePortConfig<IGravityFlipFixedPos>() != null) ? this.TelePortConfig<IGravityFlipFixedPos>().Value.UnPack() : null);
				break;
			case TTeleportConfig.INearestEntity:
				_o.TelePortConfig.Value = ((this.TelePortConfig<INearestEntity>() != null) ? this.TelePortConfig<INearestEntity>().Value.UnPack() : null);
				break;
			case TTeleportConfig.ISafePos:
				_o.TelePortConfig.Value = ((this.TelePortConfig<ISafePos>() != null) ? this.TelePortConfig<ISafePos>().Value.UnPack() : null);
				break;
			}
			_o.TeammateTeleportConfig = ((this.TeammateTeleportConfig != null) ? this.TeammateTeleportConfig.Value.UnPack() : null);
			_o.TransitionOption = new TTeleportTransitionOptionUnion();
			_o.TransitionOption.Type = this.TransitionOptionType;
			switch (this.TransitionOptionType)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInDigitalScreen>() != null) ? this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInSeamlessType>() != null) ? this.TransitionOption<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCenterText>() != null) ? this.TransitionOption<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCharacterDisplay>() != null) ? this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithEffect>() != null) ? this.TransitionOption<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithFadeInScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithMp4>() != null) ? this.TransitionOption<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithPlayFlow>() != null) ? this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				break;
			}
			_o.DisableAutoFadeInScreen = this.DisableAutoFadeInScreen;
			_o.OnlinePreciseTransport = this.OnlinePreciseTransport;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032E5F RID: 208479 RVA: 0x006DDAA4 File Offset: 0x006DBCA4
		public static Offset<ISetPlayerPos> Pack(FlatBufferBuilder builder, ISetPlayerPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPlayerPos>);
			}
			TTeleportConfig telePortConfig_type = (_o.TelePortConfig == null) ? TTeleportConfig.NONE : _o.TelePortConfig.Type;
			int telePortConfigOffset = (_o.TelePortConfig == null) ? 0 : TTeleportConfigUnion.Pack(builder, _o.TelePortConfig);
			Offset<ITelePortAfterTimeOut> teammateTeleportConfigOffset = (_o.TeammateTeleportConfig == null) ? default(Offset<ITelePortAfterTimeOut>) : ITelePortAfterTimeOut.Pack(builder, _o.TeammateTeleportConfig);
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			return ISetPlayerPos.CreateISetPlayerPos(builder, telePortConfig_type, telePortConfigOffset, teammateTeleportConfigOffset, transitionOption_type, transitionOptionOffset, _o.DisableAutoFadeInScreen, _o.OnlinePreciseTransport, _o.NullMask);
		}

		// Token: 0x04011A9E RID: 72350
		private Table __p;
	}
}
