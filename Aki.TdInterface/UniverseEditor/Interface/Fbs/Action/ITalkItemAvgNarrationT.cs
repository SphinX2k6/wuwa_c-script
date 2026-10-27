using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072CC RID: 29388
	public class ITalkItemAvgNarrationT
	{
		// Token: 0x1700DB21 RID: 56097
		// (get) Token: 0x060346A8 RID: 214696 RVA: 0x00711573 File Offset: 0x0070F773
		// (set) Token: 0x060346A9 RID: 214697 RVA: 0x0071157B File Offset: 0x0070F77B
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DB22 RID: 56098
		// (get) Token: 0x060346AA RID: 214698 RVA: 0x00711584 File Offset: 0x0070F784
		// (set) Token: 0x060346AB RID: 214699 RVA: 0x0071158C File Offset: 0x0070F78C
		public int Id { get; set; }

		// Token: 0x1700DB23 RID: 56099
		// (get) Token: 0x060346AC RID: 214700 RVA: 0x00711595 File Offset: 0x0070F795
		// (set) Token: 0x060346AD RID: 214701 RVA: 0x0071159D File Offset: 0x0070F79D
		public int PlotLineId { get; set; }

		// Token: 0x1700DB24 RID: 56100
		// (get) Token: 0x060346AE RID: 214702 RVA: 0x007115A6 File Offset: 0x0070F7A6
		// (set) Token: 0x060346AF RID: 214703 RVA: 0x007115AE File Offset: 0x0070F7AE
		public string PlotLineKey { get; set; }

		// Token: 0x1700DB25 RID: 56101
		// (get) Token: 0x060346B0 RID: 214704 RVA: 0x007115B7 File Offset: 0x0070F7B7
		// (set) Token: 0x060346B1 RID: 214705 RVA: 0x007115BF File Offset: 0x0070F7BF
		public string Name { get; set; }

		// Token: 0x1700DB26 RID: 56102
		// (get) Token: 0x060346B2 RID: 214706 RVA: 0x007115C8 File Offset: 0x0070F7C8
		// (set) Token: 0x060346B3 RID: 214707 RVA: 0x007115D0 File Offset: 0x0070F7D0
		public bool _Folded { get; set; }

		// Token: 0x1700DB27 RID: 56103
		// (get) Token: 0x060346B4 RID: 214708 RVA: 0x007115D9 File Offset: 0x0070F7D9
		// (set) Token: 0x060346B5 RID: 214709 RVA: 0x007115E1 File Offset: 0x0070F7E1
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DB28 RID: 56104
		// (get) Token: 0x060346B6 RID: 214710 RVA: 0x007115EA File Offset: 0x0070F7EA
		// (set) Token: 0x060346B7 RID: 214711 RVA: 0x007115F2 File Offset: 0x0070F7F2
		public int WhoId { get; set; }

		// Token: 0x1700DB29 RID: 56105
		// (get) Token: 0x060346B8 RID: 214712 RVA: 0x007115FB File Offset: 0x0070F7FB
		// (set) Token: 0x060346B9 RID: 214713 RVA: 0x00711603 File Offset: 0x0070F803
		public int TextId { get; set; }

		// Token: 0x1700DB2A RID: 56106
		// (get) Token: 0x060346BA RID: 214714 RVA: 0x0071160C File Offset: 0x0070F80C
		// (set) Token: 0x060346BB RID: 214715 RVA: 0x00711614 File Offset: 0x0070F814
		public string TidTalk { get; set; }

		// Token: 0x1700DB2B RID: 56107
		// (get) Token: 0x060346BC RID: 214716 RVA: 0x0071161D File Offset: 0x0070F81D
		// (set) Token: 0x060346BD RID: 214717 RVA: 0x00711625 File Offset: 0x0070F825
		public float WaitTime { get; set; }

		// Token: 0x1700DB2C RID: 56108
		// (get) Token: 0x060346BE RID: 214718 RVA: 0x0071162E File Offset: 0x0070F82E
		// (set) Token: 0x060346BF RID: 214719 RVA: 0x00711636 File Offset: 0x0070F836
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DB2D RID: 56109
		// (get) Token: 0x060346C0 RID: 214720 RVA: 0x0071163F File Offset: 0x0070F83F
		// (set) Token: 0x060346C1 RID: 214721 RVA: 0x00711647 File Offset: 0x0070F847
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DB2E RID: 56110
		// (get) Token: 0x060346C2 RID: 214722 RVA: 0x00711650 File Offset: 0x0070F850
		// (set) Token: 0x060346C3 RID: 214723 RVA: 0x00711658 File Offset: 0x0070F858
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DB2F RID: 56111
		// (get) Token: 0x060346C4 RID: 214724 RVA: 0x00711661 File Offset: 0x0070F861
		// (set) Token: 0x060346C5 RID: 214725 RVA: 0x00711669 File Offset: 0x0070F869
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DB30 RID: 56112
		// (get) Token: 0x060346C6 RID: 214726 RVA: 0x00711672 File Offset: 0x0070F872
		// (set) Token: 0x060346C7 RID: 214727 RVA: 0x0071167A File Offset: 0x0070F87A
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DB31 RID: 56113
		// (get) Token: 0x060346C8 RID: 214728 RVA: 0x00711683 File Offset: 0x0070F883
		// (set) Token: 0x060346C9 RID: 214729 RVA: 0x0071168B File Offset: 0x0070F88B
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DB32 RID: 56114
		// (get) Token: 0x060346CA RID: 214730 RVA: 0x00711694 File Offset: 0x0070F894
		// (set) Token: 0x060346CB RID: 214731 RVA: 0x0071169C File Offset: 0x0070F89C
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DB33 RID: 56115
		// (get) Token: 0x060346CC RID: 214732 RVA: 0x007116A5 File Offset: 0x0070F8A5
		// (set) Token: 0x060346CD RID: 214733 RVA: 0x007116AD File Offset: 0x0070F8AD
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DB34 RID: 56116
		// (get) Token: 0x060346CE RID: 214734 RVA: 0x007116B6 File Offset: 0x0070F8B6
		// (set) Token: 0x060346CF RID: 214735 RVA: 0x007116BE File Offset: 0x0070F8BE
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DB35 RID: 56117
		// (get) Token: 0x060346D0 RID: 214736 RVA: 0x007116C7 File Offset: 0x0070F8C7
		// (set) Token: 0x060346D1 RID: 214737 RVA: 0x007116CF File Offset: 0x0070F8CF
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DB36 RID: 56118
		// (get) Token: 0x060346D2 RID: 214738 RVA: 0x007116D8 File Offset: 0x0070F8D8
		// (set) Token: 0x060346D3 RID: 214739 RVA: 0x007116E0 File Offset: 0x0070F8E0
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DB37 RID: 56119
		// (get) Token: 0x060346D4 RID: 214740 RVA: 0x007116E9 File Offset: 0x0070F8E9
		// (set) Token: 0x060346D5 RID: 214741 RVA: 0x007116F1 File Offset: 0x0070F8F1
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DB38 RID: 56120
		// (get) Token: 0x060346D6 RID: 214742 RVA: 0x007116FA File Offset: 0x0070F8FA
		// (set) Token: 0x060346D7 RID: 214743 RVA: 0x00711702 File Offset: 0x0070F902
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DB39 RID: 56121
		// (get) Token: 0x060346D8 RID: 214744 RVA: 0x0071170B File Offset: 0x0070F90B
		// (set) Token: 0x060346D9 RID: 214745 RVA: 0x00711713 File Offset: 0x0070F913
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DB3A RID: 56122
		// (get) Token: 0x060346DA RID: 214746 RVA: 0x0071171C File Offset: 0x0070F91C
		// (set) Token: 0x060346DB RID: 214747 RVA: 0x00711724 File Offset: 0x0070F924
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DB3B RID: 56123
		// (get) Token: 0x060346DC RID: 214748 RVA: 0x0071172D File Offset: 0x0070F92D
		// (set) Token: 0x060346DD RID: 214749 RVA: 0x00711735 File Offset: 0x0070F935
		public bool PlayVoice { get; set; }

		// Token: 0x1700DB3C RID: 56124
		// (get) Token: 0x060346DE RID: 214750 RVA: 0x0071173E File Offset: 0x0070F93E
		// (set) Token: 0x060346DF RID: 214751 RVA: 0x00711746 File Offset: 0x0070F946
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DB3D RID: 56125
		// (get) Token: 0x060346E0 RID: 214752 RVA: 0x0071174F File Offset: 0x0070F94F
		// (set) Token: 0x060346E1 RID: 214753 RVA: 0x00711757 File Offset: 0x0070F957
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DB3E RID: 56126
		// (get) Token: 0x060346E2 RID: 214754 RVA: 0x00711760 File Offset: 0x0070F960
		// (set) Token: 0x060346E3 RID: 214755 RVA: 0x00711768 File Offset: 0x0070F968
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DB3F RID: 56127
		// (get) Token: 0x060346E4 RID: 214756 RVA: 0x00711771 File Offset: 0x0070F971
		// (set) Token: 0x060346E5 RID: 214757 RVA: 0x00711779 File Offset: 0x0070F979
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DB40 RID: 56128
		// (get) Token: 0x060346E6 RID: 214758 RVA: 0x00711782 File Offset: 0x0070F982
		// (set) Token: 0x060346E7 RID: 214759 RVA: 0x0071178A File Offset: 0x0070F98A
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DB41 RID: 56129
		// (get) Token: 0x060346E8 RID: 214760 RVA: 0x00711793 File Offset: 0x0070F993
		// (set) Token: 0x060346E9 RID: 214761 RVA: 0x0071179B File Offset: 0x0070F99B
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DB42 RID: 56130
		// (get) Token: 0x060346EA RID: 214762 RVA: 0x007117A4 File Offset: 0x0070F9A4
		// (set) Token: 0x060346EB RID: 214763 RVA: 0x007117AC File Offset: 0x0070F9AC
		public uint NullMask { get; set; }

		// Token: 0x060346EC RID: 214764 RVA: 0x007117B8 File Offset: 0x0070F9B8
		public ITalkItemAvgNarrationT()
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
