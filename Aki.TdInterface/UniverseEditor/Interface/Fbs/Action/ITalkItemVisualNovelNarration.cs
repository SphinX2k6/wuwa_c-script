using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AE8 RID: 31464
	public struct ITalkItemVisualNovelNarration : IFlatbufferObject
	{
		// Token: 0x1700EA5B RID: 59995
		// (get) Token: 0x06038550 RID: 230736 RVA: 0x0079719D File Offset: 0x0079539D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038551 RID: 230737 RVA: 0x007971AA File Offset: 0x007953AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038552 RID: 230738 RVA: 0x007971B4 File Offset: 0x007953B4
		public static ITalkItemVisualNovelNarration GetRootAsITalkItemVisualNovelNarration(ByteBuffer _bb)
		{
			return ITalkItemVisualNovelNarration.GetRootAsITalkItemVisualNovelNarration(_bb, default(ITalkItemVisualNovelNarration));
		}

		// Token: 0x06038553 RID: 230739 RVA: 0x007971D0 File Offset: 0x007953D0
		public static ITalkItemVisualNovelNarration GetRootAsITalkItemVisualNovelNarration(ByteBuffer _bb, ITalkItemVisualNovelNarration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038554 RID: 230740 RVA: 0x007971ED File Offset: 0x007953ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038555 RID: 230741 RVA: 0x007971FC File Offset: 0x007953FC
		public ITalkItemVisualNovelNarration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EA5C RID: 59996
		// (get) Token: 0x06038556 RID: 230742 RVA: 0x0079720C File Offset: 0x0079540C
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

		// Token: 0x1700EA5D RID: 59997
		// (get) Token: 0x06038557 RID: 230743 RVA: 0x00797248 File Offset: 0x00795448
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

		// Token: 0x1700EA5E RID: 59998
		// (get) Token: 0x06038558 RID: 230744 RVA: 0x00797284 File Offset: 0x00795484
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

		// Token: 0x1700EA5F RID: 59999
		// (get) Token: 0x06038559 RID: 230745 RVA: 0x007972C0 File Offset: 0x007954C0
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

		// Token: 0x0603855A RID: 230746 RVA: 0x007972F8 File Offset: 0x007954F8
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0603855B RID: 230747 RVA: 0x00797308 File Offset: 0x00795508
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700EA60 RID: 60000
		// (get) Token: 0x0603855C RID: 230748 RVA: 0x00797318 File Offset: 0x00795518
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

		// Token: 0x0603855D RID: 230749 RVA: 0x00797350 File Offset: 0x00795550
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0603855E RID: 230750 RVA: 0x00797360 File Offset: 0x00795560
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700EA61 RID: 60001
		// (get) Token: 0x0603855F RID: 230751 RVA: 0x00797370 File Offset: 0x00795570
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EA62 RID: 60002
		// (get) Token: 0x06038560 RID: 230752 RVA: 0x007973B0 File Offset: 0x007955B0
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

		// Token: 0x1700EA63 RID: 60003
		// (get) Token: 0x06038561 RID: 230753 RVA: 0x007973F0 File Offset: 0x007955F0
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

		// Token: 0x1700EA64 RID: 60004
		// (get) Token: 0x06038562 RID: 230754 RVA: 0x00797430 File Offset: 0x00795630
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

		// Token: 0x1700EA65 RID: 60005
		// (get) Token: 0x06038563 RID: 230755 RVA: 0x00797470 File Offset: 0x00795670
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

		// Token: 0x06038564 RID: 230756 RVA: 0x007974A8 File Offset: 0x007956A8
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06038565 RID: 230757 RVA: 0x007974B8 File Offset: 0x007956B8
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700EA66 RID: 60006
		// (get) Token: 0x06038566 RID: 230758 RVA: 0x007974C8 File Offset: 0x007956C8
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

		// Token: 0x1700EA67 RID: 60007
		// (get) Token: 0x06038567 RID: 230759 RVA: 0x0079750C File Offset: 0x0079570C
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

		// Token: 0x06038568 RID: 230760 RVA: 0x0079756C File Offset: 0x0079576C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA68 RID: 60008
		// (get) Token: 0x06038569 RID: 230761 RVA: 0x007975D0 File Offset: 0x007957D0
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

		// Token: 0x0603856A RID: 230762 RVA: 0x007975FC File Offset: 0x007957FC
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA69 RID: 60009
		// (get) Token: 0x0603856B RID: 230763 RVA: 0x00797660 File Offset: 0x00795860
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

		// Token: 0x1700EA6A RID: 60010
		// (get) Token: 0x0603856C RID: 230764 RVA: 0x0079768C File Offset: 0x0079588C
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

		// Token: 0x1700EA6B RID: 60011
		// (get) Token: 0x0603856D RID: 230765 RVA: 0x007976EC File Offset: 0x007958EC
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

		// Token: 0x1700EA6C RID: 60012
		// (get) Token: 0x0603856E RID: 230766 RVA: 0x0079774C File Offset: 0x0079594C
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

		// Token: 0x0603856F RID: 230767 RVA: 0x007977AC File Offset: 0x007959AC
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA6D RID: 60013
		// (get) Token: 0x06038570 RID: 230768 RVA: 0x00797810 File Offset: 0x00795A10
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

		// Token: 0x06038571 RID: 230769 RVA: 0x0079783C File Offset: 0x00795A3C
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA6E RID: 60014
		// (get) Token: 0x06038572 RID: 230770 RVA: 0x007978A0 File Offset: 0x00795AA0
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

		// Token: 0x06038573 RID: 230771 RVA: 0x007978CC File Offset: 0x00795ACC
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA6F RID: 60015
		// (get) Token: 0x06038574 RID: 230772 RVA: 0x00797930 File Offset: 0x00795B30
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

		// Token: 0x06038575 RID: 230773 RVA: 0x0079795C File Offset: 0x00795B5C
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA70 RID: 60016
		// (get) Token: 0x06038576 RID: 230774 RVA: 0x007979C0 File Offset: 0x00795BC0
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

		// Token: 0x06038577 RID: 230775 RVA: 0x007979EC File Offset: 0x00795BEC
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA71 RID: 60017
		// (get) Token: 0x06038578 RID: 230776 RVA: 0x00797A50 File Offset: 0x00795C50
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

		// Token: 0x1700EA72 RID: 60018
		// (get) Token: 0x06038579 RID: 230777 RVA: 0x00797A7C File Offset: 0x00795C7C
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

		// Token: 0x0603857A RID: 230778 RVA: 0x00797ABC File Offset: 0x00795CBC
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603857B RID: 230779 RVA: 0x00797B04 File Offset: 0x00795D04
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x0603857C RID: 230780 RVA: 0x00797B20 File Offset: 0x00795D20
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x0603857D RID: 230781 RVA: 0x00797B3C File Offset: 0x00795D3C
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x0603857E RID: 230782 RVA: 0x00797B58 File Offset: 0x00795D58
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700EA73 RID: 60019
		// (get) Token: 0x0603857F RID: 230783 RVA: 0x00797B74 File Offset: 0x00795D74
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

		// Token: 0x06038580 RID: 230784 RVA: 0x00797BB4 File Offset: 0x00795DB4
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038581 RID: 230785 RVA: 0x00797BFC File Offset: 0x00795DFC
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06038582 RID: 230786 RVA: 0x00797C18 File Offset: 0x00795E18
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x06038583 RID: 230787 RVA: 0x00797C34 File Offset: 0x00795E34
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06038584 RID: 230788 RVA: 0x00797C50 File Offset: 0x00795E50
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700EA74 RID: 60020
		// (get) Token: 0x06038585 RID: 230789 RVA: 0x00797C6C File Offset: 0x00795E6C
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

		// Token: 0x1700EA75 RID: 60021
		// (get) Token: 0x06038586 RID: 230790 RVA: 0x00797CCC File Offset: 0x00795ECC
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

		// Token: 0x06038587 RID: 230791 RVA: 0x00797D0C File Offset: 0x00795F0C
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038588 RID: 230792 RVA: 0x00797D54 File Offset: 0x00795F54
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x06038589 RID: 230793 RVA: 0x00797D70 File Offset: 0x00795F70
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x0603858A RID: 230794 RVA: 0x00797D8C File Offset: 0x00795F8C
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x0603858B RID: 230795 RVA: 0x00797DA8 File Offset: 0x00795FA8
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x0603858C RID: 230796 RVA: 0x00797DC4 File Offset: 0x00795FC4
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700EA76 RID: 60022
		// (get) Token: 0x0603858D RID: 230797 RVA: 0x00797DE0 File Offset: 0x00795FE0
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EA77 RID: 60023
		// (get) Token: 0x0603858E RID: 230798 RVA: 0x00797E20 File Offset: 0x00796020
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

		// Token: 0x1700EA78 RID: 60024
		// (get) Token: 0x0603858F RID: 230799 RVA: 0x00797E80 File Offset: 0x00796080
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

		// Token: 0x06038590 RID: 230800 RVA: 0x00797EE0 File Offset: 0x007960E0
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA79 RID: 60025
		// (get) Token: 0x06038591 RID: 230801 RVA: 0x00797F44 File Offset: 0x00796144
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

		// Token: 0x06038592 RID: 230802 RVA: 0x00797F70 File Offset: 0x00796170
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA7A RID: 60026
		// (get) Token: 0x06038593 RID: 230803 RVA: 0x00797FD4 File Offset: 0x007961D4
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

		// Token: 0x06038594 RID: 230804 RVA: 0x00798000 File Offset: 0x00796200
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EA7B RID: 60027
		// (get) Token: 0x06038595 RID: 230805 RVA: 0x00798040 File Offset: 0x00796240
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

		// Token: 0x06038596 RID: 230806 RVA: 0x0079806C File Offset: 0x0079626C
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x06038597 RID: 230807 RVA: 0x0079807C File Offset: 0x0079627C
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

		// Token: 0x06038598 RID: 230808 RVA: 0x007980E8 File Offset: 0x007962E8
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700EA7C RID: 60028
		// (get) Token: 0x06038599 RID: 230809 RVA: 0x00798130 File Offset: 0x00796330
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

		// Token: 0x0603859A RID: 230810 RVA: 0x0079815C File Offset: 0x0079635C
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EA7D RID: 60029
		// (get) Token: 0x0603859B RID: 230811 RVA: 0x007981C0 File Offset: 0x007963C0
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

		// Token: 0x1700EA7E RID: 60030
		// (get) Token: 0x0603859C RID: 230812 RVA: 0x007981EC File Offset: 0x007963EC
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

		// Token: 0x1700EA7F RID: 60031
		// (get) Token: 0x0603859D RID: 230813 RVA: 0x0079822C File Offset: 0x0079642C
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

		// Token: 0x0603859E RID: 230814 RVA: 0x0079826C File Offset: 0x0079646C
		public TTable? OptionGroup<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603859F RID: 230815 RVA: 0x007982B4 File Offset: 0x007964B4
		public IVisualNovelOptionGroupFullScreen OptionGroupAsIVisualNovelOptionGroupFullScreen()
		{
			return this.OptionGroup<IVisualNovelOptionGroupFullScreen>().Value;
		}

		// Token: 0x060385A0 RID: 230816 RVA: 0x007982D0 File Offset: 0x007964D0
		public IVisualNovelOptionGroupNormal OptionGroupAsIVisualNovelOptionGroupNormal()
		{
			return this.OptionGroup<IVisualNovelOptionGroupNormal>().Value;
		}

		// Token: 0x1700EA80 RID: 60032
		// (get) Token: 0x060385A1 RID: 230817 RVA: 0x007982EC File Offset: 0x007964EC
		public float DialogDelay
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EA81 RID: 60033
		// (get) Token: 0x060385A2 RID: 230818 RVA: 0x00798330 File Offset: 0x00796530
		public bool ClickShowFull
		{
			get
			{
				int num = this.__p.__offset(86);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EA82 RID: 60034
		// (get) Token: 0x060385A3 RID: 230819 RVA: 0x00798370 File Offset: 0x00796570
		public TVisualNovelBackground VisualNovelBackgroundConfigType
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return TVisualNovelBackground.NONE;
				}
				return (TVisualNovelBackground)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060385A4 RID: 230820 RVA: 0x007983B0 File Offset: 0x007965B0
		public TTable? VisualNovelBackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(90);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060385A5 RID: 230821 RVA: 0x007983F8 File Offset: 0x007965F8
		public IVisualNovelBackgroundClean VisualNovelBackgroundConfigAsIVisualNovelBackgroundClean()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundClean>().Value;
		}

		// Token: 0x060385A6 RID: 230822 RVA: 0x00798414 File Offset: 0x00796614
		public IVisualNovelBackgroundLoad VisualNovelBackgroundConfigAsIVisualNovelBackgroundLoad()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundLoad>().Value;
		}

		// Token: 0x1700EA83 RID: 60035
		// (get) Token: 0x060385A7 RID: 230823 RVA: 0x00798430 File Offset: 0x00796630
		public TVisualNovelCg CgConfigType
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return TVisualNovelCg.NONE;
				}
				return (TVisualNovelCg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060385A8 RID: 230824 RVA: 0x00798470 File Offset: 0x00796670
		public TTable? CgConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(94);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060385A9 RID: 230825 RVA: 0x007984B8 File Offset: 0x007966B8
		public IVisualNovelCgClean CgConfigAsIVisualNovelCgClean()
		{
			return this.CgConfig<IVisualNovelCgClean>().Value;
		}

		// Token: 0x060385AA RID: 230826 RVA: 0x007984D4 File Offset: 0x007966D4
		public IVisualNovelCgLoadImage CgConfigAsIVisualNovelCgLoadImage()
		{
			return this.CgConfig<IVisualNovelCgLoadImage>().Value;
		}

		// Token: 0x060385AB RID: 230827 RVA: 0x007984F0 File Offset: 0x007966F0
		public IVisualNovelCgLoadPrefab CgConfigAsIVisualNovelCgLoadPrefab()
		{
			return this.CgConfig<IVisualNovelCgLoadPrefab>().Value;
		}

		// Token: 0x1700EA84 RID: 60036
		// (get) Token: 0x060385AC RID: 230828 RVA: 0x0079850C File Offset: 0x0079670C
		public TVisualNovelDisplayItem DisplayItemConfigType
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return TVisualNovelDisplayItem.NONE;
				}
				return (TVisualNovelDisplayItem)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060385AD RID: 230829 RVA: 0x0079854C File Offset: 0x0079674C
		public TTable? DisplayItemConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(98);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060385AE RID: 230830 RVA: 0x00798594 File Offset: 0x00796794
		public IVisualNovelDisplayItemClose DisplayItemConfigAsIVisualNovelDisplayItemClose()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemClose>().Value;
		}

		// Token: 0x060385AF RID: 230831 RVA: 0x007985B0 File Offset: 0x007967B0
		public IVisualNovelDisplayItemImage DisplayItemConfigAsIVisualNovelDisplayItemImage()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemImage>().Value;
		}

		// Token: 0x060385B0 RID: 230832 RVA: 0x007985CC File Offset: 0x007967CC
		public IVisualNovelDisplayItemPrefab DisplayItemConfigAsIVisualNovelDisplayItemPrefab()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemPrefab>().Value;
		}

		// Token: 0x1700EA85 RID: 60037
		// (get) Token: 0x060385B1 RID: 230833 RVA: 0x007985E8 File Offset: 0x007967E8
		public int PlotKeyId
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060385B2 RID: 230834 RVA: 0x00798628 File Offset: 0x00796828
		public TVisualNovelPerformance StartPerformancesType(int j)
		{
			int num = this.__p.__offset(102);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EA86 RID: 60038
		// (get) Token: 0x060385B3 RID: 230835 RVA: 0x00798668 File Offset: 0x00796868
		public int StartPerformancesTypeLength
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

		// Token: 0x060385B4 RID: 230836 RVA: 0x00798694 File Offset: 0x00796894
		public Span<TVisualNovelPerformance> GetStartPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(102, 1);
		}

		// Token: 0x060385B5 RID: 230837 RVA: 0x007986A4 File Offset: 0x007968A4
		public TVisualNovelPerformance[] GetStartPerformancesTypeArray()
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

		// Token: 0x060385B6 RID: 230838 RVA: 0x00798710 File Offset: 0x00796910
		public TTable? StartPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(104);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700EA87 RID: 60039
		// (get) Token: 0x060385B7 RID: 230839 RVA: 0x00798758 File Offset: 0x00796958
		public int StartPerformancesLength
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

		// Token: 0x060385B8 RID: 230840 RVA: 0x00798784 File Offset: 0x00796984
		public TVisualNovelPerformance EndPerformancesType(int j)
		{
			int num = this.__p.__offset(106);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EA88 RID: 60040
		// (get) Token: 0x060385B9 RID: 230841 RVA: 0x007987C4 File Offset: 0x007969C4
		public int EndPerformancesTypeLength
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

		// Token: 0x060385BA RID: 230842 RVA: 0x007987F0 File Offset: 0x007969F0
		public Span<TVisualNovelPerformance> GetEndPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(106, 1);
		}

		// Token: 0x060385BB RID: 230843 RVA: 0x00798800 File Offset: 0x00796A00
		public TVisualNovelPerformance[] GetEndPerformancesTypeArray()
		{
			int num = this.__p.__offset(106);
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

		// Token: 0x060385BC RID: 230844 RVA: 0x0079886C File Offset: 0x00796A6C
		public TTable? EndPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(108);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700EA89 RID: 60041
		// (get) Token: 0x060385BD RID: 230845 RVA: 0x007988B4 File Offset: 0x00796AB4
		public int EndPerformancesLength
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700EA8A RID: 60042
		// (get) Token: 0x060385BE RID: 230846 RVA: 0x007988E0 File Offset: 0x00796AE0
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060385BF RID: 230847 RVA: 0x00798920 File Offset: 0x00796B20
		public static Offset<ITalkItemVisualNovelNarration> CreateITalkItemVisualNovelNarration(FlatBufferBuilder builder, ETalkItemType Type = ETalkItemType.Talk, int Id = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, int WhoId = 0, int TextId = 0, StringOffset TidTalkOffset = default(StringOffset), float WaitTime = 0f, Offset<ICaptionParam> CaptionParamsOffset = default(Offset<ICaptionParam>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), Offset<IPlayMontage> MontageOffset = default(Offset<IPlayMontage>), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>), Offset<ISetFlowTemplate> FlowTemplateOffset = default(Offset<ISetFlowTemplate>), VectorOffset FlowTemplateListOffset = default(VectorOffset), VectorOffset ActorMontageArrayOffset = default(VectorOffset), VectorOffset ActorFaceExpressionArrayOffset = default(VectorOffset), VectorOffset ActorLookAtArrayOffset = default(VectorOffset), VectorOffset ActorTurnToArrayOffset = default(VectorOffset), TPostAkEvent TalkAkEvent_type = TPostAkEvent.NONE, int TalkAkEventOffset = 0, TPostAkEvent TalkEndAkEvent_type = TPostAkEvent.NONE, int TalkEndAkEventOffset = 0, Offset<IUniversalTone> UniversalToneOffset = default(Offset<IUniversalTone>), TTalkBackground BackgroundConfig_type = TTalkBackground.NONE, int BackgroundConfigOffset = 0, bool PlayVoice = false, Offset<ITimeLimitOptionGroup> TimeLimitOptionGroupOffset = default(Offset<ITimeLimitOptionGroup>), Offset<IGamepadShakeInTalk> GamepadShakeOffset = default(Offset<IGamepadShakeInTalk>), VectorOffset IntroActionsOffset = default(VectorOffset), VectorOffset ActorFxEmoteArrayOffset = default(VectorOffset), VectorOffset TalkEffectArray_typeOffset = default(VectorOffset), VectorOffset TalkEffectArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), EVisualNovelOptionInteractionType OptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect, TVisualNovelOptionGroupConfig OptionGroup_type = TVisualNovelOptionGroupConfig.NONE, int OptionGroupOffset = 0, float DialogDelay = 0f, bool ClickShowFull = false, TVisualNovelBackground VisualNovelBackgroundConfig_type = TVisualNovelBackground.NONE, int VisualNovelBackgroundConfigOffset = 0, TVisualNovelCg CgConfig_type = TVisualNovelCg.NONE, int CgConfigOffset = 0, TVisualNovelDisplayItem DisplayItemConfig_type = TVisualNovelDisplayItem.NONE, int DisplayItemConfigOffset = 0, int PlotKeyId = 0, VectorOffset StartPerformances_typeOffset = default(VectorOffset), VectorOffset StartPerformancesOffset = default(VectorOffset), VectorOffset EndPerformances_typeOffset = default(VectorOffset), VectorOffset EndPerformancesOffset = default(VectorOffset), uint NullMask = 0U)
		{
			builder.StartTable(54);
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
			ITalkItemVisualNovelNarration.AddOptionGroupType(builder, OptionGroup_type);
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

		// Token: 0x060385C0 RID: 230848 RVA: 0x00798AE8 File Offset: 0x00796CE8
		public static void StartITalkItemVisualNovelNarration(FlatBufferBuilder builder)
		{
			builder.StartTable(54);
		}

		// Token: 0x060385C1 RID: 230849 RVA: 0x00798AF2 File Offset: 0x00796CF2
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060385C2 RID: 230850 RVA: 0x00798AFD File Offset: 0x00796CFD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060385C3 RID: 230851 RVA: 0x00798B08 File Offset: 0x00796D08
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x060385C4 RID: 230852 RVA: 0x00798B13 File Offset: 0x00796D13
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x060385C5 RID: 230853 RVA: 0x00798B23 File Offset: 0x00796D23
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x060385C6 RID: 230854 RVA: 0x00798B33 File Offset: 0x00796D33
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x060385C7 RID: 230855 RVA: 0x00798B3E File Offset: 0x00796D3E
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x060385C8 RID: 230856 RVA: 0x00798B49 File Offset: 0x00796D49
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x060385C9 RID: 230857 RVA: 0x00798B54 File Offset: 0x00796D54
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x060385CA RID: 230858 RVA: 0x00798B5F File Offset: 0x00796D5F
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x060385CB RID: 230859 RVA: 0x00798B70 File Offset: 0x00796D70
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x060385CC RID: 230860 RVA: 0x00798B84 File Offset: 0x00796D84
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x060385CD RID: 230861 RVA: 0x00798B95 File Offset: 0x00796D95
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x060385CE RID: 230862 RVA: 0x00798BA8 File Offset: 0x00796DA8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060385CF RID: 230863 RVA: 0x00798BE8 File Offset: 0x00796DE8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385D0 RID: 230864 RVA: 0x00798C02 File Offset: 0x00796E02
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385D1 RID: 230865 RVA: 0x00798C20 File Offset: 0x00796E20
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060385D2 RID: 230866 RVA: 0x00798C39 File Offset: 0x00796E39
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060385D3 RID: 230867 RVA: 0x00798C44 File Offset: 0x00796E44
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x060385D4 RID: 230868 RVA: 0x00798C58 File Offset: 0x00796E58
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060385D5 RID: 230869 RVA: 0x00798C98 File Offset: 0x00796E98
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385D6 RID: 230870 RVA: 0x00798CB2 File Offset: 0x00796EB2
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385D7 RID: 230871 RVA: 0x00798CD0 File Offset: 0x00796ED0
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060385D8 RID: 230872 RVA: 0x00798CE9 File Offset: 0x00796EE9
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060385D9 RID: 230873 RVA: 0x00798CF4 File Offset: 0x00796EF4
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x060385DA RID: 230874 RVA: 0x00798D05 File Offset: 0x00796F05
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x060385DB RID: 230875 RVA: 0x00798D16 File Offset: 0x00796F16
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x060385DC RID: 230876 RVA: 0x00798D27 File Offset: 0x00796F27
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x060385DD RID: 230877 RVA: 0x00798D38 File Offset: 0x00796F38
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060385DE RID: 230878 RVA: 0x00798D78 File Offset: 0x00796F78
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385DF RID: 230879 RVA: 0x00798D92 File Offset: 0x00796F92
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385E0 RID: 230880 RVA: 0x00798DB0 File Offset: 0x00796FB0
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060385E1 RID: 230881 RVA: 0x00798DC9 File Offset: 0x00796FC9
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060385E2 RID: 230882 RVA: 0x00798DD4 File Offset: 0x00796FD4
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x060385E3 RID: 230883 RVA: 0x00798DE8 File Offset: 0x00796FE8
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060385E4 RID: 230884 RVA: 0x00798E28 File Offset: 0x00797028
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385E5 RID: 230885 RVA: 0x00798E42 File Offset: 0x00797042
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385E6 RID: 230886 RVA: 0x00798E60 File Offset: 0x00797060
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060385E7 RID: 230887 RVA: 0x00798E79 File Offset: 0x00797079
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060385E8 RID: 230888 RVA: 0x00798E84 File Offset: 0x00797084
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x060385E9 RID: 230889 RVA: 0x00798E98 File Offset: 0x00797098
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060385EA RID: 230890 RVA: 0x00798ED8 File Offset: 0x007970D8
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385EB RID: 230891 RVA: 0x00798EF2 File Offset: 0x007970F2
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385EC RID: 230892 RVA: 0x00798F10 File Offset: 0x00797110
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060385ED RID: 230893 RVA: 0x00798F29 File Offset: 0x00797129
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060385EE RID: 230894 RVA: 0x00798F34 File Offset: 0x00797134
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x060385EF RID: 230895 RVA: 0x00798F48 File Offset: 0x00797148
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060385F0 RID: 230896 RVA: 0x00798F88 File Offset: 0x00797188
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385F1 RID: 230897 RVA: 0x00798FA2 File Offset: 0x007971A2
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385F2 RID: 230898 RVA: 0x00798FC0 File Offset: 0x007971C0
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060385F3 RID: 230899 RVA: 0x00798FD9 File Offset: 0x007971D9
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060385F4 RID: 230900 RVA: 0x00798FE4 File Offset: 0x007971E4
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x060385F5 RID: 230901 RVA: 0x00798FF8 File Offset: 0x007971F8
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060385F6 RID: 230902 RVA: 0x00799038 File Offset: 0x00797238
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385F7 RID: 230903 RVA: 0x00799052 File Offset: 0x00797252
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060385F8 RID: 230904 RVA: 0x00799070 File Offset: 0x00797270
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060385F9 RID: 230905 RVA: 0x00799089 File Offset: 0x00797289
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060385FA RID: 230906 RVA: 0x00799094 File Offset: 0x00797294
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x060385FB RID: 230907 RVA: 0x007990A0 File Offset: 0x007972A0
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x060385FC RID: 230908 RVA: 0x007990AC File Offset: 0x007972AC
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x060385FD RID: 230909 RVA: 0x007990B8 File Offset: 0x007972B8
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x060385FE RID: 230910 RVA: 0x007990C4 File Offset: 0x007972C4
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x060385FF RID: 230911 RVA: 0x007990D5 File Offset: 0x007972D5
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x06038600 RID: 230912 RVA: 0x007990E1 File Offset: 0x007972E1
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x06038601 RID: 230913 RVA: 0x007990ED File Offset: 0x007972ED
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x06038602 RID: 230914 RVA: 0x007990F9 File Offset: 0x007972F9
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x06038603 RID: 230915 RVA: 0x0079910A File Offset: 0x0079730A
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x06038604 RID: 230916 RVA: 0x0079911B File Offset: 0x0079731B
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x06038605 RID: 230917 RVA: 0x0079912C File Offset: 0x0079732C
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038606 RID: 230918 RVA: 0x0079916C File Offset: 0x0079736C
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038607 RID: 230919 RVA: 0x00799186 File Offset: 0x00797386
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038608 RID: 230920 RVA: 0x007991A4 File Offset: 0x007973A4
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038609 RID: 230921 RVA: 0x007991BD File Offset: 0x007973BD
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603860A RID: 230922 RVA: 0x007991C8 File Offset: 0x007973C8
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x0603860B RID: 230923 RVA: 0x007991DC File Offset: 0x007973DC
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603860C RID: 230924 RVA: 0x0079921C File Offset: 0x0079741C
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603860D RID: 230925 RVA: 0x00799236 File Offset: 0x00797436
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603860E RID: 230926 RVA: 0x00799254 File Offset: 0x00797454
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603860F RID: 230927 RVA: 0x0079926D File Offset: 0x0079746D
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038610 RID: 230928 RVA: 0x00799278 File Offset: 0x00797478
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x06038611 RID: 230929 RVA: 0x0079928C File Offset: 0x0079748C
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038612 RID: 230930 RVA: 0x007992C3 File Offset: 0x007974C3
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06038613 RID: 230931 RVA: 0x007992DD File Offset: 0x007974DD
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x06038614 RID: 230932 RVA: 0x007992FB File Offset: 0x007974FB
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038615 RID: 230933 RVA: 0x00799314 File Offset: 0x00797514
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06038616 RID: 230934 RVA: 0x0079931F File Offset: 0x0079751F
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x06038617 RID: 230935 RVA: 0x00799330 File Offset: 0x00797530
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038618 RID: 230936 RVA: 0x00799367 File Offset: 0x00797567
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038619 RID: 230937 RVA: 0x00799381 File Offset: 0x00797581
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603861A RID: 230938 RVA: 0x0079939F File Offset: 0x0079759F
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603861B RID: 230939 RVA: 0x007993B8 File Offset: 0x007975B8
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603861C RID: 230940 RVA: 0x007993C3 File Offset: 0x007975C3
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x0603861D RID: 230941 RVA: 0x007993D4 File Offset: 0x007975D4
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603861E RID: 230942 RVA: 0x00799414 File Offset: 0x00797614
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603861F RID: 230943 RVA: 0x0079942E File Offset: 0x0079762E
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038620 RID: 230944 RVA: 0x0079944C File Offset: 0x0079764C
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038621 RID: 230945 RVA: 0x00799465 File Offset: 0x00797665
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038622 RID: 230946 RVA: 0x00799470 File Offset: 0x00797670
		public static void AddOptionInteractionType(FlatBufferBuilder builder, EVisualNovelOptionInteractionType optionInteractionType)
		{
			builder.AddByte(37, (byte)optionInteractionType, 0);
		}

		// Token: 0x06038623 RID: 230947 RVA: 0x0079947C File Offset: 0x0079767C
		public static void AddOptionGroupType(FlatBufferBuilder builder, TVisualNovelOptionGroupConfig optionGroupType)
		{
			builder.AddByte(38, (byte)optionGroupType, 0);
		}

		// Token: 0x06038624 RID: 230948 RVA: 0x00799488 File Offset: 0x00797688
		public static void AddOptionGroup(FlatBufferBuilder builder, int optionGroupOffset)
		{
			builder.AddOffset(39, optionGroupOffset, 0);
		}

		// Token: 0x06038625 RID: 230949 RVA: 0x00799494 File Offset: 0x00797694
		public static void AddDialogDelay(FlatBufferBuilder builder, float dialogDelay)
		{
			builder.AddFloat(40, dialogDelay, 0.0);
		}

		// Token: 0x06038626 RID: 230950 RVA: 0x007994A8 File Offset: 0x007976A8
		public static void AddClickShowFull(FlatBufferBuilder builder, bool clickShowFull)
		{
			builder.AddBool(41, clickShowFull, false);
		}

		// Token: 0x06038627 RID: 230951 RVA: 0x007994B4 File Offset: 0x007976B4
		public static void AddVisualNovelBackgroundConfigType(FlatBufferBuilder builder, TVisualNovelBackground visualNovelBackgroundConfigType)
		{
			builder.AddByte(42, (byte)visualNovelBackgroundConfigType, 0);
		}

		// Token: 0x06038628 RID: 230952 RVA: 0x007994C0 File Offset: 0x007976C0
		public static void AddVisualNovelBackgroundConfig(FlatBufferBuilder builder, int visualNovelBackgroundConfigOffset)
		{
			builder.AddOffset(43, visualNovelBackgroundConfigOffset, 0);
		}

		// Token: 0x06038629 RID: 230953 RVA: 0x007994CC File Offset: 0x007976CC
		public static void AddCgConfigType(FlatBufferBuilder builder, TVisualNovelCg cgConfigType)
		{
			builder.AddByte(44, (byte)cgConfigType, 0);
		}

		// Token: 0x0603862A RID: 230954 RVA: 0x007994D8 File Offset: 0x007976D8
		public static void AddCgConfig(FlatBufferBuilder builder, int cgConfigOffset)
		{
			builder.AddOffset(45, cgConfigOffset, 0);
		}

		// Token: 0x0603862B RID: 230955 RVA: 0x007994E4 File Offset: 0x007976E4
		public static void AddDisplayItemConfigType(FlatBufferBuilder builder, TVisualNovelDisplayItem displayItemConfigType)
		{
			builder.AddByte(46, (byte)displayItemConfigType, 0);
		}

		// Token: 0x0603862C RID: 230956 RVA: 0x007994F0 File Offset: 0x007976F0
		public static void AddDisplayItemConfig(FlatBufferBuilder builder, int displayItemConfigOffset)
		{
			builder.AddOffset(47, displayItemConfigOffset, 0);
		}

		// Token: 0x0603862D RID: 230957 RVA: 0x007994FC File Offset: 0x007976FC
		public static void AddPlotKeyId(FlatBufferBuilder builder, int plotKeyId)
		{
			builder.AddInt(48, plotKeyId, 0);
		}

		// Token: 0x0603862E RID: 230958 RVA: 0x00799508 File Offset: 0x00797708
		public static void AddStartPerformancesType(FlatBufferBuilder builder, VectorOffset startPerformancesTypeOffset)
		{
			builder.AddOffset(49, startPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x0603862F RID: 230959 RVA: 0x0079951C File Offset: 0x0079771C
		public static VectorOffset CreateStartPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038630 RID: 230960 RVA: 0x00799553 File Offset: 0x00797753
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06038631 RID: 230961 RVA: 0x0079956D File Offset: 0x0079776D
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x06038632 RID: 230962 RVA: 0x0079958B File Offset: 0x0079778B
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038633 RID: 230963 RVA: 0x007995A4 File Offset: 0x007977A4
		public static void StartStartPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06038634 RID: 230964 RVA: 0x007995AF File Offset: 0x007977AF
		public static void AddStartPerformances(FlatBufferBuilder builder, VectorOffset startPerformancesOffset)
		{
			builder.AddOffset(50, startPerformancesOffset.Value, 0);
		}

		// Token: 0x06038635 RID: 230965 RVA: 0x007995C0 File Offset: 0x007977C0
		public static VectorOffset CreateStartPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038636 RID: 230966 RVA: 0x007995F7 File Offset: 0x007977F7
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038637 RID: 230967 RVA: 0x00799611 File Offset: 0x00797811
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038638 RID: 230968 RVA: 0x0079962F File Offset: 0x0079782F
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038639 RID: 230969 RVA: 0x00799648 File Offset: 0x00797848
		public static void StartStartPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603863A RID: 230970 RVA: 0x00799653 File Offset: 0x00797853
		public static void AddEndPerformancesType(FlatBufferBuilder builder, VectorOffset endPerformancesTypeOffset)
		{
			builder.AddOffset(51, endPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x0603863B RID: 230971 RVA: 0x00799664 File Offset: 0x00797864
		public static VectorOffset CreateEndPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603863C RID: 230972 RVA: 0x0079969B File Offset: 0x0079789B
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x0603863D RID: 230973 RVA: 0x007996B5 File Offset: 0x007978B5
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x0603863E RID: 230974 RVA: 0x007996D3 File Offset: 0x007978D3
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603863F RID: 230975 RVA: 0x007996EC File Offset: 0x007978EC
		public static void StartEndPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06038640 RID: 230976 RVA: 0x007996F7 File Offset: 0x007978F7
		public static void AddEndPerformances(FlatBufferBuilder builder, VectorOffset endPerformancesOffset)
		{
			builder.AddOffset(52, endPerformancesOffset.Value, 0);
		}

		// Token: 0x06038641 RID: 230977 RVA: 0x00799708 File Offset: 0x00797908
		public static VectorOffset CreateEndPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038642 RID: 230978 RVA: 0x0079973F File Offset: 0x0079793F
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038643 RID: 230979 RVA: 0x00799759 File Offset: 0x00797959
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038644 RID: 230980 RVA: 0x00799777 File Offset: 0x00797977
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038645 RID: 230981 RVA: 0x00799790 File Offset: 0x00797990
		public static void StartEndPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038646 RID: 230982 RVA: 0x0079979B File Offset: 0x0079799B
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(53, nullMask, 0U);
		}

		// Token: 0x06038647 RID: 230983 RVA: 0x007997A7 File Offset: 0x007979A7
		public static Offset<ITalkItemVisualNovelNarration> EndITalkItemVisualNovelNarration(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemVisualNovelNarration>(builder.EndTable());
		}

		// Token: 0x06038648 RID: 230984 RVA: 0x007997B4 File Offset: 0x007979B4
		public ITalkItemVisualNovelNarrationT UnPack()
		{
			ITalkItemVisualNovelNarrationT talkItemVisualNovelNarrationT = new ITalkItemVisualNovelNarrationT();
			this.UnPackTo(talkItemVisualNovelNarrationT);
			return talkItemVisualNovelNarrationT;
		}

		// Token: 0x06038649 RID: 230985 RVA: 0x007997D0 File Offset: 0x007979D0
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

		// Token: 0x0603864A RID: 230986 RVA: 0x0079ADC8 File Offset: 0x00798FC8
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
			return ITalkItemVisualNovelNarration.CreateITalkItemVisualNovelNarration(builder, _o.Type, _o.Id, _o.PlotLineId, plotLineKeyOffset, nameOffset, _o._Folded, _o._EditFlag, _o.WhoId, _o.TextId, tidTalkOffset, _o.WaitTime, captionParamsOffset, actionsOffset, optionsOffset, montageOffset, cameraDataOffset, flowTemplateOffset, flowTemplateListOffset, actorMontageArrayOffset, actorFaceExpressionArrayOffset, actorLookAtArrayOffset, actorTurnToArrayOffset, talkAkEvent_type, talkAkEventOffset, talkEndAkEvent_type, talkEndAkEventOffset, universalToneOffset, backgroundConfig_type, backgroundConfigOffset, _o.PlayVoice, timeLimitOptionGroupOffset, gamepadShakeOffset, introActionsOffset, actorFxEmoteArrayOffset, talkEffectArray_typeOffset, talkEffectArrayOffset, actorVisibilityArrayOffset, _o.OptionInteractionType, optionGroup_type, optionGroupOffset, _o.DialogDelay, _o.ClickShowFull, visualNovelBackgroundConfig_type, visualNovelBackgroundConfigOffset, cgConfig_type, cgConfigOffset, displayItemConfig_type, displayItemConfigOffset, _o.PlotKeyId, startPerformances_typeOffset, startPerformancesOffset, endPerformances_typeOffset, endPerformancesOffset, _o.NullMask);
		}

		// Token: 0x0401303A RID: 77882
		private Table __p;
	}
}
