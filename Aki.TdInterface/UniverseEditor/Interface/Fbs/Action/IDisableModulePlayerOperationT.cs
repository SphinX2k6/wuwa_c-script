using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C54 RID: 27732
	public class IDisableModulePlayerOperationT
	{
		// Token: 0x1700CB4E RID: 52046
		// (get) Token: 0x0602FC04 RID: 195588 RVA: 0x006810C9 File Offset: 0x0067F2C9
		// (set) Token: 0x0602FC05 RID: 195589 RVA: 0x006810D1 File Offset: 0x0067F2D1
		public EPlayerOperationType Type { get; set; }

		// Token: 0x1700CB4F RID: 52047
		// (get) Token: 0x0602FC06 RID: 195590 RVA: 0x006810DA File Offset: 0x0067F2DA
		// (set) Token: 0x0602FC07 RID: 195591 RVA: 0x006810E2 File Offset: 0x0067F2E2
		public TMoveOperationUnion MoveOption { get; set; }

		// Token: 0x1700CB50 RID: 52048
		// (get) Token: 0x0602FC08 RID: 195592 RVA: 0x006810EB File Offset: 0x0067F2EB
		// (set) Token: 0x0602FC09 RID: 195593 RVA: 0x006810F3 File Offset: 0x0067F2F3
		public TSkillOperationUnion SkillOption { get; set; }

		// Token: 0x1700CB51 RID: 52049
		// (get) Token: 0x0602FC0A RID: 195594 RVA: 0x006810FC File Offset: 0x0067F2FC
		// (set) Token: 0x0602FC0B RID: 195595 RVA: 0x00681104 File Offset: 0x0067F304
		public TCameraOperationUnion CameraOption { get; set; }

		// Token: 0x1700CB52 RID: 52050
		// (get) Token: 0x0602FC0C RID: 195596 RVA: 0x0068110D File Offset: 0x0067F30D
		// (set) Token: 0x0602FC0D RID: 195597 RVA: 0x00681115 File Offset: 0x0067F315
		public TUiOperationUnion UiOption { get; set; }

		// Token: 0x1700CB53 RID: 52051
		// (get) Token: 0x0602FC0E RID: 195598 RVA: 0x0068111E File Offset: 0x0067F31E
		// (set) Token: 0x0602FC0F RID: 195599 RVA: 0x00681126 File Offset: 0x0067F326
		public TSceneInteractionOperationUnion SceneInteractionOption { get; set; }

		// Token: 0x1700CB54 RID: 52052
		// (get) Token: 0x0602FC10 RID: 195600 RVA: 0x0068112F File Offset: 0x0067F32F
		// (set) Token: 0x0602FC11 RID: 195601 RVA: 0x00681137 File Offset: 0x0067F337
		public TPlayerAiControlUnion PlayerAiOption { get; set; }

		// Token: 0x0602FC12 RID: 195602 RVA: 0x00681140 File Offset: 0x0067F340
		public IDisableModulePlayerOperationT()
		{
			this.Type = EPlayerOperationType.EnableAll;
			this.MoveOption = null;
			this.SkillOption = null;
			this.CameraOption = null;
			this.UiOption = null;
			this.SceneInteractionOption = null;
			this.PlayerAiOption = null;
		}
	}
}
