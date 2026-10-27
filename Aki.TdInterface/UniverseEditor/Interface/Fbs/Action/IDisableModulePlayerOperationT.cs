using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065E9 RID: 26089
	public class IDisableModulePlayerOperationT
	{
		// Token: 0x1700C1B7 RID: 49591
		// (get) Token: 0x0602D459 RID: 185433 RVA: 0x006348A8 File Offset: 0x00632AA8
		// (set) Token: 0x0602D45A RID: 185434 RVA: 0x006348B0 File Offset: 0x00632AB0
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700C1B8 RID: 49592
		// (get) Token: 0x0602D45B RID: 185435 RVA: 0x006348B9 File Offset: 0x00632AB9
		// (set) Token: 0x0602D45C RID: 185436 RVA: 0x006348C1 File Offset: 0x00632AC1
		public TMoveOperationUnion MoveOption { get; set; }

		// Token: 0x1700C1B9 RID: 49593
		// (get) Token: 0x0602D45D RID: 185437 RVA: 0x006348CA File Offset: 0x00632ACA
		// (set) Token: 0x0602D45E RID: 185438 RVA: 0x006348D2 File Offset: 0x00632AD2
		public TSkillOperationUnion SkillOption { get; set; }

		// Token: 0x1700C1BA RID: 49594
		// (get) Token: 0x0602D45F RID: 185439 RVA: 0x006348DB File Offset: 0x00632ADB
		// (set) Token: 0x0602D460 RID: 185440 RVA: 0x006348E3 File Offset: 0x00632AE3
		public TCameraOperationUnion CameraOption { get; set; }

		// Token: 0x1700C1BB RID: 49595
		// (get) Token: 0x0602D461 RID: 185441 RVA: 0x006348EC File Offset: 0x00632AEC
		// (set) Token: 0x0602D462 RID: 185442 RVA: 0x006348F4 File Offset: 0x00632AF4
		public TUiOperationUnion UiOption { get; set; }

		// Token: 0x1700C1BC RID: 49596
		// (get) Token: 0x0602D463 RID: 185443 RVA: 0x006348FD File Offset: 0x00632AFD
		// (set) Token: 0x0602D464 RID: 185444 RVA: 0x00634905 File Offset: 0x00632B05
		public TSceneInteractionOperationUnion SceneInteractionOption { get; set; }

		// Token: 0x0602D465 RID: 185445 RVA: 0x0063490E File Offset: 0x00632B0E
		public IDisableModulePlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
			this.MoveOption = null;
			this.SkillOption = null;
			this.CameraOption = null;
			this.UiOption = null;
			this.SceneInteractionOption = null;
		}
	}
}
