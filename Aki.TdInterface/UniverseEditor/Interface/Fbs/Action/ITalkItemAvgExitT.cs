using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A9E RID: 31390
	public class ITalkItemAvgExitT
	{
		// Token: 0x1700E6D3 RID: 59091
		// (get) Token: 0x060378AF RID: 227503 RVA: 0x0076F49F File Offset: 0x0076D69F
		// (set) Token: 0x060378B0 RID: 227504 RVA: 0x0076F4A7 File Offset: 0x0076D6A7
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E6D4 RID: 59092
		// (get) Token: 0x060378B1 RID: 227505 RVA: 0x0076F4B0 File Offset: 0x0076D6B0
		// (set) Token: 0x060378B2 RID: 227506 RVA: 0x0076F4B8 File Offset: 0x0076D6B8
		public int Id { get; set; }

		// Token: 0x1700E6D5 RID: 59093
		// (get) Token: 0x060378B3 RID: 227507 RVA: 0x0076F4C1 File Offset: 0x0076D6C1
		// (set) Token: 0x060378B4 RID: 227508 RVA: 0x0076F4C9 File Offset: 0x0076D6C9
		public int PlotLineId { get; set; }

		// Token: 0x1700E6D6 RID: 59094
		// (get) Token: 0x060378B5 RID: 227509 RVA: 0x0076F4D2 File Offset: 0x0076D6D2
		// (set) Token: 0x060378B6 RID: 227510 RVA: 0x0076F4DA File Offset: 0x0076D6DA
		public string PlotLineKey { get; set; }

		// Token: 0x1700E6D7 RID: 59095
		// (get) Token: 0x060378B7 RID: 227511 RVA: 0x0076F4E3 File Offset: 0x0076D6E3
		// (set) Token: 0x060378B8 RID: 227512 RVA: 0x0076F4EB File Offset: 0x0076D6EB
		public string Name { get; set; }

		// Token: 0x1700E6D8 RID: 59096
		// (get) Token: 0x060378B9 RID: 227513 RVA: 0x0076F4F4 File Offset: 0x0076D6F4
		// (set) Token: 0x060378BA RID: 227514 RVA: 0x0076F4FC File Offset: 0x0076D6FC
		public bool _Folded { get; set; }

		// Token: 0x1700E6D9 RID: 59097
		// (get) Token: 0x060378BB RID: 227515 RVA: 0x0076F505 File Offset: 0x0076D705
		// (set) Token: 0x060378BC RID: 227516 RVA: 0x0076F50D File Offset: 0x0076D70D
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E6DA RID: 59098
		// (get) Token: 0x060378BD RID: 227517 RVA: 0x0076F516 File Offset: 0x0076D716
		// (set) Token: 0x060378BE RID: 227518 RVA: 0x0076F51E File Offset: 0x0076D71E
		public int WhoId { get; set; }

		// Token: 0x1700E6DB RID: 59099
		// (get) Token: 0x060378BF RID: 227519 RVA: 0x0076F527 File Offset: 0x0076D727
		// (set) Token: 0x060378C0 RID: 227520 RVA: 0x0076F52F File Offset: 0x0076D72F
		public int TextId { get; set; }

		// Token: 0x1700E6DC RID: 59100
		// (get) Token: 0x060378C1 RID: 227521 RVA: 0x0076F538 File Offset: 0x0076D738
		// (set) Token: 0x060378C2 RID: 227522 RVA: 0x0076F540 File Offset: 0x0076D740
		public string TidTalk { get; set; }

		// Token: 0x1700E6DD RID: 59101
		// (get) Token: 0x060378C3 RID: 227523 RVA: 0x0076F549 File Offset: 0x0076D749
		// (set) Token: 0x060378C4 RID: 227524 RVA: 0x0076F551 File Offset: 0x0076D751
		public float WaitTime { get; set; }

		// Token: 0x1700E6DE RID: 59102
		// (get) Token: 0x060378C5 RID: 227525 RVA: 0x0076F55A File Offset: 0x0076D75A
		// (set) Token: 0x060378C6 RID: 227526 RVA: 0x0076F562 File Offset: 0x0076D762
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E6DF RID: 59103
		// (get) Token: 0x060378C7 RID: 227527 RVA: 0x0076F56B File Offset: 0x0076D76B
		// (set) Token: 0x060378C8 RID: 227528 RVA: 0x0076F573 File Offset: 0x0076D773
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E6E0 RID: 59104
		// (get) Token: 0x060378C9 RID: 227529 RVA: 0x0076F57C File Offset: 0x0076D77C
		// (set) Token: 0x060378CA RID: 227530 RVA: 0x0076F584 File Offset: 0x0076D784
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E6E1 RID: 59105
		// (get) Token: 0x060378CB RID: 227531 RVA: 0x0076F58D File Offset: 0x0076D78D
		// (set) Token: 0x060378CC RID: 227532 RVA: 0x0076F595 File Offset: 0x0076D795
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E6E2 RID: 59106
		// (get) Token: 0x060378CD RID: 227533 RVA: 0x0076F59E File Offset: 0x0076D79E
		// (set) Token: 0x060378CE RID: 227534 RVA: 0x0076F5A6 File Offset: 0x0076D7A6
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E6E3 RID: 59107
		// (get) Token: 0x060378CF RID: 227535 RVA: 0x0076F5AF File Offset: 0x0076D7AF
		// (set) Token: 0x060378D0 RID: 227536 RVA: 0x0076F5B7 File Offset: 0x0076D7B7
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E6E4 RID: 59108
		// (get) Token: 0x060378D1 RID: 227537 RVA: 0x0076F5C0 File Offset: 0x0076D7C0
		// (set) Token: 0x060378D2 RID: 227538 RVA: 0x0076F5C8 File Offset: 0x0076D7C8
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E6E5 RID: 59109
		// (get) Token: 0x060378D3 RID: 227539 RVA: 0x0076F5D1 File Offset: 0x0076D7D1
		// (set) Token: 0x060378D4 RID: 227540 RVA: 0x0076F5D9 File Offset: 0x0076D7D9
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E6E6 RID: 59110
		// (get) Token: 0x060378D5 RID: 227541 RVA: 0x0076F5E2 File Offset: 0x0076D7E2
		// (set) Token: 0x060378D6 RID: 227542 RVA: 0x0076F5EA File Offset: 0x0076D7EA
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E6E7 RID: 59111
		// (get) Token: 0x060378D7 RID: 227543 RVA: 0x0076F5F3 File Offset: 0x0076D7F3
		// (set) Token: 0x060378D8 RID: 227544 RVA: 0x0076F5FB File Offset: 0x0076D7FB
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E6E8 RID: 59112
		// (get) Token: 0x060378D9 RID: 227545 RVA: 0x0076F604 File Offset: 0x0076D804
		// (set) Token: 0x060378DA RID: 227546 RVA: 0x0076F60C File Offset: 0x0076D80C
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E6E9 RID: 59113
		// (get) Token: 0x060378DB RID: 227547 RVA: 0x0076F615 File Offset: 0x0076D815
		// (set) Token: 0x060378DC RID: 227548 RVA: 0x0076F61D File Offset: 0x0076D81D
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E6EA RID: 59114
		// (get) Token: 0x060378DD RID: 227549 RVA: 0x0076F626 File Offset: 0x0076D826
		// (set) Token: 0x060378DE RID: 227550 RVA: 0x0076F62E File Offset: 0x0076D82E
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E6EB RID: 59115
		// (get) Token: 0x060378DF RID: 227551 RVA: 0x0076F637 File Offset: 0x0076D837
		// (set) Token: 0x060378E0 RID: 227552 RVA: 0x0076F63F File Offset: 0x0076D83F
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E6EC RID: 59116
		// (get) Token: 0x060378E1 RID: 227553 RVA: 0x0076F648 File Offset: 0x0076D848
		// (set) Token: 0x060378E2 RID: 227554 RVA: 0x0076F650 File Offset: 0x0076D850
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E6ED RID: 59117
		// (get) Token: 0x060378E3 RID: 227555 RVA: 0x0076F659 File Offset: 0x0076D859
		// (set) Token: 0x060378E4 RID: 227556 RVA: 0x0076F661 File Offset: 0x0076D861
		public bool PlayVoice { get; set; }

		// Token: 0x1700E6EE RID: 59118
		// (get) Token: 0x060378E5 RID: 227557 RVA: 0x0076F66A File Offset: 0x0076D86A
		// (set) Token: 0x060378E6 RID: 227558 RVA: 0x0076F672 File Offset: 0x0076D872
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E6EF RID: 59119
		// (get) Token: 0x060378E7 RID: 227559 RVA: 0x0076F67B File Offset: 0x0076D87B
		// (set) Token: 0x060378E8 RID: 227560 RVA: 0x0076F683 File Offset: 0x0076D883
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E6F0 RID: 59120
		// (get) Token: 0x060378E9 RID: 227561 RVA: 0x0076F68C File Offset: 0x0076D88C
		// (set) Token: 0x060378EA RID: 227562 RVA: 0x0076F694 File Offset: 0x0076D894
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E6F1 RID: 59121
		// (get) Token: 0x060378EB RID: 227563 RVA: 0x0076F69D File Offset: 0x0076D89D
		// (set) Token: 0x060378EC RID: 227564 RVA: 0x0076F6A5 File Offset: 0x0076D8A5
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E6F2 RID: 59122
		// (get) Token: 0x060378ED RID: 227565 RVA: 0x0076F6AE File Offset: 0x0076D8AE
		// (set) Token: 0x060378EE RID: 227566 RVA: 0x0076F6B6 File Offset: 0x0076D8B6
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E6F3 RID: 59123
		// (get) Token: 0x060378EF RID: 227567 RVA: 0x0076F6BF File Offset: 0x0076D8BF
		// (set) Token: 0x060378F0 RID: 227568 RVA: 0x0076F6C7 File Offset: 0x0076D8C7
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E6F4 RID: 59124
		// (get) Token: 0x060378F1 RID: 227569 RVA: 0x0076F6D0 File Offset: 0x0076D8D0
		// (set) Token: 0x060378F2 RID: 227570 RVA: 0x0076F6D8 File Offset: 0x0076D8D8
		public ITalkItemAvgRoleConfigT AvgRoleConfig { get; set; }

		// Token: 0x1700E6F5 RID: 59125
		// (get) Token: 0x060378F3 RID: 227571 RVA: 0x0076F6E1 File Offset: 0x0076D8E1
		// (set) Token: 0x060378F4 RID: 227572 RVA: 0x0076F6E9 File Offset: 0x0076D8E9
		public uint NullMask { get; set; }

		// Token: 0x060378F5 RID: 227573 RVA: 0x0076F6F4 File Offset: 0x0076D8F4
		public ITalkItemAvgExitT()
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
			this.AvgRoleConfig = null;
			this.NullMask = 0U;
		}
	}
}
