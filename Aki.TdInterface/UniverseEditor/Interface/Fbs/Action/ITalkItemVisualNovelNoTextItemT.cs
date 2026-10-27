using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007314 RID: 29460
	public class ITalkItemVisualNovelNoTextItemT
	{
		// Token: 0x1700DEE7 RID: 57063
		// (get) Token: 0x0603546D RID: 218221 RVA: 0x0073EAC8 File Offset: 0x0073CCC8
		// (set) Token: 0x0603546E RID: 218222 RVA: 0x0073EAD0 File Offset: 0x0073CCD0
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DEE8 RID: 57064
		// (get) Token: 0x0603546F RID: 218223 RVA: 0x0073EAD9 File Offset: 0x0073CCD9
		// (set) Token: 0x06035470 RID: 218224 RVA: 0x0073EAE1 File Offset: 0x0073CCE1
		public int Id { get; set; }

		// Token: 0x1700DEE9 RID: 57065
		// (get) Token: 0x06035471 RID: 218225 RVA: 0x0073EAEA File Offset: 0x0073CCEA
		// (set) Token: 0x06035472 RID: 218226 RVA: 0x0073EAF2 File Offset: 0x0073CCF2
		public int PlotLineId { get; set; }

		// Token: 0x1700DEEA RID: 57066
		// (get) Token: 0x06035473 RID: 218227 RVA: 0x0073EAFB File Offset: 0x0073CCFB
		// (set) Token: 0x06035474 RID: 218228 RVA: 0x0073EB03 File Offset: 0x0073CD03
		public string PlotLineKey { get; set; }

		// Token: 0x1700DEEB RID: 57067
		// (get) Token: 0x06035475 RID: 218229 RVA: 0x0073EB0C File Offset: 0x0073CD0C
		// (set) Token: 0x06035476 RID: 218230 RVA: 0x0073EB14 File Offset: 0x0073CD14
		public string Name { get; set; }

		// Token: 0x1700DEEC RID: 57068
		// (get) Token: 0x06035477 RID: 218231 RVA: 0x0073EB1D File Offset: 0x0073CD1D
		// (set) Token: 0x06035478 RID: 218232 RVA: 0x0073EB25 File Offset: 0x0073CD25
		public bool _Folded { get; set; }

		// Token: 0x1700DEED RID: 57069
		// (get) Token: 0x06035479 RID: 218233 RVA: 0x0073EB2E File Offset: 0x0073CD2E
		// (set) Token: 0x0603547A RID: 218234 RVA: 0x0073EB36 File Offset: 0x0073CD36
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DEEE RID: 57070
		// (get) Token: 0x0603547B RID: 218235 RVA: 0x0073EB3F File Offset: 0x0073CD3F
		// (set) Token: 0x0603547C RID: 218236 RVA: 0x0073EB47 File Offset: 0x0073CD47
		public int WhoId { get; set; }

		// Token: 0x1700DEEF RID: 57071
		// (get) Token: 0x0603547D RID: 218237 RVA: 0x0073EB50 File Offset: 0x0073CD50
		// (set) Token: 0x0603547E RID: 218238 RVA: 0x0073EB58 File Offset: 0x0073CD58
		public int TextId { get; set; }

		// Token: 0x1700DEF0 RID: 57072
		// (get) Token: 0x0603547F RID: 218239 RVA: 0x0073EB61 File Offset: 0x0073CD61
		// (set) Token: 0x06035480 RID: 218240 RVA: 0x0073EB69 File Offset: 0x0073CD69
		public string TidTalk { get; set; }

		// Token: 0x1700DEF1 RID: 57073
		// (get) Token: 0x06035481 RID: 218241 RVA: 0x0073EB72 File Offset: 0x0073CD72
		// (set) Token: 0x06035482 RID: 218242 RVA: 0x0073EB7A File Offset: 0x0073CD7A
		public float WaitTime { get; set; }

		// Token: 0x1700DEF2 RID: 57074
		// (get) Token: 0x06035483 RID: 218243 RVA: 0x0073EB83 File Offset: 0x0073CD83
		// (set) Token: 0x06035484 RID: 218244 RVA: 0x0073EB8B File Offset: 0x0073CD8B
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DEF3 RID: 57075
		// (get) Token: 0x06035485 RID: 218245 RVA: 0x0073EB94 File Offset: 0x0073CD94
		// (set) Token: 0x06035486 RID: 218246 RVA: 0x0073EB9C File Offset: 0x0073CD9C
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DEF4 RID: 57076
		// (get) Token: 0x06035487 RID: 218247 RVA: 0x0073EBA5 File Offset: 0x0073CDA5
		// (set) Token: 0x06035488 RID: 218248 RVA: 0x0073EBAD File Offset: 0x0073CDAD
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DEF5 RID: 57077
		// (get) Token: 0x06035489 RID: 218249 RVA: 0x0073EBB6 File Offset: 0x0073CDB6
		// (set) Token: 0x0603548A RID: 218250 RVA: 0x0073EBBE File Offset: 0x0073CDBE
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DEF6 RID: 57078
		// (get) Token: 0x0603548B RID: 218251 RVA: 0x0073EBC7 File Offset: 0x0073CDC7
		// (set) Token: 0x0603548C RID: 218252 RVA: 0x0073EBCF File Offset: 0x0073CDCF
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DEF7 RID: 57079
		// (get) Token: 0x0603548D RID: 218253 RVA: 0x0073EBD8 File Offset: 0x0073CDD8
		// (set) Token: 0x0603548E RID: 218254 RVA: 0x0073EBE0 File Offset: 0x0073CDE0
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DEF8 RID: 57080
		// (get) Token: 0x0603548F RID: 218255 RVA: 0x0073EBE9 File Offset: 0x0073CDE9
		// (set) Token: 0x06035490 RID: 218256 RVA: 0x0073EBF1 File Offset: 0x0073CDF1
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DEF9 RID: 57081
		// (get) Token: 0x06035491 RID: 218257 RVA: 0x0073EBFA File Offset: 0x0073CDFA
		// (set) Token: 0x06035492 RID: 218258 RVA: 0x0073EC02 File Offset: 0x0073CE02
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DEFA RID: 57082
		// (get) Token: 0x06035493 RID: 218259 RVA: 0x0073EC0B File Offset: 0x0073CE0B
		// (set) Token: 0x06035494 RID: 218260 RVA: 0x0073EC13 File Offset: 0x0073CE13
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DEFB RID: 57083
		// (get) Token: 0x06035495 RID: 218261 RVA: 0x0073EC1C File Offset: 0x0073CE1C
		// (set) Token: 0x06035496 RID: 218262 RVA: 0x0073EC24 File Offset: 0x0073CE24
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DEFC RID: 57084
		// (get) Token: 0x06035497 RID: 218263 RVA: 0x0073EC2D File Offset: 0x0073CE2D
		// (set) Token: 0x06035498 RID: 218264 RVA: 0x0073EC35 File Offset: 0x0073CE35
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DEFD RID: 57085
		// (get) Token: 0x06035499 RID: 218265 RVA: 0x0073EC3E File Offset: 0x0073CE3E
		// (set) Token: 0x0603549A RID: 218266 RVA: 0x0073EC46 File Offset: 0x0073CE46
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DEFE RID: 57086
		// (get) Token: 0x0603549B RID: 218267 RVA: 0x0073EC4F File Offset: 0x0073CE4F
		// (set) Token: 0x0603549C RID: 218268 RVA: 0x0073EC57 File Offset: 0x0073CE57
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DEFF RID: 57087
		// (get) Token: 0x0603549D RID: 218269 RVA: 0x0073EC60 File Offset: 0x0073CE60
		// (set) Token: 0x0603549E RID: 218270 RVA: 0x0073EC68 File Offset: 0x0073CE68
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DF00 RID: 57088
		// (get) Token: 0x0603549F RID: 218271 RVA: 0x0073EC71 File Offset: 0x0073CE71
		// (set) Token: 0x060354A0 RID: 218272 RVA: 0x0073EC79 File Offset: 0x0073CE79
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DF01 RID: 57089
		// (get) Token: 0x060354A1 RID: 218273 RVA: 0x0073EC82 File Offset: 0x0073CE82
		// (set) Token: 0x060354A2 RID: 218274 RVA: 0x0073EC8A File Offset: 0x0073CE8A
		public bool PlayVoice { get; set; }

		// Token: 0x1700DF02 RID: 57090
		// (get) Token: 0x060354A3 RID: 218275 RVA: 0x0073EC93 File Offset: 0x0073CE93
		// (set) Token: 0x060354A4 RID: 218276 RVA: 0x0073EC9B File Offset: 0x0073CE9B
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DF03 RID: 57091
		// (get) Token: 0x060354A5 RID: 218277 RVA: 0x0073ECA4 File Offset: 0x0073CEA4
		// (set) Token: 0x060354A6 RID: 218278 RVA: 0x0073ECAC File Offset: 0x0073CEAC
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DF04 RID: 57092
		// (get) Token: 0x060354A7 RID: 218279 RVA: 0x0073ECB5 File Offset: 0x0073CEB5
		// (set) Token: 0x060354A8 RID: 218280 RVA: 0x0073ECBD File Offset: 0x0073CEBD
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DF05 RID: 57093
		// (get) Token: 0x060354A9 RID: 218281 RVA: 0x0073ECC6 File Offset: 0x0073CEC6
		// (set) Token: 0x060354AA RID: 218282 RVA: 0x0073ECCE File Offset: 0x0073CECE
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DF06 RID: 57094
		// (get) Token: 0x060354AB RID: 218283 RVA: 0x0073ECD7 File Offset: 0x0073CED7
		// (set) Token: 0x060354AC RID: 218284 RVA: 0x0073ECDF File Offset: 0x0073CEDF
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DF07 RID: 57095
		// (get) Token: 0x060354AD RID: 218285 RVA: 0x0073ECE8 File Offset: 0x0073CEE8
		// (set) Token: 0x060354AE RID: 218286 RVA: 0x0073ECF0 File Offset: 0x0073CEF0
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DF08 RID: 57096
		// (get) Token: 0x060354AF RID: 218287 RVA: 0x0073ECF9 File Offset: 0x0073CEF9
		// (set) Token: 0x060354B0 RID: 218288 RVA: 0x0073ED01 File Offset: 0x0073CF01
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700DF09 RID: 57097
		// (get) Token: 0x060354B1 RID: 218289 RVA: 0x0073ED0A File Offset: 0x0073CF0A
		// (set) Token: 0x060354B2 RID: 218290 RVA: 0x0073ED12 File Offset: 0x0073CF12
		public IVisualNovelOptionGroupSolarSchoolExamT OptionGroup { get; set; }

		// Token: 0x1700DF0A RID: 57098
		// (get) Token: 0x060354B3 RID: 218291 RVA: 0x0073ED1B File Offset: 0x0073CF1B
		// (set) Token: 0x060354B4 RID: 218292 RVA: 0x0073ED23 File Offset: 0x0073CF23
		public TVisualNovelBackgroundUnion VisualNovelBackgroundConfig { get; set; }

		// Token: 0x1700DF0B RID: 57099
		// (get) Token: 0x060354B5 RID: 218293 RVA: 0x0073ED2C File Offset: 0x0073CF2C
		// (set) Token: 0x060354B6 RID: 218294 RVA: 0x0073ED34 File Offset: 0x0073CF34
		public TVisualNovelCgUnion CgConfig { get; set; }

		// Token: 0x1700DF0C RID: 57100
		// (get) Token: 0x060354B7 RID: 218295 RVA: 0x0073ED3D File Offset: 0x0073CF3D
		// (set) Token: 0x060354B8 RID: 218296 RVA: 0x0073ED45 File Offset: 0x0073CF45
		public TVisualNovelDisplayItemUnion DisplayItemConfig { get; set; }

		// Token: 0x1700DF0D RID: 57101
		// (get) Token: 0x060354B9 RID: 218297 RVA: 0x0073ED4E File Offset: 0x0073CF4E
		// (set) Token: 0x060354BA RID: 218298 RVA: 0x0073ED56 File Offset: 0x0073CF56
		public int PlotKeyId { get; set; }

		// Token: 0x1700DF0E RID: 57102
		// (get) Token: 0x060354BB RID: 218299 RVA: 0x0073ED5F File Offset: 0x0073CF5F
		// (set) Token: 0x060354BC RID: 218300 RVA: 0x0073ED67 File Offset: 0x0073CF67
		public List<TVisualNovelPerformanceUnion> StartPerformances { get; set; }

		// Token: 0x1700DF0F RID: 57103
		// (get) Token: 0x060354BD RID: 218301 RVA: 0x0073ED70 File Offset: 0x0073CF70
		// (set) Token: 0x060354BE RID: 218302 RVA: 0x0073ED78 File Offset: 0x0073CF78
		public List<TVisualNovelPerformanceUnion> EndPerformances { get; set; }

		// Token: 0x1700DF10 RID: 57104
		// (get) Token: 0x060354BF RID: 218303 RVA: 0x0073ED81 File Offset: 0x0073CF81
		// (set) Token: 0x060354C0 RID: 218304 RVA: 0x0073ED89 File Offset: 0x0073CF89
		public uint NullMask { get; set; }

		// Token: 0x060354C1 RID: 218305 RVA: 0x0073ED94 File Offset: 0x0073CF94
		public ITalkItemVisualNovelNoTextItemT()
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
