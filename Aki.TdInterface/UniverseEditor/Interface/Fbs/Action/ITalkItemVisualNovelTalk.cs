using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007319 RID: 29465
	public struct ITalkItemVisualNovelTalk : IFlatbufferObject
	{
		// Token: 0x1700DF67 RID: 57191
		// (get) Token: 0x060355EE RID: 218606 RVA: 0x0074334A File Offset: 0x0074154A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060355EF RID: 218607 RVA: 0x00743357 File Offset: 0x00741557
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060355F0 RID: 218608 RVA: 0x00743360 File Offset: 0x00741560
		public static ITalkItemVisualNovelTalk GetRootAsITalkItemVisualNovelTalk(ByteBuffer _bb)
		{
			return ITalkItemVisualNovelTalk.GetRootAsITalkItemVisualNovelTalk(_bb, default(ITalkItemVisualNovelTalk));
		}

		// Token: 0x060355F1 RID: 218609 RVA: 0x0074337C File Offset: 0x0074157C
		public static ITalkItemVisualNovelTalk GetRootAsITalkItemVisualNovelTalk(ByteBuffer _bb, ITalkItemVisualNovelTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060355F2 RID: 218610 RVA: 0x00743399 File Offset: 0x00741599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060355F3 RID: 218611 RVA: 0x007433A8 File Offset: 0x007415A8
		public ITalkItemVisualNovelTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF68 RID: 57192
		// (get) Token: 0x060355F4 RID: 218612 RVA: 0x007433B8 File Offset: 0x007415B8
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

		// Token: 0x1700DF69 RID: 57193
		// (get) Token: 0x060355F5 RID: 218613 RVA: 0x007433F4 File Offset: 0x007415F4
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

		// Token: 0x1700DF6A RID: 57194
		// (get) Token: 0x060355F6 RID: 218614 RVA: 0x00743430 File Offset: 0x00741630
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

		// Token: 0x1700DF6B RID: 57195
		// (get) Token: 0x060355F7 RID: 218615 RVA: 0x0074346C File Offset: 0x0074166C
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

		// Token: 0x060355F8 RID: 218616 RVA: 0x007434A4 File Offset: 0x007416A4
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060355F9 RID: 218617 RVA: 0x007434B4 File Offset: 0x007416B4
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DF6C RID: 57196
		// (get) Token: 0x060355FA RID: 218618 RVA: 0x007434C4 File Offset: 0x007416C4
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

		// Token: 0x060355FB RID: 218619 RVA: 0x007434FC File Offset: 0x007416FC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060355FC RID: 218620 RVA: 0x0074350C File Offset: 0x0074170C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700DF6D RID: 57197
		// (get) Token: 0x060355FD RID: 218621 RVA: 0x0074351C File Offset: 0x0074171C
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF6E RID: 57198
		// (get) Token: 0x060355FE RID: 218622 RVA: 0x0074355C File Offset: 0x0074175C
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

		// Token: 0x1700DF6F RID: 57199
		// (get) Token: 0x060355FF RID: 218623 RVA: 0x0074359C File Offset: 0x0074179C
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

		// Token: 0x1700DF70 RID: 57200
		// (get) Token: 0x06035600 RID: 218624 RVA: 0x007435DC File Offset: 0x007417DC
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

		// Token: 0x1700DF71 RID: 57201
		// (get) Token: 0x06035601 RID: 218625 RVA: 0x0074361C File Offset: 0x0074181C
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

		// Token: 0x06035602 RID: 218626 RVA: 0x00743654 File Offset: 0x00741854
		public Span<byte> GetTidTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06035603 RID: 218627 RVA: 0x00743664 File Offset: 0x00741864
		public byte[] GetTidTalkArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x1700DF72 RID: 57202
		// (get) Token: 0x06035604 RID: 218628 RVA: 0x00743674 File Offset: 0x00741874
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

		// Token: 0x1700DF73 RID: 57203
		// (get) Token: 0x06035605 RID: 218629 RVA: 0x007436B8 File Offset: 0x007418B8
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

		// Token: 0x06035606 RID: 218630 RVA: 0x00743718 File Offset: 0x00741918
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF74 RID: 57204
		// (get) Token: 0x06035607 RID: 218631 RVA: 0x0074377C File Offset: 0x0074197C
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

		// Token: 0x06035608 RID: 218632 RVA: 0x007437A8 File Offset: 0x007419A8
		public ITalkOption? Options(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new ITalkOption?(default(ITalkOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF75 RID: 57205
		// (get) Token: 0x06035609 RID: 218633 RVA: 0x0074380C File Offset: 0x00741A0C
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

		// Token: 0x1700DF76 RID: 57206
		// (get) Token: 0x0603560A RID: 218634 RVA: 0x00743838 File Offset: 0x00741A38
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

		// Token: 0x1700DF77 RID: 57207
		// (get) Token: 0x0603560B RID: 218635 RVA: 0x00743898 File Offset: 0x00741A98
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

		// Token: 0x1700DF78 RID: 57208
		// (get) Token: 0x0603560C RID: 218636 RVA: 0x007438F8 File Offset: 0x00741AF8
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

		// Token: 0x0603560D RID: 218637 RVA: 0x00743958 File Offset: 0x00741B58
		public ISetFlowTemplate? FlowTemplateList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new ISetFlowTemplate?(default(ISetFlowTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF79 RID: 57209
		// (get) Token: 0x0603560E RID: 218638 RVA: 0x007439BC File Offset: 0x00741BBC
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

		// Token: 0x0603560F RID: 218639 RVA: 0x007439E8 File Offset: 0x00741BE8
		public IMontageData? ActorMontageArray(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new IMontageData?(default(IMontageData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF7A RID: 57210
		// (get) Token: 0x06035610 RID: 218640 RVA: 0x00743A4C File Offset: 0x00741C4C
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

		// Token: 0x06035611 RID: 218641 RVA: 0x00743A78 File Offset: 0x00741C78
		public IActorFaceExpression? ActorFaceExpressionArray(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new IActorFaceExpression?(default(IActorFaceExpression).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF7B RID: 57211
		// (get) Token: 0x06035612 RID: 218642 RVA: 0x00743ADC File Offset: 0x00741CDC
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

		// Token: 0x06035613 RID: 218643 RVA: 0x00743B08 File Offset: 0x00741D08
		public IActorLookAt? ActorLookAtArray(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new IActorLookAt?(default(IActorLookAt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF7C RID: 57212
		// (get) Token: 0x06035614 RID: 218644 RVA: 0x00743B6C File Offset: 0x00741D6C
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

		// Token: 0x06035615 RID: 218645 RVA: 0x00743B98 File Offset: 0x00741D98
		public IActorTurnTo? ActorTurnToArray(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new IActorTurnTo?(default(IActorTurnTo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF7D RID: 57213
		// (get) Token: 0x06035616 RID: 218646 RVA: 0x00743BFC File Offset: 0x00741DFC
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

		// Token: 0x1700DF7E RID: 57214
		// (get) Token: 0x06035617 RID: 218647 RVA: 0x00743C28 File Offset: 0x00741E28
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

		// Token: 0x06035618 RID: 218648 RVA: 0x00743C68 File Offset: 0x00741E68
		public TTable? TalkAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035619 RID: 218649 RVA: 0x00743CB0 File Offset: 0x00741EB0
		public IPostAkEventGlobal TalkAkEventAsIPostAkEventGlobal()
		{
			return this.TalkAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x0603561A RID: 218650 RVA: 0x00743CCC File Offset: 0x00741ECC
		public IPostAkEventMap TalkAkEventAsIPostAkEventMap()
		{
			return this.TalkAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x0603561B RID: 218651 RVA: 0x00743CE8 File Offset: 0x00741EE8
		public IPostAkEventMusicSubtitle TalkAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x0603561C RID: 218652 RVA: 0x00743D04 File Offset: 0x00741F04
		public IPostAkEventTargeted TalkAkEventAsIPostAkEventTargeted()
		{
			return this.TalkAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DF7F RID: 57215
		// (get) Token: 0x0603561D RID: 218653 RVA: 0x00743D20 File Offset: 0x00741F20
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

		// Token: 0x0603561E RID: 218654 RVA: 0x00743D60 File Offset: 0x00741F60
		public TTable? TalkEndAkEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603561F RID: 218655 RVA: 0x00743DA8 File Offset: 0x00741FA8
		public IPostAkEventGlobal TalkEndAkEventAsIPostAkEventGlobal()
		{
			return this.TalkEndAkEvent<IPostAkEventGlobal>().Value;
		}

		// Token: 0x06035620 RID: 218656 RVA: 0x00743DC4 File Offset: 0x00741FC4
		public IPostAkEventMap TalkEndAkEventAsIPostAkEventMap()
		{
			return this.TalkEndAkEvent<IPostAkEventMap>().Value;
		}

		// Token: 0x06035621 RID: 218657 RVA: 0x00743DE0 File Offset: 0x00741FE0
		public IPostAkEventMusicSubtitle TalkEndAkEventAsIPostAkEventMusicSubtitle()
		{
			return this.TalkEndAkEvent<IPostAkEventMusicSubtitle>().Value;
		}

		// Token: 0x06035622 RID: 218658 RVA: 0x00743DFC File Offset: 0x00741FFC
		public IPostAkEventTargeted TalkEndAkEventAsIPostAkEventTargeted()
		{
			return this.TalkEndAkEvent<IPostAkEventTargeted>().Value;
		}

		// Token: 0x1700DF80 RID: 57216
		// (get) Token: 0x06035623 RID: 218659 RVA: 0x00743E18 File Offset: 0x00742018
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

		// Token: 0x1700DF81 RID: 57217
		// (get) Token: 0x06035624 RID: 218660 RVA: 0x00743E78 File Offset: 0x00742078
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

		// Token: 0x06035625 RID: 218661 RVA: 0x00743EB8 File Offset: 0x007420B8
		public TTable? BackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035626 RID: 218662 RVA: 0x00743F00 File Offset: 0x00742100
		public ITalkBackgroundClean BackgroundConfigAsITalkBackgroundClean()
		{
			return this.BackgroundConfig<ITalkBackgroundClean>().Value;
		}

		// Token: 0x06035627 RID: 218663 RVA: 0x00743F1C File Offset: 0x0074211C
		public ITalkBackgroundIcon BackgroundConfigAsITalkBackgroundIcon()
		{
			return this.BackgroundConfig<ITalkBackgroundIcon>().Value;
		}

		// Token: 0x06035628 RID: 218664 RVA: 0x00743F38 File Offset: 0x00742138
		public ITalkBackgroundImage BackgroundConfigAsITalkBackgroundImage()
		{
			return this.BackgroundConfig<ITalkBackgroundImage>().Value;
		}

		// Token: 0x06035629 RID: 218665 RVA: 0x00743F54 File Offset: 0x00742154
		public ITalkBackgroundImageByMcGender BackgroundConfigAsITalkBackgroundImageByMcGender()
		{
			return this.BackgroundConfig<ITalkBackgroundImageByMcGender>().Value;
		}

		// Token: 0x0603562A RID: 218666 RVA: 0x00743F70 File Offset: 0x00742170
		public ITalkBackgroundSpineImage BackgroundConfigAsITalkBackgroundSpineImage()
		{
			return this.BackgroundConfig<ITalkBackgroundSpineImage>().Value;
		}

		// Token: 0x1700DF82 RID: 57218
		// (get) Token: 0x0603562B RID: 218667 RVA: 0x00743F8C File Offset: 0x0074218C
		public bool PlayVoice
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF83 RID: 57219
		// (get) Token: 0x0603562C RID: 218668 RVA: 0x00743FCC File Offset: 0x007421CC
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

		// Token: 0x1700DF84 RID: 57220
		// (get) Token: 0x0603562D RID: 218669 RVA: 0x0074402C File Offset: 0x0074222C
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

		// Token: 0x0603562E RID: 218670 RVA: 0x0074408C File Offset: 0x0074228C
		public IActionInfo? IntroActions(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF85 RID: 57221
		// (get) Token: 0x0603562F RID: 218671 RVA: 0x007440F0 File Offset: 0x007422F0
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

		// Token: 0x06035630 RID: 218672 RVA: 0x0074411C File Offset: 0x0074231C
		public IActorFxEmote? ActorFxEmoteArray(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new IActorFxEmote?(default(IActorFxEmote).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF86 RID: 57222
		// (get) Token: 0x06035631 RID: 218673 RVA: 0x00744180 File Offset: 0x00742380
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

		// Token: 0x06035632 RID: 218674 RVA: 0x007441AC File Offset: 0x007423AC
		public TTalkEffectAction TalkEffectArrayType(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return TTalkEffectAction.NONE;
			}
			return (TTalkEffectAction)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DF87 RID: 57223
		// (get) Token: 0x06035633 RID: 218675 RVA: 0x007441EC File Offset: 0x007423EC
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

		// Token: 0x06035634 RID: 218676 RVA: 0x00744218 File Offset: 0x00742418
		public Span<TTalkEffectAction> GetTalkEffectArrayTypeBytes()
		{
			return this.__p.__vector_as_span<TTalkEffectAction>(72, 1);
		}

		// Token: 0x06035635 RID: 218677 RVA: 0x00744228 File Offset: 0x00742428
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

		// Token: 0x06035636 RID: 218678 RVA: 0x00744294 File Offset: 0x00742494
		public TTable? TalkEffectArray<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DF88 RID: 57224
		// (get) Token: 0x06035637 RID: 218679 RVA: 0x007442DC File Offset: 0x007424DC
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

		// Token: 0x06035638 RID: 218680 RVA: 0x00744308 File Offset: 0x00742508
		public IActorVisibility? ActorVisibilityArray(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return null;
			}
			return new IActorVisibility?(default(IActorVisibility).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DF89 RID: 57225
		// (get) Token: 0x06035639 RID: 218681 RVA: 0x0074436C File Offset: 0x0074256C
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

		// Token: 0x1700DF8A RID: 57226
		// (get) Token: 0x0603563A RID: 218682 RVA: 0x00744398 File Offset: 0x00742598
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

		// Token: 0x1700DF8B RID: 57227
		// (get) Token: 0x0603563B RID: 218683 RVA: 0x007443D8 File Offset: 0x007425D8
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

		// Token: 0x1700DF8C RID: 57228
		// (get) Token: 0x0603563C RID: 218684 RVA: 0x00744438 File Offset: 0x00742638
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

		// Token: 0x1700DF8D RID: 57229
		// (get) Token: 0x0603563D RID: 218685 RVA: 0x0074447C File Offset: 0x0074267C
		public bool ClickShowFull
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DF8E RID: 57230
		// (get) Token: 0x0603563E RID: 218686 RVA: 0x007444BC File Offset: 0x007426BC
		public string Interjection
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603563F RID: 218687 RVA: 0x007444F4 File Offset: 0x007426F4
		public Span<byte> GetInterjectionBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x06035640 RID: 218688 RVA: 0x00744504 File Offset: 0x00742704
		public byte[] GetInterjectionArray()
		{
			return this.__p.__vector_as_array<byte>(86);
		}

		// Token: 0x1700DF8F RID: 57231
		// (get) Token: 0x06035641 RID: 218689 RVA: 0x00744514 File Offset: 0x00742714
		public IVisualNovelPortraitTransform? Transform
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelPortraitTransform?(default(IVisualNovelPortraitTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DF90 RID: 57232
		// (get) Token: 0x06035642 RID: 218690 RVA: 0x00744574 File Offset: 0x00742774
		public IVisualNovelRoleConfig? RoleConfig
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelRoleConfig?(default(IVisualNovelRoleConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DF91 RID: 57233
		// (get) Token: 0x06035643 RID: 218691 RVA: 0x007445D4 File Offset: 0x007427D4
		public TVisualNovelBackground VisualNovelBackgroundConfigType
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return TVisualNovelBackground.NONE;
				}
				return (TVisualNovelBackground)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035644 RID: 218692 RVA: 0x00744614 File Offset: 0x00742814
		public TTable? VisualNovelBackgroundConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(94);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035645 RID: 218693 RVA: 0x0074465C File Offset: 0x0074285C
		public IVisualNovelBackgroundClean VisualNovelBackgroundConfigAsIVisualNovelBackgroundClean()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundClean>().Value;
		}

		// Token: 0x06035646 RID: 218694 RVA: 0x00744678 File Offset: 0x00742878
		public IVisualNovelBackgroundLoad VisualNovelBackgroundConfigAsIVisualNovelBackgroundLoad()
		{
			return this.VisualNovelBackgroundConfig<IVisualNovelBackgroundLoad>().Value;
		}

		// Token: 0x1700DF92 RID: 57234
		// (get) Token: 0x06035647 RID: 218695 RVA: 0x00744694 File Offset: 0x00742894
		public TVisualNovelCg CgConfigType
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return TVisualNovelCg.NONE;
				}
				return (TVisualNovelCg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035648 RID: 218696 RVA: 0x007446D4 File Offset: 0x007428D4
		public TTable? CgConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(98);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035649 RID: 218697 RVA: 0x0074471C File Offset: 0x0074291C
		public IVisualNovelCgClean CgConfigAsIVisualNovelCgClean()
		{
			return this.CgConfig<IVisualNovelCgClean>().Value;
		}

		// Token: 0x0603564A RID: 218698 RVA: 0x00744738 File Offset: 0x00742938
		public IVisualNovelCgLoadImage CgConfigAsIVisualNovelCgLoadImage()
		{
			return this.CgConfig<IVisualNovelCgLoadImage>().Value;
		}

		// Token: 0x0603564B RID: 218699 RVA: 0x00744754 File Offset: 0x00742954
		public IVisualNovelCgLoadSpine CgConfigAsIVisualNovelCgLoadSpine()
		{
			return this.CgConfig<IVisualNovelCgLoadSpine>().Value;
		}

		// Token: 0x1700DF93 RID: 57235
		// (get) Token: 0x0603564C RID: 218700 RVA: 0x00744770 File Offset: 0x00742970
		public TVisualNovelDisplayItem DisplayItemConfigType
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return TVisualNovelDisplayItem.NONE;
				}
				return (TVisualNovelDisplayItem)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603564D RID: 218701 RVA: 0x007447B0 File Offset: 0x007429B0
		public TTable? DisplayItemConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(102);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603564E RID: 218702 RVA: 0x007447F8 File Offset: 0x007429F8
		public IVisualNovelDisplayItemClose DisplayItemConfigAsIVisualNovelDisplayItemClose()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemClose>().Value;
		}

		// Token: 0x0603564F RID: 218703 RVA: 0x00744814 File Offset: 0x00742A14
		public IVisualNovelDisplayItemImage DisplayItemConfigAsIVisualNovelDisplayItemImage()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemImage>().Value;
		}

		// Token: 0x06035650 RID: 218704 RVA: 0x00744830 File Offset: 0x00742A30
		public IVisualNovelDisplayItemPrefab DisplayItemConfigAsIVisualNovelDisplayItemPrefab()
		{
			return this.DisplayItemConfig<IVisualNovelDisplayItemPrefab>().Value;
		}

		// Token: 0x1700DF94 RID: 57236
		// (get) Token: 0x06035651 RID: 218705 RVA: 0x0074484C File Offset: 0x00742A4C
		public int PlotKeyId
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035652 RID: 218706 RVA: 0x0074488C File Offset: 0x00742A8C
		public TVisualNovelPerformance StartPerformancesType(int j)
		{
			int num = this.__p.__offset(106);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DF95 RID: 57237
		// (get) Token: 0x06035653 RID: 218707 RVA: 0x007448CC File Offset: 0x00742ACC
		public int StartPerformancesTypeLength
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

		// Token: 0x06035654 RID: 218708 RVA: 0x007448F8 File Offset: 0x00742AF8
		public Span<TVisualNovelPerformance> GetStartPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(106, 1);
		}

		// Token: 0x06035655 RID: 218709 RVA: 0x00744908 File Offset: 0x00742B08
		public TVisualNovelPerformance[] GetStartPerformancesTypeArray()
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

		// Token: 0x06035656 RID: 218710 RVA: 0x00744974 File Offset: 0x00742B74
		public TTable? StartPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(108);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DF96 RID: 57238
		// (get) Token: 0x06035657 RID: 218711 RVA: 0x007449BC File Offset: 0x00742BBC
		public int StartPerformancesLength
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

		// Token: 0x06035658 RID: 218712 RVA: 0x007449E8 File Offset: 0x00742BE8
		public TVisualNovelPerformance EndPerformancesType(int j)
		{
			int num = this.__p.__offset(110);
			if (num == 0)
			{
				return TVisualNovelPerformance.NONE;
			}
			return (TVisualNovelPerformance)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700DF97 RID: 57239
		// (get) Token: 0x06035659 RID: 218713 RVA: 0x00744A28 File Offset: 0x00742C28
		public int EndPerformancesTypeLength
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0603565A RID: 218714 RVA: 0x00744A54 File Offset: 0x00742C54
		public Span<TVisualNovelPerformance> GetEndPerformancesTypeBytes()
		{
			return this.__p.__vector_as_span<TVisualNovelPerformance>(110, 1);
		}

		// Token: 0x0603565B RID: 218715 RVA: 0x00744A64 File Offset: 0x00742C64
		public TVisualNovelPerformance[] GetEndPerformancesTypeArray()
		{
			int num = this.__p.__offset(110);
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

		// Token: 0x0603565C RID: 218716 RVA: 0x00744AD0 File Offset: 0x00742CD0
		public TTable? EndPerformances<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(112);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700DF98 RID: 57240
		// (get) Token: 0x0603565D RID: 218717 RVA: 0x00744B18 File Offset: 0x00742D18
		public int EndPerformancesLength
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DF99 RID: 57241
		// (get) Token: 0x0603565E RID: 218718 RVA: 0x00744B44 File Offset: 0x00742D44
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603565F RID: 218719 RVA: 0x00744B84 File Offset: 0x00742D84
		public static Offset<ITalkItemVisualNovelTalk> CreateITalkItemVisualNovelTalk(FlatBufferBuilder builder, ETalkItemType Type = ETalkItemType.Talk, int Id = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, int WhoId = 0, int TextId = 0, StringOffset TidTalkOffset = default(StringOffset), float WaitTime = 0f, Offset<ICaptionParam> CaptionParamsOffset = default(Offset<ICaptionParam>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset OptionsOffset = default(VectorOffset), Offset<IPlayMontage> MontageOffset = default(Offset<IPlayMontage>), Offset<ICameraData> CameraDataOffset = default(Offset<ICameraData>), Offset<ISetFlowTemplate> FlowTemplateOffset = default(Offset<ISetFlowTemplate>), VectorOffset FlowTemplateListOffset = default(VectorOffset), VectorOffset ActorMontageArrayOffset = default(VectorOffset), VectorOffset ActorFaceExpressionArrayOffset = default(VectorOffset), VectorOffset ActorLookAtArrayOffset = default(VectorOffset), VectorOffset ActorTurnToArrayOffset = default(VectorOffset), TPostAkEvent TalkAkEvent_type = TPostAkEvent.NONE, int TalkAkEventOffset = 0, TPostAkEvent TalkEndAkEvent_type = TPostAkEvent.NONE, int TalkEndAkEventOffset = 0, Offset<IUniversalTone> UniversalToneOffset = default(Offset<IUniversalTone>), TTalkBackground BackgroundConfig_type = TTalkBackground.NONE, int BackgroundConfigOffset = 0, bool PlayVoice = false, Offset<ITimeLimitOptionGroup> TimeLimitOptionGroupOffset = default(Offset<ITimeLimitOptionGroup>), Offset<IGamepadShakeInTalk> GamepadShakeOffset = default(Offset<IGamepadShakeInTalk>), VectorOffset IntroActionsOffset = default(VectorOffset), VectorOffset ActorFxEmoteArrayOffset = default(VectorOffset), VectorOffset TalkEffectArray_typeOffset = default(VectorOffset), VectorOffset TalkEffectArrayOffset = default(VectorOffset), VectorOffset ActorVisibilityArrayOffset = default(VectorOffset), EVisualNovelOptionInteractionType OptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect, Offset<IVisualNovelOptionGroupSolarSchoolExam> OptionGroupOffset = default(Offset<IVisualNovelOptionGroupSolarSchoolExam>), float DialogDelay = 0f, bool ClickShowFull = false, StringOffset InterjectionOffset = default(StringOffset), Offset<IVisualNovelPortraitTransform> TransformOffset = default(Offset<IVisualNovelPortraitTransform>), Offset<IVisualNovelRoleConfig> RoleConfigOffset = default(Offset<IVisualNovelRoleConfig>), TVisualNovelBackground VisualNovelBackgroundConfig_type = TVisualNovelBackground.NONE, int VisualNovelBackgroundConfigOffset = 0, TVisualNovelCg CgConfig_type = TVisualNovelCg.NONE, int CgConfigOffset = 0, TVisualNovelDisplayItem DisplayItemConfig_type = TVisualNovelDisplayItem.NONE, int DisplayItemConfigOffset = 0, int PlotKeyId = 0, VectorOffset StartPerformances_typeOffset = default(VectorOffset), VectorOffset StartPerformancesOffset = default(VectorOffset), VectorOffset EndPerformances_typeOffset = default(VectorOffset), VectorOffset EndPerformancesOffset = default(VectorOffset), uint NullMask = 0U)
		{
			builder.StartTable(56);
			ITalkItemVisualNovelTalk.AddNullMask(builder, NullMask);
			ITalkItemVisualNovelTalk.AddEndPerformances(builder, EndPerformancesOffset);
			ITalkItemVisualNovelTalk.AddEndPerformancesType(builder, EndPerformances_typeOffset);
			ITalkItemVisualNovelTalk.AddStartPerformances(builder, StartPerformancesOffset);
			ITalkItemVisualNovelTalk.AddStartPerformancesType(builder, StartPerformances_typeOffset);
			ITalkItemVisualNovelTalk.AddPlotKeyId(builder, PlotKeyId);
			ITalkItemVisualNovelTalk.AddDisplayItemConfig(builder, DisplayItemConfigOffset);
			ITalkItemVisualNovelTalk.AddCgConfig(builder, CgConfigOffset);
			ITalkItemVisualNovelTalk.AddVisualNovelBackgroundConfig(builder, VisualNovelBackgroundConfigOffset);
			ITalkItemVisualNovelTalk.AddRoleConfig(builder, RoleConfigOffset);
			ITalkItemVisualNovelTalk.AddTransform(builder, TransformOffset);
			ITalkItemVisualNovelTalk.AddInterjection(builder, InterjectionOffset);
			ITalkItemVisualNovelTalk.AddDialogDelay(builder, DialogDelay);
			ITalkItemVisualNovelTalk.AddOptionGroup(builder, OptionGroupOffset);
			ITalkItemVisualNovelTalk.AddActorVisibilityArray(builder, ActorVisibilityArrayOffset);
			ITalkItemVisualNovelTalk.AddTalkEffectArray(builder, TalkEffectArrayOffset);
			ITalkItemVisualNovelTalk.AddTalkEffectArrayType(builder, TalkEffectArray_typeOffset);
			ITalkItemVisualNovelTalk.AddActorFxEmoteArray(builder, ActorFxEmoteArrayOffset);
			ITalkItemVisualNovelTalk.AddIntroActions(builder, IntroActionsOffset);
			ITalkItemVisualNovelTalk.AddGamepadShake(builder, GamepadShakeOffset);
			ITalkItemVisualNovelTalk.AddTimeLimitOptionGroup(builder, TimeLimitOptionGroupOffset);
			ITalkItemVisualNovelTalk.AddBackgroundConfig(builder, BackgroundConfigOffset);
			ITalkItemVisualNovelTalk.AddUniversalTone(builder, UniversalToneOffset);
			ITalkItemVisualNovelTalk.AddTalkEndAkEvent(builder, TalkEndAkEventOffset);
			ITalkItemVisualNovelTalk.AddTalkAkEvent(builder, TalkAkEventOffset);
			ITalkItemVisualNovelTalk.AddActorTurnToArray(builder, ActorTurnToArrayOffset);
			ITalkItemVisualNovelTalk.AddActorLookAtArray(builder, ActorLookAtArrayOffset);
			ITalkItemVisualNovelTalk.AddActorFaceExpressionArray(builder, ActorFaceExpressionArrayOffset);
			ITalkItemVisualNovelTalk.AddActorMontageArray(builder, ActorMontageArrayOffset);
			ITalkItemVisualNovelTalk.AddFlowTemplateList(builder, FlowTemplateListOffset);
			ITalkItemVisualNovelTalk.AddFlowTemplate(builder, FlowTemplateOffset);
			ITalkItemVisualNovelTalk.AddCameraData(builder, CameraDataOffset);
			ITalkItemVisualNovelTalk.AddMontage(builder, MontageOffset);
			ITalkItemVisualNovelTalk.AddOptions(builder, OptionsOffset);
			ITalkItemVisualNovelTalk.AddActions(builder, ActionsOffset);
			ITalkItemVisualNovelTalk.AddCaptionParams(builder, CaptionParamsOffset);
			ITalkItemVisualNovelTalk.AddWaitTime(builder, WaitTime);
			ITalkItemVisualNovelTalk.AddTidTalk(builder, TidTalkOffset);
			ITalkItemVisualNovelTalk.AddTextId(builder, TextId);
			ITalkItemVisualNovelTalk.AddWhoId(builder, WhoId);
			ITalkItemVisualNovelTalk.AddName(builder, NameOffset);
			ITalkItemVisualNovelTalk.AddPlotLineKey(builder, PlotLineKeyOffset);
			ITalkItemVisualNovelTalk.AddPlotLineId(builder, PlotLineId);
			ITalkItemVisualNovelTalk.AddId(builder, Id);
			ITalkItemVisualNovelTalk.AddDisplayItemConfigType(builder, DisplayItemConfig_type);
			ITalkItemVisualNovelTalk.AddCgConfigType(builder, CgConfig_type);
			ITalkItemVisualNovelTalk.AddVisualNovelBackgroundConfigType(builder, VisualNovelBackgroundConfig_type);
			ITalkItemVisualNovelTalk.AddClickShowFull(builder, ClickShowFull);
			ITalkItemVisualNovelTalk.AddOptionInteractionType(builder, OptionInteractionType);
			ITalkItemVisualNovelTalk.AddPlayVoice(builder, PlayVoice);
			ITalkItemVisualNovelTalk.AddBackgroundConfigType(builder, BackgroundConfig_type);
			ITalkItemVisualNovelTalk.AddTalkEndAkEventType(builder, TalkEndAkEvent_type);
			ITalkItemVisualNovelTalk.AddTalkAkEventType(builder, TalkAkEvent_type);
			ITalkItemVisualNovelTalk.Add_EditFlag(builder, _editFlag);
			ITalkItemVisualNovelTalk.Add_Folded(builder, _folded);
			ITalkItemVisualNovelTalk.AddType(builder, Type);
			return ITalkItemVisualNovelTalk.EndITalkItemVisualNovelTalk(builder);
		}

		// Token: 0x06035660 RID: 218720 RVA: 0x00744D5C File Offset: 0x00742F5C
		public static void StartITalkItemVisualNovelTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(56);
		}

		// Token: 0x06035661 RID: 218721 RVA: 0x00744D66 File Offset: 0x00742F66
		public static void AddType(FlatBufferBuilder builder, ETalkItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035662 RID: 218722 RVA: 0x00744D71 File Offset: 0x00742F71
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06035663 RID: 218723 RVA: 0x00744D7C File Offset: 0x00742F7C
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x06035664 RID: 218724 RVA: 0x00744D87 File Offset: 0x00742F87
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06035665 RID: 218725 RVA: 0x00744D97 File Offset: 0x00742F97
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x06035666 RID: 218726 RVA: 0x00744DA7 File Offset: 0x00742FA7
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(5, _Folded, false);
		}

		// Token: 0x06035667 RID: 218727 RVA: 0x00744DB2 File Offset: 0x00742FB2
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(6, (byte)_EditFlag, 0);
		}

		// Token: 0x06035668 RID: 218728 RVA: 0x00744DBD File Offset: 0x00742FBD
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(7, whoId, 0);
		}

		// Token: 0x06035669 RID: 218729 RVA: 0x00744DC8 File Offset: 0x00742FC8
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(8, textId, 0);
		}

		// Token: 0x0603566A RID: 218730 RVA: 0x00744DD3 File Offset: 0x00742FD3
		public static void AddTidTalk(FlatBufferBuilder builder, StringOffset tidTalkOffset)
		{
			builder.AddOffset(9, tidTalkOffset.Value, 0);
		}

		// Token: 0x0603566B RID: 218731 RVA: 0x00744DE4 File Offset: 0x00742FE4
		public static void AddWaitTime(FlatBufferBuilder builder, float waitTime)
		{
			builder.AddFloat(10, waitTime, 0.0);
		}

		// Token: 0x0603566C RID: 218732 RVA: 0x00744DF8 File Offset: 0x00742FF8
		public static void AddCaptionParams(FlatBufferBuilder builder, Offset<ICaptionParam> captionParamsOffset)
		{
			builder.AddOffset(11, captionParamsOffset.Value, 0);
		}

		// Token: 0x0603566D RID: 218733 RVA: 0x00744E09 File Offset: 0x00743009
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(12, actionsOffset.Value, 0);
		}

		// Token: 0x0603566E RID: 218734 RVA: 0x00744E1C File Offset: 0x0074301C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603566F RID: 218735 RVA: 0x00744E5C File Offset: 0x0074305C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035670 RID: 218736 RVA: 0x00744E76 File Offset: 0x00743076
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035671 RID: 218737 RVA: 0x00744E94 File Offset: 0x00743094
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035672 RID: 218738 RVA: 0x00744EAD File Offset: 0x007430AD
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035673 RID: 218739 RVA: 0x00744EB8 File Offset: 0x007430B8
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(13, optionsOffset.Value, 0);
		}

		// Token: 0x06035674 RID: 218740 RVA: 0x00744ECC File Offset: 0x007430CC
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035675 RID: 218741 RVA: 0x00744F0C File Offset: 0x0074310C
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<ITalkOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035676 RID: 218742 RVA: 0x00744F26 File Offset: 0x00743126
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035677 RID: 218743 RVA: 0x00744F44 File Offset: 0x00743144
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035678 RID: 218744 RVA: 0x00744F5D File Offset: 0x0074315D
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035679 RID: 218745 RVA: 0x00744F68 File Offset: 0x00743168
		public static void AddMontage(FlatBufferBuilder builder, Offset<IPlayMontage> montageOffset)
		{
			builder.AddOffset(14, montageOffset.Value, 0);
		}

		// Token: 0x0603567A RID: 218746 RVA: 0x00744F79 File Offset: 0x00743179
		public static void AddCameraData(FlatBufferBuilder builder, Offset<ICameraData> cameraDataOffset)
		{
			builder.AddOffset(15, cameraDataOffset.Value, 0);
		}

		// Token: 0x0603567B RID: 218747 RVA: 0x00744F8A File Offset: 0x0074318A
		public static void AddFlowTemplate(FlatBufferBuilder builder, Offset<ISetFlowTemplate> flowTemplateOffset)
		{
			builder.AddOffset(16, flowTemplateOffset.Value, 0);
		}

		// Token: 0x0603567C RID: 218748 RVA: 0x00744F9B File Offset: 0x0074319B
		public static void AddFlowTemplateList(FlatBufferBuilder builder, VectorOffset flowTemplateListOffset)
		{
			builder.AddOffset(17, flowTemplateListOffset.Value, 0);
		}

		// Token: 0x0603567D RID: 218749 RVA: 0x00744FAC File Offset: 0x007431AC
		public static VectorOffset CreateFlowTemplateListVector(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603567E RID: 218750 RVA: 0x00744FEC File Offset: 0x007431EC
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, Offset<ISetFlowTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603567F RID: 218751 RVA: 0x00745006 File Offset: 0x00743206
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetFlowTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetFlowTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035680 RID: 218752 RVA: 0x00745024 File Offset: 0x00743224
		public static VectorOffset CreateFlowTemplateListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetFlowTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035681 RID: 218753 RVA: 0x0074503D File Offset: 0x0074323D
		public static void StartFlowTemplateListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035682 RID: 218754 RVA: 0x00745048 File Offset: 0x00743248
		public static void AddActorMontageArray(FlatBufferBuilder builder, VectorOffset actorMontageArrayOffset)
		{
			builder.AddOffset(18, actorMontageArrayOffset.Value, 0);
		}

		// Token: 0x06035683 RID: 218755 RVA: 0x0074505C File Offset: 0x0074325C
		public static VectorOffset CreateActorMontageArrayVector(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035684 RID: 218756 RVA: 0x0074509C File Offset: 0x0074329C
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, Offset<IMontageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035685 RID: 218757 RVA: 0x007450B6 File Offset: 0x007432B6
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMontageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMontageData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035686 RID: 218758 RVA: 0x007450D4 File Offset: 0x007432D4
		public static VectorOffset CreateActorMontageArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMontageData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035687 RID: 218759 RVA: 0x007450ED File Offset: 0x007432ED
		public static void StartActorMontageArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035688 RID: 218760 RVA: 0x007450F8 File Offset: 0x007432F8
		public static void AddActorFaceExpressionArray(FlatBufferBuilder builder, VectorOffset actorFaceExpressionArrayOffset)
		{
			builder.AddOffset(19, actorFaceExpressionArrayOffset.Value, 0);
		}

		// Token: 0x06035689 RID: 218761 RVA: 0x0074510C File Offset: 0x0074330C
		public static VectorOffset CreateActorFaceExpressionArrayVector(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603568A RID: 218762 RVA: 0x0074514C File Offset: 0x0074334C
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFaceExpression>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603568B RID: 218763 RVA: 0x00745166 File Offset: 0x00743366
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFaceExpression>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFaceExpression>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603568C RID: 218764 RVA: 0x00745184 File Offset: 0x00743384
		public static VectorOffset CreateActorFaceExpressionArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFaceExpression>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603568D RID: 218765 RVA: 0x0074519D File Offset: 0x0074339D
		public static void StartActorFaceExpressionArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603568E RID: 218766 RVA: 0x007451A8 File Offset: 0x007433A8
		public static void AddActorLookAtArray(FlatBufferBuilder builder, VectorOffset actorLookAtArrayOffset)
		{
			builder.AddOffset(20, actorLookAtArrayOffset.Value, 0);
		}

		// Token: 0x0603568F RID: 218767 RVA: 0x007451BC File Offset: 0x007433BC
		public static VectorOffset CreateActorLookAtArrayVector(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035690 RID: 218768 RVA: 0x007451FC File Offset: 0x007433FC
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorLookAt>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035691 RID: 218769 RVA: 0x00745216 File Offset: 0x00743416
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorLookAt>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorLookAt>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035692 RID: 218770 RVA: 0x00745234 File Offset: 0x00743434
		public static VectorOffset CreateActorLookAtArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorLookAt>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035693 RID: 218771 RVA: 0x0074524D File Offset: 0x0074344D
		public static void StartActorLookAtArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035694 RID: 218772 RVA: 0x00745258 File Offset: 0x00743458
		public static void AddActorTurnToArray(FlatBufferBuilder builder, VectorOffset actorTurnToArrayOffset)
		{
			builder.AddOffset(21, actorTurnToArrayOffset.Value, 0);
		}

		// Token: 0x06035695 RID: 218773 RVA: 0x0074526C File Offset: 0x0074346C
		public static VectorOffset CreateActorTurnToArrayVector(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035696 RID: 218774 RVA: 0x007452AC File Offset: 0x007434AC
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorTurnTo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035697 RID: 218775 RVA: 0x007452C6 File Offset: 0x007434C6
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorTurnTo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorTurnTo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035698 RID: 218776 RVA: 0x007452E4 File Offset: 0x007434E4
		public static VectorOffset CreateActorTurnToArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorTurnTo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035699 RID: 218777 RVA: 0x007452FD File Offset: 0x007434FD
		public static void StartActorTurnToArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603569A RID: 218778 RVA: 0x00745308 File Offset: 0x00743508
		public static void AddTalkAkEventType(FlatBufferBuilder builder, TPostAkEvent talkAkEventType)
		{
			builder.AddByte(22, (byte)talkAkEventType, 0);
		}

		// Token: 0x0603569B RID: 218779 RVA: 0x00745314 File Offset: 0x00743514
		public static void AddTalkAkEvent(FlatBufferBuilder builder, int talkAkEventOffset)
		{
			builder.AddOffset(23, talkAkEventOffset, 0);
		}

		// Token: 0x0603569C RID: 218780 RVA: 0x00745320 File Offset: 0x00743520
		public static void AddTalkEndAkEventType(FlatBufferBuilder builder, TPostAkEvent talkEndAkEventType)
		{
			builder.AddByte(24, (byte)talkEndAkEventType, 0);
		}

		// Token: 0x0603569D RID: 218781 RVA: 0x0074532C File Offset: 0x0074352C
		public static void AddTalkEndAkEvent(FlatBufferBuilder builder, int talkEndAkEventOffset)
		{
			builder.AddOffset(25, talkEndAkEventOffset, 0);
		}

		// Token: 0x0603569E RID: 218782 RVA: 0x00745338 File Offset: 0x00743538
		public static void AddUniversalTone(FlatBufferBuilder builder, Offset<IUniversalTone> universalToneOffset)
		{
			builder.AddOffset(26, universalToneOffset.Value, 0);
		}

		// Token: 0x0603569F RID: 218783 RVA: 0x00745349 File Offset: 0x00743549
		public static void AddBackgroundConfigType(FlatBufferBuilder builder, TTalkBackground backgroundConfigType)
		{
			builder.AddByte(27, (byte)backgroundConfigType, 0);
		}

		// Token: 0x060356A0 RID: 218784 RVA: 0x00745355 File Offset: 0x00743555
		public static void AddBackgroundConfig(FlatBufferBuilder builder, int backgroundConfigOffset)
		{
			builder.AddOffset(28, backgroundConfigOffset, 0);
		}

		// Token: 0x060356A1 RID: 218785 RVA: 0x00745361 File Offset: 0x00743561
		public static void AddPlayVoice(FlatBufferBuilder builder, bool playVoice)
		{
			builder.AddBool(29, playVoice, false);
		}

		// Token: 0x060356A2 RID: 218786 RVA: 0x0074536D File Offset: 0x0074356D
		public static void AddTimeLimitOptionGroup(FlatBufferBuilder builder, Offset<ITimeLimitOptionGroup> timeLimitOptionGroupOffset)
		{
			builder.AddOffset(30, timeLimitOptionGroupOffset.Value, 0);
		}

		// Token: 0x060356A3 RID: 218787 RVA: 0x0074537E File Offset: 0x0074357E
		public static void AddGamepadShake(FlatBufferBuilder builder, Offset<IGamepadShakeInTalk> gamepadShakeOffset)
		{
			builder.AddOffset(31, gamepadShakeOffset.Value, 0);
		}

		// Token: 0x060356A4 RID: 218788 RVA: 0x0074538F File Offset: 0x0074358F
		public static void AddIntroActions(FlatBufferBuilder builder, VectorOffset introActionsOffset)
		{
			builder.AddOffset(32, introActionsOffset.Value, 0);
		}

		// Token: 0x060356A5 RID: 218789 RVA: 0x007453A0 File Offset: 0x007435A0
		public static VectorOffset CreateIntroActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060356A6 RID: 218790 RVA: 0x007453E0 File Offset: 0x007435E0
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060356A7 RID: 218791 RVA: 0x007453FA File Offset: 0x007435FA
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060356A8 RID: 218792 RVA: 0x00745418 File Offset: 0x00743618
		public static VectorOffset CreateIntroActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356A9 RID: 218793 RVA: 0x00745431 File Offset: 0x00743631
		public static void StartIntroActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060356AA RID: 218794 RVA: 0x0074543C File Offset: 0x0074363C
		public static void AddActorFxEmoteArray(FlatBufferBuilder builder, VectorOffset actorFxEmoteArrayOffset)
		{
			builder.AddOffset(33, actorFxEmoteArrayOffset.Value, 0);
		}

		// Token: 0x060356AB RID: 218795 RVA: 0x00745450 File Offset: 0x00743650
		public static VectorOffset CreateActorFxEmoteArrayVector(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060356AC RID: 218796 RVA: 0x00745490 File Offset: 0x00743690
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorFxEmote>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x060356AD RID: 218797 RVA: 0x007454AA File Offset: 0x007436AA
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorFxEmote>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorFxEmote>>(data);
			return builder.EndVector();
		}

		// Token: 0x060356AE RID: 218798 RVA: 0x007454C8 File Offset: 0x007436C8
		public static VectorOffset CreateActorFxEmoteArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorFxEmote>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356AF RID: 218799 RVA: 0x007454E1 File Offset: 0x007436E1
		public static void StartActorFxEmoteArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060356B0 RID: 218800 RVA: 0x007454EC File Offset: 0x007436EC
		public static void AddTalkEffectArrayType(FlatBufferBuilder builder, VectorOffset talkEffectArrayTypeOffset)
		{
			builder.AddOffset(34, talkEffectArrayTypeOffset.Value, 0);
		}

		// Token: 0x060356B1 RID: 218801 RVA: 0x00745500 File Offset: 0x00743700
		public static VectorOffset CreateTalkEffectArrayTypeVector(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060356B2 RID: 218802 RVA: 0x00745537 File Offset: 0x00743737
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, TTalkEffectAction[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x060356B3 RID: 218803 RVA: 0x00745551 File Offset: 0x00743751
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TTalkEffectAction> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TTalkEffectAction>(data);
			return builder.EndVector();
		}

		// Token: 0x060356B4 RID: 218804 RVA: 0x0074556F File Offset: 0x0074376F
		public static VectorOffset CreateTalkEffectArrayTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TTalkEffectAction>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356B5 RID: 218805 RVA: 0x00745588 File Offset: 0x00743788
		public static void StartTalkEffectArrayTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060356B6 RID: 218806 RVA: 0x00745593 File Offset: 0x00743793
		public static void AddTalkEffectArray(FlatBufferBuilder builder, VectorOffset talkEffectArrayOffset)
		{
			builder.AddOffset(35, talkEffectArrayOffset.Value, 0);
		}

		// Token: 0x060356B7 RID: 218807 RVA: 0x007455A4 File Offset: 0x007437A4
		public static VectorOffset CreateTalkEffectArrayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060356B8 RID: 218808 RVA: 0x007455DB File Offset: 0x007437DB
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060356B9 RID: 218809 RVA: 0x007455F5 File Offset: 0x007437F5
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060356BA RID: 218810 RVA: 0x00745613 File Offset: 0x00743813
		public static VectorOffset CreateTalkEffectArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356BB RID: 218811 RVA: 0x0074562C File Offset: 0x0074382C
		public static void StartTalkEffectArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060356BC RID: 218812 RVA: 0x00745637 File Offset: 0x00743837
		public static void AddActorVisibilityArray(FlatBufferBuilder builder, VectorOffset actorVisibilityArrayOffset)
		{
			builder.AddOffset(36, actorVisibilityArrayOffset.Value, 0);
		}

		// Token: 0x060356BD RID: 218813 RVA: 0x00745648 File Offset: 0x00743848
		public static VectorOffset CreateActorVisibilityArrayVector(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060356BE RID: 218814 RVA: 0x00745688 File Offset: 0x00743888
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, Offset<IActorVisibility>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x060356BF RID: 218815 RVA: 0x007456A2 File Offset: 0x007438A2
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorVisibility>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorVisibility>>(data);
			return builder.EndVector();
		}

		// Token: 0x060356C0 RID: 218816 RVA: 0x007456C0 File Offset: 0x007438C0
		public static VectorOffset CreateActorVisibilityArrayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorVisibility>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356C1 RID: 218817 RVA: 0x007456D9 File Offset: 0x007438D9
		public static void StartActorVisibilityArrayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060356C2 RID: 218818 RVA: 0x007456E4 File Offset: 0x007438E4
		public static void AddOptionInteractionType(FlatBufferBuilder builder, EVisualNovelOptionInteractionType optionInteractionType)
		{
			builder.AddByte(37, (byte)optionInteractionType, 0);
		}

		// Token: 0x060356C3 RID: 218819 RVA: 0x007456F0 File Offset: 0x007438F0
		public static void AddOptionGroup(FlatBufferBuilder builder, Offset<IVisualNovelOptionGroupSolarSchoolExam> optionGroupOffset)
		{
			builder.AddOffset(38, optionGroupOffset.Value, 0);
		}

		// Token: 0x060356C4 RID: 218820 RVA: 0x00745701 File Offset: 0x00743901
		public static void AddDialogDelay(FlatBufferBuilder builder, float dialogDelay)
		{
			builder.AddFloat(39, dialogDelay, 0.0);
		}

		// Token: 0x060356C5 RID: 218821 RVA: 0x00745715 File Offset: 0x00743915
		public static void AddClickShowFull(FlatBufferBuilder builder, bool clickShowFull)
		{
			builder.AddBool(40, clickShowFull, false);
		}

		// Token: 0x060356C6 RID: 218822 RVA: 0x00745721 File Offset: 0x00743921
		public static void AddInterjection(FlatBufferBuilder builder, StringOffset interjectionOffset)
		{
			builder.AddOffset(41, interjectionOffset.Value, 0);
		}

		// Token: 0x060356C7 RID: 218823 RVA: 0x00745732 File Offset: 0x00743932
		public static void AddTransform(FlatBufferBuilder builder, Offset<IVisualNovelPortraitTransform> transformOffset)
		{
			builder.AddOffset(42, transformOffset.Value, 0);
		}

		// Token: 0x060356C8 RID: 218824 RVA: 0x00745743 File Offset: 0x00743943
		public static void AddRoleConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleConfig> roleConfigOffset)
		{
			builder.AddOffset(43, roleConfigOffset.Value, 0);
		}

		// Token: 0x060356C9 RID: 218825 RVA: 0x00745754 File Offset: 0x00743954
		public static void AddVisualNovelBackgroundConfigType(FlatBufferBuilder builder, TVisualNovelBackground visualNovelBackgroundConfigType)
		{
			builder.AddByte(44, (byte)visualNovelBackgroundConfigType, 0);
		}

		// Token: 0x060356CA RID: 218826 RVA: 0x00745760 File Offset: 0x00743960
		public static void AddVisualNovelBackgroundConfig(FlatBufferBuilder builder, int visualNovelBackgroundConfigOffset)
		{
			builder.AddOffset(45, visualNovelBackgroundConfigOffset, 0);
		}

		// Token: 0x060356CB RID: 218827 RVA: 0x0074576C File Offset: 0x0074396C
		public static void AddCgConfigType(FlatBufferBuilder builder, TVisualNovelCg cgConfigType)
		{
			builder.AddByte(46, (byte)cgConfigType, 0);
		}

		// Token: 0x060356CC RID: 218828 RVA: 0x00745778 File Offset: 0x00743978
		public static void AddCgConfig(FlatBufferBuilder builder, int cgConfigOffset)
		{
			builder.AddOffset(47, cgConfigOffset, 0);
		}

		// Token: 0x060356CD RID: 218829 RVA: 0x00745784 File Offset: 0x00743984
		public static void AddDisplayItemConfigType(FlatBufferBuilder builder, TVisualNovelDisplayItem displayItemConfigType)
		{
			builder.AddByte(48, (byte)displayItemConfigType, 0);
		}

		// Token: 0x060356CE RID: 218830 RVA: 0x00745790 File Offset: 0x00743990
		public static void AddDisplayItemConfig(FlatBufferBuilder builder, int displayItemConfigOffset)
		{
			builder.AddOffset(49, displayItemConfigOffset, 0);
		}

		// Token: 0x060356CF RID: 218831 RVA: 0x0074579C File Offset: 0x0074399C
		public static void AddPlotKeyId(FlatBufferBuilder builder, int plotKeyId)
		{
			builder.AddInt(50, plotKeyId, 0);
		}

		// Token: 0x060356D0 RID: 218832 RVA: 0x007457A8 File Offset: 0x007439A8
		public static void AddStartPerformancesType(FlatBufferBuilder builder, VectorOffset startPerformancesTypeOffset)
		{
			builder.AddOffset(51, startPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x060356D1 RID: 218833 RVA: 0x007457BC File Offset: 0x007439BC
		public static VectorOffset CreateStartPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060356D2 RID: 218834 RVA: 0x007457F3 File Offset: 0x007439F3
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x060356D3 RID: 218835 RVA: 0x0074580D File Offset: 0x00743A0D
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x060356D4 RID: 218836 RVA: 0x0074582B File Offset: 0x00743A2B
		public static VectorOffset CreateStartPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356D5 RID: 218837 RVA: 0x00745844 File Offset: 0x00743A44
		public static void StartStartPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060356D6 RID: 218838 RVA: 0x0074584F File Offset: 0x00743A4F
		public static void AddStartPerformances(FlatBufferBuilder builder, VectorOffset startPerformancesOffset)
		{
			builder.AddOffset(52, startPerformancesOffset.Value, 0);
		}

		// Token: 0x060356D7 RID: 218839 RVA: 0x00745860 File Offset: 0x00743A60
		public static VectorOffset CreateStartPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060356D8 RID: 218840 RVA: 0x00745897 File Offset: 0x00743A97
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060356D9 RID: 218841 RVA: 0x007458B1 File Offset: 0x00743AB1
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060356DA RID: 218842 RVA: 0x007458CF File Offset: 0x00743ACF
		public static VectorOffset CreateStartPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356DB RID: 218843 RVA: 0x007458E8 File Offset: 0x00743AE8
		public static void StartStartPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060356DC RID: 218844 RVA: 0x007458F3 File Offset: 0x00743AF3
		public static void AddEndPerformancesType(FlatBufferBuilder builder, VectorOffset endPerformancesTypeOffset)
		{
			builder.AddOffset(53, endPerformancesTypeOffset.Value, 0);
		}

		// Token: 0x060356DD RID: 218845 RVA: 0x00745904 File Offset: 0x00743B04
		public static VectorOffset CreateEndPerformancesTypeVector(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060356DE RID: 218846 RVA: 0x0074593B File Offset: 0x00743B3B
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, TVisualNovelPerformance[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x060356DF RID: 218847 RVA: 0x00745955 File Offset: 0x00743B55
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisualNovelPerformance> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisualNovelPerformance>(data);
			return builder.EndVector();
		}

		// Token: 0x060356E0 RID: 218848 RVA: 0x00745973 File Offset: 0x00743B73
		public static VectorOffset CreateEndPerformancesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisualNovelPerformance>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356E1 RID: 218849 RVA: 0x0074598C File Offset: 0x00743B8C
		public static void StartEndPerformancesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060356E2 RID: 218850 RVA: 0x00745997 File Offset: 0x00743B97
		public static void AddEndPerformances(FlatBufferBuilder builder, VectorOffset endPerformancesOffset)
		{
			builder.AddOffset(54, endPerformancesOffset.Value, 0);
		}

		// Token: 0x060356E3 RID: 218851 RVA: 0x007459A8 File Offset: 0x00743BA8
		public static VectorOffset CreateEndPerformancesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060356E4 RID: 218852 RVA: 0x007459DF File Offset: 0x00743BDF
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060356E5 RID: 218853 RVA: 0x007459F9 File Offset: 0x00743BF9
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060356E6 RID: 218854 RVA: 0x00745A17 File Offset: 0x00743C17
		public static VectorOffset CreateEndPerformancesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060356E7 RID: 218855 RVA: 0x00745A30 File Offset: 0x00743C30
		public static void StartEndPerformancesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060356E8 RID: 218856 RVA: 0x00745A3B File Offset: 0x00743C3B
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(55, nullMask, 0U);
		}

		// Token: 0x060356E9 RID: 218857 RVA: 0x00745A47 File Offset: 0x00743C47
		public static Offset<ITalkItemVisualNovelTalk> EndITalkItemVisualNovelTalk(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemVisualNovelTalk>(builder.EndTable());
		}

		// Token: 0x060356EA RID: 218858 RVA: 0x00745A54 File Offset: 0x00743C54
		public ITalkItemVisualNovelTalkT UnPack()
		{
			ITalkItemVisualNovelTalkT talkItemVisualNovelTalkT = new ITalkItemVisualNovelTalkT();
			this.UnPackTo(talkItemVisualNovelTalkT);
			return talkItemVisualNovelTalkT;
		}

		// Token: 0x060356EB RID: 218859 RVA: 0x00745A70 File Offset: 0x00743C70
		public void UnPackTo(ITalkItemVisualNovelTalkT _o)
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
			_o.Interjection = this.Interjection;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.RoleConfig = ((this.RoleConfig != null) ? this.RoleConfig.Value.UnPack() : null);
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

		// Token: 0x060356EC RID: 218860 RVA: 0x007470E8 File Offset: 0x007452E8
		public static Offset<ITalkItemVisualNovelTalk> Pack(FlatBufferBuilder builder, ITalkItemVisualNovelTalkT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemVisualNovelTalk>);
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
				actionsOffset = ITalkItemVisualNovelTalk.CreateActionsVector(builder, array);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<ITalkOption>[] array2 = new Offset<ITalkOption>[_o.Options.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ITalkOption.Pack(builder, _o.Options[j]);
				}
				optionsOffset = ITalkItemVisualNovelTalk.CreateOptionsVector(builder, array2);
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
				flowTemplateListOffset = ITalkItemVisualNovelTalk.CreateFlowTemplateListVector(builder, array3);
			}
			VectorOffset actorMontageArrayOffset = default(VectorOffset);
			if (_o.ActorMontageArray != null)
			{
				Offset<IMontageData>[] array4 = new Offset<IMontageData>[_o.ActorMontageArray.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IMontageData.Pack(builder, _o.ActorMontageArray[l]);
				}
				actorMontageArrayOffset = ITalkItemVisualNovelTalk.CreateActorMontageArrayVector(builder, array4);
			}
			VectorOffset actorFaceExpressionArrayOffset = default(VectorOffset);
			if (_o.ActorFaceExpressionArray != null)
			{
				Offset<IActorFaceExpression>[] array5 = new Offset<IActorFaceExpression>[_o.ActorFaceExpressionArray.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IActorFaceExpression.Pack(builder, _o.ActorFaceExpressionArray[m]);
				}
				actorFaceExpressionArrayOffset = ITalkItemVisualNovelTalk.CreateActorFaceExpressionArrayVector(builder, array5);
			}
			VectorOffset actorLookAtArrayOffset = default(VectorOffset);
			if (_o.ActorLookAtArray != null)
			{
				Offset<IActorLookAt>[] array6 = new Offset<IActorLookAt>[_o.ActorLookAtArray.Count];
				for (int n = 0; n < array6.Length; n++)
				{
					array6[n] = IActorLookAt.Pack(builder, _o.ActorLookAtArray[n]);
				}
				actorLookAtArrayOffset = ITalkItemVisualNovelTalk.CreateActorLookAtArrayVector(builder, array6);
			}
			VectorOffset actorTurnToArrayOffset = default(VectorOffset);
			if (_o.ActorTurnToArray != null)
			{
				Offset<IActorTurnTo>[] array7 = new Offset<IActorTurnTo>[_o.ActorTurnToArray.Count];
				for (int num = 0; num < array7.Length; num++)
				{
					array7[num] = IActorTurnTo.Pack(builder, _o.ActorTurnToArray[num]);
				}
				actorTurnToArrayOffset = ITalkItemVisualNovelTalk.CreateActorTurnToArrayVector(builder, array7);
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
				introActionsOffset = ITalkItemVisualNovelTalk.CreateIntroActionsVector(builder, array8);
			}
			VectorOffset actorFxEmoteArrayOffset = default(VectorOffset);
			if (_o.ActorFxEmoteArray != null)
			{
				Offset<IActorFxEmote>[] array9 = new Offset<IActorFxEmote>[_o.ActorFxEmoteArray.Count];
				for (int num3 = 0; num3 < array9.Length; num3++)
				{
					array9[num3] = IActorFxEmote.Pack(builder, _o.ActorFxEmoteArray[num3]);
				}
				actorFxEmoteArrayOffset = ITalkItemVisualNovelTalk.CreateActorFxEmoteArrayVector(builder, array9);
			}
			VectorOffset talkEffectArray_typeOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				TTalkEffectAction[] array10 = new TTalkEffectAction[_o.TalkEffectArray.Count];
				for (int num4 = 0; num4 < array10.Length; num4++)
				{
					array10[num4] = _o.TalkEffectArray[num4].Type;
				}
				talkEffectArray_typeOffset = ITalkItemVisualNovelTalk.CreateTalkEffectArrayTypeVector(builder, array10);
			}
			VectorOffset talkEffectArrayOffset = default(VectorOffset);
			if (_o.TalkEffectArray != null)
			{
				int[] array11 = new int[_o.TalkEffectArray.Count];
				for (int num5 = 0; num5 < array11.Length; num5++)
				{
					array11[num5] = TTalkEffectActionUnion.Pack(builder, _o.TalkEffectArray[num5]);
				}
				talkEffectArrayOffset = ITalkItemVisualNovelTalk.CreateTalkEffectArrayVector(builder, array11);
			}
			VectorOffset actorVisibilityArrayOffset = default(VectorOffset);
			if (_o.ActorVisibilityArray != null)
			{
				Offset<IActorVisibility>[] array12 = new Offset<IActorVisibility>[_o.ActorVisibilityArray.Count];
				for (int num6 = 0; num6 < array12.Length; num6++)
				{
					array12[num6] = IActorVisibility.Pack(builder, _o.ActorVisibilityArray[num6]);
				}
				actorVisibilityArrayOffset = ITalkItemVisualNovelTalk.CreateActorVisibilityArrayVector(builder, array12);
			}
			Offset<IVisualNovelOptionGroupSolarSchoolExam> optionGroupOffset = (_o.OptionGroup == null) ? default(Offset<IVisualNovelOptionGroupSolarSchoolExam>) : IVisualNovelOptionGroupSolarSchoolExam.Pack(builder, _o.OptionGroup);
			StringOffset interjectionOffset = (_o.Interjection == null) ? default(StringOffset) : builder.CreateString(_o.Interjection);
			Offset<IVisualNovelPortraitTransform> transformOffset = (_o.Transform == null) ? default(Offset<IVisualNovelPortraitTransform>) : IVisualNovelPortraitTransform.Pack(builder, _o.Transform);
			Offset<IVisualNovelRoleConfig> roleConfigOffset = (_o.RoleConfig == null) ? default(Offset<IVisualNovelRoleConfig>) : IVisualNovelRoleConfig.Pack(builder, _o.RoleConfig);
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
				startPerformances_typeOffset = ITalkItemVisualNovelTalk.CreateStartPerformancesTypeVector(builder, array13);
			}
			VectorOffset startPerformancesOffset = default(VectorOffset);
			if (_o.StartPerformances != null)
			{
				int[] array14 = new int[_o.StartPerformances.Count];
				for (int num8 = 0; num8 < array14.Length; num8++)
				{
					array14[num8] = TVisualNovelPerformanceUnion.Pack(builder, _o.StartPerformances[num8]);
				}
				startPerformancesOffset = ITalkItemVisualNovelTalk.CreateStartPerformancesVector(builder, array14);
			}
			VectorOffset endPerformances_typeOffset = default(VectorOffset);
			if (_o.EndPerformances != null)
			{
				TVisualNovelPerformance[] array15 = new TVisualNovelPerformance[_o.EndPerformances.Count];
				for (int num9 = 0; num9 < array15.Length; num9++)
				{
					array15[num9] = _o.EndPerformances[num9].Type;
				}
				endPerformances_typeOffset = ITalkItemVisualNovelTalk.CreateEndPerformancesTypeVector(builder, array15);
			}
			VectorOffset endPerformancesOffset = default(VectorOffset);
			if (_o.EndPerformances != null)
			{
				int[] array16 = new int[_o.EndPerformances.Count];
				for (int num10 = 0; num10 < array16.Length; num10++)
				{
					array16[num10] = TVisualNovelPerformanceUnion.Pack(builder, _o.EndPerformances[num10]);
				}
				endPerformancesOffset = ITalkItemVisualNovelTalk.CreateEndPerformancesVector(builder, array16);
			}
			return ITalkItemVisualNovelTalk.CreateITalkItemVisualNovelTalk(builder, _o.Type, _o.Id, _o.PlotLineId, plotLineKeyOffset, nameOffset, _o._Folded, _o._EditFlag, _o.WhoId, _o.TextId, tidTalkOffset, _o.WaitTime, captionParamsOffset, actionsOffset, optionsOffset, montageOffset, cameraDataOffset, flowTemplateOffset, flowTemplateListOffset, actorMontageArrayOffset, actorFaceExpressionArrayOffset, actorLookAtArrayOffset, actorTurnToArrayOffset, talkAkEvent_type, talkAkEventOffset, talkEndAkEvent_type, talkEndAkEventOffset, universalToneOffset, backgroundConfig_type, backgroundConfigOffset, _o.PlayVoice, timeLimitOptionGroupOffset, gamepadShakeOffset, introActionsOffset, actorFxEmoteArrayOffset, talkEffectArray_typeOffset, talkEffectArrayOffset, actorVisibilityArrayOffset, _o.OptionInteractionType, optionGroupOffset, _o.DialogDelay, _o.ClickShowFull, interjectionOffset, transformOffset, roleConfigOffset, visualNovelBackgroundConfig_type, visualNovelBackgroundConfigOffset, cgConfig_type, cgConfigOffset, displayItemConfig_type, displayItemConfigOffset, _o.PlotKeyId, startPerformances_typeOffset, startPerformancesOffset, endPerformances_typeOffset, endPerformancesOffset, _o.NullMask);
		}

		// Token: 0x040120B6 RID: 73910
		private Table __p;
	}
}
