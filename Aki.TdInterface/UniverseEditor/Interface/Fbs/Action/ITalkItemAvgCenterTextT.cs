using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C3 RID: 29379
	public class ITalkItemAvgCenterTextT
	{
		// Token: 0x1700DA49 RID: 55881
		// (get) Token: 0x060343AB RID: 213931 RVA: 0x00707633 File Offset: 0x00705833
		// (set) Token: 0x060343AC RID: 213932 RVA: 0x0070763B File Offset: 0x0070583B
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DA4A RID: 55882
		// (get) Token: 0x060343AD RID: 213933 RVA: 0x00707644 File Offset: 0x00705844
		// (set) Token: 0x060343AE RID: 213934 RVA: 0x0070764C File Offset: 0x0070584C
		public int Id { get; set; }

		// Token: 0x1700DA4B RID: 55883
		// (get) Token: 0x060343AF RID: 213935 RVA: 0x00707655 File Offset: 0x00705855
		// (set) Token: 0x060343B0 RID: 213936 RVA: 0x0070765D File Offset: 0x0070585D
		public int PlotLineId { get; set; }

		// Token: 0x1700DA4C RID: 55884
		// (get) Token: 0x060343B1 RID: 213937 RVA: 0x00707666 File Offset: 0x00705866
		// (set) Token: 0x060343B2 RID: 213938 RVA: 0x0070766E File Offset: 0x0070586E
		public string PlotLineKey { get; set; }

		// Token: 0x1700DA4D RID: 55885
		// (get) Token: 0x060343B3 RID: 213939 RVA: 0x00707677 File Offset: 0x00705877
		// (set) Token: 0x060343B4 RID: 213940 RVA: 0x0070767F File Offset: 0x0070587F
		public string Name { get; set; }

		// Token: 0x1700DA4E RID: 55886
		// (get) Token: 0x060343B5 RID: 213941 RVA: 0x00707688 File Offset: 0x00705888
		// (set) Token: 0x060343B6 RID: 213942 RVA: 0x00707690 File Offset: 0x00705890
		public bool _Folded { get; set; }

		// Token: 0x1700DA4F RID: 55887
		// (get) Token: 0x060343B7 RID: 213943 RVA: 0x00707699 File Offset: 0x00705899
		// (set) Token: 0x060343B8 RID: 213944 RVA: 0x007076A1 File Offset: 0x007058A1
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DA50 RID: 55888
		// (get) Token: 0x060343B9 RID: 213945 RVA: 0x007076AA File Offset: 0x007058AA
		// (set) Token: 0x060343BA RID: 213946 RVA: 0x007076B2 File Offset: 0x007058B2
		public int WhoId { get; set; }

		// Token: 0x1700DA51 RID: 55889
		// (get) Token: 0x060343BB RID: 213947 RVA: 0x007076BB File Offset: 0x007058BB
		// (set) Token: 0x060343BC RID: 213948 RVA: 0x007076C3 File Offset: 0x007058C3
		public int TextId { get; set; }

		// Token: 0x1700DA52 RID: 55890
		// (get) Token: 0x060343BD RID: 213949 RVA: 0x007076CC File Offset: 0x007058CC
		// (set) Token: 0x060343BE RID: 213950 RVA: 0x007076D4 File Offset: 0x007058D4
		public string TidTalk { get; set; }

		// Token: 0x1700DA53 RID: 55891
		// (get) Token: 0x060343BF RID: 213951 RVA: 0x007076DD File Offset: 0x007058DD
		// (set) Token: 0x060343C0 RID: 213952 RVA: 0x007076E5 File Offset: 0x007058E5
		public float WaitTime { get; set; }

		// Token: 0x1700DA54 RID: 55892
		// (get) Token: 0x060343C1 RID: 213953 RVA: 0x007076EE File Offset: 0x007058EE
		// (set) Token: 0x060343C2 RID: 213954 RVA: 0x007076F6 File Offset: 0x007058F6
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DA55 RID: 55893
		// (get) Token: 0x060343C3 RID: 213955 RVA: 0x007076FF File Offset: 0x007058FF
		// (set) Token: 0x060343C4 RID: 213956 RVA: 0x00707707 File Offset: 0x00705907
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DA56 RID: 55894
		// (get) Token: 0x060343C5 RID: 213957 RVA: 0x00707710 File Offset: 0x00705910
		// (set) Token: 0x060343C6 RID: 213958 RVA: 0x00707718 File Offset: 0x00705918
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DA57 RID: 55895
		// (get) Token: 0x060343C7 RID: 213959 RVA: 0x00707721 File Offset: 0x00705921
		// (set) Token: 0x060343C8 RID: 213960 RVA: 0x00707729 File Offset: 0x00705929
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DA58 RID: 55896
		// (get) Token: 0x060343C9 RID: 213961 RVA: 0x00707732 File Offset: 0x00705932
		// (set) Token: 0x060343CA RID: 213962 RVA: 0x0070773A File Offset: 0x0070593A
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DA59 RID: 55897
		// (get) Token: 0x060343CB RID: 213963 RVA: 0x00707743 File Offset: 0x00705943
		// (set) Token: 0x060343CC RID: 213964 RVA: 0x0070774B File Offset: 0x0070594B
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DA5A RID: 55898
		// (get) Token: 0x060343CD RID: 213965 RVA: 0x00707754 File Offset: 0x00705954
		// (set) Token: 0x060343CE RID: 213966 RVA: 0x0070775C File Offset: 0x0070595C
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DA5B RID: 55899
		// (get) Token: 0x060343CF RID: 213967 RVA: 0x00707765 File Offset: 0x00705965
		// (set) Token: 0x060343D0 RID: 213968 RVA: 0x0070776D File Offset: 0x0070596D
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DA5C RID: 55900
		// (get) Token: 0x060343D1 RID: 213969 RVA: 0x00707776 File Offset: 0x00705976
		// (set) Token: 0x060343D2 RID: 213970 RVA: 0x0070777E File Offset: 0x0070597E
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DA5D RID: 55901
		// (get) Token: 0x060343D3 RID: 213971 RVA: 0x00707787 File Offset: 0x00705987
		// (set) Token: 0x060343D4 RID: 213972 RVA: 0x0070778F File Offset: 0x0070598F
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DA5E RID: 55902
		// (get) Token: 0x060343D5 RID: 213973 RVA: 0x00707798 File Offset: 0x00705998
		// (set) Token: 0x060343D6 RID: 213974 RVA: 0x007077A0 File Offset: 0x007059A0
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DA5F RID: 55903
		// (get) Token: 0x060343D7 RID: 213975 RVA: 0x007077A9 File Offset: 0x007059A9
		// (set) Token: 0x060343D8 RID: 213976 RVA: 0x007077B1 File Offset: 0x007059B1
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DA60 RID: 55904
		// (get) Token: 0x060343D9 RID: 213977 RVA: 0x007077BA File Offset: 0x007059BA
		// (set) Token: 0x060343DA RID: 213978 RVA: 0x007077C2 File Offset: 0x007059C2
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DA61 RID: 55905
		// (get) Token: 0x060343DB RID: 213979 RVA: 0x007077CB File Offset: 0x007059CB
		// (set) Token: 0x060343DC RID: 213980 RVA: 0x007077D3 File Offset: 0x007059D3
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DA62 RID: 55906
		// (get) Token: 0x060343DD RID: 213981 RVA: 0x007077DC File Offset: 0x007059DC
		// (set) Token: 0x060343DE RID: 213982 RVA: 0x007077E4 File Offset: 0x007059E4
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DA63 RID: 55907
		// (get) Token: 0x060343DF RID: 213983 RVA: 0x007077ED File Offset: 0x007059ED
		// (set) Token: 0x060343E0 RID: 213984 RVA: 0x007077F5 File Offset: 0x007059F5
		public bool PlayVoice { get; set; }

		// Token: 0x1700DA64 RID: 55908
		// (get) Token: 0x060343E1 RID: 213985 RVA: 0x007077FE File Offset: 0x007059FE
		// (set) Token: 0x060343E2 RID: 213986 RVA: 0x00707806 File Offset: 0x00705A06
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DA65 RID: 55909
		// (get) Token: 0x060343E3 RID: 213987 RVA: 0x0070780F File Offset: 0x00705A0F
		// (set) Token: 0x060343E4 RID: 213988 RVA: 0x00707817 File Offset: 0x00705A17
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DA66 RID: 55910
		// (get) Token: 0x060343E5 RID: 213989 RVA: 0x00707820 File Offset: 0x00705A20
		// (set) Token: 0x060343E6 RID: 213990 RVA: 0x00707828 File Offset: 0x00705A28
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DA67 RID: 55911
		// (get) Token: 0x060343E7 RID: 213991 RVA: 0x00707831 File Offset: 0x00705A31
		// (set) Token: 0x060343E8 RID: 213992 RVA: 0x00707839 File Offset: 0x00705A39
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DA68 RID: 55912
		// (get) Token: 0x060343E9 RID: 213993 RVA: 0x00707842 File Offset: 0x00705A42
		// (set) Token: 0x060343EA RID: 213994 RVA: 0x0070784A File Offset: 0x00705A4A
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DA69 RID: 55913
		// (get) Token: 0x060343EB RID: 213995 RVA: 0x00707853 File Offset: 0x00705A53
		// (set) Token: 0x060343EC RID: 213996 RVA: 0x0070785B File Offset: 0x00705A5B
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DA6A RID: 55914
		// (get) Token: 0x060343ED RID: 213997 RVA: 0x00707864 File Offset: 0x00705A64
		// (set) Token: 0x060343EE RID: 213998 RVA: 0x0070786C File Offset: 0x00705A6C
		public uint NullMask { get; set; }

		// Token: 0x060343EF RID: 213999 RVA: 0x00707878 File Offset: 0x00705A78
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
