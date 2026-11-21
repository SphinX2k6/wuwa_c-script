using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AEC RID: 31468
	public class ITalkItemVisualNovelNoTextItemT
	{
		// Token: 0x1700EAE5 RID: 60133
		// (get) Token: 0x0603879C RID: 231324 RVA: 0x007A0549 File Offset: 0x0079E749
		// (set) Token: 0x0603879D RID: 231325 RVA: 0x007A0551 File Offset: 0x0079E751
		public ETalkItemType Type { get; set; }

		// Token: 0x1700EAE6 RID: 60134
		// (get) Token: 0x0603879E RID: 231326 RVA: 0x007A055A File Offset: 0x0079E75A
		// (set) Token: 0x0603879F RID: 231327 RVA: 0x007A0562 File Offset: 0x0079E762
		public int Id { get; set; }

		// Token: 0x1700EAE7 RID: 60135
		// (get) Token: 0x060387A0 RID: 231328 RVA: 0x007A056B File Offset: 0x0079E76B
		// (set) Token: 0x060387A1 RID: 231329 RVA: 0x007A0573 File Offset: 0x0079E773
		public int PlotLineId { get; set; }

		// Token: 0x1700EAE8 RID: 60136
		// (get) Token: 0x060387A2 RID: 231330 RVA: 0x007A057C File Offset: 0x0079E77C
		// (set) Token: 0x060387A3 RID: 231331 RVA: 0x007A0584 File Offset: 0x0079E784
		public string PlotLineKey { get; set; }

		// Token: 0x1700EAE9 RID: 60137
		// (get) Token: 0x060387A4 RID: 231332 RVA: 0x007A058D File Offset: 0x0079E78D
		// (set) Token: 0x060387A5 RID: 231333 RVA: 0x007A0595 File Offset: 0x0079E795
		public string Name { get; set; }

		// Token: 0x1700EAEA RID: 60138
		// (get) Token: 0x060387A6 RID: 231334 RVA: 0x007A059E File Offset: 0x0079E79E
		// (set) Token: 0x060387A7 RID: 231335 RVA: 0x007A05A6 File Offset: 0x0079E7A6
		public bool _Folded { get; set; }

		// Token: 0x1700EAEB RID: 60139
		// (get) Token: 0x060387A8 RID: 231336 RVA: 0x007A05AF File Offset: 0x0079E7AF
		// (set) Token: 0x060387A9 RID: 231337 RVA: 0x007A05B7 File Offset: 0x0079E7B7
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700EAEC RID: 60140
		// (get) Token: 0x060387AA RID: 231338 RVA: 0x007A05C0 File Offset: 0x0079E7C0
		// (set) Token: 0x060387AB RID: 231339 RVA: 0x007A05C8 File Offset: 0x0079E7C8
		public int WhoId { get; set; }

		// Token: 0x1700EAED RID: 60141
		// (get) Token: 0x060387AC RID: 231340 RVA: 0x007A05D1 File Offset: 0x0079E7D1
		// (set) Token: 0x060387AD RID: 231341 RVA: 0x007A05D9 File Offset: 0x0079E7D9
		public int TextId { get; set; }

		// Token: 0x1700EAEE RID: 60142
		// (get) Token: 0x060387AE RID: 231342 RVA: 0x007A05E2 File Offset: 0x0079E7E2
		// (set) Token: 0x060387AF RID: 231343 RVA: 0x007A05EA File Offset: 0x0079E7EA
		public string TidTalk { get; set; }

		// Token: 0x1700EAEF RID: 60143
		// (get) Token: 0x060387B0 RID: 231344 RVA: 0x007A05F3 File Offset: 0x0079E7F3
		// (set) Token: 0x060387B1 RID: 231345 RVA: 0x007A05FB File Offset: 0x0079E7FB
		public float WaitTime { get; set; }

		// Token: 0x1700EAF0 RID: 60144
		// (get) Token: 0x060387B2 RID: 231346 RVA: 0x007A0604 File Offset: 0x0079E804
		// (set) Token: 0x060387B3 RID: 231347 RVA: 0x007A060C File Offset: 0x0079E80C
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700EAF1 RID: 60145
		// (get) Token: 0x060387B4 RID: 231348 RVA: 0x007A0615 File Offset: 0x0079E815
		// (set) Token: 0x060387B5 RID: 231349 RVA: 0x007A061D File Offset: 0x0079E81D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700EAF2 RID: 60146
		// (get) Token: 0x060387B6 RID: 231350 RVA: 0x007A0626 File Offset: 0x0079E826
		// (set) Token: 0x060387B7 RID: 231351 RVA: 0x007A062E File Offset: 0x0079E82E
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700EAF3 RID: 60147
		// (get) Token: 0x060387B8 RID: 231352 RVA: 0x007A0637 File Offset: 0x0079E837
		// (set) Token: 0x060387B9 RID: 231353 RVA: 0x007A063F File Offset: 0x0079E83F
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700EAF4 RID: 60148
		// (get) Token: 0x060387BA RID: 231354 RVA: 0x007A0648 File Offset: 0x0079E848
		// (set) Token: 0x060387BB RID: 231355 RVA: 0x007A0650 File Offset: 0x0079E850
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700EAF5 RID: 60149
		// (get) Token: 0x060387BC RID: 231356 RVA: 0x007A0659 File Offset: 0x0079E859
		// (set) Token: 0x060387BD RID: 231357 RVA: 0x007A0661 File Offset: 0x0079E861
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700EAF6 RID: 60150
		// (get) Token: 0x060387BE RID: 231358 RVA: 0x007A066A File Offset: 0x0079E86A
		// (set) Token: 0x060387BF RID: 231359 RVA: 0x007A0672 File Offset: 0x0079E872
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700EAF7 RID: 60151
		// (get) Token: 0x060387C0 RID: 231360 RVA: 0x007A067B File Offset: 0x0079E87B
		// (set) Token: 0x060387C1 RID: 231361 RVA: 0x007A0683 File Offset: 0x0079E883
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700EAF8 RID: 60152
		// (get) Token: 0x060387C2 RID: 231362 RVA: 0x007A068C File Offset: 0x0079E88C
		// (set) Token: 0x060387C3 RID: 231363 RVA: 0x007A0694 File Offset: 0x0079E894
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700EAF9 RID: 60153
		// (get) Token: 0x060387C4 RID: 231364 RVA: 0x007A069D File Offset: 0x0079E89D
		// (set) Token: 0x060387C5 RID: 231365 RVA: 0x007A06A5 File Offset: 0x0079E8A5
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700EAFA RID: 60154
		// (get) Token: 0x060387C6 RID: 231366 RVA: 0x007A06AE File Offset: 0x0079E8AE
		// (set) Token: 0x060387C7 RID: 231367 RVA: 0x007A06B6 File Offset: 0x0079E8B6
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700EAFB RID: 60155
		// (get) Token: 0x060387C8 RID: 231368 RVA: 0x007A06BF File Offset: 0x0079E8BF
		// (set) Token: 0x060387C9 RID: 231369 RVA: 0x007A06C7 File Offset: 0x0079E8C7
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700EAFC RID: 60156
		// (get) Token: 0x060387CA RID: 231370 RVA: 0x007A06D0 File Offset: 0x0079E8D0
		// (set) Token: 0x060387CB RID: 231371 RVA: 0x007A06D8 File Offset: 0x0079E8D8
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700EAFD RID: 60157
		// (get) Token: 0x060387CC RID: 231372 RVA: 0x007A06E1 File Offset: 0x0079E8E1
		// (set) Token: 0x060387CD RID: 231373 RVA: 0x007A06E9 File Offset: 0x0079E8E9
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700EAFE RID: 60158
		// (get) Token: 0x060387CE RID: 231374 RVA: 0x007A06F2 File Offset: 0x0079E8F2
		// (set) Token: 0x060387CF RID: 231375 RVA: 0x007A06FA File Offset: 0x0079E8FA
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700EAFF RID: 60159
		// (get) Token: 0x060387D0 RID: 231376 RVA: 0x007A0703 File Offset: 0x0079E903
		// (set) Token: 0x060387D1 RID: 231377 RVA: 0x007A070B File Offset: 0x0079E90B
		public bool PlayVoice { get; set; }

		// Token: 0x1700EB00 RID: 60160
		// (get) Token: 0x060387D2 RID: 231378 RVA: 0x007A0714 File Offset: 0x0079E914
		// (set) Token: 0x060387D3 RID: 231379 RVA: 0x007A071C File Offset: 0x0079E91C
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700EB01 RID: 60161
		// (get) Token: 0x060387D4 RID: 231380 RVA: 0x007A0725 File Offset: 0x0079E925
		// (set) Token: 0x060387D5 RID: 231381 RVA: 0x007A072D File Offset: 0x0079E92D
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700EB02 RID: 60162
		// (get) Token: 0x060387D6 RID: 231382 RVA: 0x007A0736 File Offset: 0x0079E936
		// (set) Token: 0x060387D7 RID: 231383 RVA: 0x007A073E File Offset: 0x0079E93E
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700EB03 RID: 60163
		// (get) Token: 0x060387D8 RID: 231384 RVA: 0x007A0747 File Offset: 0x0079E947
		// (set) Token: 0x060387D9 RID: 231385 RVA: 0x007A074F File Offset: 0x0079E94F
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700EB04 RID: 60164
		// (get) Token: 0x060387DA RID: 231386 RVA: 0x007A0758 File Offset: 0x0079E958
		// (set) Token: 0x060387DB RID: 231387 RVA: 0x007A0760 File Offset: 0x0079E960
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700EB05 RID: 60165
		// (get) Token: 0x060387DC RID: 231388 RVA: 0x007A0769 File Offset: 0x0079E969
		// (set) Token: 0x060387DD RID: 231389 RVA: 0x007A0771 File Offset: 0x0079E971
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700EB06 RID: 60166
		// (get) Token: 0x060387DE RID: 231390 RVA: 0x007A077A File Offset: 0x0079E97A
		// (set) Token: 0x060387DF RID: 231391 RVA: 0x007A0782 File Offset: 0x0079E982
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700EB07 RID: 60167
		// (get) Token: 0x060387E0 RID: 231392 RVA: 0x007A078B File Offset: 0x0079E98B
		// (set) Token: 0x060387E1 RID: 231393 RVA: 0x007A0793 File Offset: 0x0079E993
		public TVisualNovelOptionGroupConfigUnion OptionGroup { get; set; }

		// Token: 0x1700EB08 RID: 60168
		// (get) Token: 0x060387E2 RID: 231394 RVA: 0x007A079C File Offset: 0x0079E99C
		// (set) Token: 0x060387E3 RID: 231395 RVA: 0x007A07A4 File Offset: 0x0079E9A4
		public TVisualNovelBackgroundUnion VisualNovelBackgroundConfig { get; set; }

		// Token: 0x1700EB09 RID: 60169
		// (get) Token: 0x060387E4 RID: 231396 RVA: 0x007A07AD File Offset: 0x0079E9AD
		// (set) Token: 0x060387E5 RID: 231397 RVA: 0x007A07B5 File Offset: 0x0079E9B5
		public TVisualNovelCgUnion CgConfig { get; set; }

		// Token: 0x1700EB0A RID: 60170
		// (get) Token: 0x060387E6 RID: 231398 RVA: 0x007A07BE File Offset: 0x0079E9BE
		// (set) Token: 0x060387E7 RID: 231399 RVA: 0x007A07C6 File Offset: 0x0079E9C6
		public TVisualNovelDisplayItemUnion DisplayItemConfig { get; set; }

		// Token: 0x1700EB0B RID: 60171
		// (get) Token: 0x060387E8 RID: 231400 RVA: 0x007A07CF File Offset: 0x0079E9CF
		// (set) Token: 0x060387E9 RID: 231401 RVA: 0x007A07D7 File Offset: 0x0079E9D7
		public int PlotKeyId { get; set; }

		// Token: 0x1700EB0C RID: 60172
		// (get) Token: 0x060387EA RID: 231402 RVA: 0x007A07E0 File Offset: 0x0079E9E0
		// (set) Token: 0x060387EB RID: 231403 RVA: 0x007A07E8 File Offset: 0x0079E9E8
		public List<TVisualNovelPerformanceUnion> StartPerformances { get; set; }

		// Token: 0x1700EB0D RID: 60173
		// (get) Token: 0x060387EC RID: 231404 RVA: 0x007A07F1 File Offset: 0x0079E9F1
		// (set) Token: 0x060387ED RID: 231405 RVA: 0x007A07F9 File Offset: 0x0079E9F9
		public List<TVisualNovelPerformanceUnion> EndPerformances { get; set; }

		// Token: 0x1700EB0E RID: 60174
		// (get) Token: 0x060387EE RID: 231406 RVA: 0x007A0802 File Offset: 0x0079EA02
		// (set) Token: 0x060387EF RID: 231407 RVA: 0x007A080A File Offset: 0x0079EA0A
		public uint NullMask { get; set; }

		// Token: 0x060387F0 RID: 231408 RVA: 0x007A0814 File Offset: 0x0079EA14
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
