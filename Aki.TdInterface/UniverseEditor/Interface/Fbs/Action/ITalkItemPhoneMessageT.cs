using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E7 RID: 29415
	public class ITalkItemPhoneMessageT
	{
		// Token: 0x1700DD36 RID: 56630
		// (get) Token: 0x06034E0F RID: 216591 RVA: 0x00729C1B File Offset: 0x00727E1B
		// (set) Token: 0x06034E10 RID: 216592 RVA: 0x00729C23 File Offset: 0x00727E23
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DD37 RID: 56631
		// (get) Token: 0x06034E11 RID: 216593 RVA: 0x00729C2C File Offset: 0x00727E2C
		// (set) Token: 0x06034E12 RID: 216594 RVA: 0x00729C34 File Offset: 0x00727E34
		public int Id { get; set; }

		// Token: 0x1700DD38 RID: 56632
		// (get) Token: 0x06034E13 RID: 216595 RVA: 0x00729C3D File Offset: 0x00727E3D
		// (set) Token: 0x06034E14 RID: 216596 RVA: 0x00729C45 File Offset: 0x00727E45
		public int PlotLineId { get; set; }

		// Token: 0x1700DD39 RID: 56633
		// (get) Token: 0x06034E15 RID: 216597 RVA: 0x00729C4E File Offset: 0x00727E4E
		// (set) Token: 0x06034E16 RID: 216598 RVA: 0x00729C56 File Offset: 0x00727E56
		public string PlotLineKey { get; set; }

		// Token: 0x1700DD3A RID: 56634
		// (get) Token: 0x06034E17 RID: 216599 RVA: 0x00729C5F File Offset: 0x00727E5F
		// (set) Token: 0x06034E18 RID: 216600 RVA: 0x00729C67 File Offset: 0x00727E67
		public string Name { get; set; }

		// Token: 0x1700DD3B RID: 56635
		// (get) Token: 0x06034E19 RID: 216601 RVA: 0x00729C70 File Offset: 0x00727E70
		// (set) Token: 0x06034E1A RID: 216602 RVA: 0x00729C78 File Offset: 0x00727E78
		public bool _Folded { get; set; }

		// Token: 0x1700DD3C RID: 56636
		// (get) Token: 0x06034E1B RID: 216603 RVA: 0x00729C81 File Offset: 0x00727E81
		// (set) Token: 0x06034E1C RID: 216604 RVA: 0x00729C89 File Offset: 0x00727E89
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DD3D RID: 56637
		// (get) Token: 0x06034E1D RID: 216605 RVA: 0x00729C92 File Offset: 0x00727E92
		// (set) Token: 0x06034E1E RID: 216606 RVA: 0x00729C9A File Offset: 0x00727E9A
		public int WhoId { get; set; }

		// Token: 0x1700DD3E RID: 56638
		// (get) Token: 0x06034E1F RID: 216607 RVA: 0x00729CA3 File Offset: 0x00727EA3
		// (set) Token: 0x06034E20 RID: 216608 RVA: 0x00729CAB File Offset: 0x00727EAB
		public int TextId { get; set; }

		// Token: 0x1700DD3F RID: 56639
		// (get) Token: 0x06034E21 RID: 216609 RVA: 0x00729CB4 File Offset: 0x00727EB4
		// (set) Token: 0x06034E22 RID: 216610 RVA: 0x00729CBC File Offset: 0x00727EBC
		public string TidTalk { get; set; }

		// Token: 0x1700DD40 RID: 56640
		// (get) Token: 0x06034E23 RID: 216611 RVA: 0x00729CC5 File Offset: 0x00727EC5
		// (set) Token: 0x06034E24 RID: 216612 RVA: 0x00729CCD File Offset: 0x00727ECD
		public float WaitTime { get; set; }

		// Token: 0x1700DD41 RID: 56641
		// (get) Token: 0x06034E25 RID: 216613 RVA: 0x00729CD6 File Offset: 0x00727ED6
		// (set) Token: 0x06034E26 RID: 216614 RVA: 0x00729CDE File Offset: 0x00727EDE
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DD42 RID: 56642
		// (get) Token: 0x06034E27 RID: 216615 RVA: 0x00729CE7 File Offset: 0x00727EE7
		// (set) Token: 0x06034E28 RID: 216616 RVA: 0x00729CEF File Offset: 0x00727EEF
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DD43 RID: 56643
		// (get) Token: 0x06034E29 RID: 216617 RVA: 0x00729CF8 File Offset: 0x00727EF8
		// (set) Token: 0x06034E2A RID: 216618 RVA: 0x00729D00 File Offset: 0x00727F00
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DD44 RID: 56644
		// (get) Token: 0x06034E2B RID: 216619 RVA: 0x00729D09 File Offset: 0x00727F09
		// (set) Token: 0x06034E2C RID: 216620 RVA: 0x00729D11 File Offset: 0x00727F11
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DD45 RID: 56645
		// (get) Token: 0x06034E2D RID: 216621 RVA: 0x00729D1A File Offset: 0x00727F1A
		// (set) Token: 0x06034E2E RID: 216622 RVA: 0x00729D22 File Offset: 0x00727F22
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DD46 RID: 56646
		// (get) Token: 0x06034E2F RID: 216623 RVA: 0x00729D2B File Offset: 0x00727F2B
		// (set) Token: 0x06034E30 RID: 216624 RVA: 0x00729D33 File Offset: 0x00727F33
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DD47 RID: 56647
		// (get) Token: 0x06034E31 RID: 216625 RVA: 0x00729D3C File Offset: 0x00727F3C
		// (set) Token: 0x06034E32 RID: 216626 RVA: 0x00729D44 File Offset: 0x00727F44
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DD48 RID: 56648
		// (get) Token: 0x06034E33 RID: 216627 RVA: 0x00729D4D File Offset: 0x00727F4D
		// (set) Token: 0x06034E34 RID: 216628 RVA: 0x00729D55 File Offset: 0x00727F55
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DD49 RID: 56649
		// (get) Token: 0x06034E35 RID: 216629 RVA: 0x00729D5E File Offset: 0x00727F5E
		// (set) Token: 0x06034E36 RID: 216630 RVA: 0x00729D66 File Offset: 0x00727F66
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DD4A RID: 56650
		// (get) Token: 0x06034E37 RID: 216631 RVA: 0x00729D6F File Offset: 0x00727F6F
		// (set) Token: 0x06034E38 RID: 216632 RVA: 0x00729D77 File Offset: 0x00727F77
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DD4B RID: 56651
		// (get) Token: 0x06034E39 RID: 216633 RVA: 0x00729D80 File Offset: 0x00727F80
		// (set) Token: 0x06034E3A RID: 216634 RVA: 0x00729D88 File Offset: 0x00727F88
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DD4C RID: 56652
		// (get) Token: 0x06034E3B RID: 216635 RVA: 0x00729D91 File Offset: 0x00727F91
		// (set) Token: 0x06034E3C RID: 216636 RVA: 0x00729D99 File Offset: 0x00727F99
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DD4D RID: 56653
		// (get) Token: 0x06034E3D RID: 216637 RVA: 0x00729DA2 File Offset: 0x00727FA2
		// (set) Token: 0x06034E3E RID: 216638 RVA: 0x00729DAA File Offset: 0x00727FAA
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DD4E RID: 56654
		// (get) Token: 0x06034E3F RID: 216639 RVA: 0x00729DB3 File Offset: 0x00727FB3
		// (set) Token: 0x06034E40 RID: 216640 RVA: 0x00729DBB File Offset: 0x00727FBB
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DD4F RID: 56655
		// (get) Token: 0x06034E41 RID: 216641 RVA: 0x00729DC4 File Offset: 0x00727FC4
		// (set) Token: 0x06034E42 RID: 216642 RVA: 0x00729DCC File Offset: 0x00727FCC
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DD50 RID: 56656
		// (get) Token: 0x06034E43 RID: 216643 RVA: 0x00729DD5 File Offset: 0x00727FD5
		// (set) Token: 0x06034E44 RID: 216644 RVA: 0x00729DDD File Offset: 0x00727FDD
		public bool PlayVoice { get; set; }

		// Token: 0x1700DD51 RID: 56657
		// (get) Token: 0x06034E45 RID: 216645 RVA: 0x00729DE6 File Offset: 0x00727FE6
		// (set) Token: 0x06034E46 RID: 216646 RVA: 0x00729DEE File Offset: 0x00727FEE
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DD52 RID: 56658
		// (get) Token: 0x06034E47 RID: 216647 RVA: 0x00729DF7 File Offset: 0x00727FF7
		// (set) Token: 0x06034E48 RID: 216648 RVA: 0x00729DFF File Offset: 0x00727FFF
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DD53 RID: 56659
		// (get) Token: 0x06034E49 RID: 216649 RVA: 0x00729E08 File Offset: 0x00728008
		// (set) Token: 0x06034E4A RID: 216650 RVA: 0x00729E10 File Offset: 0x00728010
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DD54 RID: 56660
		// (get) Token: 0x06034E4B RID: 216651 RVA: 0x00729E19 File Offset: 0x00728019
		// (set) Token: 0x06034E4C RID: 216652 RVA: 0x00729E21 File Offset: 0x00728021
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DD55 RID: 56661
		// (get) Token: 0x06034E4D RID: 216653 RVA: 0x00729E2A File Offset: 0x0072802A
		// (set) Token: 0x06034E4E RID: 216654 RVA: 0x00729E32 File Offset: 0x00728032
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DD56 RID: 56662
		// (get) Token: 0x06034E4F RID: 216655 RVA: 0x00729E3B File Offset: 0x0072803B
		// (set) Token: 0x06034E50 RID: 216656 RVA: 0x00729E43 File Offset: 0x00728043
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DD57 RID: 56663
		// (get) Token: 0x06034E51 RID: 216657 RVA: 0x00729E4C File Offset: 0x0072804C
		// (set) Token: 0x06034E52 RID: 216658 RVA: 0x00729E54 File Offset: 0x00728054
		public TPhoneMessageTypeUnion MessageType { get; set; }

		// Token: 0x1700DD58 RID: 56664
		// (get) Token: 0x06034E53 RID: 216659 RVA: 0x00729E5D File Offset: 0x0072805D
		// (set) Token: 0x06034E54 RID: 216660 RVA: 0x00729E65 File Offset: 0x00728065
		public TTalkItemStyleUnion Style { get; set; }

		// Token: 0x1700DD59 RID: 56665
		// (get) Token: 0x06034E55 RID: 216661 RVA: 0x00729E6E File Offset: 0x0072806E
		// (set) Token: 0x06034E56 RID: 216662 RVA: 0x00729E76 File Offset: 0x00728076
		public float OtherIsTypingDuration { get; set; }

		// Token: 0x1700DD5A RID: 56666
		// (get) Token: 0x06034E57 RID: 216663 RVA: 0x00729E7F File Offset: 0x0072807F
		// (set) Token: 0x06034E58 RID: 216664 RVA: 0x00729E87 File Offset: 0x00728087
		public uint NullMask { get; set; }

		// Token: 0x06034E59 RID: 216665 RVA: 0x00729E90 File Offset: 0x00728090
		public ITalkItemPhoneMessageT()
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
			this.MessageType = null;
			this.Style = null;
			this.OtherIsTypingDuration = 0f;
			this.NullMask = 0U;
		}
	}
}
