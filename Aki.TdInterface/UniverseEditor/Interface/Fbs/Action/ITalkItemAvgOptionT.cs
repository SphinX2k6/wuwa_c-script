using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AA4 RID: 31396
	public class ITalkItemAvgOptionT
	{
		// Token: 0x1700E760 RID: 59232
		// (get) Token: 0x06037AA7 RID: 228007 RVA: 0x00775D3F File Offset: 0x00773F3F
		// (set) Token: 0x06037AA8 RID: 228008 RVA: 0x00775D47 File Offset: 0x00773F47
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E761 RID: 59233
		// (get) Token: 0x06037AA9 RID: 228009 RVA: 0x00775D50 File Offset: 0x00773F50
		// (set) Token: 0x06037AAA RID: 228010 RVA: 0x00775D58 File Offset: 0x00773F58
		public int Id { get; set; }

		// Token: 0x1700E762 RID: 59234
		// (get) Token: 0x06037AAB RID: 228011 RVA: 0x00775D61 File Offset: 0x00773F61
		// (set) Token: 0x06037AAC RID: 228012 RVA: 0x00775D69 File Offset: 0x00773F69
		public int PlotLineId { get; set; }

		// Token: 0x1700E763 RID: 59235
		// (get) Token: 0x06037AAD RID: 228013 RVA: 0x00775D72 File Offset: 0x00773F72
		// (set) Token: 0x06037AAE RID: 228014 RVA: 0x00775D7A File Offset: 0x00773F7A
		public string PlotLineKey { get; set; }

		// Token: 0x1700E764 RID: 59236
		// (get) Token: 0x06037AAF RID: 228015 RVA: 0x00775D83 File Offset: 0x00773F83
		// (set) Token: 0x06037AB0 RID: 228016 RVA: 0x00775D8B File Offset: 0x00773F8B
		public string Name { get; set; }

		// Token: 0x1700E765 RID: 59237
		// (get) Token: 0x06037AB1 RID: 228017 RVA: 0x00775D94 File Offset: 0x00773F94
		// (set) Token: 0x06037AB2 RID: 228018 RVA: 0x00775D9C File Offset: 0x00773F9C
		public bool _Folded { get; set; }

		// Token: 0x1700E766 RID: 59238
		// (get) Token: 0x06037AB3 RID: 228019 RVA: 0x00775DA5 File Offset: 0x00773FA5
		// (set) Token: 0x06037AB4 RID: 228020 RVA: 0x00775DAD File Offset: 0x00773FAD
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E767 RID: 59239
		// (get) Token: 0x06037AB5 RID: 228021 RVA: 0x00775DB6 File Offset: 0x00773FB6
		// (set) Token: 0x06037AB6 RID: 228022 RVA: 0x00775DBE File Offset: 0x00773FBE
		public int WhoId { get; set; }

		// Token: 0x1700E768 RID: 59240
		// (get) Token: 0x06037AB7 RID: 228023 RVA: 0x00775DC7 File Offset: 0x00773FC7
		// (set) Token: 0x06037AB8 RID: 228024 RVA: 0x00775DCF File Offset: 0x00773FCF
		public int TextId { get; set; }

		// Token: 0x1700E769 RID: 59241
		// (get) Token: 0x06037AB9 RID: 228025 RVA: 0x00775DD8 File Offset: 0x00773FD8
		// (set) Token: 0x06037ABA RID: 228026 RVA: 0x00775DE0 File Offset: 0x00773FE0
		public string TidTalk { get; set; }

		// Token: 0x1700E76A RID: 59242
		// (get) Token: 0x06037ABB RID: 228027 RVA: 0x00775DE9 File Offset: 0x00773FE9
		// (set) Token: 0x06037ABC RID: 228028 RVA: 0x00775DF1 File Offset: 0x00773FF1
		public float WaitTime { get; set; }

		// Token: 0x1700E76B RID: 59243
		// (get) Token: 0x06037ABD RID: 228029 RVA: 0x00775DFA File Offset: 0x00773FFA
		// (set) Token: 0x06037ABE RID: 228030 RVA: 0x00775E02 File Offset: 0x00774002
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E76C RID: 59244
		// (get) Token: 0x06037ABF RID: 228031 RVA: 0x00775E0B File Offset: 0x0077400B
		// (set) Token: 0x06037AC0 RID: 228032 RVA: 0x00775E13 File Offset: 0x00774013
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E76D RID: 59245
		// (get) Token: 0x06037AC1 RID: 228033 RVA: 0x00775E1C File Offset: 0x0077401C
		// (set) Token: 0x06037AC2 RID: 228034 RVA: 0x00775E24 File Offset: 0x00774024
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E76E RID: 59246
		// (get) Token: 0x06037AC3 RID: 228035 RVA: 0x00775E2D File Offset: 0x0077402D
		// (set) Token: 0x06037AC4 RID: 228036 RVA: 0x00775E35 File Offset: 0x00774035
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E76F RID: 59247
		// (get) Token: 0x06037AC5 RID: 228037 RVA: 0x00775E3E File Offset: 0x0077403E
		// (set) Token: 0x06037AC6 RID: 228038 RVA: 0x00775E46 File Offset: 0x00774046
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E770 RID: 59248
		// (get) Token: 0x06037AC7 RID: 228039 RVA: 0x00775E4F File Offset: 0x0077404F
		// (set) Token: 0x06037AC8 RID: 228040 RVA: 0x00775E57 File Offset: 0x00774057
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E771 RID: 59249
		// (get) Token: 0x06037AC9 RID: 228041 RVA: 0x00775E60 File Offset: 0x00774060
		// (set) Token: 0x06037ACA RID: 228042 RVA: 0x00775E68 File Offset: 0x00774068
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E772 RID: 59250
		// (get) Token: 0x06037ACB RID: 228043 RVA: 0x00775E71 File Offset: 0x00774071
		// (set) Token: 0x06037ACC RID: 228044 RVA: 0x00775E79 File Offset: 0x00774079
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E773 RID: 59251
		// (get) Token: 0x06037ACD RID: 228045 RVA: 0x00775E82 File Offset: 0x00774082
		// (set) Token: 0x06037ACE RID: 228046 RVA: 0x00775E8A File Offset: 0x0077408A
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E774 RID: 59252
		// (get) Token: 0x06037ACF RID: 228047 RVA: 0x00775E93 File Offset: 0x00774093
		// (set) Token: 0x06037AD0 RID: 228048 RVA: 0x00775E9B File Offset: 0x0077409B
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E775 RID: 59253
		// (get) Token: 0x06037AD1 RID: 228049 RVA: 0x00775EA4 File Offset: 0x007740A4
		// (set) Token: 0x06037AD2 RID: 228050 RVA: 0x00775EAC File Offset: 0x007740AC
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E776 RID: 59254
		// (get) Token: 0x06037AD3 RID: 228051 RVA: 0x00775EB5 File Offset: 0x007740B5
		// (set) Token: 0x06037AD4 RID: 228052 RVA: 0x00775EBD File Offset: 0x007740BD
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E777 RID: 59255
		// (get) Token: 0x06037AD5 RID: 228053 RVA: 0x00775EC6 File Offset: 0x007740C6
		// (set) Token: 0x06037AD6 RID: 228054 RVA: 0x00775ECE File Offset: 0x007740CE
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E778 RID: 59256
		// (get) Token: 0x06037AD7 RID: 228055 RVA: 0x00775ED7 File Offset: 0x007740D7
		// (set) Token: 0x06037AD8 RID: 228056 RVA: 0x00775EDF File Offset: 0x007740DF
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E779 RID: 59257
		// (get) Token: 0x06037AD9 RID: 228057 RVA: 0x00775EE8 File Offset: 0x007740E8
		// (set) Token: 0x06037ADA RID: 228058 RVA: 0x00775EF0 File Offset: 0x007740F0
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E77A RID: 59258
		// (get) Token: 0x06037ADB RID: 228059 RVA: 0x00775EF9 File Offset: 0x007740F9
		// (set) Token: 0x06037ADC RID: 228060 RVA: 0x00775F01 File Offset: 0x00774101
		public bool PlayVoice { get; set; }

		// Token: 0x1700E77B RID: 59259
		// (get) Token: 0x06037ADD RID: 228061 RVA: 0x00775F0A File Offset: 0x0077410A
		// (set) Token: 0x06037ADE RID: 228062 RVA: 0x00775F12 File Offset: 0x00774112
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E77C RID: 59260
		// (get) Token: 0x06037ADF RID: 228063 RVA: 0x00775F1B File Offset: 0x0077411B
		// (set) Token: 0x06037AE0 RID: 228064 RVA: 0x00775F23 File Offset: 0x00774123
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E77D RID: 59261
		// (get) Token: 0x06037AE1 RID: 228065 RVA: 0x00775F2C File Offset: 0x0077412C
		// (set) Token: 0x06037AE2 RID: 228066 RVA: 0x00775F34 File Offset: 0x00774134
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E77E RID: 59262
		// (get) Token: 0x06037AE3 RID: 228067 RVA: 0x00775F3D File Offset: 0x0077413D
		// (set) Token: 0x06037AE4 RID: 228068 RVA: 0x00775F45 File Offset: 0x00774145
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E77F RID: 59263
		// (get) Token: 0x06037AE5 RID: 228069 RVA: 0x00775F4E File Offset: 0x0077414E
		// (set) Token: 0x06037AE6 RID: 228070 RVA: 0x00775F56 File Offset: 0x00774156
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E780 RID: 59264
		// (get) Token: 0x06037AE7 RID: 228071 RVA: 0x00775F5F File Offset: 0x0077415F
		// (set) Token: 0x06037AE8 RID: 228072 RVA: 0x00775F67 File Offset: 0x00774167
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E781 RID: 59265
		// (get) Token: 0x06037AE9 RID: 228073 RVA: 0x00775F70 File Offset: 0x00774170
		// (set) Token: 0x06037AEA RID: 228074 RVA: 0x00775F78 File Offset: 0x00774178
		public uint NullMask { get; set; }

		// Token: 0x06037AEB RID: 228075 RVA: 0x00775F84 File Offset: 0x00774184
		public ITalkItemAvgOptionT()
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
