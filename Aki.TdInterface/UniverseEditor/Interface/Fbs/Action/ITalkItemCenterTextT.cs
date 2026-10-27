using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D8 RID: 29400
	public class ITalkItemCenterTextT
	{
		// Token: 0x1700DC02 RID: 56322
		// (get) Token: 0x060349C3 RID: 215491 RVA: 0x0071B7F5 File Offset: 0x007199F5
		// (set) Token: 0x060349C4 RID: 215492 RVA: 0x0071B7FD File Offset: 0x007199FD
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DC03 RID: 56323
		// (get) Token: 0x060349C5 RID: 215493 RVA: 0x0071B806 File Offset: 0x00719A06
		// (set) Token: 0x060349C6 RID: 215494 RVA: 0x0071B80E File Offset: 0x00719A0E
		public int Id { get; set; }

		// Token: 0x1700DC04 RID: 56324
		// (get) Token: 0x060349C7 RID: 215495 RVA: 0x0071B817 File Offset: 0x00719A17
		// (set) Token: 0x060349C8 RID: 215496 RVA: 0x0071B81F File Offset: 0x00719A1F
		public int PlotLineId { get; set; }

		// Token: 0x1700DC05 RID: 56325
		// (get) Token: 0x060349C9 RID: 215497 RVA: 0x0071B828 File Offset: 0x00719A28
		// (set) Token: 0x060349CA RID: 215498 RVA: 0x0071B830 File Offset: 0x00719A30
		public string PlotLineKey { get; set; }

		// Token: 0x1700DC06 RID: 56326
		// (get) Token: 0x060349CB RID: 215499 RVA: 0x0071B839 File Offset: 0x00719A39
		// (set) Token: 0x060349CC RID: 215500 RVA: 0x0071B841 File Offset: 0x00719A41
		public string Name { get; set; }

		// Token: 0x1700DC07 RID: 56327
		// (get) Token: 0x060349CD RID: 215501 RVA: 0x0071B84A File Offset: 0x00719A4A
		// (set) Token: 0x060349CE RID: 215502 RVA: 0x0071B852 File Offset: 0x00719A52
		public bool _Folded { get; set; }

		// Token: 0x1700DC08 RID: 56328
		// (get) Token: 0x060349CF RID: 215503 RVA: 0x0071B85B File Offset: 0x00719A5B
		// (set) Token: 0x060349D0 RID: 215504 RVA: 0x0071B863 File Offset: 0x00719A63
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DC09 RID: 56329
		// (get) Token: 0x060349D1 RID: 215505 RVA: 0x0071B86C File Offset: 0x00719A6C
		// (set) Token: 0x060349D2 RID: 215506 RVA: 0x0071B874 File Offset: 0x00719A74
		public int WhoId { get; set; }

		// Token: 0x1700DC0A RID: 56330
		// (get) Token: 0x060349D3 RID: 215507 RVA: 0x0071B87D File Offset: 0x00719A7D
		// (set) Token: 0x060349D4 RID: 215508 RVA: 0x0071B885 File Offset: 0x00719A85
		public int TextId { get; set; }

		// Token: 0x1700DC0B RID: 56331
		// (get) Token: 0x060349D5 RID: 215509 RVA: 0x0071B88E File Offset: 0x00719A8E
		// (set) Token: 0x060349D6 RID: 215510 RVA: 0x0071B896 File Offset: 0x00719A96
		public string TidTalk { get; set; }

		// Token: 0x1700DC0C RID: 56332
		// (get) Token: 0x060349D7 RID: 215511 RVA: 0x0071B89F File Offset: 0x00719A9F
		// (set) Token: 0x060349D8 RID: 215512 RVA: 0x0071B8A7 File Offset: 0x00719AA7
		public float WaitTime { get; set; }

		// Token: 0x1700DC0D RID: 56333
		// (get) Token: 0x060349D9 RID: 215513 RVA: 0x0071B8B0 File Offset: 0x00719AB0
		// (set) Token: 0x060349DA RID: 215514 RVA: 0x0071B8B8 File Offset: 0x00719AB8
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DC0E RID: 56334
		// (get) Token: 0x060349DB RID: 215515 RVA: 0x0071B8C1 File Offset: 0x00719AC1
		// (set) Token: 0x060349DC RID: 215516 RVA: 0x0071B8C9 File Offset: 0x00719AC9
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DC0F RID: 56335
		// (get) Token: 0x060349DD RID: 215517 RVA: 0x0071B8D2 File Offset: 0x00719AD2
		// (set) Token: 0x060349DE RID: 215518 RVA: 0x0071B8DA File Offset: 0x00719ADA
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DC10 RID: 56336
		// (get) Token: 0x060349DF RID: 215519 RVA: 0x0071B8E3 File Offset: 0x00719AE3
		// (set) Token: 0x060349E0 RID: 215520 RVA: 0x0071B8EB File Offset: 0x00719AEB
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DC11 RID: 56337
		// (get) Token: 0x060349E1 RID: 215521 RVA: 0x0071B8F4 File Offset: 0x00719AF4
		// (set) Token: 0x060349E2 RID: 215522 RVA: 0x0071B8FC File Offset: 0x00719AFC
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DC12 RID: 56338
		// (get) Token: 0x060349E3 RID: 215523 RVA: 0x0071B905 File Offset: 0x00719B05
		// (set) Token: 0x060349E4 RID: 215524 RVA: 0x0071B90D File Offset: 0x00719B0D
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DC13 RID: 56339
		// (get) Token: 0x060349E5 RID: 215525 RVA: 0x0071B916 File Offset: 0x00719B16
		// (set) Token: 0x060349E6 RID: 215526 RVA: 0x0071B91E File Offset: 0x00719B1E
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DC14 RID: 56340
		// (get) Token: 0x060349E7 RID: 215527 RVA: 0x0071B927 File Offset: 0x00719B27
		// (set) Token: 0x060349E8 RID: 215528 RVA: 0x0071B92F File Offset: 0x00719B2F
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DC15 RID: 56341
		// (get) Token: 0x060349E9 RID: 215529 RVA: 0x0071B938 File Offset: 0x00719B38
		// (set) Token: 0x060349EA RID: 215530 RVA: 0x0071B940 File Offset: 0x00719B40
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DC16 RID: 56342
		// (get) Token: 0x060349EB RID: 215531 RVA: 0x0071B949 File Offset: 0x00719B49
		// (set) Token: 0x060349EC RID: 215532 RVA: 0x0071B951 File Offset: 0x00719B51
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DC17 RID: 56343
		// (get) Token: 0x060349ED RID: 215533 RVA: 0x0071B95A File Offset: 0x00719B5A
		// (set) Token: 0x060349EE RID: 215534 RVA: 0x0071B962 File Offset: 0x00719B62
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DC18 RID: 56344
		// (get) Token: 0x060349EF RID: 215535 RVA: 0x0071B96B File Offset: 0x00719B6B
		// (set) Token: 0x060349F0 RID: 215536 RVA: 0x0071B973 File Offset: 0x00719B73
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DC19 RID: 56345
		// (get) Token: 0x060349F1 RID: 215537 RVA: 0x0071B97C File Offset: 0x00719B7C
		// (set) Token: 0x060349F2 RID: 215538 RVA: 0x0071B984 File Offset: 0x00719B84
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DC1A RID: 56346
		// (get) Token: 0x060349F3 RID: 215539 RVA: 0x0071B98D File Offset: 0x00719B8D
		// (set) Token: 0x060349F4 RID: 215540 RVA: 0x0071B995 File Offset: 0x00719B95
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DC1B RID: 56347
		// (get) Token: 0x060349F5 RID: 215541 RVA: 0x0071B99E File Offset: 0x00719B9E
		// (set) Token: 0x060349F6 RID: 215542 RVA: 0x0071B9A6 File Offset: 0x00719BA6
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DC1C RID: 56348
		// (get) Token: 0x060349F7 RID: 215543 RVA: 0x0071B9AF File Offset: 0x00719BAF
		// (set) Token: 0x060349F8 RID: 215544 RVA: 0x0071B9B7 File Offset: 0x00719BB7
		public bool PlayVoice { get; set; }

		// Token: 0x1700DC1D RID: 56349
		// (get) Token: 0x060349F9 RID: 215545 RVA: 0x0071B9C0 File Offset: 0x00719BC0
		// (set) Token: 0x060349FA RID: 215546 RVA: 0x0071B9C8 File Offset: 0x00719BC8
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DC1E RID: 56350
		// (get) Token: 0x060349FB RID: 215547 RVA: 0x0071B9D1 File Offset: 0x00719BD1
		// (set) Token: 0x060349FC RID: 215548 RVA: 0x0071B9D9 File Offset: 0x00719BD9
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DC1F RID: 56351
		// (get) Token: 0x060349FD RID: 215549 RVA: 0x0071B9E2 File Offset: 0x00719BE2
		// (set) Token: 0x060349FE RID: 215550 RVA: 0x0071B9EA File Offset: 0x00719BEA
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DC20 RID: 56352
		// (get) Token: 0x060349FF RID: 215551 RVA: 0x0071B9F3 File Offset: 0x00719BF3
		// (set) Token: 0x06034A00 RID: 215552 RVA: 0x0071B9FB File Offset: 0x00719BFB
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DC21 RID: 56353
		// (get) Token: 0x06034A01 RID: 215553 RVA: 0x0071BA04 File Offset: 0x00719C04
		// (set) Token: 0x06034A02 RID: 215554 RVA: 0x0071BA0C File Offset: 0x00719C0C
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DC22 RID: 56354
		// (get) Token: 0x06034A03 RID: 215555 RVA: 0x0071BA15 File Offset: 0x00719C15
		// (set) Token: 0x06034A04 RID: 215556 RVA: 0x0071BA1D File Offset: 0x00719C1D
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DC23 RID: 56355
		// (get) Token: 0x06034A05 RID: 215557 RVA: 0x0071BA26 File Offset: 0x00719C26
		// (set) Token: 0x06034A06 RID: 215558 RVA: 0x0071BA2E File Offset: 0x00719C2E
		public IShowCenterTextParamsT CenterTextConfig { get; set; }

		// Token: 0x1700DC24 RID: 56356
		// (get) Token: 0x06034A07 RID: 215559 RVA: 0x0071BA37 File Offset: 0x00719C37
		// (set) Token: 0x06034A08 RID: 215560 RVA: 0x0071BA3F File Offset: 0x00719C3F
		public bool _IsPlotActionForPreview { get; set; }

		// Token: 0x1700DC25 RID: 56357
		// (get) Token: 0x06034A09 RID: 215561 RVA: 0x0071BA48 File Offset: 0x00719C48
		// (set) Token: 0x06034A0A RID: 215562 RVA: 0x0071BA50 File Offset: 0x00719C50
		public uint NullMask { get; set; }

		// Token: 0x06034A0B RID: 215563 RVA: 0x0071BA5C File Offset: 0x00719C5C
		public ITalkItemCenterTextT()
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
			this.CenterTextConfig = null;
			this._IsPlotActionForPreview = false;
			this.NullMask = 0U;
		}
	}
}
