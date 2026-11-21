using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B9 RID: 30649
	public class ISetFlowTemplateT
	{
		// Token: 0x1700E0AA RID: 57514
		// (get) Token: 0x06035D54 RID: 220500 RVA: 0x007369D7 File Offset: 0x00734BD7
		// (set) Token: 0x06035D55 RID: 220501 RVA: 0x007369DF File Offset: 0x00734BDF
		public bool _Folded { get; set; }

		// Token: 0x1700E0AB RID: 57515
		// (get) Token: 0x06035D56 RID: 220502 RVA: 0x007369E8 File Offset: 0x00734BE8
		// (set) Token: 0x06035D57 RID: 220503 RVA: 0x007369F0 File Offset: 0x00734BF0
		public IFlowTemplateModeT TemplateMode { get; set; }

		// Token: 0x1700E0AC RID: 57516
		// (get) Token: 0x06035D58 RID: 220504 RVA: 0x007369F9 File Offset: 0x00734BF9
		// (set) Token: 0x06035D59 RID: 220505 RVA: 0x00736A01 File Offset: 0x00734C01
		public IPosAndRotT TargetPos { get; set; }

		// Token: 0x1700E0AD RID: 57517
		// (get) Token: 0x06035D5A RID: 220506 RVA: 0x00736A0A File Offset: 0x00734C0A
		// (set) Token: 0x06035D5B RID: 220507 RVA: 0x00736A12 File Offset: 0x00734C12
		public ISetCameraAnimT CameraAnim { get; set; }

		// Token: 0x1700E0AE RID: 57518
		// (get) Token: 0x06035D5C RID: 220508 RVA: 0x00736A1B File Offset: 0x00734C1B
		// (set) Token: 0x06035D5D RID: 220509 RVA: 0x00736A23 File Offset: 0x00734C23
		public IVectorInfoT CameraOffset { get; set; }

		// Token: 0x1700E0AF RID: 57519
		// (get) Token: 0x06035D5E RID: 220510 RVA: 0x00736A2C File Offset: 0x00734C2C
		// (set) Token: 0x06035D5F RID: 220511 RVA: 0x00736A34 File Offset: 0x00734C34
		public IVectorInfoT CameraRotate { get; set; }

		// Token: 0x1700E0B0 RID: 57520
		// (get) Token: 0x06035D60 RID: 220512 RVA: 0x00736A3D File Offset: 0x00734C3D
		// (set) Token: 0x06035D61 RID: 220513 RVA: 0x00736A45 File Offset: 0x00734C45
		public ICameraPosAndRotT CameraPosAndRot { get; set; }

		// Token: 0x1700E0B1 RID: 57521
		// (get) Token: 0x06035D62 RID: 220514 RVA: 0x00736A4E File Offset: 0x00734C4E
		// (set) Token: 0x06035D63 RID: 220515 RVA: 0x00736A56 File Offset: 0x00734C56
		public ICameraSettingT CameraSetting { get; set; }

		// Token: 0x1700E0B2 RID: 57522
		// (get) Token: 0x06035D64 RID: 220516 RVA: 0x00736A5F File Offset: 0x00734C5F
		// (set) Token: 0x06035D65 RID: 220517 RVA: 0x00736A67 File Offset: 0x00734C67
		public TShowTalkCameraMotionUnion CameraMotion { get; set; }

		// Token: 0x1700E0B3 RID: 57523
		// (get) Token: 0x06035D66 RID: 220518 RVA: 0x00736A70 File Offset: 0x00734C70
		// (set) Token: 0x06035D67 RID: 220519 RVA: 0x00736A78 File Offset: 0x00734C78
		public IFlowTemplateBlurTransitionEffectT TransitionEffect { get; set; }

		// Token: 0x1700E0B4 RID: 57524
		// (get) Token: 0x06035D68 RID: 220520 RVA: 0x00736A81 File Offset: 0x00734C81
		// (set) Token: 0x06035D69 RID: 220521 RVA: 0x00736A89 File Offset: 0x00734C89
		public List<IFlowActorIndexDataT> ActorIndexArray { get; set; }

		// Token: 0x1700E0B5 RID: 57525
		// (get) Token: 0x06035D6A RID: 220522 RVA: 0x00736A92 File Offset: 0x00734C92
		// (set) Token: 0x06035D6B RID: 220523 RVA: 0x00736A9A File Offset: 0x00734C9A
		public List<IFlowTemplateInitialLookAtT> InitialLookAtArray { get; set; }

		// Token: 0x1700E0B6 RID: 57526
		// (get) Token: 0x06035D6C RID: 220524 RVA: 0x00736AA3 File Offset: 0x00734CA3
		// (set) Token: 0x06035D6D RID: 220525 RVA: 0x00736AAB File Offset: 0x00734CAB
		public List<IActorVisibilityT> ActorVisibilityArray { get; set; }

		// Token: 0x1700E0B7 RID: 57527
		// (get) Token: 0x06035D6E RID: 220526 RVA: 0x00736AB4 File Offset: 0x00734CB4
		// (set) Token: 0x06035D6F RID: 220527 RVA: 0x00736ABC File Offset: 0x00734CBC
		public float DelayTime { get; set; }

		// Token: 0x1700E0B8 RID: 57528
		// (get) Token: 0x06035D70 RID: 220528 RVA: 0x00736AC5 File Offset: 0x00734CC5
		// (set) Token: 0x06035D71 RID: 220529 RVA: 0x00736ACD File Offset: 0x00734CCD
		public byte NullMask { get; set; }

		// Token: 0x06035D72 RID: 220530 RVA: 0x00736AD8 File Offset: 0x00734CD8
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
