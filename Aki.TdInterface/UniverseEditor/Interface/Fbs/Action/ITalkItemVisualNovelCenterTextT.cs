using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200730E RID: 29454
	public class ITalkItemVisualNovelCenterTextT
	{
		// Token: 0x1700DE38 RID: 56888
		// (get) Token: 0x060351DD RID: 217565 RVA: 0x00734FA3 File Offset: 0x007331A3
		// (set) Token: 0x060351DE RID: 217566 RVA: 0x00734FAB File Offset: 0x007331AB
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DE39 RID: 56889
		// (get) Token: 0x060351DF RID: 217567 RVA: 0x00734FB4 File Offset: 0x007331B4
		// (set) Token: 0x060351E0 RID: 217568 RVA: 0x00734FBC File Offset: 0x007331BC
		public int Id { get; set; }

		// Token: 0x1700DE3A RID: 56890
		// (get) Token: 0x060351E1 RID: 217569 RVA: 0x00734FC5 File Offset: 0x007331C5
		// (set) Token: 0x060351E2 RID: 217570 RVA: 0x00734FCD File Offset: 0x007331CD
		public int PlotLineId { get; set; }

		// Token: 0x1700DE3B RID: 56891
		// (get) Token: 0x060351E3 RID: 217571 RVA: 0x00734FD6 File Offset: 0x007331D6
		// (set) Token: 0x060351E4 RID: 217572 RVA: 0x00734FDE File Offset: 0x007331DE
		public string PlotLineKey { get; set; }

		// Token: 0x1700DE3C RID: 56892
		// (get) Token: 0x060351E5 RID: 217573 RVA: 0x00734FE7 File Offset: 0x007331E7
		// (set) Token: 0x060351E6 RID: 217574 RVA: 0x00734FEF File Offset: 0x007331EF
		public string Name { get; set; }

		// Token: 0x1700DE3D RID: 56893
		// (get) Token: 0x060351E7 RID: 217575 RVA: 0x00734FF8 File Offset: 0x007331F8
		// (set) Token: 0x060351E8 RID: 217576 RVA: 0x00735000 File Offset: 0x00733200
		public bool _Folded { get; set; }

		// Token: 0x1700DE3E RID: 56894
		// (get) Token: 0x060351E9 RID: 217577 RVA: 0x00735009 File Offset: 0x00733209
		// (set) Token: 0x060351EA RID: 217578 RVA: 0x00735011 File Offset: 0x00733211
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DE3F RID: 56895
		// (get) Token: 0x060351EB RID: 217579 RVA: 0x0073501A File Offset: 0x0073321A
		// (set) Token: 0x060351EC RID: 217580 RVA: 0x00735022 File Offset: 0x00733222
		public int WhoId { get; set; }

		// Token: 0x1700DE40 RID: 56896
		// (get) Token: 0x060351ED RID: 217581 RVA: 0x0073502B File Offset: 0x0073322B
		// (set) Token: 0x060351EE RID: 217582 RVA: 0x00735033 File Offset: 0x00733233
		public int TextId { get; set; }

		// Token: 0x1700DE41 RID: 56897
		// (get) Token: 0x060351EF RID: 217583 RVA: 0x0073503C File Offset: 0x0073323C
		// (set) Token: 0x060351F0 RID: 217584 RVA: 0x00735044 File Offset: 0x00733244
		public string TidTalk { get; set; }

		// Token: 0x1700DE42 RID: 56898
		// (get) Token: 0x060351F1 RID: 217585 RVA: 0x0073504D File Offset: 0x0073324D
		// (set) Token: 0x060351F2 RID: 217586 RVA: 0x00735055 File Offset: 0x00733255
		public float WaitTime { get; set; }

		// Token: 0x1700DE43 RID: 56899
		// (get) Token: 0x060351F3 RID: 217587 RVA: 0x0073505E File Offset: 0x0073325E
		// (set) Token: 0x060351F4 RID: 217588 RVA: 0x00735066 File Offset: 0x00733266
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DE44 RID: 56900
		// (get) Token: 0x060351F5 RID: 217589 RVA: 0x0073506F File Offset: 0x0073326F
		// (set) Token: 0x060351F6 RID: 217590 RVA: 0x00735077 File Offset: 0x00733277
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DE45 RID: 56901
		// (get) Token: 0x060351F7 RID: 217591 RVA: 0x00735080 File Offset: 0x00733280
		// (set) Token: 0x060351F8 RID: 217592 RVA: 0x00735088 File Offset: 0x00733288
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DE46 RID: 56902
		// (get) Token: 0x060351F9 RID: 217593 RVA: 0x00735091 File Offset: 0x00733291
		// (set) Token: 0x060351FA RID: 217594 RVA: 0x00735099 File Offset: 0x00733299
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DE47 RID: 56903
		// (get) Token: 0x060351FB RID: 217595 RVA: 0x007350A2 File Offset: 0x007332A2
		// (set) Token: 0x060351FC RID: 217596 RVA: 0x007350AA File Offset: 0x007332AA
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DE48 RID: 56904
		// (get) Token: 0x060351FD RID: 217597 RVA: 0x007350B3 File Offset: 0x007332B3
		// (set) Token: 0x060351FE RID: 217598 RVA: 0x007350BB File Offset: 0x007332BB
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DE49 RID: 56905
		// (get) Token: 0x060351FF RID: 217599 RVA: 0x007350C4 File Offset: 0x007332C4
		// (set) Token: 0x06035200 RID: 217600 RVA: 0x007350CC File Offset: 0x007332CC
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DE4A RID: 56906
		// (get) Token: 0x06035201 RID: 217601 RVA: 0x007350D5 File Offset: 0x007332D5
		// (set) Token: 0x06035202 RID: 217602 RVA: 0x007350DD File Offset: 0x007332DD
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DE4B RID: 56907
		// (get) Token: 0x06035203 RID: 217603 RVA: 0x007350E6 File Offset: 0x007332E6
		// (set) Token: 0x06035204 RID: 217604 RVA: 0x007350EE File Offset: 0x007332EE
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DE4C RID: 56908
		// (get) Token: 0x06035205 RID: 217605 RVA: 0x007350F7 File Offset: 0x007332F7
		// (set) Token: 0x06035206 RID: 217606 RVA: 0x007350FF File Offset: 0x007332FF
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DE4D RID: 56909
		// (get) Token: 0x06035207 RID: 217607 RVA: 0x00735108 File Offset: 0x00733308
		// (set) Token: 0x06035208 RID: 217608 RVA: 0x00735110 File Offset: 0x00733310
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DE4E RID: 56910
		// (get) Token: 0x06035209 RID: 217609 RVA: 0x00735119 File Offset: 0x00733319
		// (set) Token: 0x0603520A RID: 217610 RVA: 0x00735121 File Offset: 0x00733321
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DE4F RID: 56911
		// (get) Token: 0x0603520B RID: 217611 RVA: 0x0073512A File Offset: 0x0073332A
		// (set) Token: 0x0603520C RID: 217612 RVA: 0x00735132 File Offset: 0x00733332
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DE50 RID: 56912
		// (get) Token: 0x0603520D RID: 217613 RVA: 0x0073513B File Offset: 0x0073333B
		// (set) Token: 0x0603520E RID: 217614 RVA: 0x00735143 File Offset: 0x00733343
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DE51 RID: 56913
		// (get) Token: 0x0603520F RID: 217615 RVA: 0x0073514C File Offset: 0x0073334C
		// (set) Token: 0x06035210 RID: 217616 RVA: 0x00735154 File Offset: 0x00733354
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DE52 RID: 56914
		// (get) Token: 0x06035211 RID: 217617 RVA: 0x0073515D File Offset: 0x0073335D
		// (set) Token: 0x06035212 RID: 217618 RVA: 0x00735165 File Offset: 0x00733365
		public bool PlayVoice { get; set; }

		// Token: 0x1700DE53 RID: 56915
		// (get) Token: 0x06035213 RID: 217619 RVA: 0x0073516E File Offset: 0x0073336E
		// (set) Token: 0x06035214 RID: 217620 RVA: 0x00735176 File Offset: 0x00733376
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DE54 RID: 56916
		// (get) Token: 0x06035215 RID: 217621 RVA: 0x0073517F File Offset: 0x0073337F
		// (set) Token: 0x06035216 RID: 217622 RVA: 0x00735187 File Offset: 0x00733387
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DE55 RID: 56917
		// (get) Token: 0x06035217 RID: 217623 RVA: 0x00735190 File Offset: 0x00733390
		// (set) Token: 0x06035218 RID: 217624 RVA: 0x00735198 File Offset: 0x00733398
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DE56 RID: 56918
		// (get) Token: 0x06035219 RID: 217625 RVA: 0x007351A1 File Offset: 0x007333A1
		// (set) Token: 0x0603521A RID: 217626 RVA: 0x007351A9 File Offset: 0x007333A9
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DE57 RID: 56919
		// (get) Token: 0x0603521B RID: 217627 RVA: 0x007351B2 File Offset: 0x007333B2
		// (set) Token: 0x0603521C RID: 217628 RVA: 0x007351BA File Offset: 0x007333BA
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DE58 RID: 56920
		// (get) Token: 0x0603521D RID: 217629 RVA: 0x007351C3 File Offset: 0x007333C3
		// (set) Token: 0x0603521E RID: 217630 RVA: 0x007351CB File Offset: 0x007333CB
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DE59 RID: 56921
		// (get) Token: 0x0603521F RID: 217631 RVA: 0x007351D4 File Offset: 0x007333D4
		// (set) Token: 0x06035220 RID: 217632 RVA: 0x007351DC File Offset: 0x007333DC
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700DE5A RID: 56922
		// (get) Token: 0x06035221 RID: 217633 RVA: 0x007351E5 File Offset: 0x007333E5
		// (set) Token: 0x06035222 RID: 217634 RVA: 0x007351ED File Offset: 0x007333ED
		public IVisualNovelOptionGroupSolarSchoolExamT OptionGroup { get; set; }

		// Token: 0x1700DE5B RID: 56923
		// (get) Token: 0x06035223 RID: 217635 RVA: 0x007351F6 File Offset: 0x007333F6
		// (set) Token: 0x06035224 RID: 217636 RVA: 0x007351FE File Offset: 0x007333FE
		public int PlotKeyId { get; set; }

		// Token: 0x1700DE5C RID: 56924
		// (get) Token: 0x06035225 RID: 217637 RVA: 0x00735207 File Offset: 0x00733407
		// (set) Token: 0x06035226 RID: 217638 RVA: 0x0073520F File Offset: 0x0073340F
		public uint NullMask { get; set; }

		// Token: 0x06035227 RID: 217639 RVA: 0x00735218 File Offset: 0x00733418
		public ITalkItemVisualNovelCenterTextT()
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
			this.PlotKeyId = 0;
			this.NullMask = 0U;
		}
	}
}
