using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB4 RID: 16308
	public class IPreShowInfoT
	{
		// Token: 0x170071E5 RID: 29157
		// (get) Token: 0x06017512 RID: 95506 RVA: 0x0035C7E3 File Offset: 0x0035A9E3
		// (set) Token: 0x06017513 RID: 95507 RVA: 0x0035C7EB File Offset: 0x0035A9EB
		public IAccessQuestConditionT PreShowCondition { get; set; }

		// Token: 0x170071E6 RID: 29158
		// (get) Token: 0x06017514 RID: 95508 RVA: 0x0035C7F4 File Offset: 0x0035A9F4
		// (set) Token: 0x06017515 RID: 95509 RVA: 0x0035C7FC File Offset: 0x0035A9FC
		public string TidPreShowDesc { get; set; }

		// Token: 0x06017516 RID: 95510 RVA: 0x0035C805 File Offset: 0x0035AA05
		public IPreShowInfoT()
		{
			this.PreShowCondition = null;
			this.TidPreShowDesc = null;
		}
	}
}
