using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D5 RID: 29397
	public class ITalkItemAvgTalkT
	{
		// Token: 0x1700DBB8 RID: 56248
		// (get) Token: 0x060348C0 RID: 215232 RVA: 0x00718225 File Offset: 0x00716425
		// (set) Token: 0x060348C1 RID: 215233 RVA: 0x0071822D File Offset: 0x0071642D
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DBB9 RID: 56249
		// (get) Token: 0x060348C2 RID: 215234 RVA: 0x00718236 File Offset: 0x00716436
		// (set) Token: 0x060348C3 RID: 215235 RVA: 0x0071823E File Offset: 0x0071643E
		public int Id { get; set; }

		// Token: 0x1700DBBA RID: 56250
		// (get) Token: 0x060348C4 RID: 215236 RVA: 0x00718247 File Offset: 0x00716447
		// (set) Token: 0x060348C5 RID: 215237 RVA: 0x0071824F File Offset: 0x0071644F
		public int PlotLineId { get; set; }

		// Token: 0x1700DBBB RID: 56251
		// (get) Token: 0x060348C6 RID: 215238 RVA: 0x00718258 File Offset: 0x00716458
		// (set) Token: 0x060348C7 RID: 215239 RVA: 0x00718260 File Offset: 0x00716460
		public string PlotLineKey { get; set; }

		// Token: 0x1700DBBC RID: 56252
		// (get) Token: 0x060348C8 RID: 215240 RVA: 0x00718269 File Offset: 0x00716469
		// (set) Token: 0x060348C9 RID: 215241 RVA: 0x00718271 File Offset: 0x00716471
		public string Name { get; set; }

		// Token: 0x1700DBBD RID: 56253
		// (get) Token: 0x060348CA RID: 215242 RVA: 0x0071827A File Offset: 0x0071647A
		// (set) Token: 0x060348CB RID: 215243 RVA: 0x00718282 File Offset: 0x00716482
		public bool _Folded { get; set; }

		// Token: 0x1700DBBE RID: 56254
		// (get) Token: 0x060348CC RID: 215244 RVA: 0x0071828B File Offset: 0x0071648B
		// (set) Token: 0x060348CD RID: 215245 RVA: 0x00718293 File Offset: 0x00716493
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DBBF RID: 56255
		// (get) Token: 0x060348CE RID: 215246 RVA: 0x0071829C File Offset: 0x0071649C
		// (set) Token: 0x060348CF RID: 215247 RVA: 0x007182A4 File Offset: 0x007164A4
		public int WhoId { get; set; }

		// Token: 0x1700DBC0 RID: 56256
		// (get) Token: 0x060348D0 RID: 215248 RVA: 0x007182AD File Offset: 0x007164AD
		// (set) Token: 0x060348D1 RID: 215249 RVA: 0x007182B5 File Offset: 0x007164B5
		public int TextId { get; set; }

		// Token: 0x1700DBC1 RID: 56257
		// (get) Token: 0x060348D2 RID: 215250 RVA: 0x007182BE File Offset: 0x007164BE
		// (set) Token: 0x060348D3 RID: 215251 RVA: 0x007182C6 File Offset: 0x007164C6
		public string TidTalk { get; set; }

		// Token: 0x1700DBC2 RID: 56258
		// (get) Token: 0x060348D4 RID: 215252 RVA: 0x007182CF File Offset: 0x007164CF
		// (set) Token: 0x060348D5 RID: 215253 RVA: 0x007182D7 File Offset: 0x007164D7
		public float WaitTime { get; set; }

		// Token: 0x1700DBC3 RID: 56259
		// (get) Token: 0x060348D6 RID: 215254 RVA: 0x007182E0 File Offset: 0x007164E0
		// (set) Token: 0x060348D7 RID: 215255 RVA: 0x007182E8 File Offset: 0x007164E8
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DBC4 RID: 56260
		// (get) Token: 0x060348D8 RID: 215256 RVA: 0x007182F1 File Offset: 0x007164F1
		// (set) Token: 0x060348D9 RID: 215257 RVA: 0x007182F9 File Offset: 0x007164F9
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DBC5 RID: 56261
		// (get) Token: 0x060348DA RID: 215258 RVA: 0x00718302 File Offset: 0x00716502
		// (set) Token: 0x060348DB RID: 215259 RVA: 0x0071830A File Offset: 0x0071650A
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DBC6 RID: 56262
		// (get) Token: 0x060348DC RID: 215260 RVA: 0x00718313 File Offset: 0x00716513
		// (set) Token: 0x060348DD RID: 215261 RVA: 0x0071831B File Offset: 0x0071651B
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DBC7 RID: 56263
		// (get) Token: 0x060348DE RID: 215262 RVA: 0x00718324 File Offset: 0x00716524
		// (set) Token: 0x060348DF RID: 215263 RVA: 0x0071832C File Offset: 0x0071652C
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DBC8 RID: 56264
		// (get) Token: 0x060348E0 RID: 215264 RVA: 0x00718335 File Offset: 0x00716535
		// (set) Token: 0x060348E1 RID: 215265 RVA: 0x0071833D File Offset: 0x0071653D
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DBC9 RID: 56265
		// (get) Token: 0x060348E2 RID: 215266 RVA: 0x00718346 File Offset: 0x00716546
		// (set) Token: 0x060348E3 RID: 215267 RVA: 0x0071834E File Offset: 0x0071654E
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DBCA RID: 56266
		// (get) Token: 0x060348E4 RID: 215268 RVA: 0x00718357 File Offset: 0x00716557
		// (set) Token: 0x060348E5 RID: 215269 RVA: 0x0071835F File Offset: 0x0071655F
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DBCB RID: 56267
		// (get) Token: 0x060348E6 RID: 215270 RVA: 0x00718368 File Offset: 0x00716568
		// (set) Token: 0x060348E7 RID: 215271 RVA: 0x00718370 File Offset: 0x00716570
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DBCC RID: 56268
		// (get) Token: 0x060348E8 RID: 215272 RVA: 0x00718379 File Offset: 0x00716579
		// (set) Token: 0x060348E9 RID: 215273 RVA: 0x00718381 File Offset: 0x00716581
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DBCD RID: 56269
		// (get) Token: 0x060348EA RID: 215274 RVA: 0x0071838A File Offset: 0x0071658A
		// (set) Token: 0x060348EB RID: 215275 RVA: 0x00718392 File Offset: 0x00716592
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DBCE RID: 56270
		// (get) Token: 0x060348EC RID: 215276 RVA: 0x0071839B File Offset: 0x0071659B
		// (set) Token: 0x060348ED RID: 215277 RVA: 0x007183A3 File Offset: 0x007165A3
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DBCF RID: 56271
		// (get) Token: 0x060348EE RID: 215278 RVA: 0x007183AC File Offset: 0x007165AC
		// (set) Token: 0x060348EF RID: 215279 RVA: 0x007183B4 File Offset: 0x007165B4
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DBD0 RID: 56272
		// (get) Token: 0x060348F0 RID: 215280 RVA: 0x007183BD File Offset: 0x007165BD
		// (set) Token: 0x060348F1 RID: 215281 RVA: 0x007183C5 File Offset: 0x007165C5
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DBD1 RID: 56273
		// (get) Token: 0x060348F2 RID: 215282 RVA: 0x007183CE File Offset: 0x007165CE
		// (set) Token: 0x060348F3 RID: 215283 RVA: 0x007183D6 File Offset: 0x007165D6
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DBD2 RID: 56274
		// (get) Token: 0x060348F4 RID: 215284 RVA: 0x007183DF File Offset: 0x007165DF
		// (set) Token: 0x060348F5 RID: 215285 RVA: 0x007183E7 File Offset: 0x007165E7
		public bool PlayVoice { get; set; }

		// Token: 0x1700DBD3 RID: 56275
		// (get) Token: 0x060348F6 RID: 215286 RVA: 0x007183F0 File Offset: 0x007165F0
		// (set) Token: 0x060348F7 RID: 215287 RVA: 0x007183F8 File Offset: 0x007165F8
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DBD4 RID: 56276
		// (get) Token: 0x060348F8 RID: 215288 RVA: 0x00718401 File Offset: 0x00716601
		// (set) Token: 0x060348F9 RID: 215289 RVA: 0x00718409 File Offset: 0x00716609
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DBD5 RID: 56277
		// (get) Token: 0x060348FA RID: 215290 RVA: 0x00718412 File Offset: 0x00716612
		// (set) Token: 0x060348FB RID: 215291 RVA: 0x0071841A File Offset: 0x0071661A
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DBD6 RID: 56278
		// (get) Token: 0x060348FC RID: 215292 RVA: 0x00718423 File Offset: 0x00716623
		// (set) Token: 0x060348FD RID: 215293 RVA: 0x0071842B File Offset: 0x0071662B
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DBD7 RID: 56279
		// (get) Token: 0x060348FE RID: 215294 RVA: 0x00718434 File Offset: 0x00716634
		// (set) Token: 0x060348FF RID: 215295 RVA: 0x0071843C File Offset: 0x0071663C
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DBD8 RID: 56280
		// (get) Token: 0x06034900 RID: 215296 RVA: 0x00718445 File Offset: 0x00716645
		// (set) Token: 0x06034901 RID: 215297 RVA: 0x0071844D File Offset: 0x0071664D
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DBD9 RID: 56281
		// (get) Token: 0x06034902 RID: 215298 RVA: 0x00718456 File Offset: 0x00716656
		// (set) Token: 0x06034903 RID: 215299 RVA: 0x0071845E File Offset: 0x0071665E
		public ITalkItemAvgRoleConfigT AvgRoleConfig { get; set; }

		// Token: 0x1700DBDA RID: 56282
		// (get) Token: 0x06034904 RID: 215300 RVA: 0x00718467 File Offset: 0x00716667
		// (set) Token: 0x06034905 RID: 215301 RVA: 0x0071846F File Offset: 0x0071666F
		public EAvgRolePosition PositionConfig { get; set; }

		// Token: 0x1700DBDB RID: 56283
		// (get) Token: 0x06034906 RID: 215302 RVA: 0x00718478 File Offset: 0x00716678
		// (set) Token: 0x06034907 RID: 215303 RVA: 0x00718480 File Offset: 0x00716680
		public uint NullMask { get; set; }

		// Token: 0x06034908 RID: 215304 RVA: 0x0071848C File Offset: 0x0071668C
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
