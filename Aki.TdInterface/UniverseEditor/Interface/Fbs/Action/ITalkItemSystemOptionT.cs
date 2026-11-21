using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AE3 RID: 31459
	public class ITalkItemSystemOptionT
	{
		// Token: 0x1700E9EC RID: 59884
		// (get) Token: 0x060383FD RID: 230397 RVA: 0x00793208 File Offset: 0x00791408
		// (set) Token: 0x060383FE RID: 230398 RVA: 0x00793210 File Offset: 0x00791410
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E9ED RID: 59885
		// (get) Token: 0x060383FF RID: 230399 RVA: 0x00793219 File Offset: 0x00791419
		// (set) Token: 0x06038400 RID: 230400 RVA: 0x00793221 File Offset: 0x00791421
		public int Id { get; set; }

		// Token: 0x1700E9EE RID: 59886
		// (get) Token: 0x06038401 RID: 230401 RVA: 0x0079322A File Offset: 0x0079142A
		// (set) Token: 0x06038402 RID: 230402 RVA: 0x00793232 File Offset: 0x00791432
		public int PlotLineId { get; set; }

		// Token: 0x1700E9EF RID: 59887
		// (get) Token: 0x06038403 RID: 230403 RVA: 0x0079323B File Offset: 0x0079143B
		// (set) Token: 0x06038404 RID: 230404 RVA: 0x00793243 File Offset: 0x00791443
		public string PlotLineKey { get; set; }

		// Token: 0x1700E9F0 RID: 59888
		// (get) Token: 0x06038405 RID: 230405 RVA: 0x0079324C File Offset: 0x0079144C
		// (set) Token: 0x06038406 RID: 230406 RVA: 0x00793254 File Offset: 0x00791454
		public string Name { get; set; }

		// Token: 0x1700E9F1 RID: 59889
		// (get) Token: 0x06038407 RID: 230407 RVA: 0x0079325D File Offset: 0x0079145D
		// (set) Token: 0x06038408 RID: 230408 RVA: 0x00793265 File Offset: 0x00791465
		public bool _Folded { get; set; }

		// Token: 0x1700E9F2 RID: 59890
		// (get) Token: 0x06038409 RID: 230409 RVA: 0x0079326E File Offset: 0x0079146E
		// (set) Token: 0x0603840A RID: 230410 RVA: 0x00793276 File Offset: 0x00791476
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E9F3 RID: 59891
		// (get) Token: 0x0603840B RID: 230411 RVA: 0x0079327F File Offset: 0x0079147F
		// (set) Token: 0x0603840C RID: 230412 RVA: 0x00793287 File Offset: 0x00791487
		public int WhoId { get; set; }

		// Token: 0x1700E9F4 RID: 59892
		// (get) Token: 0x0603840D RID: 230413 RVA: 0x00793290 File Offset: 0x00791490
		// (set) Token: 0x0603840E RID: 230414 RVA: 0x00793298 File Offset: 0x00791498
		public int TextId { get; set; }

		// Token: 0x1700E9F5 RID: 59893
		// (get) Token: 0x0603840F RID: 230415 RVA: 0x007932A1 File Offset: 0x007914A1
		// (set) Token: 0x06038410 RID: 230416 RVA: 0x007932A9 File Offset: 0x007914A9
		public string TidTalk { get; set; }

		// Token: 0x1700E9F6 RID: 59894
		// (get) Token: 0x06038411 RID: 230417 RVA: 0x007932B2 File Offset: 0x007914B2
		// (set) Token: 0x06038412 RID: 230418 RVA: 0x007932BA File Offset: 0x007914BA
		public float WaitTime { get; set; }

		// Token: 0x1700E9F7 RID: 59895
		// (get) Token: 0x06038413 RID: 230419 RVA: 0x007932C3 File Offset: 0x007914C3
		// (set) Token: 0x06038414 RID: 230420 RVA: 0x007932CB File Offset: 0x007914CB
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E9F8 RID: 59896
		// (get) Token: 0x06038415 RID: 230421 RVA: 0x007932D4 File Offset: 0x007914D4
		// (set) Token: 0x06038416 RID: 230422 RVA: 0x007932DC File Offset: 0x007914DC
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E9F9 RID: 59897
		// (get) Token: 0x06038417 RID: 230423 RVA: 0x007932E5 File Offset: 0x007914E5
		// (set) Token: 0x06038418 RID: 230424 RVA: 0x007932ED File Offset: 0x007914ED
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E9FA RID: 59898
		// (get) Token: 0x06038419 RID: 230425 RVA: 0x007932F6 File Offset: 0x007914F6
		// (set) Token: 0x0603841A RID: 230426 RVA: 0x007932FE File Offset: 0x007914FE
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E9FB RID: 59899
		// (get) Token: 0x0603841B RID: 230427 RVA: 0x00793307 File Offset: 0x00791507
		// (set) Token: 0x0603841C RID: 230428 RVA: 0x0079330F File Offset: 0x0079150F
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E9FC RID: 59900
		// (get) Token: 0x0603841D RID: 230429 RVA: 0x00793318 File Offset: 0x00791518
		// (set) Token: 0x0603841E RID: 230430 RVA: 0x00793320 File Offset: 0x00791520
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E9FD RID: 59901
		// (get) Token: 0x0603841F RID: 230431 RVA: 0x00793329 File Offset: 0x00791529
		// (set) Token: 0x06038420 RID: 230432 RVA: 0x00793331 File Offset: 0x00791531
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E9FE RID: 59902
		// (get) Token: 0x06038421 RID: 230433 RVA: 0x0079333A File Offset: 0x0079153A
		// (set) Token: 0x06038422 RID: 230434 RVA: 0x00793342 File Offset: 0x00791542
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E9FF RID: 59903
		// (get) Token: 0x06038423 RID: 230435 RVA: 0x0079334B File Offset: 0x0079154B
		// (set) Token: 0x06038424 RID: 230436 RVA: 0x00793353 File Offset: 0x00791553
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700EA00 RID: 59904
		// (get) Token: 0x06038425 RID: 230437 RVA: 0x0079335C File Offset: 0x0079155C
		// (set) Token: 0x06038426 RID: 230438 RVA: 0x00793364 File Offset: 0x00791564
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700EA01 RID: 59905
		// (get) Token: 0x06038427 RID: 230439 RVA: 0x0079336D File Offset: 0x0079156D
		// (set) Token: 0x06038428 RID: 230440 RVA: 0x00793375 File Offset: 0x00791575
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700EA02 RID: 59906
		// (get) Token: 0x06038429 RID: 230441 RVA: 0x0079337E File Offset: 0x0079157E
		// (set) Token: 0x0603842A RID: 230442 RVA: 0x00793386 File Offset: 0x00791586
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700EA03 RID: 59907
		// (get) Token: 0x0603842B RID: 230443 RVA: 0x0079338F File Offset: 0x0079158F
		// (set) Token: 0x0603842C RID: 230444 RVA: 0x00793397 File Offset: 0x00791597
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700EA04 RID: 59908
		// (get) Token: 0x0603842D RID: 230445 RVA: 0x007933A0 File Offset: 0x007915A0
		// (set) Token: 0x0603842E RID: 230446 RVA: 0x007933A8 File Offset: 0x007915A8
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700EA05 RID: 59909
		// (get) Token: 0x0603842F RID: 230447 RVA: 0x007933B1 File Offset: 0x007915B1
		// (set) Token: 0x06038430 RID: 230448 RVA: 0x007933B9 File Offset: 0x007915B9
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700EA06 RID: 59910
		// (get) Token: 0x06038431 RID: 230449 RVA: 0x007933C2 File Offset: 0x007915C2
		// (set) Token: 0x06038432 RID: 230450 RVA: 0x007933CA File Offset: 0x007915CA
		public bool PlayVoice { get; set; }

		// Token: 0x1700EA07 RID: 59911
		// (get) Token: 0x06038433 RID: 230451 RVA: 0x007933D3 File Offset: 0x007915D3
		// (set) Token: 0x06038434 RID: 230452 RVA: 0x007933DB File Offset: 0x007915DB
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700EA08 RID: 59912
		// (get) Token: 0x06038435 RID: 230453 RVA: 0x007933E4 File Offset: 0x007915E4
		// (set) Token: 0x06038436 RID: 230454 RVA: 0x007933EC File Offset: 0x007915EC
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700EA09 RID: 59913
		// (get) Token: 0x06038437 RID: 230455 RVA: 0x007933F5 File Offset: 0x007915F5
		// (set) Token: 0x06038438 RID: 230456 RVA: 0x007933FD File Offset: 0x007915FD
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700EA0A RID: 59914
		// (get) Token: 0x06038439 RID: 230457 RVA: 0x00793406 File Offset: 0x00791606
		// (set) Token: 0x0603843A RID: 230458 RVA: 0x0079340E File Offset: 0x0079160E
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700EA0B RID: 59915
		// (get) Token: 0x0603843B RID: 230459 RVA: 0x00793417 File Offset: 0x00791617
		// (set) Token: 0x0603843C RID: 230460 RVA: 0x0079341F File Offset: 0x0079161F
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700EA0C RID: 59916
		// (get) Token: 0x0603843D RID: 230461 RVA: 0x00793428 File Offset: 0x00791628
		// (set) Token: 0x0603843E RID: 230462 RVA: 0x00793430 File Offset: 0x00791630
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700EA0D RID: 59917
		// (get) Token: 0x0603843F RID: 230463 RVA: 0x00793439 File Offset: 0x00791639
		// (set) Token: 0x06038440 RID: 230464 RVA: 0x00793441 File Offset: 0x00791641
		public TSystemOptionUnion OptionConfig { get; set; }

		// Token: 0x1700EA0E RID: 59918
		// (get) Token: 0x06038441 RID: 230465 RVA: 0x0079344A File Offset: 0x0079164A
		// (set) Token: 0x06038442 RID: 230466 RVA: 0x00793452 File Offset: 0x00791652
		public uint NullMask { get; set; }

		// Token: 0x06038443 RID: 230467 RVA: 0x0079345C File Offset: 0x0079165C
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
