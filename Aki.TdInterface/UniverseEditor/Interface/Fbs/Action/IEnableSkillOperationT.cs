using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006685 RID: 26245
	public class IEnableSkillOperationT
	{
		// Token: 0x1700C311 RID: 49937
		// (get) Token: 0x0602D9D9 RID: 186841 RVA: 0x0063E792 File Offset: 0x0063C992
		// (set) Token: 0x0602D9DA RID: 186842 RVA: 0x0063E79A File Offset: 0x0063C99A
		public ESkillOperationType Type { get; set; }

		// Token: 0x0602D9DB RID: 186843 RVA: 0x0063E7A3 File Offset: 0x0063C9A3
		public IEnableSkillOperationT()
		{
			this.Type = ESkillOperationType.Enable;
		}
	}
}
