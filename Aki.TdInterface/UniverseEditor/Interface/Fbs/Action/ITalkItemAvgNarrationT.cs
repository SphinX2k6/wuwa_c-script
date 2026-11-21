using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AA1 RID: 31393
	public class ITalkItemAvgNarrationT
	{
		// Token: 0x1700E71A RID: 59162
		// (get) Token: 0x060379AC RID: 227756 RVA: 0x0077290F File Offset: 0x00770B0F
		// (set) Token: 0x060379AD RID: 227757 RVA: 0x00772917 File Offset: 0x00770B17
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E71B RID: 59163
		// (get) Token: 0x060379AE RID: 227758 RVA: 0x00772920 File Offset: 0x00770B20
		// (set) Token: 0x060379AF RID: 227759 RVA: 0x00772928 File Offset: 0x00770B28
		public int Id { get; set; }

		// Token: 0x1700E71C RID: 59164
		// (get) Token: 0x060379B0 RID: 227760 RVA: 0x00772931 File Offset: 0x00770B31
		// (set) Token: 0x060379B1 RID: 227761 RVA: 0x00772939 File Offset: 0x00770B39
		public int PlotLineId { get; set; }

		// Token: 0x1700E71D RID: 59165
		// (get) Token: 0x060379B2 RID: 227762 RVA: 0x00772942 File Offset: 0x00770B42
		// (set) Token: 0x060379B3 RID: 227763 RVA: 0x0077294A File Offset: 0x00770B4A
		public string PlotLineKey { get; set; }

		// Token: 0x1700E71E RID: 59166
		// (get) Token: 0x060379B4 RID: 227764 RVA: 0x00772953 File Offset: 0x00770B53
		// (set) Token: 0x060379B5 RID: 227765 RVA: 0x0077295B File Offset: 0x00770B5B
		public string Name { get; set; }

		// Token: 0x1700E71F RID: 59167
		// (get) Token: 0x060379B6 RID: 227766 RVA: 0x00772964 File Offset: 0x00770B64
		// (set) Token: 0x060379B7 RID: 227767 RVA: 0x0077296C File Offset: 0x00770B6C
		public bool _Folded { get; set; }

		// Token: 0x1700E720 RID: 59168
		// (get) Token: 0x060379B8 RID: 227768 RVA: 0x00772975 File Offset: 0x00770B75
		// (set) Token: 0x060379B9 RID: 227769 RVA: 0x0077297D File Offset: 0x00770B7D
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E721 RID: 59169
		// (get) Token: 0x060379BA RID: 227770 RVA: 0x00772986 File Offset: 0x00770B86
		// (set) Token: 0x060379BB RID: 227771 RVA: 0x0077298E File Offset: 0x00770B8E
		public int WhoId { get; set; }

		// Token: 0x1700E722 RID: 59170
		// (get) Token: 0x060379BC RID: 227772 RVA: 0x00772997 File Offset: 0x00770B97
		// (set) Token: 0x060379BD RID: 227773 RVA: 0x0077299F File Offset: 0x00770B9F
		public int TextId { get; set; }

		// Token: 0x1700E723 RID: 59171
		// (get) Token: 0x060379BE RID: 227774 RVA: 0x007729A8 File Offset: 0x00770BA8
		// (set) Token: 0x060379BF RID: 227775 RVA: 0x007729B0 File Offset: 0x00770BB0
		public string TidTalk { get; set; }

		// Token: 0x1700E724 RID: 59172
		// (get) Token: 0x060379C0 RID: 227776 RVA: 0x007729B9 File Offset: 0x00770BB9
		// (set) Token: 0x060379C1 RID: 227777 RVA: 0x007729C1 File Offset: 0x00770BC1
		public float WaitTime { get; set; }

		// Token: 0x1700E725 RID: 59173
		// (get) Token: 0x060379C2 RID: 227778 RVA: 0x007729CA File Offset: 0x00770BCA
		// (set) Token: 0x060379C3 RID: 227779 RVA: 0x007729D2 File Offset: 0x00770BD2
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E726 RID: 59174
		// (get) Token: 0x060379C4 RID: 227780 RVA: 0x007729DB File Offset: 0x00770BDB
		// (set) Token: 0x060379C5 RID: 227781 RVA: 0x007729E3 File Offset: 0x00770BE3
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E727 RID: 59175
		// (get) Token: 0x060379C6 RID: 227782 RVA: 0x007729EC File Offset: 0x00770BEC
		// (set) Token: 0x060379C7 RID: 227783 RVA: 0x007729F4 File Offset: 0x00770BF4
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E728 RID: 59176
		// (get) Token: 0x060379C8 RID: 227784 RVA: 0x007729FD File Offset: 0x00770BFD
		// (set) Token: 0x060379C9 RID: 227785 RVA: 0x00772A05 File Offset: 0x00770C05
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E729 RID: 59177
		// (get) Token: 0x060379CA RID: 227786 RVA: 0x00772A0E File Offset: 0x00770C0E
		// (set) Token: 0x060379CB RID: 227787 RVA: 0x00772A16 File Offset: 0x00770C16
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E72A RID: 59178
		// (get) Token: 0x060379CC RID: 227788 RVA: 0x00772A1F File Offset: 0x00770C1F
		// (set) Token: 0x060379CD RID: 227789 RVA: 0x00772A27 File Offset: 0x00770C27
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E72B RID: 59179
		// (get) Token: 0x060379CE RID: 227790 RVA: 0x00772A30 File Offset: 0x00770C30
		// (set) Token: 0x060379CF RID: 227791 RVA: 0x00772A38 File Offset: 0x00770C38
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E72C RID: 59180
		// (get) Token: 0x060379D0 RID: 227792 RVA: 0x00772A41 File Offset: 0x00770C41
		// (set) Token: 0x060379D1 RID: 227793 RVA: 0x00772A49 File Offset: 0x00770C49
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E72D RID: 59181
		// (get) Token: 0x060379D2 RID: 227794 RVA: 0x00772A52 File Offset: 0x00770C52
		// (set) Token: 0x060379D3 RID: 227795 RVA: 0x00772A5A File Offset: 0x00770C5A
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E72E RID: 59182
		// (get) Token: 0x060379D4 RID: 227796 RVA: 0x00772A63 File Offset: 0x00770C63
		// (set) Token: 0x060379D5 RID: 227797 RVA: 0x00772A6B File Offset: 0x00770C6B
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E72F RID: 59183
		// (get) Token: 0x060379D6 RID: 227798 RVA: 0x00772A74 File Offset: 0x00770C74
		// (set) Token: 0x060379D7 RID: 227799 RVA: 0x00772A7C File Offset: 0x00770C7C
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E730 RID: 59184
		// (get) Token: 0x060379D8 RID: 227800 RVA: 0x00772A85 File Offset: 0x00770C85
		// (set) Token: 0x060379D9 RID: 227801 RVA: 0x00772A8D File Offset: 0x00770C8D
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E731 RID: 59185
		// (get) Token: 0x060379DA RID: 227802 RVA: 0x00772A96 File Offset: 0x00770C96
		// (set) Token: 0x060379DB RID: 227803 RVA: 0x00772A9E File Offset: 0x00770C9E
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E732 RID: 59186
		// (get) Token: 0x060379DC RID: 227804 RVA: 0x00772AA7 File Offset: 0x00770CA7
		// (set) Token: 0x060379DD RID: 227805 RVA: 0x00772AAF File Offset: 0x00770CAF
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E733 RID: 59187
		// (get) Token: 0x060379DE RID: 227806 RVA: 0x00772AB8 File Offset: 0x00770CB8
		// (set) Token: 0x060379DF RID: 227807 RVA: 0x00772AC0 File Offset: 0x00770CC0
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E734 RID: 59188
		// (get) Token: 0x060379E0 RID: 227808 RVA: 0x00772AC9 File Offset: 0x00770CC9
		// (set) Token: 0x060379E1 RID: 227809 RVA: 0x00772AD1 File Offset: 0x00770CD1
		public bool PlayVoice { get; set; }

		// Token: 0x1700E735 RID: 59189
		// (get) Token: 0x060379E2 RID: 227810 RVA: 0x00772ADA File Offset: 0x00770CDA
		// (set) Token: 0x060379E3 RID: 227811 RVA: 0x00772AE2 File Offset: 0x00770CE2
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E736 RID: 59190
		// (get) Token: 0x060379E4 RID: 227812 RVA: 0x00772AEB File Offset: 0x00770CEB
		// (set) Token: 0x060379E5 RID: 227813 RVA: 0x00772AF3 File Offset: 0x00770CF3
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E737 RID: 59191
		// (get) Token: 0x060379E6 RID: 227814 RVA: 0x00772AFC File Offset: 0x00770CFC
		// (set) Token: 0x060379E7 RID: 227815 RVA: 0x00772B04 File Offset: 0x00770D04
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E738 RID: 59192
		// (get) Token: 0x060379E8 RID: 227816 RVA: 0x00772B0D File Offset: 0x00770D0D
		// (set) Token: 0x060379E9 RID: 227817 RVA: 0x00772B15 File Offset: 0x00770D15
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E739 RID: 59193
		// (get) Token: 0x060379EA RID: 227818 RVA: 0x00772B1E File Offset: 0x00770D1E
		// (set) Token: 0x060379EB RID: 227819 RVA: 0x00772B26 File Offset: 0x00770D26
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E73A RID: 59194
		// (get) Token: 0x060379EC RID: 227820 RVA: 0x00772B2F File Offset: 0x00770D2F
		// (set) Token: 0x060379ED RID: 227821 RVA: 0x00772B37 File Offset: 0x00770D37
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E73B RID: 59195
		// (get) Token: 0x060379EE RID: 227822 RVA: 0x00772B40 File Offset: 0x00770D40
		// (set) Token: 0x060379EF RID: 227823 RVA: 0x00772B48 File Offset: 0x00770D48
		public uint NullMask { get; set; }

		// Token: 0x060379F0 RID: 227824 RVA: 0x00772B54 File Offset: 0x00770D54
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
