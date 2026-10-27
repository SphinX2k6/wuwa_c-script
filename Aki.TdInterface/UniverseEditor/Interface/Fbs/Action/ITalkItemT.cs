using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BD RID: 29373
	public class ITalkItemT
	{
		// Token: 0x1700DA00 RID: 55808
		// (get) Token: 0x0603429E RID: 213662 RVA: 0x00704007 File Offset: 0x00702207
		// (set) Token: 0x0603429F RID: 213663 RVA: 0x0070400F File Offset: 0x0070220F
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DA01 RID: 55809
		// (get) Token: 0x060342A0 RID: 213664 RVA: 0x00704018 File Offset: 0x00702218
		// (set) Token: 0x060342A1 RID: 213665 RVA: 0x00704020 File Offset: 0x00702220
		public int Id { get; set; }

		// Token: 0x1700DA02 RID: 55810
		// (get) Token: 0x060342A2 RID: 213666 RVA: 0x00704029 File Offset: 0x00702229
		// (set) Token: 0x060342A3 RID: 213667 RVA: 0x00704031 File Offset: 0x00702231
		public int PlotLineId { get; set; }

		// Token: 0x1700DA03 RID: 55811
		// (get) Token: 0x060342A4 RID: 213668 RVA: 0x0070403A File Offset: 0x0070223A
		// (set) Token: 0x060342A5 RID: 213669 RVA: 0x00704042 File Offset: 0x00702242
		public string PlotLineKey { get; set; }

		// Token: 0x1700DA04 RID: 55812
		// (get) Token: 0x060342A6 RID: 213670 RVA: 0x0070404B File Offset: 0x0070224B
		// (set) Token: 0x060342A7 RID: 213671 RVA: 0x00704053 File Offset: 0x00702253
		public string Name { get; set; }

		// Token: 0x1700DA05 RID: 55813
		// (get) Token: 0x060342A8 RID: 213672 RVA: 0x0070405C File Offset: 0x0070225C
		// (set) Token: 0x060342A9 RID: 213673 RVA: 0x00704064 File Offset: 0x00702264
		public bool _Folded { get; set; }

		// Token: 0x1700DA06 RID: 55814
		// (get) Token: 0x060342AA RID: 213674 RVA: 0x0070406D File Offset: 0x0070226D
		// (set) Token: 0x060342AB RID: 213675 RVA: 0x00704075 File Offset: 0x00702275
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DA07 RID: 55815
		// (get) Token: 0x060342AC RID: 213676 RVA: 0x0070407E File Offset: 0x0070227E
		// (set) Token: 0x060342AD RID: 213677 RVA: 0x00704086 File Offset: 0x00702286
		public int WhoId { get; set; }

		// Token: 0x1700DA08 RID: 55816
		// (get) Token: 0x060342AE RID: 213678 RVA: 0x0070408F File Offset: 0x0070228F
		// (set) Token: 0x060342AF RID: 213679 RVA: 0x00704097 File Offset: 0x00702297
		public int TextId { get; set; }

		// Token: 0x1700DA09 RID: 55817
		// (get) Token: 0x060342B0 RID: 213680 RVA: 0x007040A0 File Offset: 0x007022A0
		// (set) Token: 0x060342B1 RID: 213681 RVA: 0x007040A8 File Offset: 0x007022A8
		public string TidTalk { get; set; }

		// Token: 0x1700DA0A RID: 55818
		// (get) Token: 0x060342B2 RID: 213682 RVA: 0x007040B1 File Offset: 0x007022B1
		// (set) Token: 0x060342B3 RID: 213683 RVA: 0x007040B9 File Offset: 0x007022B9
		public float WaitTime { get; set; }

		// Token: 0x1700DA0B RID: 55819
		// (get) Token: 0x060342B4 RID: 213684 RVA: 0x007040C2 File Offset: 0x007022C2
		// (set) Token: 0x060342B5 RID: 213685 RVA: 0x007040CA File Offset: 0x007022CA
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DA0C RID: 55820
		// (get) Token: 0x060342B6 RID: 213686 RVA: 0x007040D3 File Offset: 0x007022D3
		// (set) Token: 0x060342B7 RID: 213687 RVA: 0x007040DB File Offset: 0x007022DB
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DA0D RID: 55821
		// (get) Token: 0x060342B8 RID: 213688 RVA: 0x007040E4 File Offset: 0x007022E4
		// (set) Token: 0x060342B9 RID: 213689 RVA: 0x007040EC File Offset: 0x007022EC
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DA0E RID: 55822
		// (get) Token: 0x060342BA RID: 213690 RVA: 0x007040F5 File Offset: 0x007022F5
		// (set) Token: 0x060342BB RID: 213691 RVA: 0x007040FD File Offset: 0x007022FD
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DA0F RID: 55823
		// (get) Token: 0x060342BC RID: 213692 RVA: 0x00704106 File Offset: 0x00702306
		// (set) Token: 0x060342BD RID: 213693 RVA: 0x0070410E File Offset: 0x0070230E
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DA10 RID: 55824
		// (get) Token: 0x060342BE RID: 213694 RVA: 0x00704117 File Offset: 0x00702317
		// (set) Token: 0x060342BF RID: 213695 RVA: 0x0070411F File Offset: 0x0070231F
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DA11 RID: 55825
		// (get) Token: 0x060342C0 RID: 213696 RVA: 0x00704128 File Offset: 0x00702328
		// (set) Token: 0x060342C1 RID: 213697 RVA: 0x00704130 File Offset: 0x00702330
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DA12 RID: 55826
		// (get) Token: 0x060342C2 RID: 213698 RVA: 0x00704139 File Offset: 0x00702339
		// (set) Token: 0x060342C3 RID: 213699 RVA: 0x00704141 File Offset: 0x00702341
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DA13 RID: 55827
		// (get) Token: 0x060342C4 RID: 213700 RVA: 0x0070414A File Offset: 0x0070234A
		// (set) Token: 0x060342C5 RID: 213701 RVA: 0x00704152 File Offset: 0x00702352
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DA14 RID: 55828
		// (get) Token: 0x060342C6 RID: 213702 RVA: 0x0070415B File Offset: 0x0070235B
		// (set) Token: 0x060342C7 RID: 213703 RVA: 0x00704163 File Offset: 0x00702363
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DA15 RID: 55829
		// (get) Token: 0x060342C8 RID: 213704 RVA: 0x0070416C File Offset: 0x0070236C
		// (set) Token: 0x060342C9 RID: 213705 RVA: 0x00704174 File Offset: 0x00702374
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DA16 RID: 55830
		// (get) Token: 0x060342CA RID: 213706 RVA: 0x0070417D File Offset: 0x0070237D
		// (set) Token: 0x060342CB RID: 213707 RVA: 0x00704185 File Offset: 0x00702385
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DA17 RID: 55831
		// (get) Token: 0x060342CC RID: 213708 RVA: 0x0070418E File Offset: 0x0070238E
		// (set) Token: 0x060342CD RID: 213709 RVA: 0x00704196 File Offset: 0x00702396
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DA18 RID: 55832
		// (get) Token: 0x060342CE RID: 213710 RVA: 0x0070419F File Offset: 0x0070239F
		// (set) Token: 0x060342CF RID: 213711 RVA: 0x007041A7 File Offset: 0x007023A7
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DA19 RID: 55833
		// (get) Token: 0x060342D0 RID: 213712 RVA: 0x007041B0 File Offset: 0x007023B0
		// (set) Token: 0x060342D1 RID: 213713 RVA: 0x007041B8 File Offset: 0x007023B8
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DA1A RID: 55834
		// (get) Token: 0x060342D2 RID: 213714 RVA: 0x007041C1 File Offset: 0x007023C1
		// (set) Token: 0x060342D3 RID: 213715 RVA: 0x007041C9 File Offset: 0x007023C9
		public bool PlayVoice { get; set; }

		// Token: 0x1700DA1B RID: 55835
		// (get) Token: 0x060342D4 RID: 213716 RVA: 0x007041D2 File Offset: 0x007023D2
		// (set) Token: 0x060342D5 RID: 213717 RVA: 0x007041DA File Offset: 0x007023DA
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DA1C RID: 55836
		// (get) Token: 0x060342D6 RID: 213718 RVA: 0x007041E3 File Offset: 0x007023E3
		// (set) Token: 0x060342D7 RID: 213719 RVA: 0x007041EB File Offset: 0x007023EB
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DA1D RID: 55837
		// (get) Token: 0x060342D8 RID: 213720 RVA: 0x007041F4 File Offset: 0x007023F4
		// (set) Token: 0x060342D9 RID: 213721 RVA: 0x007041FC File Offset: 0x007023FC
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DA1E RID: 55838
		// (get) Token: 0x060342DA RID: 213722 RVA: 0x00704205 File Offset: 0x00702405
		// (set) Token: 0x060342DB RID: 213723 RVA: 0x0070420D File Offset: 0x0070240D
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DA1F RID: 55839
		// (get) Token: 0x060342DC RID: 213724 RVA: 0x00704216 File Offset: 0x00702416
		// (set) Token: 0x060342DD RID: 213725 RVA: 0x0070421E File Offset: 0x0070241E
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DA20 RID: 55840
		// (get) Token: 0x060342DE RID: 213726 RVA: 0x00704227 File Offset: 0x00702427
		// (set) Token: 0x060342DF RID: 213727 RVA: 0x0070422F File Offset: 0x0070242F
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DA21 RID: 55841
		// (get) Token: 0x060342E0 RID: 213728 RVA: 0x00704238 File Offset: 0x00702438
		// (set) Token: 0x060342E1 RID: 213729 RVA: 0x00704240 File Offset: 0x00702440
		public uint NullMask { get; set; }

		// Token: 0x060342E2 RID: 213730 RVA: 0x0070424C File Offset: 0x0070244C
		public ITalkItemT()
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
