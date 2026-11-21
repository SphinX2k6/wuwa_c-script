using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AB6 RID: 31414
	public class ITalkItemNoTextItemT
	{
		// Token: 0x1700E89B RID: 59547
		// (get) Token: 0x06037F00 RID: 229120 RVA: 0x00783F9C File Offset: 0x0078219C
		// (set) Token: 0x06037F01 RID: 229121 RVA: 0x00783FA4 File Offset: 0x007821A4
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E89C RID: 59548
		// (get) Token: 0x06037F02 RID: 229122 RVA: 0x00783FAD File Offset: 0x007821AD
		// (set) Token: 0x06037F03 RID: 229123 RVA: 0x00783FB5 File Offset: 0x007821B5
		public int Id { get; set; }

		// Token: 0x1700E89D RID: 59549
		// (get) Token: 0x06037F04 RID: 229124 RVA: 0x00783FBE File Offset: 0x007821BE
		// (set) Token: 0x06037F05 RID: 229125 RVA: 0x00783FC6 File Offset: 0x007821C6
		public int PlotLineId { get; set; }

		// Token: 0x1700E89E RID: 59550
		// (get) Token: 0x06037F06 RID: 229126 RVA: 0x00783FCF File Offset: 0x007821CF
		// (set) Token: 0x06037F07 RID: 229127 RVA: 0x00783FD7 File Offset: 0x007821D7
		public string PlotLineKey { get; set; }

		// Token: 0x1700E89F RID: 59551
		// (get) Token: 0x06037F08 RID: 229128 RVA: 0x00783FE0 File Offset: 0x007821E0
		// (set) Token: 0x06037F09 RID: 229129 RVA: 0x00783FE8 File Offset: 0x007821E8
		public string Name { get; set; }

		// Token: 0x1700E8A0 RID: 59552
		// (get) Token: 0x06037F0A RID: 229130 RVA: 0x00783FF1 File Offset: 0x007821F1
		// (set) Token: 0x06037F0B RID: 229131 RVA: 0x00783FF9 File Offset: 0x007821F9
		public bool _Folded { get; set; }

		// Token: 0x1700E8A1 RID: 59553
		// (get) Token: 0x06037F0C RID: 229132 RVA: 0x00784002 File Offset: 0x00782202
		// (set) Token: 0x06037F0D RID: 229133 RVA: 0x0078400A File Offset: 0x0078220A
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E8A2 RID: 59554
		// (get) Token: 0x06037F0E RID: 229134 RVA: 0x00784013 File Offset: 0x00782213
		// (set) Token: 0x06037F0F RID: 229135 RVA: 0x0078401B File Offset: 0x0078221B
		public int WhoId { get; set; }

		// Token: 0x1700E8A3 RID: 59555
		// (get) Token: 0x06037F10 RID: 229136 RVA: 0x00784024 File Offset: 0x00782224
		// (set) Token: 0x06037F11 RID: 229137 RVA: 0x0078402C File Offset: 0x0078222C
		public int TextId { get; set; }

		// Token: 0x1700E8A4 RID: 59556
		// (get) Token: 0x06037F12 RID: 229138 RVA: 0x00784035 File Offset: 0x00782235
		// (set) Token: 0x06037F13 RID: 229139 RVA: 0x0078403D File Offset: 0x0078223D
		public string TidTalk { get; set; }

		// Token: 0x1700E8A5 RID: 59557
		// (get) Token: 0x06037F14 RID: 229140 RVA: 0x00784046 File Offset: 0x00782246
		// (set) Token: 0x06037F15 RID: 229141 RVA: 0x0078404E File Offset: 0x0078224E
		public float WaitTime { get; set; }

		// Token: 0x1700E8A6 RID: 59558
		// (get) Token: 0x06037F16 RID: 229142 RVA: 0x00784057 File Offset: 0x00782257
		// (set) Token: 0x06037F17 RID: 229143 RVA: 0x0078405F File Offset: 0x0078225F
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E8A7 RID: 59559
		// (get) Token: 0x06037F18 RID: 229144 RVA: 0x00784068 File Offset: 0x00782268
		// (set) Token: 0x06037F19 RID: 229145 RVA: 0x00784070 File Offset: 0x00782270
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E8A8 RID: 59560
		// (get) Token: 0x06037F1A RID: 229146 RVA: 0x00784079 File Offset: 0x00782279
		// (set) Token: 0x06037F1B RID: 229147 RVA: 0x00784081 File Offset: 0x00782281
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E8A9 RID: 59561
		// (get) Token: 0x06037F1C RID: 229148 RVA: 0x0078408A File Offset: 0x0078228A
		// (set) Token: 0x06037F1D RID: 229149 RVA: 0x00784092 File Offset: 0x00782292
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E8AA RID: 59562
		// (get) Token: 0x06037F1E RID: 229150 RVA: 0x0078409B File Offset: 0x0078229B
		// (set) Token: 0x06037F1F RID: 229151 RVA: 0x007840A3 File Offset: 0x007822A3
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E8AB RID: 59563
		// (get) Token: 0x06037F20 RID: 229152 RVA: 0x007840AC File Offset: 0x007822AC
		// (set) Token: 0x06037F21 RID: 229153 RVA: 0x007840B4 File Offset: 0x007822B4
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E8AC RID: 59564
		// (get) Token: 0x06037F22 RID: 229154 RVA: 0x007840BD File Offset: 0x007822BD
		// (set) Token: 0x06037F23 RID: 229155 RVA: 0x007840C5 File Offset: 0x007822C5
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E8AD RID: 59565
		// (get) Token: 0x06037F24 RID: 229156 RVA: 0x007840CE File Offset: 0x007822CE
		// (set) Token: 0x06037F25 RID: 229157 RVA: 0x007840D6 File Offset: 0x007822D6
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E8AE RID: 59566
		// (get) Token: 0x06037F26 RID: 229158 RVA: 0x007840DF File Offset: 0x007822DF
		// (set) Token: 0x06037F27 RID: 229159 RVA: 0x007840E7 File Offset: 0x007822E7
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E8AF RID: 59567
		// (get) Token: 0x06037F28 RID: 229160 RVA: 0x007840F0 File Offset: 0x007822F0
		// (set) Token: 0x06037F29 RID: 229161 RVA: 0x007840F8 File Offset: 0x007822F8
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E8B0 RID: 59568
		// (get) Token: 0x06037F2A RID: 229162 RVA: 0x00784101 File Offset: 0x00782301
		// (set) Token: 0x06037F2B RID: 229163 RVA: 0x00784109 File Offset: 0x00782309
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E8B1 RID: 59569
		// (get) Token: 0x06037F2C RID: 229164 RVA: 0x00784112 File Offset: 0x00782312
		// (set) Token: 0x06037F2D RID: 229165 RVA: 0x0078411A File Offset: 0x0078231A
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E8B2 RID: 59570
		// (get) Token: 0x06037F2E RID: 229166 RVA: 0x00784123 File Offset: 0x00782323
		// (set) Token: 0x06037F2F RID: 229167 RVA: 0x0078412B File Offset: 0x0078232B
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E8B3 RID: 59571
		// (get) Token: 0x06037F30 RID: 229168 RVA: 0x00784134 File Offset: 0x00782334
		// (set) Token: 0x06037F31 RID: 229169 RVA: 0x0078413C File Offset: 0x0078233C
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E8B4 RID: 59572
		// (get) Token: 0x06037F32 RID: 229170 RVA: 0x00784145 File Offset: 0x00782345
		// (set) Token: 0x06037F33 RID: 229171 RVA: 0x0078414D File Offset: 0x0078234D
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E8B5 RID: 59573
		// (get) Token: 0x06037F34 RID: 229172 RVA: 0x00784156 File Offset: 0x00782356
		// (set) Token: 0x06037F35 RID: 229173 RVA: 0x0078415E File Offset: 0x0078235E
		public bool PlayVoice { get; set; }

		// Token: 0x1700E8B6 RID: 59574
		// (get) Token: 0x06037F36 RID: 229174 RVA: 0x00784167 File Offset: 0x00782367
		// (set) Token: 0x06037F37 RID: 229175 RVA: 0x0078416F File Offset: 0x0078236F
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E8B7 RID: 59575
		// (get) Token: 0x06037F38 RID: 229176 RVA: 0x00784178 File Offset: 0x00782378
		// (set) Token: 0x06037F39 RID: 229177 RVA: 0x00784180 File Offset: 0x00782380
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E8B8 RID: 59576
		// (get) Token: 0x06037F3A RID: 229178 RVA: 0x00784189 File Offset: 0x00782389
		// (set) Token: 0x06037F3B RID: 229179 RVA: 0x00784191 File Offset: 0x00782391
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E8B9 RID: 59577
		// (get) Token: 0x06037F3C RID: 229180 RVA: 0x0078419A File Offset: 0x0078239A
		// (set) Token: 0x06037F3D RID: 229181 RVA: 0x007841A2 File Offset: 0x007823A2
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E8BA RID: 59578
		// (get) Token: 0x06037F3E RID: 229182 RVA: 0x007841AB File Offset: 0x007823AB
		// (set) Token: 0x06037F3F RID: 229183 RVA: 0x007841B3 File Offset: 0x007823B3
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E8BB RID: 59579
		// (get) Token: 0x06037F40 RID: 229184 RVA: 0x007841BC File Offset: 0x007823BC
		// (set) Token: 0x06037F41 RID: 229185 RVA: 0x007841C4 File Offset: 0x007823C4
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E8BC RID: 59580
		// (get) Token: 0x06037F42 RID: 229186 RVA: 0x007841CD File Offset: 0x007823CD
		// (set) Token: 0x06037F43 RID: 229187 RVA: 0x007841D5 File Offset: 0x007823D5
		public TShowTalkCameraMotionUnion CameraMotion { get; set; }

		// Token: 0x1700E8BD RID: 59581
		// (get) Token: 0x06037F44 RID: 229188 RVA: 0x007841DE File Offset: 0x007823DE
		// (set) Token: 0x06037F45 RID: 229189 RVA: 0x007841E6 File Offset: 0x007823E6
		public uint NullMask { get; set; }

		// Token: 0x06037F46 RID: 229190 RVA: 0x007841F0 File Offset: 0x007823F0
		public ITalkItemNoTextItemT()
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
			this.CameraMotion = null;
			this.NullMask = 0U;
		}
	}
}
