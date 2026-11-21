using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AE9 RID: 31465
	public class ITalkItemVisualNovelNarrationT
	{
		// Token: 0x1700EA8B RID: 60043
		// (get) Token: 0x0603864B RID: 230987 RVA: 0x0079B6C5 File Offset: 0x007998C5
		// (set) Token: 0x0603864C RID: 230988 RVA: 0x0079B6CD File Offset: 0x007998CD
		public ETalkItemType Type { get; set; }

		// Token: 0x1700EA8C RID: 60044
		// (get) Token: 0x0603864D RID: 230989 RVA: 0x0079B6D6 File Offset: 0x007998D6
		// (set) Token: 0x0603864E RID: 230990 RVA: 0x0079B6DE File Offset: 0x007998DE
		public int Id { get; set; }

		// Token: 0x1700EA8D RID: 60045
		// (get) Token: 0x0603864F RID: 230991 RVA: 0x0079B6E7 File Offset: 0x007998E7
		// (set) Token: 0x06038650 RID: 230992 RVA: 0x0079B6EF File Offset: 0x007998EF
		public int PlotLineId { get; set; }

		// Token: 0x1700EA8E RID: 60046
		// (get) Token: 0x06038651 RID: 230993 RVA: 0x0079B6F8 File Offset: 0x007998F8
		// (set) Token: 0x06038652 RID: 230994 RVA: 0x0079B700 File Offset: 0x00799900
		public string PlotLineKey { get; set; }

		// Token: 0x1700EA8F RID: 60047
		// (get) Token: 0x06038653 RID: 230995 RVA: 0x0079B709 File Offset: 0x00799909
		// (set) Token: 0x06038654 RID: 230996 RVA: 0x0079B711 File Offset: 0x00799911
		public string Name { get; set; }

		// Token: 0x1700EA90 RID: 60048
		// (get) Token: 0x06038655 RID: 230997 RVA: 0x0079B71A File Offset: 0x0079991A
		// (set) Token: 0x06038656 RID: 230998 RVA: 0x0079B722 File Offset: 0x00799922
		public bool _Folded { get; set; }

		// Token: 0x1700EA91 RID: 60049
		// (get) Token: 0x06038657 RID: 230999 RVA: 0x0079B72B File Offset: 0x0079992B
		// (set) Token: 0x06038658 RID: 231000 RVA: 0x0079B733 File Offset: 0x00799933
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700EA92 RID: 60050
		// (get) Token: 0x06038659 RID: 231001 RVA: 0x0079B73C File Offset: 0x0079993C
		// (set) Token: 0x0603865A RID: 231002 RVA: 0x0079B744 File Offset: 0x00799944
		public int WhoId { get; set; }

		// Token: 0x1700EA93 RID: 60051
		// (get) Token: 0x0603865B RID: 231003 RVA: 0x0079B74D File Offset: 0x0079994D
		// (set) Token: 0x0603865C RID: 231004 RVA: 0x0079B755 File Offset: 0x00799955
		public int TextId { get; set; }

		// Token: 0x1700EA94 RID: 60052
		// (get) Token: 0x0603865D RID: 231005 RVA: 0x0079B75E File Offset: 0x0079995E
		// (set) Token: 0x0603865E RID: 231006 RVA: 0x0079B766 File Offset: 0x00799966
		public string TidTalk { get; set; }

		// Token: 0x1700EA95 RID: 60053
		// (get) Token: 0x0603865F RID: 231007 RVA: 0x0079B76F File Offset: 0x0079996F
		// (set) Token: 0x06038660 RID: 231008 RVA: 0x0079B777 File Offset: 0x00799977
		public float WaitTime { get; set; }

		// Token: 0x1700EA96 RID: 60054
		// (get) Token: 0x06038661 RID: 231009 RVA: 0x0079B780 File Offset: 0x00799980
		// (set) Token: 0x06038662 RID: 231010 RVA: 0x0079B788 File Offset: 0x00799988
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700EA97 RID: 60055
		// (get) Token: 0x06038663 RID: 231011 RVA: 0x0079B791 File Offset: 0x00799991
		// (set) Token: 0x06038664 RID: 231012 RVA: 0x0079B799 File Offset: 0x00799999
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700EA98 RID: 60056
		// (get) Token: 0x06038665 RID: 231013 RVA: 0x0079B7A2 File Offset: 0x007999A2
		// (set) Token: 0x06038666 RID: 231014 RVA: 0x0079B7AA File Offset: 0x007999AA
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700EA99 RID: 60057
		// (get) Token: 0x06038667 RID: 231015 RVA: 0x0079B7B3 File Offset: 0x007999B3
		// (set) Token: 0x06038668 RID: 231016 RVA: 0x0079B7BB File Offset: 0x007999BB
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700EA9A RID: 60058
		// (get) Token: 0x06038669 RID: 231017 RVA: 0x0079B7C4 File Offset: 0x007999C4
		// (set) Token: 0x0603866A RID: 231018 RVA: 0x0079B7CC File Offset: 0x007999CC
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700EA9B RID: 60059
		// (get) Token: 0x0603866B RID: 231019 RVA: 0x0079B7D5 File Offset: 0x007999D5
		// (set) Token: 0x0603866C RID: 231020 RVA: 0x0079B7DD File Offset: 0x007999DD
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700EA9C RID: 60060
		// (get) Token: 0x0603866D RID: 231021 RVA: 0x0079B7E6 File Offset: 0x007999E6
		// (set) Token: 0x0603866E RID: 231022 RVA: 0x0079B7EE File Offset: 0x007999EE
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700EA9D RID: 60061
		// (get) Token: 0x0603866F RID: 231023 RVA: 0x0079B7F7 File Offset: 0x007999F7
		// (set) Token: 0x06038670 RID: 231024 RVA: 0x0079B7FF File Offset: 0x007999FF
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700EA9E RID: 60062
		// (get) Token: 0x06038671 RID: 231025 RVA: 0x0079B808 File Offset: 0x00799A08
		// (set) Token: 0x06038672 RID: 231026 RVA: 0x0079B810 File Offset: 0x00799A10
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700EA9F RID: 60063
		// (get) Token: 0x06038673 RID: 231027 RVA: 0x0079B819 File Offset: 0x00799A19
		// (set) Token: 0x06038674 RID: 231028 RVA: 0x0079B821 File Offset: 0x00799A21
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700EAA0 RID: 60064
		// (get) Token: 0x06038675 RID: 231029 RVA: 0x0079B82A File Offset: 0x00799A2A
		// (set) Token: 0x06038676 RID: 231030 RVA: 0x0079B832 File Offset: 0x00799A32
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700EAA1 RID: 60065
		// (get) Token: 0x06038677 RID: 231031 RVA: 0x0079B83B File Offset: 0x00799A3B
		// (set) Token: 0x06038678 RID: 231032 RVA: 0x0079B843 File Offset: 0x00799A43
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700EAA2 RID: 60066
		// (get) Token: 0x06038679 RID: 231033 RVA: 0x0079B84C File Offset: 0x00799A4C
		// (set) Token: 0x0603867A RID: 231034 RVA: 0x0079B854 File Offset: 0x00799A54
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700EAA3 RID: 60067
		// (get) Token: 0x0603867B RID: 231035 RVA: 0x0079B85D File Offset: 0x00799A5D
		// (set) Token: 0x0603867C RID: 231036 RVA: 0x0079B865 File Offset: 0x00799A65
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700EAA4 RID: 60068
		// (get) Token: 0x0603867D RID: 231037 RVA: 0x0079B86E File Offset: 0x00799A6E
		// (set) Token: 0x0603867E RID: 231038 RVA: 0x0079B876 File Offset: 0x00799A76
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700EAA5 RID: 60069
		// (get) Token: 0x0603867F RID: 231039 RVA: 0x0079B87F File Offset: 0x00799A7F
		// (set) Token: 0x06038680 RID: 231040 RVA: 0x0079B887 File Offset: 0x00799A87
		public bool PlayVoice { get; set; }

		// Token: 0x1700EAA6 RID: 60070
		// (get) Token: 0x06038681 RID: 231041 RVA: 0x0079B890 File Offset: 0x00799A90
		// (set) Token: 0x06038682 RID: 231042 RVA: 0x0079B898 File Offset: 0x00799A98
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700EAA7 RID: 60071
		// (get) Token: 0x06038683 RID: 231043 RVA: 0x0079B8A1 File Offset: 0x00799AA1
		// (set) Token: 0x06038684 RID: 231044 RVA: 0x0079B8A9 File Offset: 0x00799AA9
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700EAA8 RID: 60072
		// (get) Token: 0x06038685 RID: 231045 RVA: 0x0079B8B2 File Offset: 0x00799AB2
		// (set) Token: 0x06038686 RID: 231046 RVA: 0x0079B8BA File Offset: 0x00799ABA
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700EAA9 RID: 60073
		// (get) Token: 0x06038687 RID: 231047 RVA: 0x0079B8C3 File Offset: 0x00799AC3
		// (set) Token: 0x06038688 RID: 231048 RVA: 0x0079B8CB File Offset: 0x00799ACB
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700EAAA RID: 60074
		// (get) Token: 0x06038689 RID: 231049 RVA: 0x0079B8D4 File Offset: 0x00799AD4
		// (set) Token: 0x0603868A RID: 231050 RVA: 0x0079B8DC File Offset: 0x00799ADC
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700EAAB RID: 60075
		// (get) Token: 0x0603868B RID: 231051 RVA: 0x0079B8E5 File Offset: 0x00799AE5
		// (set) Token: 0x0603868C RID: 231052 RVA: 0x0079B8ED File Offset: 0x00799AED
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700EAAC RID: 60076
		// (get) Token: 0x0603868D RID: 231053 RVA: 0x0079B8F6 File Offset: 0x00799AF6
		// (set) Token: 0x0603868E RID: 231054 RVA: 0x0079B8FE File Offset: 0x00799AFE
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700EAAD RID: 60077
		// (get) Token: 0x0603868F RID: 231055 RVA: 0x0079B907 File Offset: 0x00799B07
		// (set) Token: 0x06038690 RID: 231056 RVA: 0x0079B90F File Offset: 0x00799B0F
		public TVisualNovelOptionGroupConfigUnion OptionGroup { get; set; }

		// Token: 0x1700EAAE RID: 60078
		// (get) Token: 0x06038691 RID: 231057 RVA: 0x0079B918 File Offset: 0x00799B18
		// (set) Token: 0x06038692 RID: 231058 RVA: 0x0079B920 File Offset: 0x00799B20
		public float DialogDelay { get; set; }

		// Token: 0x1700EAAF RID: 60079
		// (get) Token: 0x06038693 RID: 231059 RVA: 0x0079B929 File Offset: 0x00799B29
		// (set) Token: 0x06038694 RID: 231060 RVA: 0x0079B931 File Offset: 0x00799B31
		public bool ClickShowFull { get; set; }

		// Token: 0x1700EAB0 RID: 60080
		// (get) Token: 0x06038695 RID: 231061 RVA: 0x0079B93A File Offset: 0x00799B3A
		// (set) Token: 0x06038696 RID: 231062 RVA: 0x0079B942 File Offset: 0x00799B42
		public TVisualNovelBackgroundUnion VisualNovelBackgroundConfig { get; set; }

		// Token: 0x1700EAB1 RID: 60081
		// (get) Token: 0x06038697 RID: 231063 RVA: 0x0079B94B File Offset: 0x00799B4B
		// (set) Token: 0x06038698 RID: 231064 RVA: 0x0079B953 File Offset: 0x00799B53
		public TVisualNovelCgUnion CgConfig { get; set; }

		// Token: 0x1700EAB2 RID: 60082
		// (get) Token: 0x06038699 RID: 231065 RVA: 0x0079B95C File Offset: 0x00799B5C
		// (set) Token: 0x0603869A RID: 231066 RVA: 0x0079B964 File Offset: 0x00799B64
		public TVisualNovelDisplayItemUnion DisplayItemConfig { get; set; }

		// Token: 0x1700EAB3 RID: 60083
		// (get) Token: 0x0603869B RID: 231067 RVA: 0x0079B96D File Offset: 0x00799B6D
		// (set) Token: 0x0603869C RID: 231068 RVA: 0x0079B975 File Offset: 0x00799B75
		public int PlotKeyId { get; set; }

		// Token: 0x1700EAB4 RID: 60084
		// (get) Token: 0x0603869D RID: 231069 RVA: 0x0079B97E File Offset: 0x00799B7E
		// (set) Token: 0x0603869E RID: 231070 RVA: 0x0079B986 File Offset: 0x00799B86
		public List<TVisualNovelPerformanceUnion> StartPerformances { get; set; }

		// Token: 0x1700EAB5 RID: 60085
		// (get) Token: 0x0603869F RID: 231071 RVA: 0x0079B98F File Offset: 0x00799B8F
		// (set) Token: 0x060386A0 RID: 231072 RVA: 0x0079B997 File Offset: 0x00799B97
		public List<TVisualNovelPerformanceUnion> EndPerformances { get; set; }

		// Token: 0x1700EAB6 RID: 60086
		// (get) Token: 0x060386A1 RID: 231073 RVA: 0x0079B9A0 File Offset: 0x00799BA0
		// (set) Token: 0x060386A2 RID: 231074 RVA: 0x0079B9A8 File Offset: 0x00799BA8
		public uint NullMask { get; set; }

		// Token: 0x060386A3 RID: 231075 RVA: 0x0079B9B4 File Offset: 0x00799BB4
		public ITalkItemVisualNovelNarrationT()
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
