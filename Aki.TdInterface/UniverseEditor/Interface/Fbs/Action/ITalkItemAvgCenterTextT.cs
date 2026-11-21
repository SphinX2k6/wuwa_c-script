using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A98 RID: 31384
	public class ITalkItemAvgCenterTextT
	{
		// Token: 0x1700E642 RID: 58946
		// (get) Token: 0x060376AF RID: 226991 RVA: 0x007689CF File Offset: 0x00766BCF
		// (set) Token: 0x060376B0 RID: 226992 RVA: 0x007689D7 File Offset: 0x00766BD7
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E643 RID: 58947
		// (get) Token: 0x060376B1 RID: 226993 RVA: 0x007689E0 File Offset: 0x00766BE0
		// (set) Token: 0x060376B2 RID: 226994 RVA: 0x007689E8 File Offset: 0x00766BE8
		public int Id { get; set; }

		// Token: 0x1700E644 RID: 58948
		// (get) Token: 0x060376B3 RID: 226995 RVA: 0x007689F1 File Offset: 0x00766BF1
		// (set) Token: 0x060376B4 RID: 226996 RVA: 0x007689F9 File Offset: 0x00766BF9
		public int PlotLineId { get; set; }

		// Token: 0x1700E645 RID: 58949
		// (get) Token: 0x060376B5 RID: 226997 RVA: 0x00768A02 File Offset: 0x00766C02
		// (set) Token: 0x060376B6 RID: 226998 RVA: 0x00768A0A File Offset: 0x00766C0A
		public string PlotLineKey { get; set; }

		// Token: 0x1700E646 RID: 58950
		// (get) Token: 0x060376B7 RID: 226999 RVA: 0x00768A13 File Offset: 0x00766C13
		// (set) Token: 0x060376B8 RID: 227000 RVA: 0x00768A1B File Offset: 0x00766C1B
		public string Name { get; set; }

		// Token: 0x1700E647 RID: 58951
		// (get) Token: 0x060376B9 RID: 227001 RVA: 0x00768A24 File Offset: 0x00766C24
		// (set) Token: 0x060376BA RID: 227002 RVA: 0x00768A2C File Offset: 0x00766C2C
		public bool _Folded { get; set; }

		// Token: 0x1700E648 RID: 58952
		// (get) Token: 0x060376BB RID: 227003 RVA: 0x00768A35 File Offset: 0x00766C35
		// (set) Token: 0x060376BC RID: 227004 RVA: 0x00768A3D File Offset: 0x00766C3D
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E649 RID: 58953
		// (get) Token: 0x060376BD RID: 227005 RVA: 0x00768A46 File Offset: 0x00766C46
		// (set) Token: 0x060376BE RID: 227006 RVA: 0x00768A4E File Offset: 0x00766C4E
		public int WhoId { get; set; }

		// Token: 0x1700E64A RID: 58954
		// (get) Token: 0x060376BF RID: 227007 RVA: 0x00768A57 File Offset: 0x00766C57
		// (set) Token: 0x060376C0 RID: 227008 RVA: 0x00768A5F File Offset: 0x00766C5F
		public int TextId { get; set; }

		// Token: 0x1700E64B RID: 58955
		// (get) Token: 0x060376C1 RID: 227009 RVA: 0x00768A68 File Offset: 0x00766C68
		// (set) Token: 0x060376C2 RID: 227010 RVA: 0x00768A70 File Offset: 0x00766C70
		public string TidTalk { get; set; }

		// Token: 0x1700E64C RID: 58956
		// (get) Token: 0x060376C3 RID: 227011 RVA: 0x00768A79 File Offset: 0x00766C79
		// (set) Token: 0x060376C4 RID: 227012 RVA: 0x00768A81 File Offset: 0x00766C81
		public float WaitTime { get; set; }

		// Token: 0x1700E64D RID: 58957
		// (get) Token: 0x060376C5 RID: 227013 RVA: 0x00768A8A File Offset: 0x00766C8A
		// (set) Token: 0x060376C6 RID: 227014 RVA: 0x00768A92 File Offset: 0x00766C92
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E64E RID: 58958
		// (get) Token: 0x060376C7 RID: 227015 RVA: 0x00768A9B File Offset: 0x00766C9B
		// (set) Token: 0x060376C8 RID: 227016 RVA: 0x00768AA3 File Offset: 0x00766CA3
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E64F RID: 58959
		// (get) Token: 0x060376C9 RID: 227017 RVA: 0x00768AAC File Offset: 0x00766CAC
		// (set) Token: 0x060376CA RID: 227018 RVA: 0x00768AB4 File Offset: 0x00766CB4
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E650 RID: 58960
		// (get) Token: 0x060376CB RID: 227019 RVA: 0x00768ABD File Offset: 0x00766CBD
		// (set) Token: 0x060376CC RID: 227020 RVA: 0x00768AC5 File Offset: 0x00766CC5
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E651 RID: 58961
		// (get) Token: 0x060376CD RID: 227021 RVA: 0x00768ACE File Offset: 0x00766CCE
		// (set) Token: 0x060376CE RID: 227022 RVA: 0x00768AD6 File Offset: 0x00766CD6
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E652 RID: 58962
		// (get) Token: 0x060376CF RID: 227023 RVA: 0x00768ADF File Offset: 0x00766CDF
		// (set) Token: 0x060376D0 RID: 227024 RVA: 0x00768AE7 File Offset: 0x00766CE7
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E653 RID: 58963
		// (get) Token: 0x060376D1 RID: 227025 RVA: 0x00768AF0 File Offset: 0x00766CF0
		// (set) Token: 0x060376D2 RID: 227026 RVA: 0x00768AF8 File Offset: 0x00766CF8
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E654 RID: 58964
		// (get) Token: 0x060376D3 RID: 227027 RVA: 0x00768B01 File Offset: 0x00766D01
		// (set) Token: 0x060376D4 RID: 227028 RVA: 0x00768B09 File Offset: 0x00766D09
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E655 RID: 58965
		// (get) Token: 0x060376D5 RID: 227029 RVA: 0x00768B12 File Offset: 0x00766D12
		// (set) Token: 0x060376D6 RID: 227030 RVA: 0x00768B1A File Offset: 0x00766D1A
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E656 RID: 58966
		// (get) Token: 0x060376D7 RID: 227031 RVA: 0x00768B23 File Offset: 0x00766D23
		// (set) Token: 0x060376D8 RID: 227032 RVA: 0x00768B2B File Offset: 0x00766D2B
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E657 RID: 58967
		// (get) Token: 0x060376D9 RID: 227033 RVA: 0x00768B34 File Offset: 0x00766D34
		// (set) Token: 0x060376DA RID: 227034 RVA: 0x00768B3C File Offset: 0x00766D3C
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E658 RID: 58968
		// (get) Token: 0x060376DB RID: 227035 RVA: 0x00768B45 File Offset: 0x00766D45
		// (set) Token: 0x060376DC RID: 227036 RVA: 0x00768B4D File Offset: 0x00766D4D
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E659 RID: 58969
		// (get) Token: 0x060376DD RID: 227037 RVA: 0x00768B56 File Offset: 0x00766D56
		// (set) Token: 0x060376DE RID: 227038 RVA: 0x00768B5E File Offset: 0x00766D5E
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E65A RID: 58970
		// (get) Token: 0x060376DF RID: 227039 RVA: 0x00768B67 File Offset: 0x00766D67
		// (set) Token: 0x060376E0 RID: 227040 RVA: 0x00768B6F File Offset: 0x00766D6F
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E65B RID: 58971
		// (get) Token: 0x060376E1 RID: 227041 RVA: 0x00768B78 File Offset: 0x00766D78
		// (set) Token: 0x060376E2 RID: 227042 RVA: 0x00768B80 File Offset: 0x00766D80
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E65C RID: 58972
		// (get) Token: 0x060376E3 RID: 227043 RVA: 0x00768B89 File Offset: 0x00766D89
		// (set) Token: 0x060376E4 RID: 227044 RVA: 0x00768B91 File Offset: 0x00766D91
		public bool PlayVoice { get; set; }

		// Token: 0x1700E65D RID: 58973
		// (get) Token: 0x060376E5 RID: 227045 RVA: 0x00768B9A File Offset: 0x00766D9A
		// (set) Token: 0x060376E6 RID: 227046 RVA: 0x00768BA2 File Offset: 0x00766DA2
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E65E RID: 58974
		// (get) Token: 0x060376E7 RID: 227047 RVA: 0x00768BAB File Offset: 0x00766DAB
		// (set) Token: 0x060376E8 RID: 227048 RVA: 0x00768BB3 File Offset: 0x00766DB3
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E65F RID: 58975
		// (get) Token: 0x060376E9 RID: 227049 RVA: 0x00768BBC File Offset: 0x00766DBC
		// (set) Token: 0x060376EA RID: 227050 RVA: 0x00768BC4 File Offset: 0x00766DC4
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E660 RID: 58976
		// (get) Token: 0x060376EB RID: 227051 RVA: 0x00768BCD File Offset: 0x00766DCD
		// (set) Token: 0x060376EC RID: 227052 RVA: 0x00768BD5 File Offset: 0x00766DD5
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E661 RID: 58977
		// (get) Token: 0x060376ED RID: 227053 RVA: 0x00768BDE File Offset: 0x00766DDE
		// (set) Token: 0x060376EE RID: 227054 RVA: 0x00768BE6 File Offset: 0x00766DE6
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E662 RID: 58978
		// (get) Token: 0x060376EF RID: 227055 RVA: 0x00768BEF File Offset: 0x00766DEF
		// (set) Token: 0x060376F0 RID: 227056 RVA: 0x00768BF7 File Offset: 0x00766DF7
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E663 RID: 58979
		// (get) Token: 0x060376F1 RID: 227057 RVA: 0x00768C00 File Offset: 0x00766E00
		// (set) Token: 0x060376F2 RID: 227058 RVA: 0x00768C08 File Offset: 0x00766E08
		public uint NullMask { get; set; }

		// Token: 0x060376F3 RID: 227059 RVA: 0x00768C14 File Offset: 0x00766E14
		public ITalkItemAvgCenterTextT()
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
			this.NullMask = 0U;
		}
	}
}
