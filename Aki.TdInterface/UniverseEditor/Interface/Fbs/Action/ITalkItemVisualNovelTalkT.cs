using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731A RID: 29466
	public class ITalkItemVisualNovelTalkT
	{
		// Token: 0x1700DF9A RID: 57242
		// (get) Token: 0x060356ED RID: 218861 RVA: 0x00747A40 File Offset: 0x00745C40
		// (set) Token: 0x060356EE RID: 218862 RVA: 0x00747A48 File Offset: 0x00745C48
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DF9B RID: 57243
		// (get) Token: 0x060356EF RID: 218863 RVA: 0x00747A51 File Offset: 0x00745C51
		// (set) Token: 0x060356F0 RID: 218864 RVA: 0x00747A59 File Offset: 0x00745C59
		public int Id { get; set; }

		// Token: 0x1700DF9C RID: 57244
		// (get) Token: 0x060356F1 RID: 218865 RVA: 0x00747A62 File Offset: 0x00745C62
		// (set) Token: 0x060356F2 RID: 218866 RVA: 0x00747A6A File Offset: 0x00745C6A
		public int PlotLineId { get; set; }

		// Token: 0x1700DF9D RID: 57245
		// (get) Token: 0x060356F3 RID: 218867 RVA: 0x00747A73 File Offset: 0x00745C73
		// (set) Token: 0x060356F4 RID: 218868 RVA: 0x00747A7B File Offset: 0x00745C7B
		public string PlotLineKey { get; set; }

		// Token: 0x1700DF9E RID: 57246
		// (get) Token: 0x060356F5 RID: 218869 RVA: 0x00747A84 File Offset: 0x00745C84
		// (set) Token: 0x060356F6 RID: 218870 RVA: 0x00747A8C File Offset: 0x00745C8C
		public string Name { get; set; }

		// Token: 0x1700DF9F RID: 57247
		// (get) Token: 0x060356F7 RID: 218871 RVA: 0x00747A95 File Offset: 0x00745C95
		// (set) Token: 0x060356F8 RID: 218872 RVA: 0x00747A9D File Offset: 0x00745C9D
		public bool _Folded { get; set; }

		// Token: 0x1700DFA0 RID: 57248
		// (get) Token: 0x060356F9 RID: 218873 RVA: 0x00747AA6 File Offset: 0x00745CA6
		// (set) Token: 0x060356FA RID: 218874 RVA: 0x00747AAE File Offset: 0x00745CAE
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DFA1 RID: 57249
		// (get) Token: 0x060356FB RID: 218875 RVA: 0x00747AB7 File Offset: 0x00745CB7
		// (set) Token: 0x060356FC RID: 218876 RVA: 0x00747ABF File Offset: 0x00745CBF
		public int WhoId { get; set; }

		// Token: 0x1700DFA2 RID: 57250
		// (get) Token: 0x060356FD RID: 218877 RVA: 0x00747AC8 File Offset: 0x00745CC8
		// (set) Token: 0x060356FE RID: 218878 RVA: 0x00747AD0 File Offset: 0x00745CD0
		public int TextId { get; set; }

		// Token: 0x1700DFA3 RID: 57251
		// (get) Token: 0x060356FF RID: 218879 RVA: 0x00747AD9 File Offset: 0x00745CD9
		// (set) Token: 0x06035700 RID: 218880 RVA: 0x00747AE1 File Offset: 0x00745CE1
		public string TidTalk { get; set; }

		// Token: 0x1700DFA4 RID: 57252
		// (get) Token: 0x06035701 RID: 218881 RVA: 0x00747AEA File Offset: 0x00745CEA
		// (set) Token: 0x06035702 RID: 218882 RVA: 0x00747AF2 File Offset: 0x00745CF2
		public float WaitTime { get; set; }

		// Token: 0x1700DFA5 RID: 57253
		// (get) Token: 0x06035703 RID: 218883 RVA: 0x00747AFB File Offset: 0x00745CFB
		// (set) Token: 0x06035704 RID: 218884 RVA: 0x00747B03 File Offset: 0x00745D03
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DFA6 RID: 57254
		// (get) Token: 0x06035705 RID: 218885 RVA: 0x00747B0C File Offset: 0x00745D0C
		// (set) Token: 0x06035706 RID: 218886 RVA: 0x00747B14 File Offset: 0x00745D14
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DFA7 RID: 57255
		// (get) Token: 0x06035707 RID: 218887 RVA: 0x00747B1D File Offset: 0x00745D1D
		// (set) Token: 0x06035708 RID: 218888 RVA: 0x00747B25 File Offset: 0x00745D25
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DFA8 RID: 57256
		// (get) Token: 0x06035709 RID: 218889 RVA: 0x00747B2E File Offset: 0x00745D2E
		// (set) Token: 0x0603570A RID: 218890 RVA: 0x00747B36 File Offset: 0x00745D36
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DFA9 RID: 57257
		// (get) Token: 0x0603570B RID: 218891 RVA: 0x00747B3F File Offset: 0x00745D3F
		// (set) Token: 0x0603570C RID: 218892 RVA: 0x00747B47 File Offset: 0x00745D47
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DFAA RID: 57258
		// (get) Token: 0x0603570D RID: 218893 RVA: 0x00747B50 File Offset: 0x00745D50
		// (set) Token: 0x0603570E RID: 218894 RVA: 0x00747B58 File Offset: 0x00745D58
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DFAB RID: 57259
		// (get) Token: 0x0603570F RID: 218895 RVA: 0x00747B61 File Offset: 0x00745D61
		// (set) Token: 0x06035710 RID: 218896 RVA: 0x00747B69 File Offset: 0x00745D69
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DFAC RID: 57260
		// (get) Token: 0x06035711 RID: 218897 RVA: 0x00747B72 File Offset: 0x00745D72
		// (set) Token: 0x06035712 RID: 218898 RVA: 0x00747B7A File Offset: 0x00745D7A
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DFAD RID: 57261
		// (get) Token: 0x06035713 RID: 218899 RVA: 0x00747B83 File Offset: 0x00745D83
		// (set) Token: 0x06035714 RID: 218900 RVA: 0x00747B8B File Offset: 0x00745D8B
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DFAE RID: 57262
		// (get) Token: 0x06035715 RID: 218901 RVA: 0x00747B94 File Offset: 0x00745D94
		// (set) Token: 0x06035716 RID: 218902 RVA: 0x00747B9C File Offset: 0x00745D9C
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DFAF RID: 57263
		// (get) Token: 0x06035717 RID: 218903 RVA: 0x00747BA5 File Offset: 0x00745DA5
		// (set) Token: 0x06035718 RID: 218904 RVA: 0x00747BAD File Offset: 0x00745DAD
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DFB0 RID: 57264
		// (get) Token: 0x06035719 RID: 218905 RVA: 0x00747BB6 File Offset: 0x00745DB6
		// (set) Token: 0x0603571A RID: 218906 RVA: 0x00747BBE File Offset: 0x00745DBE
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DFB1 RID: 57265
		// (get) Token: 0x0603571B RID: 218907 RVA: 0x00747BC7 File Offset: 0x00745DC7
		// (set) Token: 0x0603571C RID: 218908 RVA: 0x00747BCF File Offset: 0x00745DCF
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DFB2 RID: 57266
		// (get) Token: 0x0603571D RID: 218909 RVA: 0x00747BD8 File Offset: 0x00745DD8
		// (set) Token: 0x0603571E RID: 218910 RVA: 0x00747BE0 File Offset: 0x00745DE0
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DFB3 RID: 57267
		// (get) Token: 0x0603571F RID: 218911 RVA: 0x00747BE9 File Offset: 0x00745DE9
		// (set) Token: 0x06035720 RID: 218912 RVA: 0x00747BF1 File Offset: 0x00745DF1
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DFB4 RID: 57268
		// (get) Token: 0x06035721 RID: 218913 RVA: 0x00747BFA File Offset: 0x00745DFA
		// (set) Token: 0x06035722 RID: 218914 RVA: 0x00747C02 File Offset: 0x00745E02
		public bool PlayVoice { get; set; }

		// Token: 0x1700DFB5 RID: 57269
		// (get) Token: 0x06035723 RID: 218915 RVA: 0x00747C0B File Offset: 0x00745E0B
		// (set) Token: 0x06035724 RID: 218916 RVA: 0x00747C13 File Offset: 0x00745E13
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DFB6 RID: 57270
		// (get) Token: 0x06035725 RID: 218917 RVA: 0x00747C1C File Offset: 0x00745E1C
		// (set) Token: 0x06035726 RID: 218918 RVA: 0x00747C24 File Offset: 0x00745E24
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DFB7 RID: 57271
		// (get) Token: 0x06035727 RID: 218919 RVA: 0x00747C2D File Offset: 0x00745E2D
		// (set) Token: 0x06035728 RID: 218920 RVA: 0x00747C35 File Offset: 0x00745E35
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DFB8 RID: 57272
		// (get) Token: 0x06035729 RID: 218921 RVA: 0x00747C3E File Offset: 0x00745E3E
		// (set) Token: 0x0603572A RID: 218922 RVA: 0x00747C46 File Offset: 0x00745E46
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DFB9 RID: 57273
		// (get) Token: 0x0603572B RID: 218923 RVA: 0x00747C4F File Offset: 0x00745E4F
		// (set) Token: 0x0603572C RID: 218924 RVA: 0x00747C57 File Offset: 0x00745E57
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DFBA RID: 57274
		// (get) Token: 0x0603572D RID: 218925 RVA: 0x00747C60 File Offset: 0x00745E60
		// (set) Token: 0x0603572E RID: 218926 RVA: 0x00747C68 File Offset: 0x00745E68
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DFBB RID: 57275
		// (get) Token: 0x0603572F RID: 218927 RVA: 0x00747C71 File Offset: 0x00745E71
		// (set) Token: 0x06035730 RID: 218928 RVA: 0x00747C79 File Offset: 0x00745E79
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700DFBC RID: 57276
		// (get) Token: 0x06035731 RID: 218929 RVA: 0x00747C82 File Offset: 0x00745E82
		// (set) Token: 0x06035732 RID: 218930 RVA: 0x00747C8A File Offset: 0x00745E8A
		public IVisualNovelOptionGroupSolarSchoolExamT OptionGroup { get; set; }

		// Token: 0x1700DFBD RID: 57277
		// (get) Token: 0x06035733 RID: 218931 RVA: 0x00747C93 File Offset: 0x00745E93
		// (set) Token: 0x06035734 RID: 218932 RVA: 0x00747C9B File Offset: 0x00745E9B
		public float DialogDelay { get; set; }

		// Token: 0x1700DFBE RID: 57278
		// (get) Token: 0x06035735 RID: 218933 RVA: 0x00747CA4 File Offset: 0x00745EA4
		// (set) Token: 0x06035736 RID: 218934 RVA: 0x00747CAC File Offset: 0x00745EAC
		public bool ClickShowFull { get; set; }

		// Token: 0x1700DFBF RID: 57279
		// (get) Token: 0x06035737 RID: 218935 RVA: 0x00747CB5 File Offset: 0x00745EB5
		// (set) Token: 0x06035738 RID: 218936 RVA: 0x00747CBD File Offset: 0x00745EBD
		public string Interjection { get; set; }

		// Token: 0x1700DFC0 RID: 57280
		// (get) Token: 0x06035739 RID: 218937 RVA: 0x00747CC6 File Offset: 0x00745EC6
		// (set) Token: 0x0603573A RID: 218938 RVA: 0x00747CCE File Offset: 0x00745ECE
		public IVisualNovelPortraitTransformT Transform { get; set; }

		// Token: 0x1700DFC1 RID: 57281
		// (get) Token: 0x0603573B RID: 218939 RVA: 0x00747CD7 File Offset: 0x00745ED7
		// (set) Token: 0x0603573C RID: 218940 RVA: 0x00747CDF File Offset: 0x00745EDF
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700DFC2 RID: 57282
		// (get) Token: 0x0603573D RID: 218941 RVA: 0x00747CE8 File Offset: 0x00745EE8
		// (set) Token: 0x0603573E RID: 218942 RVA: 0x00747CF0 File Offset: 0x00745EF0
		public TVisualNovelBackgroundUnion VisualNovelBackgroundConfig { get; set; }

		// Token: 0x1700DFC3 RID: 57283
		// (get) Token: 0x0603573F RID: 218943 RVA: 0x00747CF9 File Offset: 0x00745EF9
		// (set) Token: 0x06035740 RID: 218944 RVA: 0x00747D01 File Offset: 0x00745F01
		public TVisualNovelCgUnion CgConfig { get; set; }

		// Token: 0x1700DFC4 RID: 57284
		// (get) Token: 0x06035741 RID: 218945 RVA: 0x00747D0A File Offset: 0x00745F0A
		// (set) Token: 0x06035742 RID: 218946 RVA: 0x00747D12 File Offset: 0x00745F12
		public TVisualNovelDisplayItemUnion DisplayItemConfig { get; set; }

		// Token: 0x1700DFC5 RID: 57285
		// (get) Token: 0x06035743 RID: 218947 RVA: 0x00747D1B File Offset: 0x00745F1B
		// (set) Token: 0x06035744 RID: 218948 RVA: 0x00747D23 File Offset: 0x00745F23
		public int PlotKeyId { get; set; }

		// Token: 0x1700DFC6 RID: 57286
		// (get) Token: 0x06035745 RID: 218949 RVA: 0x00747D2C File Offset: 0x00745F2C
		// (set) Token: 0x06035746 RID: 218950 RVA: 0x00747D34 File Offset: 0x00745F34
		public List<TVisualNovelPerformanceUnion> StartPerformances { get; set; }

		// Token: 0x1700DFC7 RID: 57287
		// (get) Token: 0x06035747 RID: 218951 RVA: 0x00747D3D File Offset: 0x00745F3D
		// (set) Token: 0x06035748 RID: 218952 RVA: 0x00747D45 File Offset: 0x00745F45
		public List<TVisualNovelPerformanceUnion> EndPerformances { get; set; }

		// Token: 0x1700DFC8 RID: 57288
		// (get) Token: 0x06035749 RID: 218953 RVA: 0x00747D4E File Offset: 0x00745F4E
		// (set) Token: 0x0603574A RID: 218954 RVA: 0x00747D56 File Offset: 0x00745F56
		public uint NullMask { get; set; }

		// Token: 0x0603574B RID: 218955 RVA: 0x00747D60 File Offset: 0x00745F60
		public ITalkItemVisualNovelTalkT()
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
			this.DialogDelay = 0f;
			this.ClickShowFull = false;
			this.Interjection = null;
			this.Transform = null;
			this.RoleConfig = null;
			this.VisualNovelBackgroundConfig = null;
			this.CgConfig = null;
			this.DisplayItemConfig = null;
			this.PlotKeyId = 0;
			this.StartPerformances = null;
			this.EndPerformances = null;
			this.NullMask = 0U;
		}
	}
}
