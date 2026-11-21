using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A9B RID: 31387
	public class ITalkItemAvgEnterT
	{
		// Token: 0x1700E68A RID: 59018
		// (get) Token: 0x060377AE RID: 227246 RVA: 0x0076BF35 File Offset: 0x0076A135
		// (set) Token: 0x060377AF RID: 227247 RVA: 0x0076BF3D File Offset: 0x0076A13D
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E68B RID: 59019
		// (get) Token: 0x060377B0 RID: 227248 RVA: 0x0076BF46 File Offset: 0x0076A146
		// (set) Token: 0x060377B1 RID: 227249 RVA: 0x0076BF4E File Offset: 0x0076A14E
		public int Id { get; set; }

		// Token: 0x1700E68C RID: 59020
		// (get) Token: 0x060377B2 RID: 227250 RVA: 0x0076BF57 File Offset: 0x0076A157
		// (set) Token: 0x060377B3 RID: 227251 RVA: 0x0076BF5F File Offset: 0x0076A15F
		public int PlotLineId { get; set; }

		// Token: 0x1700E68D RID: 59021
		// (get) Token: 0x060377B4 RID: 227252 RVA: 0x0076BF68 File Offset: 0x0076A168
		// (set) Token: 0x060377B5 RID: 227253 RVA: 0x0076BF70 File Offset: 0x0076A170
		public string PlotLineKey { get; set; }

		// Token: 0x1700E68E RID: 59022
		// (get) Token: 0x060377B6 RID: 227254 RVA: 0x0076BF79 File Offset: 0x0076A179
		// (set) Token: 0x060377B7 RID: 227255 RVA: 0x0076BF81 File Offset: 0x0076A181
		public string Name { get; set; }

		// Token: 0x1700E68F RID: 59023
		// (get) Token: 0x060377B8 RID: 227256 RVA: 0x0076BF8A File Offset: 0x0076A18A
		// (set) Token: 0x060377B9 RID: 227257 RVA: 0x0076BF92 File Offset: 0x0076A192
		public bool _Folded { get; set; }

		// Token: 0x1700E690 RID: 59024
		// (get) Token: 0x060377BA RID: 227258 RVA: 0x0076BF9B File Offset: 0x0076A19B
		// (set) Token: 0x060377BB RID: 227259 RVA: 0x0076BFA3 File Offset: 0x0076A1A3
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E691 RID: 59025
		// (get) Token: 0x060377BC RID: 227260 RVA: 0x0076BFAC File Offset: 0x0076A1AC
		// (set) Token: 0x060377BD RID: 227261 RVA: 0x0076BFB4 File Offset: 0x0076A1B4
		public int WhoId { get; set; }

		// Token: 0x1700E692 RID: 59026
		// (get) Token: 0x060377BE RID: 227262 RVA: 0x0076BFBD File Offset: 0x0076A1BD
		// (set) Token: 0x060377BF RID: 227263 RVA: 0x0076BFC5 File Offset: 0x0076A1C5
		public int TextId { get; set; }

		// Token: 0x1700E693 RID: 59027
		// (get) Token: 0x060377C0 RID: 227264 RVA: 0x0076BFCE File Offset: 0x0076A1CE
		// (set) Token: 0x060377C1 RID: 227265 RVA: 0x0076BFD6 File Offset: 0x0076A1D6
		public string TidTalk { get; set; }

		// Token: 0x1700E694 RID: 59028
		// (get) Token: 0x060377C2 RID: 227266 RVA: 0x0076BFDF File Offset: 0x0076A1DF
		// (set) Token: 0x060377C3 RID: 227267 RVA: 0x0076BFE7 File Offset: 0x0076A1E7
		public float WaitTime { get; set; }

		// Token: 0x1700E695 RID: 59029
		// (get) Token: 0x060377C4 RID: 227268 RVA: 0x0076BFF0 File Offset: 0x0076A1F0
		// (set) Token: 0x060377C5 RID: 227269 RVA: 0x0076BFF8 File Offset: 0x0076A1F8
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E696 RID: 59030
		// (get) Token: 0x060377C6 RID: 227270 RVA: 0x0076C001 File Offset: 0x0076A201
		// (set) Token: 0x060377C7 RID: 227271 RVA: 0x0076C009 File Offset: 0x0076A209
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E697 RID: 59031
		// (get) Token: 0x060377C8 RID: 227272 RVA: 0x0076C012 File Offset: 0x0076A212
		// (set) Token: 0x060377C9 RID: 227273 RVA: 0x0076C01A File Offset: 0x0076A21A
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E698 RID: 59032
		// (get) Token: 0x060377CA RID: 227274 RVA: 0x0076C023 File Offset: 0x0076A223
		// (set) Token: 0x060377CB RID: 227275 RVA: 0x0076C02B File Offset: 0x0076A22B
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E699 RID: 59033
		// (get) Token: 0x060377CC RID: 227276 RVA: 0x0076C034 File Offset: 0x0076A234
		// (set) Token: 0x060377CD RID: 227277 RVA: 0x0076C03C File Offset: 0x0076A23C
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E69A RID: 59034
		// (get) Token: 0x060377CE RID: 227278 RVA: 0x0076C045 File Offset: 0x0076A245
		// (set) Token: 0x060377CF RID: 227279 RVA: 0x0076C04D File Offset: 0x0076A24D
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E69B RID: 59035
		// (get) Token: 0x060377D0 RID: 227280 RVA: 0x0076C056 File Offset: 0x0076A256
		// (set) Token: 0x060377D1 RID: 227281 RVA: 0x0076C05E File Offset: 0x0076A25E
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E69C RID: 59036
		// (get) Token: 0x060377D2 RID: 227282 RVA: 0x0076C067 File Offset: 0x0076A267
		// (set) Token: 0x060377D3 RID: 227283 RVA: 0x0076C06F File Offset: 0x0076A26F
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E69D RID: 59037
		// (get) Token: 0x060377D4 RID: 227284 RVA: 0x0076C078 File Offset: 0x0076A278
		// (set) Token: 0x060377D5 RID: 227285 RVA: 0x0076C080 File Offset: 0x0076A280
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E69E RID: 59038
		// (get) Token: 0x060377D6 RID: 227286 RVA: 0x0076C089 File Offset: 0x0076A289
		// (set) Token: 0x060377D7 RID: 227287 RVA: 0x0076C091 File Offset: 0x0076A291
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E69F RID: 59039
		// (get) Token: 0x060377D8 RID: 227288 RVA: 0x0076C09A File Offset: 0x0076A29A
		// (set) Token: 0x060377D9 RID: 227289 RVA: 0x0076C0A2 File Offset: 0x0076A2A2
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E6A0 RID: 59040
		// (get) Token: 0x060377DA RID: 227290 RVA: 0x0076C0AB File Offset: 0x0076A2AB
		// (set) Token: 0x060377DB RID: 227291 RVA: 0x0076C0B3 File Offset: 0x0076A2B3
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E6A1 RID: 59041
		// (get) Token: 0x060377DC RID: 227292 RVA: 0x0076C0BC File Offset: 0x0076A2BC
		// (set) Token: 0x060377DD RID: 227293 RVA: 0x0076C0C4 File Offset: 0x0076A2C4
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E6A2 RID: 59042
		// (get) Token: 0x060377DE RID: 227294 RVA: 0x0076C0CD File Offset: 0x0076A2CD
		// (set) Token: 0x060377DF RID: 227295 RVA: 0x0076C0D5 File Offset: 0x0076A2D5
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E6A3 RID: 59043
		// (get) Token: 0x060377E0 RID: 227296 RVA: 0x0076C0DE File Offset: 0x0076A2DE
		// (set) Token: 0x060377E1 RID: 227297 RVA: 0x0076C0E6 File Offset: 0x0076A2E6
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E6A4 RID: 59044
		// (get) Token: 0x060377E2 RID: 227298 RVA: 0x0076C0EF File Offset: 0x0076A2EF
		// (set) Token: 0x060377E3 RID: 227299 RVA: 0x0076C0F7 File Offset: 0x0076A2F7
		public bool PlayVoice { get; set; }

		// Token: 0x1700E6A5 RID: 59045
		// (get) Token: 0x060377E4 RID: 227300 RVA: 0x0076C100 File Offset: 0x0076A300
		// (set) Token: 0x060377E5 RID: 227301 RVA: 0x0076C108 File Offset: 0x0076A308
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E6A6 RID: 59046
		// (get) Token: 0x060377E6 RID: 227302 RVA: 0x0076C111 File Offset: 0x0076A311
		// (set) Token: 0x060377E7 RID: 227303 RVA: 0x0076C119 File Offset: 0x0076A319
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E6A7 RID: 59047
		// (get) Token: 0x060377E8 RID: 227304 RVA: 0x0076C122 File Offset: 0x0076A322
		// (set) Token: 0x060377E9 RID: 227305 RVA: 0x0076C12A File Offset: 0x0076A32A
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E6A8 RID: 59048
		// (get) Token: 0x060377EA RID: 227306 RVA: 0x0076C133 File Offset: 0x0076A333
		// (set) Token: 0x060377EB RID: 227307 RVA: 0x0076C13B File Offset: 0x0076A33B
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E6A9 RID: 59049
		// (get) Token: 0x060377EC RID: 227308 RVA: 0x0076C144 File Offset: 0x0076A344
		// (set) Token: 0x060377ED RID: 227309 RVA: 0x0076C14C File Offset: 0x0076A34C
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E6AA RID: 59050
		// (get) Token: 0x060377EE RID: 227310 RVA: 0x0076C155 File Offset: 0x0076A355
		// (set) Token: 0x060377EF RID: 227311 RVA: 0x0076C15D File Offset: 0x0076A35D
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E6AB RID: 59051
		// (get) Token: 0x060377F0 RID: 227312 RVA: 0x0076C166 File Offset: 0x0076A366
		// (set) Token: 0x060377F1 RID: 227313 RVA: 0x0076C16E File Offset: 0x0076A36E
		public ITalkItemAvgRoleConfigT AvgRoleConfig { get; set; }

		// Token: 0x1700E6AC RID: 59052
		// (get) Token: 0x060377F2 RID: 227314 RVA: 0x0076C177 File Offset: 0x0076A377
		// (set) Token: 0x060377F3 RID: 227315 RVA: 0x0076C17F File Offset: 0x0076A37F
		public EAvgRolePosition PositionConfig { get; set; }

		// Token: 0x1700E6AD RID: 59053
		// (get) Token: 0x060377F4 RID: 227316 RVA: 0x0076C188 File Offset: 0x0076A388
		// (set) Token: 0x060377F5 RID: 227317 RVA: 0x0076C190 File Offset: 0x0076A390
		public uint NullMask { get; set; }

		// Token: 0x060377F6 RID: 227318 RVA: 0x0076C19C File Offset: 0x0076A39C
		public ITalkItemAvgEnterT()
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
