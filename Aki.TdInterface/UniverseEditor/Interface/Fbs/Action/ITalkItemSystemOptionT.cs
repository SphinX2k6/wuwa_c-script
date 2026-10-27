using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200730B RID: 29451
	public class ITalkItemSystemOptionT
	{
		// Token: 0x1700DDEE RID: 56814
		// (get) Token: 0x060350DA RID: 217306 RVA: 0x00731984 File Offset: 0x0072FB84
		// (set) Token: 0x060350DB RID: 217307 RVA: 0x0073198C File Offset: 0x0072FB8C
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DDEF RID: 56815
		// (get) Token: 0x060350DC RID: 217308 RVA: 0x00731995 File Offset: 0x0072FB95
		// (set) Token: 0x060350DD RID: 217309 RVA: 0x0073199D File Offset: 0x0072FB9D
		public int Id { get; set; }

		// Token: 0x1700DDF0 RID: 56816
		// (get) Token: 0x060350DE RID: 217310 RVA: 0x007319A6 File Offset: 0x0072FBA6
		// (set) Token: 0x060350DF RID: 217311 RVA: 0x007319AE File Offset: 0x0072FBAE
		public int PlotLineId { get; set; }

		// Token: 0x1700DDF1 RID: 56817
		// (get) Token: 0x060350E0 RID: 217312 RVA: 0x007319B7 File Offset: 0x0072FBB7
		// (set) Token: 0x060350E1 RID: 217313 RVA: 0x007319BF File Offset: 0x0072FBBF
		public string PlotLineKey { get; set; }

		// Token: 0x1700DDF2 RID: 56818
		// (get) Token: 0x060350E2 RID: 217314 RVA: 0x007319C8 File Offset: 0x0072FBC8
		// (set) Token: 0x060350E3 RID: 217315 RVA: 0x007319D0 File Offset: 0x0072FBD0
		public string Name { get; set; }

		// Token: 0x1700DDF3 RID: 56819
		// (get) Token: 0x060350E4 RID: 217316 RVA: 0x007319D9 File Offset: 0x0072FBD9
		// (set) Token: 0x060350E5 RID: 217317 RVA: 0x007319E1 File Offset: 0x0072FBE1
		public bool _Folded { get; set; }

		// Token: 0x1700DDF4 RID: 56820
		// (get) Token: 0x060350E6 RID: 217318 RVA: 0x007319EA File Offset: 0x0072FBEA
		// (set) Token: 0x060350E7 RID: 217319 RVA: 0x007319F2 File Offset: 0x0072FBF2
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DDF5 RID: 56821
		// (get) Token: 0x060350E8 RID: 217320 RVA: 0x007319FB File Offset: 0x0072FBFB
		// (set) Token: 0x060350E9 RID: 217321 RVA: 0x00731A03 File Offset: 0x0072FC03
		public int WhoId { get; set; }

		// Token: 0x1700DDF6 RID: 56822
		// (get) Token: 0x060350EA RID: 217322 RVA: 0x00731A0C File Offset: 0x0072FC0C
		// (set) Token: 0x060350EB RID: 217323 RVA: 0x00731A14 File Offset: 0x0072FC14
		public int TextId { get; set; }

		// Token: 0x1700DDF7 RID: 56823
		// (get) Token: 0x060350EC RID: 217324 RVA: 0x00731A1D File Offset: 0x0072FC1D
		// (set) Token: 0x060350ED RID: 217325 RVA: 0x00731A25 File Offset: 0x0072FC25
		public string TidTalk { get; set; }

		// Token: 0x1700DDF8 RID: 56824
		// (get) Token: 0x060350EE RID: 217326 RVA: 0x00731A2E File Offset: 0x0072FC2E
		// (set) Token: 0x060350EF RID: 217327 RVA: 0x00731A36 File Offset: 0x0072FC36
		public float WaitTime { get; set; }

		// Token: 0x1700DDF9 RID: 56825
		// (get) Token: 0x060350F0 RID: 217328 RVA: 0x00731A3F File Offset: 0x0072FC3F
		// (set) Token: 0x060350F1 RID: 217329 RVA: 0x00731A47 File Offset: 0x0072FC47
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DDFA RID: 56826
		// (get) Token: 0x060350F2 RID: 217330 RVA: 0x00731A50 File Offset: 0x0072FC50
		// (set) Token: 0x060350F3 RID: 217331 RVA: 0x00731A58 File Offset: 0x0072FC58
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DDFB RID: 56827
		// (get) Token: 0x060350F4 RID: 217332 RVA: 0x00731A61 File Offset: 0x0072FC61
		// (set) Token: 0x060350F5 RID: 217333 RVA: 0x00731A69 File Offset: 0x0072FC69
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DDFC RID: 56828
		// (get) Token: 0x060350F6 RID: 217334 RVA: 0x00731A72 File Offset: 0x0072FC72
		// (set) Token: 0x060350F7 RID: 217335 RVA: 0x00731A7A File Offset: 0x0072FC7A
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DDFD RID: 56829
		// (get) Token: 0x060350F8 RID: 217336 RVA: 0x00731A83 File Offset: 0x0072FC83
		// (set) Token: 0x060350F9 RID: 217337 RVA: 0x00731A8B File Offset: 0x0072FC8B
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DDFE RID: 56830
		// (get) Token: 0x060350FA RID: 217338 RVA: 0x00731A94 File Offset: 0x0072FC94
		// (set) Token: 0x060350FB RID: 217339 RVA: 0x00731A9C File Offset: 0x0072FC9C
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DDFF RID: 56831
		// (get) Token: 0x060350FC RID: 217340 RVA: 0x00731AA5 File Offset: 0x0072FCA5
		// (set) Token: 0x060350FD RID: 217341 RVA: 0x00731AAD File Offset: 0x0072FCAD
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DE00 RID: 56832
		// (get) Token: 0x060350FE RID: 217342 RVA: 0x00731AB6 File Offset: 0x0072FCB6
		// (set) Token: 0x060350FF RID: 217343 RVA: 0x00731ABE File Offset: 0x0072FCBE
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DE01 RID: 56833
		// (get) Token: 0x06035100 RID: 217344 RVA: 0x00731AC7 File Offset: 0x0072FCC7
		// (set) Token: 0x06035101 RID: 217345 RVA: 0x00731ACF File Offset: 0x0072FCCF
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DE02 RID: 56834
		// (get) Token: 0x06035102 RID: 217346 RVA: 0x00731AD8 File Offset: 0x0072FCD8
		// (set) Token: 0x06035103 RID: 217347 RVA: 0x00731AE0 File Offset: 0x0072FCE0
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DE03 RID: 56835
		// (get) Token: 0x06035104 RID: 217348 RVA: 0x00731AE9 File Offset: 0x0072FCE9
		// (set) Token: 0x06035105 RID: 217349 RVA: 0x00731AF1 File Offset: 0x0072FCF1
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DE04 RID: 56836
		// (get) Token: 0x06035106 RID: 217350 RVA: 0x00731AFA File Offset: 0x0072FCFA
		// (set) Token: 0x06035107 RID: 217351 RVA: 0x00731B02 File Offset: 0x0072FD02
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DE05 RID: 56837
		// (get) Token: 0x06035108 RID: 217352 RVA: 0x00731B0B File Offset: 0x0072FD0B
		// (set) Token: 0x06035109 RID: 217353 RVA: 0x00731B13 File Offset: 0x0072FD13
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DE06 RID: 56838
		// (get) Token: 0x0603510A RID: 217354 RVA: 0x00731B1C File Offset: 0x0072FD1C
		// (set) Token: 0x0603510B RID: 217355 RVA: 0x00731B24 File Offset: 0x0072FD24
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DE07 RID: 56839
		// (get) Token: 0x0603510C RID: 217356 RVA: 0x00731B2D File Offset: 0x0072FD2D
		// (set) Token: 0x0603510D RID: 217357 RVA: 0x00731B35 File Offset: 0x0072FD35
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DE08 RID: 56840
		// (get) Token: 0x0603510E RID: 217358 RVA: 0x00731B3E File Offset: 0x0072FD3E
		// (set) Token: 0x0603510F RID: 217359 RVA: 0x00731B46 File Offset: 0x0072FD46
		public bool PlayVoice { get; set; }

		// Token: 0x1700DE09 RID: 56841
		// (get) Token: 0x06035110 RID: 217360 RVA: 0x00731B4F File Offset: 0x0072FD4F
		// (set) Token: 0x06035111 RID: 217361 RVA: 0x00731B57 File Offset: 0x0072FD57
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DE0A RID: 56842
		// (get) Token: 0x06035112 RID: 217362 RVA: 0x00731B60 File Offset: 0x0072FD60
		// (set) Token: 0x06035113 RID: 217363 RVA: 0x00731B68 File Offset: 0x0072FD68
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DE0B RID: 56843
		// (get) Token: 0x06035114 RID: 217364 RVA: 0x00731B71 File Offset: 0x0072FD71
		// (set) Token: 0x06035115 RID: 217365 RVA: 0x00731B79 File Offset: 0x0072FD79
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DE0C RID: 56844
		// (get) Token: 0x06035116 RID: 217366 RVA: 0x00731B82 File Offset: 0x0072FD82
		// (set) Token: 0x06035117 RID: 217367 RVA: 0x00731B8A File Offset: 0x0072FD8A
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DE0D RID: 56845
		// (get) Token: 0x06035118 RID: 217368 RVA: 0x00731B93 File Offset: 0x0072FD93
		// (set) Token: 0x06035119 RID: 217369 RVA: 0x00731B9B File Offset: 0x0072FD9B
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DE0E RID: 56846
		// (get) Token: 0x0603511A RID: 217370 RVA: 0x00731BA4 File Offset: 0x0072FDA4
		// (set) Token: 0x0603511B RID: 217371 RVA: 0x00731BAC File Offset: 0x0072FDAC
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DE0F RID: 56847
		// (get) Token: 0x0603511C RID: 217372 RVA: 0x00731BB5 File Offset: 0x0072FDB5
		// (set) Token: 0x0603511D RID: 217373 RVA: 0x00731BBD File Offset: 0x0072FDBD
		public TSystemOptionUnion OptionConfig { get; set; }

		// Token: 0x1700DE10 RID: 56848
		// (get) Token: 0x0603511E RID: 217374 RVA: 0x00731BC6 File Offset: 0x0072FDC6
		// (set) Token: 0x0603511F RID: 217375 RVA: 0x00731BCE File Offset: 0x0072FDCE
		public uint NullMask { get; set; }

		// Token: 0x06035120 RID: 217376 RVA: 0x00731BD8 File Offset: 0x0072FDD8
		public ITalkItemSystemOptionT()
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
			this.OptionConfig = null;
			this.NullMask = 0U;
		}
	}
}
