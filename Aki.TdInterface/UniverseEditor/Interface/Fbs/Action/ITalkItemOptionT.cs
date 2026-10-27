using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E4 RID: 29412
	public class ITalkItemOptionT
	{
		// Token: 0x1700DCEB RID: 56555
		// (get) Token: 0x06034D00 RID: 216320 RVA: 0x007262AC File Offset: 0x007244AC
		// (set) Token: 0x06034D01 RID: 216321 RVA: 0x007262B4 File Offset: 0x007244B4
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DCEC RID: 56556
		// (get) Token: 0x06034D02 RID: 216322 RVA: 0x007262BD File Offset: 0x007244BD
		// (set) Token: 0x06034D03 RID: 216323 RVA: 0x007262C5 File Offset: 0x007244C5
		public int Id { get; set; }

		// Token: 0x1700DCED RID: 56557
		// (get) Token: 0x06034D04 RID: 216324 RVA: 0x007262CE File Offset: 0x007244CE
		// (set) Token: 0x06034D05 RID: 216325 RVA: 0x007262D6 File Offset: 0x007244D6
		public int PlotLineId { get; set; }

		// Token: 0x1700DCEE RID: 56558
		// (get) Token: 0x06034D06 RID: 216326 RVA: 0x007262DF File Offset: 0x007244DF
		// (set) Token: 0x06034D07 RID: 216327 RVA: 0x007262E7 File Offset: 0x007244E7
		public string PlotLineKey { get; set; }

		// Token: 0x1700DCEF RID: 56559
		// (get) Token: 0x06034D08 RID: 216328 RVA: 0x007262F0 File Offset: 0x007244F0
		// (set) Token: 0x06034D09 RID: 216329 RVA: 0x007262F8 File Offset: 0x007244F8
		public string Name { get; set; }

		// Token: 0x1700DCF0 RID: 56560
		// (get) Token: 0x06034D0A RID: 216330 RVA: 0x00726301 File Offset: 0x00724501
		// (set) Token: 0x06034D0B RID: 216331 RVA: 0x00726309 File Offset: 0x00724509
		public bool _Folded { get; set; }

		// Token: 0x1700DCF1 RID: 56561
		// (get) Token: 0x06034D0C RID: 216332 RVA: 0x00726312 File Offset: 0x00724512
		// (set) Token: 0x06034D0D RID: 216333 RVA: 0x0072631A File Offset: 0x0072451A
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DCF2 RID: 56562
		// (get) Token: 0x06034D0E RID: 216334 RVA: 0x00726323 File Offset: 0x00724523
		// (set) Token: 0x06034D0F RID: 216335 RVA: 0x0072632B File Offset: 0x0072452B
		public int WhoId { get; set; }

		// Token: 0x1700DCF3 RID: 56563
		// (get) Token: 0x06034D10 RID: 216336 RVA: 0x00726334 File Offset: 0x00724534
		// (set) Token: 0x06034D11 RID: 216337 RVA: 0x0072633C File Offset: 0x0072453C
		public int TextId { get; set; }

		// Token: 0x1700DCF4 RID: 56564
		// (get) Token: 0x06034D12 RID: 216338 RVA: 0x00726345 File Offset: 0x00724545
		// (set) Token: 0x06034D13 RID: 216339 RVA: 0x0072634D File Offset: 0x0072454D
		public string TidTalk { get; set; }

		// Token: 0x1700DCF5 RID: 56565
		// (get) Token: 0x06034D14 RID: 216340 RVA: 0x00726356 File Offset: 0x00724556
		// (set) Token: 0x06034D15 RID: 216341 RVA: 0x0072635E File Offset: 0x0072455E
		public float WaitTime { get; set; }

		// Token: 0x1700DCF6 RID: 56566
		// (get) Token: 0x06034D16 RID: 216342 RVA: 0x00726367 File Offset: 0x00724567
		// (set) Token: 0x06034D17 RID: 216343 RVA: 0x0072636F File Offset: 0x0072456F
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DCF7 RID: 56567
		// (get) Token: 0x06034D18 RID: 216344 RVA: 0x00726378 File Offset: 0x00724578
		// (set) Token: 0x06034D19 RID: 216345 RVA: 0x00726380 File Offset: 0x00724580
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DCF8 RID: 56568
		// (get) Token: 0x06034D1A RID: 216346 RVA: 0x00726389 File Offset: 0x00724589
		// (set) Token: 0x06034D1B RID: 216347 RVA: 0x00726391 File Offset: 0x00724591
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DCF9 RID: 56569
		// (get) Token: 0x06034D1C RID: 216348 RVA: 0x0072639A File Offset: 0x0072459A
		// (set) Token: 0x06034D1D RID: 216349 RVA: 0x007263A2 File Offset: 0x007245A2
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DCFA RID: 56570
		// (get) Token: 0x06034D1E RID: 216350 RVA: 0x007263AB File Offset: 0x007245AB
		// (set) Token: 0x06034D1F RID: 216351 RVA: 0x007263B3 File Offset: 0x007245B3
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DCFB RID: 56571
		// (get) Token: 0x06034D20 RID: 216352 RVA: 0x007263BC File Offset: 0x007245BC
		// (set) Token: 0x06034D21 RID: 216353 RVA: 0x007263C4 File Offset: 0x007245C4
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DCFC RID: 56572
		// (get) Token: 0x06034D22 RID: 216354 RVA: 0x007263CD File Offset: 0x007245CD
		// (set) Token: 0x06034D23 RID: 216355 RVA: 0x007263D5 File Offset: 0x007245D5
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DCFD RID: 56573
		// (get) Token: 0x06034D24 RID: 216356 RVA: 0x007263DE File Offset: 0x007245DE
		// (set) Token: 0x06034D25 RID: 216357 RVA: 0x007263E6 File Offset: 0x007245E6
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DCFE RID: 56574
		// (get) Token: 0x06034D26 RID: 216358 RVA: 0x007263EF File Offset: 0x007245EF
		// (set) Token: 0x06034D27 RID: 216359 RVA: 0x007263F7 File Offset: 0x007245F7
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DCFF RID: 56575
		// (get) Token: 0x06034D28 RID: 216360 RVA: 0x00726400 File Offset: 0x00724600
		// (set) Token: 0x06034D29 RID: 216361 RVA: 0x00726408 File Offset: 0x00724608
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DD00 RID: 56576
		// (get) Token: 0x06034D2A RID: 216362 RVA: 0x00726411 File Offset: 0x00724611
		// (set) Token: 0x06034D2B RID: 216363 RVA: 0x00726419 File Offset: 0x00724619
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DD01 RID: 56577
		// (get) Token: 0x06034D2C RID: 216364 RVA: 0x00726422 File Offset: 0x00724622
		// (set) Token: 0x06034D2D RID: 216365 RVA: 0x0072642A File Offset: 0x0072462A
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DD02 RID: 56578
		// (get) Token: 0x06034D2E RID: 216366 RVA: 0x00726433 File Offset: 0x00724633
		// (set) Token: 0x06034D2F RID: 216367 RVA: 0x0072643B File Offset: 0x0072463B
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DD03 RID: 56579
		// (get) Token: 0x06034D30 RID: 216368 RVA: 0x00726444 File Offset: 0x00724644
		// (set) Token: 0x06034D31 RID: 216369 RVA: 0x0072644C File Offset: 0x0072464C
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DD04 RID: 56580
		// (get) Token: 0x06034D32 RID: 216370 RVA: 0x00726455 File Offset: 0x00724655
		// (set) Token: 0x06034D33 RID: 216371 RVA: 0x0072645D File Offset: 0x0072465D
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DD05 RID: 56581
		// (get) Token: 0x06034D34 RID: 216372 RVA: 0x00726466 File Offset: 0x00724666
		// (set) Token: 0x06034D35 RID: 216373 RVA: 0x0072646E File Offset: 0x0072466E
		public bool PlayVoice { get; set; }

		// Token: 0x1700DD06 RID: 56582
		// (get) Token: 0x06034D36 RID: 216374 RVA: 0x00726477 File Offset: 0x00724677
		// (set) Token: 0x06034D37 RID: 216375 RVA: 0x0072647F File Offset: 0x0072467F
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DD07 RID: 56583
		// (get) Token: 0x06034D38 RID: 216376 RVA: 0x00726488 File Offset: 0x00724688
		// (set) Token: 0x06034D39 RID: 216377 RVA: 0x00726490 File Offset: 0x00724690
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DD08 RID: 56584
		// (get) Token: 0x06034D3A RID: 216378 RVA: 0x00726499 File Offset: 0x00724699
		// (set) Token: 0x06034D3B RID: 216379 RVA: 0x007264A1 File Offset: 0x007246A1
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DD09 RID: 56585
		// (get) Token: 0x06034D3C RID: 216380 RVA: 0x007264AA File Offset: 0x007246AA
		// (set) Token: 0x06034D3D RID: 216381 RVA: 0x007264B2 File Offset: 0x007246B2
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DD0A RID: 56586
		// (get) Token: 0x06034D3E RID: 216382 RVA: 0x007264BB File Offset: 0x007246BB
		// (set) Token: 0x06034D3F RID: 216383 RVA: 0x007264C3 File Offset: 0x007246C3
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DD0B RID: 56587
		// (get) Token: 0x06034D40 RID: 216384 RVA: 0x007264CC File Offset: 0x007246CC
		// (set) Token: 0x06034D41 RID: 216385 RVA: 0x007264D4 File Offset: 0x007246D4
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DD0C RID: 56588
		// (get) Token: 0x06034D42 RID: 216386 RVA: 0x007264DD File Offset: 0x007246DD
		// (set) Token: 0x06034D43 RID: 216387 RVA: 0x007264E5 File Offset: 0x007246E5
		public TShowTalkCameraMotionUnion CameraMotion { get; set; }

		// Token: 0x1700DD0D RID: 56589
		// (get) Token: 0x06034D44 RID: 216388 RVA: 0x007264EE File Offset: 0x007246EE
		// (set) Token: 0x06034D45 RID: 216389 RVA: 0x007264F6 File Offset: 0x007246F6
		public ITalkItemAutoPlayConfigT AutoPlayConfig { get; set; }

		// Token: 0x1700DD0E RID: 56590
		// (get) Token: 0x06034D46 RID: 216390 RVA: 0x007264FF File Offset: 0x007246FF
		// (set) Token: 0x06034D47 RID: 216391 RVA: 0x00726507 File Offset: 0x00724707
		public uint NullMask { get; set; }

		// Token: 0x06034D48 RID: 216392 RVA: 0x00726510 File Offset: 0x00724710
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
