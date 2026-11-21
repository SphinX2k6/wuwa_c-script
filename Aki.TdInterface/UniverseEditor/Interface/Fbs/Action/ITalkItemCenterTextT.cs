using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AAD RID: 31405
	public class ITalkItemCenterTextT
	{
		// Token: 0x1700E7FB RID: 59387
		// (get) Token: 0x06037CC7 RID: 228551 RVA: 0x0077CB91 File Offset: 0x0077AD91
		// (set) Token: 0x06037CC8 RID: 228552 RVA: 0x0077CB99 File Offset: 0x0077AD99
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E7FC RID: 59388
		// (get) Token: 0x06037CC9 RID: 228553 RVA: 0x0077CBA2 File Offset: 0x0077ADA2
		// (set) Token: 0x06037CCA RID: 228554 RVA: 0x0077CBAA File Offset: 0x0077ADAA
		public int Id { get; set; }

		// Token: 0x1700E7FD RID: 59389
		// (get) Token: 0x06037CCB RID: 228555 RVA: 0x0077CBB3 File Offset: 0x0077ADB3
		// (set) Token: 0x06037CCC RID: 228556 RVA: 0x0077CBBB File Offset: 0x0077ADBB
		public int PlotLineId { get; set; }

		// Token: 0x1700E7FE RID: 59390
		// (get) Token: 0x06037CCD RID: 228557 RVA: 0x0077CBC4 File Offset: 0x0077ADC4
		// (set) Token: 0x06037CCE RID: 228558 RVA: 0x0077CBCC File Offset: 0x0077ADCC
		public string PlotLineKey { get; set; }

		// Token: 0x1700E7FF RID: 59391
		// (get) Token: 0x06037CCF RID: 228559 RVA: 0x0077CBD5 File Offset: 0x0077ADD5
		// (set) Token: 0x06037CD0 RID: 228560 RVA: 0x0077CBDD File Offset: 0x0077ADDD
		public string Name { get; set; }

		// Token: 0x1700E800 RID: 59392
		// (get) Token: 0x06037CD1 RID: 228561 RVA: 0x0077CBE6 File Offset: 0x0077ADE6
		// (set) Token: 0x06037CD2 RID: 228562 RVA: 0x0077CBEE File Offset: 0x0077ADEE
		public bool _Folded { get; set; }

		// Token: 0x1700E801 RID: 59393
		// (get) Token: 0x06037CD3 RID: 228563 RVA: 0x0077CBF7 File Offset: 0x0077ADF7
		// (set) Token: 0x06037CD4 RID: 228564 RVA: 0x0077CBFF File Offset: 0x0077ADFF
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E802 RID: 59394
		// (get) Token: 0x06037CD5 RID: 228565 RVA: 0x0077CC08 File Offset: 0x0077AE08
		// (set) Token: 0x06037CD6 RID: 228566 RVA: 0x0077CC10 File Offset: 0x0077AE10
		public int WhoId { get; set; }

		// Token: 0x1700E803 RID: 59395
		// (get) Token: 0x06037CD7 RID: 228567 RVA: 0x0077CC19 File Offset: 0x0077AE19
		// (set) Token: 0x06037CD8 RID: 228568 RVA: 0x0077CC21 File Offset: 0x0077AE21
		public int TextId { get; set; }

		// Token: 0x1700E804 RID: 59396
		// (get) Token: 0x06037CD9 RID: 228569 RVA: 0x0077CC2A File Offset: 0x0077AE2A
		// (set) Token: 0x06037CDA RID: 228570 RVA: 0x0077CC32 File Offset: 0x0077AE32
		public string TidTalk { get; set; }

		// Token: 0x1700E805 RID: 59397
		// (get) Token: 0x06037CDB RID: 228571 RVA: 0x0077CC3B File Offset: 0x0077AE3B
		// (set) Token: 0x06037CDC RID: 228572 RVA: 0x0077CC43 File Offset: 0x0077AE43
		public float WaitTime { get; set; }

		// Token: 0x1700E806 RID: 59398
		// (get) Token: 0x06037CDD RID: 228573 RVA: 0x0077CC4C File Offset: 0x0077AE4C
		// (set) Token: 0x06037CDE RID: 228574 RVA: 0x0077CC54 File Offset: 0x0077AE54
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E807 RID: 59399
		// (get) Token: 0x06037CDF RID: 228575 RVA: 0x0077CC5D File Offset: 0x0077AE5D
		// (set) Token: 0x06037CE0 RID: 228576 RVA: 0x0077CC65 File Offset: 0x0077AE65
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E808 RID: 59400
		// (get) Token: 0x06037CE1 RID: 228577 RVA: 0x0077CC6E File Offset: 0x0077AE6E
		// (set) Token: 0x06037CE2 RID: 228578 RVA: 0x0077CC76 File Offset: 0x0077AE76
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E809 RID: 59401
		// (get) Token: 0x06037CE3 RID: 228579 RVA: 0x0077CC7F File Offset: 0x0077AE7F
		// (set) Token: 0x06037CE4 RID: 228580 RVA: 0x0077CC87 File Offset: 0x0077AE87
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E80A RID: 59402
		// (get) Token: 0x06037CE5 RID: 228581 RVA: 0x0077CC90 File Offset: 0x0077AE90
		// (set) Token: 0x06037CE6 RID: 228582 RVA: 0x0077CC98 File Offset: 0x0077AE98
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E80B RID: 59403
		// (get) Token: 0x06037CE7 RID: 228583 RVA: 0x0077CCA1 File Offset: 0x0077AEA1
		// (set) Token: 0x06037CE8 RID: 228584 RVA: 0x0077CCA9 File Offset: 0x0077AEA9
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E80C RID: 59404
		// (get) Token: 0x06037CE9 RID: 228585 RVA: 0x0077CCB2 File Offset: 0x0077AEB2
		// (set) Token: 0x06037CEA RID: 228586 RVA: 0x0077CCBA File Offset: 0x0077AEBA
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E80D RID: 59405
		// (get) Token: 0x06037CEB RID: 228587 RVA: 0x0077CCC3 File Offset: 0x0077AEC3
		// (set) Token: 0x06037CEC RID: 228588 RVA: 0x0077CCCB File Offset: 0x0077AECB
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E80E RID: 59406
		// (get) Token: 0x06037CED RID: 228589 RVA: 0x0077CCD4 File Offset: 0x0077AED4
		// (set) Token: 0x06037CEE RID: 228590 RVA: 0x0077CCDC File Offset: 0x0077AEDC
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E80F RID: 59407
		// (get) Token: 0x06037CEF RID: 228591 RVA: 0x0077CCE5 File Offset: 0x0077AEE5
		// (set) Token: 0x06037CF0 RID: 228592 RVA: 0x0077CCED File Offset: 0x0077AEED
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E810 RID: 59408
		// (get) Token: 0x06037CF1 RID: 228593 RVA: 0x0077CCF6 File Offset: 0x0077AEF6
		// (set) Token: 0x06037CF2 RID: 228594 RVA: 0x0077CCFE File Offset: 0x0077AEFE
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E811 RID: 59409
		// (get) Token: 0x06037CF3 RID: 228595 RVA: 0x0077CD07 File Offset: 0x0077AF07
		// (set) Token: 0x06037CF4 RID: 228596 RVA: 0x0077CD0F File Offset: 0x0077AF0F
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E812 RID: 59410
		// (get) Token: 0x06037CF5 RID: 228597 RVA: 0x0077CD18 File Offset: 0x0077AF18
		// (set) Token: 0x06037CF6 RID: 228598 RVA: 0x0077CD20 File Offset: 0x0077AF20
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E813 RID: 59411
		// (get) Token: 0x06037CF7 RID: 228599 RVA: 0x0077CD29 File Offset: 0x0077AF29
		// (set) Token: 0x06037CF8 RID: 228600 RVA: 0x0077CD31 File Offset: 0x0077AF31
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E814 RID: 59412
		// (get) Token: 0x06037CF9 RID: 228601 RVA: 0x0077CD3A File Offset: 0x0077AF3A
		// (set) Token: 0x06037CFA RID: 228602 RVA: 0x0077CD42 File Offset: 0x0077AF42
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E815 RID: 59413
		// (get) Token: 0x06037CFB RID: 228603 RVA: 0x0077CD4B File Offset: 0x0077AF4B
		// (set) Token: 0x06037CFC RID: 228604 RVA: 0x0077CD53 File Offset: 0x0077AF53
		public bool PlayVoice { get; set; }

		// Token: 0x1700E816 RID: 59414
		// (get) Token: 0x06037CFD RID: 228605 RVA: 0x0077CD5C File Offset: 0x0077AF5C
		// (set) Token: 0x06037CFE RID: 228606 RVA: 0x0077CD64 File Offset: 0x0077AF64
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E817 RID: 59415
		// (get) Token: 0x06037CFF RID: 228607 RVA: 0x0077CD6D File Offset: 0x0077AF6D
		// (set) Token: 0x06037D00 RID: 228608 RVA: 0x0077CD75 File Offset: 0x0077AF75
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E818 RID: 59416
		// (get) Token: 0x06037D01 RID: 228609 RVA: 0x0077CD7E File Offset: 0x0077AF7E
		// (set) Token: 0x06037D02 RID: 228610 RVA: 0x0077CD86 File Offset: 0x0077AF86
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E819 RID: 59417
		// (get) Token: 0x06037D03 RID: 228611 RVA: 0x0077CD8F File Offset: 0x0077AF8F
		// (set) Token: 0x06037D04 RID: 228612 RVA: 0x0077CD97 File Offset: 0x0077AF97
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E81A RID: 59418
		// (get) Token: 0x06037D05 RID: 228613 RVA: 0x0077CDA0 File Offset: 0x0077AFA0
		// (set) Token: 0x06037D06 RID: 228614 RVA: 0x0077CDA8 File Offset: 0x0077AFA8
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E81B RID: 59419
		// (get) Token: 0x06037D07 RID: 228615 RVA: 0x0077CDB1 File Offset: 0x0077AFB1
		// (set) Token: 0x06037D08 RID: 228616 RVA: 0x0077CDB9 File Offset: 0x0077AFB9
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E81C RID: 59420
		// (get) Token: 0x06037D09 RID: 228617 RVA: 0x0077CDC2 File Offset: 0x0077AFC2
		// (set) Token: 0x06037D0A RID: 228618 RVA: 0x0077CDCA File Offset: 0x0077AFCA
		public IShowCenterTextParamsT CenterTextConfig { get; set; }

		// Token: 0x1700E81D RID: 59421
		// (get) Token: 0x06037D0B RID: 228619 RVA: 0x0077CDD3 File Offset: 0x0077AFD3
		// (set) Token: 0x06037D0C RID: 228620 RVA: 0x0077CDDB File Offset: 0x0077AFDB
		public bool _IsPlotActionForPreview { get; set; }

		// Token: 0x1700E81E RID: 59422
		// (get) Token: 0x06037D0D RID: 228621 RVA: 0x0077CDE4 File Offset: 0x0077AFE4
		// (set) Token: 0x06037D0E RID: 228622 RVA: 0x0077CDEC File Offset: 0x0077AFEC
		public uint NullMask { get; set; }

		// Token: 0x06037D0F RID: 228623 RVA: 0x0077CDF8 File Offset: 0x0077AFF8
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
