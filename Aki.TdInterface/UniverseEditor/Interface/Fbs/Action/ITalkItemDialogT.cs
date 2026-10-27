using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DB RID: 29403
	public class ITalkItemDialogT
	{
		// Token: 0x1700DC4F RID: 56399
		// (get) Token: 0x06034AD4 RID: 215764 RVA: 0x0071F1B1 File Offset: 0x0071D3B1
		// (set) Token: 0x06034AD5 RID: 215765 RVA: 0x0071F1B9 File Offset: 0x0071D3B9
		public ETalkItemType Type { get; set; }

		// Token: 0x1700DC50 RID: 56400
		// (get) Token: 0x06034AD6 RID: 215766 RVA: 0x0071F1C2 File Offset: 0x0071D3C2
		// (set) Token: 0x06034AD7 RID: 215767 RVA: 0x0071F1CA File Offset: 0x0071D3CA
		public int Id { get; set; }

		// Token: 0x1700DC51 RID: 56401
		// (get) Token: 0x06034AD8 RID: 215768 RVA: 0x0071F1D3 File Offset: 0x0071D3D3
		// (set) Token: 0x06034AD9 RID: 215769 RVA: 0x0071F1DB File Offset: 0x0071D3DB
		public int PlotLineId { get; set; }

		// Token: 0x1700DC52 RID: 56402
		// (get) Token: 0x06034ADA RID: 215770 RVA: 0x0071F1E4 File Offset: 0x0071D3E4
		// (set) Token: 0x06034ADB RID: 215771 RVA: 0x0071F1EC File Offset: 0x0071D3EC
		public string PlotLineKey { get; set; }

		// Token: 0x1700DC53 RID: 56403
		// (get) Token: 0x06034ADC RID: 215772 RVA: 0x0071F1F5 File Offset: 0x0071D3F5
		// (set) Token: 0x06034ADD RID: 215773 RVA: 0x0071F1FD File Offset: 0x0071D3FD
		public string Name { get; set; }

		// Token: 0x1700DC54 RID: 56404
		// (get) Token: 0x06034ADE RID: 215774 RVA: 0x0071F206 File Offset: 0x0071D406
		// (set) Token: 0x06034ADF RID: 215775 RVA: 0x0071F20E File Offset: 0x0071D40E
		public bool _Folded { get; set; }

		// Token: 0x1700DC55 RID: 56405
		// (get) Token: 0x06034AE0 RID: 215776 RVA: 0x0071F217 File Offset: 0x0071D417
		// (set) Token: 0x06034AE1 RID: 215777 RVA: 0x0071F21F File Offset: 0x0071D41F
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DC56 RID: 56406
		// (get) Token: 0x06034AE2 RID: 215778 RVA: 0x0071F228 File Offset: 0x0071D428
		// (set) Token: 0x06034AE3 RID: 215779 RVA: 0x0071F230 File Offset: 0x0071D430
		public int WhoId { get; set; }

		// Token: 0x1700DC57 RID: 56407
		// (get) Token: 0x06034AE4 RID: 215780 RVA: 0x0071F239 File Offset: 0x0071D439
		// (set) Token: 0x06034AE5 RID: 215781 RVA: 0x0071F241 File Offset: 0x0071D441
		public int TextId { get; set; }

		// Token: 0x1700DC58 RID: 56408
		// (get) Token: 0x06034AE6 RID: 215782 RVA: 0x0071F24A File Offset: 0x0071D44A
		// (set) Token: 0x06034AE7 RID: 215783 RVA: 0x0071F252 File Offset: 0x0071D452
		public string TidTalk { get; set; }

		// Token: 0x1700DC59 RID: 56409
		// (get) Token: 0x06034AE8 RID: 215784 RVA: 0x0071F25B File Offset: 0x0071D45B
		// (set) Token: 0x06034AE9 RID: 215785 RVA: 0x0071F263 File Offset: 0x0071D463
		public float WaitTime { get; set; }

		// Token: 0x1700DC5A RID: 56410
		// (get) Token: 0x06034AEA RID: 215786 RVA: 0x0071F26C File Offset: 0x0071D46C
		// (set) Token: 0x06034AEB RID: 215787 RVA: 0x0071F274 File Offset: 0x0071D474
		public ICaptionParamT CaptionParams { get; set; }

		// Token: 0x1700DC5B RID: 56411
		// (get) Token: 0x06034AEC RID: 215788 RVA: 0x0071F27D File Offset: 0x0071D47D
		// (set) Token: 0x06034AED RID: 215789 RVA: 0x0071F285 File Offset: 0x0071D485
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DC5C RID: 56412
		// (get) Token: 0x06034AEE RID: 215790 RVA: 0x0071F28E File Offset: 0x0071D48E
		// (set) Token: 0x06034AEF RID: 215791 RVA: 0x0071F296 File Offset: 0x0071D496
		public List<ITalkOptionT> Options { get; set; }

		// Token: 0x1700DC5D RID: 56413
		// (get) Token: 0x06034AF0 RID: 215792 RVA: 0x0071F29F File Offset: 0x0071D49F
		// (set) Token: 0x06034AF1 RID: 215793 RVA: 0x0071F2A7 File Offset: 0x0071D4A7
		public IPlayMontageT Montage { get; set; }

		// Token: 0x1700DC5E RID: 56414
		// (get) Token: 0x06034AF2 RID: 215794 RVA: 0x0071F2B0 File Offset: 0x0071D4B0
		// (set) Token: 0x06034AF3 RID: 215795 RVA: 0x0071F2B8 File Offset: 0x0071D4B8
		public ICameraDataT CameraData { get; set; }

		// Token: 0x1700DC5F RID: 56415
		// (get) Token: 0x06034AF4 RID: 215796 RVA: 0x0071F2C1 File Offset: 0x0071D4C1
		// (set) Token: 0x06034AF5 RID: 215797 RVA: 0x0071F2C9 File Offset: 0x0071D4C9
		public ISetFlowTemplateT FlowTemplate { get; set; }

		// Token: 0x1700DC60 RID: 56416
		// (get) Token: 0x06034AF6 RID: 215798 RVA: 0x0071F2D2 File Offset: 0x0071D4D2
		// (set) Token: 0x06034AF7 RID: 215799 RVA: 0x0071F2DA File Offset: 0x0071D4DA
		public List<ISetFlowTemplateT> FlowTemplateList { get; set; }

		// Token: 0x1700DC61 RID: 56417
		// (get) Token: 0x06034AF8 RID: 215800 RVA: 0x0071F2E3 File Offset: 0x0071D4E3
		// (set) Token: 0x06034AF9 RID: 215801 RVA: 0x0071F2EB File Offset: 0x0071D4EB
		public List<IMontageDataT> ActorMontageArray { get; set; }

		// Token: 0x1700DC62 RID: 56418
		// (get) Token: 0x06034AFA RID: 215802 RVA: 0x0071F2F4 File Offset: 0x0071D4F4
		// (set) Token: 0x06034AFB RID: 215803 RVA: 0x0071F2FC File Offset: 0x0071D4FC
		public List<IActorFaceExpressionT> ActorFaceExpressionArray { get; set; }

		// Token: 0x1700DC63 RID: 56419
		// (get) Token: 0x06034AFC RID: 215804 RVA: 0x0071F305 File Offset: 0x0071D505
		// (set) Token: 0x06034AFD RID: 215805 RVA: 0x0071F30D File Offset: 0x0071D50D
		public List<IActorLookAtT> ActorLookAtArray { get; set; }

		// Token: 0x1700DC64 RID: 56420
		// (get) Token: 0x06034AFE RID: 215806 RVA: 0x0071F316 File Offset: 0x0071D516
		// (set) Token: 0x06034AFF RID: 215807 RVA: 0x0071F31E File Offset: 0x0071D51E
		public List<IActorTurnToT> ActorTurnToArray { get; set; }

		// Token: 0x1700DC65 RID: 56421
		// (get) Token: 0x06034B00 RID: 215808 RVA: 0x0071F327 File Offset: 0x0071D527
		// (set) Token: 0x06034B01 RID: 215809 RVA: 0x0071F32F File Offset: 0x0071D52F
		public TPostAkEventUnion TalkAkEvent { get; set; }

		// Token: 0x1700DC66 RID: 56422
		// (get) Token: 0x06034B02 RID: 215810 RVA: 0x0071F338 File Offset: 0x0071D538
		// (set) Token: 0x06034B03 RID: 215811 RVA: 0x0071F340 File Offset: 0x0071D540
		public TPostAkEventUnion TalkEndAkEvent { get; set; }

		// Token: 0x1700DC67 RID: 56423
		// (get) Token: 0x06034B04 RID: 215812 RVA: 0x0071F349 File Offset: 0x0071D549
		// (set) Token: 0x06034B05 RID: 215813 RVA: 0x0071F351 File Offset: 0x0071D551
		public IUniversalToneT UniversalTone { get; set; }

		// Token: 0x1700DC68 RID: 56424
		// (get) Token: 0x06034B06 RID: 215814 RVA: 0x0071F35A File Offset: 0x0071D55A
		// (set) Token: 0x06034B07 RID: 215815 RVA: 0x0071F362 File Offset: 0x0071D562
		public TTalkBackgroundUnion BackgroundConfig { get; set; }

		// Token: 0x1700DC69 RID: 56425
		// (get) Token: 0x06034B08 RID: 215816 RVA: 0x0071F36B File Offset: 0x0071D56B
		// (set) Token: 0x06034B09 RID: 215817 RVA: 0x0071F373 File Offset: 0x0071D573
		public bool PlayVoice { get; set; }

		// Token: 0x1700DC6A RID: 56426
		// (get) Token: 0x06034B0A RID: 215818 RVA: 0x0071F37C File Offset: 0x0071D57C
		// (set) Token: 0x06034B0B RID: 215819 RVA: 0x0071F384 File Offset: 0x0071D584
		public ITimeLimitOptionGroupT TimeLimitOptionGroup { get; set; }

		// Token: 0x1700DC6B RID: 56427
		// (get) Token: 0x06034B0C RID: 215820 RVA: 0x0071F38D File Offset: 0x0071D58D
		// (set) Token: 0x06034B0D RID: 215821 RVA: 0x0071F395 File Offset: 0x0071D595
		public IGamepadShakeInTalkT GamepadShake { get; set; }

		// Token: 0x1700DC6C RID: 56428
		// (get) Token: 0x06034B0E RID: 215822 RVA: 0x0071F39E File Offset: 0x0071D59E
		// (set) Token: 0x06034B0F RID: 215823 RVA: 0x0071F3A6 File Offset: 0x0071D5A6
		public List<IActionInfoT> IntroActions { get; set; }

		// Token: 0x1700DC6D RID: 56429
		// (get) Token: 0x06034B10 RID: 215824 RVA: 0x0071F3AF File Offset: 0x0071D5AF
		// (set) Token: 0x06034B11 RID: 215825 RVA: 0x0071F3B7 File Offset: 0x0071D5B7
		public List<IActorFxEmoteT> ActorFxEmoteArray { get; set; }

		// Token: 0x1700DC6E RID: 56430
		// (get) Token: 0x06034B12 RID: 215826 RVA: 0x0071F3C0 File Offset: 0x0071D5C0
		// (set) Token: 0x06034B13 RID: 215827 RVA: 0x0071F3C8 File Offset: 0x0071D5C8
		public List<TTalkEffectActionUnion> TalkEffectArray { get; set; }

		// Token: 0x1700DC6F RID: 56431
		// (get) Token: 0x06034B14 RID: 215828 RVA: 0x0071F3D1 File Offset: 0x0071D5D1
		// (set) Token: 0x06034B15 RID: 215829 RVA: 0x0071F3D9 File Offset: 0x0071D5D9
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700DC70 RID: 56432
		// (get) Token: 0x06034B16 RID: 215830 RVA: 0x0071F3E2 File Offset: 0x0071D5E2
		// (set) Token: 0x06034B17 RID: 215831 RVA: 0x0071F3EA File Offset: 0x0071D5EA
		public TTalkItemStyleUnion Style { get; set; }

		// Token: 0x1700DC71 RID: 56433
		// (get) Token: 0x06034B18 RID: 215832 RVA: 0x0071F3F3 File Offset: 0x0071D5F3
		// (set) Token: 0x06034B19 RID: 215833 RVA: 0x0071F3FB File Offset: 0x0071D5FB
		public TShowTalkCameraMotionUnion CameraMotion { get; set; }

		// Token: 0x1700DC72 RID: 56434
		// (get) Token: 0x06034B1A RID: 215834 RVA: 0x0071F404 File Offset: 0x0071D604
		// (set) Token: 0x06034B1B RID: 215835 RVA: 0x0071F40C File Offset: 0x0071D60C
		public ITalkItemAutoPlayConfigT AutoPlayConfig { get; set; }

		// Token: 0x1700DC73 RID: 56435
		// (get) Token: 0x06034B1C RID: 215836 RVA: 0x0071F415 File Offset: 0x0071D615
		// (set) Token: 0x06034B1D RID: 215837 RVA: 0x0071F41D File Offset: 0x0071D61D
		public bool NoMouthAnim { get; set; }

		// Token: 0x1700DC74 RID: 56436
		// (get) Token: 0x06034B1E RID: 215838 RVA: 0x0071F426 File Offset: 0x0071D626
		// (set) Token: 0x06034B1F RID: 215839 RVA: 0x0071F42E File Offset: 0x0071D62E
		public float OtherIsTypingDuration { get; set; }

		// Token: 0x1700DC75 RID: 56437
		// (get) Token: 0x06034B20 RID: 215840 RVA: 0x0071F437 File Offset: 0x0071D637
		// (set) Token: 0x06034B21 RID: 215841 RVA: 0x0071F43F File Offset: 0x0071D63F
		public uint NullMask { get; set; }

		// Token: 0x06034B22 RID: 215842 RVA: 0x0071F448 File Offset: 0x0071D648
		public ITalkItemDialogT()
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
			this.Style = null;
			this.CameraMotion = null;
			this.AutoPlayConfig = null;
			this.NoMouthAnim = false;
			this.OtherIsTypingDuration = 0f;
			this.NullMask = 0U;
		}
	}
}
