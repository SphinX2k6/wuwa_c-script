using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006392 RID: 25490
	public class IClientDisableModulePlayerOperationT
	{
		// Token: 0x1700BE10 RID: 48656
		// (get) Token: 0x0602C19F RID: 180639 RVA: 0x0060ED74 File Offset: 0x0060CF74
		// (set) Token: 0x0602C1A0 RID: 180640 RVA: 0x0060ED7C File Offset: 0x0060CF7C
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700BE11 RID: 48657
		// (get) Token: 0x0602C1A1 RID: 180641 RVA: 0x0060ED85 File Offset: 0x0060CF85
		// (set) Token: 0x0602C1A2 RID: 180642 RVA: 0x0060ED8D File Offset: 0x0060CF8D
		public TMoveOperationUnion MoveOption { get; set; }

		// Token: 0x1700BE12 RID: 48658
		// (get) Token: 0x0602C1A3 RID: 180643 RVA: 0x0060ED96 File Offset: 0x0060CF96
		// (set) Token: 0x0602C1A4 RID: 180644 RVA: 0x0060ED9E File Offset: 0x0060CF9E
		public TSkillOperationUnion SkillOption { get; set; }

		// Token: 0x1700BE13 RID: 48659
		// (get) Token: 0x0602C1A5 RID: 180645 RVA: 0x0060EDA7 File Offset: 0x0060CFA7
		// (set) Token: 0x0602C1A6 RID: 180646 RVA: 0x0060EDAF File Offset: 0x0060CFAF
		public TCameraOperationUnion CameraOption { get; set; }

		// Token: 0x1700BE14 RID: 48660
		// (get) Token: 0x0602C1A7 RID: 180647 RVA: 0x0060EDB8 File Offset: 0x0060CFB8
		// (set) Token: 0x0602C1A8 RID: 180648 RVA: 0x0060EDC0 File Offset: 0x0060CFC0
		public TUiOperationUnion UiOption { get; set; }

		// Token: 0x1700BE15 RID: 48661
		// (get) Token: 0x0602C1A9 RID: 180649 RVA: 0x0060EDC9 File Offset: 0x0060CFC9
		// (set) Token: 0x0602C1AA RID: 180650 RVA: 0x0060EDD1 File Offset: 0x0060CFD1
		public TSceneInteractionOperationUnion SceneInteractionOption { get; set; }

		// Token: 0x0602C1AB RID: 180651 RVA: 0x0060EDDA File Offset: 0x0060CFDA
		public IClientDisableModulePlayerOperationT()
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
