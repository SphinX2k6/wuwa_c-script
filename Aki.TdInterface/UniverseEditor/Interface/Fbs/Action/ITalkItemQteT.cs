using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072FC RID: 29436
	public class ITalkItemQteT
	{
		// Token: 0x1700DD9B RID: 56731
		// (get) Token: 0x06034F92 RID: 216978 RVA: 0x0072DD5D File Offset: 0x0072BF5D
		// (set) Token: 0x06034F93 RID: 216979 RVA: 0x0072DD65 File Offset: 0x0072BF65
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DD9C RID: 56732
		// (get) Token: 0x06034F94 RID: 216980 RVA: 0x0072DD6E File Offset: 0x0072BF6E
		// (set) Token: 0x06034F95 RID: 216981 RVA: 0x0072DD76 File Offset: 0x0072BF76
		public int Id { get; set; }

		// Token: 0x1700DD9D RID: 56733
		// (get) Token: 0x06034F96 RID: 216982 RVA: 0x0072DD7F File Offset: 0x0072BF7F
		// (set) Token: 0x06034F97 RID: 216983 RVA: 0x0072DD87 File Offset: 0x0072BF87
		public int PlotLineId { get; set; }

		// Token: 0x1700DD9E RID: 56734
		// (get) Token: 0x06034F98 RID: 216984 RVA: 0x0072DD90 File Offset: 0x0072BF90
		// (set) Token: 0x06034F99 RID: 216985 RVA: 0x0072DD98 File Offset: 0x0072BF98
		public string PlotLineKey { get; set; }

		// Token: 0x1700DD9F RID: 56735
		// (get) Token: 0x06034F9A RID: 216986 RVA: 0x0072DDA1 File Offset: 0x0072BFA1
		// (set) Token: 0x06034F9B RID: 216987 RVA: 0x0072DDA9 File Offset: 0x0072BFA9
		public string Name { get; set; }

		// Token: 0x1700DDA0 RID: 56736
		// (get) Token: 0x06034F9C RID: 216988 RVA: 0x0072DDB2 File Offset: 0x0072BFB2
		// (set) Token: 0x06034F9D RID: 216989 RVA: 0x0072DDBA File Offset: 0x0072BFBA
		public bool _Folded { get; set; }

		// Token: 0x1700DDA1 RID: 56737
		// (get) Token: 0x06034F9E RID: 216990 RVA: 0x0072DDC3 File Offset: 0x0072BFC3
		// (set) Token: 0x06034F9F RID: 216991 RVA: 0x0072DDCB File Offset: 0x0072BFCB
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DDA2 RID: 56738
		// (get) Token: 0x06034FA0 RID: 216992 RVA: 0x0072DDD4 File Offset: 0x0072BFD4
		// (set) Token: 0x06034FA1 RID: 216993 RVA: 0x0072DDDC File Offset: 0x0072BFDC
		public int WhoId { get; set; }

		// Token: 0x1700DDA3 RID: 56739
		// (get) Token: 0x06034FA2 RID: 216994 RVA: 0x0072DDE5 File Offset: 0x0072BFE5
		// (set) Token: 0x06034FA3 RID: 216995 RVA: 0x0072DDED File Offset: 0x0072BFED
		public int TextId { get; set; }

		// Token: 0x1700DDA4 RID: 56740
		// (get) Token: 0x06034FA4 RID: 216996 RVA: 0x0072DDF6 File Offset: 0x0072BFF6
		// (set) Token: 0x06034FA5 RID: 216997 RVA: 0x0072DDFE File Offset: 0x0072BFFE
		public string TidTalk { get; set; }

		// Token: 0x1700DDA5 RID: 56741
		// (get) Token: 0x06034FA6 RID: 216998 RVA: 0x0072DE07 File Offset: 0x0072C007
		// (set) Token: 0x06034FA7 RID: 216999 RVA: 0x0072DE0F File Offset: 0x0072C00F
		public float WaitTime { get; set; }

		// Token: 0x1700DDA6 RID: 56742
		// (get) Token: 0x06034FA8 RID: 217000 RVA: 0x0072DE18 File Offset: 0x0072C018
		// (set) Token: 0x06034FA9 RID: 217001 RVA: 0x0072DE20 File Offset: 0x0072C020
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DDA7 RID: 56743
		// (get) Token: 0x06034FAA RID: 217002 RVA: 0x0072DE29 File Offset: 0x0072C029
		// (set) Token: 0x06034FAB RID: 217003 RVA: 0x0072DE31 File Offset: 0x0072C031
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DDA8 RID: 56744
		// (get) Token: 0x06034FAC RID: 217004 RVA: 0x0072DE3A File Offset: 0x0072C03A
		// (set) Token: 0x06034FAD RID: 217005 RVA: 0x0072DE42 File Offset: 0x0072C042
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DDA9 RID: 56745
		// (get) Token: 0x06034FAE RID: 217006 RVA: 0x0072DE4B File Offset: 0x0072C04B
		// (set) Token: 0x06034FAF RID: 217007 RVA: 0x0072DE53 File Offset: 0x0072C053
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DDAA RID: 56746
		// (get) Token: 0x06034FB0 RID: 217008 RVA: 0x0072DE5C File Offset: 0x0072C05C
		// (set) Token: 0x06034FB1 RID: 217009 RVA: 0x0072DE64 File Offset: 0x0072C064
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DDAB RID: 56747
		// (get) Token: 0x06034FB2 RID: 217010 RVA: 0x0072DE6D File Offset: 0x0072C06D
		// (set) Token: 0x06034FB3 RID: 217011 RVA: 0x0072DE75 File Offset: 0x0072C075
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DDAC RID: 56748
		// (get) Token: 0x06034FB4 RID: 217012 RVA: 0x0072DE7E File Offset: 0x0072C07E
		// (set) Token: 0x06034FB5 RID: 217013 RVA: 0x0072DE86 File Offset: 0x0072C086
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DDAD RID: 56749
		// (get) Token: 0x06034FB6 RID: 217014 RVA: 0x0072DE8F File Offset: 0x0072C08F
		// (set) Token: 0x06034FB7 RID: 217015 RVA: 0x0072DE97 File Offset: 0x0072C097
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DDAE RID: 56750
		// (get) Token: 0x06034FB8 RID: 217016 RVA: 0x0072DEA0 File Offset: 0x0072C0A0
		// (set) Token: 0x06034FB9 RID: 217017 RVA: 0x0072DEA8 File Offset: 0x0072C0A8
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DDAF RID: 56751
		// (get) Token: 0x06034FBA RID: 217018 RVA: 0x0072DEB1 File Offset: 0x0072C0B1
		// (set) Token: 0x06034FBB RID: 217019 RVA: 0x0072DEB9 File Offset: 0x0072C0B9
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DDB0 RID: 56752
		// (get) Token: 0x06034FBC RID: 217020 RVA: 0x0072DEC2 File Offset: 0x0072C0C2
		// (set) Token: 0x06034FBD RID: 217021 RVA: 0x0072DECA File Offset: 0x0072C0CA
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DDB1 RID: 56753
		// (get) Token: 0x06034FBE RID: 217022 RVA: 0x0072DED3 File Offset: 0x0072C0D3
		// (set) Token: 0x06034FBF RID: 217023 RVA: 0x0072DEDB File Offset: 0x0072C0DB
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DDB2 RID: 56754
		// (get) Token: 0x06034FC0 RID: 217024 RVA: 0x0072DEE4 File Offset: 0x0072C0E4
		// (set) Token: 0x06034FC1 RID: 217025 RVA: 0x0072DEEC File Offset: 0x0072C0EC
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DDB3 RID: 56755
		// (get) Token: 0x06034FC2 RID: 217026 RVA: 0x0072DEF5 File Offset: 0x0072C0F5
		// (set) Token: 0x06034FC3 RID: 217027 RVA: 0x0072DEFD File Offset: 0x0072C0FD
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DDB4 RID: 56756
		// (get) Token: 0x06034FC4 RID: 217028 RVA: 0x0072DF06 File Offset: 0x0072C106
		// (set) Token: 0x06034FC5 RID: 217029 RVA: 0x0072DF0E File Offset: 0x0072C10E
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DDB5 RID: 56757
		// (get) Token: 0x06034FC6 RID: 217030 RVA: 0x0072DF17 File Offset: 0x0072C117
		// (set) Token: 0x06034FC7 RID: 217031 RVA: 0x0072DF1F File Offset: 0x0072C11F
		public bool PlayVoice { get; set; }

		// Token: 0x1700DDB6 RID: 56758
		// (get) Token: 0x06034FC8 RID: 217032 RVA: 0x0072DF28 File Offset: 0x0072C128
		// (set) Token: 0x06034FC9 RID: 217033 RVA: 0x0072DF30 File Offset: 0x0072C130
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DDB7 RID: 56759
		// (get) Token: 0x06034FCA RID: 217034 RVA: 0x0072DF39 File Offset: 0x0072C139
		// (set) Token: 0x06034FCB RID: 217035 RVA: 0x0072DF41 File Offset: 0x0072C141
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DDB8 RID: 56760
		// (get) Token: 0x06034FCC RID: 217036 RVA: 0x0072DF4A File Offset: 0x0072C14A
		// (set) Token: 0x06034FCD RID: 217037 RVA: 0x0072DF52 File Offset: 0x0072C152
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DDB9 RID: 56761
		// (get) Token: 0x06034FCE RID: 217038 RVA: 0x0072DF5B File Offset: 0x0072C15B
		// (set) Token: 0x06034FCF RID: 217039 RVA: 0x0072DF63 File Offset: 0x0072C163
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DDBA RID: 56762
		// (get) Token: 0x06034FD0 RID: 217040 RVA: 0x0072DF6C File Offset: 0x0072C16C
		// (set) Token: 0x06034FD1 RID: 217041 RVA: 0x0072DF74 File Offset: 0x0072C174
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DDBB RID: 56763
		// (get) Token: 0x06034FD2 RID: 217042 RVA: 0x0072DF7D File Offset: 0x0072C17D
		// (set) Token: 0x06034FD3 RID: 217043 RVA: 0x0072DF85 File Offset: 0x0072C185
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DDBC RID: 56764
		// (get) Token: 0x06034FD4 RID: 217044 RVA: 0x0072DF8E File Offset: 0x0072C18E
		// (set) Token: 0x06034FD5 RID: 217045 RVA: 0x0072DF96 File Offset: 0x0072C196
		public int QteId { get; set; }

		// Token: 0x1700DDBD RID: 56765
		// (get) Token: 0x06034FD6 RID: 217046 RVA: 0x0072DF9F File Offset: 0x0072C19F
		// (set) Token: 0x06034FD7 RID: 217047 RVA: 0x0072DFA7 File Offset: 0x0072C1A7
		public uint NullMask { get; set; }

		// Token: 0x06034FD8 RID: 217048 RVA: 0x0072DFB0 File Offset: 0x0072C1B0
		public ITalkItemQteT()
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
			this.QteId = 0;
			this.NullMask = 0U;
		}
	}
}
