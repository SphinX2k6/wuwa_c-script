using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007313 RID: 29459
	public struct ITalkItemVisualNovelNoTextItem : IFlatbufferObject
	{
		// Token: 0x1700DEB9 RID: 57017
		// (get) Token: 0x0603537A RID: 217978 RVA: 0x0073A6EA File Offset: 0x007388EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603537B RID: 217979 RVA: 0x0073A6F7 File Offset: 0x007388F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603537C RID: 217980 RVA: 0x0073A700 File Offset: 0x00738900
		public static ITalkItemVisualNovelNoTextItem GetRootAsITalkItemVisualNovelNoTextItem(ByteBuffer _bb)
		{
			return ITalkItemVisualNovelNoTextItem.GetRootAsITalkItemVisualNovelNoTextItem(_bb, default(ITalkItemVisualNovelNoTextItem));
		}

		// Token: 0x0603537D RID: 217981 RVA: 0x0073A71C File Offset: 0x0073891C
		public static ITalkItemVisualNovelNoTextItem GetRootAsITalkItemVisualNovelNoTextItem(ByteBuffer _bb, ITalkItemVisualNovelNoTextItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603537E RID: 217982 RVA: 0x0073A739 File Offset: 0x00738939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603537F RID: 217983 RVA: 0x0073A748 File Offset: 0x00738948
		public ITalkItemVisualNovelNoTextItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEBA RID: 57018
		// (get) Token: 0x06035380 RID: 217984 RVA: 0x0073A758 File Offset: 0x00738958
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

		// Token: 0x1700DEBB RID: 57019
		// (get) Token: 0x06035381 RID: 217985 RVA: 0x0073A794 File Offset: 0x00738994
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

		// Token: 0x1700DEBC RID: 57020
		// (get) Token: 0x06035382 RID: 217986 RVA: 0x0073A7D0 File Offset: 0x007389D0
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

		// Token: 0x1700DEBD RID: 57021
		// (get) Token: 0x06035383 RID: 217987 RVA: 0x0073A80C File Offset: 0x00738A0C
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

		// Token: 0x06035384 RID: 217988 RVA: 0x0073A844 File Offset: 0x00738A44
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06035385 RID: 217989 RVA: 0x0073A854 File Offset: 0x00738A54
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DEBE RID: 57022
		// (get) Token: 0x06035386 RID: 217990 RVA: 0x0073A864 File Offset: 0x00738A64
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

		// Token: 0x06035387 RID: 217991 RVA: 0x0073A89C File Offset: 0x00738A9C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06035388 RID: 217992 RVA: 0x0073A8AC File Offset: 0x00738AAC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700DEBF RID: 57023
		// (get) Token: 0x06035389 RID: 217993 RVA: 0x0073A8BC File Offset: 0x00738ABC
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DEC0 RID: 57024
		// (get) Token: 0x0603538A RID: 217994 RVA: 0x0073A8FC File Offset: 0x00738AFC
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

		// Token: 0x1700DEC1 RID: 57025
		// (get) Token: 0x0603538B RID: 217995 RVA: 0x0073A93C File Offset: 0x00738B3C
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

		// Token: 0x1700DEC2 RID: 57026
		// (get) Token: 0x0603538C RID: 217996 RVA: 0x0073A97C File Offset: 0x00738B7C
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

		// Token: 0x1700DEC3 RID: 57027
		// (get) Token: 0x0603538D RID: 217997 RVA: 0x0073A9BC File Offset: 0x00738BBC
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

		// Token: 0x0603538E RID: 217998 RVA: 0x0073A9F4 File Offset: 0x00738BF4
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0603538F RID: 217999 RVA: 0x0073AA04 File Offset: 0x00738C04
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700DEC4 RID: 57028
		// (get) Token: 0x06035390 RID: 218000 RVA: 0x0073AA14 File Offset: 0x00738C14
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

		// Token: 0x1700DEC5 RID: 57029
		// (get) Token: 0x06035391 RID: 218001 RVA: 0x0073AA58 File Offset: 0x00738C58
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

		// Token: 0x06035392 RID: 218002 RVA: 0x0073AAB8 File Offset: 0x00738CB8
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DEC6 RID: 57030
		// (get) Token: 0x06035393 RID: 218003 RVA: 0x0073AB1C File Offset: 0x00738D1C
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

		// Token: 0x06035394 RID: 218004 RVA: 0x0073AB48 File Offset: 0x00738D48
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DEC7 RID: 57031
		// (get) Token: 0x06035395 RID: 218005 RVA: 0x0073ABAC File Offset: 0x00738DAC
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

		// Token: 0x1700DEC8 RID: 57032
		// (get) Token: 0x06035396 RID: 218006 RVA: 0x0073ABD8 File Offset: 0x00738DD8
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

		// Token: 0x1700DEC9 RID: 57033
		// (get) Token: 0x06035397 RID: 218007 RVA: 0x0073AC38 File Offset: 0x00738E38
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

		// Token: 0x1700DECA RID: 57034
		// (get) Token: 0x06035398 RID: 218008 RVA: 0x0073AC98 File Offset: 0x00738E98
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

		// Token: 0x06035399 RID: 218009 RVA: 0x0073ACF8 File Offset: 0x00738EF8
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DECB RID: 57035
		// (get) Token: 0x0603539A RID: 218010 RVA: 0x0073AD5C File Offset: 0x00738F5C
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

		// Token: 0x0603539B RID: 218011 RVA: 0x0073AD88 File Offset: 0x00738F88
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DECC RID: 57036
		// (get) Token: 0x0603539C RID: 218012 RVA: 0x0073ADEC File Offset: 0x00738FEC
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

		// Token: 0x0603539D RID: 218013 RVA: 0x0073AE18 File Offset: 0x00739018
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DECD RID: 57037
		// (get) Token: 0x0603539E RID: 218014 RVA: 0x0073AE7C File Offset: 0x0073907C
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

		// Token: 0x0603539F RID: 218015 RVA: 0x0073AEA8 File Offset: 0x007390A8
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DECE RID: 57038
		// (get) Token: 0x060353A0 RID: 218016 RVA: 0x0073AF0C File Offset: 0x0073910C
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

		// Token: 0x060353A1 RID: 218017 RVA: 0x0073AF38 File Offset: 0x00739138
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DECF RID: 57039
		// (get) Token: 0x060353A2 RID: 218018 RVA: 0x0073AF9C File Offset: 0x0073919C
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

		// Token: 0x1700DED0 RID: 57040
		// (get) Token: 0x060353A3 RID: 218019 RVA: 0x0073AFC8 File Offset: 0x007391C8
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

		// Token: 0x060353A4 RID: 218020 RVA: 0x0073B008 File Offset: 0x00739208
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060353A5 RID: 218021 RVA: 0x0073B050 File Offset: 0x00739250
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x060353A6 RID: 218022 RVA: 0x0073B06C File Offset: 0x0073926C
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x060353A7 RID: 218023 RVA: 0x0073B088 File Offset: 0x00739288
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x060353A8 RID: 218024 RVA: 0x0073B0A4 File Offset: 0x007392A4
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DED1 RID: 57041
		// (get) Token: 0x060353A9 RID: 218025 RVA: 0x0073B0C0 File Offset: 0x007392C0
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

		// Token: 0x060353AA RID: 218026 RVA: 0x0073B100 File Offset: 0x00739300
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060353AB RID: 218027 RVA: 0x0073B148 File Offset: 0x00739348
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x060353AC RID: 218028 RVA: 0x0073B164 File Offset: 0x00739364
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x060353AD RID: 218029 RVA: 0x0073B180 File Offset: 0x00739380
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x060353AE RID: 218030 RVA: 0x0073B19C File Offset: 0x0073939C
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DED2 RID: 57042
		// (get) Token: 0x060353AF RID: 218031 RVA: 0x0073B1B8 File Offset: 0x007393B8
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

		// Token: 0x1700DED3 RID: 57043
		// (get) Token: 0x060353B0 RID: 218032 RVA: 0x0073B218 File Offset: 0x00739418
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

		// Token: 0x060353B1 RID: 218033 RVA: 0x0073B258 File Offset: 0x00739458
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060353B2 RID: 218034 RVA: 0x0073B2A0 File Offset: 0x007394A0
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x060353B3 RID: 218035 RVA: 0x0073B2BC File Offset: 0x007394BC
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x060353B4 RID: 218036 RVA: 0x0073B2D8 File Offset: 0x007394D8
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x060353B5 RID: 218037 RVA: 0x0073B2F4 File Offset: 0x007394F4
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x060353B6 RID: 218038 RVA: 0x0073B310 File Offset: 0x00739510
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700DED4 RID: 57044
		// (get) Token: 0x060353B7 RID: 218039 RVA: 0x0073B32C File Offset: 0x0073952C
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DED5 RID: 57045
		// (get) Token: 0x060353B8 RID: 218040 RVA: 0x0073B36C File Offset: 0x0073956C
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

		// Token: 0x1700DED6 RID: 57046
		// (get) Token: 0x060353B9 RID: 218041 RVA: 0x0073B3CC File Offset: 0x007395CC
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

		// Token: 0x060353BA RID: 218042 RVA: 0x0073B42C File Offset: 0x0073962C
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DED7 RID: 57047
		// (get) Token: 0x060353BB RID: 218043 RVA: 0x0073B490 File Offset: 0x00739690
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

		// Token: 0x060353BC RID: 218044 RVA: 0x0073B4BC File Offset: 0x007396BC
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DED8 RID: 57048
		// (get) Token: 0x060353BD RID: 218045 RVA: 0x0073B520 File Offset: 0x00739720
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

		// Token: 0x060353BE RID: 218046 RVA: 0x0073B54C File Offset: 0x0073974C
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DED9 RID: 57049
		// (get) Token: 0x060353BF RID: 218047 RVA: 0x0073B58C File Offset: 0x0073978C
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

		// Token: 0x060353C0 RID: 218048 RVA: 0x0073B5B8 File Offset: 0x007397B8
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x060353C1 RID: 218049 RVA: 0x0073B5C8 File Offset: 0x007397C8
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

		// Token: 0x060353C2 RID: 218050 RVA: 0x0073B634 File Offset: 0x00739834
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DEDA RID: 57050
		// (get) Token: 0x060353C3 RID: 218051 RVA: 0x0073B67C File Offset: 0x0073987C
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

		// Token: 0x060353C4 RID: 218052 RVA: 0x0073B6A8 File Offset: 0x007398A8
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DEDB RID: 57051
		// (get) Token: 0x060353C5 RID: 218053 RVA: 0x0073B70C File Offset: 0x0073990C
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

		// Token: 0x1700DEDC RID: 57052
		// (get) Token: 0x060353C6 RID: 218054 RVA: 0x0073B738 File Offset: 0x00739938
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

		// Token: 0x1700DEDD RID: 57053
		// (get) Token: 0x060353C7 RID: 218055 RVA: 0x0073B778 File Offset: 0x00739978
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

		// Token: 0x1700DEDE RID: 57054
		// (get) Token: 0x060353C8 RID: 218056 RVA: 0x0073B7D8 File Offset: 0x007399D8
		public TVisualNovelBackground VisualNovelBackgroundConfigType
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return TVisualNovelBackground.NONE;
				}
				return (TVisualNovelBackground)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060353C9 RID: 218057 RVA: 0x0073B818 File Offset: 0x00739A18
		public TTable? VisualNovelBackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(84);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060353CA RID: 218058 RVA: 0x0073B860 File Offset: 0x00739A60
		public IVisualNovelBackgroundClean VisualNovelBackgroundConfigAsIVisualNovelBackgroundClean()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundClean>().Value;
		}

		// Token: 0x060353CB RID: 218059 RVA: 0x0073B87C File Offset: 0x00739A7C
		public IVisualNovelBackgroundLoad VisualNovelBackgroundConfigAsIVisualNovelBackgroundLoad()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundLoad>().Value;
		}

		// Token: 0x1700DEDF RID: 57055
		// (get) Token: 0x060353CC RID: 218060 RVA: 0x0073B898 File Offset: 0x00739A98
		public TVisualNovelCg CgConfigType
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return TVisualNovelCg.NONE;
				}
				return (TVisualNovelCg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060353CD RID: 218061 RVA: 0x0073B8D8 File Offset: 0x00739AD8
		public TTable? CgConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(88);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060353CE RID: 218062 RVA: 0x0073B920 File Offset: 0x00739B20
		public IVisualNovelCgClean CgConfigAsIVisualNovelCgClean()
		{
			return this.CgConfig<IVisualNovelCgClean>().Value;
		}

		// Token: 0x060353CF RID: 218063 RVA: 0x0073B93C File Offset: 0x00739B3C
		public IVisualNovelCgLoadImage CgConfigAsIVisualNovelCgLoadImage()
		{
			return this.CgConfig<IVisualNovelCgLoadImage>().Value;
		}

		// Token: 0x060353D0 RID: 218064 RVA: 0x0073B958 File Offset: 0x00739B58
		public IVisualNovelCgLoadSpine CgConfigAsIVisualNovelCgLoadSpine()
		{
			return this.CgConfig<IVisualNovelCgLoadSpine>().Value;
		}

		// Token: 0x1700DEE0 RID: 57056
		// (get) Token: 0x060353D1 RID: 218065 RVA: 0x0073B974 File Offset: 0x00739B74
		public TVisualNovelDisplayItem DisplayItemConfigType
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return TVisualNovelDisplayItem.NONE;
				}
				return (TVisualNovelDisplayItem)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060353D2 RID: 218066 RVA: 0x0073B9B4 File Offset: 0x00739BB4
		public TTable? DisplayItemConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060353D3 RID: 218067 RVA: 0x0073B9FC File Offset: 0x00739BFC
		public IVisualNovelDisplayItemClose DisplayItemConfigAsIVisualNovelDisplayItemClose()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemClose>().Value;
		}

		// Token: 0x060353D4 RID: 218068 RVA: 0x0073BA18 File Offset: 0x00739C18
		public IVisualNovelDisplayItemImage DisplayItemConfigAsIVisualNovelDisplayItemImage()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemImage>().Value;
		}

		// Token: 0x060353D5 RID: 218069 RVA: 0x0073BA34 File Offset: 0x00739C34
		public IVisualNovelDisplayItemPrefab DisplayItemConfigAsIVisualNovelDisplayItemPrefab()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemPrefab>().Value;
		}

		// Token: 0x1700DEE1 RID: 57057
		// (get) Token: 0x060353D6 RID: 218070 RVA: 0x0073BA50 File Offset: 0x00739C50
		public int PlotKeyId
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060353D7 RID: 218071 RVA: 0x0073BA90 File Offset: 0x00739C90
		public TVisualNovelPerformance StartPerformancesType(int j)
		{
			int num = this.__p.__offset(96);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DEE2 RID: 57058
		// (get) Token: 0x060353D8 RID: 218072 RVA: 0x0073BAD0 File Offset: 0x00739CD0
		public int StartPerformancesTypeLength
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060353D9 RID: 218073 RVA: 0x0073BAFC File Offset: 0x00739CFC
		public Span<TVisualNovelPerformance> GetStartPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(96, 1);
		}

		// Token: 0x060353DA RID: 218074 RVA: 0x0073BB0C File Offset: 0x00739D0C
		public TVisualNovelPerformance[] GetStartPerformancesTypeArray()
		{
			int num = this.__p.__offset(96);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVisualNovelPerformance[] array = new TVisualNovelPerformance[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVisualNovelPerformance)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060353DB RID: 218075 RVA: 0x0073BB78 File Offset: 0x00739D78
		public TTable? StartPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(98);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DEE3 RID: 57059
		// (get) Token: 0x060353DC RID: 218076 RVA: 0x0073BBC0 File Offset: 0x00739DC0
		public int StartPerformancesLength
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060353DD RID: 218077 RVA: 0x0073BBEC File Offset: 0x00739DEC
		public TVisualNovelPerformance EndPerformancesType(int j)
		{
			int num = this.__p.__offset(100);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DEE4 RID: 57060
		// (get) Token: 0x060353DE RID: 218078 RVA: 0x0073BC2C File Offset: 0x00739E2C
		public int EndPerformancesTypeLength
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060353DF RID: 218079 RVA: 0x0073BC58 File Offset: 0x00739E58
		public Span<TVisualNovelPerformance> GetEndPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(100, 1);
		}

		// Token: 0x060353E0 RID: 218080 RVA: 0x0073BC68 File Offset: 0x00739E68
		public TVisualNovelPerformance[] GetEndPerformancesTypeArray()
		{
			int num = this.__p.__offset(100);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVisualNovelPerformance[] array = new TVisualNovelPerformance[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVisualNovelPerformance)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060353E1 RID: 218081 RVA: 0x0073BCD4 File Offset: 0x00739ED4
		public TTable? EndPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(102);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DEE5 RID: 57061
		// (get) Token: 0x060353E2 RID: 218082 RVA: 0x0073BD1C File Offset: 0x00739F1C
		public int EndPerformancesLength
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DEE6 RID: 57062
		// (get) Token: 0x060353E3 RID: 218083 RVA: 0x0073BD48 File Offset: 0x00739F48
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060353E4 RID: 218084 RVA: 0x0073BD88 File Offset: 0x00739F88
		public static Offset<ITalkItemVisualNovelNoTextItem> CreateITalkItemVisualNovelNoTextItem(FlatBufferBuilder builder, ETalkItemType Type = ETalkItemType.Talk, int Id = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, int WhoId = 0, int TextId = 0, StringOffset TidTalkOffset = default(StringOffset), float WaitTime = 0f, Offset<ICaptionParam> CaptionParamsOffset = default(Offset<ICaptionParam>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), Offset<IPlayMontage> MontageOffset = default(Offset<IPlayMontage>), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>), Offset<ISetFlowTemplate> FlowTemplateOffset = default(Offset<ISetFlowTemplate>), VectorOffset FlowTemplateListOffset = default(VectorOffset), VectorOffset ActorMontageArrayOffset = default(VectorOffset), VectorOffset ActorFaceExpressionArrayOffset = default(VectorOffset), VectorOffset ActorLookAtArrayOffset = default(VectorOffset), VectorOffset ActorTurnToArrayOffset = default(VectorOffset), TPostAkEvent TalkAkEvent_type = TPostAkEvent.NONE, int TalkAkEventOffset = 0, TPostAkEvent TalkEndAkEvent_type = TPostAkEvent.NONE, int TalkEndAkEventOffset = 0, Offset<IUniversalTone> UniversalToneOffset = default(Offset<IUniversalTone>), TTalkBackground BackgroundConfig_type = TTalkBackground.NONE, int BackgroundConfigOffset = 0, bool PlayVoice = false, Offset<ITimeLimitOptionGroup> TimeLimitOptionGroupOffset = default(Offset<ITimeLimitOptionGroup>), Offset<IGamepadShakeInTalk> GamepadShakeOffset = default(Offset<IGamepadShakeInTalk>), VectorOffset IntroActionsOffset = default(VectorOffset), VectorOffset ActorFxEmoteArrayOffset = default(VectorOffset), VectorOffset TalkEffectArray_typeOffset = default(VectorOffset), VectorOffset TalkEffectArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), EVisualNovelOptionInteractionType OptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect, Offset<IVisualNovelOptionGroupSolarSchoolExam> OptionGroupOffset = default(Offset<IVisualNovelOptionGroupSolarSchoolExam>), TVisualNovelBackground VisualNovelBackgroundConfig_type = TVisualNovelBackground.NONE, int VisualNovelBackgroundConfigOffset = 0, TVisualNovelCg CgConfig_type = TVisualNovelCg.NONE, int CgConfigOffset = 0, TVisualNovelDisplayItem DisplayItemConfig_type = TVisualNovelDisplayItem.NONE, int DisplayItemConfigOffset = 0, int PlotKeyId = 0, VectorOffset StartPerformances_typeOffset = default(VectorOffset), VectorOffset StartPerformancesOffset = default(VectorOffset), VectorOffset EndPerformances_typeOffset = default(VectorOffset), VectorOffset EndPerformancesOffset = default(VectorOffset), uint NullMask = 0U)
		{
			builder.StartTable(51);
			ITalkItemVisualNovelNoTextItem.AddNullMask(builder, NullMask);
			ITalkItemVisualNovelNoTextItem.AddEndPerformances(builder, EndPerformancesOffset);
			ITalkItemVisualNovelNoTextItem.AddEndPerformancesType(builder, EndPerformances_typeOffset);
			ITalkItemVisualNovelNoTextItem.AddStartPerformances(builder, StartPerformancesOffset);
			ITalkItemVisualNovelNoTextItem.AddStartPerformancesType(builder, StartPerformances_typeOffset);
			ITalkItemVisualNovelNoTextItem.AddPlotKeyId(builder, PlotKeyId);
			ITalkItemVisualNovelNoTextItem.AddDisplayItemConfig(builder, DisplayItemConfigOffset);
			ITalkItemVisualNovelNoTextItem.AddCgConfig(builder, CgConfigOffset);
			ITalkItemVisualNovelNoTextItem.AddVisualNovelBackgroundConfig(builder, VisualNovelBackgroundConfigOffset);
			ITalkItemVisualNovelNoTextItem.AddOptionGroup(builder, OptionGroupOffset);
			ITalkItemVisualNovelNoTextItem.AddActorVisibilityArray(builder, ActorVisibilityArrayOffset);
			ITalkItemVisualNovelNoTextItem.AddTalkEffectArray(builder, TalkEffectArrayOffset);
			ITalkItemVisualNovelNoTextItem.AddTalkEffectArrayType(builder, TalkEffectArray_typeOffset);
			ITalkItemVisualNovelNoTextItem.AddActorFxEmoteArray(builder, ActorFxEmoteArrayOffset);
			ITalkItemVisualNovelNoTextItem.AddIntroActions(builder, IntroActionsOffset);
			ITalkItemVisualNovelNoTextItem.AddGamepadShake(builder, GamepadShakeOffset);
			ITalkItemVisualNovelNoTextItem.AddTimeLimitOptionGroup(builder, TimeLimitOptionGroupOffset);
			ITalkItemVisualNovelNoTextItem.AddBackgroundConfig(builder, BackgroundConfigOffset);
			ITalkItemVisualNovelNoTextItem.AddUniversalTone(builder, UniversalToneOffset);
			ITalkItemVisualNovelNoTextItem.AddTalkEndAkEvent(builder, TalkEndAkEventOffset);
			ITalkItemVisualNovelNoTextItem.AddTalkAkEvent(builder, TalkAkEventOffset);
			ITalkItemVisualNovelNoTextItem.AddActorTurnToArray(builder, ActorTurnToArrayOffset);
			ITalkItemVisualNovelNoTextItem.AddActorLookAtArray(builder, ActorLookAtArrayOffset);
			ITalkItemVisualNovelNoTextItem.AddActorFaceExpressionArray(builder, ActorFaceExpressionArrayOffset);
			ITalkItemVisualNovelNoTextItem.AddActorMontageArray(builder, ActorMontageArrayOffset);
			ITalkItemVisualNovelNoTextItem.AddFlowTemplateList(builder, FlowTemplateListOffset);
			ITalkItemVisualNovelNoTextItem.AddFlowTemplate(builder, FlowTemplateOffset);
			ITalkItemVisualNovelNoTextItem.AddCameraData(builder, CameraDataOffset);
			ITalkItemVisualNovelNoTextItem.AddMontage(builder, MontageOffset);
			ITalkItemVisualNovelNoTextItem.AddOptions(builder, OptionsOffset);
			ITalkItemVisualNovelNoTextItem.AddActions(builder, ActionsOffset);
			ITalkItemVisualNovelNoTextItem.AddCaptionParams(builder, CaptionParamsOffset);
			ITalkItemVisualNovelNoTextItem.AddWaitTime(builder, WaitTime);
			ITalkItemVisualNovelNoTextItem.AddTidTalk(builder, TidTalkOffset);
			ITalkItemVisualNovelNoTextItem.AddTextId(builder, TextId);
			ITalkItemVisualNovelNoTextItem.AddWhoId(builder, WhoId);
			ITalkItemVisualNovelNoTextItem.AddName(builder, NameOffset);
			ITalkItemVisualNovelNoTextItem.AddPlotLineKey(builder, PlotLineKeyOffset);
			ITalkItemVisualNovelNoTextItem.AddPlotLineId(builder, PlotLineId);
			ITalkItemVisualNovelNoTextItem.AddId(builder, Id);
			ITalkItemVisualNovelNoTextItem.AddDisplayItemConfigType(builder, DisplayItemConfig_type);
			ITalkItemVisualNovelNoTextItem.AddCgConfigType(builder, CgConfig_type);
			ITalkItemVisualNovelNoTextItem.AddVisualNovelBackgroundConfigType(builder, VisualNovelBackgroundConfig_type);
			ITalkItemVisualNovelNoTextItem.AddOptionInteractionType(builder, OptionInteractionType);
			ITalkItemVisualNovelNoTextItem.AddPlayVoice(builder, PlayVoice);
			ITalkItemVisualNovelNoTextItem.AddBackgroundConfigType(builder, BackgroundConfig_type);
			ITalkItemVisualNovelNoTextItem.AddTalkEndAkEventType(builder, TalkEndAkEvent_type);
			ITalkItemVisualNovelNoTextItem.AddTalkAkEventType(builder, TalkAkEvent_type);
			ITalkItemVisualNovelNoTextItem.Add_EditFlag(builder, _editFlag);
			ITalkItemVisualNovelNoTextItem.Add_Folded(builder, _folded);
			ITalkItemVisualNovelNoTextItem.AddType(builder, Type);
			return ITalkItemVisualNovelNoTextItem.EndITalkItemVisualNovelNoTextItem(builder);
		}

		// Token: 0x060353E5 RID: 218085 RVA: 0x0073BF38 File Offset: 0x0073A138
		public static void StartITalkItemVisualNovelNoTextItem(FlatBufferBuilder builder)
		{
			builder.StartTable(51);
		}

		// Token: 0x060353E6 RID: 218086 RVA: 0x0073BF42 File Offset: 0x0073A142
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060353E7 RID: 218087 RVA: 0x0073BF4D File Offset: 0x0073A14D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060353E8 RID: 218088 RVA: 0x0073BF58 File Offset: 0x0073A158
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x060353E9 RID: 218089 RVA: 0x0073BF63 File Offset: 0x0073A163
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x060353EA RID: 218090 RVA: 0x0073BF73 File Offset: 0x0073A173
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x060353EB RID: 218091 RVA: 0x0073BF83 File Offset: 0x0073A183
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x060353EC RID: 218092 RVA: 0x0073BF8E File Offset: 0x0073A18E
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x060353ED RID: 218093 RVA: 0x0073BF99 File Offset: 0x0073A199
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x060353EE RID: 218094 RVA: 0x0073BFA4 File Offset: 0x0073A1A4
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x060353EF RID: 218095 RVA: 0x0073BFAF File Offset: 0x0073A1AF
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x060353F0 RID: 218096 RVA: 0x0073BFC0 File Offset: 0x0073A1C0
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x060353F1 RID: 218097 RVA: 0x0073BFD4 File Offset: 0x0073A1D4
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x060353F2 RID: 218098 RVA: 0x0073BFE5 File Offset: 0x0073A1E5
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x060353F3 RID: 218099 RVA: 0x0073BFF8 File Offset: 0x0073A1F8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060353F4 RID: 218100 RVA: 0x0073C038 File Offset: 0x0073A238
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060353F5 RID: 218101 RVA: 0x0073C052 File Offset: 0x0073A252
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060353F6 RID: 218102 RVA: 0x0073C070 File Offset: 0x0073A270
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060353F7 RID: 218103 RVA: 0x0073C089 File Offset: 0x0073A289
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060353F8 RID: 218104 RVA: 0x0073C094 File Offset: 0x0073A294
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x060353F9 RID: 218105 RVA: 0x0073C0A8 File Offset: 0x0073A2A8
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060353FA RID: 218106 RVA: 0x0073C0E8 File Offset: 0x0073A2E8
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060353FB RID: 218107 RVA: 0x0073C102 File Offset: 0x0073A302
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060353FC RID: 218108 RVA: 0x0073C120 File Offset: 0x0073A320
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060353FD RID: 218109 RVA: 0x0073C139 File Offset: 0x0073A339
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060353FE RID: 218110 RVA: 0x0073C144 File Offset: 0x0073A344
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x060353FF RID: 218111 RVA: 0x0073C155 File Offset: 0x0073A355
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x06035400 RID: 218112 RVA: 0x0073C166 File Offset: 0x0073A366
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x06035401 RID: 218113 RVA: 0x0073C177 File Offset: 0x0073A377
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x06035402 RID: 218114 RVA: 0x0073C188 File Offset: 0x0073A388
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035403 RID: 218115 RVA: 0x0073C1C8 File Offset: 0x0073A3C8
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035404 RID: 218116 RVA: 0x0073C1E2 File Offset: 0x0073A3E2
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035405 RID: 218117 RVA: 0x0073C200 File Offset: 0x0073A400
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035406 RID: 218118 RVA: 0x0073C219 File Offset: 0x0073A419
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035407 RID: 218119 RVA: 0x0073C224 File Offset: 0x0073A424
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x06035408 RID: 218120 RVA: 0x0073C238 File Offset: 0x0073A438
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035409 RID: 218121 RVA: 0x0073C278 File Offset: 0x0073A478
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603540A RID: 218122 RVA: 0x0073C292 File Offset: 0x0073A492
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603540B RID: 218123 RVA: 0x0073C2B0 File Offset: 0x0073A4B0
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603540C RID: 218124 RVA: 0x0073C2C9 File Offset: 0x0073A4C9
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603540D RID: 218125 RVA: 0x0073C2D4 File Offset: 0x0073A4D4
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x0603540E RID: 218126 RVA: 0x0073C2E8 File Offset: 0x0073A4E8
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603540F RID: 218127 RVA: 0x0073C328 File Offset: 0x0073A528
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035410 RID: 218128 RVA: 0x0073C342 File Offset: 0x0073A542
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035411 RID: 218129 RVA: 0x0073C360 File Offset: 0x0073A560
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035412 RID: 218130 RVA: 0x0073C379 File Offset: 0x0073A579
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035413 RID: 218131 RVA: 0x0073C384 File Offset: 0x0073A584
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x06035414 RID: 218132 RVA: 0x0073C398 File Offset: 0x0073A598
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035415 RID: 218133 RVA: 0x0073C3D8 File Offset: 0x0073A5D8
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035416 RID: 218134 RVA: 0x0073C3F2 File Offset: 0x0073A5F2
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035417 RID: 218135 RVA: 0x0073C410 File Offset: 0x0073A610
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035418 RID: 218136 RVA: 0x0073C429 File Offset: 0x0073A629
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035419 RID: 218137 RVA: 0x0073C434 File Offset: 0x0073A634
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x0603541A RID: 218138 RVA: 0x0073C448 File Offset: 0x0073A648
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603541B RID: 218139 RVA: 0x0073C488 File Offset: 0x0073A688
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603541C RID: 218140 RVA: 0x0073C4A2 File Offset: 0x0073A6A2
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603541D RID: 218141 RVA: 0x0073C4C0 File Offset: 0x0073A6C0
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603541E RID: 218142 RVA: 0x0073C4D9 File Offset: 0x0073A6D9
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603541F RID: 218143 RVA: 0x0073C4E4 File Offset: 0x0073A6E4
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x06035420 RID: 218144 RVA: 0x0073C4F0 File Offset: 0x0073A6F0
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x06035421 RID: 218145 RVA: 0x0073C4FC File Offset: 0x0073A6FC
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x06035422 RID: 218146 RVA: 0x0073C508 File Offset: 0x0073A708
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x06035423 RID: 218147 RVA: 0x0073C514 File Offset: 0x0073A714
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x06035424 RID: 218148 RVA: 0x0073C525 File Offset: 0x0073A725
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x06035425 RID: 218149 RVA: 0x0073C531 File Offset: 0x0073A731
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x06035426 RID: 218150 RVA: 0x0073C53D File Offset: 0x0073A73D
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x06035427 RID: 218151 RVA: 0x0073C549 File Offset: 0x0073A749
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x06035428 RID: 218152 RVA: 0x0073C55A File Offset: 0x0073A75A
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x06035429 RID: 218153 RVA: 0x0073C56B File Offset: 0x0073A76B
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x0603542A RID: 218154 RVA: 0x0073C57C File Offset: 0x0073A77C
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603542B RID: 218155 RVA: 0x0073C5BC File Offset: 0x0073A7BC
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603542C RID: 218156 RVA: 0x0073C5D6 File Offset: 0x0073A7D6
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603542D RID: 218157 RVA: 0x0073C5F4 File Offset: 0x0073A7F4
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603542E RID: 218158 RVA: 0x0073C60D File Offset: 0x0073A80D
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603542F RID: 218159 RVA: 0x0073C618 File Offset: 0x0073A818
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x06035430 RID: 218160 RVA: 0x0073C62C File Offset: 0x0073A82C
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035431 RID: 218161 RVA: 0x0073C66C File Offset: 0x0073A86C
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035432 RID: 218162 RVA: 0x0073C686 File Offset: 0x0073A886
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035433 RID: 218163 RVA: 0x0073C6A4 File Offset: 0x0073A8A4
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035434 RID: 218164 RVA: 0x0073C6BD File Offset: 0x0073A8BD
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035435 RID: 218165 RVA: 0x0073C6C8 File Offset: 0x0073A8C8
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x06035436 RID: 218166 RVA: 0x0073C6DC File Offset: 0x0073A8DC
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035437 RID: 218167 RVA: 0x0073C713 File Offset: 0x0073A913
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06035438 RID: 218168 RVA: 0x0073C72D File Offset: 0x0073A92D
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06035439 RID: 218169 RVA: 0x0073C74B File Offset: 0x0073A94B
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603543A RID: 218170 RVA: 0x0073C764 File Offset: 0x0073A964
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603543B RID: 218171 RVA: 0x0073C76F File Offset: 0x0073A96F
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x0603543C RID: 218172 RVA: 0x0073C780 File Offset: 0x0073A980
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603543D RID: 218173 RVA: 0x0073C7B7 File Offset: 0x0073A9B7
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603543E RID: 218174 RVA: 0x0073C7D1 File Offset: 0x0073A9D1
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603543F RID: 218175 RVA: 0x0073C7EF File Offset: 0x0073A9EF
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035440 RID: 218176 RVA: 0x0073C808 File Offset: 0x0073AA08
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035441 RID: 218177 RVA: 0x0073C813 File Offset: 0x0073AA13
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x06035442 RID: 218178 RVA: 0x0073C824 File Offset: 0x0073AA24
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035443 RID: 218179 RVA: 0x0073C864 File Offset: 0x0073AA64
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035444 RID: 218180 RVA: 0x0073C87E File Offset: 0x0073AA7E
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035445 RID: 218181 RVA: 0x0073C89C File Offset: 0x0073AA9C
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035446 RID: 218182 RVA: 0x0073C8B5 File Offset: 0x0073AAB5
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035447 RID: 218183 RVA: 0x0073C8C0 File Offset: 0x0073AAC0
		public static void AddOptionInteractionType(FlatBufferBuilder builder, EVisualNovelOptionInteractionType optionInteractionType)
		{
			builder.AddByte(37, (byte)optionInteractionType, 0);
		}

		// Token: 0x06035448 RID: 218184 RVA: 0x0073C8CC File Offset: 0x0073AACC
		public static void AddOptionGroup(FlatBufferBuilder builder, Offset<IVisualNovelOptionGroupSolarSchoolExam> optionGroupOffset)
		{
			builder.AddOffset(38, optionGroupOffset.Value, 0);
		}

		// Token: 0x06035449 RID: 218185 RVA: 0x0073C8DD File Offset: 0x0073AADD
		public static void AddVisualNovelBackgroundConfigType(FlatBufferBuilder builder, TVisualNovelBackground visualNovelBackgroundConfigType)
		{
			builder.AddByte(39, (byte)visualNovelBackgroundConfigType, 0);
		}

		// Token: 0x0603544A RID: 218186 RVA: 0x0073C8E9 File Offset: 0x0073AAE9
		public static void AddVisualNovelBackgroundConfig(FlatBufferBuilder builder, int visualNovelBackgroundConfigOffset)
		{
			builder.AddOffset(40, visualNovelBackgroundConfigOffset, 0);
		}

		// Token: 0x0603544B RID: 218187 RVA: 0x0073C8F5 File Offset: 0x0073AAF5
		public static void AddCgConfigType(FlatBufferBuilder builder, TVisualNovelCg cgConfigType)
		{
			builder.AddByte(41, (byte)cgConfigType, 0);
		}

		// Token: 0x0603544C RID: 218188 RVA: 0x0073C901 File Offset: 0x0073AB01
		public static void AddCgConfig(FlatBufferBuilder builder, int cgConfigOffset)
		{
			builder.AddOffset(42, cgConfigOffset, 0);
		}

		// Token: 0x0603544D RID: 218189 RVA: 0x0073C90D File Offset: 0x0073AB0D
		public static void AddDisplayItemConfigType(FlatBufferBuilder builder, TVisualNovelDisplayItem displayItemConfigType)
		{
			builder.AddByte(43, (byte)displayItemConfigType, 0);
		}

		// Token: 0x0603544E RID: 218190 RVA: 0x0073C919 File Offset: 0x0073AB19
		public static void AddDisplayItemConfig(FlatBufferBuilder builder, int displayItemConfigOffset)
		{
			builder.AddOffset(44, displayItemConfigOffset, 0);
		}

		// Token: 0x0603544F RID: 218191 RVA: 0x0073C925 File Offset: 0x0073AB25
		public static void AddPlotKeyId(FlatBufferBuilder builder, int plotKeyId)
		{
			builder.AddInt(45, plotKeyId, 0);
		}

		// Token: 0x06035450 RID: 218192 RVA: 0x0073C931 File Offset: 0x0073AB31
		public static void AddStartPerformancesType(FlatBufferBuilder builder, VectorOffset startPerformancesTypeOffset)
		{
			builder.AddOffset(46, startPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x06035451 RID: 218193 RVA: 0x0073C944 File Offset: 0x0073AB44
		public static VectorOffset CreateStartPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035452 RID: 218194 RVA: 0x0073C97B File Offset: 0x0073AB7B
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035453 RID: 218195 RVA: 0x0073C995 File Offset: 0x0073AB95
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035454 RID: 218196 RVA: 0x0073C9B3 File Offset: 0x0073ABB3
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035455 RID: 218197 RVA: 0x0073C9CC File Offset: 0x0073ABCC
		public static void StartStartPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06035456 RID: 218198 RVA: 0x0073C9D7 File Offset: 0x0073ABD7
		public static void AddStartPerformances(FlatBufferBuilder builder, VectorOffset startPerformancesOffset)
		{
			builder.AddOffset(47, startPerformancesOffset.Value, 0);
		}

		// Token: 0x06035457 RID: 218199 RVA: 0x0073C9E8 File Offset: 0x0073ABE8
		public static VectorOffset CreateStartPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035458 RID: 218200 RVA: 0x0073CA1F File Offset: 0x0073AC1F
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035459 RID: 218201 RVA: 0x0073CA39 File Offset: 0x0073AC39
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603545A RID: 218202 RVA: 0x0073CA57 File Offset: 0x0073AC57
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603545B RID: 218203 RVA: 0x0073CA70 File Offset: 0x0073AC70
		public static void StartStartPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603545C RID: 218204 RVA: 0x0073CA7B File Offset: 0x0073AC7B
		public static void AddEndPerformancesType(FlatBufferBuilder builder, VectorOffset endPerformancesTypeOffset)
		{
			builder.AddOffset(48, endPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x0603545D RID: 218205 RVA: 0x0073CA8C File Offset: 0x0073AC8C
		public static VectorOffset CreateEndPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603545E RID: 218206 RVA: 0x0073CAC3 File Offset: 0x0073ACC3
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x0603545F RID: 218207 RVA: 0x0073CADD File Offset: 0x0073ACDD
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035460 RID: 218208 RVA: 0x0073CAFB File Offset: 0x0073ACFB
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035461 RID: 218209 RVA: 0x0073CB14 File Offset: 0x0073AD14
		public static void StartEndPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06035462 RID: 218210 RVA: 0x0073CB1F File Offset: 0x0073AD1F
		public static void AddEndPerformances(FlatBufferBuilder builder, VectorOffset endPerformancesOffset)
		{
			builder.AddOffset(49, endPerformancesOffset.Value, 0);
		}

		// Token: 0x06035463 RID: 218211 RVA: 0x0073CB30 File Offset: 0x0073AD30
		public static VectorOffset CreateEndPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035464 RID: 218212 RVA: 0x0073CB67 File Offset: 0x0073AD67
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035465 RID: 218213 RVA: 0x0073CB81 File Offset: 0x0073AD81
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035466 RID: 218214 RVA: 0x0073CB9F File Offset: 0x0073AD9F
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035467 RID: 218215 RVA: 0x0073CBB8 File Offset: 0x0073ADB8
		public static void StartEndPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035468 RID: 218216 RVA: 0x0073CBC3 File Offset: 0x0073ADC3
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(50, nullMask, 0U);
		}

		// Token: 0x06035469 RID: 218217 RVA: 0x0073CBCF File Offset: 0x0073ADCF
		public static Offset<ITalkItemVisualNovelNoTextItem> EndITalkItemVisualNovelNoTextItem(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemVisualNovelNoTextItem>(builder.EndTable());
		}

		// Token: 0x0603546A RID: 218218 RVA: 0x0073CBDC File Offset: 0x0073ADDC
		public ITalkItemVisualNovelNoTextItemT UnPack()
		{
			ITalkItemVisualNovelNoTextItemT talkItemVisualNovelNoTextItemT = new ITalkItemVisualNovelNoTextItemT();
			this.UnPackTo(talkItemVisualNovelNoTextItemT);
			return talkItemVisualNovelNoTextItemT;
		}

		// Token: 0x0603546B RID: 218219 RVA: 0x0073CBF8 File Offset: 0x0073ADF8
		public void UnPackTo(ITalkItemVisualNovelNoTextItemT _o)
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
			_o.StartPerformances = new List<TVisualNovelPerformanceUnion>();
			for (int num6 = 0; num6 < this.StartPerformancesLength; num6++)
			{
				TVisualNovelPerformanceUnion tvisualNovelPerformanceUnion = new TVisualNovelPerformanceUnion();
				tvisualNovelPerformanceUnion.Type = this.StartPerformancesType(num6);
				switch (this.StartPerformancesType(num6))
				{
				case TVisualNovelPerformance.IVisualNovelPerformanceActivityAction:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceActivityAction>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceActivityAction>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceBackgroundMove:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceBackgroundMove>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceBackgroundMove>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceCgMove:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceCgMove>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceCgMove>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceEnter:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceEnter>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceEnter>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceEnterBlackScreen:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceEnterBlackScreen>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceEnterBlackScreen>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceExit:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceExit>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceExit>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceLeaveBlackScreen:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceLeaveBlackScreen>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceLeaveBlackScreen>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceModifyRole:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceModifyRole>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceModifyRole>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceMove:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceMove>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceMove>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformancePlayScreenEffect:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformancePlayScreenEffect>(num6) != null) ? this.StartPerformances<IVisualNovelPerformancePlayScreenEffect>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformancePortraitEffect:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformancePortraitEffect>(num6) != null) ? this.StartPerformances<IVisualNovelPerformancePortraitEffect>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceRoleIntroduction:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceRoleIntroduction>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceRoleIntroduction>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceSendAudioEvent:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceSendAudioEvent>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceSendAudioEvent>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceStopScreenEffect:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceStopScreenEffect>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceStopScreenEffect>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceSwitchAudioState:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceSwitchAudioState>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceSwitchAudioState>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceTransition:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceTransition>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceTransition>(num6).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceUiShake:
					tvisualNovelPerformanceUnion.Value = ((this.StartPerformances<IVisualNovelPerformanceUiShake>(num6) != null) ? this.StartPerformances<IVisualNovelPerformanceUiShake>(num6).Value.UnPack() : null);
					break;
				}
				_o.StartPerformances.Add(tvisualNovelPerformanceUnion);
			}
			_o.EndPerformances = new List<TVisualNovelPerformanceUnion>();
			for (int num7 = 0; num7 < this.EndPerformancesLength; num7++)
			{
				TVisualNovelPerformanceUnion tvisualNovelPerformanceUnion2 = new TVisualNovelPerformanceUnion();
				tvisualNovelPerformanceUnion2.Type = this.EndPerformancesType(num7);
				switch (this.EndPerformancesType(num7))
				{
				case TVisualNovelPerformance.IVisualNovelPerformanceActivityAction:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceActivityAction>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceActivityAction>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceBackgroundMove:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceBackgroundMove>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceBackgroundMove>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceCgMove:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceCgMove>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceCgMove>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceEnter:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceEnter>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceEnter>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceEnterBlackScreen:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceEnterBlackScreen>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceEnterBlackScreen>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceExit:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceExit>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceExit>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceLeaveBlackScreen:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceLeaveBlackScreen>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceLeaveBlackScreen>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceModifyRole:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceModifyRole>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceModifyRole>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceMove:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceMove>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceMove>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformancePlayScreenEffect:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformancePlayScreenEffect>(num7) != null) ? this.EndPerformances<IVisualNovelPerformancePlayScreenEffect>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformancePortraitEffect:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformancePortraitEffect>(num7) != null) ? this.EndPerformances<IVisualNovelPerformancePortraitEffect>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceRoleIntroduction:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceRoleIntroduction>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceRoleIntroduction>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceSendAudioEvent:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceSendAudioEvent>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceSendAudioEvent>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceStopScreenEffect:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceStopScreenEffect>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceStopScreenEffect>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceSwitchAudioState:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceSwitchAudioState>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceSwitchAudioState>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceTransition:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceTransition>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceTransition>(num7).Value.UnPack() : null);
					break;
				case TVisualNovelPerformance.IVisualNovelPerformanceUiShake:
					tvisualNovelPerformanceUnion2.Value = ((this.EndPerformances<IVisualNovelPerformanceUiShake>(num7) != null) ? this.EndPerformances<IVisualNovelPerformanceUiShake>(num7).Value.UnPack() : null);
					break;
				}
				_o.EndPerformances.Add(tvisualNovelPerformanceUnion2);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603546C RID: 218220 RVA: 0x0073E1E8 File Offset: 0x0073C3E8
		public static Offset<ITalkItemVisualNovelNoTextItem> Pack(FlatBufferBuilder builder, ITalkItemVisualNovelNoTextItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemVisualNovelNoTextItem>);
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
				actionsOffset = ITalkItemVisualNovelNoTextItem.CreateActionsVector(builder, array);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<ITalkOption>[] array2 = new Offset<ITalkOption>[_o.Options.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ITalkOption.Pack(builder, _o.Options[j]);
				}
				optionsOffset = ITalkItemVisualNovelNoTextItem.CreateOptionsVector(builder, array2);
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
				flowTemplateListOffset = ITalkItemVisualNovelNoTextItem.CreateFlowTemplateListVector(builder, array3);
			}
			VectorOffset actorMontageArrayOffset = default(VectorOffset);
			if (_o.ActorMontageArray != null)
			{
				Offset<IMontageData>[] array4 = new Offset<IMontageData>[_o.ActorMontageArray.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IMontageData.Pack(builder, _o.ActorMontageArray[l]);
				}
				actorMontageArrayOffset = ITalkItemVisualNovelNoTextItem.CreateActorMontageArrayVector(builder, array4);
			}
			VectorOffset actorFaceExpressionArrayOffset = default(VectorOffset);
			if (_o.ActorFaceExpressionArray != null)
			{
				Offset<IActorFaceExpression>[] array5 = new Offset<IActorFaceExpression>[_o.ActorFaceExpressionArray.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActorFaceExpression.Pack(builder, _o.ActorFaceExpressionArray[m]);
				}
				actorFaceExpressionArrayOffset = ITalkItemVisualNovelNoTextItem.CreateActorFaceExpressionArrayVector(builder, array5);
			}
			VectorOffset actorLookAtArrayOffset = default(VectorOffset);
			if (_o.ActorLookAtArray != null)
			{
				Offset<IActorLookAt>[] array6 = new Offset<IActorLookAt>[_o.ActorLookAtArray.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = IActorLookAt.Pack(builder, _o.ActorLookAtArray[n]);
				}
				actorLookAtArrayOffset = ITalkItemVisualNovelNoTextItem.CreateActorLookAtArrayVector(builder, array6);
			}
			VectorOffset actorTurnToArrayOffset = default(VectorOffset);
			if (_o.ActorTurnToArray != null)
			{
				Offset<IActorTurnTo>[] array7 = new Offset<IActorTurnTo>[_o.ActorTurnToArray.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = IActorTurnTo.Pack(builder, _o.ActorTurnToArray[num]);
				}
				actorTurnToArrayOffset = ITalkItemVisualNovelNoTextItem.CreateActorTurnToArrayVector(builder, array7);
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
				introActionsOffset = ITalkItemVisualNovelNoTextItem.CreateIntroActionsVector(builder, array8);
			}
			VectorOffset actorFxEmoteArrayOffset = default(VectorOffset);
			if (_o.ActorFxEmoteArray != null)
			{
				Offset<IActorFxEmote>[] array9 = new Offset<IActorFxEmote>[_o.ActorFxEmoteArray.Count];
				for (int num3 = 0; num3 < array9.Length; num3++)
				{
					array9[num3] = IActorFxEmote.Pack(builder, _o.ActorFxEmoteArray[num3]);
				}
				actorFxEmoteArrayOffset = ITalkItemVisualNovelNoTextItem.CreateActorFxEmoteArrayVector(builder, array9);
			}
			VectorOffset talkEffectArray_typeOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				TTalkEffectAction[] array10 = new TTalkEffectAction[_o.TalkEffectArray.Count];
				for (int num4 = 0; num4 < array10.Length; num4++)
				{
					array10[num4] = _o.TalkEffectArray[num4].Type;
				}
				talkEffectArray_typeOffset = ITalkItemVisualNovelNoTextItem.CreateTalkEffectArrayTypeVector(builder, array10);
			}
			VectorOffset talkEffectArrayOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				int[] array11 = new int[_o.TalkEffectArray.Count];
				for (int num5 = 0; num5 < array11.Length; num5++)
				{
					array11[num5] = TTalkEffectActionUnion.Pack(builder, _o.TalkEffectArray[num5]);
				}
				talkEffectArrayOffset = ITalkItemVisualNovelNoTextItem.CreateTalkEffectArrayVector(builder, array11);
			}
			VectorOffset actorVisibilityArrayOffset = default(VectorOffset);
			if (_o.ActorVisibilityArray != null)
			{
				Offset<IActorVisibility>[] array12 = new Offset<IActorVisibility>[_o.ActorVisibilityArray.Count];
				for (int num6 = 0; num6 < array12.Length; num6++)
				{
					array12[num6] = IActorVisibility.Pack(builder, _o.ActorVisibilityArray[num6]);
				}
				actorVisibilityArrayOffset = ITalkItemVisualNovelNoTextItem.CreateActorVisibilityArrayVector(builder, array12);
			}
			Offset<IVisualNovelOptionGroupSolarSchoolExam> optionGroupOffset = (_o.OptionGroup == null) ? default(Offset<IVisualNovelOptionGroupSolarSchoolExam>) : IVisualNovelOptionGroupSolarSchoolExam.Pack(builder, _o.OptionGroup);
			TVisualNovelBackground visualNovelBackgroundConfig_type = (_o.VisualNovelBackgroundConfig == null) ? TVisualNovelBackground.NONE : _o.VisualNovelBackgroundConfig.Type;
			int visualNovelBackgroundConfigOffset = (_o.VisualNovelBackgroundConfig == null) ? 0 : TVisualNovelBackgroundUnion.Pack(builder, _o.VisualNovelBackgroundConfig);
			TVisualNovelCg cgConfig_type = (_o.CgConfig == null) ? TVisualNovelCg.NONE : _o.CgConfig.Type;
			int cgConfigOffset = (_o.CgConfig == null) ? 0 : TVisualNovelCgUnion.Pack(builder, _o.CgConfig);
			TVisualNovelDisplayItem displayItemConfig_type = (_o.DisplayItemConfig == null) ? TVisualNovelDisplayItem.NONE : _o.DisplayItemConfig.Type;
			int displayItemConfigOffset = (_o.DisplayItemConfig == null) ? 0 : TVisualNovelDisplayItemUnion.Pack(builder, _o.DisplayItemConfig);
			VectorOffset startPerformances_typeOffset = default(VectorOffset);
			if (_o.StartPerformances != null)
			{
				TVisualNovelPerformance[] array13 = new TVisualNovelPerformance[_o.StartPerformances.Count];
				for (int num7 = 0; num7 < array13.Length; num7++)
				{
					array13[num7] = _o.StartPerformances[num7].Type;
				}
				startPerformances_typeOffset = ITalkItemVisualNovelNoTextItem.CreateStartPerformancesTypeVector(builder, array13);
			}
			VectorOffset startPerformancesOffset = default(VectorOffset);
			if (_o.StartPerformances != null)
			{
				int[] array14 = new int[_o.StartPerformances.Count];
				for (int num8 = 0; num8 < array14.Length; num8++)
				{
					array14[num8] = TVisualNovelPerformanceUnion.Pack(builder, _o.StartPerformances[num8]);
				}
				startPerformancesOffset = ITalkItemVisualNovelNoTextItem.CreateStartPerformancesVector(builder, array14);
			}
			VectorOffset endPerformances_typeOffset = default(VectorOffset);
			if (_o.EndPerformances != null)
			{
				TVisualNovelPerformance[] array15 = new TVisualNovelPerformance[_o.EndPerformances.Count];
				for (int num9 = 0; num9 < array15.Length; num9++)
				{
					array15[num9] = _o.EndPerformances[num9].Type;
				}
				endPerformances_typeOffset = ITalkItemVisualNovelNoTextItem.CreateEndPerformancesTypeVector(builder, array15);
			}
			VectorOffset endPerformancesOffset = default(VectorOffset);
			if (_o.EndPerformances != null)
			{
				int[] array16 = new int[_o.EndPerformances.Count];
				for (int num10 = 0; num10 < array16.Length; num10++)
				{
					array16[num10] = TVisualNovelPerformanceUnion.Pack(builder, _o.EndPerformances[num10]);
				}
				endPerformancesOffset = ITalkItemVisualNovelNoTextItem.CreateEndPerformancesVector(builder, array16);
			}
			return ITalkItemVisualNovelNoTextItem.CreateITalkItemVisualNovelNoTextItem(builder, _o.Type, _o.Id, _o.PlotLineId, plotLineKeyOffset, nameOffset, _o._Folded, _o._EditFlag, _o.WhoId, _o.TextId, tidTalkOffset, _o.WaitTime, captionParamsOffset, actionsOffset, optionsOffset, montageOffset, cameraDataOffset, flowTemplateOffset, flowTemplateListOffset, actorMontageArrayOffset, actorFaceExpressionArrayOffset, actorLookAtArrayOffset, actorTurnToArrayOffset, talkAkEvent_type, talkAkEventOffset, talkEndAkEvent_type, talkEndAkEventOffset, universalToneOffset, backgroundConfig_type, backgroundConfigOffset, _o.PlayVoice, timeLimitOptionGroupOffset, gamepadShakeOffset, introActionsOffset, actorFxEmoteArrayOffset, talkEffectArray_typeOffset, talkEffectArrayOffset, actorVisibilityArrayOffset, _o.OptionInteractionType, optionGroupOffset, visualNovelBackgroundConfig_type, visualNovelBackgroundConfigOffset, cgConfig_type, cgConfigOffset, displayItemConfig_type, displayItemConfigOffset, _o.PlotKeyId, startPerformances_typeOffset, startPerformancesOffset, endPerformances_typeOffset, endPerformancesOffset, _o.NullMask);
		}

		// Token: 0x04012060 RID: 73824
		private Table __p;
	}
}
