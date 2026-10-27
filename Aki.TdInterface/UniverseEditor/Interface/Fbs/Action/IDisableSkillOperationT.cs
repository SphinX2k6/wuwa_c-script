using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F5 RID: 26101
	public class IDisableSkillOperationT
	{
		// Token: 0x1700C1EF RID: 49647
		// (get) Token: 0x0602D4F9 RID: 185593 RVA: 0x00635C9C File Offset: 0x00633E9C
		// (set) Token: 0x0602D4FA RID: 185594 RVA: 0x00635CA4 File Offset: 0x00633EA4
		public ESkillOperationType Type { get; set; }

		// Token: 0x1700C1F0 RID: 49648
		// (get) Token: 0x0602D4FB RID: 185595 RVA: 0x00635CAD File Offset: 0x00633EAD
		// (set) Token: 0x0602D4FC RID: 185596 RVA: 0x00635CB5 File Offset: 0x00633EB5
		public EDisplayModeInSkillOp DisplayMode { get; set; }

		// Token: 0x1700C1F1 RID: 49649
		// (get) Token: 0x0602D4FD RID: 185597 RVA: 0x00635CBE File Offset: 0x00633EBE
		// (set) Token: 0x0602D4FE RID: 185598 RVA: 0x00635CC6 File Offset: 0x00633EC6
		public bool DisableSkillWheel { get; set; }

		// Token: 0x1700C1F2 RID: 49650
		// (get) Token: 0x0602D4FF RID: 185599 RVA: 0x00635CCF File Offset: 0x00633ECF
		// (set) Token: 0x0602D500 RID: 185600 RVA: 0x00635CD7 File Offset: 0x00633ED7
		public byte NullMask { get; set; }

		// Token: 0x0602D501 RID: 185601 RVA: 0x00635CE0 File Offset: 0x00633EE0
		public IDisableSkillOperationT()
		{
			this.Type = ESkillOperationType.Enable;
			this.DisplayMode = EDisplayModeInSkillOp.Ashen;
			this.DisableSkillWheel = false;
			this.NullMask = 0;
		}
	}
}
