using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007311 RID: 29457
	public class ITalkItemVisualNovelNarrationT
	{
		// Token: 0x1700DE8D RID: 56973
		// (get) Token: 0x06035320 RID: 217888 RVA: 0x00739CCC File Offset: 0x00737ECC
		// (set) Token: 0x06035321 RID: 217889 RVA: 0x00739CD4 File Offset: 0x00737ED4
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DE8E RID: 56974
		// (get) Token: 0x06035322 RID: 217890 RVA: 0x00739CDD File Offset: 0x00737EDD
		// (set) Token: 0x06035323 RID: 217891 RVA: 0x00739CE5 File Offset: 0x00737EE5
		public int Id { get; set; }

		// Token: 0x1700DE8F RID: 56975
		// (get) Token: 0x06035324 RID: 217892 RVA: 0x00739CEE File Offset: 0x00737EEE
		// (set) Token: 0x06035325 RID: 217893 RVA: 0x00739CF6 File Offset: 0x00737EF6
		public int PlotLineId { get; set; }

		// Token: 0x1700DE90 RID: 56976
		// (get) Token: 0x06035326 RID: 217894 RVA: 0x00739CFF File Offset: 0x00737EFF
		// (set) Token: 0x06035327 RID: 217895 RVA: 0x00739D07 File Offset: 0x00737F07
		public string PlotLineKey { get; set; }

		// Token: 0x1700DE91 RID: 56977
		// (get) Token: 0x06035328 RID: 217896 RVA: 0x00739D10 File Offset: 0x00737F10
		// (set) Token: 0x06035329 RID: 217897 RVA: 0x00739D18 File Offset: 0x00737F18
		public string Name { get; set; }

		// Token: 0x1700DE92 RID: 56978
		// (get) Token: 0x0603532A RID: 217898 RVA: 0x00739D21 File Offset: 0x00737F21
		// (set) Token: 0x0603532B RID: 217899 RVA: 0x00739D29 File Offset: 0x00737F29
		public bool _Folded { get; set; }

		// Token: 0x1700DE93 RID: 56979
		// (get) Token: 0x0603532C RID: 217900 RVA: 0x00739D32 File Offset: 0x00737F32
		// (set) Token: 0x0603532D RID: 217901 RVA: 0x00739D3A File Offset: 0x00737F3A
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DE94 RID: 56980
		// (get) Token: 0x0603532E RID: 217902 RVA: 0x00739D43 File Offset: 0x00737F43
		// (set) Token: 0x0603532F RID: 217903 RVA: 0x00739D4B File Offset: 0x00737F4B
		public int WhoId { get; set; }

		// Token: 0x1700DE95 RID: 56981
		// (get) Token: 0x06035330 RID: 217904 RVA: 0x00739D54 File Offset: 0x00737F54
		// (set) Token: 0x06035331 RID: 217905 RVA: 0x00739D5C File Offset: 0x00737F5C
		public int TextId { get; set; }

		// Token: 0x1700DE96 RID: 56982
		// (get) Token: 0x06035332 RID: 217906 RVA: 0x00739D65 File Offset: 0x00737F65
		// (set) Token: 0x06035333 RID: 217907 RVA: 0x00739D6D File Offset: 0x00737F6D
		public string TidTalk { get; set; }

		// Token: 0x1700DE97 RID: 56983
		// (get) Token: 0x06035334 RID: 217908 RVA: 0x00739D76 File Offset: 0x00737F76
		// (set) Token: 0x06035335 RID: 217909 RVA: 0x00739D7E File Offset: 0x00737F7E
		public float WaitTime { get; set; }

		// Token: 0x1700DE98 RID: 56984
		// (get) Token: 0x06035336 RID: 217910 RVA: 0x00739D87 File Offset: 0x00737F87
		// (set) Token: 0x06035337 RID: 217911 RVA: 0x00739D8F File Offset: 0x00737F8F
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DE99 RID: 56985
		// (get) Token: 0x06035338 RID: 217912 RVA: 0x00739D98 File Offset: 0x00737F98
		// (set) Token: 0x06035339 RID: 217913 RVA: 0x00739DA0 File Offset: 0x00737FA0
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DE9A RID: 56986
		// (get) Token: 0x0603533A RID: 217914 RVA: 0x00739DA9 File Offset: 0x00737FA9
		// (set) Token: 0x0603533B RID: 217915 RVA: 0x00739DB1 File Offset: 0x00737FB1
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DE9B RID: 56987
		// (get) Token: 0x0603533C RID: 217916 RVA: 0x00739DBA File Offset: 0x00737FBA
		// (set) Token: 0x0603533D RID: 217917 RVA: 0x00739DC2 File Offset: 0x00737FC2
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DE9C RID: 56988
		// (get) Token: 0x0603533E RID: 217918 RVA: 0x00739DCB File Offset: 0x00737FCB
		// (set) Token: 0x0603533F RID: 217919 RVA: 0x00739DD3 File Offset: 0x00737FD3
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DE9D RID: 56989
		// (get) Token: 0x06035340 RID: 217920 RVA: 0x00739DDC File Offset: 0x00737FDC
		// (set) Token: 0x06035341 RID: 217921 RVA: 0x00739DE4 File Offset: 0x00737FE4
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DE9E RID: 56990
		// (get) Token: 0x06035342 RID: 217922 RVA: 0x00739DED File Offset: 0x00737FED
		// (set) Token: 0x06035343 RID: 217923 RVA: 0x00739DF5 File Offset: 0x00737FF5
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DE9F RID: 56991
		// (get) Token: 0x06035344 RID: 217924 RVA: 0x00739DFE File Offset: 0x00737FFE
		// (set) Token: 0x06035345 RID: 217925 RVA: 0x00739E06 File Offset: 0x00738006
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DEA0 RID: 56992
		// (get) Token: 0x06035346 RID: 217926 RVA: 0x00739E0F File Offset: 0x0073800F
		// (set) Token: 0x06035347 RID: 217927 RVA: 0x00739E17 File Offset: 0x00738017
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DEA1 RID: 56993
		// (get) Token: 0x06035348 RID: 217928 RVA: 0x00739E20 File Offset: 0x00738020
		// (set) Token: 0x06035349 RID: 217929 RVA: 0x00739E28 File Offset: 0x00738028
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DEA2 RID: 56994
		// (get) Token: 0x0603534A RID: 217930 RVA: 0x00739E31 File Offset: 0x00738031
		// (set) Token: 0x0603534B RID: 217931 RVA: 0x00739E39 File Offset: 0x00738039
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DEA3 RID: 56995
		// (get) Token: 0x0603534C RID: 217932 RVA: 0x00739E42 File Offset: 0x00738042
		// (set) Token: 0x0603534D RID: 217933 RVA: 0x00739E4A File Offset: 0x0073804A
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DEA4 RID: 56996
		// (get) Token: 0x0603534E RID: 217934 RVA: 0x00739E53 File Offset: 0x00738053
		// (set) Token: 0x0603534F RID: 217935 RVA: 0x00739E5B File Offset: 0x0073805B
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DEA5 RID: 56997
		// (get) Token: 0x06035350 RID: 217936 RVA: 0x00739E64 File Offset: 0x00738064
		// (set) Token: 0x06035351 RID: 217937 RVA: 0x00739E6C File Offset: 0x0073806C
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DEA6 RID: 56998
		// (get) Token: 0x06035352 RID: 217938 RVA: 0x00739E75 File Offset: 0x00738075
		// (set) Token: 0x06035353 RID: 217939 RVA: 0x00739E7D File Offset: 0x0073807D
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DEA7 RID: 56999
		// (get) Token: 0x06035354 RID: 217940 RVA: 0x00739E86 File Offset: 0x00738086
		// (set) Token: 0x06035355 RID: 217941 RVA: 0x00739E8E File Offset: 0x0073808E
		public bool PlayVoice { get; set; }

		// Token: 0x1700DEA8 RID: 57000
		// (get) Token: 0x06035356 RID: 217942 RVA: 0x00739E97 File Offset: 0x00738097
		// (set) Token: 0x06035357 RID: 217943 RVA: 0x00739E9F File Offset: 0x0073809F
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DEA9 RID: 57001
		// (get) Token: 0x06035358 RID: 217944 RVA: 0x00739EA8 File Offset: 0x007380A8
		// (set) Token: 0x06035359 RID: 217945 RVA: 0x00739EB0 File Offset: 0x007380B0
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DEAA RID: 57002
		// (get) Token: 0x0603535A RID: 217946 RVA: 0x00739EB9 File Offset: 0x007380B9
		// (set) Token: 0x0603535B RID: 217947 RVA: 0x00739EC1 File Offset: 0x007380C1
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DEAB RID: 57003
		// (get) Token: 0x0603535C RID: 217948 RVA: 0x00739ECA File Offset: 0x007380CA
		// (set) Token: 0x0603535D RID: 217949 RVA: 0x00739ED2 File Offset: 0x007380D2
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DEAC RID: 57004
		// (get) Token: 0x0603535E RID: 217950 RVA: 0x00739EDB File Offset: 0x007380DB
		// (set) Token: 0x0603535F RID: 217951 RVA: 0x00739EE3 File Offset: 0x007380E3
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DEAD RID: 57005
		// (get) Token: 0x06035360 RID: 217952 RVA: 0x00739EEC File Offset: 0x007380EC
		// (set) Token: 0x06035361 RID: 217953 RVA: 0x00739EF4 File Offset: 0x007380F4
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DEAE RID: 57006
		// (get) Token: 0x06035362 RID: 217954 RVA: 0x00739EFD File Offset: 0x007380FD
		// (set) Token: 0x06035363 RID: 217955 RVA: 0x00739F05 File Offset: 0x00738105
		public EVisualNovelOptionInteractionType OptionInteractionType { get; set; }

		// Token: 0x1700DEAF RID: 57007
		// (get) Token: 0x06035364 RID: 217956 RVA: 0x00739F0E File Offset: 0x0073810E
		// (set) Token: 0x06035365 RID: 217957 RVA: 0x00739F16 File Offset: 0x00738116
		public IVisualNovelOptionGroupSolarSchoolExamT OptionGroup { get; set; }

		// Token: 0x1700DEB0 RID: 57008
		// (get) Token: 0x06035366 RID: 217958 RVA: 0x00739F1F File Offset: 0x0073811F
		// (set) Token: 0x06035367 RID: 217959 RVA: 0x00739F27 File Offset: 0x00738127
		public float DialogDelay { get; set; }

		// Token: 0x1700DEB1 RID: 57009
		// (get) Token: 0x06035368 RID: 217960 RVA: 0x00739F30 File Offset: 0x00738130
		// (set) Token: 0x06035369 RID: 217961 RVA: 0x00739F38 File Offset: 0x00738138
		public bool ClickShowFull { get; set; }

		// Token: 0x1700DEB2 RID: 57010
		// (get) Token: 0x0603536A RID: 217962 RVA: 0x00739F41 File Offset: 0x00738141
		// (set) Token: 0x0603536B RID: 217963 RVA: 0x00739F49 File Offset: 0x00738149
		public TVisualNovelBackgroundUnion VisualNovelBackgroundConfig { get; set; }

		// Token: 0x1700DEB3 RID: 57011
		// (get) Token: 0x0603536C RID: 217964 RVA: 0x00739F52 File Offset: 0x00738152
		// (set) Token: 0x0603536D RID: 217965 RVA: 0x00739F5A File Offset: 0x0073815A
		public TVisualNovelCgUnion CgConfig { get; set; }

		// Token: 0x1700DEB4 RID: 57012
		// (get) Token: 0x0603536E RID: 217966 RVA: 0x00739F63 File Offset: 0x00738163
		// (set) Token: 0x0603536F RID: 217967 RVA: 0x00739F6B File Offset: 0x0073816B
		public TVisualNovelDisplayItemUnion DisplayItemConfig { get; set; }

		// Token: 0x1700DEB5 RID: 57013
		// (get) Token: 0x06035370 RID: 217968 RVA: 0x00739F74 File Offset: 0x00738174
		// (set) Token: 0x06035371 RID: 217969 RVA: 0x00739F7C File Offset: 0x0073817C
		public int PlotKeyId { get; set; }

		// Token: 0x1700DEB6 RID: 57014
		// (get) Token: 0x06035372 RID: 217970 RVA: 0x00739F85 File Offset: 0x00738185
		// (set) Token: 0x06035373 RID: 217971 RVA: 0x00739F8D File Offset: 0x0073818D
		public List<TVisualNovelPerformanceUnion> StartPerformances { get; set; }

		// Token: 0x1700DEB7 RID: 57015
		// (get) Token: 0x06035374 RID: 217972 RVA: 0x00739F96 File Offset: 0x00738196
		// (set) Token: 0x06035375 RID: 217973 RVA: 0x00739F9E File Offset: 0x0073819E
		public List<TVisualNovelPerformanceUnion> EndPerformances { get; set; }

		// Token: 0x1700DEB8 RID: 57016
		// (get) Token: 0x06035376 RID: 217974 RVA: 0x00739FA7 File Offset: 0x007381A7
		// (set) Token: 0x06035377 RID: 217975 RVA: 0x00739FAF File Offset: 0x007381AF
		public uint NullMask { get; set; }

		// Token: 0x06035378 RID: 217976 RVA: 0x00739FB8 File Offset: 0x007381B8
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
