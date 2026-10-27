using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007310 RID: 29456
	public struct ITalkItemVisualNovelNarration : IFlatbufferObject
	{
		// Token: 0x1700DE5D RID: 56925
		// (get) Token: 0x06035229 RID: 217641 RVA: 0x00735817 File Offset: 0x00733A17
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603522A RID: 217642 RVA: 0x00735824 File Offset: 0x00733A24
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603522B RID: 217643 RVA: 0x0073582C File Offset: 0x00733A2C
		public static ITalkItemVisualNovelNarration GetRootAsITalkItemVisualNovelNarration(ByteBuffer _bb)
		{
			return ITalkItemVisualNovelNarration.GetRootAsITalkItemVisualNovelNarration(_bb, default(ITalkItemVisualNovelNarration));
		}

		// Token: 0x0603522C RID: 217644 RVA: 0x00735848 File Offset: 0x00733A48
		public static ITalkItemVisualNovelNarration GetRootAsITalkItemVisualNovelNarration(ByteBuffer _bb, ITalkItemVisualNovelNarration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603522D RID: 217645 RVA: 0x00735865 File Offset: 0x00733A65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603522E RID: 217646 RVA: 0x00735874 File Offset: 0x00733A74
		public ITalkItemVisualNovelNarration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE5E RID: 56926
		// (get) Token: 0x0603522F RID: 217647 RVA: 0x00735884 File Offset: 0x00733A84
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

		// Token: 0x1700DE5F RID: 56927
		// (get) Token: 0x06035230 RID: 217648 RVA: 0x007358C0 File Offset: 0x00733AC0
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

		// Token: 0x1700DE60 RID: 56928
		// (get) Token: 0x06035231 RID: 217649 RVA: 0x007358FC File Offset: 0x00733AFC
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

		// Token: 0x1700DE61 RID: 56929
		// (get) Token: 0x06035232 RID: 217650 RVA: 0x00735938 File Offset: 0x00733B38
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

		// Token: 0x06035233 RID: 217651 RVA: 0x00735970 File Offset: 0x00733B70
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06035234 RID: 217652 RVA: 0x00735980 File Offset: 0x00733B80
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DE62 RID: 56930
		// (get) Token: 0x06035235 RID: 217653 RVA: 0x00735990 File Offset: 0x00733B90
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

		// Token: 0x06035236 RID: 217654 RVA: 0x007359C8 File Offset: 0x00733BC8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06035237 RID: 217655 RVA: 0x007359D8 File Offset: 0x00733BD8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700DE63 RID: 56931
		// (get) Token: 0x06035238 RID: 217656 RVA: 0x007359E8 File Offset: 0x00733BE8
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DE64 RID: 56932
		// (get) Token: 0x06035239 RID: 217657 RVA: 0x00735A28 File Offset: 0x00733C28
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

		// Token: 0x1700DE65 RID: 56933
		// (get) Token: 0x0603523A RID: 217658 RVA: 0x00735A68 File Offset: 0x00733C68
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

		// Token: 0x1700DE66 RID: 56934
		// (get) Token: 0x0603523B RID: 217659 RVA: 0x00735AA8 File Offset: 0x00733CA8
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

		// Token: 0x1700DE67 RID: 56935
		// (get) Token: 0x0603523C RID: 217660 RVA: 0x00735AE8 File Offset: 0x00733CE8
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

		// Token: 0x0603523D RID: 217661 RVA: 0x00735B20 File Offset: 0x00733D20
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0603523E RID: 217662 RVA: 0x00735B30 File Offset: 0x00733D30
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700DE68 RID: 56936
		// (get) Token: 0x0603523F RID: 217663 RVA: 0x00735B40 File Offset: 0x00733D40
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

		// Token: 0x1700DE69 RID: 56937
		// (get) Token: 0x06035240 RID: 217664 RVA: 0x00735B84 File Offset: 0x00733D84
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

		// Token: 0x06035241 RID: 217665 RVA: 0x00735BE4 File Offset: 0x00733DE4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE6A RID: 56938
		// (get) Token: 0x06035242 RID: 217666 RVA: 0x00735C48 File Offset: 0x00733E48
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

		// Token: 0x06035243 RID: 217667 RVA: 0x00735C74 File Offset: 0x00733E74
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE6B RID: 56939
		// (get) Token: 0x06035244 RID: 217668 RVA: 0x00735CD8 File Offset: 0x00733ED8
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

		// Token: 0x1700DE6C RID: 56940
		// (get) Token: 0x06035245 RID: 217669 RVA: 0x00735D04 File Offset: 0x00733F04
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

		// Token: 0x1700DE6D RID: 56941
		// (get) Token: 0x06035246 RID: 217670 RVA: 0x00735D64 File Offset: 0x00733F64
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

		// Token: 0x1700DE6E RID: 56942
		// (get) Token: 0x06035247 RID: 217671 RVA: 0x00735DC4 File Offset: 0x00733FC4
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

		// Token: 0x06035248 RID: 217672 RVA: 0x00735E24 File Offset: 0x00734024
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE6F RID: 56943
		// (get) Token: 0x06035249 RID: 217673 RVA: 0x00735E88 File Offset: 0x00734088
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

		// Token: 0x0603524A RID: 217674 RVA: 0x00735EB4 File Offset: 0x007340B4
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE70 RID: 56944
		// (get) Token: 0x0603524B RID: 217675 RVA: 0x00735F18 File Offset: 0x00734118
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

		// Token: 0x0603524C RID: 217676 RVA: 0x00735F44 File Offset: 0x00734144
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE71 RID: 56945
		// (get) Token: 0x0603524D RID: 217677 RVA: 0x00735FA8 File Offset: 0x007341A8
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

		// Token: 0x0603524E RID: 217678 RVA: 0x00735FD4 File Offset: 0x007341D4
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE72 RID: 56946
		// (get) Token: 0x0603524F RID: 217679 RVA: 0x00736038 File Offset: 0x00734238
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

		// Token: 0x06035250 RID: 217680 RVA: 0x00736064 File Offset: 0x00734264
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE73 RID: 56947
		// (get) Token: 0x06035251 RID: 217681 RVA: 0x007360C8 File Offset: 0x007342C8
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

		// Token: 0x1700DE74 RID: 56948
		// (get) Token: 0x06035252 RID: 217682 RVA: 0x007360F4 File Offset: 0x007342F4
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

		// Token: 0x06035253 RID: 217683 RVA: 0x00736134 File Offset: 0x00734334
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035254 RID: 217684 RVA: 0x0073617C File Offset: 0x0073437C
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06035255 RID: 217685 RVA: 0x00736198 File Offset: 0x00734398
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x06035256 RID: 217686 RVA: 0x007361B4 File Offset: 0x007343B4
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06035257 RID: 217687 RVA: 0x007361D0 File Offset: 0x007343D0
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DE75 RID: 56949
		// (get) Token: 0x06035258 RID: 217688 RVA: 0x007361EC File Offset: 0x007343EC
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

		// Token: 0x06035259 RID: 217689 RVA: 0x0073622C File Offset: 0x0073442C
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603525A RID: 217690 RVA: 0x00736274 File Offset: 0x00734474
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x0603525B RID: 217691 RVA: 0x00736290 File Offset: 0x00734490
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x0603525C RID: 217692 RVA: 0x007362AC File Offset: 0x007344AC
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x0603525D RID: 217693 RVA: 0x007362C8 File Offset: 0x007344C8
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DE76 RID: 56950
		// (get) Token: 0x0603525E RID: 217694 RVA: 0x007362E4 File Offset: 0x007344E4
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

		// Token: 0x1700DE77 RID: 56951
		// (get) Token: 0x0603525F RID: 217695 RVA: 0x00736344 File Offset: 0x00734544
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

		// Token: 0x06035260 RID: 217696 RVA: 0x00736384 File Offset: 0x00734584
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035261 RID: 217697 RVA: 0x007363CC File Offset: 0x007345CC
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x06035262 RID: 217698 RVA: 0x007363E8 File Offset: 0x007345E8
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x06035263 RID: 217699 RVA: 0x00736404 File Offset: 0x00734604
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x06035264 RID: 217700 RVA: 0x00736420 File Offset: 0x00734620
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x06035265 RID: 217701 RVA: 0x0073643C File Offset: 0x0073463C
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700DE78 RID: 56952
		// (get) Token: 0x06035266 RID: 217702 RVA: 0x00736458 File Offset: 0x00734658
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DE79 RID: 56953
		// (get) Token: 0x06035267 RID: 217703 RVA: 0x00736498 File Offset: 0x00734698
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

		// Token: 0x1700DE7A RID: 56954
		// (get) Token: 0x06035268 RID: 217704 RVA: 0x007364F8 File Offset: 0x007346F8
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

		// Token: 0x06035269 RID: 217705 RVA: 0x00736558 File Offset: 0x00734758
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE7B RID: 56955
		// (get) Token: 0x0603526A RID: 217706 RVA: 0x007365BC File Offset: 0x007347BC
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

		// Token: 0x0603526B RID: 217707 RVA: 0x007365E8 File Offset: 0x007347E8
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE7C RID: 56956
		// (get) Token: 0x0603526C RID: 217708 RVA: 0x0073664C File Offset: 0x0073484C
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

		// Token: 0x0603526D RID: 217709 RVA: 0x00736678 File Offset: 0x00734878
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DE7D RID: 56957
		// (get) Token: 0x0603526E RID: 217710 RVA: 0x007366B8 File Offset: 0x007348B8
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

		// Token: 0x0603526F RID: 217711 RVA: 0x007366E4 File Offset: 0x007348E4
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x06035270 RID: 217712 RVA: 0x007366F4 File Offset: 0x007348F4
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

		// Token: 0x06035271 RID: 217713 RVA: 0x00736760 File Offset: 0x00734960
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DE7E RID: 56958
		// (get) Token: 0x06035272 RID: 217714 RVA: 0x007367A8 File Offset: 0x007349A8
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

		// Token: 0x06035273 RID: 217715 RVA: 0x007367D4 File Offset: 0x007349D4
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DE7F RID: 56959
		// (get) Token: 0x06035274 RID: 217716 RVA: 0x00736838 File Offset: 0x00734A38
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

		// Token: 0x1700DE80 RID: 56960
		// (get) Token: 0x06035275 RID: 217717 RVA: 0x00736864 File Offset: 0x00734A64
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

		// Token: 0x1700DE81 RID: 56961
		// (get) Token: 0x06035276 RID: 217718 RVA: 0x007368A4 File Offset: 0x00734AA4
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

		// Token: 0x1700DE82 RID: 56962
		// (get) Token: 0x06035277 RID: 217719 RVA: 0x00736904 File Offset: 0x00734B04
		public float DialogDelay
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DE83 RID: 56963
		// (get) Token: 0x06035278 RID: 217720 RVA: 0x00736948 File Offset: 0x00734B48
		public bool ClickShowFull
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DE84 RID: 56964
		// (get) Token: 0x06035279 RID: 217721 RVA: 0x00736988 File Offset: 0x00734B88
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

		// Token: 0x0603527A RID: 217722 RVA: 0x007369C8 File Offset: 0x00734BC8
		public TTable? VisualNovelBackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(88);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603527B RID: 217723 RVA: 0x00736A10 File Offset: 0x00734C10
		public IVisualNovelBackgroundClean VisualNovelBackgroundConfigAsIVisualNovelBackgroundClean()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundClean>().Value;
		}

		// Token: 0x0603527C RID: 217724 RVA: 0x00736A2C File Offset: 0x00734C2C
		public IVisualNovelBackgroundLoad VisualNovelBackgroundConfigAsIVisualNovelBackgroundLoad()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundLoad>().Value;
		}

		// Token: 0x1700DE85 RID: 56965
		// (get) Token: 0x0603527D RID: 217725 RVA: 0x00736A48 File Offset: 0x00734C48
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

		// Token: 0x0603527E RID: 217726 RVA: 0x00736A88 File Offset: 0x00734C88
		public TTable? CgConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603527F RID: 217727 RVA: 0x00736AD0 File Offset: 0x00734CD0
		public IVisualNovelCgClean CgConfigAsIVisualNovelCgClean()
		{
			return this.CgConfig<IVisualNovelCgClean>().Value;
		}

		// Token: 0x06035280 RID: 217728 RVA: 0x00736AEC File Offset: 0x00734CEC
		public IVisualNovelCgLoadImage CgConfigAsIVisualNovelCgLoadImage()
		{
			return this.CgConfig<IVisualNovelCgLoadImage>().Value;
		}

		// Token: 0x06035281 RID: 217729 RVA: 0x00736B08 File Offset: 0x00734D08
		public IVisualNovelCgLoadSpine CgConfigAsIVisualNovelCgLoadSpine()
		{
			return this.CgConfig<IVisualNovelCgLoadSpine>().Value;
		}

		// Token: 0x1700DE86 RID: 56966
		// (get) Token: 0x06035282 RID: 217730 RVA: 0x00736B24 File Offset: 0x00734D24
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

		// Token: 0x06035283 RID: 217731 RVA: 0x00736B64 File Offset: 0x00734D64
		public TTable? DisplayItemConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(96);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035284 RID: 217732 RVA: 0x00736BAC File Offset: 0x00734DAC
		public IVisualNovelDisplayItemClose DisplayItemConfigAsIVisualNovelDisplayItemClose()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemClose>().Value;
		}

		// Token: 0x06035285 RID: 217733 RVA: 0x00736BC8 File Offset: 0x00734DC8
		public IVisualNovelDisplayItemImage DisplayItemConfigAsIVisualNovelDisplayItemImage()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemImage>().Value;
		}

		// Token: 0x06035286 RID: 217734 RVA: 0x00736BE4 File Offset: 0x00734DE4
		public IVisualNovelDisplayItemPrefab DisplayItemConfigAsIVisualNovelDisplayItemPrefab()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemPrefab>().Value;
		}

		// Token: 0x1700DE87 RID: 56967
		// (get) Token: 0x06035287 RID: 217735 RVA: 0x00736C00 File Offset: 0x00734E00
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

		// Token: 0x06035288 RID: 217736 RVA: 0x00736C40 File Offset: 0x00734E40
		public TVisualNovelPerformance StartPerformancesType(int j)
		{
			int num = this.__p.__offset(100);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DE88 RID: 56968
		// (get) Token: 0x06035289 RID: 217737 RVA: 0x00736C80 File Offset: 0x00734E80
		public int StartPerformancesTypeLength
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

		// Token: 0x0603528A RID: 217738 RVA: 0x00736CAC File Offset: 0x00734EAC
		public Span<TVisualNovelPerformance> GetStartPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(100, 1);
		}

		// Token: 0x0603528B RID: 217739 RVA: 0x00736CBC File Offset: 0x00734EBC
		public TVisualNovelPerformance[] GetStartPerformancesTypeArray()
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

		// Token: 0x0603528C RID: 217740 RVA: 0x00736D28 File Offset: 0x00734F28
		public TTable? StartPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(102);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DE89 RID: 56969
		// (get) Token: 0x0603528D RID: 217741 RVA: 0x00736D70 File Offset: 0x00734F70
		public int StartPerformancesLength
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

		// Token: 0x0603528E RID: 217742 RVA: 0x00736D9C File Offset: 0x00734F9C
		public TVisualNovelPerformance EndPerformancesType(int j)
		{
			int num = this.__p.__offset(104);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DE8A RID: 56970
		// (get) Token: 0x0603528F RID: 217743 RVA: 0x00736DDC File Offset: 0x00734FDC
		public int EndPerformancesTypeLength
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

		// Token: 0x06035290 RID: 217744 RVA: 0x00736E08 File Offset: 0x00735008
		public Span<TVisualNovelPerformance> GetEndPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(104, 1);
		}

		// Token: 0x06035291 RID: 217745 RVA: 0x00736E18 File Offset: 0x00735018
		public TVisualNovelPerformance[] GetEndPerformancesTypeArray()
		{
			int num = this.__p.__offset(104);
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

		// Token: 0x06035292 RID: 217746 RVA: 0x00736E84 File Offset: 0x00735084
		public TTable? EndPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(106);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DE8B RID: 56971
		// (get) Token: 0x06035293 RID: 217747 RVA: 0x00736ECC File Offset: 0x007350CC
		public int EndPerformancesLength
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DE8C RID: 56972
		// (get) Token: 0x06035294 RID: 217748 RVA: 0x00736EF8 File Offset: 0x007350F8
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035295 RID: 217749 RVA: 0x00736F38 File Offset: 0x00735138
		public static Offset<ITalkItemVisualNovelNarration> CreateITalkItemVisualNovelNarration(FlatBufferBuilder builder, ETalkItemType Type = ETalkItemType.Talk, int Id = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, int WhoId = 0, int TextId = 0, StringOffset TidTalkOffset = default(StringOffset), float WaitTime = 0f, Offset<ICaptionParam> CaptionParamsOffset = default(Offset<ICaptionParam>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), Offset<IPlayMontage> MontageOffset = default(Offset<IPlayMontage>), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>), Offset<ISetFlowTemplate> FlowTemplateOffset = default(Offset<ISetFlowTemplate>), VectorOffset FlowTemplateListOffset = default(VectorOffset), VectorOffset ActorMontageArrayOffset = default(VectorOffset), VectorOffset ActorFaceExpressionArrayOffset = default(VectorOffset), VectorOffset ActorLookAtArrayOffset = default(VectorOffset), VectorOffset ActorTurnToArrayOffset = default(VectorOffset), TPostAkEvent TalkAkEvent_type = TPostAkEvent.NONE, int TalkAkEventOffset = 0, TPostAkEvent TalkEndAkEvent_type = TPostAkEvent.NONE, int TalkEndAkEventOffset = 0, Offset<IUniversalTone> UniversalToneOffset = default(Offset<IUniversalTone>), TTalkBackground BackgroundConfig_type = TTalkBackground.NONE, int BackgroundConfigOffset = 0, bool PlayVoice = false, Offset<ITimeLimitOptionGroup> TimeLimitOptionGroupOffset = default(Offset<ITimeLimitOptionGroup>), Offset<IGamepadShakeInTalk> GamepadShakeOffset = default(Offset<IGamepadShakeInTalk>), VectorOffset IntroActionsOffset = default(VectorOffset), VectorOffset ActorFxEmoteArrayOffset = default(VectorOffset), VectorOffset TalkEffectArray_typeOffset = default(VectorOffset), VectorOffset TalkEffectArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), EVisualNovelOptionInteractionType OptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect, Offset<IVisualNovelOptionGroupSolarSchoolExam> OptionGroupOffset = default(Offset<IVisualNovelOptionGroupSolarSchoolExam>), float DialogDelay = 0f, bool ClickShowFull = false, TVisualNovelBackground VisualNovelBackgroundConfig_type = TVisualNovelBackground.NONE, int VisualNovelBackgroundConfigOffset = 0, TVisualNovelCg CgConfig_type = TVisualNovelCg.NONE, int CgConfigOffset = 0, TVisualNovelDisplayItem DisplayItemConfig_type = TVisualNovelDisplayItem.NONE, int DisplayItemConfigOffset = 0, int PlotKeyId = 0, VectorOffset StartPerformances_typeOffset = default(VectorOffset), VectorOffset StartPerformancesOffset = default(VectorOffset), VectorOffset EndPerformances_typeOffset = default(VectorOffset), VectorOffset EndPerformancesOffset = default(VectorOffset), uint NullMask = 0U)
		{
			builder.StartTable(53);
			ITalkItemVisualNovelNarration.AddNullMask(builder, NullMask);
			ITalkItemVisualNovelNarration.AddEndPerformances(builder, EndPerformancesOffset);
			ITalkItemVisualNovelNarration.AddEndPerformancesType(builder, EndPerformances_typeOffset);
			ITalkItemVisualNovelNarration.AddStartPerformances(builder, StartPerformancesOffset);
			ITalkItemVisualNovelNarration.AddStartPerformancesType(builder, StartPerformances_typeOffset);
			ITalkItemVisualNovelNarration.AddPlotKeyId(builder, PlotKeyId);
			ITalkItemVisualNovelNarration.AddDisplayItemConfig(builder, DisplayItemConfigOffset);
			ITalkItemVisualNovelNarration.AddCgConfig(builder, CgConfigOffset);
			ITalkItemVisualNovelNarration.AddVisualNovelBackgroundConfig(builder, VisualNovelBackgroundConfigOffset);
			ITalkItemVisualNovelNarration.AddDialogDelay(builder, DialogDelay);
			ITalkItemVisualNovelNarration.AddOptionGroup(builder, OptionGroupOffset);
			ITalkItemVisualNovelNarration.AddActorVisibilityArray(builder, ActorVisibilityArrayOffset);
			ITalkItemVisualNovelNarration.AddTalkEffectArray(builder, TalkEffectArrayOffset);
			ITalkItemVisualNovelNarration.AddTalkEffectArrayType(builder, TalkEffectArray_typeOffset);
			ITalkItemVisualNovelNarration.AddActorFxEmoteArray(builder, ActorFxEmoteArrayOffset);
			ITalkItemVisualNovelNarration.AddIntroActions(builder, IntroActionsOffset);
			ITalkItemVisualNovelNarration.AddGamepadShake(builder, GamepadShakeOffset);
			ITalkItemVisualNovelNarration.AddTimeLimitOptionGroup(builder, TimeLimitOptionGroupOffset);
			ITalkItemVisualNovelNarration.AddBackgroundConfig(builder, BackgroundConfigOffset);
			ITalkItemVisualNovelNarration.AddUniversalTone(builder, UniversalToneOffset);
			ITalkItemVisualNovelNarration.AddTalkEndAkEvent(builder, TalkEndAkEventOffset);
			ITalkItemVisualNovelNarration.AddTalkAkEvent(builder, TalkAkEventOffset);
			ITalkItemVisualNovelNarration.AddActorTurnToArray(builder, ActorTurnToArrayOffset);
			ITalkItemVisualNovelNarration.AddActorLookAtArray(builder, ActorLookAtArrayOffset);
			ITalkItemVisualNovelNarration.AddActorFaceExpressionArray(builder, ActorFaceExpressionArrayOffset);
			ITalkItemVisualNovelNarration.AddActorMontageArray(builder, ActorMontageArrayOffset);
			ITalkItemVisualNovelNarration.AddFlowTemplateList(builder, FlowTemplateListOffset);
			ITalkItemVisualNovelNarration.AddFlowTemplate(builder, FlowTemplateOffset);
			ITalkItemVisualNovelNarration.AddCameraData(builder, CameraDataOffset);
			ITalkItemVisualNovelNarration.AddMontage(builder, MontageOffset);
			ITalkItemVisualNovelNarration.AddOptions(builder, OptionsOffset);
			ITalkItemVisualNovelNarration.AddActions(builder, ActionsOffset);
			ITalkItemVisualNovelNarration.AddCaptionParams(builder, CaptionParamsOffset);
			ITalkItemVisualNovelNarration.AddWaitTime(builder, WaitTime);
			ITalkItemVisualNovelNarration.AddTidTalk(builder, TidTalkOffset);
			ITalkItemVisualNovelNarration.AddTextId(builder, TextId);
			ITalkItemVisualNovelNarration.AddWhoId(builder, WhoId);
			ITalkItemVisualNovelNarration.AddName(builder, NameOffset);
			ITalkItemVisualNovelNarration.AddPlotLineKey(builder, PlotLineKeyOffset);
			ITalkItemVisualNovelNarration.AddPlotLineId(builder, PlotLineId);
			ITalkItemVisualNovelNarration.AddId(builder, Id);
			ITalkItemVisualNovelNarration.AddDisplayItemConfigType(builder, DisplayItemConfig_type);
			ITalkItemVisualNovelNarration.AddCgConfigType(builder, CgConfig_type);
			ITalkItemVisualNovelNarration.AddVisualNovelBackgroundConfigType(builder, VisualNovelBackgroundConfig_type);
			ITalkItemVisualNovelNarration.AddClickShowFull(builder, ClickShowFull);
			ITalkItemVisualNovelNarration.AddOptionInteractionType(builder, OptionInteractionType);
			ITalkItemVisualNovelNarration.AddPlayVoice(builder, PlayVoice);
			ITalkItemVisualNovelNarration.AddBackgroundConfigType(builder, BackgroundConfig_type);
			ITalkItemVisualNovelNarration.AddTalkEndAkEventType(builder, TalkEndAkEvent_type);
			ITalkItemVisualNovelNarration.AddTalkAkEventType(builder, TalkAkEvent_type);
			ITalkItemVisualNovelNarration.Add_EditFlag(builder, _editFlag);
			ITalkItemVisualNovelNarration.Add_Folded(builder, _folded);
			ITalkItemVisualNovelNarration.AddType(builder, Type);
			return ITalkItemVisualNovelNarration.EndITalkItemVisualNovelNarration(builder);
		}

		// Token: 0x06035296 RID: 217750 RVA: 0x007370F8 File Offset: 0x007352F8
		public static void StartITalkItemVisualNovelNarration(FlatBufferBuilder builder)
		{
			builder.StartTable(53);
		}

		// Token: 0x06035297 RID: 217751 RVA: 0x00737102 File Offset: 0x00735302
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035298 RID: 217752 RVA: 0x0073710D File Offset: 0x0073530D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06035299 RID: 217753 RVA: 0x00737118 File Offset: 0x00735318
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x0603529A RID: 217754 RVA: 0x00737123 File Offset: 0x00735323
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x0603529B RID: 217755 RVA: 0x00737133 File Offset: 0x00735333
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x0603529C RID: 217756 RVA: 0x00737143 File Offset: 0x00735343
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x0603529D RID: 217757 RVA: 0x0073714E File Offset: 0x0073534E
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x0603529E RID: 217758 RVA: 0x00737159 File Offset: 0x00735359
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x0603529F RID: 217759 RVA: 0x00737164 File Offset: 0x00735364
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x060352A0 RID: 217760 RVA: 0x0073716F File Offset: 0x0073536F
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x060352A1 RID: 217761 RVA: 0x00737180 File Offset: 0x00735380
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x060352A2 RID: 217762 RVA: 0x00737194 File Offset: 0x00735394
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x060352A3 RID: 217763 RVA: 0x007371A5 File Offset: 0x007353A5
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x060352A4 RID: 217764 RVA: 0x007371B8 File Offset: 0x007353B8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352A5 RID: 217765 RVA: 0x007371F8 File Offset: 0x007353F8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352A6 RID: 217766 RVA: 0x00737212 File Offset: 0x00735412
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352A7 RID: 217767 RVA: 0x00737230 File Offset: 0x00735430
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352A8 RID: 217768 RVA: 0x00737249 File Offset: 0x00735449
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352A9 RID: 217769 RVA: 0x00737254 File Offset: 0x00735454
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x060352AA RID: 217770 RVA: 0x00737268 File Offset: 0x00735468
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352AB RID: 217771 RVA: 0x007372A8 File Offset: 0x007354A8
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352AC RID: 217772 RVA: 0x007372C2 File Offset: 0x007354C2
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352AD RID: 217773 RVA: 0x007372E0 File Offset: 0x007354E0
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352AE RID: 217774 RVA: 0x007372F9 File Offset: 0x007354F9
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352AF RID: 217775 RVA: 0x00737304 File Offset: 0x00735504
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x060352B0 RID: 217776 RVA: 0x00737315 File Offset: 0x00735515
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x060352B1 RID: 217777 RVA: 0x00737326 File Offset: 0x00735526
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x060352B2 RID: 217778 RVA: 0x00737337 File Offset: 0x00735537
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x060352B3 RID: 217779 RVA: 0x00737348 File Offset: 0x00735548
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352B4 RID: 217780 RVA: 0x00737388 File Offset: 0x00735588
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352B5 RID: 217781 RVA: 0x007373A2 File Offset: 0x007355A2
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352B6 RID: 217782 RVA: 0x007373C0 File Offset: 0x007355C0
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352B7 RID: 217783 RVA: 0x007373D9 File Offset: 0x007355D9
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352B8 RID: 217784 RVA: 0x007373E4 File Offset: 0x007355E4
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x060352B9 RID: 217785 RVA: 0x007373F8 File Offset: 0x007355F8
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352BA RID: 217786 RVA: 0x00737438 File Offset: 0x00735638
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352BB RID: 217787 RVA: 0x00737452 File Offset: 0x00735652
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352BC RID: 217788 RVA: 0x00737470 File Offset: 0x00735670
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352BD RID: 217789 RVA: 0x00737489 File Offset: 0x00735689
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352BE RID: 217790 RVA: 0x00737494 File Offset: 0x00735694
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x060352BF RID: 217791 RVA: 0x007374A8 File Offset: 0x007356A8
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352C0 RID: 217792 RVA: 0x007374E8 File Offset: 0x007356E8
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352C1 RID: 217793 RVA: 0x00737502 File Offset: 0x00735702
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352C2 RID: 217794 RVA: 0x00737520 File Offset: 0x00735720
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352C3 RID: 217795 RVA: 0x00737539 File Offset: 0x00735739
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352C4 RID: 217796 RVA: 0x00737544 File Offset: 0x00735744
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x060352C5 RID: 217797 RVA: 0x00737558 File Offset: 0x00735758
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352C6 RID: 217798 RVA: 0x00737598 File Offset: 0x00735798
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352C7 RID: 217799 RVA: 0x007375B2 File Offset: 0x007357B2
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352C8 RID: 217800 RVA: 0x007375D0 File Offset: 0x007357D0
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352C9 RID: 217801 RVA: 0x007375E9 File Offset: 0x007357E9
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352CA RID: 217802 RVA: 0x007375F4 File Offset: 0x007357F4
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x060352CB RID: 217803 RVA: 0x00737608 File Offset: 0x00735808
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352CC RID: 217804 RVA: 0x00737648 File Offset: 0x00735848
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352CD RID: 217805 RVA: 0x00737662 File Offset: 0x00735862
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352CE RID: 217806 RVA: 0x00737680 File Offset: 0x00735880
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352CF RID: 217807 RVA: 0x00737699 File Offset: 0x00735899
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352D0 RID: 217808 RVA: 0x007376A4 File Offset: 0x007358A4
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x060352D1 RID: 217809 RVA: 0x007376B0 File Offset: 0x007358B0
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x060352D2 RID: 217810 RVA: 0x007376BC File Offset: 0x007358BC
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x060352D3 RID: 217811 RVA: 0x007376C8 File Offset: 0x007358C8
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x060352D4 RID: 217812 RVA: 0x007376D4 File Offset: 0x007358D4
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x060352D5 RID: 217813 RVA: 0x007376E5 File Offset: 0x007358E5
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x060352D6 RID: 217814 RVA: 0x007376F1 File Offset: 0x007358F1
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x060352D7 RID: 217815 RVA: 0x007376FD File Offset: 0x007358FD
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x060352D8 RID: 217816 RVA: 0x00737709 File Offset: 0x00735909
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x060352D9 RID: 217817 RVA: 0x0073771A File Offset: 0x0073591A
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x060352DA RID: 217818 RVA: 0x0073772B File Offset: 0x0073592B
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x060352DB RID: 217819 RVA: 0x0073773C File Offset: 0x0073593C
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352DC RID: 217820 RVA: 0x0073777C File Offset: 0x0073597C
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352DD RID: 217821 RVA: 0x00737796 File Offset: 0x00735996
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352DE RID: 217822 RVA: 0x007377B4 File Offset: 0x007359B4
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352DF RID: 217823 RVA: 0x007377CD File Offset: 0x007359CD
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352E0 RID: 217824 RVA: 0x007377D8 File Offset: 0x007359D8
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x060352E1 RID: 217825 RVA: 0x007377EC File Offset: 0x007359EC
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352E2 RID: 217826 RVA: 0x0073782C File Offset: 0x00735A2C
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352E3 RID: 217827 RVA: 0x00737846 File Offset: 0x00735A46
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352E4 RID: 217828 RVA: 0x00737864 File Offset: 0x00735A64
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352E5 RID: 217829 RVA: 0x0073787D File Offset: 0x00735A7D
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352E6 RID: 217830 RVA: 0x00737888 File Offset: 0x00735A88
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x060352E7 RID: 217831 RVA: 0x0073789C File Offset: 0x00735A9C
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060352E8 RID: 217832 RVA: 0x007378D3 File Offset: 0x00735AD3
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x060352E9 RID: 217833 RVA: 0x007378ED File Offset: 0x00735AED
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x060352EA RID: 217834 RVA: 0x0073790B File Offset: 0x00735B0B
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352EB RID: 217835 RVA: 0x00737924 File Offset: 0x00735B24
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060352EC RID: 217836 RVA: 0x0073792F File Offset: 0x00735B2F
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x060352ED RID: 217837 RVA: 0x00737940 File Offset: 0x00735B40
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060352EE RID: 217838 RVA: 0x00737977 File Offset: 0x00735B77
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060352EF RID: 217839 RVA: 0x00737991 File Offset: 0x00735B91
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060352F0 RID: 217840 RVA: 0x007379AF File Offset: 0x00735BAF
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352F1 RID: 217841 RVA: 0x007379C8 File Offset: 0x00735BC8
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352F2 RID: 217842 RVA: 0x007379D3 File Offset: 0x00735BD3
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x060352F3 RID: 217843 RVA: 0x007379E4 File Offset: 0x00735BE4
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060352F4 RID: 217844 RVA: 0x00737A24 File Offset: 0x00735C24
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352F5 RID: 217845 RVA: 0x00737A3E File Offset: 0x00735C3E
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x060352F6 RID: 217846 RVA: 0x00737A5C File Offset: 0x00735C5C
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060352F7 RID: 217847 RVA: 0x00737A75 File Offset: 0x00735C75
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060352F8 RID: 217848 RVA: 0x00737A80 File Offset: 0x00735C80
		public static void AddOptionInteractionType(FlatBufferBuilder builder, EVisualNovelOptionInteractionType optionInteractionType)
		{
			builder.AddByte(37, (byte)optionInteractionType, 0);
		}

		// Token: 0x060352F9 RID: 217849 RVA: 0x00737A8C File Offset: 0x00735C8C
		public static void AddOptionGroup(FlatBufferBuilder builder, Offset<IVisualNovelOptionGroupSolarSchoolExam> optionGroupOffset)
		{
			builder.AddOffset(38, optionGroupOffset.Value, 0);
		}

		// Token: 0x060352FA RID: 217850 RVA: 0x00737A9D File Offset: 0x00735C9D
		public static void AddDialogDelay(FlatBufferBuilder builder, float dialogDelay)
		{
			builder.AddFloat(39, dialogDelay, 0.0);
		}

		// Token: 0x060352FB RID: 217851 RVA: 0x00737AB1 File Offset: 0x00735CB1
		public static void AddClickShowFull(FlatBufferBuilder builder, bool clickShowFull)
		{
			builder.AddBool(40, clickShowFull, false);
		}

		// Token: 0x060352FC RID: 217852 RVA: 0x00737ABD File Offset: 0x00735CBD
		public static void AddVisualNovelBackgroundConfigType(FlatBufferBuilder builder, TVisualNovelBackground visualNovelBackgroundConfigType)
		{
			builder.AddByte(41, (byte)visualNovelBackgroundConfigType, 0);
		}

		// Token: 0x060352FD RID: 217853 RVA: 0x00737AC9 File Offset: 0x00735CC9
		public static void AddVisualNovelBackgroundConfig(FlatBufferBuilder builder, int visualNovelBackgroundConfigOffset)
		{
			builder.AddOffset(42, visualNovelBackgroundConfigOffset, 0);
		}

		// Token: 0x060352FE RID: 217854 RVA: 0x00737AD5 File Offset: 0x00735CD5
		public static void AddCgConfigType(FlatBufferBuilder builder, TVisualNovelCg cgConfigType)
		{
			builder.AddByte(43, (byte)cgConfigType, 0);
		}

		// Token: 0x060352FF RID: 217855 RVA: 0x00737AE1 File Offset: 0x00735CE1
		public static void AddCgConfig(FlatBufferBuilder builder, int cgConfigOffset)
		{
			builder.AddOffset(44, cgConfigOffset, 0);
		}

		// Token: 0x06035300 RID: 217856 RVA: 0x00737AED File Offset: 0x00735CED
		public static void AddDisplayItemConfigType(FlatBufferBuilder builder, TVisualNovelDisplayItem displayItemConfigType)
		{
			builder.AddByte(45, (byte)displayItemConfigType, 0);
		}

		// Token: 0x06035301 RID: 217857 RVA: 0x00737AF9 File Offset: 0x00735CF9
		public static void AddDisplayItemConfig(FlatBufferBuilder builder, int displayItemConfigOffset)
		{
			builder.AddOffset(46, displayItemConfigOffset, 0);
		}

		// Token: 0x06035302 RID: 217858 RVA: 0x00737B05 File Offset: 0x00735D05
		public static void AddPlotKeyId(FlatBufferBuilder builder, int plotKeyId)
		{
			builder.AddInt(47, plotKeyId, 0);
		}

		// Token: 0x06035303 RID: 217859 RVA: 0x00737B11 File Offset: 0x00735D11
		public static void AddStartPerformancesType(FlatBufferBuilder builder, VectorOffset startPerformancesTypeOffset)
		{
			builder.AddOffset(48, startPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x06035304 RID: 217860 RVA: 0x00737B24 File Offset: 0x00735D24
		public static VectorOffset CreateStartPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035305 RID: 217861 RVA: 0x00737B5B File Offset: 0x00735D5B
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035306 RID: 217862 RVA: 0x00737B75 File Offset: 0x00735D75
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035307 RID: 217863 RVA: 0x00737B93 File Offset: 0x00735D93
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035308 RID: 217864 RVA: 0x00737BAC File Offset: 0x00735DAC
		public static void StartStartPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06035309 RID: 217865 RVA: 0x00737BB7 File Offset: 0x00735DB7
		public static void AddStartPerformances(FlatBufferBuilder builder, VectorOffset startPerformancesOffset)
		{
			builder.AddOffset(49, startPerformancesOffset.Value, 0);
		}

		// Token: 0x0603530A RID: 217866 RVA: 0x00737BC8 File Offset: 0x00735DC8
		public static VectorOffset CreateStartPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603530B RID: 217867 RVA: 0x00737BFF File Offset: 0x00735DFF
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603530C RID: 217868 RVA: 0x00737C19 File Offset: 0x00735E19
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603530D RID: 217869 RVA: 0x00737C37 File Offset: 0x00735E37
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603530E RID: 217870 RVA: 0x00737C50 File Offset: 0x00735E50
		public static void StartStartPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603530F RID: 217871 RVA: 0x00737C5B File Offset: 0x00735E5B
		public static void AddEndPerformancesType(FlatBufferBuilder builder, VectorOffset endPerformancesTypeOffset)
		{
			builder.AddOffset(50, endPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x06035310 RID: 217872 RVA: 0x00737C6C File Offset: 0x00735E6C
		public static VectorOffset CreateEndPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035311 RID: 217873 RVA: 0x00737CA3 File Offset: 0x00735EA3
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035312 RID: 217874 RVA: 0x00737CBD File Offset: 0x00735EBD
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06035313 RID: 217875 RVA: 0x00737CDB File Offset: 0x00735EDB
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035314 RID: 217876 RVA: 0x00737CF4 File Offset: 0x00735EF4
		public static void StartEndPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06035315 RID: 217877 RVA: 0x00737CFF File Offset: 0x00735EFF
		public static void AddEndPerformances(FlatBufferBuilder builder, VectorOffset endPerformancesOffset)
		{
			builder.AddOffset(51, endPerformancesOffset.Value, 0);
		}

		// Token: 0x06035316 RID: 217878 RVA: 0x00737D10 File Offset: 0x00735F10
		public static VectorOffset CreateEndPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035317 RID: 217879 RVA: 0x00737D47 File Offset: 0x00735F47
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035318 RID: 217880 RVA: 0x00737D61 File Offset: 0x00735F61
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035319 RID: 217881 RVA: 0x00737D7F File Offset: 0x00735F7F
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603531A RID: 217882 RVA: 0x00737D98 File Offset: 0x00735F98
		public static void StartEndPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603531B RID: 217883 RVA: 0x00737DA3 File Offset: 0x00735FA3
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(52, nullMask, 0U);
		}

		// Token: 0x0603531C RID: 217884 RVA: 0x00737DAF File Offset: 0x00735FAF
		public static Offset<ITalkItemVisualNovelNarration> EndITalkItemVisualNovelNarration(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemVisualNovelNarration>(builder.EndTable());
		}

		// Token: 0x0603531D RID: 217885 RVA: 0x00737DBC File Offset: 0x00735FBC
		public ITalkItemVisualNovelNarrationT UnPack()
		{
			ITalkItemVisualNovelNarrationT talkItemVisualNovelNarrationT = new ITalkItemVisualNovelNarrationT();
			this.UnPackTo(talkItemVisualNovelNarrationT);
			return talkItemVisualNovelNarrationT;
		}

		// Token: 0x0603531E RID: 217886 RVA: 0x00737DD8 File Offset: 0x00735FD8
		public void UnPackTo(ITalkItemVisualNovelNarrationT _o)
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
			_o.DialogDelay = this.DialogDelay;
			_o.ClickShowFull = this.ClickShowFull;
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

		// Token: 0x0603531F RID: 217887 RVA: 0x007393E0 File Offset: 0x007375E0
		public static Offset<ITalkItemVisualNovelNarration> Pack(FlatBufferBuilder builder, ITalkItemVisualNovelNarrationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemVisualNovelNarration>);
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
				actionsOffset = ITalkItemVisualNovelNarration.CreateActionsVector(builder, array);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<ITalkOption>[] array2 = new Offset<ITalkOption>[_o.Options.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ITalkOption.Pack(builder, _o.Options[j]);
				}
				optionsOffset = ITalkItemVisualNovelNarration.CreateOptionsVector(builder, array2);
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
				flowTemplateListOffset = ITalkItemVisualNovelNarration.CreateFlowTemplateListVector(builder, array3);
			}
			VectorOffset actorMontageArrayOffset = default(VectorOffset);
			if (_o.ActorMontageArray != null)
			{
				Offset<IMontageData>[] array4 = new Offset<IMontageData>[_o.ActorMontageArray.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IMontageData.Pack(builder, _o.ActorMontageArray[l]);
				}
				actorMontageArrayOffset = ITalkItemVisualNovelNarration.CreateActorMontageArrayVector(builder, array4);
			}
			VectorOffset actorFaceExpressionArrayOffset = default(VectorOffset);
			if (_o.ActorFaceExpressionArray != null)
			{
				Offset<IActorFaceExpression>[] array5 = new Offset<IActorFaceExpression>[_o.ActorFaceExpressionArray.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActorFaceExpression.Pack(builder, _o.ActorFaceExpressionArray[m]);
				}
				actorFaceExpressionArrayOffset = ITalkItemVisualNovelNarration.CreateActorFaceExpressionArrayVector(builder, array5);
			}
			VectorOffset actorLookAtArrayOffset = default(VectorOffset);
			if (_o.ActorLookAtArray != null)
			{
				Offset<IActorLookAt>[] array6 = new Offset<IActorLookAt>[_o.ActorLookAtArray.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = IActorLookAt.Pack(builder, _o.ActorLookAtArray[n]);
				}
				actorLookAtArrayOffset = ITalkItemVisualNovelNarration.CreateActorLookAtArrayVector(builder, array6);
			}
			VectorOffset actorTurnToArrayOffset = default(VectorOffset);
			if (_o.ActorTurnToArray != null)
			{
				Offset<IActorTurnTo>[] array7 = new Offset<IActorTurnTo>[_o.ActorTurnToArray.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = IActorTurnTo.Pack(builder, _o.ActorTurnToArray[num]);
				}
				actorTurnToArrayOffset = ITalkItemVisualNovelNarration.CreateActorTurnToArrayVector(builder, array7);
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
				introActionsOffset = ITalkItemVisualNovelNarration.CreateIntroActionsVector(builder, array8);
			}
			VectorOffset actorFxEmoteArrayOffset = default(VectorOffset);
			if (_o.ActorFxEmoteArray != null)
			{
				Offset<IActorFxEmote>[] array9 = new Offset<IActorFxEmote>[_o.ActorFxEmoteArray.Count];
				for (int num3 = 0; num3 < array9.Length; num3++)
				{
					array9[num3] = IActorFxEmote.Pack(builder, _o.ActorFxEmoteArray[num3]);
				}
				actorFxEmoteArrayOffset = ITalkItemVisualNovelNarration.CreateActorFxEmoteArrayVector(builder, array9);
			}
			VectorOffset talkEffectArray_typeOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				TTalkEffectAction[] array10 = new TTalkEffectAction[_o.TalkEffectArray.Count];
				for (int num4 = 0; num4 < array10.Length; num4++)
				{
					array10[num4] = _o.TalkEffectArray[num4].Type;
				}
				talkEffectArray_typeOffset = ITalkItemVisualNovelNarration.CreateTalkEffectArrayTypeVector(builder, array10);
			}
			VectorOffset talkEffectArrayOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				int[] array11 = new int[_o.TalkEffectArray.Count];
				for (int num5 = 0; num5 < array11.Length; num5++)
				{
					array11[num5] = TTalkEffectActionUnion.Pack(builder, _o.TalkEffectArray[num5]);
				}
				talkEffectArrayOffset = ITalkItemVisualNovelNarration.CreateTalkEffectArrayVector(builder, array11);
			}
			VectorOffset actorVisibilityArrayOffset = default(VectorOffset);
			if (_o.ActorVisibilityArray != null)
			{
				Offset<IActorVisibility>[] array12 = new Offset<IActorVisibility>[_o.ActorVisibilityArray.Count];
				for (int num6 = 0; num6 < array12.Length; num6++)
				{
					array12[num6] = IActorVisibility.Pack(builder, _o.ActorVisibilityArray[num6]);
				}
				actorVisibilityArrayOffset = ITalkItemVisualNovelNarration.CreateActorVisibilityArrayVector(builder, array12);
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
				startPerformances_typeOffset = ITalkItemVisualNovelNarration.CreateStartPerformancesTypeVector(builder, array13);
			}
			VectorOffset startPerformancesOffset = default(VectorOffset);
			if (_o.StartPerformances != null)
			{
				int[] array14 = new int[_o.StartPerformances.Count];
				for (int num8 = 0; num8 < array14.Length; num8++)
				{
					array14[num8] = TVisualNovelPerformanceUnion.Pack(builder, _o.StartPerformances[num8]);
				}
				startPerformancesOffset = ITalkItemVisualNovelNarration.CreateStartPerformancesVector(builder, array14);
			}
			VectorOffset endPerformances_typeOffset = default(VectorOffset);
			if (_o.EndPerformances != null)
			{
				TVisualNovelPerformance[] array15 = new TVisualNovelPerformance[_o.EndPerformances.Count];
				for (int num9 = 0; num9 < array15.Length; num9++)
				{
					array15[num9] = _o.EndPerformances[num9].Type;
				}
				endPerformances_typeOffset = ITalkItemVisualNovelNarration.CreateEndPerformancesTypeVector(builder, array15);
			}
			VectorOffset endPerformancesOffset = default(VectorOffset);
			if (_o.EndPerformances != null)
			{
				int[] array16 = new int[_o.EndPerformances.Count];
				for (int num10 = 0; num10 < array16.Length; num10++)
				{
					array16[num10] = TVisualNovelPerformanceUnion.Pack(builder, _o.EndPerformances[num10]);
				}
				endPerformancesOffset = ITalkItemVisualNovelNarration.CreateEndPerformancesVector(builder, array16);
			}
			return ITalkItemVisualNovelNarration.CreateITalkItemVisualNovelNarration(builder, _o.Type, _o.Id, _o.PlotLineId, plotLineKeyOffset, nameOffset, _o._Folded, _o._EditFlag, _o.WhoId, _o.TextId, tidTalkOffset, _o.WaitTime, captionParamsOffset, actionsOffset, optionsOffset, montageOffset, cameraDataOffset, flowTemplateOffset, flowTemplateListOffset, actorMontageArrayOffset, actorFaceExpressionArrayOffset, actorLookAtArrayOffset, actorTurnToArrayOffset, talkAkEvent_type, talkAkEventOffset, talkEndAkEvent_type, talkEndAkEventOffset, universalToneOffset, backgroundConfig_type, backgroundConfigOffset, _o.PlayVoice, timeLimitOptionGroupOffset, gamepadShakeOffset, introActionsOffset, actorFxEmoteArrayOffset, talkEffectArray_typeOffset, talkEffectArrayOffset, actorVisibilityArrayOffset, _o.OptionInteractionType, optionGroupOffset, _o.DialogDelay, _o.ClickShowFull, visualNovelBackgroundConfig_type, visualNovelBackgroundConfigOffset, cgConfig_type, cgConfigOffset, displayItemConfig_type, displayItemConfigOffset, _o.PlotKeyId, startPerformances_typeOffset, startPerformancesOffset, endPerformances_typeOffset, endPerformancesOffset, _o.NullMask);
		}

		// Token: 0x04012033 RID: 73779
		private Table __p;
	}
}
