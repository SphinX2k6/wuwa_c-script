using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072CF RID: 29391
	public class ITalkItemAvgOptionT
	{
		// Token: 0x1700DB67 RID: 56167
		// (get) Token: 0x060347A3 RID: 214947 RVA: 0x007149A3 File Offset: 0x00712BA3
		// (set) Token: 0x060347A4 RID: 214948 RVA: 0x007149AB File Offset: 0x00712BAB
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DB68 RID: 56168
		// (get) Token: 0x060347A5 RID: 214949 RVA: 0x007149B4 File Offset: 0x00712BB4
		// (set) Token: 0x060347A6 RID: 214950 RVA: 0x007149BC File Offset: 0x00712BBC
		public int Id { get; set; }

		// Token: 0x1700DB69 RID: 56169
		// (get) Token: 0x060347A7 RID: 214951 RVA: 0x007149C5 File Offset: 0x00712BC5
		// (set) Token: 0x060347A8 RID: 214952 RVA: 0x007149CD File Offset: 0x00712BCD
		public int PlotLineId { get; set; }

		// Token: 0x1700DB6A RID: 56170
		// (get) Token: 0x060347A9 RID: 214953 RVA: 0x007149D6 File Offset: 0x00712BD6
		// (set) Token: 0x060347AA RID: 214954 RVA: 0x007149DE File Offset: 0x00712BDE
		public string PlotLineKey { get; set; }

		// Token: 0x1700DB6B RID: 56171
		// (get) Token: 0x060347AB RID: 214955 RVA: 0x007149E7 File Offset: 0x00712BE7
		// (set) Token: 0x060347AC RID: 214956 RVA: 0x007149EF File Offset: 0x00712BEF
		public string Name { get; set; }

		// Token: 0x1700DB6C RID: 56172
		// (get) Token: 0x060347AD RID: 214957 RVA: 0x007149F8 File Offset: 0x00712BF8
		// (set) Token: 0x060347AE RID: 214958 RVA: 0x00714A00 File Offset: 0x00712C00
		public bool _Folded { get; set; }

		// Token: 0x1700DB6D RID: 56173
		// (get) Token: 0x060347AF RID: 214959 RVA: 0x00714A09 File Offset: 0x00712C09
		// (set) Token: 0x060347B0 RID: 214960 RVA: 0x00714A11 File Offset: 0x00712C11
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DB6E RID: 56174
		// (get) Token: 0x060347B1 RID: 214961 RVA: 0x00714A1A File Offset: 0x00712C1A
		// (set) Token: 0x060347B2 RID: 214962 RVA: 0x00714A22 File Offset: 0x00712C22
		public int WhoId { get; set; }

		// Token: 0x1700DB6F RID: 56175
		// (get) Token: 0x060347B3 RID: 214963 RVA: 0x00714A2B File Offset: 0x00712C2B
		// (set) Token: 0x060347B4 RID: 214964 RVA: 0x00714A33 File Offset: 0x00712C33
		public int TextId { get; set; }

		// Token: 0x1700DB70 RID: 56176
		// (get) Token: 0x060347B5 RID: 214965 RVA: 0x00714A3C File Offset: 0x00712C3C
		// (set) Token: 0x060347B6 RID: 214966 RVA: 0x00714A44 File Offset: 0x00712C44
		public string TidTalk { get; set; }

		// Token: 0x1700DB71 RID: 56177
		// (get) Token: 0x060347B7 RID: 214967 RVA: 0x00714A4D File Offset: 0x00712C4D
		// (set) Token: 0x060347B8 RID: 214968 RVA: 0x00714A55 File Offset: 0x00712C55
		public float WaitTime { get; set; }

		// Token: 0x1700DB72 RID: 56178
		// (get) Token: 0x060347B9 RID: 214969 RVA: 0x00714A5E File Offset: 0x00712C5E
		// (set) Token: 0x060347BA RID: 214970 RVA: 0x00714A66 File Offset: 0x00712C66
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DB73 RID: 56179
		// (get) Token: 0x060347BB RID: 214971 RVA: 0x00714A6F File Offset: 0x00712C6F
		// (set) Token: 0x060347BC RID: 214972 RVA: 0x00714A77 File Offset: 0x00712C77
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DB74 RID: 56180
		// (get) Token: 0x060347BD RID: 214973 RVA: 0x00714A80 File Offset: 0x00712C80
		// (set) Token: 0x060347BE RID: 214974 RVA: 0x00714A88 File Offset: 0x00712C88
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DB75 RID: 56181
		// (get) Token: 0x060347BF RID: 214975 RVA: 0x00714A91 File Offset: 0x00712C91
		// (set) Token: 0x060347C0 RID: 214976 RVA: 0x00714A99 File Offset: 0x00712C99
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DB76 RID: 56182
		// (get) Token: 0x060347C1 RID: 214977 RVA: 0x00714AA2 File Offset: 0x00712CA2
		// (set) Token: 0x060347C2 RID: 214978 RVA: 0x00714AAA File Offset: 0x00712CAA
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DB77 RID: 56183
		// (get) Token: 0x060347C3 RID: 214979 RVA: 0x00714AB3 File Offset: 0x00712CB3
		// (set) Token: 0x060347C4 RID: 214980 RVA: 0x00714ABB File Offset: 0x00712CBB
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DB78 RID: 56184
		// (get) Token: 0x060347C5 RID: 214981 RVA: 0x00714AC4 File Offset: 0x00712CC4
		// (set) Token: 0x060347C6 RID: 214982 RVA: 0x00714ACC File Offset: 0x00712CCC
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DB79 RID: 56185
		// (get) Token: 0x060347C7 RID: 214983 RVA: 0x00714AD5 File Offset: 0x00712CD5
		// (set) Token: 0x060347C8 RID: 214984 RVA: 0x00714ADD File Offset: 0x00712CDD
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DB7A RID: 56186
		// (get) Token: 0x060347C9 RID: 214985 RVA: 0x00714AE6 File Offset: 0x00712CE6
		// (set) Token: 0x060347CA RID: 214986 RVA: 0x00714AEE File Offset: 0x00712CEE
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DB7B RID: 56187
		// (get) Token: 0x060347CB RID: 214987 RVA: 0x00714AF7 File Offset: 0x00712CF7
		// (set) Token: 0x060347CC RID: 214988 RVA: 0x00714AFF File Offset: 0x00712CFF
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DB7C RID: 56188
		// (get) Token: 0x060347CD RID: 214989 RVA: 0x00714B08 File Offset: 0x00712D08
		// (set) Token: 0x060347CE RID: 214990 RVA: 0x00714B10 File Offset: 0x00712D10
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DB7D RID: 56189
		// (get) Token: 0x060347CF RID: 214991 RVA: 0x00714B19 File Offset: 0x00712D19
		// (set) Token: 0x060347D0 RID: 214992 RVA: 0x00714B21 File Offset: 0x00712D21
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DB7E RID: 56190
		// (get) Token: 0x060347D1 RID: 214993 RVA: 0x00714B2A File Offset: 0x00712D2A
		// (set) Token: 0x060347D2 RID: 214994 RVA: 0x00714B32 File Offset: 0x00712D32
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DB7F RID: 56191
		// (get) Token: 0x060347D3 RID: 214995 RVA: 0x00714B3B File Offset: 0x00712D3B
		// (set) Token: 0x060347D4 RID: 214996 RVA: 0x00714B43 File Offset: 0x00712D43
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DB80 RID: 56192
		// (get) Token: 0x060347D5 RID: 214997 RVA: 0x00714B4C File Offset: 0x00712D4C
		// (set) Token: 0x060347D6 RID: 214998 RVA: 0x00714B54 File Offset: 0x00712D54
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DB81 RID: 56193
		// (get) Token: 0x060347D7 RID: 214999 RVA: 0x00714B5D File Offset: 0x00712D5D
		// (set) Token: 0x060347D8 RID: 215000 RVA: 0x00714B65 File Offset: 0x00712D65
		public bool PlayVoice { get; set; }

		// Token: 0x1700DB82 RID: 56194
		// (get) Token: 0x060347D9 RID: 215001 RVA: 0x00714B6E File Offset: 0x00712D6E
		// (set) Token: 0x060347DA RID: 215002 RVA: 0x00714B76 File Offset: 0x00712D76
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DB83 RID: 56195
		// (get) Token: 0x060347DB RID: 215003 RVA: 0x00714B7F File Offset: 0x00712D7F
		// (set) Token: 0x060347DC RID: 215004 RVA: 0x00714B87 File Offset: 0x00712D87
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DB84 RID: 56196
		// (get) Token: 0x060347DD RID: 215005 RVA: 0x00714B90 File Offset: 0x00712D90
		// (set) Token: 0x060347DE RID: 215006 RVA: 0x00714B98 File Offset: 0x00712D98
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DB85 RID: 56197
		// (get) Token: 0x060347DF RID: 215007 RVA: 0x00714BA1 File Offset: 0x00712DA1
		// (set) Token: 0x060347E0 RID: 215008 RVA: 0x00714BA9 File Offset: 0x00712DA9
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DB86 RID: 56198
		// (get) Token: 0x060347E1 RID: 215009 RVA: 0x00714BB2 File Offset: 0x00712DB2
		// (set) Token: 0x060347E2 RID: 215010 RVA: 0x00714BBA File Offset: 0x00712DBA
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DB87 RID: 56199
		// (get) Token: 0x060347E3 RID: 215011 RVA: 0x00714BC3 File Offset: 0x00712DC3
		// (set) Token: 0x060347E4 RID: 215012 RVA: 0x00714BCB File Offset: 0x00712DCB
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DB88 RID: 56200
		// (get) Token: 0x060347E5 RID: 215013 RVA: 0x00714BD4 File Offset: 0x00712DD4
		// (set) Token: 0x060347E6 RID: 215014 RVA: 0x00714BDC File Offset: 0x00712DDC
		public uint NullMask { get; set; }

		// Token: 0x060347E7 RID: 215015 RVA: 0x00714BE8 File Offset: 0x00712DE8
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
