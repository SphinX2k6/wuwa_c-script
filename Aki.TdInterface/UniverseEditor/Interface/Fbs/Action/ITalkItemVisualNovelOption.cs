using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007316 RID: 29462
	public struct ITalkItemVisualNovelOption : IFlatbufferObject
	{
		// Token: 0x1700DF11 RID: 57105
		// (get) Token: 0x060354C3 RID: 218307 RVA: 0x0073F490 File Offset: 0x0073D690
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060354C4 RID: 218308 RVA: 0x0073F49D File Offset: 0x0073D69D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060354C5 RID: 218309 RVA: 0x0073F4A4 File Offset: 0x0073D6A4
		public static ITalkItemVisualNovelOption GetRootAsITalkItemVisualNovelOption(ByteBuffer _bb)
		{
			return ITalkItemVisualNovelOption.GetRootAsITalkItemVisualNovelOption(_bb, default(ITalkItemVisualNovelOption));
		}

		// Token: 0x060354C6 RID: 218310 RVA: 0x0073F4C0 File Offset: 0x0073D6C0
		public static ITalkItemVisualNovelOption GetRootAsITalkItemVisualNovelOption(ByteBuffer _bb, ITalkItemVisualNovelOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060354C7 RID: 218311 RVA: 0x0073F4DD File Offset: 0x0073D6DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060354C8 RID: 218312 RVA: 0x0073F4EC File Offset: 0x0073D6EC
		public ITalkItemVisualNovelOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF12 RID: 57106
		// (get) Token: 0x060354C9 RID: 218313 RVA: 0x0073F4FC File Offset: 0x0073D6FC
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

		// Token: 0x1700DF13 RID: 57107
		// (get) Token: 0x060354CA RID: 218314 RVA: 0x0073F538 File Offset: 0x0073D738
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

		// Token: 0x1700DF14 RID: 57108
		// (get) Token: 0x060354CB RID: 218315 RVA: 0x0073F574 File Offset: 0x0073D774
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

		// Token: 0x1700DF15 RID: 57109
		// (get) Token: 0x060354CC RID: 218316 RVA: 0x0073F5B0 File Offset: 0x0073D7B0
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

		// Token: 0x060354CD RID: 218317 RVA: 0x0073F5E8 File Offset: 0x0073D7E8
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060354CE RID: 218318 RVA: 0x0073F5F8 File Offset: 0x0073D7F8
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DF16 RID: 57110
		// (get) Token: 0x060354CF RID: 218319 RVA: 0x0073F608 File Offset: 0x0073D808
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

		// Token: 0x060354D0 RID: 218320 RVA: 0x0073F640 File Offset: 0x0073D840
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060354D1 RID: 218321 RVA: 0x0073F650 File Offset: 0x0073D850
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700DF17 RID: 57111
		// (get) Token: 0x060354D2 RID: 218322 RVA: 0x0073F660 File Offset: 0x0073D860
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF18 RID: 57112
		// (get) Token: 0x060354D3 RID: 218323 RVA: 0x0073F6A0 File Offset: 0x0073D8A0
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

		// Token: 0x1700DF19 RID: 57113
		// (get) Token: 0x060354D4 RID: 218324 RVA: 0x0073F6E0 File Offset: 0x0073D8E0
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

		// Token: 0x1700DF1A RID: 57114
		// (get) Token: 0x060354D5 RID: 218325 RVA: 0x0073F720 File Offset: 0x0073D920
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

		// Token: 0x1700DF1B RID: 57115
		// (get) Token: 0x060354D6 RID: 218326 RVA: 0x0073F760 File Offset: 0x0073D960
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

		// Token: 0x060354D7 RID: 218327 RVA: 0x0073F798 File Offset: 0x0073D998
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060354D8 RID: 218328 RVA: 0x0073F7A8 File Offset: 0x0073D9A8
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700DF1C RID: 57116
		// (get) Token: 0x060354D9 RID: 218329 RVA: 0x0073F7B8 File Offset: 0x0073D9B8
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

		// Token: 0x1700DF1D RID: 57117
		// (get) Token: 0x060354DA RID: 218330 RVA: 0x0073F7FC File Offset: 0x0073D9FC
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

		// Token: 0x060354DB RID: 218331 RVA: 0x0073F85C File Offset: 0x0073DA5C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF1E RID: 57118
		// (get) Token: 0x060354DC RID: 218332 RVA: 0x0073F8C0 File Offset: 0x0073DAC0
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

		// Token: 0x060354DD RID: 218333 RVA: 0x0073F8EC File Offset: 0x0073DAEC
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF1F RID: 57119
		// (get) Token: 0x060354DE RID: 218334 RVA: 0x0073F950 File Offset: 0x0073DB50
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

		// Token: 0x1700DF20 RID: 57120
		// (get) Token: 0x060354DF RID: 218335 RVA: 0x0073F97C File Offset: 0x0073DB7C
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

		// Token: 0x1700DF21 RID: 57121
		// (get) Token: 0x060354E0 RID: 218336 RVA: 0x0073F9DC File Offset: 0x0073DBDC
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

		// Token: 0x1700DF22 RID: 57122
		// (get) Token: 0x060354E1 RID: 218337 RVA: 0x0073FA3C File Offset: 0x0073DC3C
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

		// Token: 0x060354E2 RID: 218338 RVA: 0x0073FA9C File Offset: 0x0073DC9C
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF23 RID: 57123
		// (get) Token: 0x060354E3 RID: 218339 RVA: 0x0073FB00 File Offset: 0x0073DD00
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

		// Token: 0x060354E4 RID: 218340 RVA: 0x0073FB2C File Offset: 0x0073DD2C
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF24 RID: 57124
		// (get) Token: 0x060354E5 RID: 218341 RVA: 0x0073FB90 File Offset: 0x0073DD90
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

		// Token: 0x060354E6 RID: 218342 RVA: 0x0073FBBC File Offset: 0x0073DDBC
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF25 RID: 57125
		// (get) Token: 0x060354E7 RID: 218343 RVA: 0x0073FC20 File Offset: 0x0073DE20
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

		// Token: 0x060354E8 RID: 218344 RVA: 0x0073FC4C File Offset: 0x0073DE4C
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF26 RID: 57126
		// (get) Token: 0x060354E9 RID: 218345 RVA: 0x0073FCB0 File Offset: 0x0073DEB0
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

		// Token: 0x060354EA RID: 218346 RVA: 0x0073FCDC File Offset: 0x0073DEDC
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF27 RID: 57127
		// (get) Token: 0x060354EB RID: 218347 RVA: 0x0073FD40 File Offset: 0x0073DF40
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

		// Token: 0x1700DF28 RID: 57128
		// (get) Token: 0x060354EC RID: 218348 RVA: 0x0073FD6C File Offset: 0x0073DF6C
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

		// Token: 0x060354ED RID: 218349 RVA: 0x0073FDAC File Offset: 0x0073DFAC
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060354EE RID: 218350 RVA: 0x0073FDF4 File Offset: 0x0073DFF4
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x060354EF RID: 218351 RVA: 0x0073FE10 File Offset: 0x0073E010
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x060354F0 RID: 218352 RVA: 0x0073FE2C File Offset: 0x0073E02C
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x060354F1 RID: 218353 RVA: 0x0073FE48 File Offset: 0x0073E048
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DF29 RID: 57129
		// (get) Token: 0x060354F2 RID: 218354 RVA: 0x0073FE64 File Offset: 0x0073E064
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

		// Token: 0x060354F3 RID: 218355 RVA: 0x0073FEA4 File Offset: 0x0073E0A4
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060354F4 RID: 218356 RVA: 0x0073FEEC File Offset: 0x0073E0EC
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x060354F5 RID: 218357 RVA: 0x0073FF08 File Offset: 0x0073E108
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x060354F6 RID: 218358 RVA: 0x0073FF24 File Offset: 0x0073E124
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x060354F7 RID: 218359 RVA: 0x0073FF40 File Offset: 0x0073E140
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DF2A RID: 57130
		// (get) Token: 0x060354F8 RID: 218360 RVA: 0x0073FF5C File Offset: 0x0073E15C
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

		// Token: 0x1700DF2B RID: 57131
		// (get) Token: 0x060354F9 RID: 218361 RVA: 0x0073FFBC File Offset: 0x0073E1BC
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

		// Token: 0x060354FA RID: 218362 RVA: 0x0073FFFC File Offset: 0x0073E1FC
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060354FB RID: 218363 RVA: 0x00740044 File Offset: 0x0073E244
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x060354FC RID: 218364 RVA: 0x00740060 File Offset: 0x0073E260
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x060354FD RID: 218365 RVA: 0x0074007C File Offset: 0x0073E27C
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x060354FE RID: 218366 RVA: 0x00740098 File Offset: 0x0073E298
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x060354FF RID: 218367 RVA: 0x007400B4 File Offset: 0x0073E2B4
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700DF2C RID: 57132
		// (get) Token: 0x06035500 RID: 218368 RVA: 0x007400D0 File Offset: 0x0073E2D0
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF2D RID: 57133
		// (get) Token: 0x06035501 RID: 218369 RVA: 0x00740110 File Offset: 0x0073E310
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

		// Token: 0x1700DF2E RID: 57134
		// (get) Token: 0x06035502 RID: 218370 RVA: 0x00740170 File Offset: 0x0073E370
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

		// Token: 0x06035503 RID: 218371 RVA: 0x007401D0 File Offset: 0x0073E3D0
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF2F RID: 57135
		// (get) Token: 0x06035504 RID: 218372 RVA: 0x00740234 File Offset: 0x0073E434
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

		// Token: 0x06035505 RID: 218373 RVA: 0x00740260 File Offset: 0x0073E460
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF30 RID: 57136
		// (get) Token: 0x06035506 RID: 218374 RVA: 0x007402C4 File Offset: 0x0073E4C4
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

		// Token: 0x06035507 RID: 218375 RVA: 0x007402F0 File Offset: 0x0073E4F0
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DF31 RID: 57137
		// (get) Token: 0x06035508 RID: 218376 RVA: 0x00740330 File Offset: 0x0073E530
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

		// Token: 0x06035509 RID: 218377 RVA: 0x0074035C File Offset: 0x0073E55C
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x0603550A RID: 218378 RVA: 0x0074036C File Offset: 0x0073E56C
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

		// Token: 0x0603550B RID: 218379 RVA: 0x007403D8 File Offset: 0x0073E5D8
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DF32 RID: 57138
		// (get) Token: 0x0603550C RID: 218380 RVA: 0x00740420 File Offset: 0x0073E620
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

		// Token: 0x0603550D RID: 218381 RVA: 0x0074044C File Offset: 0x0073E64C
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF33 RID: 57139
		// (get) Token: 0x0603550E RID: 218382 RVA: 0x007404B0 File Offset: 0x0073E6B0
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

		// Token: 0x1700DF34 RID: 57140
		// (get) Token: 0x0603550F RID: 218383 RVA: 0x007404DC File Offset: 0x0073E6DC
		public EVisualNovelOptionInteractionType OptionInteractionType
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return EVisualNovelOptionInteractionType.HideAndAutoSelect;
				}
				return (EVisualNovelOptionInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF35 RID: 57141
		// (get) Token: 0x06035510 RID: 218384 RVA: 0x0074051C File Offset: 0x0073E71C
		public IVisualNovelOptionGroupSolarSchoolExam? OptionGroup
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelOptionGroupSolarSchoolExam?(default(IVisualNovelOptionGroupSolarSchoolExam).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DF36 RID: 57142
		// (get) Token: 0x06035511 RID: 218385 RVA: 0x0074057C File Offset: 0x0073E77C
		public int CustomDescTextId
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF37 RID: 57143
		// (get) Token: 0x06035512 RID: 218386 RVA: 0x007405BC File Offset: 0x0073E7BC
		public string TidCustomDescText
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035513 RID: 218387 RVA: 0x007405F4 File Offset: 0x0073E7F4
		public Span<byte> GetTidCustomDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x06035514 RID: 218388 RVA: 0x00740604 File Offset: 0x0073E804
		public byte[] GetTidCustomDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(84);
		}

		// Token: 0x1700DF38 RID: 57144
		// (get) Token: 0x06035515 RID: 218389 RVA: 0x00740614 File Offset: 0x0073E814
		public TVisualNovelBackground VisualNovelBackgroundConfigType
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return TVisualNovelBackground.NONE;
				}
				return (TVisualNovelBackground)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035516 RID: 218390 RVA: 0x00740654 File Offset: 0x0073E854
		public TTable? VisualNovelBackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(88);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035517 RID: 218391 RVA: 0x0074069C File Offset: 0x0073E89C
		public IVisualNovelBackgroundClean VisualNovelBackgroundConfigAsIVisualNovelBackgroundClean()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundClean>().Value;
		}

		// Token: 0x06035518 RID: 218392 RVA: 0x007406B8 File Offset: 0x0073E8B8
		public IVisualNovelBackgroundLoad VisualNovelBackgroundConfigAsIVisualNovelBackgroundLoad()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundLoad>().Value;
		}

		// Token: 0x1700DF39 RID: 57145
		// (get) Token: 0x06035519 RID: 218393 RVA: 0x007406D4 File Offset: 0x0073E8D4
		public TVisualNovelCg CgConfigType
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return TVisualNovelCg.NONE;
				}
				return (TVisualNovelCg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603551A RID: 218394 RVA: 0x00740714 File Offset: 0x0073E914
		public TTable? CgConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603551B RID: 218395 RVA: 0x0074075C File Offset: 0x0073E95C
		public IVisualNovelCgClean CgConfigAsIVisualNovelCgClean()
		{
			return this.CgConfig<IVisualNovelCgClean>().Value;
		}

		// Token: 0x0603551C RID: 218396 RVA: 0x00740778 File Offset: 0x0073E978
		public IVisualNovelCgLoadImage CgConfigAsIVisualNovelCgLoadImage()
		{
			return this.CgConfig<IVisualNovelCgLoadImage>().Value;
		}

		// Token: 0x0603551D RID: 218397 RVA: 0x00740794 File Offset: 0x0073E994
		public IVisualNovelCgLoadSpine CgConfigAsIVisualNovelCgLoadSpine()
		{
			return this.CgConfig<IVisualNovelCgLoadSpine>().Value;
		}

		// Token: 0x1700DF3A RID: 57146
		// (get) Token: 0x0603551E RID: 218398 RVA: 0x007407B0 File Offset: 0x0073E9B0
		public TVisualNovelDisplayItem DisplayItemConfigType
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return TVisualNovelDisplayItem.NONE;
				}
				return (TVisualNovelDisplayItem)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603551F RID: 218399 RVA: 0x007407F0 File Offset: 0x0073E9F0
		public TTable? DisplayItemConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(96);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035520 RID: 218400 RVA: 0x00740838 File Offset: 0x0073EA38
		public IVisualNovelDisplayItemClose DisplayItemConfigAsIVisualNovelDisplayItemClose()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemClose>().Value;
		}

		// Token: 0x06035521 RID: 218401 RVA: 0x00740854 File Offset: 0x0073EA54
		public IVisualNovelDisplayItemImage DisplayItemConfigAsIVisualNovelDisplayItemImage()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemImage>().Value;
		}

		// Token: 0x06035522 RID: 218402 RVA: 0x00740870 File Offset: 0x0073EA70
		public IVisualNovelDisplayItemPrefab DisplayItemConfigAsIVisualNovelDisplayItemPrefab()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemPrefab>().Value;
		}

		// Token: 0x1700DF3B RID: 57147
		// (get) Token: 0x06035523 RID: 218403 RVA: 0x0074088C File Offset: 0x0073EA8C
		public int PlotKeyId
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF3C RID: 57148
		// (get) Token: 0x06035524 RID: 218404 RVA: 0x007408CC File Offset: 0x0073EACC
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035525 RID: 218405 RVA: 0x0074090C File Offset: 0x0073EB0C
		public static Offset<ITalkItemVisualNovelOption> CreateITalkItemVisualNovelOption(FlatBufferBuilder builder, ETalkItemType Type = ETalkItemType.Talk, int Id = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, int WhoId = 0, int TextId = 0, StringOffset TidTalkOffset = default(StringOffset), float WaitTime = 0f, Offset<ICaptionParam> CaptionParamsOffset = default(Offset<ICaptionParam>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), Offset<IPlayMontage> MontageOffset = default(Offset<IPlayMontage>), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>), Offset<ISetFlowTemplate> FlowTemplateOffset = default(Offset<ISetFlowTemplate>), VectorOffset FlowTemplateListOffset = default(VectorOffset), VectorOffset ActorMontageArrayOffset = default(VectorOffset), VectorOffset ActorFaceExpressionArrayOffset = default(VectorOffset), VectorOffset ActorLookAtArrayOffset = default(VectorOffset), VectorOffset ActorTurnToArrayOffset = default(VectorOffset), TPostAkEvent TalkAkEvent_type = TPostAkEvent.NONE, int TalkAkEventOffset = 0, TPostAkEvent TalkEndAkEvent_type = TPostAkEvent.NONE, int TalkEndAkEventOffset = 0, Offset<IUniversalTone> UniversalToneOffset = default(Offset<IUniversalTone>), TTalkBackground BackgroundConfig_type = TTalkBackground.NONE, int BackgroundConfigOffset = 0, bool PlayVoice = false, Offset<ITimeLimitOptionGroup> TimeLimitOptionGroupOffset = default(Offset<ITimeLimitOptionGroup>), Offset<IGamepadShakeInTalk> GamepadShakeOffset = default(Offset<IGamepadShakeInTalk>), VectorOffset IntroActionsOffset = default(VectorOffset), VectorOffset ActorFxEmoteArrayOffset = default(VectorOffset), VectorOffset TalkEffectArray_typeOffset = default(VectorOffset), VectorOffset TalkEffectArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), EVisualNovelOptionInteractionType OptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect, Offset<IVisualNovelOptionGroupSolarSchoolExam> OptionGroupOffset = default(Offset<IVisualNovelOptionGroupSolarSchoolExam>), int CustomDescTextId = 0, StringOffset TidCustomDescTextOffset = default(StringOffset), TVisualNovelBackground VisualNovelBackgroundConfig_type = TVisualNovelBackground.NONE, int VisualNovelBackgroundConfigOffset = 0, TVisualNovelCg CgConfig_type = TVisualNovelCg.NONE, int CgConfigOffset = 0, TVisualNovelDisplayItem DisplayItemConfig_type = TVisualNovelDisplayItem.NONE, int DisplayItemConfigOffset = 0, int PlotKeyId = 0, uint NullMask = 0U)
		{
			builder.StartTable(49);
			ITalkItemVisualNovelOption.AddNullMask(builder, NullMask);
			ITalkItemVisualNovelOption.AddPlotKeyId(builder, PlotKeyId);
			ITalkItemVisualNovelOption.AddDisplayItemConfig(builder, DisplayItemConfigOffset);
			ITalkItemVisualNovelOption.AddCgConfig(builder, CgConfigOffset);
			ITalkItemVisualNovelOption.AddVisualNovelBackgroundConfig(builder, VisualNovelBackgroundConfigOffset);
			ITalkItemVisualNovelOption.AddTidCustomDescText(builder, TidCustomDescTextOffset);
			ITalkItemVisualNovelOption.AddCustomDescTextId(builder, CustomDescTextId);
			ITalkItemVisualNovelOption.AddOptionGroup(builder, OptionGroupOffset);
			ITalkItemVisualNovelOption.AddActorVisibilityArray(builder, ActorVisibilityArrayOffset);
			ITalkItemVisualNovelOption.AddTalkEffectArray(builder, TalkEffectArrayOffset);
			ITalkItemVisualNovelOption.AddTalkEffectArrayType(builder, TalkEffectArray_typeOffset);
			ITalkItemVisualNovelOption.AddActorFxEmoteArray(builder, ActorFxEmoteArrayOffset);
			ITalkItemVisualNovelOption.AddIntroActions(builder, IntroActionsOffset);
			ITalkItemVisualNovelOption.AddGamepadShake(builder, GamepadShakeOffset);
			ITalkItemVisualNovelOption.AddTimeLimitOptionGroup(builder, TimeLimitOptionGroupOffset);
			ITalkItemVisualNovelOption.AddBackgroundConfig(builder, BackgroundConfigOffset);
			ITalkItemVisualNovelOption.AddUniversalTone(builder, UniversalToneOffset);
			ITalkItemVisualNovelOption.AddTalkEndAkEvent(builder, TalkEndAkEventOffset);
			ITalkItemVisualNovelOption.AddTalkAkEvent(builder, TalkAkEventOffset);
			ITalkItemVisualNovelOption.AddActorTurnToArray(builder, ActorTurnToArrayOffset);
			ITalkItemVisualNovelOption.AddActorLookAtArray(builder, ActorLookAtArrayOffset);
			ITalkItemVisualNovelOption.AddActorFaceExpressionArray(builder, ActorFaceExpressionArrayOffset);
			ITalkItemVisualNovelOption.AddActorMontageArray(builder, ActorMontageArrayOffset);
			ITalkItemVisualNovelOption.AddFlowTemplateList(builder, FlowTemplateListOffset);
			ITalkItemVisualNovelOption.AddFlowTemplate(builder, FlowTemplateOffset);
			ITalkItemVisualNovelOption.AddCameraData(builder, CameraDataOffset);
			ITalkItemVisualNovelOption.AddMontage(builder, MontageOffset);
			ITalkItemVisualNovelOption.AddOptions(builder, OptionsOffset);
			ITalkItemVisualNovelOption.AddActions(builder, ActionsOffset);
			ITalkItemVisualNovelOption.AddCaptionParams(builder, CaptionParamsOffset);
			ITalkItemVisualNovelOption.AddWaitTime(builder, WaitTime);
			ITalkItemVisualNovelOption.AddTidTalk(builder, TidTalkOffset);
			ITalkItemVisualNovelOption.AddTextId(builder, TextId);
			ITalkItemVisualNovelOption.AddWhoId(builder, WhoId);
			ITalkItemVisualNovelOption.AddName(builder, NameOffset);
			ITalkItemVisualNovelOption.AddPlotLineKey(builder, PlotLineKeyOffset);
			ITalkItemVisualNovelOption.AddPlotLineId(builder, PlotLineId);
			ITalkItemVisualNovelOption.AddId(builder, Id);
			ITalkItemVisualNovelOption.AddDisplayItemConfigType(builder, DisplayItemConfig_type);
			ITalkItemVisualNovelOption.AddCgConfigType(builder, CgConfig_type);
			ITalkItemVisualNovelOption.AddVisualNovelBackgroundConfigType(builder, VisualNovelBackgroundConfig_type);
			ITalkItemVisualNovelOption.AddOptionInteractionType(builder, OptionInteractionType);
			ITalkItemVisualNovelOption.AddPlayVoice(builder, PlayVoice);
			ITalkItemVisualNovelOption.AddBackgroundConfigType(builder, BackgroundConfig_type);
			ITalkItemVisualNovelOption.AddTalkEndAkEventType(builder, TalkEndAkEvent_type);
			ITalkItemVisualNovelOption.AddTalkAkEventType(builder, TalkAkEvent_type);
			ITalkItemVisualNovelOption.Add_EditFlag(builder, _editFlag);
			ITalkItemVisualNovelOption.Add_Folded(builder, _folded);
			ITalkItemVisualNovelOption.AddType(builder, Type);
			return ITalkItemVisualNovelOption.EndITalkItemVisualNovelOption(builder);
		}

		// Token: 0x06035526 RID: 218406 RVA: 0x00740AAC File Offset: 0x0073ECAC
		public static void StartITalkItemVisualNovelOption(FlatBufferBuilder builder)
		{
			builder.StartTable(49);
		}

		// Token: 0x06035527 RID: 218407 RVA: 0x00740AB6 File Offset: 0x0073ECB6
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035528 RID: 218408 RVA: 0x00740AC1 File Offset: 0x0073ECC1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06035529 RID: 218409 RVA: 0x00740ACC File Offset: 0x0073ECCC
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x0603552A RID: 218410 RVA: 0x00740AD7 File Offset: 0x0073ECD7
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x0603552B RID: 218411 RVA: 0x00740AE7 File Offset: 0x0073ECE7
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x0603552C RID: 218412 RVA: 0x00740AF7 File Offset: 0x0073ECF7
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x0603552D RID: 218413 RVA: 0x00740B02 File Offset: 0x0073ED02
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x0603552E RID: 218414 RVA: 0x00740B0D File Offset: 0x0073ED0D
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x0603552F RID: 218415 RVA: 0x00740B18 File Offset: 0x0073ED18
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x06035530 RID: 218416 RVA: 0x00740B23 File Offset: 0x0073ED23
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x06035531 RID: 218417 RVA: 0x00740B34 File Offset: 0x0073ED34
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x06035532 RID: 218418 RVA: 0x00740B48 File Offset: 0x0073ED48
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x06035533 RID: 218419 RVA: 0x00740B59 File Offset: 0x0073ED59
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x06035534 RID: 218420 RVA: 0x00740B6C File Offset: 0x0073ED6C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035535 RID: 218421 RVA: 0x00740BAC File Offset: 0x0073EDAC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035536 RID: 218422 RVA: 0x00740BC6 File Offset: 0x0073EDC6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035537 RID: 218423 RVA: 0x00740BE4 File Offset: 0x0073EDE4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035538 RID: 218424 RVA: 0x00740BFD File Offset: 0x0073EDFD
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035539 RID: 218425 RVA: 0x00740C08 File Offset: 0x0073EE08
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x0603553A RID: 218426 RVA: 0x00740C1C File Offset: 0x0073EE1C
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603553B RID: 218427 RVA: 0x00740C5C File Offset: 0x0073EE5C
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603553C RID: 218428 RVA: 0x00740C76 File Offset: 0x0073EE76
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603553D RID: 218429 RVA: 0x00740C94 File Offset: 0x0073EE94
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603553E RID: 218430 RVA: 0x00740CAD File Offset: 0x0073EEAD
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603553F RID: 218431 RVA: 0x00740CB8 File Offset: 0x0073EEB8
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x06035540 RID: 218432 RVA: 0x00740CC9 File Offset: 0x0073EEC9
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x06035541 RID: 218433 RVA: 0x00740CDA File Offset: 0x0073EEDA
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x06035542 RID: 218434 RVA: 0x00740CEB File Offset: 0x0073EEEB
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x06035543 RID: 218435 RVA: 0x00740CFC File Offset: 0x0073EEFC
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035544 RID: 218436 RVA: 0x00740D3C File Offset: 0x0073EF3C
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035545 RID: 218437 RVA: 0x00740D56 File Offset: 0x0073EF56
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035546 RID: 218438 RVA: 0x00740D74 File Offset: 0x0073EF74
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035547 RID: 218439 RVA: 0x00740D8D File Offset: 0x0073EF8D
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035548 RID: 218440 RVA: 0x00740D98 File Offset: 0x0073EF98
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x06035549 RID: 218441 RVA: 0x00740DAC File Offset: 0x0073EFAC
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603554A RID: 218442 RVA: 0x00740DEC File Offset: 0x0073EFEC
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603554B RID: 218443 RVA: 0x00740E06 File Offset: 0x0073F006
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603554C RID: 218444 RVA: 0x00740E24 File Offset: 0x0073F024
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603554D RID: 218445 RVA: 0x00740E3D File Offset: 0x0073F03D
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603554E RID: 218446 RVA: 0x00740E48 File Offset: 0x0073F048
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x0603554F RID: 218447 RVA: 0x00740E5C File Offset: 0x0073F05C
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035550 RID: 218448 RVA: 0x00740E9C File Offset: 0x0073F09C
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035551 RID: 218449 RVA: 0x00740EB6 File Offset: 0x0073F0B6
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035552 RID: 218450 RVA: 0x00740ED4 File Offset: 0x0073F0D4
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035553 RID: 218451 RVA: 0x00740EED File Offset: 0x0073F0ED
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035554 RID: 218452 RVA: 0x00740EF8 File Offset: 0x0073F0F8
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x06035555 RID: 218453 RVA: 0x00740F0C File Offset: 0x0073F10C
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035556 RID: 218454 RVA: 0x00740F4C File Offset: 0x0073F14C
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035557 RID: 218455 RVA: 0x00740F66 File Offset: 0x0073F166
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035558 RID: 218456 RVA: 0x00740F84 File Offset: 0x0073F184
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035559 RID: 218457 RVA: 0x00740F9D File Offset: 0x0073F19D
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603555A RID: 218458 RVA: 0x00740FA8 File Offset: 0x0073F1A8
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x0603555B RID: 218459 RVA: 0x00740FBC File Offset: 0x0073F1BC
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603555C RID: 218460 RVA: 0x00740FFC File Offset: 0x0073F1FC
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603555D RID: 218461 RVA: 0x00741016 File Offset: 0x0073F216
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603555E RID: 218462 RVA: 0x00741034 File Offset: 0x0073F234
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603555F RID: 218463 RVA: 0x0074104D File Offset: 0x0073F24D
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035560 RID: 218464 RVA: 0x00741058 File Offset: 0x0073F258
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x06035561 RID: 218465 RVA: 0x00741064 File Offset: 0x0073F264
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x06035562 RID: 218466 RVA: 0x00741070 File Offset: 0x0073F270
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x06035563 RID: 218467 RVA: 0x0074107C File Offset: 0x0073F27C
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x06035564 RID: 218468 RVA: 0x00741088 File Offset: 0x0073F288
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x06035565 RID: 218469 RVA: 0x00741099 File Offset: 0x0073F299
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x06035566 RID: 218470 RVA: 0x007410A5 File Offset: 0x0073F2A5
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x06035567 RID: 218471 RVA: 0x007410B1 File Offset: 0x0073F2B1
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x06035568 RID: 218472 RVA: 0x007410BD File Offset: 0x0073F2BD
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x06035569 RID: 218473 RVA: 0x007410CE File Offset: 0x0073F2CE
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x0603556A RID: 218474 RVA: 0x007410DF File Offset: 0x0073F2DF
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x0603556B RID: 218475 RVA: 0x007410F0 File Offset: 0x0073F2F0
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603556C RID: 218476 RVA: 0x00741130 File Offset: 0x0073F330
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603556D RID: 218477 RVA: 0x0074114A File Offset: 0x0073F34A
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603556E RID: 218478 RVA: 0x00741168 File Offset: 0x0073F368
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603556F RID: 218479 RVA: 0x00741181 File Offset: 0x0073F381
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035570 RID: 218480 RVA: 0x0074118C File Offset: 0x0073F38C
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x06035571 RID: 218481 RVA: 0x007411A0 File Offset: 0x0073F3A0
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035572 RID: 218482 RVA: 0x007411E0 File Offset: 0x0073F3E0
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035573 RID: 218483 RVA: 0x007411FA File Offset: 0x0073F3FA
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035574 RID: 218484 RVA: 0x00741218 File Offset: 0x0073F418
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035575 RID: 218485 RVA: 0x00741231 File Offset: 0x0073F431
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035576 RID: 218486 RVA: 0x0074123C File Offset: 0x0073F43C
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x06035577 RID: 218487 RVA: 0x00741250 File Offset: 0x0073F450
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035578 RID: 218488 RVA: 0x00741287 File Offset: 0x0073F487
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06035579 RID: 218489 RVA: 0x007412A1 File Offset: 0x0073F4A1
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x0603557A RID: 218490 RVA: 0x007412BF File Offset: 0x0073F4BF
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603557B RID: 218491 RVA: 0x007412D8 File Offset: 0x0073F4D8
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603557C RID: 218492 RVA: 0x007412E3 File Offset: 0x0073F4E3
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x0603557D RID: 218493 RVA: 0x007412F4 File Offset: 0x0073F4F4
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603557E RID: 218494 RVA: 0x0074132B File Offset: 0x0073F52B
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603557F RID: 218495 RVA: 0x00741345 File Offset: 0x0073F545
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035580 RID: 218496 RVA: 0x00741363 File Offset: 0x0073F563
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035581 RID: 218497 RVA: 0x0074137C File Offset: 0x0073F57C
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035582 RID: 218498 RVA: 0x00741387 File Offset: 0x0073F587
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x06035583 RID: 218499 RVA: 0x00741398 File Offset: 0x0073F598
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035584 RID: 218500 RVA: 0x007413D8 File Offset: 0x0073F5D8
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035585 RID: 218501 RVA: 0x007413F2 File Offset: 0x0073F5F2
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035586 RID: 218502 RVA: 0x00741410 File Offset: 0x0073F610
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035587 RID: 218503 RVA: 0x00741429 File Offset: 0x0073F629
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035588 RID: 218504 RVA: 0x00741434 File Offset: 0x0073F634
		public static void AddOptionInteractionType(FlatBufferBuilder builder, EVisualNovelOptionInteractionType optionInteractionType)
		{
			builder.AddByte(37, (byte)optionInteractionType, 0);
		}

		// Token: 0x06035589 RID: 218505 RVA: 0x00741440 File Offset: 0x0073F640
		public static void AddOptionGroup(FlatBufferBuilder builder, Offset<IVisualNovelOptionGroupSolarSchoolExam> optionGroupOffset)
		{
			builder.AddOffset(38, optionGroupOffset.Value, 0);
		}

		// Token: 0x0603558A RID: 218506 RVA: 0x00741451 File Offset: 0x0073F651
		public static void AddCustomDescTextId(FlatBufferBuilder builder, int customDescTextId)
		{
			builder.AddInt(39, customDescTextId, 0);
		}

		// Token: 0x0603558B RID: 218507 RVA: 0x0074145D File Offset: 0x0073F65D
		public static void AddTidCustomDescText(FlatBufferBuilder builder, StringOffset tidCustomDescTextOffset)
		{
			builder.AddOffset(40, tidCustomDescTextOffset.Value, 0);
		}

		// Token: 0x0603558C RID: 218508 RVA: 0x0074146E File Offset: 0x0073F66E
		public static void AddVisualNovelBackgroundConfigType(FlatBufferBuilder builder, TVisualNovelBackground visualNovelBackgroundConfigType)
		{
			builder.AddByte(41, (byte)visualNovelBackgroundConfigType, 0);
		}

		// Token: 0x0603558D RID: 218509 RVA: 0x0074147A File Offset: 0x0073F67A
		public static void AddVisualNovelBackgroundConfig(FlatBufferBuilder builder, int visualNovelBackgroundConfigOffset)
		{
			builder.AddOffset(42, visualNovelBackgroundConfigOffset, 0);
		}

		// Token: 0x0603558E RID: 218510 RVA: 0x00741486 File Offset: 0x0073F686
		public static void AddCgConfigType(FlatBufferBuilder builder, TVisualNovelCg cgConfigType)
		{
			builder.AddByte(43, (byte)cgConfigType, 0);
		}

		// Token: 0x0603558F RID: 218511 RVA: 0x00741492 File Offset: 0x0073F692
		public static void AddCgConfig(FlatBufferBuilder builder, int cgConfigOffset)
		{
			builder.AddOffset(44, cgConfigOffset, 0);
		}

		// Token: 0x06035590 RID: 218512 RVA: 0x0074149E File Offset: 0x0073F69E
		public static void AddDisplayItemConfigType(FlatBufferBuilder builder, TVisualNovelDisplayItem displayItemConfigType)
		{
			builder.AddByte(45, (byte)displayItemConfigType, 0);
		}

		// Token: 0x06035591 RID: 218513 RVA: 0x007414AA File Offset: 0x0073F6AA
		public static void AddDisplayItemConfig(FlatBufferBuilder builder, int displayItemConfigOffset)
		{
			builder.AddOffset(46, displayItemConfigOffset, 0);
		}

		// Token: 0x06035592 RID: 218514 RVA: 0x007414B6 File Offset: 0x0073F6B6
		public static void AddPlotKeyId(FlatBufferBuilder builder, int plotKeyId)
		{
			builder.AddInt(47, plotKeyId, 0);
		}

		// Token: 0x06035593 RID: 218515 RVA: 0x007414C2 File Offset: 0x0073F6C2
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(48, nullMask, 0U);
		}

		// Token: 0x06035594 RID: 218516 RVA: 0x007414CE File Offset: 0x0073F6CE
		public static Offset<ITalkItemVisualNovelOption> EndITalkItemVisualNovelOption(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemVisualNovelOption>(builder.EndTable());
		}

		// Token: 0x06035595 RID: 218517 RVA: 0x007414DC File Offset: 0x0073F6DC
		public ITalkItemVisualNovelOptionT UnPack()
		{
			ITalkItemVisualNovelOptionT talkItemVisualNovelOptionT = new ITalkItemVisualNovelOptionT();
			this.UnPackTo(talkItemVisualNovelOptionT);
			return talkItemVisualNovelOptionT;
		}

		// Token: 0x06035596 RID: 218518 RVA: 0x007414F8 File Offset: 0x0073F6F8
		public void UnPackTo(ITalkItemVisualNovelOptionT _o)
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
			_o.OptionInteractionType = this.OptionInteractionType;
			_o.OptionGroup = ((this.OptionGroup != null) ? this.OptionGroup.Value.UnPack() : null);
			_o.CustomDescTextId = this.CustomDescTextId;
			_o.TidCustomDescText = this.TidCustomDescText;
			_o.VisualNovelBackgroundConfig = new TVisualNovelBackgroundUnion();
			_o.VisualNovelBackgroundConfig.Type = this.VisualNovelBackgroundConfigType;
			TVisualNovelBackground visualNovelBackgroundConfigType = this.VisualNovelBackgroundConfigType;
			if (visualNovelBackgroundConfigType != TVisualNovelBackground.IVisualNovelBackgroundClean)
			{
				if (visualNovelBackgroundConfigType == TVisualNovelBackground.IVisualNovelBackgroundLoad)
				{
					_o.VisualNovelBackgroundConfig.Value = ((this.VisualNovelBackgroundConfig<IVisualNovelBackgroundLoad>() != null) ? this.VisualNovelBackgroundConfig<IVisualNovelBackgroundLoad>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.VisualNovelBackgroundConfig.Value = ((this.VisualNovelBackgroundConfig<IVisualNovelBackgroundClean>() != null) ? this.VisualNovelBackgroundConfig<IVisualNovelBackgroundClean>().Value.UnPack() : null);
			}
			_o.CgConfig = new TVisualNovelCgUnion();
			_o.CgConfig.Type = this.CgConfigType;
			switch (this.CgConfigType)
			{
			case TVisualNovelCg.IVisualNovelCgClean:
				_o.CgConfig.Value = ((this.CgConfig<IVisualNovelCgClean>() != null) ? this.CgConfig<IVisualNovelCgClean>().Value.UnPack() : null);
				break;
			case TVisualNovelCg.IVisualNovelCgLoadImage:
				_o.CgConfig.Value = ((this.CgConfig<IVisualNovelCgLoadImage>() != null) ? this.CgConfig<IVisualNovelCgLoadImage>().Value.UnPack() : null);
				break;
			case TVisualNovelCg.IVisualNovelCgLoadSpine:
				_o.CgConfig.Value = ((this.CgConfig<IVisualNovelCgLoadSpine>() != null) ? this.CgConfig<IVisualNovelCgLoadSpine>().Value.UnPack() : null);
				break;
			}
			_o.DisplayItemConfig = new TVisualNovelDisplayItemUnion();
			_o.DisplayItemConfig.Type = this.DisplayItemConfigType;
			switch (this.DisplayItemConfigType)
			{
			case TVisualNovelDisplayItem.IVisualNovelDisplayItemClose:
				_o.DisplayItemConfig.Value = ((this.DisplayItemConfig<IVisualNovelDisplayItemClose>() != null) ? this.DisplayItemConfig<IVisualNovelDisplayItemClose>().Value.UnPack() : null);
				break;
			case TVisualNovelDisplayItem.IVisualNovelDisplayItemImage:
				_o.DisplayItemConfig.Value = ((this.DisplayItemConfig<IVisualNovelDisplayItemImage>() != null) ? this.DisplayItemConfig<IVisualNovelDisplayItemImage>().Value.UnPack() : null);
				break;
			case TVisualNovelDisplayItem.IVisualNovelDisplayItemPrefab:
				_o.DisplayItemConfig.Value = ((this.DisplayItemConfig<IVisualNovelDisplayItemPrefab>() != null) ? this.DisplayItemConfig<IVisualNovelDisplayItemPrefab>().Value.UnPack() : null);
				break;
			}
			_o.PlotKeyId = this.PlotKeyId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035597 RID: 218519 RVA: 0x007421D4 File Offset: 0x007403D4
		public static Offset<ITalkItemVisualNovelOption> Pack(FlatBufferBuilder builder, ITalkItemVisualNovelOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemVisualNovelOption>);
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
				actionsOffset = ITalkItemVisualNovelOption.CreateActionsVector(builder, array);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<ITalkOption>[] array2 = new Offset<ITalkOption>[_o.Options.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ITalkOption.Pack(builder, _o.Options[j]);
				}
				optionsOffset = ITalkItemVisualNovelOption.CreateOptionsVector(builder, array2);
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
				flowTemplateListOffset = ITalkItemVisualNovelOption.CreateFlowTemplateListVector(builder, array3);
			}
			VectorOffset actorMontageArrayOffset = default(VectorOffset);
			if (_o.ActorMontageArray != null)
			{
				Offset<IMontageData>[] array4 = new Offset<IMontageData>[_o.ActorMontageArray.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IMontageData.Pack(builder, _o.ActorMontageArray[l]);
				}
				actorMontageArrayOffset = ITalkItemVisualNovelOption.CreateActorMontageArrayVector(builder, array4);
			}
			VectorOffset actorFaceExpressionArrayOffset = default(VectorOffset);
			if (_o.ActorFaceExpressionArray != null)
			{
				Offset<IActorFaceExpression>[] array5 = new Offset<IActorFaceExpression>[_o.ActorFaceExpressionArray.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActorFaceExpression.Pack(builder, _o.ActorFaceExpressionArray[m]);
				}
				actorFaceExpressionArrayOffset = ITalkItemVisualNovelOption.CreateActorFaceExpressionArrayVector(builder, array5);
			}
			VectorOffset actorLookAtArrayOffset = default(VectorOffset);
			if (_o.ActorLookAtArray != null)
			{
				Offset<IActorLookAt>[] array6 = new Offset<IActorLookAt>[_o.ActorLookAtArray.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = IActorLookAt.Pack(builder, _o.ActorLookAtArray[n]);
				}
				actorLookAtArrayOffset = ITalkItemVisualNovelOption.CreateActorLookAtArrayVector(builder, array6);
			}
			VectorOffset actorTurnToArrayOffset = default(VectorOffset);
			if (_o.ActorTurnToArray != null)
			{
				Offset<IActorTurnTo>[] array7 = new Offset<IActorTurnTo>[_o.ActorTurnToArray.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = IActorTurnTo.Pack(builder, _o.ActorTurnToArray[num]);
				}
				actorTurnToArrayOffset = ITalkItemVisualNovelOption.CreateActorTurnToArrayVector(builder, array7);
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
				introActionsOffset = ITalkItemVisualNovelOption.CreateIntroActionsVector(builder, array8);
			}
			VectorOffset actorFxEmoteArrayOffset = default(VectorOffset);
			if (_o.ActorFxEmoteArray != null)
			{
				Offset<IActorFxEmote>[] array9 = new Offset<IActorFxEmote>[_o.ActorFxEmoteArray.Count];
				for (int num3 = 0; num3 < array9.Length; num3++)
				{
					array9[num3] = IActorFxEmote.Pack(builder, _o.ActorFxEmoteArray[num3]);
				}
				actorFxEmoteArrayOffset = ITalkItemVisualNovelOption.CreateActorFxEmoteArrayVector(builder, array9);
			}
			VectorOffset talkEffectArray_typeOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				TTalkEffectAction[] array10 = new TTalkEffectAction[_o.TalkEffectArray.Count];
				for (int num4 = 0; num4 < array10.Length; num4++)
				{
					array10[num4] = _o.TalkEffectArray[num4].Type;
				}
				talkEffectArray_typeOffset = ITalkItemVisualNovelOption.CreateTalkEffectArrayTypeVector(builder, array10);
			}
			VectorOffset talkEffectArrayOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				int[] array11 = new int[_o.TalkEffectArray.Count];
				for (int num5 = 0; num5 < array11.Length; num5++)
				{
					array11[num5] = TTalkEffectActionUnion.Pack(builder, _o.TalkEffectArray[num5]);
				}
				talkEffectArrayOffset = ITalkItemVisualNovelOption.CreateTalkEffectArrayVector(builder, array11);
			}
			VectorOffset actorVisibilityArrayOffset = default(VectorOffset);
			if (_o.ActorVisibilityArray != null)
			{
				Offset<IActorVisibility>[] array12 = new Offset<IActorVisibility>[_o.ActorVisibilityArray.Count];
				for (int num6 = 0; num6 < array12.Length; num6++)
				{
					array12[num6] = IActorVisibility.Pack(builder, _o.ActorVisibilityArray[num6]);
				}
				actorVisibilityArrayOffset = ITalkItemVisualNovelOption.CreateActorVisibilityArrayVector(builder, array12);
			}
			Offset<IVisualNovelOptionGroupSolarSchoolExam> optionGroupOffset = (_o.OptionGroup == null) ? default(Offset<IVisualNovelOptionGroupSolarSchoolExam>) : IVisualNovelOptionGroupSolarSchoolExam.Pack(builder, _o.OptionGroup);
			StringOffset tidCustomDescTextOffset = (_o.TidCustomDescText == null) ? default(StringOffset) : builder.CreateString(_o.TidCustomDescText);
			TVisualNovelBackground visualNovelBackgroundConfig_type = (_o.VisualNovelBackgroundConfig == null) ? TVisualNovelBackground.NONE : _o.VisualNovelBackgroundConfig.Type;
			int visualNovelBackgroundConfigOffset = (_o.VisualNovelBackgroundConfig == null) ? 0 : TVisualNovelBackgroundUnion.Pack(builder, _o.VisualNovelBackgroundConfig);
			TVisualNovelCg cgConfig_type = (_o.CgConfig == null) ? TVisualNovelCg.NONE : _o.CgConfig.Type;
			int cgConfigOffset = (_o.CgConfig == null) ? 0 : TVisualNovelCgUnion.Pack(builder, _o.CgConfig);
			TVisualNovelDisplayItem displayItemConfig_type = (_o.DisplayItemConfig == null) ? TVisualNovelDisplayItem.NONE : _o.DisplayItemConfig.Type;
			int displayItemConfigOffset = (_o.DisplayItemConfig == null) ? 0 : TVisualNovelDisplayItemUnion.Pack(builder, _o.DisplayItemConfig);
			return ITalkItemVisualNovelOption.CreateITalkItemVisualNovelOption(builder, _o.Type, _o.Id, _o.PlotLineId, plotLineKeyOffset, nameOffset, _o._Folded, _o._EditFlag, _o.WhoId, _o.TextId, tidTalkOffset, _o.WaitTime, captionParamsOffset, actionsOffset, optionsOffset, montageOffset, cameraDataOffset, flowTemplateOffset, flowTemplateListOffset, actorMontageArrayOffset, actorFaceExpressionArrayOffset, actorLookAtArrayOffset, actorTurnToArrayOffset, talkAkEvent_type, talkAkEventOffset, talkEndAkEvent_type, talkEndAkEventOffset, universalToneOffset, backgroundConfig_type, backgroundConfigOffset, _o.PlayVoice, timeLimitOptionGroupOffset, gamepadShakeOffset, introActionsOffset, actorFxEmoteArrayOffset, talkEffectArray_typeOffset, talkEffectArrayOffset, actorVisibilityArrayOffset, _o.OptionInteractionType, optionGroupOffset, _o.CustomDescTextId, tidCustomDescTextOffset, visualNovelBackgroundConfig_type, visualNovelBackgroundConfigOffset, cgConfig_type, cgConfigOffset, displayItemConfig_type, displayItemConfigOffset, _o.PlotKeyId, _o.NullMask);
		}

		// Token: 0x0401208B RID: 73867
		private Table __p;
	}
}
