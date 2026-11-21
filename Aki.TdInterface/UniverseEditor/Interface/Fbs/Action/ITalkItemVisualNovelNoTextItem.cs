using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AEB RID: 31467
	public struct ITalkItemVisualNovelNoTextItem : IFlatbufferObject
	{
		// Token: 0x1700EAB7 RID: 60087
		// (get) Token: 0x060386A5 RID: 231077 RVA: 0x0079C0FB File Offset: 0x0079A2FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060386A6 RID: 231078 RVA: 0x0079C108 File Offset: 0x0079A308
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060386A7 RID: 231079 RVA: 0x0079C110 File Offset: 0x0079A310
		public static ITalkItemVisualNovelNoTextItem GetRootAsITalkItemVisualNovelNoTextItem(ByteBuffer _bb)
		{
			return ITalkItemVisualNovelNoTextItem.GetRootAsITalkItemVisualNovelNoTextItem(_bb, default(ITalkItemVisualNovelNoTextItem));
		}

		// Token: 0x060386A8 RID: 231080 RVA: 0x0079C12C File Offset: 0x0079A32C
		public static ITalkItemVisualNovelNoTextItem GetRootAsITalkItemVisualNovelNoTextItem(ByteBuffer _bb, ITalkItemVisualNovelNoTextItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060386A9 RID: 231081 RVA: 0x0079C149 File Offset: 0x0079A349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060386AA RID: 231082 RVA: 0x0079C158 File Offset: 0x0079A358
		public ITalkItemVisualNovelNoTextItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EAB8 RID: 60088
		// (get) Token: 0x060386AB RID: 231083 RVA: 0x0079C168 File Offset: 0x0079A368
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

		// Token: 0x1700EAB9 RID: 60089
		// (get) Token: 0x060386AC RID: 231084 RVA: 0x0079C1A4 File Offset: 0x0079A3A4
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

		// Token: 0x1700EABA RID: 60090
		// (get) Token: 0x060386AD RID: 231085 RVA: 0x0079C1E0 File Offset: 0x0079A3E0
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

		// Token: 0x1700EABB RID: 60091
		// (get) Token: 0x060386AE RID: 231086 RVA: 0x0079C21C File Offset: 0x0079A41C
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

		// Token: 0x060386AF RID: 231087 RVA: 0x0079C254 File Offset: 0x0079A454
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060386B0 RID: 231088 RVA: 0x0079C264 File Offset: 0x0079A464
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700EABC RID: 60092
		// (get) Token: 0x060386B1 RID: 231089 RVA: 0x0079C274 File Offset: 0x0079A474
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

		// Token: 0x060386B2 RID: 231090 RVA: 0x0079C2AC File Offset: 0x0079A4AC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060386B3 RID: 231091 RVA: 0x0079C2BC File Offset: 0x0079A4BC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700EABD RID: 60093
		// (get) Token: 0x060386B4 RID: 231092 RVA: 0x0079C2CC File Offset: 0x0079A4CC
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EABE RID: 60094
		// (get) Token: 0x060386B5 RID: 231093 RVA: 0x0079C30C File Offset: 0x0079A50C
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

		// Token: 0x1700EABF RID: 60095
		// (get) Token: 0x060386B6 RID: 231094 RVA: 0x0079C34C File Offset: 0x0079A54C
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

		// Token: 0x1700EAC0 RID: 60096
		// (get) Token: 0x060386B7 RID: 231095 RVA: 0x0079C38C File Offset: 0x0079A58C
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

		// Token: 0x1700EAC1 RID: 60097
		// (get) Token: 0x060386B8 RID: 231096 RVA: 0x0079C3CC File Offset: 0x0079A5CC
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

		// Token: 0x060386B9 RID: 231097 RVA: 0x0079C404 File Offset: 0x0079A604
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060386BA RID: 231098 RVA: 0x0079C414 File Offset: 0x0079A614
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700EAC2 RID: 60098
		// (get) Token: 0x060386BB RID: 231099 RVA: 0x0079C424 File Offset: 0x0079A624
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

		// Token: 0x1700EAC3 RID: 60099
		// (get) Token: 0x060386BC RID: 231100 RVA: 0x0079C468 File Offset: 0x0079A668
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

		// Token: 0x060386BD RID: 231101 RVA: 0x0079C4C8 File Offset: 0x0079A6C8
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EAC4 RID: 60100
		// (get) Token: 0x060386BE RID: 231102 RVA: 0x0079C52C File Offset: 0x0079A72C
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

		// Token: 0x060386BF RID: 231103 RVA: 0x0079C558 File Offset: 0x0079A758
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EAC5 RID: 60101
		// (get) Token: 0x060386C0 RID: 231104 RVA: 0x0079C5BC File Offset: 0x0079A7BC
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

		// Token: 0x1700EAC6 RID: 60102
		// (get) Token: 0x060386C1 RID: 231105 RVA: 0x0079C5E8 File Offset: 0x0079A7E8
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

		// Token: 0x1700EAC7 RID: 60103
		// (get) Token: 0x060386C2 RID: 231106 RVA: 0x0079C648 File Offset: 0x0079A848
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

		// Token: 0x1700EAC8 RID: 60104
		// (get) Token: 0x060386C3 RID: 231107 RVA: 0x0079C6A8 File Offset: 0x0079A8A8
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

		// Token: 0x060386C4 RID: 231108 RVA: 0x0079C708 File Offset: 0x0079A908
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EAC9 RID: 60105
		// (get) Token: 0x060386C5 RID: 231109 RVA: 0x0079C76C File Offset: 0x0079A96C
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

		// Token: 0x060386C6 RID: 231110 RVA: 0x0079C798 File Offset: 0x0079A998
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EACA RID: 60106
		// (get) Token: 0x060386C7 RID: 231111 RVA: 0x0079C7FC File Offset: 0x0079A9FC
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

		// Token: 0x060386C8 RID: 231112 RVA: 0x0079C828 File Offset: 0x0079AA28
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EACB RID: 60107
		// (get) Token: 0x060386C9 RID: 231113 RVA: 0x0079C88C File Offset: 0x0079AA8C
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

		// Token: 0x060386CA RID: 231114 RVA: 0x0079C8B8 File Offset: 0x0079AAB8
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EACC RID: 60108
		// (get) Token: 0x060386CB RID: 231115 RVA: 0x0079C91C File Offset: 0x0079AB1C
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

		// Token: 0x060386CC RID: 231116 RVA: 0x0079C948 File Offset: 0x0079AB48
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EACD RID: 60109
		// (get) Token: 0x060386CD RID: 231117 RVA: 0x0079C9AC File Offset: 0x0079ABAC
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

		// Token: 0x1700EACE RID: 60110
		// (get) Token: 0x060386CE RID: 231118 RVA: 0x0079C9D8 File Offset: 0x0079ABD8
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

		// Token: 0x060386CF RID: 231119 RVA: 0x0079CA18 File Offset: 0x0079AC18
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060386D0 RID: 231120 RVA: 0x0079CA60 File Offset: 0x0079AC60
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x060386D1 RID: 231121 RVA: 0x0079CA7C File Offset: 0x0079AC7C
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x060386D2 RID: 231122 RVA: 0x0079CA98 File Offset: 0x0079AC98
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x060386D3 RID: 231123 RVA: 0x0079CAB4 File Offset: 0x0079ACB4
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700EACF RID: 60111
		// (get) Token: 0x060386D4 RID: 231124 RVA: 0x0079CAD0 File Offset: 0x0079ACD0
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

		// Token: 0x060386D5 RID: 231125 RVA: 0x0079CB10 File Offset: 0x0079AD10
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060386D6 RID: 231126 RVA: 0x0079CB58 File Offset: 0x0079AD58
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x060386D7 RID: 231127 RVA: 0x0079CB74 File Offset: 0x0079AD74
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x060386D8 RID: 231128 RVA: 0x0079CB90 File Offset: 0x0079AD90
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x060386D9 RID: 231129 RVA: 0x0079CBAC File Offset: 0x0079ADAC
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700EAD0 RID: 60112
		// (get) Token: 0x060386DA RID: 231130 RVA: 0x0079CBC8 File Offset: 0x0079ADC8
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

		// Token: 0x1700EAD1 RID: 60113
		// (get) Token: 0x060386DB RID: 231131 RVA: 0x0079CC28 File Offset: 0x0079AE28
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

		// Token: 0x060386DC RID: 231132 RVA: 0x0079CC68 File Offset: 0x0079AE68
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060386DD RID: 231133 RVA: 0x0079CCB0 File Offset: 0x0079AEB0
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x060386DE RID: 231134 RVA: 0x0079CCCC File Offset: 0x0079AECC
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x060386DF RID: 231135 RVA: 0x0079CCE8 File Offset: 0x0079AEE8
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x060386E0 RID: 231136 RVA: 0x0079CD04 File Offset: 0x0079AF04
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x060386E1 RID: 231137 RVA: 0x0079CD20 File Offset: 0x0079AF20
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700EAD2 RID: 60114
		// (get) Token: 0x060386E2 RID: 231138 RVA: 0x0079CD3C File Offset: 0x0079AF3C
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EAD3 RID: 60115
		// (get) Token: 0x060386E3 RID: 231139 RVA: 0x0079CD7C File Offset: 0x0079AF7C
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

		// Token: 0x1700EAD4 RID: 60116
		// (get) Token: 0x060386E4 RID: 231140 RVA: 0x0079CDDC File Offset: 0x0079AFDC
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

		// Token: 0x060386E5 RID: 231141 RVA: 0x0079CE3C File Offset: 0x0079B03C
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EAD5 RID: 60117
		// (get) Token: 0x060386E6 RID: 231142 RVA: 0x0079CEA0 File Offset: 0x0079B0A0
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

		// Token: 0x060386E7 RID: 231143 RVA: 0x0079CECC File Offset: 0x0079B0CC
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EAD6 RID: 60118
		// (get) Token: 0x060386E8 RID: 231144 RVA: 0x0079CF30 File Offset: 0x0079B130
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

		// Token: 0x060386E9 RID: 231145 RVA: 0x0079CF5C File Offset: 0x0079B15C
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EAD7 RID: 60119
		// (get) Token: 0x060386EA RID: 231146 RVA: 0x0079CF9C File Offset: 0x0079B19C
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

		// Token: 0x060386EB RID: 231147 RVA: 0x0079CFC8 File Offset: 0x0079B1C8
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x060386EC RID: 231148 RVA: 0x0079CFD8 File Offset: 0x0079B1D8
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

		// Token: 0x060386ED RID: 231149 RVA: 0x0079D044 File Offset: 0x0079B244
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700EAD8 RID: 60120
		// (get) Token: 0x060386EE RID: 231150 RVA: 0x0079D08C File Offset: 0x0079B28C
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

		// Token: 0x060386EF RID: 231151 RVA: 0x0079D0B8 File Offset: 0x0079B2B8
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EAD9 RID: 60121
		// (get) Token: 0x060386F0 RID: 231152 RVA: 0x0079D11C File Offset: 0x0079B31C
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

		// Token: 0x1700EADA RID: 60122
		// (get) Token: 0x060386F1 RID: 231153 RVA: 0x0079D148 File Offset: 0x0079B348
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

		// Token: 0x1700EADB RID: 60123
		// (get) Token: 0x060386F2 RID: 231154 RVA: 0x0079D188 File Offset: 0x0079B388
		public TVisualNovelOptionGroupConfig OptionGroupType
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return TVisualNovelOptionGroupConfig.NONE;
				}
				return (TVisualNovelOptionGroupConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060386F3 RID: 231155 RVA: 0x0079D1C8 File Offset: 0x0079B3C8
		public TTable? OptionGroup<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060386F4 RID: 231156 RVA: 0x0079D210 File Offset: 0x0079B410
		public IVisualNovelOptionGroupFullScreen OptionGroupAsIVisualNovelOptionGroupFullScreen()
		{
			return this.OptionGroup<IVisualNovelOptionGroupFullScreen>().Value;
		}

		// Token: 0x060386F5 RID: 231157 RVA: 0x0079D22C File Offset: 0x0079B42C
		public IVisualNovelOptionGroupNormal OptionGroupAsIVisualNovelOptionGroupNormal()
		{
			return this.OptionGroup<IVisualNovelOptionGroupNormal>().Value;
		}

		// Token: 0x1700EADC RID: 60124
		// (get) Token: 0x060386F6 RID: 231158 RVA: 0x0079D248 File Offset: 0x0079B448
		public TVisualNovelBackground VisualNovelBackgroundConfigType
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return TVisualNovelBackground.NONE;
				}
				return (TVisualNovelBackground)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060386F7 RID: 231159 RVA: 0x0079D288 File Offset: 0x0079B488
		public TTable? VisualNovelBackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060386F8 RID: 231160 RVA: 0x0079D2D0 File Offset: 0x0079B4D0
		public IVisualNovelBackgroundClean VisualNovelBackgroundConfigAsIVisualNovelBackgroundClean()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundClean>().Value;
		}

		// Token: 0x060386F9 RID: 231161 RVA: 0x0079D2EC File Offset: 0x0079B4EC
		public IVisualNovelBackgroundLoad VisualNovelBackgroundConfigAsIVisualNovelBackgroundLoad()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundLoad>().Value;
		}

		// Token: 0x1700EADD RID: 60125
		// (get) Token: 0x060386FA RID: 231162 RVA: 0x0079D308 File Offset: 0x0079B508
		public TVisualNovelCg CgConfigType
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return TVisualNovelCg.NONE;
				}
				return (TVisualNovelCg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060386FB RID: 231163 RVA: 0x0079D348 File Offset: 0x0079B548
		public TTable? CgConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(90);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060386FC RID: 231164 RVA: 0x0079D390 File Offset: 0x0079B590
		public IVisualNovelCgClean CgConfigAsIVisualNovelCgClean()
		{
			return this.CgConfig<IVisualNovelCgClean>().Value;
		}

		// Token: 0x060386FD RID: 231165 RVA: 0x0079D3AC File Offset: 0x0079B5AC
		public IVisualNovelCgLoadImage CgConfigAsIVisualNovelCgLoadImage()
		{
			return this.CgConfig<IVisualNovelCgLoadImage>().Value;
		}

		// Token: 0x060386FE RID: 231166 RVA: 0x0079D3C8 File Offset: 0x0079B5C8
		public IVisualNovelCgLoadPrefab CgConfigAsIVisualNovelCgLoadPrefab()
		{
			return this.CgConfig<IVisualNovelCgLoadPrefab>().Value;
		}

		// Token: 0x1700EADE RID: 60126
		// (get) Token: 0x060386FF RID: 231167 RVA: 0x0079D3E4 File Offset: 0x0079B5E4
		public TVisualNovelDisplayItem DisplayItemConfigType
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return TVisualNovelDisplayItem.NONE;
				}
				return (TVisualNovelDisplayItem)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038700 RID: 231168 RVA: 0x0079D424 File Offset: 0x0079B624
		public TTable? DisplayItemConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(94);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038701 RID: 231169 RVA: 0x0079D46C File Offset: 0x0079B66C
		public IVisualNovelDisplayItemClose DisplayItemConfigAsIVisualNovelDisplayItemClose()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemClose>().Value;
		}

		// Token: 0x06038702 RID: 231170 RVA: 0x0079D488 File Offset: 0x0079B688
		public IVisualNovelDisplayItemImage DisplayItemConfigAsIVisualNovelDisplayItemImage()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemImage>().Value;
		}

		// Token: 0x06038703 RID: 231171 RVA: 0x0079D4A4 File Offset: 0x0079B6A4
		public IVisualNovelDisplayItemPrefab DisplayItemConfigAsIVisualNovelDisplayItemPrefab()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemPrefab>().Value;
		}

		// Token: 0x1700EADF RID: 60127
		// (get) Token: 0x06038704 RID: 231172 RVA: 0x0079D4C0 File Offset: 0x0079B6C0
		public int PlotKeyId
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038705 RID: 231173 RVA: 0x0079D500 File Offset: 0x0079B700
		public TVisualNovelPerformance StartPerformancesType(int j)
		{
			int num = this.__p.__offset(98);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EAE0 RID: 60128
		// (get) Token: 0x06038706 RID: 231174 RVA: 0x0079D540 File Offset: 0x0079B740
		public int StartPerformancesTypeLength
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

		// Token: 0x06038707 RID: 231175 RVA: 0x0079D56C File Offset: 0x0079B76C
		public Span<TVisualNovelPerformance> GetStartPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(98, 1);
		}

		// Token: 0x06038708 RID: 231176 RVA: 0x0079D57C File Offset: 0x0079B77C
		public TVisualNovelPerformance[] GetStartPerformancesTypeArray()
		{
			int num = this.__p.__offset(98);
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

		// Token: 0x06038709 RID: 231177 RVA: 0x0079D5E8 File Offset: 0x0079B7E8
		public TTable? StartPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(100);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700EAE1 RID: 60129
		// (get) Token: 0x0603870A RID: 231178 RVA: 0x0079D630 File Offset: 0x0079B830
		public int StartPerformancesLength
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

		// Token: 0x0603870B RID: 231179 RVA: 0x0079D65C File Offset: 0x0079B85C
		public TVisualNovelPerformance EndPerformancesType(int j)
		{
			int num = this.__p.__offset(102);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EAE2 RID: 60130
		// (get) Token: 0x0603870C RID: 231180 RVA: 0x0079D69C File Offset: 0x0079B89C
		public int EndPerformancesTypeLength
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

		// Token: 0x0603870D RID: 231181 RVA: 0x0079D6C8 File Offset: 0x0079B8C8
		public Span<TVisualNovelPerformance> GetEndPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(102, 1);
		}

		// Token: 0x0603870E RID: 231182 RVA: 0x0079D6D8 File Offset: 0x0079B8D8
		public TVisualNovelPerformance[] GetEndPerformancesTypeArray()
		{
			int num = this.__p.__offset(102);
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

		// Token: 0x0603870F RID: 231183 RVA: 0x0079D744 File Offset: 0x0079B944
		public TTable? EndPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(104);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700EAE3 RID: 60131
		// (get) Token: 0x06038710 RID: 231184 RVA: 0x0079D78C File Offset: 0x0079B98C
		public int EndPerformancesLength
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700EAE4 RID: 60132
		// (get) Token: 0x06038711 RID: 231185 RVA: 0x0079D7B8 File Offset: 0x0079B9B8
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038712 RID: 231186 RVA: 0x0079D7F8 File Offset: 0x0079B9F8
		public static Offset<ITalkItemVisualNovelNoTextItem> CreateITalkItemVisualNovelNoTextItem(FlatBufferBuilder builder, ETalkItemType Type = ETalkItemType.Talk, int Id = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, int WhoId = 0, int TextId = 0, StringOffset TidTalkOffset = default(StringOffset), float WaitTime = 0f, Offset<ICaptionParam> CaptionParamsOffset = default(Offset<ICaptionParam>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), Offset<IPlayMontage> MontageOffset = default(Offset<IPlayMontage>), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>), Offset<ISetFlowTemplate> FlowTemplateOffset = default(Offset<ISetFlowTemplate>), VectorOffset FlowTemplateListOffset = default(VectorOffset), VectorOffset ActorMontageArrayOffset = default(VectorOffset), VectorOffset ActorFaceExpressionArrayOffset = default(VectorOffset), VectorOffset ActorLookAtArrayOffset = default(VectorOffset), VectorOffset ActorTurnToArrayOffset = default(VectorOffset), TPostAkEvent TalkAkEvent_type = TPostAkEvent.NONE, int TalkAkEventOffset = 0, TPostAkEvent TalkEndAkEvent_type = TPostAkEvent.NONE, int TalkEndAkEventOffset = 0, Offset<IUniversalTone> UniversalToneOffset = default(Offset<IUniversalTone>), TTalkBackground BackgroundConfig_type = TTalkBackground.NONE, int BackgroundConfigOffset = 0, bool PlayVoice = false, Offset<ITimeLimitOptionGroup> TimeLimitOptionGroupOffset = default(Offset<ITimeLimitOptionGroup>), Offset<IGamepadShakeInTalk> GamepadShakeOffset = default(Offset<IGamepadShakeInTalk>), VectorOffset IntroActionsOffset = default(VectorOffset), VectorOffset ActorFxEmoteArrayOffset = default(VectorOffset), VectorOffset TalkEffectArray_typeOffset = default(VectorOffset), VectorOffset TalkEffectArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), EVisualNovelOptionInteractionType OptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect, TVisualNovelOptionGroupConfig OptionGroup_type = TVisualNovelOptionGroupConfig.NONE, int OptionGroupOffset = 0, TVisualNovelBackground VisualNovelBackgroundConfig_type = TVisualNovelBackground.NONE, int VisualNovelBackgroundConfigOffset = 0, TVisualNovelCg CgConfig_type = TVisualNovelCg.NONE, int CgConfigOffset = 0, TVisualNovelDisplayItem DisplayItemConfig_type = TVisualNovelDisplayItem.NONE, int DisplayItemConfigOffset = 0, int PlotKeyId = 0, VectorOffset StartPerformances_typeOffset = default(VectorOffset), VectorOffset StartPerformancesOffset = default(VectorOffset), VectorOffset EndPerformances_typeOffset = default(VectorOffset), VectorOffset EndPerformancesOffset = default(VectorOffset), uint NullMask = 0U)
		{
			builder.StartTable(52);
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
			ITalkItemVisualNovelNoTextItem.AddOptionGroupType(builder, OptionGroup_type);
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

		// Token: 0x06038713 RID: 231187 RVA: 0x0079D9B0 File Offset: 0x0079BBB0
		public static void StartITalkItemVisualNovelNoTextItem(FlatBufferBuilder builder)
		{
			builder.StartTable(52);
		}

		// Token: 0x06038714 RID: 231188 RVA: 0x0079D9BA File Offset: 0x0079BBBA
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038715 RID: 231189 RVA: 0x0079D9C5 File Offset: 0x0079BBC5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06038716 RID: 231190 RVA: 0x0079D9D0 File Offset: 0x0079BBD0
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x06038717 RID: 231191 RVA: 0x0079D9DB File Offset: 0x0079BBDB
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06038718 RID: 231192 RVA: 0x0079D9EB File Offset: 0x0079BBEB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x06038719 RID: 231193 RVA: 0x0079D9FB File Offset: 0x0079BBFB
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x0603871A RID: 231194 RVA: 0x0079DA06 File Offset: 0x0079BC06
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x0603871B RID: 231195 RVA: 0x0079DA11 File Offset: 0x0079BC11
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x0603871C RID: 231196 RVA: 0x0079DA1C File Offset: 0x0079BC1C
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x0603871D RID: 231197 RVA: 0x0079DA27 File Offset: 0x0079BC27
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x0603871E RID: 231198 RVA: 0x0079DA38 File Offset: 0x0079BC38
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x0603871F RID: 231199 RVA: 0x0079DA4C File Offset: 0x0079BC4C
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x06038720 RID: 231200 RVA: 0x0079DA5D File Offset: 0x0079BC5D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x06038721 RID: 231201 RVA: 0x0079DA70 File Offset: 0x0079BC70
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038722 RID: 231202 RVA: 0x0079DAB0 File Offset: 0x0079BCB0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038723 RID: 231203 RVA: 0x0079DACA File Offset: 0x0079BCCA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038724 RID: 231204 RVA: 0x0079DAE8 File Offset: 0x0079BCE8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038725 RID: 231205 RVA: 0x0079DB01 File Offset: 0x0079BD01
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038726 RID: 231206 RVA: 0x0079DB0C File Offset: 0x0079BD0C
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x06038727 RID: 231207 RVA: 0x0079DB20 File Offset: 0x0079BD20
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038728 RID: 231208 RVA: 0x0079DB60 File Offset: 0x0079BD60
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038729 RID: 231209 RVA: 0x0079DB7A File Offset: 0x0079BD7A
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603872A RID: 231210 RVA: 0x0079DB98 File Offset: 0x0079BD98
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603872B RID: 231211 RVA: 0x0079DBB1 File Offset: 0x0079BDB1
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603872C RID: 231212 RVA: 0x0079DBBC File Offset: 0x0079BDBC
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x0603872D RID: 231213 RVA: 0x0079DBCD File Offset: 0x0079BDCD
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x0603872E RID: 231214 RVA: 0x0079DBDE File Offset: 0x0079BDDE
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x0603872F RID: 231215 RVA: 0x0079DBEF File Offset: 0x0079BDEF
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x06038730 RID: 231216 RVA: 0x0079DC00 File Offset: 0x0079BE00
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038731 RID: 231217 RVA: 0x0079DC40 File Offset: 0x0079BE40
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038732 RID: 231218 RVA: 0x0079DC5A File Offset: 0x0079BE5A
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038733 RID: 231219 RVA: 0x0079DC78 File Offset: 0x0079BE78
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038734 RID: 231220 RVA: 0x0079DC91 File Offset: 0x0079BE91
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038735 RID: 231221 RVA: 0x0079DC9C File Offset: 0x0079BE9C
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x06038736 RID: 231222 RVA: 0x0079DCB0 File Offset: 0x0079BEB0
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038737 RID: 231223 RVA: 0x0079DCF0 File Offset: 0x0079BEF0
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038738 RID: 231224 RVA: 0x0079DD0A File Offset: 0x0079BF0A
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038739 RID: 231225 RVA: 0x0079DD28 File Offset: 0x0079BF28
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603873A RID: 231226 RVA: 0x0079DD41 File Offset: 0x0079BF41
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603873B RID: 231227 RVA: 0x0079DD4C File Offset: 0x0079BF4C
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x0603873C RID: 231228 RVA: 0x0079DD60 File Offset: 0x0079BF60
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603873D RID: 231229 RVA: 0x0079DDA0 File Offset: 0x0079BFA0
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603873E RID: 231230 RVA: 0x0079DDBA File Offset: 0x0079BFBA
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603873F RID: 231231 RVA: 0x0079DDD8 File Offset: 0x0079BFD8
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038740 RID: 231232 RVA: 0x0079DDF1 File Offset: 0x0079BFF1
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038741 RID: 231233 RVA: 0x0079DDFC File Offset: 0x0079BFFC
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x06038742 RID: 231234 RVA: 0x0079DE10 File Offset: 0x0079C010
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038743 RID: 231235 RVA: 0x0079DE50 File Offset: 0x0079C050
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038744 RID: 231236 RVA: 0x0079DE6A File Offset: 0x0079C06A
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038745 RID: 231237 RVA: 0x0079DE88 File Offset: 0x0079C088
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038746 RID: 231238 RVA: 0x0079DEA1 File Offset: 0x0079C0A1
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038747 RID: 231239 RVA: 0x0079DEAC File Offset: 0x0079C0AC
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x06038748 RID: 231240 RVA: 0x0079DEC0 File Offset: 0x0079C0C0
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038749 RID: 231241 RVA: 0x0079DF00 File Offset: 0x0079C100
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603874A RID: 231242 RVA: 0x0079DF1A File Offset: 0x0079C11A
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603874B RID: 231243 RVA: 0x0079DF38 File Offset: 0x0079C138
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603874C RID: 231244 RVA: 0x0079DF51 File Offset: 0x0079C151
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603874D RID: 231245 RVA: 0x0079DF5C File Offset: 0x0079C15C
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x0603874E RID: 231246 RVA: 0x0079DF68 File Offset: 0x0079C168
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x0603874F RID: 231247 RVA: 0x0079DF74 File Offset: 0x0079C174
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x06038750 RID: 231248 RVA: 0x0079DF80 File Offset: 0x0079C180
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x06038751 RID: 231249 RVA: 0x0079DF8C File Offset: 0x0079C18C
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x06038752 RID: 231250 RVA: 0x0079DF9D File Offset: 0x0079C19D
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x06038753 RID: 231251 RVA: 0x0079DFA9 File Offset: 0x0079C1A9
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x06038754 RID: 231252 RVA: 0x0079DFB5 File Offset: 0x0079C1B5
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x06038755 RID: 231253 RVA: 0x0079DFC1 File Offset: 0x0079C1C1
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x06038756 RID: 231254 RVA: 0x0079DFD2 File Offset: 0x0079C1D2
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x06038757 RID: 231255 RVA: 0x0079DFE3 File Offset: 0x0079C1E3
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x06038758 RID: 231256 RVA: 0x0079DFF4 File Offset: 0x0079C1F4
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038759 RID: 231257 RVA: 0x0079E034 File Offset: 0x0079C234
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603875A RID: 231258 RVA: 0x0079E04E File Offset: 0x0079C24E
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603875B RID: 231259 RVA: 0x0079E06C File Offset: 0x0079C26C
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603875C RID: 231260 RVA: 0x0079E085 File Offset: 0x0079C285
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603875D RID: 231261 RVA: 0x0079E090 File Offset: 0x0079C290
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x0603875E RID: 231262 RVA: 0x0079E0A4 File Offset: 0x0079C2A4
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603875F RID: 231263 RVA: 0x0079E0E4 File Offset: 0x0079C2E4
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038760 RID: 231264 RVA: 0x0079E0FE File Offset: 0x0079C2FE
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038761 RID: 231265 RVA: 0x0079E11C File Offset: 0x0079C31C
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038762 RID: 231266 RVA: 0x0079E135 File Offset: 0x0079C335
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038763 RID: 231267 RVA: 0x0079E140 File Offset: 0x0079C340
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x06038764 RID: 231268 RVA: 0x0079E154 File Offset: 0x0079C354
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038765 RID: 231269 RVA: 0x0079E18B File Offset: 0x0079C38B
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06038766 RID: 231270 RVA: 0x0079E1A5 File Offset: 0x0079C3A5
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06038767 RID: 231271 RVA: 0x0079E1C3 File Offset: 0x0079C3C3
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038768 RID: 231272 RVA: 0x0079E1DC File Offset: 0x0079C3DC
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06038769 RID: 231273 RVA: 0x0079E1E7 File Offset: 0x0079C3E7
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x0603876A RID: 231274 RVA: 0x0079E1F8 File Offset: 0x0079C3F8
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603876B RID: 231275 RVA: 0x0079E22F File Offset: 0x0079C42F
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603876C RID: 231276 RVA: 0x0079E249 File Offset: 0x0079C449
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603876D RID: 231277 RVA: 0x0079E267 File Offset: 0x0079C467
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603876E RID: 231278 RVA: 0x0079E280 File Offset: 0x0079C480
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603876F RID: 231279 RVA: 0x0079E28B File Offset: 0x0079C48B
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x06038770 RID: 231280 RVA: 0x0079E29C File Offset: 0x0079C49C
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038771 RID: 231281 RVA: 0x0079E2DC File Offset: 0x0079C4DC
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038772 RID: 231282 RVA: 0x0079E2F6 File Offset: 0x0079C4F6
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038773 RID: 231283 RVA: 0x0079E314 File Offset: 0x0079C514
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038774 RID: 231284 RVA: 0x0079E32D File Offset: 0x0079C52D
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038775 RID: 231285 RVA: 0x0079E338 File Offset: 0x0079C538
		public static void AddOptionInteractionType(FlatBufferBuilder builder, EVisualNovelOptionInteractionType optionInteractionType)
		{
			builder.AddByte(37, (byte)optionInteractionType, 0);
		}

		// Token: 0x06038776 RID: 231286 RVA: 0x0079E344 File Offset: 0x0079C544
		public static void AddOptionGroupType(FlatBufferBuilder builder, TVisualNovelOptionGroupConfig optionGroupType)
		{
			builder.AddByte(38, (byte)optionGroupType, 0);
		}

		// Token: 0x06038777 RID: 231287 RVA: 0x0079E350 File Offset: 0x0079C550
		public static void AddOptionGroup(FlatBufferBuilder builder, int optionGroupOffset)
		{
			builder.AddOffset(39, optionGroupOffset, 0);
		}

		// Token: 0x06038778 RID: 231288 RVA: 0x0079E35C File Offset: 0x0079C55C
		public static void AddVisualNovelBackgroundConfigType(FlatBufferBuilder builder, TVisualNovelBackground visualNovelBackgroundConfigType)
		{
			builder.AddByte(40, (byte)visualNovelBackgroundConfigType, 0);
		}

		// Token: 0x06038779 RID: 231289 RVA: 0x0079E368 File Offset: 0x0079C568
		public static void AddVisualNovelBackgroundConfig(FlatBufferBuilder builder, int visualNovelBackgroundConfigOffset)
		{
			builder.AddOffset(41, visualNovelBackgroundConfigOffset, 0);
		}

		// Token: 0x0603877A RID: 231290 RVA: 0x0079E374 File Offset: 0x0079C574
		public static void AddCgConfigType(FlatBufferBuilder builder, TVisualNovelCg cgConfigType)
		{
			builder.AddByte(42, (byte)cgConfigType, 0);
		}

		// Token: 0x0603877B RID: 231291 RVA: 0x0079E380 File Offset: 0x0079C580
		public static void AddCgConfig(FlatBufferBuilder builder, int cgConfigOffset)
		{
			builder.AddOffset(43, cgConfigOffset, 0);
		}

		// Token: 0x0603877C RID: 231292 RVA: 0x0079E38C File Offset: 0x0079C58C
		public static void AddDisplayItemConfigType(FlatBufferBuilder builder, TVisualNovelDisplayItem displayItemConfigType)
		{
			builder.AddByte(44, (byte)displayItemConfigType, 0);
		}

		// Token: 0x0603877D RID: 231293 RVA: 0x0079E398 File Offset: 0x0079C598
		public static void AddDisplayItemConfig(FlatBufferBuilder builder, int displayItemConfigOffset)
		{
			builder.AddOffset(45, displayItemConfigOffset, 0);
		}

		// Token: 0x0603877E RID: 231294 RVA: 0x0079E3A4 File Offset: 0x0079C5A4
		public static void AddPlotKeyId(FlatBufferBuilder builder, int plotKeyId)
		{
			builder.AddInt(46, plotKeyId, 0);
		}

		// Token: 0x0603877F RID: 231295 RVA: 0x0079E3B0 File Offset: 0x0079C5B0
		public static void AddStartPerformancesType(FlatBufferBuilder builder, VectorOffset startPerformancesTypeOffset)
		{
			builder.AddOffset(47, startPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x06038780 RID: 231296 RVA: 0x0079E3C4 File Offset: 0x0079C5C4
		public static VectorOffset CreateStartPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038781 RID: 231297 RVA: 0x0079E3FB File Offset: 0x0079C5FB
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06038782 RID: 231298 RVA: 0x0079E415 File Offset: 0x0079C615
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06038783 RID: 231299 RVA: 0x0079E433 File Offset: 0x0079C633
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038784 RID: 231300 RVA: 0x0079E44C File Offset: 0x0079C64C
		public static void StartStartPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06038785 RID: 231301 RVA: 0x0079E457 File Offset: 0x0079C657
		public static void AddStartPerformances(FlatBufferBuilder builder, VectorOffset startPerformancesOffset)
		{
			builder.AddOffset(48, startPerformancesOffset.Value, 0);
		}

		// Token: 0x06038786 RID: 231302 RVA: 0x0079E468 File Offset: 0x0079C668
		public static VectorOffset CreateStartPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038787 RID: 231303 RVA: 0x0079E49F File Offset: 0x0079C69F
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038788 RID: 231304 RVA: 0x0079E4B9 File Offset: 0x0079C6B9
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038789 RID: 231305 RVA: 0x0079E4D7 File Offset: 0x0079C6D7
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603878A RID: 231306 RVA: 0x0079E4F0 File Offset: 0x0079C6F0
		public static void StartStartPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603878B RID: 231307 RVA: 0x0079E4FB File Offset: 0x0079C6FB
		public static void AddEndPerformancesType(FlatBufferBuilder builder, VectorOffset endPerformancesTypeOffset)
		{
			builder.AddOffset(49, endPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x0603878C RID: 231308 RVA: 0x0079E50C File Offset: 0x0079C70C
		public static VectorOffset CreateEndPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603878D RID: 231309 RVA: 0x0079E543 File Offset: 0x0079C743
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x0603878E RID: 231310 RVA: 0x0079E55D File Offset: 0x0079C75D
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x0603878F RID: 231311 RVA: 0x0079E57B File Offset: 0x0079C77B
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038790 RID: 231312 RVA: 0x0079E594 File Offset: 0x0079C794
		public static void StartEndPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06038791 RID: 231313 RVA: 0x0079E59F File Offset: 0x0079C79F
		public static void AddEndPerformances(FlatBufferBuilder builder, VectorOffset endPerformancesOffset)
		{
			builder.AddOffset(50, endPerformancesOffset.Value, 0);
		}

		// Token: 0x06038792 RID: 231314 RVA: 0x0079E5B0 File Offset: 0x0079C7B0
		public static VectorOffset CreateEndPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038793 RID: 231315 RVA: 0x0079E5E7 File Offset: 0x0079C7E7
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038794 RID: 231316 RVA: 0x0079E601 File Offset: 0x0079C801
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038795 RID: 231317 RVA: 0x0079E61F File Offset: 0x0079C81F
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038796 RID: 231318 RVA: 0x0079E638 File Offset: 0x0079C838
		public static void StartEndPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038797 RID: 231319 RVA: 0x0079E643 File Offset: 0x0079C843
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(51, nullMask, 0U);
		}

		// Token: 0x06038798 RID: 231320 RVA: 0x0079E64F File Offset: 0x0079C84F
		public static Offset<ITalkItemVisualNovelNoTextItem> EndITalkItemVisualNovelNoTextItem(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemVisualNovelNoTextItem>(builder.EndTable());
		}

		// Token: 0x06038799 RID: 231321 RVA: 0x0079E65C File Offset: 0x0079C85C
		public ITalkItemVisualNovelNoTextItemT UnPack()
		{
			ITalkItemVisualNovelNoTextItemT talkItemVisualNovelNoTextItemT = new ITalkItemVisualNovelNoTextItemT();
			this.UnPackTo(talkItemVisualNovelNoTextItemT);
			return talkItemVisualNovelNoTextItemT;
		}

		// Token: 0x0603879A RID: 231322 RVA: 0x0079E678 File Offset: 0x0079C878
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
			_o.OptionGroup = new TVisualNovelOptionGroupConfigUnion();
			_o.OptionGroup.Type = this.OptionGroupType;
			TVisualNovelOptionGroupConfig optionGroupType = this.OptionGroupType;
			if (optionGroupType != TVisualNovelOptionGroupConfig.IVisualNovelOptionGroupFullScreen)
			{
				if (optionGroupType == TVisualNovelOptionGroupConfig.IVisualNovelOptionGroupNormal)
				{
					_o.OptionGroup.Value = ((this.OptionGroup<IVisualNovelOptionGroupNormal>() != null) ? this.OptionGroup<IVisualNovelOptionGroupNormal>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.OptionGroup.Value = ((this.OptionGroup<IVisualNovelOptionGroupFullScreen>() != null) ? this.OptionGroup<IVisualNovelOptionGroupFullScreen>().Value.UnPack() : null);
			}
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
			case TVisualNovelCg.IVisualNovelCgLoadPrefab:
				_o.CgConfig.Value = ((this.CgConfig<IVisualNovelCgLoadPrefab>() != null) ? this.CgConfig<IVisualNovelCgLoadPrefab>().Value.UnPack() : null);
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
				}
				_o.EndPerformances.Add(tvisualNovelPerformanceUnion2);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603879B RID: 231323 RVA: 0x0079FC58 File Offset: 0x0079DE58
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
			TVisualNovelOptionGroupConfig optionGroup_type = (_o.OptionGroup == null) ? TVisualNovelOptionGroupConfig.NONE : _o.OptionGroup.Type;
			int optionGroupOffset = (_o.OptionGroup == null) ? 0 : TVisualNovelOptionGroupConfigUnion.Pack(builder, _o.OptionGroup);
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
			return ITalkItemVisualNovelNoTextItem.CreateITalkItemVisualNovelNoTextItem(builder, _o.Type, _o.Id, _o.PlotLineId, plotLineKeyOffset, nameOffset, _o._Folded, _o._EditFlag, _o.WhoId, _o.TextId, tidTalkOffset, _o.WaitTime, captionParamsOffset, actionsOffset, optionsOffset, montageOffset, cameraDataOffset, flowTemplateOffset, flowTemplateListOffset, actorMontageArrayOffset, actorFaceExpressionArrayOffset, actorLookAtArrayOffset, actorTurnToArrayOffset, talkAkEvent_type, talkAkEventOffset, talkEndAkEvent_type, talkEndAkEventOffset, universalToneOffset, backgroundConfig_type, backgroundConfigOffset, _o.PlayVoice, timeLimitOptionGroupOffset, gamepadShakeOffset, introActionsOffset, actorFxEmoteArrayOffset, talkEffectArray_typeOffset, talkEffectArrayOffset, actorVisibilityArrayOffset, _o.OptionInteractionType, optionGroup_type, optionGroupOffset, visualNovelBackgroundConfig_type, visualNovelBackgroundConfigOffset, cgConfig_type, cgConfigOffset, displayItemConfig_type, displayItemConfigOffset, _o.PlotKeyId, startPerformances_typeOffset, startPerformancesOffset, endPerformances_typeOffset, endPerformancesOffset, _o.NullMask);
		}

		// Token: 0x04013067 RID: 77927
		private Table __p;
	}
}
