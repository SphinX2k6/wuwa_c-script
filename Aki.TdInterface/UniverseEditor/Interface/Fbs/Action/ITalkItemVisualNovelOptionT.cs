using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007317 RID: 29463
	public class ITalkItemVisualNovelOptionT
	{
		// Token: 0x1700DF3D RID: 57149
		// (get) Token: 0x06035598 RID: 218520 RVA: 0x0074297C File Offset: 0x00740B7C
		// (set) Token: 0x06035599 RID: 218521 RVA: 0x00742984 File Offset: 0x00740B84
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DF3E RID: 57150
		// (get) Token: 0x0603559A RID: 218522 RVA: 0x0074298D File Offset: 0x00740B8D
		// (set) Token: 0x0603559B RID: 218523 RVA: 0x00742995 File Offset: 0x00740B95
		public int Id { get; set; }

		// Token: 0x1700DF3F RID: 57151
		// (get) Token: 0x0603559C RID: 218524 RVA: 0x0074299E File Offset: 0x00740B9E
		// (set) Token: 0x0603559D RID: 218525 RVA: 0x007429A6 File Offset: 0x00740BA6
		public int PlotLineId { get; set; }

		// Token: 0x1700DF40 RID: 57152
		// (get) Token: 0x0603559E RID: 218526 RVA: 0x007429AF File Offset: 0x00740BAF
		// (set) Token: 0x0603559F RID: 218527 RVA: 0x007429B7 File Offset: 0x00740BB7
		public string PlotLineKey { get; set; }

		// Token: 0x1700DF41 RID: 57153
		// (get) Token: 0x060355A0 RID: 218528 RVA: 0x007429C0 File Offset: 0x00740BC0
		// (set) Token: 0x060355A1 RID: 218529 RVA: 0x007429C8 File Offset: 0x00740BC8
		public string Name { get; set; }

		// Token: 0x1700DF42 RID: 57154
		// (get) Token: 0x060355A2 RID: 218530 RVA: 0x007429D1 File Offset: 0x00740BD1
		// (set) Token: 0x060355A3 RID: 218531 RVA: 0x007429D9 File Offset: 0x00740BD9
		public bool _Folded { get; set; }

		// Token: 0x1700DF43 RID: 57155
		// (get) Token: 0x060355A4 RID: 218532 RVA: 0x007429E2 File Offset: 0x00740BE2
		// (set) Token: 0x060355A5 RID: 218533 RVA: 0x007429EA File Offset: 0x00740BEA
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DF44 RID: 57156
		// (get) Token: 0x060355A6 RID: 218534 RVA: 0x007429F3 File Offset: 0x00740BF3
		// (set) Token: 0x060355A7 RID: 218535 RVA: 0x007429FB File Offset: 0x00740BFB
		public int WhoId { get; set; }

		// Token: 0x1700DF45 RID: 57157
		// (get) Token: 0x060355A8 RID: 218536 RVA: 0x00742A04 File Offset: 0x00740C04
		// (set) Token: 0x060355A9 RID: 218537 RVA: 0x00742A0C File Offset: 0x00740C0C
		public int TextId { get; set; }

		// Token: 0x1700DF46 RID: 57158
		// (get) Token: 0x060355AA RID: 218538 RVA: 0x00742A15 File Offset: 0x00740C15
		// (set) Token: 0x060355AB RID: 218539 RVA: 0x00742A1D File Offset: 0x00740C1D
		public string TidTalk { get; set; }

		// Token: 0x1700DF47 RID: 57159
		// (get) Token: 0x060355AC RID: 218540 RVA: 0x00742A26 File Offset: 0x00740C26
		// (set) Token: 0x060355AD RID: 218541 RVA: 0x00742A2E File Offset: 0x00740C2E
		public float WaitTime { get; set; }

		// Token: 0x1700DF48 RID: 57160
		// (get) Token: 0x060355AE RID: 218542 RVA: 0x00742A37 File Offset: 0x00740C37
		// (set) Token: 0x060355AF RID: 218543 RVA: 0x00742A3F File Offset: 0x00740C3F
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DF49 RID: 57161
		// (get) Token: 0x060355B0 RID: 218544 RVA: 0x00742A48 File Offset: 0x00740C48
		// (set) Token: 0x060355B1 RID: 218545 RVA: 0x00742A50 File Offset: 0x00740C50
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DF4A RID: 57162
		// (get) Token: 0x060355B2 RID: 218546 RVA: 0x00742A59 File Offset: 0x00740C59
		// (set) Token: 0x060355B3 RID: 218547 RVA: 0x00742A61 File Offset: 0x00740C61
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DF4B RID: 57163
		// (get) Token: 0x060355B4 RID: 218548 RVA: 0x00742A6A File Offset: 0x00740C6A
		// (set) Token: 0x060355B5 RID: 218549 RVA: 0x00742A72 File Offset: 0x00740C72
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DF4C RID: 57164
		// (get) Token: 0x060355B6 RID: 218550 RVA: 0x00742A7B File Offset: 0x00740C7B
		// (set) Token: 0x060355B7 RID: 218551 RVA: 0x00742A83 File Offset: 0x00740C83
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DF4D RID: 57165
		// (get) Token: 0x060355B8 RID: 218552 RVA: 0x00742A8C File Offset: 0x00740C8C
		// (set) Token: 0x060355B9 RID: 218553 RVA: 0x00742A94 File Offset: 0x00740C94
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DF4E RID: 57166
		// (get) Token: 0x060355BA RID: 218554 RVA: 0x00742A9D File Offset: 0x00740C9D
		// (set) Token: 0x060355BB RID: 218555 RVA: 0x00742AA5 File Offset: 0x00740CA5
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DF4F RID: 57167
		// (get) Token: 0x060355BC RID: 218556 RVA: 0x00742AAE File Offset: 0x00740CAE
		// (set) Token: 0x060355BD RID: 218557 RVA: 0x00742AB6 File Offset: 0x00740CB6
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DF50 RID: 57168
		// (get) Token: 0x060355BE RID: 218558 RVA: 0x00742ABF File Offset: 0x00740CBF
		// (set) Token: 0x060355BF RID: 218559 RVA: 0x00742AC7 File Offset: 0x00740CC7
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DF51 RID: 57169
		// (get) Token: 0x060355C0 RID: 218560 RVA: 0x00742AD0 File Offset: 0x00740CD0
		// (set) Token: 0x060355C1 RID: 218561 RVA: 0x00742AD8 File Offset: 0x00740CD8
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DF52 RID: 57170
		// (get) Token: 0x060355C2 RID: 218562 RVA: 0x00742AE1 File Offset: 0x00740CE1
		// (set) Token: 0x060355C3 RID: 218563 RVA: 0x00742AE9 File Offset: 0x00740CE9
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DF53 RID: 57171
		// (get) Token: 0x060355C4 RID: 218564 RVA: 0x00742AF2 File Offset: 0x00740CF2
		// (set) Token: 0x060355C5 RID: 218565 RVA: 0x00742AFA File Offset: 0x00740CFA
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DF54 RID: 57172
		// (get) Token: 0x060355C6 RID: 218566 RVA: 0x00742B03 File Offset: 0x00740D03
		// (set) Token: 0x060355C7 RID: 218567 RVA: 0x00742B0B File Offset: 0x00740D0B
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DF55 RID: 57173
		// (get) Token: 0x060355C8 RID: 218568 RVA: 0x00742B14 File Offset: 0x00740D14
		// (set) Token: 0x060355C9 RID: 218569 RVA: 0x00742B1C File Offset: 0x00740D1C
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DF56 RID: 57174
		// (get) Token: 0x060355CA RID: 218570 RVA: 0x00742B25 File Offset: 0x00740D25
		// (set) Token: 0x060355CB RID: 218571 RVA: 0x00742B2D File Offset: 0x00740D2D
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DF57 RID: 57175
		// (get) Token: 0x060355CC RID: 218572 RVA: 0x00742B36 File Offset: 0x00740D36
		// (set) Token: 0x060355CD RID: 218573 RVA: 0x00742B3E File Offset: 0x00740D3E
		public bool PlayVoice { get; set; }

		// Token: 0x1700DF58 RID: 57176
		// (get) Token: 0x060355CE RID: 218574 RVA: 0x00742B47 File Offset: 0x00740D47
		// (set) Token: 0x060355CF RID: 218575 RVA: 0x00742B4F File Offset: 0x00740D4F
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DF59 RID: 57177
		// (get) Token: 0x060355D0 RID: 218576 RVA: 0x00742B58 File Offset: 0x00740D58
		// (set) Token: 0x060355D1 RID: 218577 RVA: 0x00742B60 File Offset: 0x00740D60
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DF5A RID: 57178
		// (get) Token: 0x060355D2 RID: 218578 RVA: 0x00742B69 File Offset: 0x00740D69
		// (set) Token: 0x060355D3 RID: 218579 RVA: 0x00742B71 File Offset: 0x00740D71
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DF5B RID: 57179
		// (get) Token: 0x060355D4 RID: 218580 RVA: 0x00742B7A File Offset: 0x00740D7A
		// (set) Token: 0x060355D5 RID: 218581 RVA: 0x00742B82 File Offset: 0x00740D82
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DF5C RID: 57180
		// (get) Token: 0x060355D6 RID: 218582 RVA: 0x00742B8B File Offset: 0x00740D8B
		// (set) Token: 0x060355D7 RID: 218583 RVA: 0x00742B93 File Offset: 0x00740D93
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DF5D RID: 57181
		// (get) Token: 0x060355D8 RID: 218584 RVA: 0x00742B9C File Offset: 0x00740D9C
		// (set) Token: 0x060355D9 RID: 218585 RVA: 0x00742BA4 File Offset: 0x00740DA4
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DF5E RID: 57182
		// (get) Token: 0x060355DA RID: 218586 RVA: 0x00742BAD File Offset: 0x00740DAD
		// (set) Token: 0x060355DB RID: 218587 RVA: 0x00742BB5 File Offset: 0x00740DB5
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700DF5F RID: 57183
		// (get) Token: 0x060355DC RID: 218588 RVA: 0x00742BBE File Offset: 0x00740DBE
		// (set) Token: 0x060355DD RID: 218589 RVA: 0x00742BC6 File Offset: 0x00740DC6
		public IVisualNovelOptionGroupSolarSchoolExamT OptionGroup { get; set; }

		// Token: 0x1700DF60 RID: 57184
		// (get) Token: 0x060355DE RID: 218590 RVA: 0x00742BCF File Offset: 0x00740DCF
		// (set) Token: 0x060355DF RID: 218591 RVA: 0x00742BD7 File Offset: 0x00740DD7
		public int CustomDescTextId { get; set; }

		// Token: 0x1700DF61 RID: 57185
		// (get) Token: 0x060355E0 RID: 218592 RVA: 0x00742BE0 File Offset: 0x00740DE0
		// (set) Token: 0x060355E1 RID: 218593 RVA: 0x00742BE8 File Offset: 0x00740DE8
		public string TidCustomDescText { get; set; }

		// Token: 0x1700DF62 RID: 57186
		// (get) Token: 0x060355E2 RID: 218594 RVA: 0x00742BF1 File Offset: 0x00740DF1
		// (set) Token: 0x060355E3 RID: 218595 RVA: 0x00742BF9 File Offset: 0x00740DF9
		public TVisualNovelBackgroundUnion VisualNovelBackgroundConfig { get; set; }

		// Token: 0x1700DF63 RID: 57187
		// (get) Token: 0x060355E4 RID: 218596 RVA: 0x00742C02 File Offset: 0x00740E02
		// (set) Token: 0x060355E5 RID: 218597 RVA: 0x00742C0A File Offset: 0x00740E0A
		public TVisualNovelCgUnion CgConfig { get; set; }

		// Token: 0x1700DF64 RID: 57188
		// (get) Token: 0x060355E6 RID: 218598 RVA: 0x00742C13 File Offset: 0x00740E13
		// (set) Token: 0x060355E7 RID: 218599 RVA: 0x00742C1B File Offset: 0x00740E1B
		public TVisualNovelDisplayItemUnion DisplayItemConfig { get; set; }

		// Token: 0x1700DF65 RID: 57189
		// (get) Token: 0x060355E8 RID: 218600 RVA: 0x00742C24 File Offset: 0x00740E24
		// (set) Token: 0x060355E9 RID: 218601 RVA: 0x00742C2C File Offset: 0x00740E2C
		public int PlotKeyId { get; set; }

		// Token: 0x1700DF66 RID: 57190
		// (get) Token: 0x060355EA RID: 218602 RVA: 0x00742C35 File Offset: 0x00740E35
		// (set) Token: 0x060355EB RID: 218603 RVA: 0x00742C3D File Offset: 0x00740E3D
		public uint NullMask { get; set; }

		// Token: 0x060355EC RID: 218604 RVA: 0x00742C48 File Offset: 0x00740E48
		public ITalkItemVisualNovelOptionT()
		{
			this.Type = ETalkItemType.Talk;
			this.Id = 0;
			this.PlotLineId = 0;
			this.PlotLineKey = null;
			this.Name = null;
			this._Folded = false;
			this._EditFlag = EEditFlag.Add;
			this.WhoId = 0;
			this.TextId = 0;
			this.TidTalk = null;
			this.WaitTime = 0f;
			this.CaptionParams = null;
			this.Actions = null;
			this.Options = null;
			this.Montage = null;
			this.CameraData = null;
			this.FlowTemplate = null;
			this.FlowTemplateList = null;
			this.ActorMontageArray = null;
			this.ActorFaceExpressionArray = null;
			this.ActorLookAtArray = null;
			this.ActorTurnToArray = null;
			this.TalkAkEvent = null;
			this.TalkEndAkEvent = null;
			this.UniversalTone = null;
			this.BackgroundConfig = null;
			this.PlayVoice = false;
			this.TimeLimitOptionGroup = null;
			this.GamepadShake = null;
			this.IntroActions = null;
			this.ActorFxEmoteArray = null;
			this.TalkEffectArray = null;
			this.ActorVisibilityArray = null;
			this.OptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect;
			this.OptionGroup = null;
			this.CustomDescTextId = 0;
			this.TidCustomDescText = null;
			this.VisualNovelBackgroundConfig = null;
			this.CgConfig = null;
			this.DisplayItemConfig = null;
			this.PlotKeyId = 0;
			this.NullMask = 0U;
		}
	}
}
