using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007821 RID: 30753
	public struct ISetPlayerPos : IFlatbufferObject
	{
		// Token: 0x1700E177 RID: 57719
		// (get) Token: 0x060360D2 RID: 221394 RVA: 0x0073D63E File Offset: 0x0073B83E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060360D3 RID: 221395 RVA: 0x0073D64B File Offset: 0x0073B84B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060360D4 RID: 221396 RVA: 0x0073D654 File Offset: 0x0073B854
		public static ISetPlayerPos GetRootAsISetPlayerPos(ByteBuffer _bb)
		{
			return ISetPlayerPos.GetRootAsISetPlayerPos(_bb, default(ISetPlayerPos));
		}

		// Token: 0x060360D5 RID: 221397 RVA: 0x0073D670 File Offset: 0x0073B870
		public static ISetPlayerPos GetRootAsISetPlayerPos(ByteBuffer _bb, ISetPlayerPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060360D6 RID: 221398 RVA: 0x0073D68D File Offset: 0x0073B88D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060360D7 RID: 221399 RVA: 0x0073D69C File Offset: 0x0073B89C
		public ISetPlayerPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E178 RID: 57720
		// (get) Token: 0x060360D8 RID: 221400 RVA: 0x0073D6AC File Offset: 0x0073B8AC
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

		// Token: 0x060360D9 RID: 221401 RVA: 0x0073D6E8 File Offset: 0x0073B8E8
		public TTable? TelePortConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060360DA RID: 221402 RVA: 0x0073D72C File Offset: 0x0073B92C
		public IFixedPos TelePortConfigAsIFixedPos()
		{
			return this.TelePortConfig<IFixedPos>().Value;
		}

		// Token: 0x060360DB RID: 221403 RVA: 0x0073D748 File Offset: 0x0073B948
		public IGravityFlipFixedPos TelePortConfigAsIGravityFlipFixedPos()
		{
			return this.TelePortConfig<IGravityFlipFixedPos>().Value;
		}

		// Token: 0x060360DC RID: 221404 RVA: 0x0073D764 File Offset: 0x0073B964
		public INearestEntity TelePortConfigAsINearestEntity()
		{
			return this.TelePortConfig<INearestEntity>().Value;
		}

		// Token: 0x060360DD RID: 221405 RVA: 0x0073D780 File Offset: 0x0073B980
		public ISafePos TelePortConfigAsISafePos()
		{
			return this.TelePortConfig<ISafePos>().Value;
		}

		// Token: 0x1700E179 RID: 57721
		// (get) Token: 0x060360DE RID: 221406 RVA: 0x0073D79C File Offset: 0x0073B99C
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

		// Token: 0x1700E17A RID: 57722
		// (get) Token: 0x060360DF RID: 221407 RVA: 0x0073D7FC File Offset: 0x0073B9FC
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

		// Token: 0x060360E0 RID: 221408 RVA: 0x0073D83C File Offset: 0x0073BA3C
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060360E1 RID: 221409 RVA: 0x0073D884 File Offset: 0x0073BA84
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x060360E2 RID: 221410 RVA: 0x0073D8A0 File Offset: 0x0073BAA0
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x060360E3 RID: 221411 RVA: 0x0073D8BC File Offset: 0x0073BABC
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x060360E4 RID: 221412 RVA: 0x0073D8D8 File Offset: 0x0073BAD8
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x060360E5 RID: 221413 RVA: 0x0073D8F4 File Offset: 0x0073BAF4
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x060360E6 RID: 221414 RVA: 0x0073D910 File Offset: 0x0073BB10
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x060360E7 RID: 221415 RVA: 0x0073D92C File Offset: 0x0073BB2C
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x060360E8 RID: 221416 RVA: 0x0073D948 File Offset: 0x0073BB48
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x060360E9 RID: 221417 RVA: 0x0073D964 File Offset: 0x0073BB64
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x060360EA RID: 221418 RVA: 0x0073D980 File Offset: 0x0073BB80
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x060360EB RID: 221419 RVA: 0x0073D99C File Offset: 0x0073BB9C
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700E17B RID: 57723
		// (get) Token: 0x060360EC RID: 221420 RVA: 0x0073D9B8 File Offset: 0x0073BBB8
		public bool DisableAutoFadeInScreen
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E17C RID: 57724
		// (get) Token: 0x060360ED RID: 221421 RVA: 0x0073D9F8 File Offset: 0x0073BBF8
		public bool OnlinePreciseTransport
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E17D RID: 57725
		// (get) Token: 0x060360EE RID: 221422 RVA: 0x0073DA38 File Offset: 0x0073BC38
		public bool IsBanMapSound
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E17E RID: 57726
		// (get) Token: 0x060360EF RID: 221423 RVA: 0x0073DA78 File Offset: 0x0073BC78
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

		// Token: 0x060360F0 RID: 221424 RVA: 0x0073DAB8 File Offset: 0x0073BCB8
		public static Offset<ISetPlayerPos> CreateISetPlayerPos(FlatBufferBuilder builder, TTeleportConfig TelePortConfig_type = TTeleportConfig.NONE, int TelePortConfigOffset = 0, Offset<ITelePortAfterTimeOut> TeammateTeleportConfigOffset = default(Offset<ITelePortAfterTimeOut>), TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0, bool DisableAutoFadeInScreen = false, bool OnlinePreciseTransport = false, bool IsBanMapSound = false, byte NullMask = 0)
		{
			builder.StartTable(9);
			ISetPlayerPos.AddTransitionOption(builder, TransitionOptionOffset);
			ISetPlayerPos.AddTeammateTeleportConfig(builder, TeammateTeleportConfigOffset);
			ISetPlayerPos.AddTelePortConfig(builder, TelePortConfigOffset);
			ISetPlayerPos.AddNullMask(builder, NullMask);
			ISetPlayerPos.AddIsBanMapSound(builder, IsBanMapSound);
			ISetPlayerPos.AddOnlinePreciseTransport(builder, OnlinePreciseTransport);
			ISetPlayerPos.AddDisableAutoFadeInScreen(builder, DisableAutoFadeInScreen);
			ISetPlayerPos.AddTransitionOptionType(builder, TransitionOption_type);
			ISetPlayerPos.AddTelePortConfigType(builder, TelePortConfig_type);
			return ISetPlayerPos.EndISetPlayerPos(builder);
		}

		// Token: 0x060360F1 RID: 221425 RVA: 0x0073DB18 File Offset: 0x0073BD18
		public static void StartISetPlayerPos(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060360F2 RID: 221426 RVA: 0x0073DB22 File Offset: 0x0073BD22
		public static void AddTelePortConfigType(FlatBufferBuilder builder, TTeleportConfig telePortConfigType)
		{
			builder.AddByte(0, (byte)telePortConfigType, 0);
		}

		// Token: 0x060360F3 RID: 221427 RVA: 0x0073DB2D File Offset: 0x0073BD2D
		public static void AddTelePortConfig(FlatBufferBuilder builder, int telePortConfigOffset)
		{
			builder.AddOffset(1, telePortConfigOffset, 0);
		}

		// Token: 0x060360F4 RID: 221428 RVA: 0x0073DB38 File Offset: 0x0073BD38
		public static void AddTeammateTeleportConfig(FlatBufferBuilder builder, Offset<ITelePortAfterTimeOut> teammateTeleportConfigOffset)
		{
			builder.AddOffset(2, teammateTeleportConfigOffset.Value, 0);
		}

		// Token: 0x060360F5 RID: 221429 RVA: 0x0073DB48 File Offset: 0x0073BD48
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(3, (byte)transitionOptionType, 0);
		}

		// Token: 0x060360F6 RID: 221430 RVA: 0x0073DB53 File Offset: 0x0073BD53
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(4, transitionOptionOffset, 0);
		}

		// Token: 0x060360F7 RID: 221431 RVA: 0x0073DB5E File Offset: 0x0073BD5E
		public static void AddDisableAutoFadeInScreen(FlatBufferBuilder builder, bool disableAutoFadeInScreen)
		{
			builder.AddBool(5, disableAutoFadeInScreen, false);
		}

		// Token: 0x060360F8 RID: 221432 RVA: 0x0073DB69 File Offset: 0x0073BD69
		public static void AddOnlinePreciseTransport(FlatBufferBuilder builder, bool onlinePreciseTransport)
		{
			builder.AddBool(6, onlinePreciseTransport, false);
		}

		// Token: 0x060360F9 RID: 221433 RVA: 0x0073DB74 File Offset: 0x0073BD74
		public static void AddIsBanMapSound(FlatBufferBuilder builder, bool isBanMapSound)
		{
			builder.AddBool(7, isBanMapSound, false);
		}

		// Token: 0x060360FA RID: 221434 RVA: 0x0073DB7F File Offset: 0x0073BD7F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060360FB RID: 221435 RVA: 0x0073DB8A File Offset: 0x0073BD8A
		public static Offset<ISetPlayerPos> EndISetPlayerPos(FlatBufferBuilder builder)
		{
			return new Offset<ISetPlayerPos>(builder.EndTable());
		}

		// Token: 0x060360FC RID: 221436 RVA: 0x0073DB98 File Offset: 0x0073BD98
		public ISetPlayerPosT UnPack()
		{
			ISetPlayerPosT setPlayerPosT = new ISetPlayerPosT();
			this.UnPackTo(setPlayerPosT);
			return setPlayerPosT;
		}

		// Token: 0x060360FD RID: 221437 RVA: 0x0073DBB4 File Offset: 0x0073BDB4
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
			_o.IsBanMapSound = this.IsBanMapSound;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060360FE RID: 221438 RVA: 0x0073E02C File Offset: 0x0073C22C
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
			return ISetPlayerPos.CreateISetPlayerPos(builder, telePortConfig_type, telePortConfigOffset, teammateTeleportConfigOffset, transitionOption_type, transitionOptionOffset, _o.DisableAutoFadeInScreen, _o.OnlinePreciseTransport, _o.IsBanMapSound, _o.NullMask);
		}

		// Token: 0x04012A8B RID: 76427
		private Table __p;
	}
}
