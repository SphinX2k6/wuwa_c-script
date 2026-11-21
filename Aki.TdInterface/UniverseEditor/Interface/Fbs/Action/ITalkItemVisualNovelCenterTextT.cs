using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AE6 RID: 31462
	public class ITalkItemVisualNovelCenterTextT
	{
		// Token: 0x1700EA36 RID: 59958
		// (get) Token: 0x06038504 RID: 230660 RVA: 0x00796914 File Offset: 0x00794B14
		// (set) Token: 0x06038505 RID: 230661 RVA: 0x0079691C File Offset: 0x00794B1C
		public ETalkItemType Type { get; set; }

		// Token: 0x1700EA37 RID: 59959
		// (get) Token: 0x06038506 RID: 230662 RVA: 0x00796925 File Offset: 0x00794B25
		// (set) Token: 0x06038507 RID: 230663 RVA: 0x0079692D File Offset: 0x00794B2D
		public int Id { get; set; }

		// Token: 0x1700EA38 RID: 59960
		// (get) Token: 0x06038508 RID: 230664 RVA: 0x00796936 File Offset: 0x00794B36
		// (set) Token: 0x06038509 RID: 230665 RVA: 0x0079693E File Offset: 0x00794B3E
		public int PlotLineId { get; set; }

		// Token: 0x1700EA39 RID: 59961
		// (get) Token: 0x0603850A RID: 230666 RVA: 0x00796947 File Offset: 0x00794B47
		// (set) Token: 0x0603850B RID: 230667 RVA: 0x0079694F File Offset: 0x00794B4F
		public string PlotLineKey { get; set; }

		// Token: 0x1700EA3A RID: 59962
		// (get) Token: 0x0603850C RID: 230668 RVA: 0x00796958 File Offset: 0x00794B58
		// (set) Token: 0x0603850D RID: 230669 RVA: 0x00796960 File Offset: 0x00794B60
		public string Name { get; set; }

		// Token: 0x1700EA3B RID: 59963
		// (get) Token: 0x0603850E RID: 230670 RVA: 0x00796969 File Offset: 0x00794B69
		// (set) Token: 0x0603850F RID: 230671 RVA: 0x00796971 File Offset: 0x00794B71
		public bool _Folded { get; set; }

		// Token: 0x1700EA3C RID: 59964
		// (get) Token: 0x06038510 RID: 230672 RVA: 0x0079697A File Offset: 0x00794B7A
		// (set) Token: 0x06038511 RID: 230673 RVA: 0x00796982 File Offset: 0x00794B82
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700EA3D RID: 59965
		// (get) Token: 0x06038512 RID: 230674 RVA: 0x0079698B File Offset: 0x00794B8B
		// (set) Token: 0x06038513 RID: 230675 RVA: 0x00796993 File Offset: 0x00794B93
		public int WhoId { get; set; }

		// Token: 0x1700EA3E RID: 59966
		// (get) Token: 0x06038514 RID: 230676 RVA: 0x0079699C File Offset: 0x00794B9C
		// (set) Token: 0x06038515 RID: 230677 RVA: 0x007969A4 File Offset: 0x00794BA4
		public int TextId { get; set; }

		// Token: 0x1700EA3F RID: 59967
		// (get) Token: 0x06038516 RID: 230678 RVA: 0x007969AD File Offset: 0x00794BAD
		// (set) Token: 0x06038517 RID: 230679 RVA: 0x007969B5 File Offset: 0x00794BB5
		public string TidTalk { get; set; }

		// Token: 0x1700EA40 RID: 59968
		// (get) Token: 0x06038518 RID: 230680 RVA: 0x007969BE File Offset: 0x00794BBE
		// (set) Token: 0x06038519 RID: 230681 RVA: 0x007969C6 File Offset: 0x00794BC6
		public float WaitTime { get; set; }

		// Token: 0x1700EA41 RID: 59969
		// (get) Token: 0x0603851A RID: 230682 RVA: 0x007969CF File Offset: 0x00794BCF
		// (set) Token: 0x0603851B RID: 230683 RVA: 0x007969D7 File Offset: 0x00794BD7
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700EA42 RID: 59970
		// (get) Token: 0x0603851C RID: 230684 RVA: 0x007969E0 File Offset: 0x00794BE0
		// (set) Token: 0x0603851D RID: 230685 RVA: 0x007969E8 File Offset: 0x00794BE8
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700EA43 RID: 59971
		// (get) Token: 0x0603851E RID: 230686 RVA: 0x007969F1 File Offset: 0x00794BF1
		// (set) Token: 0x0603851F RID: 230687 RVA: 0x007969F9 File Offset: 0x00794BF9
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700EA44 RID: 59972
		// (get) Token: 0x06038520 RID: 230688 RVA: 0x00796A02 File Offset: 0x00794C02
		// (set) Token: 0x06038521 RID: 230689 RVA: 0x00796A0A File Offset: 0x00794C0A
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700EA45 RID: 59973
		// (get) Token: 0x06038522 RID: 230690 RVA: 0x00796A13 File Offset: 0x00794C13
		// (set) Token: 0x06038523 RID: 230691 RVA: 0x00796A1B File Offset: 0x00794C1B
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700EA46 RID: 59974
		// (get) Token: 0x06038524 RID: 230692 RVA: 0x00796A24 File Offset: 0x00794C24
		// (set) Token: 0x06038525 RID: 230693 RVA: 0x00796A2C File Offset: 0x00794C2C
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700EA47 RID: 59975
		// (get) Token: 0x06038526 RID: 230694 RVA: 0x00796A35 File Offset: 0x00794C35
		// (set) Token: 0x06038527 RID: 230695 RVA: 0x00796A3D File Offset: 0x00794C3D
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700EA48 RID: 59976
		// (get) Token: 0x06038528 RID: 230696 RVA: 0x00796A46 File Offset: 0x00794C46
		// (set) Token: 0x06038529 RID: 230697 RVA: 0x00796A4E File Offset: 0x00794C4E
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700EA49 RID: 59977
		// (get) Token: 0x0603852A RID: 230698 RVA: 0x00796A57 File Offset: 0x00794C57
		// (set) Token: 0x0603852B RID: 230699 RVA: 0x00796A5F File Offset: 0x00794C5F
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700EA4A RID: 59978
		// (get) Token: 0x0603852C RID: 230700 RVA: 0x00796A68 File Offset: 0x00794C68
		// (set) Token: 0x0603852D RID: 230701 RVA: 0x00796A70 File Offset: 0x00794C70
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700EA4B RID: 59979
		// (get) Token: 0x0603852E RID: 230702 RVA: 0x00796A79 File Offset: 0x00794C79
		// (set) Token: 0x0603852F RID: 230703 RVA: 0x00796A81 File Offset: 0x00794C81
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700EA4C RID: 59980
		// (get) Token: 0x06038530 RID: 230704 RVA: 0x00796A8A File Offset: 0x00794C8A
		// (set) Token: 0x06038531 RID: 230705 RVA: 0x00796A92 File Offset: 0x00794C92
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700EA4D RID: 59981
		// (get) Token: 0x06038532 RID: 230706 RVA: 0x00796A9B File Offset: 0x00794C9B
		// (set) Token: 0x06038533 RID: 230707 RVA: 0x00796AA3 File Offset: 0x00794CA3
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700EA4E RID: 59982
		// (get) Token: 0x06038534 RID: 230708 RVA: 0x00796AAC File Offset: 0x00794CAC
		// (set) Token: 0x06038535 RID: 230709 RVA: 0x00796AB4 File Offset: 0x00794CB4
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700EA4F RID: 59983
		// (get) Token: 0x06038536 RID: 230710 RVA: 0x00796ABD File Offset: 0x00794CBD
		// (set) Token: 0x06038537 RID: 230711 RVA: 0x00796AC5 File Offset: 0x00794CC5
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700EA50 RID: 59984
		// (get) Token: 0x06038538 RID: 230712 RVA: 0x00796ACE File Offset: 0x00794CCE
		// (set) Token: 0x06038539 RID: 230713 RVA: 0x00796AD6 File Offset: 0x00794CD6
		public bool PlayVoice { get; set; }

		// Token: 0x1700EA51 RID: 59985
		// (get) Token: 0x0603853A RID: 230714 RVA: 0x00796ADF File Offset: 0x00794CDF
		// (set) Token: 0x0603853B RID: 230715 RVA: 0x00796AE7 File Offset: 0x00794CE7
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700EA52 RID: 59986
		// (get) Token: 0x0603853C RID: 230716 RVA: 0x00796AF0 File Offset: 0x00794CF0
		// (set) Token: 0x0603853D RID: 230717 RVA: 0x00796AF8 File Offset: 0x00794CF8
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700EA53 RID: 59987
		// (get) Token: 0x0603853E RID: 230718 RVA: 0x00796B01 File Offset: 0x00794D01
		// (set) Token: 0x0603853F RID: 230719 RVA: 0x00796B09 File Offset: 0x00794D09
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700EA54 RID: 59988
		// (get) Token: 0x06038540 RID: 230720 RVA: 0x00796B12 File Offset: 0x00794D12
		// (set) Token: 0x06038541 RID: 230721 RVA: 0x00796B1A File Offset: 0x00794D1A
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700EA55 RID: 59989
		// (get) Token: 0x06038542 RID: 230722 RVA: 0x00796B23 File Offset: 0x00794D23
		// (set) Token: 0x06038543 RID: 230723 RVA: 0x00796B2B File Offset: 0x00794D2B
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700EA56 RID: 59990
		// (get) Token: 0x06038544 RID: 230724 RVA: 0x00796B34 File Offset: 0x00794D34
		// (set) Token: 0x06038545 RID: 230725 RVA: 0x00796B3C File Offset: 0x00794D3C
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700EA57 RID: 59991
		// (get) Token: 0x06038546 RID: 230726 RVA: 0x00796B45 File Offset: 0x00794D45
		// (set) Token: 0x06038547 RID: 230727 RVA: 0x00796B4D File Offset: 0x00794D4D
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700EA58 RID: 59992
		// (get) Token: 0x06038548 RID: 230728 RVA: 0x00796B56 File Offset: 0x00794D56
		// (set) Token: 0x06038549 RID: 230729 RVA: 0x00796B5E File Offset: 0x00794D5E
		public TVisualNovelOptionGroupConfigUnion OptionGroup { get; set; }

		// Token: 0x1700EA59 RID: 59993
		// (get) Token: 0x0603854A RID: 230730 RVA: 0x00796B67 File Offset: 0x00794D67
		// (set) Token: 0x0603854B RID: 230731 RVA: 0x00796B6F File Offset: 0x00794D6F
		public int PlotKeyId { get; set; }

		// Token: 0x1700EA5A RID: 59994
		// (get) Token: 0x0603854C RID: 230732 RVA: 0x00796B78 File Offset: 0x00794D78
		// (set) Token: 0x0603854D RID: 230733 RVA: 0x00796B80 File Offset: 0x00794D80
		public uint NullMask { get; set; }

		// Token: 0x0603854E RID: 230734 RVA: 0x00796B8C File Offset: 0x00794D8C
		public ITalkItemVisualNovelCenterTextT()
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
			this.OptionInteractionType = EVisualNovelOptionInteractionType.HideAndAutoSelect;
			this.OptionGroup = null;
			this.PlotKeyId = 0;
			this.NullMask = 0U;
		}
	}
}
