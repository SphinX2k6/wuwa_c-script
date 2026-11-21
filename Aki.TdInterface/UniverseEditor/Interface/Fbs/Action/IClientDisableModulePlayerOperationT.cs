using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A03 RID: 27139
	public class IClientDisableModulePlayerOperationT
	{
		// Token: 0x1700C794 RID: 51092
		// (get) Token: 0x0602E901 RID: 190721 RVA: 0x00659DAC File Offset: 0x00657FAC
		// (set) Token: 0x0602E902 RID: 190722 RVA: 0x00659DB4 File Offset: 0x00657FB4
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700C795 RID: 51093
		// (get) Token: 0x0602E903 RID: 190723 RVA: 0x00659DBD File Offset: 0x00657FBD
		// (set) Token: 0x0602E904 RID: 190724 RVA: 0x00659DC5 File Offset: 0x00657FC5
		public TMoveOperationUnion MoveOption { get; set; }

		// Token: 0x1700C796 RID: 51094
		// (get) Token: 0x0602E905 RID: 190725 RVA: 0x00659DCE File Offset: 0x00657FCE
		// (set) Token: 0x0602E906 RID: 190726 RVA: 0x00659DD6 File Offset: 0x00657FD6
		public TSkillOperationUnion SkillOption { get; set; }

		// Token: 0x1700C797 RID: 51095
		// (get) Token: 0x0602E907 RID: 190727 RVA: 0x00659DDF File Offset: 0x00657FDF
		// (set) Token: 0x0602E908 RID: 190728 RVA: 0x00659DE7 File Offset: 0x00657FE7
		public TCameraOperationUnion CameraOption { get; set; }

		// Token: 0x1700C798 RID: 51096
		// (get) Token: 0x0602E909 RID: 190729 RVA: 0x00659DF0 File Offset: 0x00657FF0
		// (set) Token: 0x0602E90A RID: 190730 RVA: 0x00659DF8 File Offset: 0x00657FF8
		public TUiOperationUnion UiOption { get; set; }

		// Token: 0x1700C799 RID: 51097
		// (get) Token: 0x0602E90B RID: 190731 RVA: 0x00659E01 File Offset: 0x00658001
		// (set) Token: 0x0602E90C RID: 190732 RVA: 0x00659E09 File Offset: 0x00658009
		public TSceneInteractionOperationUnion SceneInteractionOption { get; set; }

		// Token: 0x0602E90D RID: 190733 RVA: 0x00659E12 File Offset: 0x00658012
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
