using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078FD RID: 30973
	public class ISkillOperationTypeT
	{
		// Token: 0x1700E340 RID: 58176
		// (get) Token: 0x060368A3 RID: 223395 RVA: 0x0074D092 File Offset: 0x0074B292
		// (set) Token: 0x060368A4 RID: 223396 RVA: 0x0074D09A File Offset: 0x0074B29A
		public ESkillOperationType Type { get; set; }

		// Token: 0x060368A5 RID: 223397 RVA: 0x0074D0A3 File Offset: 0x0074B2A3
		public ISkillOperationTypeT()
		{
			this.Type = ESkillOperationType.Enable;
		}
	}
}
