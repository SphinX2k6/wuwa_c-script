using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AB9 RID: 31417
	public class ITalkItemOptionT
	{
		// Token: 0x1700E8E4 RID: 59620
		// (get) Token: 0x06038005 RID: 229381 RVA: 0x007876AC File Offset: 0x007858AC
		// (set) Token: 0x06038006 RID: 229382 RVA: 0x007876B4 File Offset: 0x007858B4
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E8E5 RID: 59621
		// (get) Token: 0x06038007 RID: 229383 RVA: 0x007876BD File Offset: 0x007858BD
		// (set) Token: 0x06038008 RID: 229384 RVA: 0x007876C5 File Offset: 0x007858C5
		public int Id { get; set; }

		// Token: 0x1700E8E6 RID: 59622
		// (get) Token: 0x06038009 RID: 229385 RVA: 0x007876CE File Offset: 0x007858CE
		// (set) Token: 0x0603800A RID: 229386 RVA: 0x007876D6 File Offset: 0x007858D6
		public int PlotLineId { get; set; }

		// Token: 0x1700E8E7 RID: 59623
		// (get) Token: 0x0603800B RID: 229387 RVA: 0x007876DF File Offset: 0x007858DF
		// (set) Token: 0x0603800C RID: 229388 RVA: 0x007876E7 File Offset: 0x007858E7
		public string PlotLineKey { get; set; }

		// Token: 0x1700E8E8 RID: 59624
		// (get) Token: 0x0603800D RID: 229389 RVA: 0x007876F0 File Offset: 0x007858F0
		// (set) Token: 0x0603800E RID: 229390 RVA: 0x007876F8 File Offset: 0x007858F8
		public string Name { get; set; }

		// Token: 0x1700E8E9 RID: 59625
		// (get) Token: 0x0603800F RID: 229391 RVA: 0x00787701 File Offset: 0x00785901
		// (set) Token: 0x06038010 RID: 229392 RVA: 0x00787709 File Offset: 0x00785909
		public bool _Folded { get; set; }

		// Token: 0x1700E8EA RID: 59626
		// (get) Token: 0x06038011 RID: 229393 RVA: 0x00787712 File Offset: 0x00785912
		// (set) Token: 0x06038012 RID: 229394 RVA: 0x0078771A File Offset: 0x0078591A
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E8EB RID: 59627
		// (get) Token: 0x06038013 RID: 229395 RVA: 0x00787723 File Offset: 0x00785923
		// (set) Token: 0x06038014 RID: 229396 RVA: 0x0078772B File Offset: 0x0078592B
		public int WhoId { get; set; }

		// Token: 0x1700E8EC RID: 59628
		// (get) Token: 0x06038015 RID: 229397 RVA: 0x00787734 File Offset: 0x00785934
		// (set) Token: 0x06038016 RID: 229398 RVA: 0x0078773C File Offset: 0x0078593C
		public int TextId { get; set; }

		// Token: 0x1700E8ED RID: 59629
		// (get) Token: 0x06038017 RID: 229399 RVA: 0x00787745 File Offset: 0x00785945
		// (set) Token: 0x06038018 RID: 229400 RVA: 0x0078774D File Offset: 0x0078594D
		public string TidTalk { get; set; }

		// Token: 0x1700E8EE RID: 59630
		// (get) Token: 0x06038019 RID: 229401 RVA: 0x00787756 File Offset: 0x00785956
		// (set) Token: 0x0603801A RID: 229402 RVA: 0x0078775E File Offset: 0x0078595E
		public float WaitTime { get; set; }

		// Token: 0x1700E8EF RID: 59631
		// (get) Token: 0x0603801B RID: 229403 RVA: 0x00787767 File Offset: 0x00785967
		// (set) Token: 0x0603801C RID: 229404 RVA: 0x0078776F File Offset: 0x0078596F
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E8F0 RID: 59632
		// (get) Token: 0x0603801D RID: 229405 RVA: 0x00787778 File Offset: 0x00785978
		// (set) Token: 0x0603801E RID: 229406 RVA: 0x00787780 File Offset: 0x00785980
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E8F1 RID: 59633
		// (get) Token: 0x0603801F RID: 229407 RVA: 0x00787789 File Offset: 0x00785989
		// (set) Token: 0x06038020 RID: 229408 RVA: 0x00787791 File Offset: 0x00785991
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E8F2 RID: 59634
		// (get) Token: 0x06038021 RID: 229409 RVA: 0x0078779A File Offset: 0x0078599A
		// (set) Token: 0x06038022 RID: 229410 RVA: 0x007877A2 File Offset: 0x007859A2
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E8F3 RID: 59635
		// (get) Token: 0x06038023 RID: 229411 RVA: 0x007877AB File Offset: 0x007859AB
		// (set) Token: 0x06038024 RID: 229412 RVA: 0x007877B3 File Offset: 0x007859B3
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E8F4 RID: 59636
		// (get) Token: 0x06038025 RID: 229413 RVA: 0x007877BC File Offset: 0x007859BC
		// (set) Token: 0x06038026 RID: 229414 RVA: 0x007877C4 File Offset: 0x007859C4
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E8F5 RID: 59637
		// (get) Token: 0x06038027 RID: 229415 RVA: 0x007877CD File Offset: 0x007859CD
		// (set) Token: 0x06038028 RID: 229416 RVA: 0x007877D5 File Offset: 0x007859D5
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E8F6 RID: 59638
		// (get) Token: 0x06038029 RID: 229417 RVA: 0x007877DE File Offset: 0x007859DE
		// (set) Token: 0x0603802A RID: 229418 RVA: 0x007877E6 File Offset: 0x007859E6
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E8F7 RID: 59639
		// (get) Token: 0x0603802B RID: 229419 RVA: 0x007877EF File Offset: 0x007859EF
		// (set) Token: 0x0603802C RID: 229420 RVA: 0x007877F7 File Offset: 0x007859F7
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E8F8 RID: 59640
		// (get) Token: 0x0603802D RID: 229421 RVA: 0x00787800 File Offset: 0x00785A00
		// (set) Token: 0x0603802E RID: 229422 RVA: 0x00787808 File Offset: 0x00785A08
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E8F9 RID: 59641
		// (get) Token: 0x0603802F RID: 229423 RVA: 0x00787811 File Offset: 0x00785A11
		// (set) Token: 0x06038030 RID: 229424 RVA: 0x00787819 File Offset: 0x00785A19
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E8FA RID: 59642
		// (get) Token: 0x06038031 RID: 229425 RVA: 0x00787822 File Offset: 0x00785A22
		// (set) Token: 0x06038032 RID: 229426 RVA: 0x0078782A File Offset: 0x00785A2A
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E8FB RID: 59643
		// (get) Token: 0x06038033 RID: 229427 RVA: 0x00787833 File Offset: 0x00785A33
		// (set) Token: 0x06038034 RID: 229428 RVA: 0x0078783B File Offset: 0x00785A3B
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E8FC RID: 59644
		// (get) Token: 0x06038035 RID: 229429 RVA: 0x00787844 File Offset: 0x00785A44
		// (set) Token: 0x06038036 RID: 229430 RVA: 0x0078784C File Offset: 0x00785A4C
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E8FD RID: 59645
		// (get) Token: 0x06038037 RID: 229431 RVA: 0x00787855 File Offset: 0x00785A55
		// (set) Token: 0x06038038 RID: 229432 RVA: 0x0078785D File Offset: 0x00785A5D
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E8FE RID: 59646
		// (get) Token: 0x06038039 RID: 229433 RVA: 0x00787866 File Offset: 0x00785A66
		// (set) Token: 0x0603803A RID: 229434 RVA: 0x0078786E File Offset: 0x00785A6E
		public bool PlayVoice { get; set; }

		// Token: 0x1700E8FF RID: 59647
		// (get) Token: 0x0603803B RID: 229435 RVA: 0x00787877 File Offset: 0x00785A77
		// (set) Token: 0x0603803C RID: 229436 RVA: 0x0078787F File Offset: 0x00785A7F
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E900 RID: 59648
		// (get) Token: 0x0603803D RID: 229437 RVA: 0x00787888 File Offset: 0x00785A88
		// (set) Token: 0x0603803E RID: 229438 RVA: 0x00787890 File Offset: 0x00785A90
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E901 RID: 59649
		// (get) Token: 0x0603803F RID: 229439 RVA: 0x00787899 File Offset: 0x00785A99
		// (set) Token: 0x06038040 RID: 229440 RVA: 0x007878A1 File Offset: 0x00785AA1
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E902 RID: 59650
		// (get) Token: 0x06038041 RID: 229441 RVA: 0x007878AA File Offset: 0x00785AAA
		// (set) Token: 0x06038042 RID: 229442 RVA: 0x007878B2 File Offset: 0x00785AB2
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E903 RID: 59651
		// (get) Token: 0x06038043 RID: 229443 RVA: 0x007878BB File Offset: 0x00785ABB
		// (set) Token: 0x06038044 RID: 229444 RVA: 0x007878C3 File Offset: 0x00785AC3
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E904 RID: 59652
		// (get) Token: 0x06038045 RID: 229445 RVA: 0x007878CC File Offset: 0x00785ACC
		// (set) Token: 0x06038046 RID: 229446 RVA: 0x007878D4 File Offset: 0x00785AD4
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E905 RID: 59653
		// (get) Token: 0x06038047 RID: 229447 RVA: 0x007878DD File Offset: 0x00785ADD
		// (set) Token: 0x06038048 RID: 229448 RVA: 0x007878E5 File Offset: 0x00785AE5
		public TShowTalkCameraMotionUnion CameraMotion { get; set; }

		// Token: 0x1700E906 RID: 59654
		// (get) Token: 0x06038049 RID: 229449 RVA: 0x007878EE File Offset: 0x00785AEE
		// (set) Token: 0x0603804A RID: 229450 RVA: 0x007878F6 File Offset: 0x00785AF6
		public ITalkItemAutoPlayConfigT AutoPlayConfig { get; set; }

		// Token: 0x1700E907 RID: 59655
		// (get) Token: 0x0603804B RID: 229451 RVA: 0x007878FF File Offset: 0x00785AFF
		// (set) Token: 0x0603804C RID: 229452 RVA: 0x00787907 File Offset: 0x00785B07
		public uint NullMask { get; set; }

		// Token: 0x0603804D RID: 229453 RVA: 0x00787910 File Offset: 0x00785B10
		public ITalkItemOptionT()
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
			this.CameraMotion = null;
			this.AutoPlayConfig = null;
			this.NullMask = 0U;
		}
	}
}
