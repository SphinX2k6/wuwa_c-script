using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AEF RID: 31471
	public class ITalkItemVisualNovelOptionT
	{
		// Token: 0x1700EB3A RID: 60218
		// (get) Token: 0x060388C9 RID: 231625 RVA: 0x007A449F File Offset: 0x007A269F
		// (set) Token: 0x060388CA RID: 231626 RVA: 0x007A44A7 File Offset: 0x007A26A7
		public ETalkItemType Type { get; set; }

		// Token: 0x1700EB3B RID: 60219
		// (get) Token: 0x060388CB RID: 231627 RVA: 0x007A44B0 File Offset: 0x007A26B0
		// (set) Token: 0x060388CC RID: 231628 RVA: 0x007A44B8 File Offset: 0x007A26B8
		public int Id { get; set; }

		// Token: 0x1700EB3C RID: 60220
		// (get) Token: 0x060388CD RID: 231629 RVA: 0x007A44C1 File Offset: 0x007A26C1
		// (set) Token: 0x060388CE RID: 231630 RVA: 0x007A44C9 File Offset: 0x007A26C9
		public int PlotLineId { get; set; }

		// Token: 0x1700EB3D RID: 60221
		// (get) Token: 0x060388CF RID: 231631 RVA: 0x007A44D2 File Offset: 0x007A26D2
		// (set) Token: 0x060388D0 RID: 231632 RVA: 0x007A44DA File Offset: 0x007A26DA
		public string PlotLineKey { get; set; }

		// Token: 0x1700EB3E RID: 60222
		// (get) Token: 0x060388D1 RID: 231633 RVA: 0x007A44E3 File Offset: 0x007A26E3
		// (set) Token: 0x060388D2 RID: 231634 RVA: 0x007A44EB File Offset: 0x007A26EB
		public string Name { get; set; }

		// Token: 0x1700EB3F RID: 60223
		// (get) Token: 0x060388D3 RID: 231635 RVA: 0x007A44F4 File Offset: 0x007A26F4
		// (set) Token: 0x060388D4 RID: 231636 RVA: 0x007A44FC File Offset: 0x007A26FC
		public bool _Folded { get; set; }

		// Token: 0x1700EB40 RID: 60224
		// (get) Token: 0x060388D5 RID: 231637 RVA: 0x007A4505 File Offset: 0x007A2705
		// (set) Token: 0x060388D6 RID: 231638 RVA: 0x007A450D File Offset: 0x007A270D
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700EB41 RID: 60225
		// (get) Token: 0x060388D7 RID: 231639 RVA: 0x007A4516 File Offset: 0x007A2716
		// (set) Token: 0x060388D8 RID: 231640 RVA: 0x007A451E File Offset: 0x007A271E
		public int WhoId { get; set; }

		// Token: 0x1700EB42 RID: 60226
		// (get) Token: 0x060388D9 RID: 231641 RVA: 0x007A4527 File Offset: 0x007A2727
		// (set) Token: 0x060388DA RID: 231642 RVA: 0x007A452F File Offset: 0x007A272F
		public int TextId { get; set; }

		// Token: 0x1700EB43 RID: 60227
		// (get) Token: 0x060388DB RID: 231643 RVA: 0x007A4538 File Offset: 0x007A2738
		// (set) Token: 0x060388DC RID: 231644 RVA: 0x007A4540 File Offset: 0x007A2740
		public string TidTalk { get; set; }

		// Token: 0x1700EB44 RID: 60228
		// (get) Token: 0x060388DD RID: 231645 RVA: 0x007A4549 File Offset: 0x007A2749
		// (set) Token: 0x060388DE RID: 231646 RVA: 0x007A4551 File Offset: 0x007A2751
		public float WaitTime { get; set; }

		// Token: 0x1700EB45 RID: 60229
		// (get) Token: 0x060388DF RID: 231647 RVA: 0x007A455A File Offset: 0x007A275A
		// (set) Token: 0x060388E0 RID: 231648 RVA: 0x007A4562 File Offset: 0x007A2762
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700EB46 RID: 60230
		// (get) Token: 0x060388E1 RID: 231649 RVA: 0x007A456B File Offset: 0x007A276B
		// (set) Token: 0x060388E2 RID: 231650 RVA: 0x007A4573 File Offset: 0x007A2773
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700EB47 RID: 60231
		// (get) Token: 0x060388E3 RID: 231651 RVA: 0x007A457C File Offset: 0x007A277C
		// (set) Token: 0x060388E4 RID: 231652 RVA: 0x007A4584 File Offset: 0x007A2784
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700EB48 RID: 60232
		// (get) Token: 0x060388E5 RID: 231653 RVA: 0x007A458D File Offset: 0x007A278D
		// (set) Token: 0x060388E6 RID: 231654 RVA: 0x007A4595 File Offset: 0x007A2795
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700EB49 RID: 60233
		// (get) Token: 0x060388E7 RID: 231655 RVA: 0x007A459E File Offset: 0x007A279E
		// (set) Token: 0x060388E8 RID: 231656 RVA: 0x007A45A6 File Offset: 0x007A27A6
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700EB4A RID: 60234
		// (get) Token: 0x060388E9 RID: 231657 RVA: 0x007A45AF File Offset: 0x007A27AF
		// (set) Token: 0x060388EA RID: 231658 RVA: 0x007A45B7 File Offset: 0x007A27B7
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700EB4B RID: 60235
		// (get) Token: 0x060388EB RID: 231659 RVA: 0x007A45C0 File Offset: 0x007A27C0
		// (set) Token: 0x060388EC RID: 231660 RVA: 0x007A45C8 File Offset: 0x007A27C8
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700EB4C RID: 60236
		// (get) Token: 0x060388ED RID: 231661 RVA: 0x007A45D1 File Offset: 0x007A27D1
		// (set) Token: 0x060388EE RID: 231662 RVA: 0x007A45D9 File Offset: 0x007A27D9
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700EB4D RID: 60237
		// (get) Token: 0x060388EF RID: 231663 RVA: 0x007A45E2 File Offset: 0x007A27E2
		// (set) Token: 0x060388F0 RID: 231664 RVA: 0x007A45EA File Offset: 0x007A27EA
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700EB4E RID: 60238
		// (get) Token: 0x060388F1 RID: 231665 RVA: 0x007A45F3 File Offset: 0x007A27F3
		// (set) Token: 0x060388F2 RID: 231666 RVA: 0x007A45FB File Offset: 0x007A27FB
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700EB4F RID: 60239
		// (get) Token: 0x060388F3 RID: 231667 RVA: 0x007A4604 File Offset: 0x007A2804
		// (set) Token: 0x060388F4 RID: 231668 RVA: 0x007A460C File Offset: 0x007A280C
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700EB50 RID: 60240
		// (get) Token: 0x060388F5 RID: 231669 RVA: 0x007A4615 File Offset: 0x007A2815
		// (set) Token: 0x060388F6 RID: 231670 RVA: 0x007A461D File Offset: 0x007A281D
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700EB51 RID: 60241
		// (get) Token: 0x060388F7 RID: 231671 RVA: 0x007A4626 File Offset: 0x007A2826
		// (set) Token: 0x060388F8 RID: 231672 RVA: 0x007A462E File Offset: 0x007A282E
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700EB52 RID: 60242
		// (get) Token: 0x060388F9 RID: 231673 RVA: 0x007A4637 File Offset: 0x007A2837
		// (set) Token: 0x060388FA RID: 231674 RVA: 0x007A463F File Offset: 0x007A283F
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700EB53 RID: 60243
		// (get) Token: 0x060388FB RID: 231675 RVA: 0x007A4648 File Offset: 0x007A2848
		// (set) Token: 0x060388FC RID: 231676 RVA: 0x007A4650 File Offset: 0x007A2850
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700EB54 RID: 60244
		// (get) Token: 0x060388FD RID: 231677 RVA: 0x007A4659 File Offset: 0x007A2859
		// (set) Token: 0x060388FE RID: 231678 RVA: 0x007A4661 File Offset: 0x007A2861
		public bool PlayVoice { get; set; }

		// Token: 0x1700EB55 RID: 60245
		// (get) Token: 0x060388FF RID: 231679 RVA: 0x007A466A File Offset: 0x007A286A
		// (set) Token: 0x06038900 RID: 231680 RVA: 0x007A4672 File Offset: 0x007A2872
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700EB56 RID: 60246
		// (get) Token: 0x06038901 RID: 231681 RVA: 0x007A467B File Offset: 0x007A287B
		// (set) Token: 0x06038902 RID: 231682 RVA: 0x007A4683 File Offset: 0x007A2883
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700EB57 RID: 60247
		// (get) Token: 0x06038903 RID: 231683 RVA: 0x007A468C File Offset: 0x007A288C
		// (set) Token: 0x06038904 RID: 231684 RVA: 0x007A4694 File Offset: 0x007A2894
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700EB58 RID: 60248
		// (get) Token: 0x06038905 RID: 231685 RVA: 0x007A469D File Offset: 0x007A289D
		// (set) Token: 0x06038906 RID: 231686 RVA: 0x007A46A5 File Offset: 0x007A28A5
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700EB59 RID: 60249
		// (get) Token: 0x06038907 RID: 231687 RVA: 0x007A46AE File Offset: 0x007A28AE
		// (set) Token: 0x06038908 RID: 231688 RVA: 0x007A46B6 File Offset: 0x007A28B6
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700EB5A RID: 60250
		// (get) Token: 0x06038909 RID: 231689 RVA: 0x007A46BF File Offset: 0x007A28BF
		// (set) Token: 0x0603890A RID: 231690 RVA: 0x007A46C7 File Offset: 0x007A28C7
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700EB5B RID: 60251
		// (get) Token: 0x0603890B RID: 231691 RVA: 0x007A46D0 File Offset: 0x007A28D0
		// (set) Token: 0x0603890C RID: 231692 RVA: 0x007A46D8 File Offset: 0x007A28D8
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700EB5C RID: 60252
		// (get) Token: 0x0603890D RID: 231693 RVA: 0x007A46E1 File Offset: 0x007A28E1
		// (set) Token: 0x0603890E RID: 231694 RVA: 0x007A46E9 File Offset: 0x007A28E9
		public TVisualNovelOptionGroupConfigUnion OptionGroup { get; set; }

		// Token: 0x1700EB5D RID: 60253
		// (get) Token: 0x0603890F RID: 231695 RVA: 0x007A46F2 File Offset: 0x007A28F2
		// (set) Token: 0x06038910 RID: 231696 RVA: 0x007A46FA File Offset: 0x007A28FA
		public string TidCustomDescText { get; set; }

		// Token: 0x1700EB5E RID: 60254
		// (get) Token: 0x06038911 RID: 231697 RVA: 0x007A4703 File Offset: 0x007A2903
		// (set) Token: 0x06038912 RID: 231698 RVA: 0x007A470B File Offset: 0x007A290B
		public TVisualNovelBackgroundUnion VisualNovelBackgroundConfig { get; set; }

		// Token: 0x1700EB5F RID: 60255
		// (get) Token: 0x06038913 RID: 231699 RVA: 0x007A4714 File Offset: 0x007A2914
		// (set) Token: 0x06038914 RID: 231700 RVA: 0x007A471C File Offset: 0x007A291C
		public TVisualNovelCgUnion CgConfig { get; set; }

		// Token: 0x1700EB60 RID: 60256
		// (get) Token: 0x06038915 RID: 231701 RVA: 0x007A4725 File Offset: 0x007A2925
		// (set) Token: 0x06038916 RID: 231702 RVA: 0x007A472D File Offset: 0x007A292D
		public TVisualNovelDisplayItemUnion DisplayItemConfig { get; set; }

		// Token: 0x1700EB61 RID: 60257
		// (get) Token: 0x06038917 RID: 231703 RVA: 0x007A4736 File Offset: 0x007A2936
		// (set) Token: 0x06038918 RID: 231704 RVA: 0x007A473E File Offset: 0x007A293E
		public int PlotKeyId { get; set; }

		// Token: 0x1700EB62 RID: 60258
		// (get) Token: 0x06038919 RID: 231705 RVA: 0x007A4747 File Offset: 0x007A2947
		// (set) Token: 0x0603891A RID: 231706 RVA: 0x007A474F File Offset: 0x007A294F
		public uint NullMask { get; set; }

		// Token: 0x0603891B RID: 231707 RVA: 0x007A4758 File Offset: 0x007A2958
		public ITalkItemVisualNovelOptionT()
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
			this.TidCustomDescText = null;
			this.VisualNovelBackgroundConfig = null;
			this.CgConfig = null;
			this.DisplayItemConfig = null;
			this.PlotKeyId = 0;
			this.NullMask = 0U;
		}
	}
}
