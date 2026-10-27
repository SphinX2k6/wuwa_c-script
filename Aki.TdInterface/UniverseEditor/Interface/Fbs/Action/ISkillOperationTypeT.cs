using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007131 RID: 28977
	public class ISkillOperationTypeT
	{
		// Token: 0x1700D75D RID: 55133
		// (get) Token: 0x06033601 RID: 210433 RVA: 0x006ECA86 File Offset: 0x006EAC86
		// (set) Token: 0x06033602 RID: 210434 RVA: 0x006ECA8E File Offset: 0x006EAC8E
		public ESkillOperationType Type { get; set; }

		// Token: 0x06033603 RID: 210435 RVA: 0x006ECA97 File Offset: 0x006EAC97
		public ISkillOperationTypeT()
		{
			this.Type = ESkillOperationType.Enable;
		}
	}
}
