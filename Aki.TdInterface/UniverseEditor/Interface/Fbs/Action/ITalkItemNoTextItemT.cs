using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E1 RID: 29409
	public class ITalkItemNoTextItemT
	{
		// Token: 0x1700DCA2 RID: 56482
		// (get) Token: 0x06034BFB RID: 216059 RVA: 0x00722B9C File Offset: 0x00720D9C
		// (set) Token: 0x06034BFC RID: 216060 RVA: 0x00722BA4 File Offset: 0x00720DA4
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DCA3 RID: 56483
		// (get) Token: 0x06034BFD RID: 216061 RVA: 0x00722BAD File Offset: 0x00720DAD
		// (set) Token: 0x06034BFE RID: 216062 RVA: 0x00722BB5 File Offset: 0x00720DB5
		public int Id { get; set; }

		// Token: 0x1700DCA4 RID: 56484
		// (get) Token: 0x06034BFF RID: 216063 RVA: 0x00722BBE File Offset: 0x00720DBE
		// (set) Token: 0x06034C00 RID: 216064 RVA: 0x00722BC6 File Offset: 0x00720DC6
		public int PlotLineId { get; set; }

		// Token: 0x1700DCA5 RID: 56485
		// (get) Token: 0x06034C01 RID: 216065 RVA: 0x00722BCF File Offset: 0x00720DCF
		// (set) Token: 0x06034C02 RID: 216066 RVA: 0x00722BD7 File Offset: 0x00720DD7
		public string PlotLineKey { get; set; }

		// Token: 0x1700DCA6 RID: 56486
		// (get) Token: 0x06034C03 RID: 216067 RVA: 0x00722BE0 File Offset: 0x00720DE0
		// (set) Token: 0x06034C04 RID: 216068 RVA: 0x00722BE8 File Offset: 0x00720DE8
		public string Name { get; set; }

		// Token: 0x1700DCA7 RID: 56487
		// (get) Token: 0x06034C05 RID: 216069 RVA: 0x00722BF1 File Offset: 0x00720DF1
		// (set) Token: 0x06034C06 RID: 216070 RVA: 0x00722BF9 File Offset: 0x00720DF9
		public bool _Folded { get; set; }

		// Token: 0x1700DCA8 RID: 56488
		// (get) Token: 0x06034C07 RID: 216071 RVA: 0x00722C02 File Offset: 0x00720E02
		// (set) Token: 0x06034C08 RID: 216072 RVA: 0x00722C0A File Offset: 0x00720E0A
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DCA9 RID: 56489
		// (get) Token: 0x06034C09 RID: 216073 RVA: 0x00722C13 File Offset: 0x00720E13
		// (set) Token: 0x06034C0A RID: 216074 RVA: 0x00722C1B File Offset: 0x00720E1B
		public int WhoId { get; set; }

		// Token: 0x1700DCAA RID: 56490
		// (get) Token: 0x06034C0B RID: 216075 RVA: 0x00722C24 File Offset: 0x00720E24
		// (set) Token: 0x06034C0C RID: 216076 RVA: 0x00722C2C File Offset: 0x00720E2C
		public int TextId { get; set; }

		// Token: 0x1700DCAB RID: 56491
		// (get) Token: 0x06034C0D RID: 216077 RVA: 0x00722C35 File Offset: 0x00720E35
		// (set) Token: 0x06034C0E RID: 216078 RVA: 0x00722C3D File Offset: 0x00720E3D
		public string TidTalk { get; set; }

		// Token: 0x1700DCAC RID: 56492
		// (get) Token: 0x06034C0F RID: 216079 RVA: 0x00722C46 File Offset: 0x00720E46
		// (set) Token: 0x06034C10 RID: 216080 RVA: 0x00722C4E File Offset: 0x00720E4E
		public float WaitTime { get; set; }

		// Token: 0x1700DCAD RID: 56493
		// (get) Token: 0x06034C11 RID: 216081 RVA: 0x00722C57 File Offset: 0x00720E57
		// (set) Token: 0x06034C12 RID: 216082 RVA: 0x00722C5F File Offset: 0x00720E5F
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DCAE RID: 56494
		// (get) Token: 0x06034C13 RID: 216083 RVA: 0x00722C68 File Offset: 0x00720E68
		// (set) Token: 0x06034C14 RID: 216084 RVA: 0x00722C70 File Offset: 0x00720E70
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DCAF RID: 56495
		// (get) Token: 0x06034C15 RID: 216085 RVA: 0x00722C79 File Offset: 0x00720E79
		// (set) Token: 0x06034C16 RID: 216086 RVA: 0x00722C81 File Offset: 0x00720E81
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DCB0 RID: 56496
		// (get) Token: 0x06034C17 RID: 216087 RVA: 0x00722C8A File Offset: 0x00720E8A
		// (set) Token: 0x06034C18 RID: 216088 RVA: 0x00722C92 File Offset: 0x00720E92
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DCB1 RID: 56497
		// (get) Token: 0x06034C19 RID: 216089 RVA: 0x00722C9B File Offset: 0x00720E9B
		// (set) Token: 0x06034C1A RID: 216090 RVA: 0x00722CA3 File Offset: 0x00720EA3
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DCB2 RID: 56498
		// (get) Token: 0x06034C1B RID: 216091 RVA: 0x00722CAC File Offset: 0x00720EAC
		// (set) Token: 0x06034C1C RID: 216092 RVA: 0x00722CB4 File Offset: 0x00720EB4
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DCB3 RID: 56499
		// (get) Token: 0x06034C1D RID: 216093 RVA: 0x00722CBD File Offset: 0x00720EBD
		// (set) Token: 0x06034C1E RID: 216094 RVA: 0x00722CC5 File Offset: 0x00720EC5
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DCB4 RID: 56500
		// (get) Token: 0x06034C1F RID: 216095 RVA: 0x00722CCE File Offset: 0x00720ECE
		// (set) Token: 0x06034C20 RID: 216096 RVA: 0x00722CD6 File Offset: 0x00720ED6
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DCB5 RID: 56501
		// (get) Token: 0x06034C21 RID: 216097 RVA: 0x00722CDF File Offset: 0x00720EDF
		// (set) Token: 0x06034C22 RID: 216098 RVA: 0x00722CE7 File Offset: 0x00720EE7
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DCB6 RID: 56502
		// (get) Token: 0x06034C23 RID: 216099 RVA: 0x00722CF0 File Offset: 0x00720EF0
		// (set) Token: 0x06034C24 RID: 216100 RVA: 0x00722CF8 File Offset: 0x00720EF8
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DCB7 RID: 56503
		// (get) Token: 0x06034C25 RID: 216101 RVA: 0x00722D01 File Offset: 0x00720F01
		// (set) Token: 0x06034C26 RID: 216102 RVA: 0x00722D09 File Offset: 0x00720F09
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DCB8 RID: 56504
		// (get) Token: 0x06034C27 RID: 216103 RVA: 0x00722D12 File Offset: 0x00720F12
		// (set) Token: 0x06034C28 RID: 216104 RVA: 0x00722D1A File Offset: 0x00720F1A
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DCB9 RID: 56505
		// (get) Token: 0x06034C29 RID: 216105 RVA: 0x00722D23 File Offset: 0x00720F23
		// (set) Token: 0x06034C2A RID: 216106 RVA: 0x00722D2B File Offset: 0x00720F2B
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DCBA RID: 56506
		// (get) Token: 0x06034C2B RID: 216107 RVA: 0x00722D34 File Offset: 0x00720F34
		// (set) Token: 0x06034C2C RID: 216108 RVA: 0x00722D3C File Offset: 0x00720F3C
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DCBB RID: 56507
		// (get) Token: 0x06034C2D RID: 216109 RVA: 0x00722D45 File Offset: 0x00720F45
		// (set) Token: 0x06034C2E RID: 216110 RVA: 0x00722D4D File Offset: 0x00720F4D
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DCBC RID: 56508
		// (get) Token: 0x06034C2F RID: 216111 RVA: 0x00722D56 File Offset: 0x00720F56
		// (set) Token: 0x06034C30 RID: 216112 RVA: 0x00722D5E File Offset: 0x00720F5E
		public bool PlayVoice { get; set; }

		// Token: 0x1700DCBD RID: 56509
		// (get) Token: 0x06034C31 RID: 216113 RVA: 0x00722D67 File Offset: 0x00720F67
		// (set) Token: 0x06034C32 RID: 216114 RVA: 0x00722D6F File Offset: 0x00720F6F
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DCBE RID: 56510
		// (get) Token: 0x06034C33 RID: 216115 RVA: 0x00722D78 File Offset: 0x00720F78
		// (set) Token: 0x06034C34 RID: 216116 RVA: 0x00722D80 File Offset: 0x00720F80
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DCBF RID: 56511
		// (get) Token: 0x06034C35 RID: 216117 RVA: 0x00722D89 File Offset: 0x00720F89
		// (set) Token: 0x06034C36 RID: 216118 RVA: 0x00722D91 File Offset: 0x00720F91
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DCC0 RID: 56512
		// (get) Token: 0x06034C37 RID: 216119 RVA: 0x00722D9A File Offset: 0x00720F9A
		// (set) Token: 0x06034C38 RID: 216120 RVA: 0x00722DA2 File Offset: 0x00720FA2
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DCC1 RID: 56513
		// (get) Token: 0x06034C39 RID: 216121 RVA: 0x00722DAB File Offset: 0x00720FAB
		// (set) Token: 0x06034C3A RID: 216122 RVA: 0x00722DB3 File Offset: 0x00720FB3
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DCC2 RID: 56514
		// (get) Token: 0x06034C3B RID: 216123 RVA: 0x00722DBC File Offset: 0x00720FBC
		// (set) Token: 0x06034C3C RID: 216124 RVA: 0x00722DC4 File Offset: 0x00720FC4
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DCC3 RID: 56515
		// (get) Token: 0x06034C3D RID: 216125 RVA: 0x00722DCD File Offset: 0x00720FCD
		// (set) Token: 0x06034C3E RID: 216126 RVA: 0x00722DD5 File Offset: 0x00720FD5
		public TShowTalkCameraMotionUnion CameraMotion { get; set; }

		// Token: 0x1700DCC4 RID: 56516
		// (get) Token: 0x06034C3F RID: 216127 RVA: 0x00722DDE File Offset: 0x00720FDE
		// (set) Token: 0x06034C40 RID: 216128 RVA: 0x00722DE6 File Offset: 0x00720FE6
		public uint NullMask { get; set; }

		// Token: 0x06034C41 RID: 216129 RVA: 0x00722DF0 File Offset: 0x00720FF0
		public ITalkItemNoTextItemT()
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
			this.NullMask = 0U;
		}
	}
}
