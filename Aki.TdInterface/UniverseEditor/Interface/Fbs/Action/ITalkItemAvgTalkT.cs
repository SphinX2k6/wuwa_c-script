using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AAA RID: 31402
	public class ITalkItemAvgTalkT
	{
		// Token: 0x1700E7B1 RID: 59313
		// (get) Token: 0x06037BC4 RID: 228292 RVA: 0x007795C1 File Offset: 0x007777C1
		// (set) Token: 0x06037BC5 RID: 228293 RVA: 0x007795C9 File Offset: 0x007777C9
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E7B2 RID: 59314
		// (get) Token: 0x06037BC6 RID: 228294 RVA: 0x007795D2 File Offset: 0x007777D2
		// (set) Token: 0x06037BC7 RID: 228295 RVA: 0x007795DA File Offset: 0x007777DA
		public int Id { get; set; }

		// Token: 0x1700E7B3 RID: 59315
		// (get) Token: 0x06037BC8 RID: 228296 RVA: 0x007795E3 File Offset: 0x007777E3
		// (set) Token: 0x06037BC9 RID: 228297 RVA: 0x007795EB File Offset: 0x007777EB
		public int PlotLineId { get; set; }

		// Token: 0x1700E7B4 RID: 59316
		// (get) Token: 0x06037BCA RID: 228298 RVA: 0x007795F4 File Offset: 0x007777F4
		// (set) Token: 0x06037BCB RID: 228299 RVA: 0x007795FC File Offset: 0x007777FC
		public string PlotLineKey { get; set; }

		// Token: 0x1700E7B5 RID: 59317
		// (get) Token: 0x06037BCC RID: 228300 RVA: 0x00779605 File Offset: 0x00777805
		// (set) Token: 0x06037BCD RID: 228301 RVA: 0x0077960D File Offset: 0x0077780D
		public string Name { get; set; }

		// Token: 0x1700E7B6 RID: 59318
		// (get) Token: 0x06037BCE RID: 228302 RVA: 0x00779616 File Offset: 0x00777816
		// (set) Token: 0x06037BCF RID: 228303 RVA: 0x0077961E File Offset: 0x0077781E
		public bool _Folded { get; set; }

		// Token: 0x1700E7B7 RID: 59319
		// (get) Token: 0x06037BD0 RID: 228304 RVA: 0x00779627 File Offset: 0x00777827
		// (set) Token: 0x06037BD1 RID: 228305 RVA: 0x0077962F File Offset: 0x0077782F
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E7B8 RID: 59320
		// (get) Token: 0x06037BD2 RID: 228306 RVA: 0x00779638 File Offset: 0x00777838
		// (set) Token: 0x06037BD3 RID: 228307 RVA: 0x00779640 File Offset: 0x00777840
		public int WhoId { get; set; }

		// Token: 0x1700E7B9 RID: 59321
		// (get) Token: 0x06037BD4 RID: 228308 RVA: 0x00779649 File Offset: 0x00777849
		// (set) Token: 0x06037BD5 RID: 228309 RVA: 0x00779651 File Offset: 0x00777851
		public int TextId { get; set; }

		// Token: 0x1700E7BA RID: 59322
		// (get) Token: 0x06037BD6 RID: 228310 RVA: 0x0077965A File Offset: 0x0077785A
		// (set) Token: 0x06037BD7 RID: 228311 RVA: 0x00779662 File Offset: 0x00777862
		public string TidTalk { get; set; }

		// Token: 0x1700E7BB RID: 59323
		// (get) Token: 0x06037BD8 RID: 228312 RVA: 0x0077966B File Offset: 0x0077786B
		// (set) Token: 0x06037BD9 RID: 228313 RVA: 0x00779673 File Offset: 0x00777873
		public float WaitTime { get; set; }

		// Token: 0x1700E7BC RID: 59324
		// (get) Token: 0x06037BDA RID: 228314 RVA: 0x0077967C File Offset: 0x0077787C
		// (set) Token: 0x06037BDB RID: 228315 RVA: 0x00779684 File Offset: 0x00777884
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E7BD RID: 59325
		// (get) Token: 0x06037BDC RID: 228316 RVA: 0x0077968D File Offset: 0x0077788D
		// (set) Token: 0x06037BDD RID: 228317 RVA: 0x00779695 File Offset: 0x00777895
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E7BE RID: 59326
		// (get) Token: 0x06037BDE RID: 228318 RVA: 0x0077969E File Offset: 0x0077789E
		// (set) Token: 0x06037BDF RID: 228319 RVA: 0x007796A6 File Offset: 0x007778A6
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E7BF RID: 59327
		// (get) Token: 0x06037BE0 RID: 228320 RVA: 0x007796AF File Offset: 0x007778AF
		// (set) Token: 0x06037BE1 RID: 228321 RVA: 0x007796B7 File Offset: 0x007778B7
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E7C0 RID: 59328
		// (get) Token: 0x06037BE2 RID: 228322 RVA: 0x007796C0 File Offset: 0x007778C0
		// (set) Token: 0x06037BE3 RID: 228323 RVA: 0x007796C8 File Offset: 0x007778C8
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E7C1 RID: 59329
		// (get) Token: 0x06037BE4 RID: 228324 RVA: 0x007796D1 File Offset: 0x007778D1
		// (set) Token: 0x06037BE5 RID: 228325 RVA: 0x007796D9 File Offset: 0x007778D9
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E7C2 RID: 59330
		// (get) Token: 0x06037BE6 RID: 228326 RVA: 0x007796E2 File Offset: 0x007778E2
		// (set) Token: 0x06037BE7 RID: 228327 RVA: 0x007796EA File Offset: 0x007778EA
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E7C3 RID: 59331
		// (get) Token: 0x06037BE8 RID: 228328 RVA: 0x007796F3 File Offset: 0x007778F3
		// (set) Token: 0x06037BE9 RID: 228329 RVA: 0x007796FB File Offset: 0x007778FB
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E7C4 RID: 59332
		// (get) Token: 0x06037BEA RID: 228330 RVA: 0x00779704 File Offset: 0x00777904
		// (set) Token: 0x06037BEB RID: 228331 RVA: 0x0077970C File Offset: 0x0077790C
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E7C5 RID: 59333
		// (get) Token: 0x06037BEC RID: 228332 RVA: 0x00779715 File Offset: 0x00777915
		// (set) Token: 0x06037BED RID: 228333 RVA: 0x0077971D File Offset: 0x0077791D
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E7C6 RID: 59334
		// (get) Token: 0x06037BEE RID: 228334 RVA: 0x00779726 File Offset: 0x00777926
		// (set) Token: 0x06037BEF RID: 228335 RVA: 0x0077972E File Offset: 0x0077792E
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E7C7 RID: 59335
		// (get) Token: 0x06037BF0 RID: 228336 RVA: 0x00779737 File Offset: 0x00777937
		// (set) Token: 0x06037BF1 RID: 228337 RVA: 0x0077973F File Offset: 0x0077793F
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E7C8 RID: 59336
		// (get) Token: 0x06037BF2 RID: 228338 RVA: 0x00779748 File Offset: 0x00777948
		// (set) Token: 0x06037BF3 RID: 228339 RVA: 0x00779750 File Offset: 0x00777950
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E7C9 RID: 59337
		// (get) Token: 0x06037BF4 RID: 228340 RVA: 0x00779759 File Offset: 0x00777959
		// (set) Token: 0x06037BF5 RID: 228341 RVA: 0x00779761 File Offset: 0x00777961
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E7CA RID: 59338
		// (get) Token: 0x06037BF6 RID: 228342 RVA: 0x0077976A File Offset: 0x0077796A
		// (set) Token: 0x06037BF7 RID: 228343 RVA: 0x00779772 File Offset: 0x00777972
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E7CB RID: 59339
		// (get) Token: 0x06037BF8 RID: 228344 RVA: 0x0077977B File Offset: 0x0077797B
		// (set) Token: 0x06037BF9 RID: 228345 RVA: 0x00779783 File Offset: 0x00777983
		public bool PlayVoice { get; set; }

		// Token: 0x1700E7CC RID: 59340
		// (get) Token: 0x06037BFA RID: 228346 RVA: 0x0077978C File Offset: 0x0077798C
		// (set) Token: 0x06037BFB RID: 228347 RVA: 0x00779794 File Offset: 0x00777994
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E7CD RID: 59341
		// (get) Token: 0x06037BFC RID: 228348 RVA: 0x0077979D File Offset: 0x0077799D
		// (set) Token: 0x06037BFD RID: 228349 RVA: 0x007797A5 File Offset: 0x007779A5
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E7CE RID: 59342
		// (get) Token: 0x06037BFE RID: 228350 RVA: 0x007797AE File Offset: 0x007779AE
		// (set) Token: 0x06037BFF RID: 228351 RVA: 0x007797B6 File Offset: 0x007779B6
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E7CF RID: 59343
		// (get) Token: 0x06037C00 RID: 228352 RVA: 0x007797BF File Offset: 0x007779BF
		// (set) Token: 0x06037C01 RID: 228353 RVA: 0x007797C7 File Offset: 0x007779C7
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E7D0 RID: 59344
		// (get) Token: 0x06037C02 RID: 228354 RVA: 0x007797D0 File Offset: 0x007779D0
		// (set) Token: 0x06037C03 RID: 228355 RVA: 0x007797D8 File Offset: 0x007779D8
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E7D1 RID: 59345
		// (get) Token: 0x06037C04 RID: 228356 RVA: 0x007797E1 File Offset: 0x007779E1
		// (set) Token: 0x06037C05 RID: 228357 RVA: 0x007797E9 File Offset: 0x007779E9
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E7D2 RID: 59346
		// (get) Token: 0x06037C06 RID: 228358 RVA: 0x007797F2 File Offset: 0x007779F2
		// (set) Token: 0x06037C07 RID: 228359 RVA: 0x007797FA File Offset: 0x007779FA
		public ITalkItemAvgRoleConfigT AvgRoleConfig { get; set; }

		// Token: 0x1700E7D3 RID: 59347
		// (get) Token: 0x06037C08 RID: 228360 RVA: 0x00779803 File Offset: 0x00777A03
		// (set) Token: 0x06037C09 RID: 228361 RVA: 0x0077980B File Offset: 0x00777A0B
		public EAvgRolePosition PositionConfig { get; set; }

		// Token: 0x1700E7D4 RID: 59348
		// (get) Token: 0x06037C0A RID: 228362 RVA: 0x00779814 File Offset: 0x00777A14
		// (set) Token: 0x06037C0B RID: 228363 RVA: 0x0077981C File Offset: 0x00777A1C
		public uint NullMask { get; set; }

		// Token: 0x06037C0C RID: 228364 RVA: 0x00779828 File Offset: 0x00777A28
		public ITalkItemAvgTalkT()
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
			this.PositionConfig = EAvgRolePosition.Center;
			this.NullMask = 0U;
		}
	}
}
