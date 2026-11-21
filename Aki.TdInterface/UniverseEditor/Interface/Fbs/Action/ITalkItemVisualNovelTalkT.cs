using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AF2 RID: 31474
	public class ITalkItemVisualNovelTalkT
	{
		// Token: 0x1700EB96 RID: 60310
		// (get) Token: 0x06038A20 RID: 231968 RVA: 0x007A95B5 File Offset: 0x007A77B5
		// (set) Token: 0x06038A21 RID: 231969 RVA: 0x007A95BD File Offset: 0x007A77BD
		public ETalkItemType Type { get; set; }

		// Token: 0x1700EB97 RID: 60311
		// (get) Token: 0x06038A22 RID: 231970 RVA: 0x007A95C6 File Offset: 0x007A77C6
		// (set) Token: 0x06038A23 RID: 231971 RVA: 0x007A95CE File Offset: 0x007A77CE
		public int Id { get; set; }

		// Token: 0x1700EB98 RID: 60312
		// (get) Token: 0x06038A24 RID: 231972 RVA: 0x007A95D7 File Offset: 0x007A77D7
		// (set) Token: 0x06038A25 RID: 231973 RVA: 0x007A95DF File Offset: 0x007A77DF
		public int PlotLineId { get; set; }

		// Token: 0x1700EB99 RID: 60313
		// (get) Token: 0x06038A26 RID: 231974 RVA: 0x007A95E8 File Offset: 0x007A77E8
		// (set) Token: 0x06038A27 RID: 231975 RVA: 0x007A95F0 File Offset: 0x007A77F0
		public string PlotLineKey { get; set; }

		// Token: 0x1700EB9A RID: 60314
		// (get) Token: 0x06038A28 RID: 231976 RVA: 0x007A95F9 File Offset: 0x007A77F9
		// (set) Token: 0x06038A29 RID: 231977 RVA: 0x007A9601 File Offset: 0x007A7801
		public string Name { get; set; }

		// Token: 0x1700EB9B RID: 60315
		// (get) Token: 0x06038A2A RID: 231978 RVA: 0x007A960A File Offset: 0x007A780A
		// (set) Token: 0x06038A2B RID: 231979 RVA: 0x007A9612 File Offset: 0x007A7812
		public bool _Folded { get; set; }

		// Token: 0x1700EB9C RID: 60316
		// (get) Token: 0x06038A2C RID: 231980 RVA: 0x007A961B File Offset: 0x007A781B
		// (set) Token: 0x06038A2D RID: 231981 RVA: 0x007A9623 File Offset: 0x007A7823
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700EB9D RID: 60317
		// (get) Token: 0x06038A2E RID: 231982 RVA: 0x007A962C File Offset: 0x007A782C
		// (set) Token: 0x06038A2F RID: 231983 RVA: 0x007A9634 File Offset: 0x007A7834
		public int WhoId { get; set; }

		// Token: 0x1700EB9E RID: 60318
		// (get) Token: 0x06038A30 RID: 231984 RVA: 0x007A963D File Offset: 0x007A783D
		// (set) Token: 0x06038A31 RID: 231985 RVA: 0x007A9645 File Offset: 0x007A7845
		public int TextId { get; set; }

		// Token: 0x1700EB9F RID: 60319
		// (get) Token: 0x06038A32 RID: 231986 RVA: 0x007A964E File Offset: 0x007A784E
		// (set) Token: 0x06038A33 RID: 231987 RVA: 0x007A9656 File Offset: 0x007A7856
		public string TidTalk { get; set; }

		// Token: 0x1700EBA0 RID: 60320
		// (get) Token: 0x06038A34 RID: 231988 RVA: 0x007A965F File Offset: 0x007A785F
		// (set) Token: 0x06038A35 RID: 231989 RVA: 0x007A9667 File Offset: 0x007A7867
		public float WaitTime { get; set; }

		// Token: 0x1700EBA1 RID: 60321
		// (get) Token: 0x06038A36 RID: 231990 RVA: 0x007A9670 File Offset: 0x007A7870
		// (set) Token: 0x06038A37 RID: 231991 RVA: 0x007A9678 File Offset: 0x007A7878
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700EBA2 RID: 60322
		// (get) Token: 0x06038A38 RID: 231992 RVA: 0x007A9681 File Offset: 0x007A7881
		// (set) Token: 0x06038A39 RID: 231993 RVA: 0x007A9689 File Offset: 0x007A7889
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700EBA3 RID: 60323
		// (get) Token: 0x06038A3A RID: 231994 RVA: 0x007A9692 File Offset: 0x007A7892
		// (set) Token: 0x06038A3B RID: 231995 RVA: 0x007A969A File Offset: 0x007A789A
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700EBA4 RID: 60324
		// (get) Token: 0x06038A3C RID: 231996 RVA: 0x007A96A3 File Offset: 0x007A78A3
		// (set) Token: 0x06038A3D RID: 231997 RVA: 0x007A96AB File Offset: 0x007A78AB
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700EBA5 RID: 60325
		// (get) Token: 0x06038A3E RID: 231998 RVA: 0x007A96B4 File Offset: 0x007A78B4
		// (set) Token: 0x06038A3F RID: 231999 RVA: 0x007A96BC File Offset: 0x007A78BC
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700EBA6 RID: 60326
		// (get) Token: 0x06038A40 RID: 232000 RVA: 0x007A96C5 File Offset: 0x007A78C5
		// (set) Token: 0x06038A41 RID: 232001 RVA: 0x007A96CD File Offset: 0x007A78CD
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700EBA7 RID: 60327
		// (get) Token: 0x06038A42 RID: 232002 RVA: 0x007A96D6 File Offset: 0x007A78D6
		// (set) Token: 0x06038A43 RID: 232003 RVA: 0x007A96DE File Offset: 0x007A78DE
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700EBA8 RID: 60328
		// (get) Token: 0x06038A44 RID: 232004 RVA: 0x007A96E7 File Offset: 0x007A78E7
		// (set) Token: 0x06038A45 RID: 232005 RVA: 0x007A96EF File Offset: 0x007A78EF
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700EBA9 RID: 60329
		// (get) Token: 0x06038A46 RID: 232006 RVA: 0x007A96F8 File Offset: 0x007A78F8
		// (set) Token: 0x06038A47 RID: 232007 RVA: 0x007A9700 File Offset: 0x007A7900
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700EBAA RID: 60330
		// (get) Token: 0x06038A48 RID: 232008 RVA: 0x007A9709 File Offset: 0x007A7909
		// (set) Token: 0x06038A49 RID: 232009 RVA: 0x007A9711 File Offset: 0x007A7911
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700EBAB RID: 60331
		// (get) Token: 0x06038A4A RID: 232010 RVA: 0x007A971A File Offset: 0x007A791A
		// (set) Token: 0x06038A4B RID: 232011 RVA: 0x007A9722 File Offset: 0x007A7922
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700EBAC RID: 60332
		// (get) Token: 0x06038A4C RID: 232012 RVA: 0x007A972B File Offset: 0x007A792B
		// (set) Token: 0x06038A4D RID: 232013 RVA: 0x007A9733 File Offset: 0x007A7933
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700EBAD RID: 60333
		// (get) Token: 0x06038A4E RID: 232014 RVA: 0x007A973C File Offset: 0x007A793C
		// (set) Token: 0x06038A4F RID: 232015 RVA: 0x007A9744 File Offset: 0x007A7944
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700EBAE RID: 60334
		// (get) Token: 0x06038A50 RID: 232016 RVA: 0x007A974D File Offset: 0x007A794D
		// (set) Token: 0x06038A51 RID: 232017 RVA: 0x007A9755 File Offset: 0x007A7955
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700EBAF RID: 60335
		// (get) Token: 0x06038A52 RID: 232018 RVA: 0x007A975E File Offset: 0x007A795E
		// (set) Token: 0x06038A53 RID: 232019 RVA: 0x007A9766 File Offset: 0x007A7966
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700EBB0 RID: 60336
		// (get) Token: 0x06038A54 RID: 232020 RVA: 0x007A976F File Offset: 0x007A796F
		// (set) Token: 0x06038A55 RID: 232021 RVA: 0x007A9777 File Offset: 0x007A7977
		public bool PlayVoice { get; set; }

		// Token: 0x1700EBB1 RID: 60337
		// (get) Token: 0x06038A56 RID: 232022 RVA: 0x007A9780 File Offset: 0x007A7980
		// (set) Token: 0x06038A57 RID: 232023 RVA: 0x007A9788 File Offset: 0x007A7988
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700EBB2 RID: 60338
		// (get) Token: 0x06038A58 RID: 232024 RVA: 0x007A9791 File Offset: 0x007A7991
		// (set) Token: 0x06038A59 RID: 232025 RVA: 0x007A9799 File Offset: 0x007A7999
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700EBB3 RID: 60339
		// (get) Token: 0x06038A5A RID: 232026 RVA: 0x007A97A2 File Offset: 0x007A79A2
		// (set) Token: 0x06038A5B RID: 232027 RVA: 0x007A97AA File Offset: 0x007A79AA
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700EBB4 RID: 60340
		// (get) Token: 0x06038A5C RID: 232028 RVA: 0x007A97B3 File Offset: 0x007A79B3
		// (set) Token: 0x06038A5D RID: 232029 RVA: 0x007A97BB File Offset: 0x007A79BB
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700EBB5 RID: 60341
		// (get) Token: 0x06038A5E RID: 232030 RVA: 0x007A97C4 File Offset: 0x007A79C4
		// (set) Token: 0x06038A5F RID: 232031 RVA: 0x007A97CC File Offset: 0x007A79CC
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700EBB6 RID: 60342
		// (get) Token: 0x06038A60 RID: 232032 RVA: 0x007A97D5 File Offset: 0x007A79D5
		// (set) Token: 0x06038A61 RID: 232033 RVA: 0x007A97DD File Offset: 0x007A79DD
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700EBB7 RID: 60343
		// (get) Token: 0x06038A62 RID: 232034 RVA: 0x007A97E6 File Offset: 0x007A79E6
		// (set) Token: 0x06038A63 RID: 232035 RVA: 0x007A97EE File Offset: 0x007A79EE
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700EBB8 RID: 60344
		// (get) Token: 0x06038A64 RID: 232036 RVA: 0x007A97F7 File Offset: 0x007A79F7
		// (set) Token: 0x06038A65 RID: 232037 RVA: 0x007A97FF File Offset: 0x007A79FF
		public TVisualNovelOptionGroupConfigUnion OptionGroup { get; set; }

		// Token: 0x1700EBB9 RID: 60345
		// (get) Token: 0x06038A66 RID: 232038 RVA: 0x007A9808 File Offset: 0x007A7A08
		// (set) Token: 0x06038A67 RID: 232039 RVA: 0x007A9810 File Offset: 0x007A7A10
		public float DialogDelay { get; set; }

		// Token: 0x1700EBBA RID: 60346
		// (get) Token: 0x06038A68 RID: 232040 RVA: 0x007A9819 File Offset: 0x007A7A19
		// (set) Token: 0x06038A69 RID: 232041 RVA: 0x007A9821 File Offset: 0x007A7A21
		public bool ClickShowFull { get; set; }

		// Token: 0x1700EBBB RID: 60347
		// (get) Token: 0x06038A6A RID: 232042 RVA: 0x007A982A File Offset: 0x007A7A2A
		// (set) Token: 0x06038A6B RID: 232043 RVA: 0x007A9832 File Offset: 0x007A7A32
		public string Interjection { get; set; }

		// Token: 0x1700EBBC RID: 60348
		// (get) Token: 0x06038A6C RID: 232044 RVA: 0x007A983B File Offset: 0x007A7A3B
		// (set) Token: 0x06038A6D RID: 232045 RVA: 0x007A9843 File Offset: 0x007A7A43
		public IVisualNovelPortraitTransformT Transform { get; set; }

		// Token: 0x1700EBBD RID: 60349
		// (get) Token: 0x06038A6E RID: 232046 RVA: 0x007A984C File Offset: 0x007A7A4C
		// (set) Token: 0x06038A6F RID: 232047 RVA: 0x007A9854 File Offset: 0x007A7A54
		public IVisualNovelRoleConfigT RoleConfig { get; set; }

		// Token: 0x1700EBBE RID: 60350
		// (get) Token: 0x06038A70 RID: 232048 RVA: 0x007A985D File Offset: 0x007A7A5D
		// (set) Token: 0x06038A71 RID: 232049 RVA: 0x007A9865 File Offset: 0x007A7A65
		public TVisualNovelBackgroundUnion VisualNovelBackgroundConfig { get; set; }

		// Token: 0x1700EBBF RID: 60351
		// (get) Token: 0x06038A72 RID: 232050 RVA: 0x007A986E File Offset: 0x007A7A6E
		// (set) Token: 0x06038A73 RID: 232051 RVA: 0x007A9876 File Offset: 0x007A7A76
		public TVisualNovelCgUnion CgConfig { get; set; }

		// Token: 0x1700EBC0 RID: 60352
		// (get) Token: 0x06038A74 RID: 232052 RVA: 0x007A987F File Offset: 0x007A7A7F
		// (set) Token: 0x06038A75 RID: 232053 RVA: 0x007A9887 File Offset: 0x007A7A87
		public TVisualNovelDisplayItemUnion DisplayItemConfig { get; set; }

		// Token: 0x1700EBC1 RID: 60353
		// (get) Token: 0x06038A76 RID: 232054 RVA: 0x007A9890 File Offset: 0x007A7A90
		// (set) Token: 0x06038A77 RID: 232055 RVA: 0x007A9898 File Offset: 0x007A7A98
		public int PlotKeyId { get; set; }

		// Token: 0x1700EBC2 RID: 60354
		// (get) Token: 0x06038A78 RID: 232056 RVA: 0x007A98A1 File Offset: 0x007A7AA1
		// (set) Token: 0x06038A79 RID: 232057 RVA: 0x007A98A9 File Offset: 0x007A7AA9
		public List<TVisualNovelPerformanceUnion> StartPerformances { get; set; }

		// Token: 0x1700EBC3 RID: 60355
		// (get) Token: 0x06038A7A RID: 232058 RVA: 0x007A98B2 File Offset: 0x007A7AB2
		// (set) Token: 0x06038A7B RID: 232059 RVA: 0x007A98BA File Offset: 0x007A7ABA
		public List<TVisualNovelPerformanceUnion> EndPerformances { get; set; }

		// Token: 0x1700EBC4 RID: 60356
		// (get) Token: 0x06038A7C RID: 232060 RVA: 0x007A98C3 File Offset: 0x007A7AC3
		// (set) Token: 0x06038A7D RID: 232061 RVA: 0x007A98CB File Offset: 0x007A7ACB
		public uint NullMask { get; set; }

		// Token: 0x06038A7E RID: 232062 RVA: 0x007A98D4 File Offset: 0x007A7AD4
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
