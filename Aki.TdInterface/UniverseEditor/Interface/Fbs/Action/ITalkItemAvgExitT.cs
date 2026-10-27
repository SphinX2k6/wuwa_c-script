using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C9 RID: 29385
	public class ITalkItemAvgExitT
	{
		// Token: 0x1700DADA RID: 56026
		// (get) Token: 0x060345AB RID: 214443 RVA: 0x0070E103 File Offset: 0x0070C303
		// (set) Token: 0x060345AC RID: 214444 RVA: 0x0070E10B File Offset: 0x0070C30B
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DADB RID: 56027
		// (get) Token: 0x060345AD RID: 214445 RVA: 0x0070E114 File Offset: 0x0070C314
		// (set) Token: 0x060345AE RID: 214446 RVA: 0x0070E11C File Offset: 0x0070C31C
		public int Id { get; set; }

		// Token: 0x1700DADC RID: 56028
		// (get) Token: 0x060345AF RID: 214447 RVA: 0x0070E125 File Offset: 0x0070C325
		// (set) Token: 0x060345B0 RID: 214448 RVA: 0x0070E12D File Offset: 0x0070C32D
		public int PlotLineId { get; set; }

		// Token: 0x1700DADD RID: 56029
		// (get) Token: 0x060345B1 RID: 214449 RVA: 0x0070E136 File Offset: 0x0070C336
		// (set) Token: 0x060345B2 RID: 214450 RVA: 0x0070E13E File Offset: 0x0070C33E
		public string PlotLineKey { get; set; }

		// Token: 0x1700DADE RID: 56030
		// (get) Token: 0x060345B3 RID: 214451 RVA: 0x0070E147 File Offset: 0x0070C347
		// (set) Token: 0x060345B4 RID: 214452 RVA: 0x0070E14F File Offset: 0x0070C34F
		public string Name { get; set; }

		// Token: 0x1700DADF RID: 56031
		// (get) Token: 0x060345B5 RID: 214453 RVA: 0x0070E158 File Offset: 0x0070C358
		// (set) Token: 0x060345B6 RID: 214454 RVA: 0x0070E160 File Offset: 0x0070C360
		public bool _Folded { get; set; }

		// Token: 0x1700DAE0 RID: 56032
		// (get) Token: 0x060345B7 RID: 214455 RVA: 0x0070E169 File Offset: 0x0070C369
		// (set) Token: 0x060345B8 RID: 214456 RVA: 0x0070E171 File Offset: 0x0070C371
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DAE1 RID: 56033
		// (get) Token: 0x060345B9 RID: 214457 RVA: 0x0070E17A File Offset: 0x0070C37A
		// (set) Token: 0x060345BA RID: 214458 RVA: 0x0070E182 File Offset: 0x0070C382
		public int WhoId { get; set; }

		// Token: 0x1700DAE2 RID: 56034
		// (get) Token: 0x060345BB RID: 214459 RVA: 0x0070E18B File Offset: 0x0070C38B
		// (set) Token: 0x060345BC RID: 214460 RVA: 0x0070E193 File Offset: 0x0070C393
		public int TextId { get; set; }

		// Token: 0x1700DAE3 RID: 56035
		// (get) Token: 0x060345BD RID: 214461 RVA: 0x0070E19C File Offset: 0x0070C39C
		// (set) Token: 0x060345BE RID: 214462 RVA: 0x0070E1A4 File Offset: 0x0070C3A4
		public string TidTalk { get; set; }

		// Token: 0x1700DAE4 RID: 56036
		// (get) Token: 0x060345BF RID: 214463 RVA: 0x0070E1AD File Offset: 0x0070C3AD
		// (set) Token: 0x060345C0 RID: 214464 RVA: 0x0070E1B5 File Offset: 0x0070C3B5
		public float WaitTime { get; set; }

		// Token: 0x1700DAE5 RID: 56037
		// (get) Token: 0x060345C1 RID: 214465 RVA: 0x0070E1BE File Offset: 0x0070C3BE
		// (set) Token: 0x060345C2 RID: 214466 RVA: 0x0070E1C6 File Offset: 0x0070C3C6
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DAE6 RID: 56038
		// (get) Token: 0x060345C3 RID: 214467 RVA: 0x0070E1CF File Offset: 0x0070C3CF
		// (set) Token: 0x060345C4 RID: 214468 RVA: 0x0070E1D7 File Offset: 0x0070C3D7
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DAE7 RID: 56039
		// (get) Token: 0x060345C5 RID: 214469 RVA: 0x0070E1E0 File Offset: 0x0070C3E0
		// (set) Token: 0x060345C6 RID: 214470 RVA: 0x0070E1E8 File Offset: 0x0070C3E8
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DAE8 RID: 56040
		// (get) Token: 0x060345C7 RID: 214471 RVA: 0x0070E1F1 File Offset: 0x0070C3F1
		// (set) Token: 0x060345C8 RID: 214472 RVA: 0x0070E1F9 File Offset: 0x0070C3F9
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DAE9 RID: 56041
		// (get) Token: 0x060345C9 RID: 214473 RVA: 0x0070E202 File Offset: 0x0070C402
		// (set) Token: 0x060345CA RID: 214474 RVA: 0x0070E20A File Offset: 0x0070C40A
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DAEA RID: 56042
		// (get) Token: 0x060345CB RID: 214475 RVA: 0x0070E213 File Offset: 0x0070C413
		// (set) Token: 0x060345CC RID: 214476 RVA: 0x0070E21B File Offset: 0x0070C41B
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DAEB RID: 56043
		// (get) Token: 0x060345CD RID: 214477 RVA: 0x0070E224 File Offset: 0x0070C424
		// (set) Token: 0x060345CE RID: 214478 RVA: 0x0070E22C File Offset: 0x0070C42C
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DAEC RID: 56044
		// (get) Token: 0x060345CF RID: 214479 RVA: 0x0070E235 File Offset: 0x0070C435
		// (set) Token: 0x060345D0 RID: 214480 RVA: 0x0070E23D File Offset: 0x0070C43D
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DAED RID: 56045
		// (get) Token: 0x060345D1 RID: 214481 RVA: 0x0070E246 File Offset: 0x0070C446
		// (set) Token: 0x060345D2 RID: 214482 RVA: 0x0070E24E File Offset: 0x0070C44E
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DAEE RID: 56046
		// (get) Token: 0x060345D3 RID: 214483 RVA: 0x0070E257 File Offset: 0x0070C457
		// (set) Token: 0x060345D4 RID: 214484 RVA: 0x0070E25F File Offset: 0x0070C45F
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DAEF RID: 56047
		// (get) Token: 0x060345D5 RID: 214485 RVA: 0x0070E268 File Offset: 0x0070C468
		// (set) Token: 0x060345D6 RID: 214486 RVA: 0x0070E270 File Offset: 0x0070C470
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DAF0 RID: 56048
		// (get) Token: 0x060345D7 RID: 214487 RVA: 0x0070E279 File Offset: 0x0070C479
		// (set) Token: 0x060345D8 RID: 214488 RVA: 0x0070E281 File Offset: 0x0070C481
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DAF1 RID: 56049
		// (get) Token: 0x060345D9 RID: 214489 RVA: 0x0070E28A File Offset: 0x0070C48A
		// (set) Token: 0x060345DA RID: 214490 RVA: 0x0070E292 File Offset: 0x0070C492
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DAF2 RID: 56050
		// (get) Token: 0x060345DB RID: 214491 RVA: 0x0070E29B File Offset: 0x0070C49B
		// (set) Token: 0x060345DC RID: 214492 RVA: 0x0070E2A3 File Offset: 0x0070C4A3
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DAF3 RID: 56051
		// (get) Token: 0x060345DD RID: 214493 RVA: 0x0070E2AC File Offset: 0x0070C4AC
		// (set) Token: 0x060345DE RID: 214494 RVA: 0x0070E2B4 File Offset: 0x0070C4B4
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DAF4 RID: 56052
		// (get) Token: 0x060345DF RID: 214495 RVA: 0x0070E2BD File Offset: 0x0070C4BD
		// (set) Token: 0x060345E0 RID: 214496 RVA: 0x0070E2C5 File Offset: 0x0070C4C5
		public bool PlayVoice { get; set; }

		// Token: 0x1700DAF5 RID: 56053
		// (get) Token: 0x060345E1 RID: 214497 RVA: 0x0070E2CE File Offset: 0x0070C4CE
		// (set) Token: 0x060345E2 RID: 214498 RVA: 0x0070E2D6 File Offset: 0x0070C4D6
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DAF6 RID: 56054
		// (get) Token: 0x060345E3 RID: 214499 RVA: 0x0070E2DF File Offset: 0x0070C4DF
		// (set) Token: 0x060345E4 RID: 214500 RVA: 0x0070E2E7 File Offset: 0x0070C4E7
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DAF7 RID: 56055
		// (get) Token: 0x060345E5 RID: 214501 RVA: 0x0070E2F0 File Offset: 0x0070C4F0
		// (set) Token: 0x060345E6 RID: 214502 RVA: 0x0070E2F8 File Offset: 0x0070C4F8
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DAF8 RID: 56056
		// (get) Token: 0x060345E7 RID: 214503 RVA: 0x0070E301 File Offset: 0x0070C501
		// (set) Token: 0x060345E8 RID: 214504 RVA: 0x0070E309 File Offset: 0x0070C509
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DAF9 RID: 56057
		// (get) Token: 0x060345E9 RID: 214505 RVA: 0x0070E312 File Offset: 0x0070C512
		// (set) Token: 0x060345EA RID: 214506 RVA: 0x0070E31A File Offset: 0x0070C51A
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DAFA RID: 56058
		// (get) Token: 0x060345EB RID: 214507 RVA: 0x0070E323 File Offset: 0x0070C523
		// (set) Token: 0x060345EC RID: 214508 RVA: 0x0070E32B File Offset: 0x0070C52B
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DAFB RID: 56059
		// (get) Token: 0x060345ED RID: 214509 RVA: 0x0070E334 File Offset: 0x0070C534
		// (set) Token: 0x060345EE RID: 214510 RVA: 0x0070E33C File Offset: 0x0070C53C
		public ITalkItemAvgRoleConfigT AvgRoleConfig { get; set; }

		// Token: 0x1700DAFC RID: 56060
		// (get) Token: 0x060345EF RID: 214511 RVA: 0x0070E345 File Offset: 0x0070C545
		// (set) Token: 0x060345F0 RID: 214512 RVA: 0x0070E34D File Offset: 0x0070C54D
		public uint NullMask { get; set; }

		// Token: 0x060345F1 RID: 214513 RVA: 0x0070E358 File Offset: 0x0070C558
		public ITalkItemAvgExitT()
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
			this.NullMask = 0U;
		}
	}
}
