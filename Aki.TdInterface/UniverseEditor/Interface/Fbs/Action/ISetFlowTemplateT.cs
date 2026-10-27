using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF0 RID: 28656
	public class ISetFlowTemplateT
	{
		// Token: 0x1700D4D6 RID: 54486
		// (get) Token: 0x06032AEE RID: 207598 RVA: 0x006D6D93 File Offset: 0x006D4F93
		// (set) Token: 0x06032AEF RID: 207599 RVA: 0x006D6D9B File Offset: 0x006D4F9B
		public bool _Folded { get; set; }

		// Token: 0x1700D4D7 RID: 54487
		// (get) Token: 0x06032AF0 RID: 207600 RVA: 0x006D6DA4 File Offset: 0x006D4FA4
		// (set) Token: 0x06032AF1 RID: 207601 RVA: 0x006D6DAC File Offset: 0x006D4FAC
		public IFlowTemplateModeT TemplateMode { get; set; }

		// Token: 0x1700D4D8 RID: 54488
		// (get) Token: 0x06032AF2 RID: 207602 RVA: 0x006D6DB5 File Offset: 0x006D4FB5
		// (set) Token: 0x06032AF3 RID: 207603 RVA: 0x006D6DBD File Offset: 0x006D4FBD
		public IPosAndRotT TargetPos { get; set; }

		// Token: 0x1700D4D9 RID: 54489
		// (get) Token: 0x06032AF4 RID: 207604 RVA: 0x006D6DC6 File Offset: 0x006D4FC6
		// (set) Token: 0x06032AF5 RID: 207605 RVA: 0x006D6DCE File Offset: 0x006D4FCE
		public ISetCameraAnimT CameraAnim { get; set; }

		// Token: 0x1700D4DA RID: 54490
		// (get) Token: 0x06032AF6 RID: 207606 RVA: 0x006D6DD7 File Offset: 0x006D4FD7
		// (set) Token: 0x06032AF7 RID: 207607 RVA: 0x006D6DDF File Offset: 0x006D4FDF
		public IVectorInfoT CameraOffset { get; set; }

		// Token: 0x1700D4DB RID: 54491
		// (get) Token: 0x06032AF8 RID: 207608 RVA: 0x006D6DE8 File Offset: 0x006D4FE8
		// (set) Token: 0x06032AF9 RID: 207609 RVA: 0x006D6DF0 File Offset: 0x006D4FF0
		public IVectorInfoT CameraRotate { get; set; }

		// Token: 0x1700D4DC RID: 54492
		// (get) Token: 0x06032AFA RID: 207610 RVA: 0x006D6DF9 File Offset: 0x006D4FF9
		// (set) Token: 0x06032AFB RID: 207611 RVA: 0x006D6E01 File Offset: 0x006D5001
		public ICameraPosAndRotT CameraPosAndRot { get; set; }

		// Token: 0x1700D4DD RID: 54493
		// (get) Token: 0x06032AFC RID: 207612 RVA: 0x006D6E0A File Offset: 0x006D500A
		// (set) Token: 0x06032AFD RID: 207613 RVA: 0x006D6E12 File Offset: 0x006D5012
		public ICameraSettingT CameraSetting { get; set; }

		// Token: 0x1700D4DE RID: 54494
		// (get) Token: 0x06032AFE RID: 207614 RVA: 0x006D6E1B File Offset: 0x006D501B
		// (set) Token: 0x06032AFF RID: 207615 RVA: 0x006D6E23 File Offset: 0x006D5023
		public TShowTalkCameraMotionUnion CameraMotion { get; set; }

		// Token: 0x1700D4DF RID: 54495
		// (get) Token: 0x06032B00 RID: 207616 RVA: 0x006D6E2C File Offset: 0x006D502C
		// (set) Token: 0x06032B01 RID: 207617 RVA: 0x006D6E34 File Offset: 0x006D5034
		public IFlowTemplateBlurTransitionEffectT TransitionEffect { get; set; }

		// Token: 0x1700D4E0 RID: 54496
		// (get) Token: 0x06032B02 RID: 207618 RVA: 0x006D6E3D File Offset: 0x006D503D
		// (set) Token: 0x06032B03 RID: 207619 RVA: 0x006D6E45 File Offset: 0x006D5045
		public List<IFlowActorIndexDataT> ActorIndexArray { get; set; }

		// Token: 0x1700D4E1 RID: 54497
		// (get) Token: 0x06032B04 RID: 207620 RVA: 0x006D6E4E File Offset: 0x006D504E
		// (set) Token: 0x06032B05 RID: 207621 RVA: 0x006D6E56 File Offset: 0x006D5056
		public List<IFlowTemplateInitialLookAtT> InitialLookAtArray { get; set; }

		// Token: 0x1700D4E2 RID: 54498
		// (get) Token: 0x06032B06 RID: 207622 RVA: 0x006D6E5F File Offset: 0x006D505F
		// (set) Token: 0x06032B07 RID: 207623 RVA: 0x006D6E67 File Offset: 0x006D5067
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700D4E3 RID: 54499
		// (get) Token: 0x06032B08 RID: 207624 RVA: 0x006D6E70 File Offset: 0x006D5070
		// (set) Token: 0x06032B09 RID: 207625 RVA: 0x006D6E78 File Offset: 0x006D5078
		public float DelayTime { get; set; }

		// Token: 0x1700D4E4 RID: 54500
		// (get) Token: 0x06032B0A RID: 207626 RVA: 0x006D6E81 File Offset: 0x006D5081
		// (set) Token: 0x06032B0B RID: 207627 RVA: 0x006D6E89 File Offset: 0x006D5089
		public byte NullMask { get; set; }

		// Token: 0x06032B0C RID: 207628 RVA: 0x006D6E94 File Offset: 0x006D5094
		public ISetFlowTemplateT()
		{
			this._Folded = false;
			this.TemplateMode = null;
			this.TargetPos = null;
			this.CameraAnim = null;
			this.CameraOffset = null;
			this.CameraRotate = null;
			this.CameraPosAndRot = null;
			this.CameraSetting = null;
			this.CameraMotion = null;
			this.TransitionEffect = null;
			this.ActorIndexArray = null;
			this.InitialLookAtArray = null;
			this.ActorVisibilityArray = null;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
