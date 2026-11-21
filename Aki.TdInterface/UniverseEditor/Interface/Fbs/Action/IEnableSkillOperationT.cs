using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFF RID: 27903
	public class IEnableSkillOperationT
	{
		// Token: 0x1700CCC2 RID: 52418
		// (get) Token: 0x060301F6 RID: 197110 RVA: 0x0068BA46 File Offset: 0x00689C46
		// (set) Token: 0x060301F7 RID: 197111 RVA: 0x0068BA4E File Offset: 0x00689C4E
		public ESkillOperationType Type { get; set; }

		// Token: 0x060301F8 RID: 197112 RVA: 0x0068BA57 File Offset: 0x00689C57
		public IEnableSkillOperationT()
		{
			this.Type = ESkillOperationType.Enable;
		}
	}
}
