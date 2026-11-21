using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AD1 RID: 31441
	public class ITalkItemQteT
	{
		// Token: 0x1700E994 RID: 59796
		// (get) Token: 0x06038298 RID: 230040 RVA: 0x0078F1C1 File Offset: 0x0078D3C1
		// (set) Token: 0x06038299 RID: 230041 RVA: 0x0078F1C9 File Offset: 0x0078D3C9
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E995 RID: 59797
		// (get) Token: 0x0603829A RID: 230042 RVA: 0x0078F1D2 File Offset: 0x0078D3D2
		// (set) Token: 0x0603829B RID: 230043 RVA: 0x0078F1DA File Offset: 0x0078D3DA
		public int Id { get; set; }

		// Token: 0x1700E996 RID: 59798
		// (get) Token: 0x0603829C RID: 230044 RVA: 0x0078F1E3 File Offset: 0x0078D3E3
		// (set) Token: 0x0603829D RID: 230045 RVA: 0x0078F1EB File Offset: 0x0078D3EB
		public int PlotLineId { get; set; }

		// Token: 0x1700E997 RID: 59799
		// (get) Token: 0x0603829E RID: 230046 RVA: 0x0078F1F4 File Offset: 0x0078D3F4
		// (set) Token: 0x0603829F RID: 230047 RVA: 0x0078F1FC File Offset: 0x0078D3FC
		public string PlotLineKey { get; set; }

		// Token: 0x1700E998 RID: 59800
		// (get) Token: 0x060382A0 RID: 230048 RVA: 0x0078F205 File Offset: 0x0078D405
		// (set) Token: 0x060382A1 RID: 230049 RVA: 0x0078F20D File Offset: 0x0078D40D
		public string Name { get; set; }

		// Token: 0x1700E999 RID: 59801
		// (get) Token: 0x060382A2 RID: 230050 RVA: 0x0078F216 File Offset: 0x0078D416
		// (set) Token: 0x060382A3 RID: 230051 RVA: 0x0078F21E File Offset: 0x0078D41E
		public bool _Folded { get; set; }

		// Token: 0x1700E99A RID: 59802
		// (get) Token: 0x060382A4 RID: 230052 RVA: 0x0078F227 File Offset: 0x0078D427
		// (set) Token: 0x060382A5 RID: 230053 RVA: 0x0078F22F File Offset: 0x0078D42F
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E99B RID: 59803
		// (get) Token: 0x060382A6 RID: 230054 RVA: 0x0078F238 File Offset: 0x0078D438
		// (set) Token: 0x060382A7 RID: 230055 RVA: 0x0078F240 File Offset: 0x0078D440
		public int WhoId { get; set; }

		// Token: 0x1700E99C RID: 59804
		// (get) Token: 0x060382A8 RID: 230056 RVA: 0x0078F249 File Offset: 0x0078D449
		// (set) Token: 0x060382A9 RID: 230057 RVA: 0x0078F251 File Offset: 0x0078D451
		public int TextId { get; set; }

		// Token: 0x1700E99D RID: 59805
		// (get) Token: 0x060382AA RID: 230058 RVA: 0x0078F25A File Offset: 0x0078D45A
		// (set) Token: 0x060382AB RID: 230059 RVA: 0x0078F262 File Offset: 0x0078D462
		public string TidTalk { get; set; }

		// Token: 0x1700E99E RID: 59806
		// (get) Token: 0x060382AC RID: 230060 RVA: 0x0078F26B File Offset: 0x0078D46B
		// (set) Token: 0x060382AD RID: 230061 RVA: 0x0078F273 File Offset: 0x0078D473
		public float WaitTime { get; set; }

		// Token: 0x1700E99F RID: 59807
		// (get) Token: 0x060382AE RID: 230062 RVA: 0x0078F27C File Offset: 0x0078D47C
		// (set) Token: 0x060382AF RID: 230063 RVA: 0x0078F284 File Offset: 0x0078D484
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E9A0 RID: 59808
		// (get) Token: 0x060382B0 RID: 230064 RVA: 0x0078F28D File Offset: 0x0078D48D
		// (set) Token: 0x060382B1 RID: 230065 RVA: 0x0078F295 File Offset: 0x0078D495
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E9A1 RID: 59809
		// (get) Token: 0x060382B2 RID: 230066 RVA: 0x0078F29E File Offset: 0x0078D49E
		// (set) Token: 0x060382B3 RID: 230067 RVA: 0x0078F2A6 File Offset: 0x0078D4A6
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E9A2 RID: 59810
		// (get) Token: 0x060382B4 RID: 230068 RVA: 0x0078F2AF File Offset: 0x0078D4AF
		// (set) Token: 0x060382B5 RID: 230069 RVA: 0x0078F2B7 File Offset: 0x0078D4B7
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E9A3 RID: 59811
		// (get) Token: 0x060382B6 RID: 230070 RVA: 0x0078F2C0 File Offset: 0x0078D4C0
		// (set) Token: 0x060382B7 RID: 230071 RVA: 0x0078F2C8 File Offset: 0x0078D4C8
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E9A4 RID: 59812
		// (get) Token: 0x060382B8 RID: 230072 RVA: 0x0078F2D1 File Offset: 0x0078D4D1
		// (set) Token: 0x060382B9 RID: 230073 RVA: 0x0078F2D9 File Offset: 0x0078D4D9
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E9A5 RID: 59813
		// (get) Token: 0x060382BA RID: 230074 RVA: 0x0078F2E2 File Offset: 0x0078D4E2
		// (set) Token: 0x060382BB RID: 230075 RVA: 0x0078F2EA File Offset: 0x0078D4EA
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E9A6 RID: 59814
		// (get) Token: 0x060382BC RID: 230076 RVA: 0x0078F2F3 File Offset: 0x0078D4F3
		// (set) Token: 0x060382BD RID: 230077 RVA: 0x0078F2FB File Offset: 0x0078D4FB
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E9A7 RID: 59815
		// (get) Token: 0x060382BE RID: 230078 RVA: 0x0078F304 File Offset: 0x0078D504
		// (set) Token: 0x060382BF RID: 230079 RVA: 0x0078F30C File Offset: 0x0078D50C
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E9A8 RID: 59816
		// (get) Token: 0x060382C0 RID: 230080 RVA: 0x0078F315 File Offset: 0x0078D515
		// (set) Token: 0x060382C1 RID: 230081 RVA: 0x0078F31D File Offset: 0x0078D51D
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E9A9 RID: 59817
		// (get) Token: 0x060382C2 RID: 230082 RVA: 0x0078F326 File Offset: 0x0078D526
		// (set) Token: 0x060382C3 RID: 230083 RVA: 0x0078F32E File Offset: 0x0078D52E
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E9AA RID: 59818
		// (get) Token: 0x060382C4 RID: 230084 RVA: 0x0078F337 File Offset: 0x0078D537
		// (set) Token: 0x060382C5 RID: 230085 RVA: 0x0078F33F File Offset: 0x0078D53F
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E9AB RID: 59819
		// (get) Token: 0x060382C6 RID: 230086 RVA: 0x0078F348 File Offset: 0x0078D548
		// (set) Token: 0x060382C7 RID: 230087 RVA: 0x0078F350 File Offset: 0x0078D550
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E9AC RID: 59820
		// (get) Token: 0x060382C8 RID: 230088 RVA: 0x0078F359 File Offset: 0x0078D559
		// (set) Token: 0x060382C9 RID: 230089 RVA: 0x0078F361 File Offset: 0x0078D561
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E9AD RID: 59821
		// (get) Token: 0x060382CA RID: 230090 RVA: 0x0078F36A File Offset: 0x0078D56A
		// (set) Token: 0x060382CB RID: 230091 RVA: 0x0078F372 File Offset: 0x0078D572
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E9AE RID: 59822
		// (get) Token: 0x060382CC RID: 230092 RVA: 0x0078F37B File Offset: 0x0078D57B
		// (set) Token: 0x060382CD RID: 230093 RVA: 0x0078F383 File Offset: 0x0078D583
		public bool PlayVoice { get; set; }

		// Token: 0x1700E9AF RID: 59823
		// (get) Token: 0x060382CE RID: 230094 RVA: 0x0078F38C File Offset: 0x0078D58C
		// (set) Token: 0x060382CF RID: 230095 RVA: 0x0078F394 File Offset: 0x0078D594
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E9B0 RID: 59824
		// (get) Token: 0x060382D0 RID: 230096 RVA: 0x0078F39D File Offset: 0x0078D59D
		// (set) Token: 0x060382D1 RID: 230097 RVA: 0x0078F3A5 File Offset: 0x0078D5A5
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E9B1 RID: 59825
		// (get) Token: 0x060382D2 RID: 230098 RVA: 0x0078F3AE File Offset: 0x0078D5AE
		// (set) Token: 0x060382D3 RID: 230099 RVA: 0x0078F3B6 File Offset: 0x0078D5B6
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E9B2 RID: 59826
		// (get) Token: 0x060382D4 RID: 230100 RVA: 0x0078F3BF File Offset: 0x0078D5BF
		// (set) Token: 0x060382D5 RID: 230101 RVA: 0x0078F3C7 File Offset: 0x0078D5C7
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E9B3 RID: 59827
		// (get) Token: 0x060382D6 RID: 230102 RVA: 0x0078F3D0 File Offset: 0x0078D5D0
		// (set) Token: 0x060382D7 RID: 230103 RVA: 0x0078F3D8 File Offset: 0x0078D5D8
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E9B4 RID: 59828
		// (get) Token: 0x060382D8 RID: 230104 RVA: 0x0078F3E1 File Offset: 0x0078D5E1
		// (set) Token: 0x060382D9 RID: 230105 RVA: 0x0078F3E9 File Offset: 0x0078D5E9
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E9B5 RID: 59829
		// (get) Token: 0x060382DA RID: 230106 RVA: 0x0078F3F2 File Offset: 0x0078D5F2
		// (set) Token: 0x060382DB RID: 230107 RVA: 0x0078F3FA File Offset: 0x0078D5FA
		public int QteId { get; set; }

		// Token: 0x1700E9B6 RID: 59830
		// (get) Token: 0x060382DC RID: 230108 RVA: 0x0078F403 File Offset: 0x0078D603
		// (set) Token: 0x060382DD RID: 230109 RVA: 0x0078F40B File Offset: 0x0078D60B
		public uint NullMask { get; set; }

		// Token: 0x060382DE RID: 230110 RVA: 0x0078F414 File Offset: 0x0078D614
		public ITalkItemQteT()
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
			this.QteId = 0;
			this.NullMask = 0U;
		}
	}
}
