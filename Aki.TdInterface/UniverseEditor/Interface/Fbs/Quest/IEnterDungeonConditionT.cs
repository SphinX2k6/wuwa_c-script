using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004236 RID: 16950
	public class IEnterDungeonConditionT
	{
		// Token: 0x1700738E RID: 29582
		// (get) Token: 0x06017946 RID: 96582 RVA: 0x0035D519 File Offset: 0x0035B719
		// (set) Token: 0x06017947 RID: 96583 RVA: 0x0035D521 File Offset: 0x0035B721
		public EChildQuest Type { get; set; }

		// Token: 0x1700738F RID: 29583
		// (get) Token: 0x06017948 RID: 96584 RVA: 0x0035D52A File Offset: 0x0035B72A
		// (set) Token: 0x06017949 RID: 96585 RVA: 0x0035D532 File Offset: 0x0035B732
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007390 RID: 29584
		// (get) Token: 0x0601794A RID: 96586 RVA: 0x0035D53B File Offset: 0x0035B73B
		// (set) Token: 0x0601794B RID: 96587 RVA: 0x0035D543 File Offset: 0x0035B743
		public TEnterDungeonUnion EnterType { get; set; }

		// Token: 0x0601794C RID: 96588 RVA: 0x0035D54C File Offset: 0x0035B74C
		public IEnterDungeonConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EnterType = null;
		}
	}
}
