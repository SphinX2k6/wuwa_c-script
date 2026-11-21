using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ABB RID: 31419
	public struct ITalkItemPhoneMessage : IFlatbufferObject
	{
		// Token: 0x1700E908 RID: 59656
		// (get) Token: 0x0603804F RID: 229455 RVA: 0x00787F20 File Offset: 0x00786120
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038050 RID: 229456 RVA: 0x00787F2D File Offset: 0x0078612D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038051 RID: 229457 RVA: 0x00787F34 File Offset: 0x00786134
		public static ITalkItemPhoneMessage GetRootAsITalkItemPhoneMessage(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessage.GetRootAsITalkItemPhoneMessage(_bb, default(ITalkItemPhoneMessage));
		}

		// Token: 0x06038052 RID: 229458 RVA: 0x00787F50 File Offset: 0x00786150
		public static ITalkItemPhoneMessage GetRootAsITalkItemPhoneMessage(ByteBuffer _bb, ITalkItemPhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038053 RID: 229459 RVA: 0x00787F6D File Offset: 0x0078616D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038054 RID: 229460 RVA: 0x00787F7C File Offset: 0x0078617C
		public ITalkItemPhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E909 RID: 59657
		// (get) Token: 0x06038055 RID: 229461 RVA: 0x00787F8C File Offset: 0x0078618C
		public ETalkItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkItemType.Talk;
				}
				return (ETalkItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E90A RID: 59658
		// (get) Token: 0x06038056 RID: 229462 RVA: 0x00787FC8 File Offset: 0x007861C8
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E90B RID: 59659
		// (get) Token: 0x06038057 RID: 229463 RVA: 0x00788004 File Offset: 0x00786204
		public int PlotLineId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E90C RID: 59660
		// (get) Token: 0x06038058 RID: 229464 RVA: 0x00788040 File Offset: 0x00786240
		public string PlotLineKey
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038059 RID: 229465 RVA: 0x00788078 File Offset: 0x00786278
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0603805A RID: 229466 RVA: 0x00788088 File Offset: 0x00786288
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700E90D RID: 59661
		// (get) Token: 0x0603805B RID: 229467 RVA: 0x00788098 File Offset: 0x00786298
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603805C RID: 229468 RVA: 0x007880D0 File Offset: 0x007862D0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0603805D RID: 229469 RVA: 0x007880E0 File Offset: 0x007862E0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700E90E RID: 59662
		// (get) Token: 0x0603805E RID: 229470 RVA: 0x007880F0 File Offset: 0x007862F0
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E90F RID: 59663
		// (get) Token: 0x0603805F RID: 229471 RVA: 0x00788130 File Offset: 0x00786330
		public EEditFlag _EditFlag
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return EEditFlag.Add;
				}
				return (EEditFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E910 RID: 59664
		// (get) Token: 0x06038060 RID: 229472 RVA: 0x00788170 File Offset: 0x00786370
		public int WhoId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E911 RID: 59665
		// (get) Token: 0x06038061 RID: 229473 RVA: 0x007881B0 File Offset: 0x007863B0
		public int TextId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E912 RID: 59666
		// (get) Token: 0x06038062 RID: 229474 RVA: 0x007881F0 File Offset: 0x007863F0
		public string TidTalk
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038063 RID: 229475 RVA: 0x00788228 File Offset: 0x00786428
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06038064 RID: 229476 RVA: 0x00788238 File Offset: 0x00786438
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700E913 RID: 59667
		// (get) Token: 0x06038065 RID: 229477 RVA: 0x00788248 File Offset: 0x00786448
		public float WaitTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E914 RID: 59668
		// (get) Token: 0x06038066 RID: 229478 RVA: 0x0078828C File Offset: 0x0078648C
		public ICaptionParam? CaptionParams
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new ICaptionParam?(default(ICaptionParam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06038067 RID: 229479 RVA: 0x007882EC File Offset: 0x007864EC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E915 RID: 59669
		// (get) Token: 0x06038068 RID: 229480 RVA: 0x00788350 File Offset: 0x00786550
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038069 RID: 229481 RVA: 0x0078837C File Offset: 0x0078657C
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E916 RID: 59670
		// (get) Token: 0x0603806A RID: 229482 RVA: 0x007883E0 File Offset: 0x007865E0
		public int OptionsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E917 RID: 59671
		// (get) Token: 0x0603806B RID: 229483 RVA: 0x0078840C File Offset: 0x0078660C
		public IPlayMontage? Montage
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new IPlayMontage?(default(IPlayMontage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E918 RID: 59672
		// (get) Token: 0x0603806C RID: 229484 RVA: 0x0078846C File Offset: 0x0078666C
		public ICameraData? CameraData
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new ICameraData?(default(ICameraData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E919 RID: 59673
		// (get) Token: 0x0603806D RID: 229485 RVA: 0x007884CC File Offset: 0x007866CC
		public ISetFlowTemplate? FlowTemplate
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603806E RID: 229486 RVA: 0x0078852C File Offset: 0x0078672C
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E91A RID: 59674
		// (get) Token: 0x0603806F RID: 229487 RVA: 0x00788590 File Offset: 0x00786790
		public int FlowTemplateListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038070 RID: 229488 RVA: 0x007885BC File Offset: 0x007867BC
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E91B RID: 59675
		// (get) Token: 0x06038071 RID: 229489 RVA: 0x00788620 File Offset: 0x00786820
		public int ActorMontageArrayLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038072 RID: 229490 RVA: 0x0078864C File Offset: 0x0078684C
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E91C RID: 59676
		// (get) Token: 0x06038073 RID: 229491 RVA: 0x007886B0 File Offset: 0x007868B0
		public int ActorFaceExpressionArrayLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038074 RID: 229492 RVA: 0x007886DC File Offset: 0x007868DC
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E91D RID: 59677
		// (get) Token: 0x06038075 RID: 229493 RVA: 0x00788740 File Offset: 0x00786940
		public int ActorLookAtArrayLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038076 RID: 229494 RVA: 0x0078876C File Offset: 0x0078696C
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E91E RID: 59678
		// (get) Token: 0x06038077 RID: 229495 RVA: 0x007887D0 File Offset: 0x007869D0
		public int ActorTurnToArrayLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E91F RID: 59679
		// (get) Token: 0x06038078 RID: 229496 RVA: 0x007887FC File Offset: 0x007869FC
		public TPostAkEvent TalkAkEventType
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return TPostAkEvent.NONE;
				}
				return (TPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038079 RID: 229497 RVA: 0x0078883C File Offset: 0x00786A3C
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603807A RID: 229498 RVA: 0x00788884 File Offset: 0x00786A84
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x0603807B RID: 229499 RVA: 0x007888A0 File Offset: 0x00786AA0
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x0603807C RID: 229500 RVA: 0x007888BC File Offset: 0x00786ABC
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x0603807D RID: 229501 RVA: 0x007888D8 File Offset: 0x00786AD8
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700E920 RID: 59680
		// (get) Token: 0x0603807E RID: 229502 RVA: 0x007888F4 File Offset: 0x00786AF4
		public TPostAkEvent TalkEndAkEventType
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return TPostAkEvent.NONE;
				}
				return (TPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603807F RID: 229503 RVA: 0x00788934 File Offset: 0x00786B34
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038080 RID: 229504 RVA: 0x0078897C File Offset: 0x00786B7C
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06038081 RID: 229505 RVA: 0x00788998 File Offset: 0x00786B98
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x06038082 RID: 229506 RVA: 0x007889B4 File Offset: 0x00786BB4
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06038083 RID: 229507 RVA: 0x007889D0 File Offset: 0x00786BD0
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700E921 RID: 59681
		// (get) Token: 0x06038084 RID: 229508 RVA: 0x007889EC File Offset: 0x00786BEC
		public IUniversalTone? UniversalTone
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return new IUniversalTone?(default(IUniversalTone).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E922 RID: 59682
		// (get) Token: 0x06038085 RID: 229509 RVA: 0x00788A4C File Offset: 0x00786C4C
		public TTalkBackground BackgroundConfigType
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return TTalkBackground.NONE;
				}
				return (TTalkBackground)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038086 RID: 229510 RVA: 0x00788A8C File Offset: 0x00786C8C
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038087 RID: 229511 RVA: 0x00788AD4 File Offset: 0x00786CD4
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x06038088 RID: 229512 RVA: 0x00788AF0 File Offset: 0x00786CF0
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x06038089 RID: 229513 RVA: 0x00788B0C File Offset: 0x00786D0C
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x0603808A RID: 229514 RVA: 0x00788B28 File Offset: 0x00786D28
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x0603808B RID: 229515 RVA: 0x00788B44 File Offset: 0x00786D44
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700E923 RID: 59683
		// (get) Token: 0x0603808C RID: 229516 RVA: 0x00788B60 File Offset: 0x00786D60
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E924 RID: 59684
		// (get) Token: 0x0603808D RID: 229517 RVA: 0x00788BA0 File Offset: 0x00786DA0
		public ITimeLimitOptionGroup? TimeLimitOptionGroup
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return new ITimeLimitOptionGroup?(default(ITimeLimitOptionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E925 RID: 59685
		// (get) Token: 0x0603808E RID: 229518 RVA: 0x00788C00 File Offset: 0x00786E00
		public IGamepadShakeInTalk? GamepadShake
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return new IGamepadShakeInTalk?(default(IGamepadShakeInTalk).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603808F RID: 229519 RVA: 0x00788C60 File Offset: 0x00786E60
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E926 RID: 59686
		// (get) Token: 0x06038090 RID: 229520 RVA: 0x00788CC4 File Offset: 0x00786EC4
		public int IntroActionsLength
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038091 RID: 229521 RVA: 0x00788CF0 File Offset: 0x00786EF0
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E927 RID: 59687
		// (get) Token: 0x06038092 RID: 229522 RVA: 0x00788D54 File Offset: 0x00786F54
		public int ActorFxEmoteArrayLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038093 RID: 229523 RVA: 0x00788D80 File Offset: 0x00786F80
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700E928 RID: 59688
		// (get) Token: 0x06038094 RID: 229524 RVA: 0x00788DC0 File Offset: 0x00786FC0
		public int TalkEffectArrayTypeLength
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038095 RID: 229525 RVA: 0x00788DEC File Offset: 0x00786FEC
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x06038096 RID: 229526 RVA: 0x00788DFC File Offset: 0x00786FFC
		public TTalkEffectAction[] GetTalkEffectArrayTypeArray()
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TTalkEffectAction[] array = new TTalkEffectAction[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TTalkEffectAction)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06038097 RID: 229527 RVA: 0x00788E68 File Offset: 0x00787068
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700E929 RID: 59689
		// (get) Token: 0x06038098 RID: 229528 RVA: 0x00788EB0 File Offset: 0x007870B0
		public int TalkEffectArrayLength
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06038099 RID: 229529 RVA: 0x00788EDC File Offset: 0x007870DC
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E92A RID: 59690
		// (get) Token: 0x0603809A RID: 229530 RVA: 0x00788F40 File Offset: 0x00787140
		public int ActorVisibilityArrayLength
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E92B RID: 59691
		// (get) Token: 0x0603809B RID: 229531 RVA: 0x00788F6C File Offset: 0x0078716C
		public TPhoneMessageType MessageTypeType
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return TPhoneMessageType.NONE;
				}
				return (TPhoneMessageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603809C RID: 229532 RVA: 0x00788FAC File Offset: 0x007871AC
		public TTable? MessageType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603809D RID: 229533 RVA: 0x00788FF4 File Offset: 0x007871F4
		public ITalkItemPhoneMessageAttachment MessageTypeAsITalkItemPhoneMessageAttachment()
		{
			return this.MessageType<ITalkItemPhoneMessageAttachment>().Value;
		}

		// Token: 0x0603809E RID: 229534 RVA: 0x00789010 File Offset: 0x00787210
		public ITalkItemPhoneMessageEmoji MessageTypeAsITalkItemPhoneMessageEmoji()
		{
			return this.MessageType<ITalkItemPhoneMessageEmoji>().Value;
		}

		// Token: 0x0603809F RID: 229535 RVA: 0x0078902C File Offset: 0x0078722C
		public ITalkItemPhoneMessageSystemTip MessageTypeAsITalkItemPhoneMessageSystemTip()
		{
			return this.MessageType<ITalkItemPhoneMessageSystemTip>().Value;
		}

		// Token: 0x060380A0 RID: 229536 RVA: 0x00789048 File Offset: 0x00787248
		public ITalkItemPhoneMessageVoice MessageTypeAsITalkItemPhoneMessageVoice()
		{
			return this.MessageType<ITalkItemPhoneMessageVoice>().Value;
		}

		// Token: 0x1700E92C RID: 59692
		// (get) Token: 0x060380A1 RID: 229537 RVA: 0x00789064 File Offset: 0x00787264
		public TTalkItemStyle StyleType
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return TTalkItemStyle.NONE;
				}
				return (TTalkItemStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060380A2 RID: 229538 RVA: 0x007890A4 File Offset: 0x007872A4
		public TTable? Style<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(84);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060380A3 RID: 229539 RVA: 0x007890EC File Offset: 0x007872EC
		public ITalkItemStyleInnerVoice StyleAsITalkItemStyleInnerVoice()
		{
			return this.Style<ITalkItemStyleInnerVoice>().Value;
		}

		// Token: 0x060380A4 RID: 229540 RVA: 0x00789108 File Offset: 0x00787308
		public ITalkItemStylePhoneSendError StyleAsITalkItemStylePhoneSendError()
		{
			return this.Style<ITalkItemStylePhoneSendError>().Value;
		}

		// Token: 0x060380A5 RID: 229541 RVA: 0x00789124 File Offset: 0x00787324
		public ITalkItemStyleSceneUiSubtitle StyleAsITalkItemStyleSceneUiSubtitle()
		{
			return this.Style<ITalkItemStyleSceneUiSubtitle>().Value;
		}

		// Token: 0x1700E92D RID: 59693
		// (get) Token: 0x060380A6 RID: 229542 RVA: 0x00789140 File Offset: 0x00787340
		public float OtherIsTypingDuration
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E92E RID: 59694
		// (get) Token: 0x060380A7 RID: 229543 RVA: 0x00789184 File Offset: 0x00787384
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060380A8 RID: 229544 RVA: 0x007891C4 File Offset: 0x007873C4
		public static Offset<ITalkItemPhoneMessage> CreateITalkItemPhoneMessage(FlatBufferBuilder builder, ETalkItemType Type = ETalkItemType.Talk, int Id = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, int WhoId = 0, int TextId = 0, StringOffset TidTalkOffset = default(StringOffset), float WaitTime = 0f, Offset<ICaptionParam> CaptionParamsOffset = default(Offset<ICaptionParam>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), Offset<IPlayMontage> MontageOffset = default(Offset<IPlayMontage>), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>), Offset<ISetFlowTemplate> FlowTemplateOffset = default(Offset<ISetFlowTemplate>), VectorOffset FlowTemplateListOffset = default(VectorOffset), VectorOffset ActorMontageArrayOffset = default(VectorOffset), VectorOffset ActorFaceExpressionArrayOffset = default(VectorOffset), VectorOffset ActorLookAtArrayOffset = default(VectorOffset), VectorOffset ActorTurnToArrayOffset = default(VectorOffset), TPostAkEvent TalkAkEvent_type = TPostAkEvent.NONE, int TalkAkEventOffset = 0, TPostAkEvent TalkEndAkEvent_type = TPostAkEvent.NONE, int TalkEndAkEventOffset = 0, Offset<IUniversalTone> UniversalToneOffset = default(Offset<IUniversalTone>), TTalkBackground BackgroundConfig_type = TTalkBackground.NONE, int BackgroundConfigOffset = 0, bool PlayVoice = false, Offset<ITimeLimitOptionGroup> TimeLimitOptionGroupOffset = default(Offset<ITimeLimitOptionGroup>), Offset<IGamepadShakeInTalk> GamepadShakeOffset = default(Offset<IGamepadShakeInTalk>), VectorOffset IntroActionsOffset = default(VectorOffset), VectorOffset ActorFxEmoteArrayOffset = default(VectorOffset), VectorOffset TalkEffectArray_typeOffset = default(VectorOffset), VectorOffset TalkEffectArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), TPhoneMessageType MessageType_type = TPhoneMessageType.NONE, int MessageTypeOffset = 0, TTalkItemStyle Style_type = TTalkItemStyle.NONE, int StyleOffset = 0, float OtherIsTypingDuration = 0f, uint NullMask = 0U)
		{
			builder.StartTable(43);
			ITalkItemPhoneMessage.AddNullMask(builder, NullMask);
			ITalkItemPhoneMessage.AddOtherIsTypingDuration(builder, OtherIsTypingDuration);
			ITalkItemPhoneMessage.AddStyle(builder, StyleOffset);
			ITalkItemPhoneMessage.AddMessageType(builder, MessageTypeOffset);
			ITalkItemPhoneMessage.AddActorVisibilityArray(builder, ActorVisibilityArrayOffset);
			ITalkItemPhoneMessage.AddTalkEffectArray(builder, TalkEffectArrayOffset);
			ITalkItemPhoneMessage.AddTalkEffectArrayType(builder, TalkEffectArray_typeOffset);
			ITalkItemPhoneMessage.AddActorFxEmoteArray(builder, ActorFxEmoteArrayOffset);
			ITalkItemPhoneMessage.AddIntroActions(builder, IntroActionsOffset);
			ITalkItemPhoneMessage.AddGamepadShake(builder, GamepadShakeOffset);
			ITalkItemPhoneMessage.AddTimeLimitOptionGroup(builder, TimeLimitOptionGroupOffset);
			ITalkItemPhoneMessage.AddBackgroundConfig(builder, BackgroundConfigOffset);
			ITalkItemPhoneMessage.AddUniversalTone(builder, UniversalToneOffset);
			ITalkItemPhoneMessage.AddTalkEndAkEvent(builder, TalkEndAkEventOffset);
			ITalkItemPhoneMessage.AddTalkAkEvent(builder, TalkAkEventOffset);
			ITalkItemPhoneMessage.AddActorTurnToArray(builder, ActorTurnToArrayOffset);
			ITalkItemPhoneMessage.AddActorLookAtArray(builder, ActorLookAtArrayOffset);
			ITalkItemPhoneMessage.AddActorFaceExpressionArray(builder, ActorFaceExpressionArrayOffset);
			ITalkItemPhoneMessage.AddActorMontageArray(builder, ActorMontageArrayOffset);
			ITalkItemPhoneMessage.AddFlowTemplateList(builder, FlowTemplateListOffset);
			ITalkItemPhoneMessage.AddFlowTemplate(builder, FlowTemplateOffset);
			ITalkItemPhoneMessage.AddCameraData(builder, CameraDataOffset);
			ITalkItemPhoneMessage.AddMontage(builder, MontageOffset);
			ITalkItemPhoneMessage.AddOptions(builder, OptionsOffset);
			ITalkItemPhoneMessage.AddActions(builder, ActionsOffset);
			ITalkItemPhoneMessage.AddCaptionParams(builder, CaptionParamsOffset);
			ITalkItemPhoneMessage.AddWaitTime(builder, WaitTime);
			ITalkItemPhoneMessage.AddTidTalk(builder, TidTalkOffset);
			ITalkItemPhoneMessage.AddTextId(builder, TextId);
			ITalkItemPhoneMessage.AddWhoId(builder, WhoId);
			ITalkItemPhoneMessage.AddName(builder, NameOffset);
			ITalkItemPhoneMessage.AddPlotLineKey(builder, PlotLineKeyOffset);
			ITalkItemPhoneMessage.AddPlotLineId(builder, PlotLineId);
			ITalkItemPhoneMessage.AddId(builder, Id);
			ITalkItemPhoneMessage.AddStyleType(builder, Style_type);
			ITalkItemPhoneMessage.AddMessageTypeType(builder, MessageType_type);
			ITalkItemPhoneMessage.AddPlayVoice(builder, PlayVoice);
			ITalkItemPhoneMessage.AddBackgroundConfigType(builder, BackgroundConfig_type);
			ITalkItemPhoneMessage.AddTalkEndAkEventType(builder, TalkEndAkEvent_type);
			ITalkItemPhoneMessage.AddTalkAkEventType(builder, TalkAkEvent_type);
			ITalkItemPhoneMessage.Add_EditFlag(builder, _editFlag);
			ITalkItemPhoneMessage.Add_Folded(builder, _folded);
			ITalkItemPhoneMessage.AddType(builder, Type);
			return ITalkItemPhoneMessage.EndITalkItemPhoneMessage(builder);
		}

		// Token: 0x060380A9 RID: 229545 RVA: 0x00789334 File Offset: 0x00787534
		public static void StartITalkItemPhoneMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(43);
		}

		// Token: 0x060380AA RID: 229546 RVA: 0x0078933E File Offset: 0x0078753E
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060380AB RID: 229547 RVA: 0x00789349 File Offset: 0x00787549
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060380AC RID: 229548 RVA: 0x00789354 File Offset: 0x00787554
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x060380AD RID: 229549 RVA: 0x0078935F File Offset: 0x0078755F
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x060380AE RID: 229550 RVA: 0x0078936F File Offset: 0x0078756F
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x060380AF RID: 229551 RVA: 0x0078937F File Offset: 0x0078757F
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x060380B0 RID: 229552 RVA: 0x0078938A File Offset: 0x0078758A
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x060380B1 RID: 229553 RVA: 0x00789395 File Offset: 0x00787595
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x060380B2 RID: 229554 RVA: 0x007893A0 File Offset: 0x007875A0
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x060380B3 RID: 229555 RVA: 0x007893AB File Offset: 0x007875AB
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x060380B4 RID: 229556 RVA: 0x007893BC File Offset: 0x007875BC
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x060380B5 RID: 229557 RVA: 0x007893D0 File Offset: 0x007875D0
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x060380B6 RID: 229558 RVA: 0x007893E1 File Offset: 0x007875E1
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x060380B7 RID: 229559 RVA: 0x007893F4 File Offset: 0x007875F4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380B8 RID: 229560 RVA: 0x00789434 File Offset: 0x00787634
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380B9 RID: 229561 RVA: 0x0078944E File Offset: 0x0078764E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380BA RID: 229562 RVA: 0x0078946C File Offset: 0x0078766C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380BB RID: 229563 RVA: 0x00789485 File Offset: 0x00787685
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380BC RID: 229564 RVA: 0x00789490 File Offset: 0x00787690
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x060380BD RID: 229565 RVA: 0x007894A4 File Offset: 0x007876A4
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380BE RID: 229566 RVA: 0x007894E4 File Offset: 0x007876E4
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380BF RID: 229567 RVA: 0x007894FE File Offset: 0x007876FE
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380C0 RID: 229568 RVA: 0x0078951C File Offset: 0x0078771C
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380C1 RID: 229569 RVA: 0x00789535 File Offset: 0x00787735
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380C2 RID: 229570 RVA: 0x00789540 File Offset: 0x00787740
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x060380C3 RID: 229571 RVA: 0x00789551 File Offset: 0x00787751
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x060380C4 RID: 229572 RVA: 0x00789562 File Offset: 0x00787762
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x060380C5 RID: 229573 RVA: 0x00789573 File Offset: 0x00787773
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x060380C6 RID: 229574 RVA: 0x00789584 File Offset: 0x00787784
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380C7 RID: 229575 RVA: 0x007895C4 File Offset: 0x007877C4
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380C8 RID: 229576 RVA: 0x007895DE File Offset: 0x007877DE
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380C9 RID: 229577 RVA: 0x007895FC File Offset: 0x007877FC
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380CA RID: 229578 RVA: 0x00789615 File Offset: 0x00787815
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380CB RID: 229579 RVA: 0x00789620 File Offset: 0x00787820
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x060380CC RID: 229580 RVA: 0x00789634 File Offset: 0x00787834
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380CD RID: 229581 RVA: 0x00789674 File Offset: 0x00787874
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380CE RID: 229582 RVA: 0x0078968E File Offset: 0x0078788E
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380CF RID: 229583 RVA: 0x007896AC File Offset: 0x007878AC
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380D0 RID: 229584 RVA: 0x007896C5 File Offset: 0x007878C5
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380D1 RID: 229585 RVA: 0x007896D0 File Offset: 0x007878D0
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x060380D2 RID: 229586 RVA: 0x007896E4 File Offset: 0x007878E4
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380D3 RID: 229587 RVA: 0x00789724 File Offset: 0x00787924
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380D4 RID: 229588 RVA: 0x0078973E File Offset: 0x0078793E
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380D5 RID: 229589 RVA: 0x0078975C File Offset: 0x0078795C
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380D6 RID: 229590 RVA: 0x00789775 File Offset: 0x00787975
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380D7 RID: 229591 RVA: 0x00789780 File Offset: 0x00787980
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x060380D8 RID: 229592 RVA: 0x00789794 File Offset: 0x00787994
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380D9 RID: 229593 RVA: 0x007897D4 File Offset: 0x007879D4
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380DA RID: 229594 RVA: 0x007897EE File Offset: 0x007879EE
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380DB RID: 229595 RVA: 0x0078980C File Offset: 0x00787A0C
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380DC RID: 229596 RVA: 0x00789825 File Offset: 0x00787A25
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380DD RID: 229597 RVA: 0x00789830 File Offset: 0x00787A30
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x060380DE RID: 229598 RVA: 0x00789844 File Offset: 0x00787A44
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380DF RID: 229599 RVA: 0x00789884 File Offset: 0x00787A84
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380E0 RID: 229600 RVA: 0x0078989E File Offset: 0x00787A9E
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380E1 RID: 229601 RVA: 0x007898BC File Offset: 0x00787ABC
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380E2 RID: 229602 RVA: 0x007898D5 File Offset: 0x00787AD5
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380E3 RID: 229603 RVA: 0x007898E0 File Offset: 0x00787AE0
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x060380E4 RID: 229604 RVA: 0x007898EC File Offset: 0x00787AEC
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x060380E5 RID: 229605 RVA: 0x007898F8 File Offset: 0x00787AF8
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x060380E6 RID: 229606 RVA: 0x00789904 File Offset: 0x00787B04
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x060380E7 RID: 229607 RVA: 0x00789910 File Offset: 0x00787B10
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x060380E8 RID: 229608 RVA: 0x00789921 File Offset: 0x00787B21
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x060380E9 RID: 229609 RVA: 0x0078992D File Offset: 0x00787B2D
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x060380EA RID: 229610 RVA: 0x00789939 File Offset: 0x00787B39
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x060380EB RID: 229611 RVA: 0x00789945 File Offset: 0x00787B45
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x060380EC RID: 229612 RVA: 0x00789956 File Offset: 0x00787B56
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x060380ED RID: 229613 RVA: 0x00789967 File Offset: 0x00787B67
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x060380EE RID: 229614 RVA: 0x00789978 File Offset: 0x00787B78
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380EF RID: 229615 RVA: 0x007899B8 File Offset: 0x00787BB8
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380F0 RID: 229616 RVA: 0x007899D2 File Offset: 0x00787BD2
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380F1 RID: 229617 RVA: 0x007899F0 File Offset: 0x00787BF0
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380F2 RID: 229618 RVA: 0x00789A09 File Offset: 0x00787C09
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380F3 RID: 229619 RVA: 0x00789A14 File Offset: 0x00787C14
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x060380F4 RID: 229620 RVA: 0x00789A28 File Offset: 0x00787C28
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060380F5 RID: 229621 RVA: 0x00789A68 File Offset: 0x00787C68
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380F6 RID: 229622 RVA: 0x00789A82 File Offset: 0x00787C82
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x060380F7 RID: 229623 RVA: 0x00789AA0 File Offset: 0x00787CA0
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380F8 RID: 229624 RVA: 0x00789AB9 File Offset: 0x00787CB9
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060380F9 RID: 229625 RVA: 0x00789AC4 File Offset: 0x00787CC4
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x060380FA RID: 229626 RVA: 0x00789AD8 File Offset: 0x00787CD8
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060380FB RID: 229627 RVA: 0x00789B0F File Offset: 0x00787D0F
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x060380FC RID: 229628 RVA: 0x00789B29 File Offset: 0x00787D29
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x060380FD RID: 229629 RVA: 0x00789B47 File Offset: 0x00787D47
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060380FE RID: 229630 RVA: 0x00789B60 File Offset: 0x00787D60
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060380FF RID: 229631 RVA: 0x00789B6B File Offset: 0x00787D6B
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x06038100 RID: 229632 RVA: 0x00789B7C File Offset: 0x00787D7C
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038101 RID: 229633 RVA: 0x00789BB3 File Offset: 0x00787DB3
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038102 RID: 229634 RVA: 0x00789BCD File Offset: 0x00787DCD
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038103 RID: 229635 RVA: 0x00789BEB File Offset: 0x00787DEB
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038104 RID: 229636 RVA: 0x00789C04 File Offset: 0x00787E04
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038105 RID: 229637 RVA: 0x00789C0F File Offset: 0x00787E0F
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x06038106 RID: 229638 RVA: 0x00789C20 File Offset: 0x00787E20
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038107 RID: 229639 RVA: 0x00789C60 File Offset: 0x00787E60
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038108 RID: 229640 RVA: 0x00789C7A File Offset: 0x00787E7A
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038109 RID: 229641 RVA: 0x00789C98 File Offset: 0x00787E98
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603810A RID: 229642 RVA: 0x00789CB1 File Offset: 0x00787EB1
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603810B RID: 229643 RVA: 0x00789CBC File Offset: 0x00787EBC
		public static void AddMessageTypeType(FlatBufferBuilder builder, TPhoneMessageType messageTypeType)
		{
			builder.AddByte(37, (byte)messageTypeType, 0);
		}

		// Token: 0x0603810C RID: 229644 RVA: 0x00789CC8 File Offset: 0x00787EC8
		public static void AddMessageType(FlatBufferBuilder builder, int messageTypeOffset)
		{
			builder.AddOffset(38, messageTypeOffset, 0);
		}

		// Token: 0x0603810D RID: 229645 RVA: 0x00789CD4 File Offset: 0x00787ED4
		public static void AddStyleType(FlatBufferBuilder builder, TTalkItemStyle styleType)
		{
			builder.AddByte(39, (byte)styleType, 0);
		}

		// Token: 0x0603810E RID: 229646 RVA: 0x00789CE0 File Offset: 0x00787EE0
		public static void AddStyle(FlatBufferBuilder builder, int styleOffset)
		{
			builder.AddOffset(40, styleOffset, 0);
		}

		// Token: 0x0603810F RID: 229647 RVA: 0x00789CEC File Offset: 0x00787EEC
		public static void AddOtherIsTypingDuration(FlatBufferBuilder builder, float otherIsTypingDuration)
		{
			builder.AddFloat(41, otherIsTypingDuration, 0.0);
		}

		// Token: 0x06038110 RID: 229648 RVA: 0x00789D00 File Offset: 0x00787F00
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(42, nullMask, 0U);
		}

		// Token: 0x06038111 RID: 229649 RVA: 0x00789D0C File Offset: 0x00787F0C
		public static Offset<ITalkItemPhoneMessage> EndITalkItemPhoneMessage(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessage>(builder.EndTable());
		}

		// Token: 0x06038112 RID: 229650 RVA: 0x00789D1C File Offset: 0x00787F1C
		public ITalkItemPhoneMessageT UnPack()
		{
			ITalkItemPhoneMessageT talkItemPhoneMessageT = new ITalkItemPhoneMessageT();
			this.UnPackTo(talkItemPhoneMessageT);
			return talkItemPhoneMessageT;
		}

		// Token: 0x06038113 RID: 229651 RVA: 0x00789D38 File Offset: 0x00787F38
		public void UnPackTo(ITalkItemPhoneMessageT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.PlotLineId = this.PlotLineId;
			_o.PlotLineKey = this.PlotLineKey;
			_o.Name = this.Name;
			_o._Folded = this._Folded;
			_o._EditFlag = this._EditFlag;
			_o.WhoId = this.WhoId;
			_o.TextId = this.TextId;
			_o.TidTalk = this.TidTalk;
			_o.WaitTime = this.WaitTime;
			_o.CaptionParams = ((this.CaptionParams != null) ? this.CaptionParams.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.Options = new List<ITalkOptionT>();
			for (int j = 0; j < this.OptionsLength; j++)
			{
				_o.Options.Add((this.Options(j) != null) ? this.Options(j).Value.UnPack() : null);
			}
			_o.Montage = ((this.Montage != null) ? this.Montage.Value.UnPack() : null);
			_o.CameraData = ((this.CameraData != null) ? this.CameraData.Value.UnPack() : null);
			_o.FlowTemplate = ((this.FlowTemplate != null) ? this.FlowTemplate.Value.UnPack() : null);
			_o.FlowTemplateList = new List<ISetFlowTemplateT>();
			for (int k = 0; k < this.FlowTemplateListLength; k++)
			{
				_o.FlowTemplateList.Add((this.FlowTemplateList(k) != null) ? this.FlowTemplateList(k).Value.UnPack() : null);
			}
			_o.ActorMontageArray = new List<IMontageDataT>();
			for (int l = 0; l < this.ActorMontageArrayLength; l++)
			{
				_o.ActorMontageArray.Add((this.ActorMontageArray(l) != null) ? this.ActorMontageArray(l).Value.UnPack() : null);
			}
			_o.ActorFaceExpressionArray = new List<IActorFaceExpressionT>();
			for (int m = 0; m < this.ActorFaceExpressionArrayLength; m++)
			{
				_o.ActorFaceExpressionArray.Add((this.ActorFaceExpressionArray(m) != null) ? this.ActorFaceExpressionArray(m).Value.UnPack() : null);
			}
			_o.ActorLookAtArray = new List<IActorLookAtT>();
			for (int n = 0; n < this.ActorLookAtArrayLength; n++)
			{
				_o.ActorLookAtArray.Add((this.ActorLookAtArray(n) != null) ? this.ActorLookAtArray(n).Value.UnPack() : null);
			}
			_o.ActorTurnToArray = new List<IActorTurnToT>();
			for (int num = 0; num < this.ActorTurnToArrayLength; num++)
			{
				_o.ActorTurnToArray.Add((this.ActorTurnToArray(num) != null) ? this.ActorTurnToArray(num).Value.UnPack() : null);
			}
			_o.TalkAkEvent = new TPostAkEventUnion();
			_o.TalkAkEvent.Type = this.TalkAkEventType;
			switch (this.TalkAkEventType)
			{
			case TPostAkEvent.IPostAkEventGlobal:
				_o.TalkAkEvent.Value = ((this.TalkAkEvent<IPostAkEventGlobal>() != null) ? this.TalkAkEvent<IPostAkEventGlobal>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMap:
				_o.TalkAkEvent.Value = ((this.TalkAkEvent<IPostAkEventMap>() != null) ? this.TalkAkEvent<IPostAkEventMap>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMusicSubtitle:
				_o.TalkAkEvent.Value = ((this.TalkAkEvent<IPostAkEventMusicSubtitle>() != null) ? this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventTargeted:
				_o.TalkAkEvent.Value = ((this.TalkAkEvent<IPostAkEventTargeted>() != null) ? this.TalkAkEvent<IPostAkEventTargeted>().Value.UnPack() : null);
				break;
			}
			_o.TalkEndAkEvent = new TPostAkEventUnion();
			_o.TalkEndAkEvent.Type = this.TalkEndAkEventType;
			switch (this.TalkEndAkEventType)
			{
			case TPostAkEvent.IPostAkEventGlobal:
				_o.TalkEndAkEvent.Value = ((this.TalkEndAkEvent<IPostAkEventGlobal>() != null) ? this.TalkEndAkEvent<IPostAkEventGlobal>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMap:
				_o.TalkEndAkEvent.Value = ((this.TalkEndAkEvent<IPostAkEventMap>() != null) ? this.TalkEndAkEvent<IPostAkEventMap>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventMusicSubtitle:
				_o.TalkEndAkEvent.Value = ((this.TalkEndAkEvent<IPostAkEventMusicSubtitle>() != null) ? this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value.UnPack() : null);
				break;
			case TPostAkEvent.IPostAkEventTargeted:
				_o.TalkEndAkEvent.Value = ((this.TalkEndAkEvent<IPostAkEventTargeted>() != null) ? this.TalkEndAkEvent<IPostAkEventTargeted>().Value.UnPack() : null);
				break;
			}
			_o.UniversalTone = ((this.UniversalTone != null) ? this.UniversalTone.Value.UnPack() : null);
			_o.BackgroundConfig = new TTalkBackgroundUnion();
			_o.BackgroundConfig.Type = this.BackgroundConfigType;
			switch (this.BackgroundConfigType)
			{
			case TTalkBackground.ITalkBackgroundClean:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundClean>() != null) ? this.BackgroundConfig<ITalkBackgroundClean>().Value.UnPack() : null);
				break;
			case TTalkBackground.ITalkBackgroundIcon:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundIcon>() != null) ? this.BackgroundConfig<ITalkBackgroundIcon>().Value.UnPack() : null);
				break;
			case TTalkBackground.ITalkBackgroundImage:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundImage>() != null) ? this.BackgroundConfig<ITalkBackgroundImage>().Value.UnPack() : null);
				break;
			case TTalkBackground.ITalkBackgroundImageByMcGender:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundImageByMcGender>() != null) ? this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value.UnPack() : null);
				break;
			case TTalkBackground.ITalkBackgroundSpineImage:
				_o.BackgroundConfig.Value = ((this.BackgroundConfig<ITalkBackgroundSpineImage>() != null) ? this.BackgroundConfig<ITalkBackgroundSpineImage>().Value.UnPack() : null);
				break;
			}
			_o.PlayVoice = this.PlayVoice;
			_o.TimeLimitOptionGroup = ((this.TimeLimitOptionGroup != null) ? this.TimeLimitOptionGroup.Value.UnPack() : null);
			_o.GamepadShake = ((this.GamepadShake != null) ? this.GamepadShake.Value.UnPack() : null);
			_o.IntroActions = new List<IActionInfoT>();
			for (int num2 = 0; num2 < this.IntroActionsLength; num2++)
			{
				_o.IntroActions.Add((this.IntroActions(num2) != null) ? this.IntroActions(num2).Value.UnPack() : null);
			}
			_o.ActorFxEmoteArray = new List<IActorFxEmoteT>();
			for (int num3 = 0; num3 < this.ActorFxEmoteArrayLength; num3++)
			{
				_o.ActorFxEmoteArray.Add((this.ActorFxEmoteArray(num3) != null) ? this.ActorFxEmoteArray(num3).Value.UnPack() : null);
			}
			_o.TalkEffectArray = new List<TTalkEffectActionUnion>();
			for (int num4 = 0; num4 < this.TalkEffectArrayLength; num4++)
			{
				TTalkEffectActionUnion ttalkEffectActionUnion = new TTalkEffectActionUnion();
				ttalkEffectActionUnion.Type = this.TalkEffectArrayType(num4);
				TTalkEffectAction ttalkEffectAction = this.TalkEffectArrayType(num4);
				if (ttalkEffectAction != TTalkEffectAction.ITalkEffectPlay)
				{
					if (ttalkEffectAction == TTalkEffectAction.ITalkEffectStop)
					{
						ttalkEffectActionUnion.Value = ((this.TalkEffectArray<ITalkEffectStop>(num4) != null) ? this.TalkEffectArray<ITalkEffectStop>(num4).Value.UnPack() : null);
					}
				}
				else
				{
					ttalkEffectActionUnion.Value = ((this.TalkEffectArray<ITalkEffectPlay>(num4) != null) ? this.TalkEffectArray<ITalkEffectPlay>(num4).Value.UnPack() : null);
				}
				_o.TalkEffectArray.Add(ttalkEffectActionUnion);
			}
			_o.ActorVisibilityArray = new List<IActorVisibilityT>();
			for (int num5 = 0; num5 < this.ActorVisibilityArrayLength; num5++)
			{
				_o.ActorVisibilityArray.Add((this.ActorVisibilityArray(num5) != null) ? this.ActorVisibilityArray(num5).Value.UnPack() : null);
			}
			_o.MessageType = new TPhoneMessageTypeUnion();
			_o.MessageType.Type = this.MessageTypeType;
			switch (this.MessageTypeType)
			{
			case TPhoneMessageType.ITalkItemPhoneMessageAttachment:
				_o.MessageType.Value = ((this.MessageType<ITalkItemPhoneMessageAttachment>() != null) ? this.MessageType<ITalkItemPhoneMessageAttachment>().Value.UnPack() : null);
				break;
			case TPhoneMessageType.ITalkItemPhoneMessageEmoji:
				_o.MessageType.Value = ((this.MessageType<ITalkItemPhoneMessageEmoji>() != null) ? this.MessageType<ITalkItemPhoneMessageEmoji>().Value.UnPack() : null);
				break;
			case TPhoneMessageType.ITalkItemPhoneMessageSystemTip:
				_o.MessageType.Value = ((this.MessageType<ITalkItemPhoneMessageSystemTip>() != null) ? this.MessageType<ITalkItemPhoneMessageSystemTip>().Value.UnPack() : null);
				break;
			case TPhoneMessageType.ITalkItemPhoneMessageVoice:
				_o.MessageType.Value = ((this.MessageType<ITalkItemPhoneMessageVoice>() != null) ? this.MessageType<ITalkItemPhoneMessageVoice>().Value.UnPack() : null);
				break;
			}
			_o.Style = new TTalkItemStyleUnion();
			_o.Style.Type = this.StyleType;
			switch (this.StyleType)
			{
			case TTalkItemStyle.ITalkItemStyleInnerVoice:
				_o.Style.Value = ((this.Style<ITalkItemStyleInnerVoice>() != null) ? this.Style<ITalkItemStyleInnerVoice>().Value.UnPack() : null);
				break;
			case TTalkItemStyle.ITalkItemStylePhoneSendError:
				_o.Style.Value = ((this.Style<ITalkItemStylePhoneSendError>() != null) ? this.Style<ITalkItemStylePhoneSendError>().Value.UnPack() : null);
				break;
			case TTalkItemStyle.ITalkItemStyleSceneUiSubtitle:
				_o.Style.Value = ((this.Style<ITalkItemStyleSceneUiSubtitle>() != null) ? this.Style<ITalkItemStyleSceneUiSubtitle>().Value.UnPack() : null);
				break;
			}
			_o.OtherIsTypingDuration = this.OtherIsTypingDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06038114 RID: 229652 RVA: 0x0078A960 File Offset: 0x00788B60
		public static Offset<ITalkItemPhoneMessage> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessage>);
			}
			StringOffset plotLineKeyOffset = (_o.PlotLineKey == null) ? default(StringOffset) : builder.CreateString(_o.PlotLineKey);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset tidTalkOffset = (_o.TidTalk == null) ? default(StringOffset) : builder.CreateString(_o.TidTalk);
			Offset<ICaptionParam> captionParamsOffset = (_o.CaptionParams == null) ? default(Offset<ICaptionParam>) : ICaptionParam.Pack(builder, _o.CaptionParams);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ITalkItemPhoneMessage.CreateActionsVector(builder, array);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<ITalkOption>[] array2 = new Offset<ITalkOption>[_o.Options.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ITalkOption.Pack(builder, _o.Options[j]);
				}
				optionsOffset = ITalkItemPhoneMessage.CreateOptionsVector(builder, array2);
			}
			Offset<IPlayMontage> montageOffset = (_o.Montage == null) ? default(Offset<IPlayMontage>) : IPlayMontage.Pack(builder, _o.Montage);
			Offset<ICameraData> cameraDataOffset = (_o.CameraData == null) ? default(Offset<ICameraData>) : ICameraData.Pack(builder, _o.CameraData);
			Offset<ISetFlowTemplate> flowTemplateOffset = (_o.FlowTemplate == null) ? default(Offset<ISetFlowTemplate>) : ISetFlowTemplate.Pack(builder, _o.FlowTemplate);
			VectorOffset flowTemplateListOffset = default(VectorOffset);
			if (_o.FlowTemplateList != null)
			{
				Offset<ISetFlowTemplate>[] array3 = new Offset<ISetFlowTemplate>[_o.FlowTemplateList.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = ISetFlowTemplate.Pack(builder, _o.FlowTemplateList[k]);
				}
				flowTemplateListOffset = ITalkItemPhoneMessage.CreateFlowTemplateListVector(builder, array3);
			}
			VectorOffset actorMontageArrayOffset = default(VectorOffset);
			if (_o.ActorMontageArray != null)
			{
				Offset<IMontageData>[] array4 = new Offset<IMontageData>[_o.ActorMontageArray.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IMontageData.Pack(builder, _o.ActorMontageArray[l]);
				}
				actorMontageArrayOffset = ITalkItemPhoneMessage.CreateActorMontageArrayVector(builder, array4);
			}
			VectorOffset actorFaceExpressionArrayOffset = default(VectorOffset);
			if (_o.ActorFaceExpressionArray != null)
			{
				Offset<IActorFaceExpression>[] array5 = new Offset<IActorFaceExpression>[_o.ActorFaceExpressionArray.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActorFaceExpression.Pack(builder, _o.ActorFaceExpressionArray[m]);
				}
				actorFaceExpressionArrayOffset = ITalkItemPhoneMessage.CreateActorFaceExpressionArrayVector(builder, array5);
			}
			VectorOffset actorLookAtArrayOffset = default(VectorOffset);
			if (_o.ActorLookAtArray != null)
			{
				Offset<IActorLookAt>[] array6 = new Offset<IActorLookAt>[_o.ActorLookAtArray.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = IActorLookAt.Pack(builder, _o.ActorLookAtArray[n]);
				}
				actorLookAtArrayOffset = ITalkItemPhoneMessage.CreateActorLookAtArrayVector(builder, array6);
			}
			VectorOffset actorTurnToArrayOffset = default(VectorOffset);
			if (_o.ActorTurnToArray != null)
			{
				Offset<IActorTurnTo>[] array7 = new Offset<IActorTurnTo>[_o.ActorTurnToArray.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = IActorTurnTo.Pack(builder, _o.ActorTurnToArray[num]);
				}
				actorTurnToArrayOffset = ITalkItemPhoneMessage.CreateActorTurnToArrayVector(builder, array7);
			}
			TPostAkEvent talkAkEvent_type = (_o.TalkAkEvent == null) ? TPostAkEvent.NONE : _o.TalkAkEvent.Type;
			int talkAkEventOffset = (_o.TalkAkEvent == null) ? 0 : TPostAkEventUnion.Pack(builder, _o.TalkAkEvent);
			TPostAkEvent talkEndAkEvent_type = (_o.TalkEndAkEvent == null) ? TPostAkEvent.NONE : _o.TalkEndAkEvent.Type;
			int talkEndAkEventOffset = (_o.TalkEndAkEvent == null) ? 0 : TPostAkEventUnion.Pack(builder, _o.TalkEndAkEvent);
			Offset<IUniversalTone> universalToneOffset = (_o.UniversalTone == null) ? default(Offset<IUniversalTone>) : IUniversalTone.Pack(builder, _o.UniversalTone);
			TTalkBackground backgroundConfig_type = (_o.BackgroundConfig == null) ? TTalkBackground.NONE : _o.BackgroundConfig.Type;
			int backgroundConfigOffset = (_o.BackgroundConfig == null) ? 0 : TTalkBackgroundUnion.Pack(builder, _o.BackgroundConfig);
			Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset = (_o.TimeLimitOptionGroup == null) ? default(Offset<ITimeLimitOptionGroup>) : ITimeLimitOptionGroup.Pack(builder, _o.TimeLimitOptionGroup);
			Offset<IGamepadShakeInTalk> gamepadShakeOffset = (_o.GamepadShake == null) ? default(Offset<IGamepadShakeInTalk>) : IGamepadShakeInTalk.Pack(builder, _o.GamepadShake);
			VectorOffset introActionsOffset = default(VectorOffset);
			if (_o.IntroActions != null)
			{
				Offset<IActionInfo>[] array8 = new Offset<IActionInfo>[_o.IntroActions.Count];
				for (int num2 = 0; num2 < array8.Length; num2++)
				{
					array8[num2] = IActionInfo.Pack(builder, _o.IntroActions[num2]);
				}
				introActionsOffset = ITalkItemPhoneMessage.CreateIntroActionsVector(builder, array8);
			}
			VectorOffset actorFxEmoteArrayOffset = default(VectorOffset);
			if (_o.ActorFxEmoteArray != null)
			{
				Offset<IActorFxEmote>[] array9 = new Offset<IActorFxEmote>[_o.ActorFxEmoteArray.Count];
				for (int num3 = 0; num3 < array9.Length; num3++)
				{
					array9[num3] = IActorFxEmote.Pack(builder, _o.ActorFxEmoteArray[num3]);
				}
				actorFxEmoteArrayOffset = ITalkItemPhoneMessage.CreateActorFxEmoteArrayVector(builder, array9);
			}
			VectorOffset talkEffectArray_typeOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				TTalkEffectAction[] array10 = new TTalkEffectAction[_o.TalkEffectArray.Count];
				for (int num4 = 0; num4 < array10.Length; num4++)
				{
					array10[num4] = _o.TalkEffectArray[num4].Type;
				}
				talkEffectArray_typeOffset = ITalkItemPhoneMessage.CreateTalkEffectArrayTypeVector(builder, array10);
			}
			VectorOffset talkEffectArrayOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				int[] array11 = new int[_o.TalkEffectArray.Count];
				for (int num5 = 0; num5 < array11.Length; num5++)
				{
					array11[num5] = TTalkEffectActionUnion.Pack(builder, _o.TalkEffectArray[num5]);
				}
				talkEffectArrayOffset = ITalkItemPhoneMessage.CreateTalkEffectArrayVector(builder, array11);
			}
			VectorOffset actorVisibilityArrayOffset = default(VectorOffset);
			if (_o.ActorVisibilityArray != null)
			{
				Offset<IActorVisibility>[] array12 = new Offset<IActorVisibility>[_o.ActorVisibilityArray.Count];
				for (int num6 = 0; num6 < array12.Length; num6++)
				{
					array12[num6] = IActorVisibility.Pack(builder, _o.ActorVisibilityArray[num6]);
				}
				actorVisibilityArrayOffset = ITalkItemPhoneMessage.CreateActorVisibilityArrayVector(builder, array12);
			}
			TPhoneMessageType messageType_type = (_o.MessageType == null) ? TPhoneMessageType.NONE : _o.MessageType.Type;
			int messageTypeOffset = (_o.MessageType == null) ? 0 : TPhoneMessageTypeUnion.Pack(builder, _o.MessageType);
			TTalkItemStyle style_type = (_o.Style == null) ? TTalkItemStyle.NONE : _o.Style.Type;
			int styleOffset = (_o.Style == null) ? 0 : TTalkItemStyleUnion.Pack(builder, _o.Style);
			return ITalkItemPhoneMessage.CreateITalkItemPhoneMessage(builder, _o.Type, _o.Id, _o.PlotLineId, plotLineKeyOffset, nameOffset, _o._Folded, _o._EditFlag, _o.WhoId, _o.TextId, tidTalkOffset, _o.WaitTime, captionParamsOffset, actionsOffset, optionsOffset, montageOffset, cameraDataOffset, flowTemplateOffset, flowTemplateListOffset, actorMontageArrayOffset, actorFaceExpressionArrayOffset, actorLookAtArrayOffset, actorTurnToArrayOffset, talkAkEvent_type, talkAkEventOffset, talkEndAkEvent_type, talkEndAkEventOffset, universalToneOffset, backgroundConfig_type, backgroundConfigOffset, _o.PlayVoice, timeLimitOptionGroupOffset, gamepadShakeOffset, introActionsOffset, actorFxEmoteArrayOffset, talkEffectArray_typeOffset, talkEffectArrayOffset, actorVisibilityArrayOffset, messageType_type, messageTypeOffset, style_type, styleOffset, _o.OtherIsTypingDuration, _o.NullMask);
		}

		// Token: 0x04012F7D RID: 77693
		private Table __p;
	}
}
