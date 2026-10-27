using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C6 RID: 29382
	public class ITalkItemAvgEnterT
	{
		// Token: 0x1700DA91 RID: 55953
		// (get) Token: 0x060344AA RID: 214186 RVA: 0x0070AB99 File Offset: 0x00708D99
		// (set) Token: 0x060344AB RID: 214187 RVA: 0x0070ABA1 File Offset: 0x00708DA1
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DA92 RID: 55954
		// (get) Token: 0x060344AC RID: 214188 RVA: 0x0070ABAA File Offset: 0x00708DAA
		// (set) Token: 0x060344AD RID: 214189 RVA: 0x0070ABB2 File Offset: 0x00708DB2
		public int Id { get; set; }

		// Token: 0x1700DA93 RID: 55955
		// (get) Token: 0x060344AE RID: 214190 RVA: 0x0070ABBB File Offset: 0x00708DBB
		// (set) Token: 0x060344AF RID: 214191 RVA: 0x0070ABC3 File Offset: 0x00708DC3
		public int PlotLineId { get; set; }

		// Token: 0x1700DA94 RID: 55956
		// (get) Token: 0x060344B0 RID: 214192 RVA: 0x0070ABCC File Offset: 0x00708DCC
		// (set) Token: 0x060344B1 RID: 214193 RVA: 0x0070ABD4 File Offset: 0x00708DD4
		public string PlotLineKey { get; set; }

		// Token: 0x1700DA95 RID: 55957
		// (get) Token: 0x060344B2 RID: 214194 RVA: 0x0070ABDD File Offset: 0x00708DDD
		// (set) Token: 0x060344B3 RID: 214195 RVA: 0x0070ABE5 File Offset: 0x00708DE5
		public string Name { get; set; }

		// Token: 0x1700DA96 RID: 55958
		// (get) Token: 0x060344B4 RID: 214196 RVA: 0x0070ABEE File Offset: 0x00708DEE
		// (set) Token: 0x060344B5 RID: 214197 RVA: 0x0070ABF6 File Offset: 0x00708DF6
		public bool _Folded { get; set; }

		// Token: 0x1700DA97 RID: 55959
		// (get) Token: 0x060344B6 RID: 214198 RVA: 0x0070ABFF File Offset: 0x00708DFF
		// (set) Token: 0x060344B7 RID: 214199 RVA: 0x0070AC07 File Offset: 0x00708E07
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DA98 RID: 55960
		// (get) Token: 0x060344B8 RID: 214200 RVA: 0x0070AC10 File Offset: 0x00708E10
		// (set) Token: 0x060344B9 RID: 214201 RVA: 0x0070AC18 File Offset: 0x00708E18
		public int WhoId { get; set; }

		// Token: 0x1700DA99 RID: 55961
		// (get) Token: 0x060344BA RID: 214202 RVA: 0x0070AC21 File Offset: 0x00708E21
		// (set) Token: 0x060344BB RID: 214203 RVA: 0x0070AC29 File Offset: 0x00708E29
		public int TextId { get; set; }

		// Token: 0x1700DA9A RID: 55962
		// (get) Token: 0x060344BC RID: 214204 RVA: 0x0070AC32 File Offset: 0x00708E32
		// (set) Token: 0x060344BD RID: 214205 RVA: 0x0070AC3A File Offset: 0x00708E3A
		public string TidTalk { get; set; }

		// Token: 0x1700DA9B RID: 55963
		// (get) Token: 0x060344BE RID: 214206 RVA: 0x0070AC43 File Offset: 0x00708E43
		// (set) Token: 0x060344BF RID: 214207 RVA: 0x0070AC4B File Offset: 0x00708E4B
		public float WaitTime { get; set; }

		// Token: 0x1700DA9C RID: 55964
		// (get) Token: 0x060344C0 RID: 214208 RVA: 0x0070AC54 File Offset: 0x00708E54
		// (set) Token: 0x060344C1 RID: 214209 RVA: 0x0070AC5C File Offset: 0x00708E5C
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DA9D RID: 55965
		// (get) Token: 0x060344C2 RID: 214210 RVA: 0x0070AC65 File Offset: 0x00708E65
		// (set) Token: 0x060344C3 RID: 214211 RVA: 0x0070AC6D File Offset: 0x00708E6D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DA9E RID: 55966
		// (get) Token: 0x060344C4 RID: 214212 RVA: 0x0070AC76 File Offset: 0x00708E76
		// (set) Token: 0x060344C5 RID: 214213 RVA: 0x0070AC7E File Offset: 0x00708E7E
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DA9F RID: 55967
		// (get) Token: 0x060344C6 RID: 214214 RVA: 0x0070AC87 File Offset: 0x00708E87
		// (set) Token: 0x060344C7 RID: 214215 RVA: 0x0070AC8F File Offset: 0x00708E8F
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DAA0 RID: 55968
		// (get) Token: 0x060344C8 RID: 214216 RVA: 0x0070AC98 File Offset: 0x00708E98
		// (set) Token: 0x060344C9 RID: 214217 RVA: 0x0070ACA0 File Offset: 0x00708EA0
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DAA1 RID: 55969
		// (get) Token: 0x060344CA RID: 214218 RVA: 0x0070ACA9 File Offset: 0x00708EA9
		// (set) Token: 0x060344CB RID: 214219 RVA: 0x0070ACB1 File Offset: 0x00708EB1
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DAA2 RID: 55970
		// (get) Token: 0x060344CC RID: 214220 RVA: 0x0070ACBA File Offset: 0x00708EBA
		// (set) Token: 0x060344CD RID: 214221 RVA: 0x0070ACC2 File Offset: 0x00708EC2
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DAA3 RID: 55971
		// (get) Token: 0x060344CE RID: 214222 RVA: 0x0070ACCB File Offset: 0x00708ECB
		// (set) Token: 0x060344CF RID: 214223 RVA: 0x0070ACD3 File Offset: 0x00708ED3
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DAA4 RID: 55972
		// (get) Token: 0x060344D0 RID: 214224 RVA: 0x0070ACDC File Offset: 0x00708EDC
		// (set) Token: 0x060344D1 RID: 214225 RVA: 0x0070ACE4 File Offset: 0x00708EE4
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DAA5 RID: 55973
		// (get) Token: 0x060344D2 RID: 214226 RVA: 0x0070ACED File Offset: 0x00708EED
		// (set) Token: 0x060344D3 RID: 214227 RVA: 0x0070ACF5 File Offset: 0x00708EF5
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DAA6 RID: 55974
		// (get) Token: 0x060344D4 RID: 214228 RVA: 0x0070ACFE File Offset: 0x00708EFE
		// (set) Token: 0x060344D5 RID: 214229 RVA: 0x0070AD06 File Offset: 0x00708F06
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DAA7 RID: 55975
		// (get) Token: 0x060344D6 RID: 214230 RVA: 0x0070AD0F File Offset: 0x00708F0F
		// (set) Token: 0x060344D7 RID: 214231 RVA: 0x0070AD17 File Offset: 0x00708F17
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DAA8 RID: 55976
		// (get) Token: 0x060344D8 RID: 214232 RVA: 0x0070AD20 File Offset: 0x00708F20
		// (set) Token: 0x060344D9 RID: 214233 RVA: 0x0070AD28 File Offset: 0x00708F28
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DAA9 RID: 55977
		// (get) Token: 0x060344DA RID: 214234 RVA: 0x0070AD31 File Offset: 0x00708F31
		// (set) Token: 0x060344DB RID: 214235 RVA: 0x0070AD39 File Offset: 0x00708F39
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DAAA RID: 55978
		// (get) Token: 0x060344DC RID: 214236 RVA: 0x0070AD42 File Offset: 0x00708F42
		// (set) Token: 0x060344DD RID: 214237 RVA: 0x0070AD4A File Offset: 0x00708F4A
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DAAB RID: 55979
		// (get) Token: 0x060344DE RID: 214238 RVA: 0x0070AD53 File Offset: 0x00708F53
		// (set) Token: 0x060344DF RID: 214239 RVA: 0x0070AD5B File Offset: 0x00708F5B
		public bool PlayVoice { get; set; }

		// Token: 0x1700DAAC RID: 55980
		// (get) Token: 0x060344E0 RID: 214240 RVA: 0x0070AD64 File Offset: 0x00708F64
		// (set) Token: 0x060344E1 RID: 214241 RVA: 0x0070AD6C File Offset: 0x00708F6C
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DAAD RID: 55981
		// (get) Token: 0x060344E2 RID: 214242 RVA: 0x0070AD75 File Offset: 0x00708F75
		// (set) Token: 0x060344E3 RID: 214243 RVA: 0x0070AD7D File Offset: 0x00708F7D
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DAAE RID: 55982
		// (get) Token: 0x060344E4 RID: 214244 RVA: 0x0070AD86 File Offset: 0x00708F86
		// (set) Token: 0x060344E5 RID: 214245 RVA: 0x0070AD8E File Offset: 0x00708F8E
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DAAF RID: 55983
		// (get) Token: 0x060344E6 RID: 214246 RVA: 0x0070AD97 File Offset: 0x00708F97
		// (set) Token: 0x060344E7 RID: 214247 RVA: 0x0070AD9F File Offset: 0x00708F9F
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DAB0 RID: 55984
		// (get) Token: 0x060344E8 RID: 214248 RVA: 0x0070ADA8 File Offset: 0x00708FA8
		// (set) Token: 0x060344E9 RID: 214249 RVA: 0x0070ADB0 File Offset: 0x00708FB0
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DAB1 RID: 55985
		// (get) Token: 0x060344EA RID: 214250 RVA: 0x0070ADB9 File Offset: 0x00708FB9
		// (set) Token: 0x060344EB RID: 214251 RVA: 0x0070ADC1 File Offset: 0x00708FC1
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DAB2 RID: 55986
		// (get) Token: 0x060344EC RID: 214252 RVA: 0x0070ADCA File Offset: 0x00708FCA
		// (set) Token: 0x060344ED RID: 214253 RVA: 0x0070ADD2 File Offset: 0x00708FD2
		public ITalkItemAvgRoleConfigT AvgRoleConfig { get; set; }

		// Token: 0x1700DAB3 RID: 55987
		// (get) Token: 0x060344EE RID: 214254 RVA: 0x0070ADDB File Offset: 0x00708FDB
		// (set) Token: 0x060344EF RID: 214255 RVA: 0x0070ADE3 File Offset: 0x00708FE3
		public EAvgRolePosition PositionConfig { get; set; }

		// Token: 0x1700DAB4 RID: 55988
		// (get) Token: 0x060344F0 RID: 214256 RVA: 0x0070ADEC File Offset: 0x00708FEC
		// (set) Token: 0x060344F1 RID: 214257 RVA: 0x0070ADF4 File Offset: 0x00708FF4
		public uint NullMask { get; set; }

		// Token: 0x060344F2 RID: 214258 RVA: 0x0070AE00 File Offset: 0x00709000
		public ITalkItemAvgEnterT()
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
			this.AvgRoleConfig = null;
			this.PositionConfig = EAvgRolePosition.Center;
			this.NullMask = 0U;
		}
	}
}
