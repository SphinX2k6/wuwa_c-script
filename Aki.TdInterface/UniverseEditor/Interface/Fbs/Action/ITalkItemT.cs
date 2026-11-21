using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A92 RID: 31378
	public class ITalkItemT
	{
		// Token: 0x1700E5F9 RID: 58873
		// (get) Token: 0x060375A2 RID: 226722 RVA: 0x007653A3 File Offset: 0x007635A3
		// (set) Token: 0x060375A3 RID: 226723 RVA: 0x007653AB File Offset: 0x007635AB
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E5FA RID: 58874
		// (get) Token: 0x060375A4 RID: 226724 RVA: 0x007653B4 File Offset: 0x007635B4
		// (set) Token: 0x060375A5 RID: 226725 RVA: 0x007653BC File Offset: 0x007635BC
		public int Id { get; set; }

		// Token: 0x1700E5FB RID: 58875
		// (get) Token: 0x060375A6 RID: 226726 RVA: 0x007653C5 File Offset: 0x007635C5
		// (set) Token: 0x060375A7 RID: 226727 RVA: 0x007653CD File Offset: 0x007635CD
		public int PlotLineId { get; set; }

		// Token: 0x1700E5FC RID: 58876
		// (get) Token: 0x060375A8 RID: 226728 RVA: 0x007653D6 File Offset: 0x007635D6
		// (set) Token: 0x060375A9 RID: 226729 RVA: 0x007653DE File Offset: 0x007635DE
		public string PlotLineKey { get; set; }

		// Token: 0x1700E5FD RID: 58877
		// (get) Token: 0x060375AA RID: 226730 RVA: 0x007653E7 File Offset: 0x007635E7
		// (set) Token: 0x060375AB RID: 226731 RVA: 0x007653EF File Offset: 0x007635EF
		public string Name { get; set; }

		// Token: 0x1700E5FE RID: 58878
		// (get) Token: 0x060375AC RID: 226732 RVA: 0x007653F8 File Offset: 0x007635F8
		// (set) Token: 0x060375AD RID: 226733 RVA: 0x00765400 File Offset: 0x00763600
		public bool _Folded { get; set; }

		// Token: 0x1700E5FF RID: 58879
		// (get) Token: 0x060375AE RID: 226734 RVA: 0x00765409 File Offset: 0x00763609
		// (set) Token: 0x060375AF RID: 226735 RVA: 0x00765411 File Offset: 0x00763611
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E600 RID: 58880
		// (get) Token: 0x060375B0 RID: 226736 RVA: 0x0076541A File Offset: 0x0076361A
		// (set) Token: 0x060375B1 RID: 226737 RVA: 0x00765422 File Offset: 0x00763622
		public int WhoId { get; set; }

		// Token: 0x1700E601 RID: 58881
		// (get) Token: 0x060375B2 RID: 226738 RVA: 0x0076542B File Offset: 0x0076362B
		// (set) Token: 0x060375B3 RID: 226739 RVA: 0x00765433 File Offset: 0x00763633
		public int TextId { get; set; }

		// Token: 0x1700E602 RID: 58882
		// (get) Token: 0x060375B4 RID: 226740 RVA: 0x0076543C File Offset: 0x0076363C
		// (set) Token: 0x060375B5 RID: 226741 RVA: 0x00765444 File Offset: 0x00763644
		public string TidTalk { get; set; }

		// Token: 0x1700E603 RID: 58883
		// (get) Token: 0x060375B6 RID: 226742 RVA: 0x0076544D File Offset: 0x0076364D
		// (set) Token: 0x060375B7 RID: 226743 RVA: 0x00765455 File Offset: 0x00763655
		public float WaitTime { get; set; }

		// Token: 0x1700E604 RID: 58884
		// (get) Token: 0x060375B8 RID: 226744 RVA: 0x0076545E File Offset: 0x0076365E
		// (set) Token: 0x060375B9 RID: 226745 RVA: 0x00765466 File Offset: 0x00763666
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E605 RID: 58885
		// (get) Token: 0x060375BA RID: 226746 RVA: 0x0076546F File Offset: 0x0076366F
		// (set) Token: 0x060375BB RID: 226747 RVA: 0x00765477 File Offset: 0x00763677
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E606 RID: 58886
		// (get) Token: 0x060375BC RID: 226748 RVA: 0x00765480 File Offset: 0x00763680
		// (set) Token: 0x060375BD RID: 226749 RVA: 0x00765488 File Offset: 0x00763688
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E607 RID: 58887
		// (get) Token: 0x060375BE RID: 226750 RVA: 0x00765491 File Offset: 0x00763691
		// (set) Token: 0x060375BF RID: 226751 RVA: 0x00765499 File Offset: 0x00763699
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E608 RID: 58888
		// (get) Token: 0x060375C0 RID: 226752 RVA: 0x007654A2 File Offset: 0x007636A2
		// (set) Token: 0x060375C1 RID: 226753 RVA: 0x007654AA File Offset: 0x007636AA
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E609 RID: 58889
		// (get) Token: 0x060375C2 RID: 226754 RVA: 0x007654B3 File Offset: 0x007636B3
		// (set) Token: 0x060375C3 RID: 226755 RVA: 0x007654BB File Offset: 0x007636BB
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E60A RID: 58890
		// (get) Token: 0x060375C4 RID: 226756 RVA: 0x007654C4 File Offset: 0x007636C4
		// (set) Token: 0x060375C5 RID: 226757 RVA: 0x007654CC File Offset: 0x007636CC
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E60B RID: 58891
		// (get) Token: 0x060375C6 RID: 226758 RVA: 0x007654D5 File Offset: 0x007636D5
		// (set) Token: 0x060375C7 RID: 226759 RVA: 0x007654DD File Offset: 0x007636DD
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E60C RID: 58892
		// (get) Token: 0x060375C8 RID: 226760 RVA: 0x007654E6 File Offset: 0x007636E6
		// (set) Token: 0x060375C9 RID: 226761 RVA: 0x007654EE File Offset: 0x007636EE
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E60D RID: 58893
		// (get) Token: 0x060375CA RID: 226762 RVA: 0x007654F7 File Offset: 0x007636F7
		// (set) Token: 0x060375CB RID: 226763 RVA: 0x007654FF File Offset: 0x007636FF
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E60E RID: 58894
		// (get) Token: 0x060375CC RID: 226764 RVA: 0x00765508 File Offset: 0x00763708
		// (set) Token: 0x060375CD RID: 226765 RVA: 0x00765510 File Offset: 0x00763710
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E60F RID: 58895
		// (get) Token: 0x060375CE RID: 226766 RVA: 0x00765519 File Offset: 0x00763719
		// (set) Token: 0x060375CF RID: 226767 RVA: 0x00765521 File Offset: 0x00763721
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E610 RID: 58896
		// (get) Token: 0x060375D0 RID: 226768 RVA: 0x0076552A File Offset: 0x0076372A
		// (set) Token: 0x060375D1 RID: 226769 RVA: 0x00765532 File Offset: 0x00763732
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E611 RID: 58897
		// (get) Token: 0x060375D2 RID: 226770 RVA: 0x0076553B File Offset: 0x0076373B
		// (set) Token: 0x060375D3 RID: 226771 RVA: 0x00765543 File Offset: 0x00763743
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E612 RID: 58898
		// (get) Token: 0x060375D4 RID: 226772 RVA: 0x0076554C File Offset: 0x0076374C
		// (set) Token: 0x060375D5 RID: 226773 RVA: 0x00765554 File Offset: 0x00763754
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E613 RID: 58899
		// (get) Token: 0x060375D6 RID: 226774 RVA: 0x0076555D File Offset: 0x0076375D
		// (set) Token: 0x060375D7 RID: 226775 RVA: 0x00765565 File Offset: 0x00763765
		public bool PlayVoice { get; set; }

		// Token: 0x1700E614 RID: 58900
		// (get) Token: 0x060375D8 RID: 226776 RVA: 0x0076556E File Offset: 0x0076376E
		// (set) Token: 0x060375D9 RID: 226777 RVA: 0x00765576 File Offset: 0x00763776
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E615 RID: 58901
		// (get) Token: 0x060375DA RID: 226778 RVA: 0x0076557F File Offset: 0x0076377F
		// (set) Token: 0x060375DB RID: 226779 RVA: 0x00765587 File Offset: 0x00763787
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E616 RID: 58902
		// (get) Token: 0x060375DC RID: 226780 RVA: 0x00765590 File Offset: 0x00763790
		// (set) Token: 0x060375DD RID: 226781 RVA: 0x00765598 File Offset: 0x00763798
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E617 RID: 58903
		// (get) Token: 0x060375DE RID: 226782 RVA: 0x007655A1 File Offset: 0x007637A1
		// (set) Token: 0x060375DF RID: 226783 RVA: 0x007655A9 File Offset: 0x007637A9
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E618 RID: 58904
		// (get) Token: 0x060375E0 RID: 226784 RVA: 0x007655B2 File Offset: 0x007637B2
		// (set) Token: 0x060375E1 RID: 226785 RVA: 0x007655BA File Offset: 0x007637BA
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E619 RID: 58905
		// (get) Token: 0x060375E2 RID: 226786 RVA: 0x007655C3 File Offset: 0x007637C3
		// (set) Token: 0x060375E3 RID: 226787 RVA: 0x007655CB File Offset: 0x007637CB
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E61A RID: 58906
		// (get) Token: 0x060375E4 RID: 226788 RVA: 0x007655D4 File Offset: 0x007637D4
		// (set) Token: 0x060375E5 RID: 226789 RVA: 0x007655DC File Offset: 0x007637DC
		public uint NullMask { get; set; }

		// Token: 0x060375E6 RID: 226790 RVA: 0x007655E8 File Offset: 0x007637E8
		public ITalkItemT()
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
			this.NullMask = 0U;
		}
	}
}
