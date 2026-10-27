using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E6 RID: 29414
	public struct ITalkItemPhoneMessage : IFlatbufferObject
	{
		// Token: 0x1700DD0F RID: 56591
		// (get) Token: 0x06034D4A RID: 216394 RVA: 0x00726B20 File Offset: 0x00724D20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D4B RID: 216395 RVA: 0x00726B2D File Offset: 0x00724D2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D4C RID: 216396 RVA: 0x00726B34 File Offset: 0x00724D34
		public static ITalkItemPhoneMessage GetRootAsITalkItemPhoneMessage(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessage.GetRootAsITalkItemPhoneMessage(_bb, default(ITalkItemPhoneMessage));
		}

		// Token: 0x06034D4D RID: 216397 RVA: 0x00726B50 File Offset: 0x00724D50
		public static ITalkItemPhoneMessage GetRootAsITalkItemPhoneMessage(ByteBuffer _bb, ITalkItemPhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D4E RID: 216398 RVA: 0x00726B6D File Offset: 0x00724D6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D4F RID: 216399 RVA: 0x00726B7C File Offset: 0x00724D7C
		public ITalkItemPhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD10 RID: 56592
		// (get) Token: 0x06034D50 RID: 216400 RVA: 0x00726B8C File Offset: 0x00724D8C
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

		// Token: 0x1700DD11 RID: 56593
		// (get) Token: 0x06034D51 RID: 216401 RVA: 0x00726BC8 File Offset: 0x00724DC8
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

		// Token: 0x1700DD12 RID: 56594
		// (get) Token: 0x06034D52 RID: 216402 RVA: 0x00726C04 File Offset: 0x00724E04
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

		// Token: 0x1700DD13 RID: 56595
		// (get) Token: 0x06034D53 RID: 216403 RVA: 0x00726C40 File Offset: 0x00724E40
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

		// Token: 0x06034D54 RID: 216404 RVA: 0x00726C78 File Offset: 0x00724E78
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06034D55 RID: 216405 RVA: 0x00726C88 File Offset: 0x00724E88
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DD14 RID: 56596
		// (get) Token: 0x06034D56 RID: 216406 RVA: 0x00726C98 File Offset: 0x00724E98
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

		// Token: 0x06034D57 RID: 216407 RVA: 0x00726CD0 File Offset: 0x00724ED0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06034D58 RID: 216408 RVA: 0x00726CE0 File Offset: 0x00724EE0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700DD15 RID: 56597
		// (get) Token: 0x06034D59 RID: 216409 RVA: 0x00726CF0 File Offset: 0x00724EF0
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DD16 RID: 56598
		// (get) Token: 0x06034D5A RID: 216410 RVA: 0x00726D30 File Offset: 0x00724F30
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

		// Token: 0x1700DD17 RID: 56599
		// (get) Token: 0x06034D5B RID: 216411 RVA: 0x00726D70 File Offset: 0x00724F70
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

		// Token: 0x1700DD18 RID: 56600
		// (get) Token: 0x06034D5C RID: 216412 RVA: 0x00726DB0 File Offset: 0x00724FB0
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

		// Token: 0x1700DD19 RID: 56601
		// (get) Token: 0x06034D5D RID: 216413 RVA: 0x00726DF0 File Offset: 0x00724FF0
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

		// Token: 0x06034D5E RID: 216414 RVA: 0x00726E28 File Offset: 0x00725028
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06034D5F RID: 216415 RVA: 0x00726E38 File Offset: 0x00725038
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700DD1A RID: 56602
		// (get) Token: 0x06034D60 RID: 216416 RVA: 0x00726E48 File Offset: 0x00725048
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

		// Token: 0x1700DD1B RID: 56603
		// (get) Token: 0x06034D61 RID: 216417 RVA: 0x00726E8C File Offset: 0x0072508C
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

		// Token: 0x06034D62 RID: 216418 RVA: 0x00726EEC File Offset: 0x007250EC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD1C RID: 56604
		// (get) Token: 0x06034D63 RID: 216419 RVA: 0x00726F50 File Offset: 0x00725150
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

		// Token: 0x06034D64 RID: 216420 RVA: 0x00726F7C File Offset: 0x0072517C
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD1D RID: 56605
		// (get) Token: 0x06034D65 RID: 216421 RVA: 0x00726FE0 File Offset: 0x007251E0
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

		// Token: 0x1700DD1E RID: 56606
		// (get) Token: 0x06034D66 RID: 216422 RVA: 0x0072700C File Offset: 0x0072520C
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

		// Token: 0x1700DD1F RID: 56607
		// (get) Token: 0x06034D67 RID: 216423 RVA: 0x0072706C File Offset: 0x0072526C
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

		// Token: 0x1700DD20 RID: 56608
		// (get) Token: 0x06034D68 RID: 216424 RVA: 0x007270CC File Offset: 0x007252CC
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

		// Token: 0x06034D69 RID: 216425 RVA: 0x0072712C File Offset: 0x0072532C
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD21 RID: 56609
		// (get) Token: 0x06034D6A RID: 216426 RVA: 0x00727190 File Offset: 0x00725390
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

		// Token: 0x06034D6B RID: 216427 RVA: 0x007271BC File Offset: 0x007253BC
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD22 RID: 56610
		// (get) Token: 0x06034D6C RID: 216428 RVA: 0x00727220 File Offset: 0x00725420
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

		// Token: 0x06034D6D RID: 216429 RVA: 0x0072724C File Offset: 0x0072544C
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD23 RID: 56611
		// (get) Token: 0x06034D6E RID: 216430 RVA: 0x007272B0 File Offset: 0x007254B0
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

		// Token: 0x06034D6F RID: 216431 RVA: 0x007272DC File Offset: 0x007254DC
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD24 RID: 56612
		// (get) Token: 0x06034D70 RID: 216432 RVA: 0x00727340 File Offset: 0x00725540
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

		// Token: 0x06034D71 RID: 216433 RVA: 0x0072736C File Offset: 0x0072556C
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD25 RID: 56613
		// (get) Token: 0x06034D72 RID: 216434 RVA: 0x007273D0 File Offset: 0x007255D0
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

		// Token: 0x1700DD26 RID: 56614
		// (get) Token: 0x06034D73 RID: 216435 RVA: 0x007273FC File Offset: 0x007255FC
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

		// Token: 0x06034D74 RID: 216436 RVA: 0x0072743C File Offset: 0x0072563C
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034D75 RID: 216437 RVA: 0x00727484 File Offset: 0x00725684
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06034D76 RID: 216438 RVA: 0x007274A0 File Offset: 0x007256A0
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x06034D77 RID: 216439 RVA: 0x007274BC File Offset: 0x007256BC
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06034D78 RID: 216440 RVA: 0x007274D8 File Offset: 0x007256D8
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DD27 RID: 56615
		// (get) Token: 0x06034D79 RID: 216441 RVA: 0x007274F4 File Offset: 0x007256F4
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

		// Token: 0x06034D7A RID: 216442 RVA: 0x00727534 File Offset: 0x00725734
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034D7B RID: 216443 RVA: 0x0072757C File Offset: 0x0072577C
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06034D7C RID: 216444 RVA: 0x00727598 File Offset: 0x00725798
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x06034D7D RID: 216445 RVA: 0x007275B4 File Offset: 0x007257B4
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06034D7E RID: 216446 RVA: 0x007275D0 File Offset: 0x007257D0
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DD28 RID: 56616
		// (get) Token: 0x06034D7F RID: 216447 RVA: 0x007275EC File Offset: 0x007257EC
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

		// Token: 0x1700DD29 RID: 56617
		// (get) Token: 0x06034D80 RID: 216448 RVA: 0x0072764C File Offset: 0x0072584C
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

		// Token: 0x06034D81 RID: 216449 RVA: 0x0072768C File Offset: 0x0072588C
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034D82 RID: 216450 RVA: 0x007276D4 File Offset: 0x007258D4
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x06034D83 RID: 216451 RVA: 0x007276F0 File Offset: 0x007258F0
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x06034D84 RID: 216452 RVA: 0x0072770C File Offset: 0x0072590C
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x06034D85 RID: 216453 RVA: 0x00727728 File Offset: 0x00725928
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x06034D86 RID: 216454 RVA: 0x00727744 File Offset: 0x00725944
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700DD2A RID: 56618
		// (get) Token: 0x06034D87 RID: 216455 RVA: 0x00727760 File Offset: 0x00725960
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DD2B RID: 56619
		// (get) Token: 0x06034D88 RID: 216456 RVA: 0x007277A0 File Offset: 0x007259A0
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

		// Token: 0x1700DD2C RID: 56620
		// (get) Token: 0x06034D89 RID: 216457 RVA: 0x00727800 File Offset: 0x00725A00
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

		// Token: 0x06034D8A RID: 216458 RVA: 0x00727860 File Offset: 0x00725A60
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD2D RID: 56621
		// (get) Token: 0x06034D8B RID: 216459 RVA: 0x007278C4 File Offset: 0x00725AC4
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

		// Token: 0x06034D8C RID: 216460 RVA: 0x007278F0 File Offset: 0x00725AF0
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD2E RID: 56622
		// (get) Token: 0x06034D8D RID: 216461 RVA: 0x00727954 File Offset: 0x00725B54
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

		// Token: 0x06034D8E RID: 216462 RVA: 0x00727980 File Offset: 0x00725B80
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DD2F RID: 56623
		// (get) Token: 0x06034D8F RID: 216463 RVA: 0x007279C0 File Offset: 0x00725BC0
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

		// Token: 0x06034D90 RID: 216464 RVA: 0x007279EC File Offset: 0x00725BEC
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x06034D91 RID: 216465 RVA: 0x007279FC File Offset: 0x00725BFC
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

		// Token: 0x06034D92 RID: 216466 RVA: 0x00727A68 File Offset: 0x00725C68
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DD30 RID: 56624
		// (get) Token: 0x06034D93 RID: 216467 RVA: 0x00727AB0 File Offset: 0x00725CB0
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

		// Token: 0x06034D94 RID: 216468 RVA: 0x00727ADC File Offset: 0x00725CDC
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DD31 RID: 56625
		// (get) Token: 0x06034D95 RID: 216469 RVA: 0x00727B40 File Offset: 0x00725D40
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

		// Token: 0x1700DD32 RID: 56626
		// (get) Token: 0x06034D96 RID: 216470 RVA: 0x00727B6C File Offset: 0x00725D6C
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

		// Token: 0x06034D97 RID: 216471 RVA: 0x00727BAC File Offset: 0x00725DAC
		public TTable? MessageType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034D98 RID: 216472 RVA: 0x00727BF4 File Offset: 0x00725DF4
		public ITalkItemPhoneMessageAttachment MessageTypeAsITalkItemPhoneMessageAttachment()
		{
			return this.MessageType<ITalkItemPhoneMessageAttachment>().Value;
		}

		// Token: 0x06034D99 RID: 216473 RVA: 0x00727C10 File Offset: 0x00725E10
		public ITalkItemPhoneMessageEmoji MessageTypeAsITalkItemPhoneMessageEmoji()
		{
			return this.MessageType<ITalkItemPhoneMessageEmoji>().Value;
		}

		// Token: 0x06034D9A RID: 216474 RVA: 0x00727C2C File Offset: 0x00725E2C
		public ITalkItemPhoneMessageSystemTip MessageTypeAsITalkItemPhoneMessageSystemTip()
		{
			return this.MessageType<ITalkItemPhoneMessageSystemTip>().Value;
		}

		// Token: 0x06034D9B RID: 216475 RVA: 0x00727C48 File Offset: 0x00725E48
		public ITalkItemPhoneMessageVoice MessageTypeAsITalkItemPhoneMessageVoice()
		{
			return this.MessageType<ITalkItemPhoneMessageVoice>().Value;
		}

		// Token: 0x1700DD33 RID: 56627
		// (get) Token: 0x06034D9C RID: 216476 RVA: 0x00727C64 File Offset: 0x00725E64
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

		// Token: 0x06034D9D RID: 216477 RVA: 0x00727CA4 File Offset: 0x00725EA4
		public TTable? Style<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(84);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034D9E RID: 216478 RVA: 0x00727CEC File Offset: 0x00725EEC
		public ITalkItemStyleInnerVoice StyleAsITalkItemStyleInnerVoice()
		{
			return this.Style<ITalkItemStyleInnerVoice>().Value;
		}

		// Token: 0x06034D9F RID: 216479 RVA: 0x00727D08 File Offset: 0x00725F08
		public ITalkItemStylePhoneSendError StyleAsITalkItemStylePhoneSendError()
		{
			return this.Style<ITalkItemStylePhoneSendError>().Value;
		}

		// Token: 0x1700DD34 RID: 56628
		// (get) Token: 0x06034DA0 RID: 216480 RVA: 0x00727D24 File Offset: 0x00725F24
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

		// Token: 0x1700DD35 RID: 56629
		// (get) Token: 0x06034DA1 RID: 216481 RVA: 0x00727D68 File Offset: 0x00725F68
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

		// Token: 0x06034DA2 RID: 216482 RVA: 0x00727DA8 File Offset: 0x00725FA8
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

		// Token: 0x06034DA3 RID: 216483 RVA: 0x00727F18 File Offset: 0x00726118
		public static void StartITalkItemPhoneMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(43);
		}

		// Token: 0x06034DA4 RID: 216484 RVA: 0x00727F22 File Offset: 0x00726122
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034DA5 RID: 216485 RVA: 0x00727F2D File Offset: 0x0072612D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06034DA6 RID: 216486 RVA: 0x00727F38 File Offset: 0x00726138
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x06034DA7 RID: 216487 RVA: 0x00727F43 File Offset: 0x00726143
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06034DA8 RID: 216488 RVA: 0x00727F53 File Offset: 0x00726153
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x06034DA9 RID: 216489 RVA: 0x00727F63 File Offset: 0x00726163
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x06034DAA RID: 216490 RVA: 0x00727F6E File Offset: 0x0072616E
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x06034DAB RID: 216491 RVA: 0x00727F79 File Offset: 0x00726179
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x06034DAC RID: 216492 RVA: 0x00727F84 File Offset: 0x00726184
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x06034DAD RID: 216493 RVA: 0x00727F8F File Offset: 0x0072618F
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x06034DAE RID: 216494 RVA: 0x00727FA0 File Offset: 0x007261A0
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x06034DAF RID: 216495 RVA: 0x00727FB4 File Offset: 0x007261B4
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x06034DB0 RID: 216496 RVA: 0x00727FC5 File Offset: 0x007261C5
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x06034DB1 RID: 216497 RVA: 0x00727FD8 File Offset: 0x007261D8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DB2 RID: 216498 RVA: 0x00728018 File Offset: 0x00726218
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DB3 RID: 216499 RVA: 0x00728032 File Offset: 0x00726232
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DB4 RID: 216500 RVA: 0x00728050 File Offset: 0x00726250
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DB5 RID: 216501 RVA: 0x00728069 File Offset: 0x00726269
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DB6 RID: 216502 RVA: 0x00728074 File Offset: 0x00726274
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x06034DB7 RID: 216503 RVA: 0x00728088 File Offset: 0x00726288
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DB8 RID: 216504 RVA: 0x007280C8 File Offset: 0x007262C8
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DB9 RID: 216505 RVA: 0x007280E2 File Offset: 0x007262E2
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DBA RID: 216506 RVA: 0x00728100 File Offset: 0x00726300
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DBB RID: 216507 RVA: 0x00728119 File Offset: 0x00726319
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DBC RID: 216508 RVA: 0x00728124 File Offset: 0x00726324
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x06034DBD RID: 216509 RVA: 0x00728135 File Offset: 0x00726335
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x06034DBE RID: 216510 RVA: 0x00728146 File Offset: 0x00726346
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x06034DBF RID: 216511 RVA: 0x00728157 File Offset: 0x00726357
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x06034DC0 RID: 216512 RVA: 0x00728168 File Offset: 0x00726368
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DC1 RID: 216513 RVA: 0x007281A8 File Offset: 0x007263A8
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DC2 RID: 216514 RVA: 0x007281C2 File Offset: 0x007263C2
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DC3 RID: 216515 RVA: 0x007281E0 File Offset: 0x007263E0
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DC4 RID: 216516 RVA: 0x007281F9 File Offset: 0x007263F9
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DC5 RID: 216517 RVA: 0x00728204 File Offset: 0x00726404
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x06034DC6 RID: 216518 RVA: 0x00728218 File Offset: 0x00726418
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DC7 RID: 216519 RVA: 0x00728258 File Offset: 0x00726458
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DC8 RID: 216520 RVA: 0x00728272 File Offset: 0x00726472
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DC9 RID: 216521 RVA: 0x00728290 File Offset: 0x00726490
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DCA RID: 216522 RVA: 0x007282A9 File Offset: 0x007264A9
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DCB RID: 216523 RVA: 0x007282B4 File Offset: 0x007264B4
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x06034DCC RID: 216524 RVA: 0x007282C8 File Offset: 0x007264C8
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DCD RID: 216525 RVA: 0x00728308 File Offset: 0x00726508
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DCE RID: 216526 RVA: 0x00728322 File Offset: 0x00726522
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DCF RID: 216527 RVA: 0x00728340 File Offset: 0x00726540
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DD0 RID: 216528 RVA: 0x00728359 File Offset: 0x00726559
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DD1 RID: 216529 RVA: 0x00728364 File Offset: 0x00726564
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x06034DD2 RID: 216530 RVA: 0x00728378 File Offset: 0x00726578
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DD3 RID: 216531 RVA: 0x007283B8 File Offset: 0x007265B8
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DD4 RID: 216532 RVA: 0x007283D2 File Offset: 0x007265D2
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DD5 RID: 216533 RVA: 0x007283F0 File Offset: 0x007265F0
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DD6 RID: 216534 RVA: 0x00728409 File Offset: 0x00726609
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DD7 RID: 216535 RVA: 0x00728414 File Offset: 0x00726614
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x06034DD8 RID: 216536 RVA: 0x00728428 File Offset: 0x00726628
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DD9 RID: 216537 RVA: 0x00728468 File Offset: 0x00726668
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DDA RID: 216538 RVA: 0x00728482 File Offset: 0x00726682
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DDB RID: 216539 RVA: 0x007284A0 File Offset: 0x007266A0
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DDC RID: 216540 RVA: 0x007284B9 File Offset: 0x007266B9
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DDD RID: 216541 RVA: 0x007284C4 File Offset: 0x007266C4
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x06034DDE RID: 216542 RVA: 0x007284D0 File Offset: 0x007266D0
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x06034DDF RID: 216543 RVA: 0x007284DC File Offset: 0x007266DC
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x06034DE0 RID: 216544 RVA: 0x007284E8 File Offset: 0x007266E8
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x06034DE1 RID: 216545 RVA: 0x007284F4 File Offset: 0x007266F4
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x06034DE2 RID: 216546 RVA: 0x00728505 File Offset: 0x00726705
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x06034DE3 RID: 216547 RVA: 0x00728511 File Offset: 0x00726711
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x06034DE4 RID: 216548 RVA: 0x0072851D File Offset: 0x0072671D
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x06034DE5 RID: 216549 RVA: 0x00728529 File Offset: 0x00726729
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x06034DE6 RID: 216550 RVA: 0x0072853A File Offset: 0x0072673A
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x06034DE7 RID: 216551 RVA: 0x0072854B File Offset: 0x0072674B
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x06034DE8 RID: 216552 RVA: 0x0072855C File Offset: 0x0072675C
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DE9 RID: 216553 RVA: 0x0072859C File Offset: 0x0072679C
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DEA RID: 216554 RVA: 0x007285B6 File Offset: 0x007267B6
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DEB RID: 216555 RVA: 0x007285D4 File Offset: 0x007267D4
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DEC RID: 216556 RVA: 0x007285ED File Offset: 0x007267ED
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DED RID: 216557 RVA: 0x007285F8 File Offset: 0x007267F8
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x06034DEE RID: 216558 RVA: 0x0072860C File Offset: 0x0072680C
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DEF RID: 216559 RVA: 0x0072864C File Offset: 0x0072684C
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DF0 RID: 216560 RVA: 0x00728666 File Offset: 0x00726866
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DF1 RID: 216561 RVA: 0x00728684 File Offset: 0x00726884
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DF2 RID: 216562 RVA: 0x0072869D File Offset: 0x0072689D
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DF3 RID: 216563 RVA: 0x007286A8 File Offset: 0x007268A8
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x06034DF4 RID: 216564 RVA: 0x007286BC File Offset: 0x007268BC
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DF5 RID: 216565 RVA: 0x007286F3 File Offset: 0x007268F3
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DF6 RID: 216566 RVA: 0x0072870D File Offset: 0x0072690D
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DF7 RID: 216567 RVA: 0x0072872B File Offset: 0x0072692B
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DF8 RID: 216568 RVA: 0x00728744 File Offset: 0x00726944
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06034DF9 RID: 216569 RVA: 0x0072874F File Offset: 0x0072694F
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x06034DFA RID: 216570 RVA: 0x00728760 File Offset: 0x00726960
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034DFB RID: 216571 RVA: 0x00728797 File Offset: 0x00726997
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DFC RID: 216572 RVA: 0x007287B1 File Offset: 0x007269B1
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034DFD RID: 216573 RVA: 0x007287CF File Offset: 0x007269CF
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034DFE RID: 216574 RVA: 0x007287E8 File Offset: 0x007269E8
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034DFF RID: 216575 RVA: 0x007287F3 File Offset: 0x007269F3
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x06034E00 RID: 216576 RVA: 0x00728804 File Offset: 0x00726A04
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034E01 RID: 216577 RVA: 0x00728844 File Offset: 0x00726A44
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034E02 RID: 216578 RVA: 0x0072885E File Offset: 0x00726A5E
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034E03 RID: 216579 RVA: 0x0072887C File Offset: 0x00726A7C
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034E04 RID: 216580 RVA: 0x00728895 File Offset: 0x00726A95
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034E05 RID: 216581 RVA: 0x007288A0 File Offset: 0x00726AA0
		public static void AddMessageTypeType(FlatBufferBuilder builder, TPhoneMessageType messageTypeType)
		{
			builder.AddByte(37, (byte)messageTypeType, 0);
		}

		// Token: 0x06034E06 RID: 216582 RVA: 0x007288AC File Offset: 0x00726AAC
		public static void AddMessageType(FlatBufferBuilder builder, int messageTypeOffset)
		{
			builder.AddOffset(38, messageTypeOffset, 0);
		}

		// Token: 0x06034E07 RID: 216583 RVA: 0x007288B8 File Offset: 0x00726AB8
		public static void AddStyleType(FlatBufferBuilder builder, TTalkItemStyle styleType)
		{
			builder.AddByte(39, (byte)styleType, 0);
		}

		// Token: 0x06034E08 RID: 216584 RVA: 0x007288C4 File Offset: 0x00726AC4
		public static void AddStyle(FlatBufferBuilder builder, int styleOffset)
		{
			builder.AddOffset(40, styleOffset, 0);
		}

		// Token: 0x06034E09 RID: 216585 RVA: 0x007288D0 File Offset: 0x00726AD0
		public static void AddOtherIsTypingDuration(FlatBufferBuilder builder, float otherIsTypingDuration)
		{
			builder.AddFloat(41, otherIsTypingDuration, 0.0);
		}

		// Token: 0x06034E0A RID: 216586 RVA: 0x007288E4 File Offset: 0x00726AE4
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(42, nullMask, 0U);
		}

		// Token: 0x06034E0B RID: 216587 RVA: 0x007288F0 File Offset: 0x00726AF0
		public static Offset<ITalkItemPhoneMessage> EndITalkItemPhoneMessage(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessage>(builder.EndTable());
		}

		// Token: 0x06034E0C RID: 216588 RVA: 0x00728900 File Offset: 0x00726B00
		public ITalkItemPhoneMessageT UnPack()
		{
			ITalkItemPhoneMessageT talkItemPhoneMessageT = new ITalkItemPhoneMessageT();
			this.UnPackTo(talkItemPhoneMessageT);
			return talkItemPhoneMessageT;
		}

		// Token: 0x06034E0D RID: 216589 RVA: 0x0072891C File Offset: 0x00726B1C
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
			TTalkItemStyle styleType = this.StyleType;
			if (styleType != TTalkItemStyle.ITalkItemStyleInnerVoice)
			{
				if (styleType == TTalkItemStyle.ITalkItemStylePhoneSendError)
				{
					_o.Style.Value = ((this.Style<ITalkItemStylePhoneSendError>() != null) ? this.Style<ITalkItemStylePhoneSendError>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Style.Value = ((this.Style<ITalkItemStyleInnerVoice>() != null) ? this.Style<ITalkItemStyleInnerVoice>().Value.UnPack() : null);
			}
			_o.OtherIsTypingDuration = this.OtherIsTypingDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034E0E RID: 216590 RVA: 0x007294FC File Offset: 0x007276FC
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

		// Token: 0x04011F7A RID: 73594
		private Table __p;
	}
}
