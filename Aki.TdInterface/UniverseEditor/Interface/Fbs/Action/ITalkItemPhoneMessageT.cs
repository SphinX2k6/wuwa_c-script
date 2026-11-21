using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ABC RID: 31420
	public class ITalkItemPhoneMessageT
	{
		// Token: 0x1700E92F RID: 59695
		// (get) Token: 0x06038115 RID: 229653 RVA: 0x0078B07F File Offset: 0x0078927F
		// (set) Token: 0x06038116 RID: 229654 RVA: 0x0078B087 File Offset: 0x00789287
		public ETalkItemType Type { get; set; }

		// Token: 0x1700E930 RID: 59696
		// (get) Token: 0x06038117 RID: 229655 RVA: 0x0078B090 File Offset: 0x00789290
		// (set) Token: 0x06038118 RID: 229656 RVA: 0x0078B098 File Offset: 0x00789298
		public int Id { get; set; }

		// Token: 0x1700E931 RID: 59697
		// (get) Token: 0x06038119 RID: 229657 RVA: 0x0078B0A1 File Offset: 0x007892A1
		// (set) Token: 0x0603811A RID: 229658 RVA: 0x0078B0A9 File Offset: 0x007892A9
		public int PlotLineId { get; set; }

		// Token: 0x1700E932 RID: 59698
		// (get) Token: 0x0603811B RID: 229659 RVA: 0x0078B0B2 File Offset: 0x007892B2
		// (set) Token: 0x0603811C RID: 229660 RVA: 0x0078B0BA File Offset: 0x007892BA
		public string PlotLineKey { get; set; }

		// Token: 0x1700E933 RID: 59699
		// (get) Token: 0x0603811D RID: 229661 RVA: 0x0078B0C3 File Offset: 0x007892C3
		// (set) Token: 0x0603811E RID: 229662 RVA: 0x0078B0CB File Offset: 0x007892CB
		public string Name { get; set; }

		// Token: 0x1700E934 RID: 59700
		// (get) Token: 0x0603811F RID: 229663 RVA: 0x0078B0D4 File Offset: 0x007892D4
		// (set) Token: 0x06038120 RID: 229664 RVA: 0x0078B0DC File Offset: 0x007892DC
		public bool _Folded { get; set; }

		// Token: 0x1700E935 RID: 59701
		// (get) Token: 0x06038121 RID: 229665 RVA: 0x0078B0E5 File Offset: 0x007892E5
		// (set) Token: 0x06038122 RID: 229666 RVA: 0x0078B0ED File Offset: 0x007892ED
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700E936 RID: 59702
		// (get) Token: 0x06038123 RID: 229667 RVA: 0x0078B0F6 File Offset: 0x007892F6
		// (set) Token: 0x06038124 RID: 229668 RVA: 0x0078B0FE File Offset: 0x007892FE
		public int WhoId { get; set; }

		// Token: 0x1700E937 RID: 59703
		// (get) Token: 0x06038125 RID: 229669 RVA: 0x0078B107 File Offset: 0x00789307
		// (set) Token: 0x06038126 RID: 229670 RVA: 0x0078B10F File Offset: 0x0078930F
		public int TextId { get; set; }

		// Token: 0x1700E938 RID: 59704
		// (get) Token: 0x06038127 RID: 229671 RVA: 0x0078B118 File Offset: 0x00789318
		// (set) Token: 0x06038128 RID: 229672 RVA: 0x0078B120 File Offset: 0x00789320
		public string TidTalk { get; set; }

		// Token: 0x1700E939 RID: 59705
		// (get) Token: 0x06038129 RID: 229673 RVA: 0x0078B129 File Offset: 0x00789329
		// (set) Token: 0x0603812A RID: 229674 RVA: 0x0078B131 File Offset: 0x00789331
		public float WaitTime { get; set; }

		// Token: 0x1700E93A RID: 59706
		// (get) Token: 0x0603812B RID: 229675 RVA: 0x0078B13A File Offset: 0x0078933A
		// (set) Token: 0x0603812C RID: 229676 RVA: 0x0078B142 File Offset: 0x00789342
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700E93B RID: 59707
		// (get) Token: 0x0603812D RID: 229677 RVA: 0x0078B14B File Offset: 0x0078934B
		// (set) Token: 0x0603812E RID: 229678 RVA: 0x0078B153 File Offset: 0x00789353
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E93C RID: 59708
		// (get) Token: 0x0603812F RID: 229679 RVA: 0x0078B15C File Offset: 0x0078935C
		// (set) Token: 0x06038130 RID: 229680 RVA: 0x0078B164 File Offset: 0x00789364
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700E93D RID: 59709
		// (get) Token: 0x06038131 RID: 229681 RVA: 0x0078B16D File Offset: 0x0078936D
		// (set) Token: 0x06038132 RID: 229682 RVA: 0x0078B175 File Offset: 0x00789375
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700E93E RID: 59710
		// (get) Token: 0x06038133 RID: 229683 RVA: 0x0078B17E File Offset: 0x0078937E
		// (set) Token: 0x06038134 RID: 229684 RVA: 0x0078B186 File Offset: 0x00789386
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700E93F RID: 59711
		// (get) Token: 0x06038135 RID: 229685 RVA: 0x0078B18F File Offset: 0x0078938F
		// (set) Token: 0x06038136 RID: 229686 RVA: 0x0078B197 File Offset: 0x00789397
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700E940 RID: 59712
		// (get) Token: 0x06038137 RID: 229687 RVA: 0x0078B1A0 File Offset: 0x007893A0
		// (set) Token: 0x06038138 RID: 229688 RVA: 0x0078B1A8 File Offset: 0x007893A8
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700E941 RID: 59713
		// (get) Token: 0x06038139 RID: 229689 RVA: 0x0078B1B1 File Offset: 0x007893B1
		// (set) Token: 0x0603813A RID: 229690 RVA: 0x0078B1B9 File Offset: 0x007893B9
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700E942 RID: 59714
		// (get) Token: 0x0603813B RID: 229691 RVA: 0x0078B1C2 File Offset: 0x007893C2
		// (set) Token: 0x0603813C RID: 229692 RVA: 0x0078B1CA File Offset: 0x007893CA
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700E943 RID: 59715
		// (get) Token: 0x0603813D RID: 229693 RVA: 0x0078B1D3 File Offset: 0x007893D3
		// (set) Token: 0x0603813E RID: 229694 RVA: 0x0078B1DB File Offset: 0x007893DB
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700E944 RID: 59716
		// (get) Token: 0x0603813F RID: 229695 RVA: 0x0078B1E4 File Offset: 0x007893E4
		// (set) Token: 0x06038140 RID: 229696 RVA: 0x0078B1EC File Offset: 0x007893EC
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700E945 RID: 59717
		// (get) Token: 0x06038141 RID: 229697 RVA: 0x0078B1F5 File Offset: 0x007893F5
		// (set) Token: 0x06038142 RID: 229698 RVA: 0x0078B1FD File Offset: 0x007893FD
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700E946 RID: 59718
		// (get) Token: 0x06038143 RID: 229699 RVA: 0x0078B206 File Offset: 0x00789406
		// (set) Token: 0x06038144 RID: 229700 RVA: 0x0078B20E File Offset: 0x0078940E
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700E947 RID: 59719
		// (get) Token: 0x06038145 RID: 229701 RVA: 0x0078B217 File Offset: 0x00789417
		// (set) Token: 0x06038146 RID: 229702 RVA: 0x0078B21F File Offset: 0x0078941F
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700E948 RID: 59720
		// (get) Token: 0x06038147 RID: 229703 RVA: 0x0078B228 File Offset: 0x00789428
		// (set) Token: 0x06038148 RID: 229704 RVA: 0x0078B230 File Offset: 0x00789430
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700E949 RID: 59721
		// (get) Token: 0x06038149 RID: 229705 RVA: 0x0078B239 File Offset: 0x00789439
		// (set) Token: 0x0603814A RID: 229706 RVA: 0x0078B241 File Offset: 0x00789441
		public bool PlayVoice { get; set; }

		// Token: 0x1700E94A RID: 59722
		// (get) Token: 0x0603814B RID: 229707 RVA: 0x0078B24A File Offset: 0x0078944A
		// (set) Token: 0x0603814C RID: 229708 RVA: 0x0078B252 File Offset: 0x00789452
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700E94B RID: 59723
		// (get) Token: 0x0603814D RID: 229709 RVA: 0x0078B25B File Offset: 0x0078945B
		// (set) Token: 0x0603814E RID: 229710 RVA: 0x0078B263 File Offset: 0x00789463
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700E94C RID: 59724
		// (get) Token: 0x0603814F RID: 229711 RVA: 0x0078B26C File Offset: 0x0078946C
		// (set) Token: 0x06038150 RID: 229712 RVA: 0x0078B274 File Offset: 0x00789474
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700E94D RID: 59725
		// (get) Token: 0x06038151 RID: 229713 RVA: 0x0078B27D File Offset: 0x0078947D
		// (set) Token: 0x06038152 RID: 229714 RVA: 0x0078B285 File Offset: 0x00789485
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700E94E RID: 59726
		// (get) Token: 0x06038153 RID: 229715 RVA: 0x0078B28E File Offset: 0x0078948E
		// (set) Token: 0x06038154 RID: 229716 RVA: 0x0078B296 File Offset: 0x00789496
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700E94F RID: 59727
		// (get) Token: 0x06038155 RID: 229717 RVA: 0x0078B29F File Offset: 0x0078949F
		// (set) Token: 0x06038156 RID: 229718 RVA: 0x0078B2A7 File Offset: 0x007894A7
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E950 RID: 59728
		// (get) Token: 0x06038157 RID: 229719 RVA: 0x0078B2B0 File Offset: 0x007894B0
		// (set) Token: 0x06038158 RID: 229720 RVA: 0x0078B2B8 File Offset: 0x007894B8
		public TPhoneMessageTypeUnion MessageType { get; set; }

		// Token: 0x1700E951 RID: 59729
		// (get) Token: 0x06038159 RID: 229721 RVA: 0x0078B2C1 File Offset: 0x007894C1
		// (set) Token: 0x0603815A RID: 229722 RVA: 0x0078B2C9 File Offset: 0x007894C9
		public TTalkItemStyleUnion Style { get; set; }

		// Token: 0x1700E952 RID: 59730
		// (get) Token: 0x0603815B RID: 229723 RVA: 0x0078B2D2 File Offset: 0x007894D2
		// (set) Token: 0x0603815C RID: 229724 RVA: 0x0078B2DA File Offset: 0x007894DA
		public float OtherIsTypingDuration { get; set; }

		// Token: 0x1700E953 RID: 59731
		// (get) Token: 0x0603815D RID: 229725 RVA: 0x0078B2E3 File Offset: 0x007894E3
		// (set) Token: 0x0603815E RID: 229726 RVA: 0x0078B2EB File Offset: 0x007894EB
		public uint NullMask { get; set; }

		// Token: 0x0603815F RID: 229727 RVA: 0x0078B2F4 File Offset: 0x007894F4
		public ITalkItemPhoneMessageT()
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
			this.MessageType = null;
			this.Style = null;
			this.OtherIsTypingDuration = 0f;
			this.NullMask = 0U;
		}
	}
}
